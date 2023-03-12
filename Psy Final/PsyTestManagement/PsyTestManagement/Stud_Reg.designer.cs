namespace Client_Student_Information_2
{
    partial class frmStud_Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStud_Reg));
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdbbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbbtnOther = new System.Windows.Forms.RadioButton();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactno = new System.Windows.Forms.Label();
            this.lblSelecttesttype = new System.Windows.Forms.Label();
            this.txtbxEmailId = new System.Windows.Forms.TextBox();
            this.txtbxContactNo = new System.Windows.Forms.TextBox();
            this.btnSaveandNext = new System.Windows.Forms.Button();
            this.ErrorClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TestPaper = new System.Windows.Forms.CheckedListBox();
            this.txtFamilyType = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.Label();
            this.txtbxIncome = new System.Windows.Forms.TextBox();
            this.cmbbxfamilytype = new System.Windows.Forms.ComboBox();
            this.txtbxSocialEn = new System.Windows.Forms.Label();
            this.cmbbxSocialEn = new System.Windows.Forms.ComboBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.lblID1 = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.cmbsuggesttest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(9, 80);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(112, 20);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(243, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(448, 80);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(122, 26);
            this.txtMiddleName.TabIndex = 2;
            this.txtMiddleName.TextChanged += new System.EventHandler(this.txtMiddleName_TextChanged_1);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(638, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(131, 26);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged_1);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(12, 121);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // rdbbtnMale
            // 
            this.rdbbtnMale.AutoSize = true;
            this.rdbbtnMale.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbbtnMale.Location = new System.Drawing.Point(97, 123);
            this.rdbbtnMale.Name = "rdbbtnMale";
            this.rdbbtnMale.Size = new System.Drawing.Size(61, 24);
            this.rdbbtnMale.TabIndex = 5;
            this.rdbbtnMale.TabStop = true;
            this.rdbbtnMale.Text = "Male";
            this.rdbbtnMale.UseVisualStyleBackColor = false;
            // 
            // rdbbtnFemale
            // 
            this.rdbbtnFemale.AutoSize = true;
            this.rdbbtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbbtnFemale.Location = new System.Drawing.Point(164, 122);
            this.rdbbtnFemale.Name = "rdbbtnFemale";
            this.rdbbtnFemale.Size = new System.Drawing.Size(80, 24);
            this.rdbbtnFemale.TabIndex = 6;
            this.rdbbtnFemale.TabStop = true;
            this.rdbbtnFemale.Text = "Female";
            this.rdbbtnFemale.UseVisualStyleBackColor = false;
            // 
            // rdbbtnOther
            // 
            this.rdbbtnOther.AutoSize = true;
            this.rdbbtnOther.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbbtnOther.Location = new System.Drawing.Point(268, 124);
            this.rdbbtnOther.Name = "rdbbtnOther";
            this.rdbbtnOther.Size = new System.Drawing.Size(67, 24);
            this.rdbbtnOther.TabIndex = 7;
            this.rdbbtnOther.TabStop = true;
            this.rdbbtnOther.Text = "Other";
            this.rdbbtnOther.UseVisualStyleBackColor = false;
            this.rdbbtnOther.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(476, 126);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(44, 20);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "DOB";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(27, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblContactno
            // 
            this.lblContactno.AutoSize = true;
            this.lblContactno.BackColor = System.Drawing.Color.Transparent;
            this.lblContactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactno.Location = new System.Drawing.Point(505, 181);
            this.lblContactno.Name = "lblContactno";
            this.lblContactno.Size = new System.Drawing.Size(89, 20);
            this.lblContactno.TabIndex = 10;
            this.lblContactno.Text = "Contact No";
            // 
            // lblSelecttesttype
            // 
            this.lblSelecttesttype.AutoSize = true;
            this.lblSelecttesttype.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecttesttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecttesttype.Location = new System.Drawing.Point(410, 231);
            this.lblSelecttesttype.Name = "lblSelecttesttype";
            this.lblSelecttesttype.Size = new System.Drawing.Size(160, 20);
            this.lblSelecttesttype.TabIndex = 11;
            this.lblSelecttesttype.Text = "Suggested Test Type";
            // 
            // txtbxEmailId
            // 
            this.txtbxEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEmailId.Location = new System.Drawing.Point(121, 175);
            this.txtbxEmailId.Name = "txtbxEmailId";
            this.txtbxEmailId.Size = new System.Drawing.Size(214, 26);
            this.txtbxEmailId.TabIndex = 16;
            this.txtbxEmailId.TextChanged += new System.EventHandler(this.txtbxEmailId_TextChanged_1);
            // 
            // txtbxContactNo
            // 
            this.txtbxContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxContactNo.Location = new System.Drawing.Point(626, 177);
            this.txtbxContactNo.Name = "txtbxContactNo";
            this.txtbxContactNo.Size = new System.Drawing.Size(146, 26);
            this.txtbxContactNo.TabIndex = 17;
            this.txtbxContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContactNo_KeyPress);
            this.txtbxContactNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxContactNo_Validating);
            // 
            // btnSaveandNext
            // 
            this.btnSaveandNext.BackColor = System.Drawing.Color.Yellow;
            this.btnSaveandNext.FlatAppearance.BorderSize = 0;
            this.btnSaveandNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveandNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveandNext.Location = new System.Drawing.Point(652, 441);
            this.btnSaveandNext.Name = "btnSaveandNext";
            this.btnSaveandNext.Size = new System.Drawing.Size(153, 46);
            this.btnSaveandNext.TabIndex = 25;
            this.btnSaveandNext.Text = "Save and Next";
            this.btnSaveandNext.UseVisualStyleBackColor = false;
            this.btnSaveandNext.Click += new System.EventHandler(this.btnSaveandNext_Click);
            // 
            // ErrorClient
            // 
            this.ErrorClient.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "StudentID";
            // 
            // TestPaper
            // 
            this.TestPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TestPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestPaper.FormattingEnabled = true;
            this.TestPaper.Location = new System.Drawing.Point(592, 293);
            this.TestPaper.Name = "TestPaper";
            this.TestPaper.Size = new System.Drawing.Size(202, 79);
            this.TestPaper.TabIndex = 29;
            this.TestPaper.SelectedIndexChanged += new System.EventHandler(this.chklistbox_SelectedIndexChanged);
            // 
            // txtFamilyType
            // 
            this.txtFamilyType.AutoSize = true;
            this.txtFamilyType.BackColor = System.Drawing.Color.Transparent;
            this.txtFamilyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyType.Location = new System.Drawing.Point(12, 234);
            this.txtFamilyType.Name = "txtFamilyType";
            this.txtFamilyType.Size = new System.Drawing.Size(88, 20);
            this.txtFamilyType.TabIndex = 30;
            this.txtFamilyType.Text = "FamilyType";
            // 
            // txtIncome
            // 
            this.txtIncome.AutoSize = true;
            this.txtIncome.BackColor = System.Drawing.Color.Transparent;
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(14, 293);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(107, 20);
            this.txtIncome.TabIndex = 31;
            this.txtIncome.Text = "FamilyIncome";
            // 
            // txtbxIncome
            // 
            this.txtbxIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxIncome.Location = new System.Drawing.Point(188, 290);
            this.txtbxIncome.Name = "txtbxIncome";
            this.txtbxIncome.Size = new System.Drawing.Size(146, 26);
            this.txtbxIncome.TabIndex = 33;
            this.txtbxIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContactNo_KeyPress);
            // 
            // cmbbxfamilytype
            // 
            this.cmbbxfamilytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxfamilytype.FormattingEnabled = true;
            this.cmbbxfamilytype.Items.AddRange(new object[] {
            "NuclearFamily.",
            "JointFamily"});
            this.cmbbxfamilytype.Location = new System.Drawing.Point(189, 231);
            this.cmbbxfamilytype.Name = "cmbbxfamilytype";
            this.cmbbxfamilytype.Size = new System.Drawing.Size(146, 28);
            this.cmbbxfamilytype.TabIndex = 35;
            // 
            // txtbxSocialEn
            // 
            this.txtbxSocialEn.AutoSize = true;
            this.txtbxSocialEn.BackColor = System.Drawing.Color.Transparent;
            this.txtbxSocialEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSocialEn.Location = new System.Drawing.Point(12, 352);
            this.txtbxSocialEn.Name = "txtbxSocialEn";
            this.txtbxSocialEn.Size = new System.Drawing.Size(141, 20);
            this.txtbxSocialEn.TabIndex = 36;
            this.txtbxSocialEn.Text = "SocialEnvironment";
            // 
            // cmbbxSocialEn
            // 
            this.cmbbxSocialEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSocialEn.FormattingEnabled = true;
            this.cmbbxSocialEn.Items.AddRange(new object[] {
            "UrbanArea(City).",
            "RuralArea(Village,District)"});
            this.cmbbxSocialEn.Location = new System.Drawing.Point(186, 347);
            this.cmbbxSocialEn.Name = "cmbbxSocialEn";
            this.cmbbxSocialEn.Size = new System.Drawing.Size(146, 28);
            this.cmbbxSocialEn.TabIndex = 37;
            // 
            // DOB
            // 
            this.DOB.CustomFormat = "yyyy/MM/dd";
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOB.Location = new System.Drawing.Point(553, 122);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(146, 26);
            this.DOB.TabIndex = 0;
            // 
            // lblID1
            // 
            this.lblID1.AutoSize = true;
            this.lblID1.BackColor = System.Drawing.Color.Transparent;
            this.lblID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID1.Location = new System.Drawing.Point(104, 52);
            this.lblID1.Name = "lblID1";
            this.lblID1.Size = new System.Drawing.Size(26, 20);
            this.lblID1.TabIndex = 38;
            this.lblID1.Text = "ID";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistration.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(8, 9);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(266, 24);
            this.lblRegistration.TabIndex = 149;
            this.lblRegistration.Text = "STUDENT REGISTRATION";
            // 
            // cmbsuggesttest
            // 
            this.cmbsuggesttest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsuggesttest.FormattingEnabled = true;
            this.cmbsuggesttest.Items.AddRange(new object[] {
            "NuclearFamily.",
            "JointFamily"});
            this.cmbsuggesttest.Location = new System.Drawing.Point(592, 228);
            this.cmbsuggesttest.Name = "cmbsuggesttest";
            this.cmbsuggesttest.Size = new System.Drawing.Size(168, 28);
            this.cmbsuggesttest.TabIndex = 150;
            this.cmbsuggesttest.SelectedIndexChanged += new System.EventHandler(this.cmbsuggesttest_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "Suggested Paper";
            // 
            // frmStud_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbsuggesttest);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblID1);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.cmbbxSocialEn);
            this.Controls.Add(this.txtbxSocialEn);
            this.Controls.Add(this.cmbbxfamilytype);
            this.Controls.Add(this.txtbxIncome);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.txtFamilyType);
            this.Controls.Add(this.TestPaper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveandNext);
            this.Controls.Add(this.txtbxContactNo);
            this.Controls.Add(this.txtbxEmailId);
            this.Controls.Add(this.lblSelecttesttype);
            this.Controls.Add(this.lblContactno);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.rdbbtnOther);
            this.Controls.Add(this.rdbbtnFemale);
            this.Controls.Add(this.rdbbtnMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStudentName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmStud_Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Stud_Reg";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudentInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdbbtnMale;
        private System.Windows.Forms.RadioButton rdbbtnFemale;
        private System.Windows.Forms.RadioButton rdbbtnOther;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactno;
        private System.Windows.Forms.Label lblSelecttesttype;
        private System.Windows.Forms.TextBox txtbxEmailId;
        private System.Windows.Forms.TextBox txtbxContactNo;
        private System.Windows.Forms.Button btnSaveandNext;
        private System.Windows.Forms.ErrorProvider ErrorClient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox TestPaper;
        private System.Windows.Forms.TextBox txtbxIncome;
        private System.Windows.Forms.Label txtIncome;
        private System.Windows.Forms.Label txtFamilyType;
        private System.Windows.Forms.ComboBox cmbbxfamilytype;
        private System.Windows.Forms.Label txtbxSocialEn;
        private System.Windows.Forms.ComboBox cmbbxSocialEn;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label lblID1;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsuggesttest;
    }
}

