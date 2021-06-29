using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;



namespace HETS1Design
{
    [TestClass]
    public class MainScreenLogicTest
    {
        #region Many Objects
        TextBox txtArchivePath;
        Button btnBrowseArchive;
        Button btnSaveIO;
        RadioButton radioTNC;
        RadioButton radioTC;
        TextBox txtOutputAppend;
        TextBox txtInputAppend;
        Button btnAddTestCase;
        TextBox txtOutputPath;
        Button btnBrowseOutput;
        Button btnBrowseInput;
        TextBox txtInputPath;
        GroupBox groupBox3;
        RadioButton radioBtnExecutable;
        RadioButton radioBtnCode;
        RadioButton radioBtnBothExeAndCode;
        RadioButton radioButton32BitCompiler;
        RadioButton radioButton64BitCompiler;
        Button btnCompile;
        Button btnResults;
        TextBox textBoxTEMPORARY;
        Button btnExportCSV;
        OpenFileDialog openArchiveDialog;
        OpenFileDialog openInputDialog;
        OpenFileDialog openOutputDialog;
        SaveFileDialog saveCSVFile;
        CheckBox checkBoxEnableGrading;
        NumericUpDown menuResultsWeight;
        NumericUpDown menuExeWeight;
        NumericUpDown menuCodeWeight;
        NumericUpDown menuCommandsWeight;
        NumericUpDown timeoutNumUpDown;
        Button btnRunProgram;
        Button btnDetailedResults;
        DataGridView dataGridResults;
        #endregion

        [TestInitialize]
        public void TestInit()
        {
            #region Many Inits
            txtArchivePath = new System.Windows.Forms.TextBox();
            btnBrowseArchive = new System.Windows.Forms.Button();
            btnSaveIO = new System.Windows.Forms.Button();
            radioTNC = new System.Windows.Forms.RadioButton();
            radioTC = new System.Windows.Forms.RadioButton();
            txtOutputAppend = new System.Windows.Forms.TextBox();
            txtInputAppend = new System.Windows.Forms.TextBox();
            btnAddTestCase = new System.Windows.Forms.Button();
            txtOutputPath = new System.Windows.Forms.TextBox();
            btnBrowseOutput = new System.Windows.Forms.Button();
            btnBrowseInput = new System.Windows.Forms.Button();
            txtInputPath = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            radioBtnExecutable = new System.Windows.Forms.RadioButton();
            radioBtnCode = new System.Windows.Forms.RadioButton();
            radioBtnBothExeAndCode = new System.Windows.Forms.RadioButton();
            radioButton32BitCompiler = new System.Windows.Forms.RadioButton();
            radioButton64BitCompiler = new System.Windows.Forms.RadioButton();
            btnCompile = new System.Windows.Forms.Button();
            btnResults = new System.Windows.Forms.Button();
            textBoxTEMPORARY = new System.Windows.Forms.TextBox();
            btnExportCSV = new System.Windows.Forms.Button();
            openArchiveDialog = new System.Windows.Forms.OpenFileDialog();
            openInputDialog = new System.Windows.Forms.OpenFileDialog();
            openOutputDialog = new System.Windows.Forms.OpenFileDialog();
            saveCSVFile = new System.Windows.Forms.SaveFileDialog();
            checkBoxEnableGrading = new System.Windows.Forms.CheckBox();
            menuResultsWeight = new System.Windows.Forms.NumericUpDown();
            menuExeWeight = new System.Windows.Forms.NumericUpDown();
            menuCodeWeight = new System.Windows.Forms.NumericUpDown();
            menuCommandsWeight = new System.Windows.Forms.NumericUpDown();
            timeoutNumUpDown = new System.Windows.Forms.NumericUpDown();
            btnRunProgram = new System.Windows.Forms.Button();
            btnDetailedResults = new System.Windows.Forms.Button();
            dataGridResults = new System.Windows.Forms.DataGridView();
            #endregion
        }

        [TestMethod]
        public void OnMainScreenLoadTest()
        {
            MainScreenLogic.OnMainScreenLoad(menuCodeWeight, menuExeWeight, menuResultsWeight, menuCommandsWeight);
            Assert.IsFalse(menuResultsWeight.Enabled);
            Assert.IsFalse(menuExeWeight.Enabled);
            Assert.IsFalse(menuResultsWeight.Enabled);
            Assert.IsFalse(menuCommandsWeight.Enabled);
        }

