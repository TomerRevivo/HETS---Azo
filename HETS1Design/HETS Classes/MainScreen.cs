using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using HETS1Design.HETS_Classes;

namespace HETS1Design
{
    /*We are excluding this from code coverage since we'll be testing these functions in
     MainScreenLogic class.*/
    [ExcludeFromCodeCoverage]
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }


        private void MainScreen_Load(object sender, EventArgs e)
        {
            MainScreenLogic.OnMainScreenLoad(this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight, this.menuCommandsWeight);
        }

        private void MainScreen_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MainScreenLogic.DisplayGuideHelpBox();
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            MainScreenLogic.CompileHelper(this.btnCompile, this.txtArchivePath, this.txtInputPath, this.txtOutputPath);
        }


        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            MainScreenLogic.RunHelper(this.btnRunProgram, this.txtArchivePath, this.txtInputPath, this.txtOutputPath, this.btnResults);
        }


        private void btnResults_Click(object sender, EventArgs e)
        {
            MainScreenLogic.OnShowResults(this.dataGridResults, this.btnDetailedResults);

        }

        private void btnDetailedResults_Click(object sender, EventArgs e)
        {
            MainScreenLogic.OnSaveDetailedResults(this.txtArchivePath);
        }

        private void btnSaveIO_Click(object sender, EventArgs e)
        {
            MainScreenLogic.OnButtonSaveIOClick(this.txtInputPath, this.txtOutputPath);

        }

        private void btnAddTestCase_Click(object sender, EventArgs e)
        {
            MainScreenLogic.OnButtonAddTestCaseClick(this.radioTC, this.radioTNC, this.txtInputAppend, this.txtOutputAppend);
        }


        private void btnBrowseArchive_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareFileDialog("ZIP Archive files (*.zip)|*.zip", openArchiveDialog);
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareFileDialog("Text files (*.txt)|*.txt", openInputDialog);
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareFileDialog("Text files (*.txt)|*.txt", openOutputDialog);
        }

        private void openArchiveDialog_FileOk(object sender, CancelEventArgs e)
        {
            MainScreenLogic.OpenArchiveFile(this.openArchiveDialog, this.txtArchivePath, this.btnResults, this.btnDetailedResults);
        }


        private void openInputDialog_FileOk(object sender, CancelEventArgs e)
        {
            MainScreenLogic.OpenInputFile(this.openInputDialog, this.txtInputPath, this.txtOutputPath, this.btnAddTestCase, this.btnSaveIO);
        }

        private void openOutputDialog_FileOk(object sender, CancelEventArgs e)
        {
            MainScreenLogic.OpenOutputFile(this.openOutputDialog, this.txtOutputPath, this.txtInputPath, this.btnAddTestCase, this.btnSaveIO);
        }


        private void menuCodeWeight_ValueChanged(object sender, EventArgs e)
        {
            MainScreenLogic.LimitWeightsChange(this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight, this.menuCommandsWeight);
        }

        private void menuExeGrade_ValueChanged(object sender, EventArgs e)
        {
            MainScreenLogic.LimitWeightsChange(this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight, this.menuCommandsWeight);
        }

        private void menuResultsGrade_ValueChanged(object sender, EventArgs e)
        {
            MainScreenLogic.LimitWeightsChange(this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight, this.menuCommandsWeight);
        }

        private void checkBoxEnableGrading_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.EnableGradingCheckedChange(this.checkBoxEnableGrading, this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight, this.menuCommandsWeight);
        }

        private void radioButton64BitCompiler_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.Option64BitCompilerChange();
        }

        private void radioButton32BitCompiler_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.Option32BitCompilerChange();
        }


        private void timeoutNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            MainScreenLogic.TimeoutValueChange(timeoutNumUpDown);
        }

        private void radioBtnExecutable_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.OnCheckCodeRadioChange(this.btnCompile);
        }

        private void radioBtnCode_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.OnCheckExeRadioChange(this.btnCompile);
        }

        private void radioBtnBothExeAndCode_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.OnCheckBothRadioChange(this.btnCompile);
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            MainScreenLogic.OnExportToCSV(saveCSVFile, dataGridResults);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            checkCommands.findTheName(checkCommands.returnTheCommands(this.));
        }*/

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
