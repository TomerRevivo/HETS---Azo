using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HETS1Design
{
    //This class will contain all the business logic for Main screen that is NOT an event type. 
    //Many of these are simple button logic and will not be commented on.

    //[ExcludeFromCodeCoverage] //Was used in the script test.

    public class MainScreenLogic
    {
        public static bool inputErrorIsShown = false; // Indicator for faulty input file message. *****
        public static string testedInputPath = ""; // Indicator for the input path after incorrect submmistion of input file. *****

        public static List<string> listOfCommands;
        public static string IDnumber;
        public static int indexOfIDnumber;
        public static string name;


        public static void OnMainScreenLoad(NumericUpDown menuCodeWeight, NumericUpDown menuExeWeight, NumericUpDown menuResultsWeight, NumericUpDown menuCommandsWeight)
        {
            menuCodeWeight.Enabled = false;
            menuExeWeight.Enabled = false;
            menuResultsWeight.Enabled = false;
            menuCommandsWeight.Enabled = false;
        }

        public static string FormValidate(TextBox txtArchivePath, TextBox txtInputPath, TextBox txtOutputPath)
        {
            if (txtArchivePath.Text == "")
                return "Choose archive file to continue!";
            if (txtInputPath.Text == "")
                return "Choose input test case file to continue!";
            if (txtOutputPath.Text == "")
                return "Choose output test case file to continue!";
            return "OK";
        }

        //Code for limiting the overall grade sum to 100;
        public static void LimitWeightsChange(NumericUpDown menuCodeWeight, NumericUpDown menuExeWeight, NumericUpDown menuResultsWeight, NumericUpDown menuCommandsWeight)
        {
            menuCodeWeight.Maximum = 100 - (menuExeWeight.Value + menuResultsWeight.Value + menuCommandsWeight.Value);
            menuExeWeight.Maximum = 100 - (menuCodeWeight.Value + menuResultsWeight.Value + menuCommandsWeight.Value);
            menuResultsWeight.Maximum = 100 - (menuExeWeight.Value + menuCodeWeight.Value + menuCommandsWeight.Value);
            menuCommandsWeight.Maximum = 100 - (menuCodeWeight.Value + menuExeWeight.Value + menuResultsWeight.Value);
            Submissions.exeWeight = (int)menuExeWeight.Value;
            Submissions.codeWeight = (int)menuCodeWeight.Value;
            Submissions.correctResultsWeight = (int)menuResultsWeight.Value;
            Submissions.CommandWeight = (int)menuCommandsWeight.Value;
        }

        //Code for activating grading or not.
        public static void EnableGradingCheckedChange(CheckBox checkBoxEnableGrading, NumericUpDown menuCodeWeight, NumericUpDown menuExeWeight, NumericUpDown menuResultsWeight, NumericUpDown menuCommandsWeight)
        {
            if (checkBoxEnableGrading.Checked)
            {
                menuCodeWeight.Enabled = true;
                menuExeWeight.Enabled = true;
                menuResultsWeight.Enabled = true;
                menuCommandsWeight.Enabled = true;


                Submissions.exeWeight = (int)menuExeWeight.Value;
                Submissions.codeWeight = (int)menuCodeWeight.Value;
                Submissions.correctResultsWeight = (int)menuResultsWeight.Value;
                Submissions.CommandWeight = (int)menuCommandsWeight.Value;
            }
            else
            {
                menuCodeWeight.Enabled = false;
                menuExeWeight.Enabled = false;
                menuResultsWeight.Enabled = false;
                menuCommandsWeight.Enabled = false;
                Submissions.exeWeight = -1;
                Submissions.codeWeight = -1;
                Submissions.correctResultsWeight = -1;
                Submissions.CommandWeight = -1;
            }

        }

        public static void CompileHelper(Button btnCompile, TextBox txtArchivePath, TextBox txtInputPath, TextBox txtOutputPath)
        {
            string validateText = FormValidate(txtArchivePath, txtInputPath, txtOutputPath);
            if (validateText.CompareTo("OK") != 0)
                MessageBox.Show(validateText, "Error");
            else
            {
                if (Submissions.ActivateCompilation(btnCompile)) //Both compile and check that it finished compiling. (Send button for text updates)
                    btnCompile.Text = "Compile Programs"; //Return to the original text.
            }


        }

        public static void RunHelper(Button btnRunProgram, TextBox txtArchivePath, TextBox txtInputPath, TextBox txtOutputPath, Button btnResults)
        {
            string validateText = FormValidate(txtArchivePath, txtInputPath, txtOutputPath);
            if (validateText.CompareTo("OK") != 0)
                MessageBox.Show(validateText, "Error");
            else
            {
                if (Submissions.ActivateExecution(btnRunProgram)) //Both run and check that it finished running. (Send button for text updates).
                    btnRunProgram.Text = "Run Programs"; //Return to the original text.

                btnResults.Enabled = true;
            }
        }

        public static void Option64BitCompilerChange()
        {
            CodeChecker.use32bitCompiler = false; //Default is 64
        }

        public static void Option32BitCompilerChange()
        {
            CodeChecker.use32bitCompiler = true;
        }

        public static void TimeoutValueChange(NumericUpDown timeoutNumUpDown)
        {
            CodeChecker.timeoutSeconds = (int)timeoutNumUpDown.Value;
        }

        public static void PrepareFileDialog(string conditions, OpenFileDialog openDialog)
        {
            openDialog.Filter = conditions;
            openDialog.ShowDialog();
        }

        public static void OpenArchiveFile(OpenFileDialog openArchiveDialog, TextBox txtArchivePath, Button btnResults, Button btnDetailedResults)
        {
            try
            {
                string zipFile = openArchiveDialog.FileName;
                txtArchivePath.Text = zipFile;
                Submissions.ResetSubmissions();
                btnResults.Enabled = false;
                btnDetailedResults.Enabled = false;
                ZipArchiveHandler.GetSubmissionData(zipFile, true); //Extract submissions data.

            }
            catch (Exception ex)
            {
                txtArchivePath.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        //The small scale guide we have.
        public static void DisplayGuideHelpBox()
        {
            MessageBox.Show("*I/O files must have symmetry." +
                "\r\n\r\n*Choose Input=Output (Test case must be titled __[TC] in the input file)" +
                "or Input!=Output (__[TNC] instead). There are example files to follow in the " +
                " examples folder." +
                "\r\n\r\n*If you wish to have a Boundary test for one input, place __[Bound] Number1 Number2" +
                " where you would place the original output." +
                "\r\n\r\n*For the same but with Equivalence Partitioning use __[EP] Number1 Number2 instead." +
                "\r\n*In both cases Number2 needs to be higher in value than Number1." +
                "\r\n\r\n*Spaces and New Lines (enter) DO matter! No matter if you don't see them, make sure" +
                "you write your input/output files correctly (and tell your students to mind it too!) ");
        }

        public static void OpenInputFile(OpenFileDialog openInputDialog, TextBox txtInputPath, TextBox txtOutputPath, Button btnAddTestCase, Button btnSaveIO)
        {
            string inputTextFile = openInputDialog.FileName;
            txtInputPath.Text = openInputDialog.FileName;

            string inputText = File.ReadAllText(txtInputPath.Text); // Holds the txt file *****

            try
            {
                if (txtInputPath.Text != "" && txtOutputPath.Text != "")
                {
                    TestCases.ResetTestCases();
                    TestCases.ExtractTestCasesFromText(txtInputPath.Text, txtOutputPath.Text);
                    btnAddTestCase.Enabled = true;
                    btnSaveIO.Enabled = true;
                }
                if (txtInputPath.Text != "" && txtOutputPath.Text == "") // if the user enter first the input file *****
                {
                    if (TestCases.CountTestCases(inputText) == 0) // if there is no test cases in the input file *****
                    {
                        MessageBox.Show("Error. There are no test cases in the text file (TC/TNC)"); // shows error message about the incorrect file *****
                        inputErrorIsShown = true;// Test indicator for showing the messeging box. *****
                        txtInputPath.Text = ""; // clear the input file path (aka do not get the incorrect input) *****
                        testedInputPath = txtInputPath.Text; // Test indicator for the input path box. *****
                        btnAddTestCase.Enabled = true; // Re-enabling the adding button. *****
                        btnSaveIO.Enabled = true; // Re-enabling the saving option. *****
                    }
                }
            }

            catch (Exception ex)
            {
                txtInputPath.Text = "";
                txtOutputPath.Text = "";
                MessageBox.Show(ex.Message);
                btnAddTestCase.Enabled = false;
                btnSaveIO.Enabled = false;
            }
        }

        public static void OpenOutputFile(OpenFileDialog openOutputDialog, TextBox txtOutputPath, TextBox txtInputPath, Button btnAddTestCase, Button btnSaveIO)
        {
            string outputTextFile = openOutputDialog.FileName;
            txtOutputPath.Text = openOutputDialog.FileName;

            try
            {

                if (txtInputPath.Text != "" && txtOutputPath.Text != "")
                {
                    TestCases.ResetTestCases();
                    TestCases.ExtractTestCasesFromText(txtInputPath.Text, txtOutputPath.Text);
                    btnAddTestCase.Enabled = true;
                    btnSaveIO.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                txtInputPath.Text = "";
                txtOutputPath.Text = "";
                MessageBox.Show(ex.Message);
                btnAddTestCase.Enabled = false;
                btnSaveIO.Enabled = false;
            }
        }



        public static void OnShowResults(DataGridView dataGridResults, Button btnDetailedResults)//TextBox textBoxTEMPORARY)
        {
            dataGridResults.DataSource = Submissions.GetResultsTable();
            dataGridResults.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnDetailedResults.Enabled = true;
        }

        public static void OnSaveDetailedResults(TextBox txtArchivePath)
        {
            Submissions.SaveDetailedResults(txtArchivePath.Text);
        }

        public static void OnExportToCSV(SaveFileDialog saveCSVFile, DataGridView dataGridResults)
        {
            saveCSVFile.Filter = "CSV (*.csv)|*.csv";
            saveCSVFile.FileName = "Output.csv";
            if (saveCSVFile.ShowDialog() == DialogResult.OK)
            {
                var sb = new StringBuilder();

                var headers = dataGridResults.Columns.Cast<DataGridViewColumn>();
                sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                foreach (DataGridViewRow row in dataGridResults.Rows)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                }
                File.WriteAllText(saveCSVFile.FileName, sb.ToString(), Encoding.UTF8);
            }
        }

        public static void OnButtonSaveIOClick(TextBox txtInputPath, TextBox txtOutputPath)
        {
            File.WriteAllText(Path.GetDirectoryName(txtInputPath.Text) + @"\HETS1-Azo Generated INPUT.txt", TestCases.inputText);
            File.WriteAllText(Path.GetDirectoryName(txtOutputPath.Text) + @"\HETS1-Azo Generated OUTPUT.txt", TestCases.outputText);
        }

        public static void OnButtonAddTestCaseClick(RadioButton radioTC, RadioButton radioTNC, TextBox txtInputAppend, TextBox txtOutputAppend)
        {
            if (radioTC.Checked)
                TestCases.OnAddTestCase(txtInputAppend.Text, txtOutputAppend.Text, true);
            if (radioTNC.Checked)
                TestCases.OnAddTestCase(txtInputAppend.Text, txtOutputAppend.Text, false);


            if (txtInputAppend.Text != "" && txtOutputAppend.Text != "")
            {
                MessageBox.Show("Added a new test case!\r\n" +
                   "In order to save the new array of test cases (Both input and output files)\r\n" +
                   "please choose the Save new I/O options. \r\nMake sure you already have chosen input/output " +
                   "files since they will be saved in the same directory as your original files.");
            }
        }

        public static void OnCheckCodeRadioChange(Button btnCompile)
        {
            Submissions.checkCode = true;
            Submissions.checkExe = false;
            btnCompile.Enabled = true;
        }

        public static void OnCheckExeRadioChange(Button btnCompile)
        {
            Submissions.checkCode = false;
            Submissions.checkExe = true;
            btnCompile.Enabled = false;
        }

        public static void OnCheckBothRadioChange(Button btnCompile)
        {
            Submissions.checkCode = true;
            Submissions.checkExe = true;
            btnCompile.Enabled = true;
        }

        //Code for activating grading or not.

      


     
    }
}