        [TestMethod]
        public void FormValidateTest()
        {
            //TODO
            txtArchivePath.Text = "";
            txtInputPath.Text = "";
            txtOutputPath.Text = "";
            Assert.AreEqual("Choose archive file to continue!", MainScreenLogic.FormValidate(txtArchivePath, txtInputPath, txtOutputPath));

            txtArchivePath.Text = "fsdgsdfghdf";
            txtInputPath.Text = "";
            txtOutputPath.Text = "";
            Assert.AreEqual("Choose input test case file to continue!", MainScreenLogic.FormValidate(txtArchivePath, txtInputPath, txtOutputPath));

            txtArchivePath.Text = "fsdgsdfghdf";
            txtInputPath.Text = "ghsjhfgsydtgrfhj";
            txtOutputPath.Text = "";
            Assert.AreEqual("Choose output test case file to continue!", MainScreenLogic.FormValidate(txtArchivePath, txtInputPath, txtOutputPath));

            txtArchivePath.Text = "fsdgsdfghdf";
            txtInputPath.Text = "ghsjhfgsydtgrfhj";
            txtOutputPath.Text = "hejwhfdkhtfsejhflsldjfjaslk";
            Assert.AreEqual("OK", MainScreenLogic.FormValidate(txtArchivePath, txtInputPath, txtOutputPath));
        }

        [TestMethod]
        public void OnButtonAddTestCaseClickTest()
        {
            radioTC.Checked = true;
            radioTNC.Checked = false;

            //  MainScreenLogic.OnButtonAddTestCaseClick(radioTC, radioTNC, input, output);
        }

        [TestMethod]
        public void LimitWeightsChangeTest()
        {
            menuCodeWeight.Value = 100;
            // menuCommandsWeight.Value = 100; 
            MainScreenLogic.LimitWeightsChange(menuCodeWeight, menuExeWeight, menuResultsWeight, menuCommandsWeight);
            try
            {
                menuExeWeight.Value = 100;
            }
            catch
            {
                // Nothing(Dont set menuExeWeight)
            }
            MainScreenLogic.LimitWeightsChange(menuCodeWeight, menuExeWeight, menuResultsWeight, menuCommandsWeight);
            Assert.AreEqual(100, menuCodeWeight.Value);
            Assert.AreEqual(0, menuCommandsWeight.Value);
            Assert.AreEqual(0, menuExeWeight.Value);
        }

        [TestMethod]
        public void EnableGradingCheckedChangeTest()
        {
            checkBoxEnableGrading.Checked = true;
            MainScreenLogic.EnableGradingCheckedChange(checkBoxEnableGrading, menuCodeWeight, menuExeWeight, menuResultsWeight, menuCommandsWeight);
            checkBoxEnableGrading.Checked = false;
            MainScreenLogic.EnableGradingCheckedChange(checkBoxEnableGrading, menuCodeWeight, menuExeWeight, menuResultsWeight, menuCommandsWeight);
        }


        [TestMethod]
        public void Option64BitCompilerChangeTest()
        {
            CodeChecker.use32bitCompiler = false;
            MainScreenLogic.Option64BitCompilerChange();
        }

        [TestMethod]
        public void Option32BitCompilerChangeTest()
        {
            CodeChecker.use32bitCompiler = true;
            MainScreenLogic.Option32BitCompilerChange();
        }


        [TestMethod]
        public void OnCheckCodeRadioChange_Success()
        {
            MainScreenLogic.OnCheckCodeRadioChange(btnCompile);
            Assert.IsTrue(Submissions.checkCode);
            Assert.IsFalse(Submissions.checkExe);
            Assert.IsTrue(btnCompile.Enabled);
        }

        [TestMethod]
        public void OnCheckExeRadioChange_Success()
        {
            MainScreenLogic.OnCheckExeRadioChange(btnCompile);
            Assert.IsFalse(Submissions.checkCode);
            Assert.IsTrue(Submissions.checkExe);
            Assert.IsFalse(btnCompile.Enabled);
        }

        [TestMethod]
        public void OnCheckBothRadioChange_Success()
        {
            MainScreenLogic.OnCheckBothRadioChange(btnCompile);
            Assert.IsTrue(Submissions.checkCode);
            Assert.IsTrue(Submissions.checkExe);
            Assert.IsTrue(btnCompile.Enabled);
        }

