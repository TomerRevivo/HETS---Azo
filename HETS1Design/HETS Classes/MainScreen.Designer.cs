using System.Diagnostics.CodeAnalysis;
namespace HETS1Design
{
    /*Since this is all automatically generated code, we exclude it from code coverage
    by using [ExcludeFromCodeCoverage] before every method and that's because it's a partial
    class and excluding this class will exclude all event methods that we might (not sure) be
    able to test too.*/
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        [ExcludeFromCodeCoverage]
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code. This will be excluded from code coverage.

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [ExcludeFromCodeCoverage]
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtArchivePath = new System.Windows.Forms.TextBox();
            this.btnBrowseArchive = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveIO = new System.Windows.Forms.Button();
            this.radioTNC = new System.Windows.Forms.RadioButton();
            this.radioTC = new System.Windows.Forms.RadioButton();
            this.txtOutputAppend = new System.Windows.Forms.TextBox();
            this.txtInputAppend = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddTestCase = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnExecutable = new System.Windows.Forms.RadioButton();
            this.radioBtnCode = new System.Windows.Forms.RadioButton();
            this.radioBtnBothExeAndCode = new System.Windows.Forms.RadioButton();
            this.radioButton32BitCompiler = new System.Windows.Forms.RadioButton();
            this.radioButton64BitCompiler = new System.Windows.Forms.RadioButton();
            this.btnCompile = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.openArchiveDialog = new System.Windows.Forms.OpenFileDialog();
            this.openInputDialog = new System.Windows.Forms.OpenFileDialog();
            this.openOutputDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveCSVFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuCommandsWeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxEnableGrading = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuResultsWeight = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuExeWeight = new System.Windows.Forms.NumericUpDown();
            this.menuCodeWeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scndLabel = new System.Windows.Forms.Label();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.timeoutNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.btnDetailedResults = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuCommandsWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuResultsWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuExeWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCodeWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumUpDown)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose archive file to check:";
            // 
            // txtArchivePath
            // 
            this.txtArchivePath.Location = new System.Drawing.Point(158, 16);
            this.txtArchivePath.Name = "txtArchivePath";
            this.txtArchivePath.ReadOnly = true;
            this.txtArchivePath.Size = new System.Drawing.Size(530, 20);
            this.txtArchivePath.TabIndex = 2;
            // 
            // btnBrowseArchive
            // 
            this.btnBrowseArchive.Location = new System.Drawing.Point(694, 13);
            this.btnBrowseArchive.Name = "btnBrowseArchive";
            this.btnBrowseArchive.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseArchive.TabIndex = 3;
            this.btnBrowseArchive.Text = "Browse...";
            this.btnBrowseArchive.UseVisualStyleBackColor = true;
            this.btnBrowseArchive.Click += new System.EventHandler(this.btnBrowseArchive_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowseArchive);
            this.groupBox1.Controls.Add(this.txtArchivePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files for checking";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveIO);
            this.groupBox2.Controls.Add(this.radioTNC);
            this.groupBox2.Controls.Add(this.radioTC);
            this.groupBox2.Controls.Add(this.txtOutputAppend);
            this.groupBox2.Controls.Add(this.txtInputAppend);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAddTestCase);
            this.groupBox2.Controls.Add(this.txtOutputPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBrowseOutput);
            this.groupBox2.Controls.Add(this.btnBrowseInput);
            this.groupBox2.Controls.Add(this.txtInputPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input/Output case files";
            // 
            // btnSaveIO
            // 
            this.btnSaveIO.Enabled = false;
            this.btnSaveIO.Location = new System.Drawing.Point(653, 175);
            this.btnSaveIO.Name = "btnSaveIO";
            this.btnSaveIO.Size = new System.Drawing.Size(116, 23);
            this.btnSaveIO.TabIndex = 13;
            this.btnSaveIO.Text = "Save new I/O";
            this.btnSaveIO.UseVisualStyleBackColor = true;
            this.btnSaveIO.Click += new System.EventHandler(this.btnSaveIO_Click);
            // 
            // radioTNC
            // 
            this.radioTNC.AutoSize = true;
            this.radioTNC.Location = new System.Drawing.Point(366, 116);
            this.radioTNC.Name = "radioTNC";
            this.radioTNC.Size = new System.Drawing.Size(34, 17);
            this.radioTNC.TabIndex = 12;
            this.radioTNC.TabStop = true;
            this.radioTNC.Text = "!=";
            this.radioTNC.UseVisualStyleBackColor = true;
            // 
            // radioTC
            // 
            this.radioTC.AutoSize = true;
            this.radioTC.Checked = true;
            this.radioTC.Location = new System.Drawing.Point(366, 93);
            this.radioTC.Name = "radioTC";
            this.radioTC.Size = new System.Drawing.Size(31, 17);
            this.radioTC.TabIndex = 11;
            this.radioTC.TabStop = true;
            this.radioTC.Text = "=";
            this.radioTC.UseVisualStyleBackColor = true;
            // 
            // txtOutputAppend
            // 
            this.txtOutputAppend.BackColor = System.Drawing.SystemColors.Info;
            this.txtOutputAppend.Location = new System.Drawing.Point(400, 63);
            this.txtOutputAppend.Multiline = true;
            this.txtOutputAppend.Name = "txtOutputAppend";
            this.txtOutputAppend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutputAppend.Size = new System.Drawing.Size(372, 96);
            this.txtOutputAppend.TabIndex = 10;
            this.txtOutputAppend.WordWrap = false;
            // 
            // txtInputAppend
            // 
            this.txtInputAppend.BackColor = System.Drawing.SystemColors.Info;
            this.txtInputAppend.Location = new System.Drawing.Point(4, 63);
            this.txtInputAppend.Multiline = true;
            this.txtInputAppend.Name = "txtInputAppend";
            this.txtInputAppend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInputAppend.Size = new System.Drawing.Size(361, 96);
            this.txtInputAppend.TabIndex = 9;
            this.txtInputAppend.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Output file additional test cases:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Input file additional test cases:";
            // 
            // btnAddTestCase
            // 
            this.btnAddTestCase.Enabled = false;
            this.btnAddTestCase.Location = new System.Drawing.Point(255, 165);
            this.btnAddTestCase.Name = "btnAddTestCase";
            this.btnAddTestCase.Size = new System.Drawing.Size(234, 23);
            this.btnAddTestCase.TabIndex = 6;
            this.btnAddTestCase.Text = "Add Test Case";
            this.btnAddTestCase.UseVisualStyleBackColor = true;
            this.btnAddTestCase.Click += new System.EventHandler(this.btnAddTestCase_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(458, 17);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(230, 20);
            this.txtOutputPath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output file:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(694, 15);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 3;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(299, 15);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 2;
            this.btnBrowseInput.Text = "Browse...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtInputPath
            // 
            this.txtInputPath.Location = new System.Drawing.Point(63, 17);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.ReadOnly = true;
            this.txtInputPath.Size = new System.Drawing.Size(230, 20);
            this.txtInputPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input file:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnExecutable);
            this.groupBox3.Controls.Add(this.radioBtnCode);
            this.groupBox3.Controls.Add(this.radioBtnBothExeAndCode);
            this.groupBox3.Location = new System.Drawing.Point(13, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 67);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Submission Contains";
            // 
            // radioBtnExecutable
            // 
            this.radioBtnExecutable.AutoSize = true;
            this.radioBtnExecutable.Location = new System.Drawing.Point(27, 30);
            this.radioBtnExecutable.Name = "radioBtnExecutable";
            this.radioBtnExecutable.Size = new System.Drawing.Size(79, 17);
            this.radioBtnExecutable.TabIndex = 5;
            this.radioBtnExecutable.Text = "C Code File";
            this.radioBtnExecutable.UseVisualStyleBackColor = true;
            this.radioBtnExecutable.CheckedChanged += new System.EventHandler(this.radioBtnExecutable_CheckedChanged);
            // 
            // radioBtnCode
            // 
            this.radioBtnCode.AutoSize = true;
            this.radioBtnCode.Location = new System.Drawing.Point(112, 30);
            this.radioBtnCode.Name = "radioBtnCode";
            this.radioBtnCode.Size = new System.Drawing.Size(78, 17);
            this.radioBtnCode.TabIndex = 4;
            this.radioBtnCode.Text = "Executable";
            this.radioBtnCode.UseVisualStyleBackColor = true;
            this.radioBtnCode.CheckedChanged += new System.EventHandler(this.radioBtnCode_CheckedChanged);
            // 
            // radioBtnBothExeAndCode
            // 
            this.radioBtnBothExeAndCode.AutoSize = true;
            this.radioBtnBothExeAndCode.Checked = true;
            this.radioBtnBothExeAndCode.Location = new System.Drawing.Point(196, 30);
            this.radioBtnBothExeAndCode.Name = "radioBtnBothExeAndCode";
            this.radioBtnBothExeAndCode.Size = new System.Drawing.Size(47, 17);
            this.radioBtnBothExeAndCode.TabIndex = 3;
            this.radioBtnBothExeAndCode.TabStop = true;
            this.radioBtnBothExeAndCode.Text = "Both";
            this.radioBtnBothExeAndCode.UseVisualStyleBackColor = true;
            this.radioBtnBothExeAndCode.CheckedChanged += new System.EventHandler(this.radioBtnBothExeAndCode_CheckedChanged);
            // 
            // radioButton32BitCompiler
            // 
            this.radioButton32BitCompiler.AutoSize = true;
            this.radioButton32BitCompiler.Location = new System.Drawing.Point(111, 32);
            this.radioButton32BitCompiler.Name = "radioButton32BitCompiler";
            this.radioButton32BitCompiler.Size = new System.Drawing.Size(85, 17);
            this.radioButton32BitCompiler.TabIndex = 5;
            this.radioButton32BitCompiler.Text = "32bit version";
            this.radioButton32BitCompiler.UseVisualStyleBackColor = true;
            this.radioButton32BitCompiler.CheckedChanged += new System.EventHandler(this.radioButton32BitCompiler_CheckedChanged);
            // 
            // radioButton64BitCompiler
            // 
            this.radioButton64BitCompiler.AutoSize = true;
            this.radioButton64BitCompiler.Checked = true;
            this.radioButton64BitCompiler.Location = new System.Drawing.Point(20, 32);
            this.radioButton64BitCompiler.Name = "radioButton64BitCompiler";
            this.radioButton64BitCompiler.Size = new System.Drawing.Size(85, 17);
            this.radioButton64BitCompiler.TabIndex = 4;
            this.radioButton64BitCompiler.TabStop = true;
            this.radioButton64BitCompiler.Text = "64bit version";
            this.radioButton64BitCompiler.UseVisualStyleBackColor = true;
            this.radioButton64BitCompiler.CheckedChanged += new System.EventHandler(this.radioButton64BitCompiler_CheckedChanged);
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(13, 400);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(160, 30);
            this.btnCompile.TabIndex = 7;
            this.btnCompile.Text = "Compile Programs";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // btnResults
            // 
            this.btnResults.Enabled = false;
            this.btnResults.Location = new System.Drawing.Point(423, 400);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(160, 30);
            this.btnResults.TabIndex = 8;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridResults);
            this.groupBox4.Location = new System.Drawing.Point(17, 436);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(795, 246);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results Table";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridResults
            // 
            this.dataGridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Location = new System.Drawing.Point(5, 19);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.RowHeadersWidth = 50;
            this.dataGridResults.Size = new System.Drawing.Size(775, 221);
            this.dataGridResults.TabIndex = 0;
            this.dataGridResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResults_CellContentClick);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(342, 697);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(113, 26);
            this.btnExportCSV.TabIndex = 10;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // openArchiveDialog
            // 
            this.openArchiveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openArchiveDialog_FileOk);
            // 
            // openInputDialog
            // 
            this.openInputDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openInputDialog_FileOk);
            // 
            // openOutputDialog
            // 
            this.openOutputDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openOutputDialog_FileOk);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.menuCommandsWeight);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.checkBoxEnableGrading);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.menuResultsWeight);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.menuExeWeight);
            this.groupBox5.Controls.Add(this.menuCodeWeight);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(13, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(715, 46);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            // 
            // menuCommandsWeight
            // 
            this.menuCommandsWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuCommandsWeight.Location = new System.Drawing.Point(633, 18);
            this.menuCommandsWeight.Name = "menuCommandsWeight";
            this.menuCommandsWeight.Size = new System.Drawing.Size(52, 20);
            this.menuCommandsWeight.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correct Commands:";
            // 
            // checkBoxEnableGrading
            // 
            this.checkBoxEnableGrading.AutoSize = true;
            this.checkBoxEnableGrading.Location = new System.Drawing.Point(9, -1);
            this.checkBoxEnableGrading.Name = "checkBoxEnableGrading";
            this.checkBoxEnableGrading.Size = new System.Drawing.Size(63, 17);
            this.checkBoxEnableGrading.TabIndex = 10;
            this.checkBoxEnableGrading.Text = "Grading";
            this.checkBoxEnableGrading.UseVisualStyleBackColor = true;
            this.checkBoxEnableGrading.CheckedChanged += new System.EventHandler(this.checkBoxEnableGrading_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "%";
            // 
            // menuResultsWeight
            // 
            this.menuResultsWeight.Location = new System.Drawing.Point(434, 18);
            this.menuResultsWeight.Name = "menuResultsWeight";
            this.menuResultsWeight.Size = new System.Drawing.Size(52, 20);
            this.menuResultsWeight.TabIndex = 8;
            this.menuResultsWeight.ValueChanged += new System.EventHandler(this.menuResultsGrade_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Correct results:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // menuExeWeight
            // 
            this.menuExeWeight.Location = new System.Drawing.Point(237, 17);
            this.menuExeWeight.Name = "menuExeWeight";
            this.menuExeWeight.Size = new System.Drawing.Size(52, 20);
            this.menuExeWeight.TabIndex = 4;
            this.menuExeWeight.ValueChanged += new System.EventHandler(this.menuExeGrade_ValueChanged);
            // 
            // menuCodeWeight
            // 
            this.menuCodeWeight.Location = new System.Drawing.Point(51, 17);
            this.menuCodeWeight.Name = "menuCodeWeight";
            this.menuCodeWeight.Size = new System.Drawing.Size(52, 20);
            this.menuCodeWeight.TabIndex = 3;
            this.menuCodeWeight.ValueChanged += new System.EventHandler(this.menuCodeWeight_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Executable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Code:";
            // 
            // scndLabel
            // 
            this.scndLabel.AutoSize = true;
            this.scndLabel.Location = new System.Drawing.Point(242, 33);
            this.scndLabel.Name = "scndLabel";
            this.scndLabel.Size = new System.Drawing.Size(50, 13);
            this.scndLabel.TabIndex = 13;
            this.scndLabel.Text = "seconds.";
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(23, 32);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(155, 13);
            this.timeoutLabel.TabIndex = 12;
            this.timeoutLabel.Text = "Executable forced to stop after:";
            // 
            // timeoutNumUpDown
            // 
            this.timeoutNumUpDown.Location = new System.Drawing.Point(184, 29);
            this.timeoutNumUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.timeoutNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeoutNumUpDown.Name = "timeoutNumUpDown";
            this.timeoutNumUpDown.Size = new System.Drawing.Size(52, 20);
            this.timeoutNumUpDown.TabIndex = 11;
            this.timeoutNumUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.timeoutNumUpDown.ValueChanged += new System.EventHandler(this.timeoutNumUpDown_ValueChanged);
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.Location = new System.Drawing.Point(218, 400);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(160, 30);
            this.btnRunProgram.TabIndex = 14;
            this.btnRunProgram.Text = "Run Programs";
            this.btnRunProgram.UseVisualStyleBackColor = true;
            this.btnRunProgram.Click += new System.EventHandler(this.btnRunProgram_Click);
            // 
            // btnDetailedResults
            // 
            this.btnDetailedResults.Enabled = false;
            this.btnDetailedResults.Location = new System.Drawing.Point(624, 400);
            this.btnDetailedResults.Name = "btnDetailedResults";
            this.btnDetailedResults.Size = new System.Drawing.Size(160, 30);
            this.btnDetailedResults.TabIndex = 15;
            this.btnDetailedResults.Text = "Detailed Results";
            this.btnDetailedResults.UseVisualStyleBackColor = true;
            this.btnDetailedResults.Click += new System.EventHandler(this.btnDetailedResults_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton32BitCompiler);
            this.groupBox6.Controls.Add(this.radioButton64BitCompiler);
            this.groupBox6.Location = new System.Drawing.Point(268, 274);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(208, 67);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Compiler version:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.scndLabel);
            this.groupBox7.Controls.Add(this.timeoutLabel);
            this.groupBox7.Controls.Add(this.timeoutNumUpDown);
            this.groupBox7.Location = new System.Drawing.Point(482, 274);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(306, 67);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Timeout:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnDetailedResults);
            this.Controls.Add(this.btnRunProgram);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HETS - AZO Version";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainScreen_HelpButtonClicked);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuCommandsWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuResultsWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuExeWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCodeWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumUpDown)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArchivePath;
        private System.Windows.Forms.Button btnBrowseArchive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.TextBox txtOutputAppend;
        private System.Windows.Forms.TextBox txtInputAppend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddTestCase;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.OpenFileDialog openArchiveDialog;
        private System.Windows.Forms.OpenFileDialog openInputDialog;
        private System.Windows.Forms.OpenFileDialog openOutputDialog;
        private System.Windows.Forms.SaveFileDialog saveCSVFile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown menuExeWeight;
        private System.Windows.Forms.NumericUpDown menuCodeWeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown menuResultsWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxEnableGrading;
        private System.Windows.Forms.RadioButton radioButton32BitCompiler;
        private System.Windows.Forms.RadioButton radioButton64BitCompiler;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.NumericUpDown timeoutNumUpDown;
        private System.Windows.Forms.Label scndLabel;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.Button btnDetailedResults;
        private System.Windows.Forms.RadioButton radioBtnExecutable;
        private System.Windows.Forms.RadioButton radioBtnCode;
        private System.Windows.Forms.RadioButton radioBtnBothExeAndCode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioTNC;
        private System.Windows.Forms.RadioButton radioTC;
        private System.Windows.Forms.Button btnSaveIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown menuCommandsWeight;
        private System.Windows.Forms.Label label4;
    }
}


