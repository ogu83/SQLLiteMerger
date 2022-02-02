namespace SQLLiteMerger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox_InputFiles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_SelectOutputFile = new System.Windows.Forms.Button();
            this.txt_OutputFile = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox_InputFiles
            // 
            this.listBox_InputFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_InputFiles.FormattingEnabled = true;
            this.listBox_InputFiles.HorizontalScrollbar = true;
            this.listBox_InputFiles.ItemHeight = 15;
            this.listBox_InputFiles.Location = new System.Drawing.Point(3, 19);
            this.listBox_InputFiles.Name = "listBox_InputFiles";
            this.listBox_InputFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_InputFiles.Size = new System.Drawing.Size(250, 319);
            this.listBox_InputFiles.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_InputFiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Files";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add File(s)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(96, 359);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(169, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Selected File(s)";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(502, 35);
            this.progressBar1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Progress);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(277, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progress";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_SelectOutputFile);
            this.groupBox3.Controls.Add(this.txt_OutputFile);
            this.groupBox3.Location = new System.Drawing.Point(277, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 48);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output File";
            // 
            // btn_SelectOutputFile
            // 
            this.btn_SelectOutputFile.Location = new System.Drawing.Point(416, 19);
            this.btn_SelectOutputFile.Name = "btn_SelectOutputFile";
            this.btn_SelectOutputFile.Size = new System.Drawing.Size(86, 23);
            this.btn_SelectOutputFile.TabIndex = 8;
            this.btn_SelectOutputFile.Text = "...";
            this.btn_SelectOutputFile.UseVisualStyleBackColor = true;
            this.btn_SelectOutputFile.Click += new System.EventHandler(this.btn_SelectOutputFile_Click);
            // 
            // txt_OutputFile
            // 
            this.txt_OutputFile.Location = new System.Drawing.Point(6, 19);
            this.txt_OutputFile.Name = "txt_OutputFile";
            this.txt_OutputFile.ReadOnly = true;
            this.txt_OutputFile.Size = new System.Drawing.Size(404, 23);
            this.txt_OutputFile.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(277, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Progress.Location = new System.Drawing.Point(3, 19);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(52, 15);
            this.lbl_Progress.TabIndex = 5;
            this.lbl_Progress.Text = "Progress";
            this.lbl_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SQLiteMerger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ListBox listBox_InputFiles;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Button btnRemove;
        private ProgressBar progressBar1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btn_SelectOutputFile;
        private TextBox txt_OutputFile;
        private Button btnStart;
        private Button button1;
        private Label lbl_Progress;
    }
}