        [TestMethod]
        public void OpenOutputFileTest()
        {
            openOutputDialog.FileName = @"..\..\..\Assets\Test Required FIles\MainScreenLogicTest\OpenOutputFileFuncTest.txt";
            txtOutputPath.Text = openOutputDialog.FileName;

            MainScreenLogic.OpenOutputFile(openOutputDialog, txtOutputPath, txtInputPath, btnAddTestCase, btnSaveIO);

            txtInputPath.Text = @"..\..\..\Assets\Test Required FIles\MainScreenLogicTest\OpenOutputFileFuncTest.txt";
            txtOutputPath.Text = @"..\..\..\Assets\Test Required FIles\MainScreenLogicTest\‏‏OpenOutputFileFuncTest.txt";

            MainScreenLogic.OpenOutputFile(openOutputDialog, txtOutputPath, txtInputPath, btnAddTestCase, btnSaveIO);

            Assert.IsTrue(btnAddTestCase.Enabled);
            Assert.IsTrue(btnSaveIO.Enabled);

        }

        /* Testing the first initialization of the global variables we added to the class. ***** */
        [TestMethod]
        public void MainScreenLogic_GlobalVariablesTesting()
        {
            /* Reciving our indicator variables about wether the messegebox was shown or not. ***** */
            bool InputFileError = MainScreenLogic.inputErrorIsShown; // Variable that indicate wether the error message of wrong input file is shown. *****
            string inputFilePath = MainScreenLogic.testedInputPath; // Variable that indicate the path of the wrong input file. *****

            /* Testing our indicator variables (testing their first initialization). ***** */
            Assert.IsFalse(InputFileError); // Should be false. *****
            Assert.AreEqual(inputFilePath, ""); // Should be true. *****
        }


        [TestMethod]
        public void OpenInputFileTest()
        {
            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\MainScreenLogicTest\OpenInputFileFuncTest.txt";
            txtInputPath.Text = openInputDialog.FileName;

            MainScreenLogic.OpenInputFile(openInputDialog, txtInputPath, txtOutputPath, btnAddTestCase, btnSaveIO);

            txtInputPath.Text = @"..\..\..\Assets\Test Required FIles\MainScreenLogicTest\OpenInputFileFuncTest.txt";
            txtOutputPath.Text = @"..\..\..\Assets\Test Required FIles\MainScreenLogicTest\OpenInputFileFuncTest.txt";

            MainScreenLogic.OpenInputFile(openInputDialog, txtInputPath, txtOutputPath, btnAddTestCase, btnSaveIO);

            Assert.IsTrue(btnAddTestCase.Enabled);
            Assert.IsTrue(btnSaveIO.Enabled);

        }

        /* Test for the case that the user entered inputfile.txt without test cases. ***** */
        [TestMethod]
        public void FaultyInputFileTest()
        {
            openInputDialog.FileName = @"..\..\..\Assets\Test Required FIles\MainScreenLogicTest\WrongInputForTest.txt"; // Sets the path the the faulty txt file that test our bug fix. *****
            txtInputPath.Text = openInputDialog.FileName; // Set the vatiable to hold the txt file name. *****
            txtOutputPath.Text = ""; // Make sure that no output file was entered. *****

            MainScreenLogic.OpenInputFile(openInputDialog, txtInputPath, txtOutputPath, btnAddTestCase, btnSaveIO); // Puts our faulty file as input an initielize the methode of opening input file. *****

            Assert.IsTrue(MainScreenLogic.inputErrorIsShown); // Checking our indicator parameter if the error message was shown. // should be true. *****
            Assert.IsTrue(btnAddTestCase.Enabled); // cheking if the add test case button is enabled again. // should be true.  *****
            Assert.IsTrue(btnSaveIO.Enabled); // checking if the save input/output button is enabled again. // should be true. *****
            Assert.AreEqual("", MainScreenLogic.testedInputPath); // Tested that the input line path is empty again (input file was not excepted). // Should be true. *****

            /* Reset the original variable to their default. ***** */
            MainScreenLogic.inputErrorIsShown = false;
            MainScreenLogic.testedInputPath = "";
        }
    }
}
