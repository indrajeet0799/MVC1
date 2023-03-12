namespace PsyTestManagement
{
    partial class frmNewTestPaper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTestPaper));
            this.btnAddTest = new System.Windows.Forms.Button();
            this.grpbx = new System.Windows.Forms.GroupBox();
            this.cmbbxStatus = new System.Windows.Forms.ComboBox();
            this.txtTestPaper = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.cmbbxTestPaper = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbbxTestType = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTestPaperName = new System.Windows.Forms.Label();
            this.lblTestType = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tnRefresh = new System.Windows.Forms.Button();
            this.grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTest.BackgroundImage")));
            this.btnAddTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTest.ForeColor = System.Drawing.Color.Black;
            this.btnAddTest.Location = new System.Drawing.Point(717, 124);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(33, 25);
            this.btnAddTest.TabIndex = 16;
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // grpbx
            // 
            this.grpbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbx.Controls.Add(this.cmbbxStatus);
            this.grpbx.Controls.Add(this.txtTestPaper);
            this.grpbx.Controls.Add(this.txtDuration);
            this.grpbx.Controls.Add(this.txtMarks);
            this.grpbx.ForeColor = System.Drawing.Color.Black;
            this.grpbx.Location = new System.Drawing.Point(122, 170);
            this.grpbx.Name = "grpbx";
            this.grpbx.Size = new System.Drawing.Size(801, 70);
            this.grpbx.TabIndex = 15;
            this.grpbx.TabStop = false;
            this.grpbx.Visible = false;
            // 
            // cmbbxStatus
            // 
            this.cmbbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxStatus.FormattingEnabled = true;
            this.cmbbxStatus.Location = new System.Drawing.Point(587, 34);
            this.cmbbxStatus.Name = "cmbbxStatus";
            this.cmbbxStatus.Size = new System.Drawing.Size(121, 28);
            this.cmbbxStatus.TabIndex = 7;
            this.cmbbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxStatus_SelectedIndexChanged);
            // 
            // txtTestPaper
            // 
            this.txtTestPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestPaper.Location = new System.Drawing.Point(49, 34);
            this.txtTestPaper.Name = "txtTestPaper";
            this.txtTestPaper.Size = new System.Drawing.Size(151, 26);
            this.txtTestPaper.TabIndex = 3;
            this.txtTestPaper.Text = "Test Paper Name";
            this.txtTestPaper.TextChanged += new System.EventHandler(this.txtTestPaper_TextChanged);
            this.txtTestPaper.Enter += new System.EventHandler(this.txtTestPaper_Enter);
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(234, 34);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(151, 26);
            this.txtDuration.TabIndex = 5;
            this.txtDuration.Text = "Duration";
            this.txtDuration.Enter += new System.EventHandler(this.txtDuration_Enter);
            this.txtDuration.Leave += new System.EventHandler(this.txtDuration_Leave);
            // 
            // txtMarks
            // 
            this.txtMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarks.Location = new System.Drawing.Point(402, 34);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(151, 26);
            this.txtMarks.TabIndex = 6;
            this.txtMarks.Text = "Marks";
            this.txtMarks.Enter += new System.EventHandler(this.txtMarks_Enter);
            this.txtMarks.Leave += new System.EventHandler(this.txtMarks_Leave);
            // 
            // cmbbxTestPaper
            // 
            this.cmbbxTestPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxTestPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestPaper.FormattingEnabled = true;
            this.cmbbxTestPaper.Location = new System.Drawing.Point(561, 122);
            this.cmbbxTestPaper.Name = "cmbbxTestPaper";
            this.cmbbxTestPaper.Size = new System.Drawing.Size(150, 28);
            this.cmbbxTestPaper.TabIndex = 14;
            this.cmbbxTestPaper.SelectedIndexChanged += new System.EventHandler(this.cmbbxTestPaper_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(756, 116);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 34);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnAddQue_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(352, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbbxTestType
            // 
            this.cmbbxTestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTestType.FormattingEnabled = true;
            this.cmbbxTestType.Location = new System.Drawing.Point(198, 125);
            this.cmbbxTestType.Name = "cmbbxTestType";
            this.cmbbxTestType.Size = new System.Drawing.Size(148, 28);
            this.cmbbxTestType.TabIndex = 11;
            this.cmbbxTestType.SelectedIndexChanged += new System.EventHandler(this.cmbbxTestType_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTestPaperName
            // 
            this.lblTestPaperName.AutoSize = true;
            this.lblTestPaperName.BackColor = System.Drawing.Color.Transparent;
            this.lblTestPaperName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestPaperName.Location = new System.Drawing.Point(431, 129);
            this.lblTestPaperName.Name = "lblTestPaperName";
            this.lblTestPaperName.Size = new System.Drawing.Size(124, 20);
            this.lblTestPaperName.TabIndex = 51;
            this.lblTestPaperName.Text = "TestPaperName";
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.BackColor = System.Drawing.Color.Transparent;
            this.lblTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestType.Location = new System.Drawing.Point(118, 126);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(74, 20);
            this.lblTestType.TabIndex = 52;
            this.lblTestType.Text = "TestType";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(952, 193);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 37);
            this.btnSubmit.TabIndex = 53;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tnRefresh
            // 
            this.tnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tnRefresh.BackgroundImage")));
            this.tnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tnRefresh.FlatAppearance.BorderSize = 0;
            this.tnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnRefresh.Location = new System.Drawing.Point(391, 127);
            this.tnRefresh.Name = "tnRefresh";
            this.tnRefresh.Size = new System.Drawing.Size(34, 26);
            this.tnRefresh.TabIndex = 55;
            this.tnRefresh.UseVisualStyleBackColor = true;
            this.tnRefresh.Click += new System.EventHandler(this.tnRefresh_Click);
            // 
            // frmNewTestPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1085, 487);
            this.Controls.Add(this.tnRefresh);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTestType);
            this.Controls.Add(this.lblTestPaperName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpbx);
            this.Controls.Add(this.cmbbxTestPaper);
            this.Controls.Add(this.cmbbxTestType);
            this.Controls.Add(this.btnAddTest);
            this.Name = "frmNewTestPaper";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbx.ResumeLayout(false);
            this.grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.GroupBox grpbx;
        private System.Windows.Forms.TextBox txtTestPaper;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.ComboBox cmbbxTestPaper;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbbxTestType;
        private System.Windows.Forms.ComboBox cmbbxStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTestType;
        private System.Windows.Forms.Label lblTestPaperName;
        public System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button tnRefresh;
    }
}

