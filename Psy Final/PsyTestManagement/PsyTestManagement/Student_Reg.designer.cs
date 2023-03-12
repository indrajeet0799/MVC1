namespace Testmgt
{
    partial class FrmStudentRegistration
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lblStudentRegistration = new System.Windows.Forms.Label();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.cmbbxCountry = new System.Windows.Forms.ComboBox();
            this.lblPincode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.btnSaveAndNext = new System.Windows.Forms.Button();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rdbtnOther = new System.Windows.Forms.RadioButton();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.ErrorStudentRegistration = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblFamilyType = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.cmbbxFamilyType = new System.Windows.Forms.ComboBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbbxSocialType = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStudentRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(527, -92);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(85, 26);
            this.btnExcel.TabIndex = 82;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(443, -92);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(85, 26);
            this.btnPDF.TabIndex = 81;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(364, -92);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 26);
            this.btnRefresh.TabIndex = 80;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(281, -92);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 26);
            this.btnSearch.TabIndex = 79;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(585, -31);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(89, 18);
            this.lblLastName.TabIndex = 61;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(399, -31);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(106, 18);
            this.lblMiddleName.TabIndex = 60;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(238, -31);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(91, 18);
            this.lbFirstName.TabIndex = 59;
            this.lbFirstName.Text = "First Name";
            // 
            // lblStudentRegistration
            // 
            this.lblStudentRegistration.AutoSize = true;
            this.lblStudentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRegistration.Location = new System.Drawing.Point(97, -58);
            this.lblStudentRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentRegistration.Name = "lblStudentRegistration";
            this.lblStudentRegistration.Size = new System.Drawing.Size(161, 18);
            this.lblStudentRegistration.TabIndex = 58;
            this.lblStudentRegistration.Text = "Student Registration";
            // 
            // txtPincode
            // 
            this.txtPincode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPincode.ForeColor = System.Drawing.Color.Black;
            this.txtPincode.Location = new System.Drawing.Point(734, 512);
            this.txtPincode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(160, 26);
            this.txtPincode.TabIndex = 141;
            this.txtPincode.Text = "Pincode";
            this.txtPincode.TextChanged += new System.EventHandler(this.txtbxPincode_TextChanged);
            this.txtPincode.Enter += new System.EventHandler(this.txtbxPincode_Enter);
            // 
            // cmbbxState
            // 
            this.cmbbxState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(734, 376);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(160, 27);
            this.cmbbxState.TabIndex = 140;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(737, 438);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(160, 27);
            this.cmbbxCity.TabIndex = 139;
            this.cmbbxCity.SelectedIndexChanged += new System.EventHandler(this.cmbbxCity_SelectedIndexChanged);
            // 
            // cmbbxCountry
            // 
            this.cmbbxCountry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCountry.FormattingEnabled = true;
            this.cmbbxCountry.Location = new System.Drawing.Point(734, 299);
            this.cmbbxCountry.Name = "cmbbxCountry";
            this.cmbbxCountry.Size = new System.Drawing.Size(160, 27);
            this.cmbbxCountry.TabIndex = 138;
            this.cmbbxCountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged_1);
            // 
            // lblPincode
            // 
            this.lblPincode.AutoSize = true;
            this.lblPincode.BackColor = System.Drawing.Color.Transparent;
            this.lblPincode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPincode.Location = new System.Drawing.Point(596, 512);
            this.lblPincode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(72, 19);
            this.lblPincode.TabIndex = 137;
            this.lblPincode.Text = "Pincode";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(596, 377);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 19);
            this.lblState.TabIndex = 136;
            this.lblState.Text = "State";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(596, 300);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(71, 19);
            this.lblCountry.TabIndex = 135;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(599, 436);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 19);
            this.lblCity.TabIndex = 134;
            this.lblCity.Text = "City";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(64, 102);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(117, 19);
            this.lblStudentName.TabIndex = 117;
            this.lblStudentName.Text = "Student Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(727, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 26);
            this.dateTimePicker1.TabIndex = 133;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Location = new System.Drawing.Point(299, 104);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(174, 26);
            this.txtFirstname.TabIndex = 122;
            this.txtFirstname.Text = "First Name";
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            this.txtFirstname.Enter += new System.EventHandler(this.txtbxFirstname_Enter);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(64, 162);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 19);
            this.lblGender.TabIndex = 118;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailID.Location = new System.Drawing.Point(64, 232);
            this.lblEmailID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(71, 19);
            this.lblEmailID.TabIndex = 119;
            this.lblEmailID.Text = "Email ID";
            this.lblEmailID.Click += new System.EventHandler(this.lblEnailID_Click);
            // 
            // btnSaveAndNext
            // 
            this.btnSaveAndNext.BackColor = System.Drawing.Color.Yellow;
            this.btnSaveAndNext.FlatAppearance.BorderSize = 0;
            this.btnSaveAndNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndNext.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNext.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAndNext.Location = new System.Drawing.Point(675, 601);
            this.btnSaveAndNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAndNext.Name = "btnSaveAndNext";
            this.btnSaveAndNext.Size = new System.Drawing.Size(197, 47);
            this.btnSaveAndNext.TabIndex = 132;
            this.btnSaveAndNext.Text = "Save And Next";
            this.btnSaveAndNext.UseVisualStyleBackColor = false;
            this.btnSaveAndNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(592, 237);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(95, 19);
            this.lblContactNo.TabIndex = 120;
            this.lblContactNo.Text = "Contact No";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(67, 331);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(297, 71);
            this.txtAddress.TabIndex = 131;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtbxAddress_TextChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(592, 177);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(45, 19);
            this.lblDOB.TabIndex = 121;
            this.lblDOB.Text = "DOB";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleName.Location = new System.Drawing.Point(502, 104);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(180, 26);
            this.txtMiddleName.TabIndex = 123;
            this.txtMiddleName.Text = "Middle Name";
            this.txtMiddleName.TextChanged += new System.EventHandler(this.txtbxMiddleName_TextChanged);
            this.txtMiddleName.Enter += new System.EventHandler(this.txtbxMiddleName_Enter);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(709, 104);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 26);
            this.txtLastName.TabIndex = 124;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtbxLastName_TextChanged);
            this.txtLastName.Enter += new System.EventHandler(this.txtbxLastName_Enter);
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnMale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.Location = new System.Drawing.Point(192, 161);
            this.rdbtnMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(62, 23);
            this.rdbtnMale.TabIndex = 125;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = false;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnFemale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.Location = new System.Drawing.Point(262, 161);
            this.rdbtnFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(82, 23);
            this.rdbtnFemale.TabIndex = 126;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(64, 300);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(164, 19);
            this.lblAddress.TabIndex = 130;
            this.lblAddress.Text = "Address Information";
            // 
            // rdbtnOther
            // 
            this.rdbtnOther.AutoSize = true;
            this.rdbtnOther.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnOther.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOther.Location = new System.Drawing.Point(348, 160);
            this.rdbtnOther.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnOther.Name = "rdbtnOther";
            this.rdbtnOther.Size = new System.Drawing.Size(69, 23);
            this.rdbtnOther.TabIndex = 127;
            this.rdbtnOther.TabStop = true;
            this.rdbtnOther.Text = "Other";
            this.rdbtnOther.UseVisualStyleBackColor = false;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(730, 230);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(160, 26);
            this.txtContact.TabIndex = 129;
            this.txtContact.TextChanged += new System.EventHandler(this.txtbxContact_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(190, 229);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 26);
            this.txtEmail.TabIndex = 128;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtbxEmail_TextChanged);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(64, 68);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(89, 19);
            this.lblStudentId.TabIndex = 142;
            this.lblStudentId.Text = "Student ID";
            // 
            // ErrorStudentRegistration
            // 
            this.ErrorStudentRegistration.ContainerControl = this;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BackColor = System.Drawing.Color.Transparent;
            this.lblIncome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(63, 551);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(129, 19);
            this.lblIncome.TabIndex = 144;
            this.lblIncome.Text = "Family Inncome";
            // 
            // lblFamilyType
            // 
            this.lblFamilyType.AutoSize = true;
            this.lblFamilyType.BackColor = System.Drawing.Color.Transparent;
            this.lblFamilyType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyType.Location = new System.Drawing.Point(63, 453);
            this.lblFamilyType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamilyType.Name = "lblFamilyType";
            this.lblFamilyType.Size = new System.Drawing.Size(100, 19);
            this.lblFamilyType.TabIndex = 145;
            this.lblFamilyType.Text = "Family Type";
            // 
            // txtIncome
            // 
            this.txtIncome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(271, 551);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(148, 26);
            this.txtIncome.TabIndex = 146;
            this.txtIncome.TextChanged += new System.EventHandler(this.txtIncome_TextChanged);
            // 
            // cmbbxFamilyType
            // 
            this.cmbbxFamilyType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxFamilyType.FormattingEnabled = true;
            this.cmbbxFamilyType.Items.AddRange(new object[] {
            "Nuclear",
            "Joint Family"});
            this.cmbbxFamilyType.Location = new System.Drawing.Point(269, 453);
            this.cmbbxFamilyType.Name = "cmbbxFamilyType";
            this.cmbbxFamilyType.Size = new System.Drawing.Size(150, 27);
            this.cmbbxFamilyType.TabIndex = 147;
            this.cmbbxFamilyType.SelectedIndexChanged += new System.EventHandler(this.cmbbxFamilyType_SelectedIndexChanged);
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistration.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(39, 9);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(266, 24);
            this.lblRegistration.TabIndex = 148;
            this.lblRegistration.Text = "STUDENT REGISTRATION";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(64, 500);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(143, 19);
            this.lblType.TabIndex = 149;
            this.lblType.Text = "Socialogical Type";
            // 
            // cmbbxSocialType
            // 
            this.cmbbxSocialType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSocialType.FormattingEnabled = true;
            this.cmbbxSocialType.Items.AddRange(new object[] {
            "Urban",
            "Rural"});
            this.cmbbxSocialType.Location = new System.Drawing.Point(269, 501);
            this.cmbbxSocialType.Name = "cmbbxSocialType";
            this.cmbbxSocialType.Size = new System.Drawing.Size(150, 27);
            this.cmbbxSocialType.TabIndex = 150;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(295, 68);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 19);
            this.lblID.TabIndex = 151;
            this.lblID.Text = "ID";
            // 
            // FrmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbbxSocialType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.cmbbxFamilyType);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.lblFamilyType);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtPincode);
            this.Controls.Add(this.cmbbxState);
            this.Controls.Add(this.cmbbxCity);
            this.Controls.Add(this.cmbbxCountry);
            this.Controls.Add(this.lblPincode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmailID);
            this.Controls.Add(this.btnSaveAndNext);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.rdbtnOther);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lblStudentRegistration);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FrmStudentRegistration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStudentRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lblStudentRegistration;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.ComboBox cmbbxCountry;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnSaveAndNext;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RadioButton rdbtnOther;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.ErrorProvider ErrorStudentRegistration;
        private System.Windows.Forms.ComboBox cmbbxFamilyType;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label lblFamilyType;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.ComboBox cmbbxSocialType;
        private System.Windows.Forms.Label lblType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblID;
    }
}

