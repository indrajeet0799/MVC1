namespace PsyTestManagement
{
    partial class frmStaff_Registration
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
            this.cmbbxStaffPosition = new System.Windows.Forms.ComboBox();
            this.lblStaffPosition = new System.Windows.Forms.Label();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbbxCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtAddressInf = new System.Windows.Forms.TextBox();
            this.lblAddressInf = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.rdbbtnOther = new System.Windows.Forms.RadioButton();
            this.rdbbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbbtnMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.grpbxStaffInfo1 = new System.Windows.Forms.GroupBox();
            this.errorStaffReg = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpbxStaffInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorStaffReg)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbxStaffPosition
            // 
            this.cmbbxStaffPosition.FormattingEnabled = true;
            this.cmbbxStaffPosition.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmbbxStaffPosition.Location = new System.Drawing.Point(125, 35);
            this.cmbbxStaffPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxStaffPosition.Name = "cmbbxStaffPosition";
            this.cmbbxStaffPosition.Size = new System.Drawing.Size(141, 29);
            this.cmbbxStaffPosition.TabIndex = 30;
            this.cmbbxStaffPosition.SelectedIndexChanged += new System.EventHandler(this.cmbbxStaffPosition_SelectedIndexChanged);
            // 
            // lblStaffPosition
            // 
            this.lblStaffPosition.AutoSize = true;
            this.lblStaffPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffPosition.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPosition.Location = new System.Drawing.Point(23, 40);
            this.lblStaffPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffPosition.Name = "lblStaffPosition";
            this.lblStaffPosition.Size = new System.Drawing.Size(97, 20);
            this.lblStaffPosition.TabIndex = 29;
            this.lblStaffPosition.Text = "Staff-Position:";
            this.lblStaffPosition.Click += new System.EventHandler(this.lblStaffPosition_Click);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.Location = new System.Drawing.Point(101, 427);
            this.txtPinCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(132, 26);
            this.txtPinCode.TabIndex = 28;
            this.txtPinCode.TextChanged += new System.EventHandler(this.txtPinCode_TextChanged);
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPinCode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.Location = new System.Drawing.Point(24, 431);
            this.lblPinCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(70, 20);
            this.lblPinCode.TabIndex = 27;
            this.lblPinCode.Text = "Pin Code:";
            this.lblPinCode.Click += new System.EventHandler(this.lblPinCode_Click);
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(562, 387);
            this.cmbbxCity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(176, 26);
            this.cmbbxCity.TabIndex = 26;
            this.cmbbxCity.SelectedIndexChanged += new System.EventHandler(this.cmbbxCity_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(530, 392);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 20);
            this.lblCity.TabIndex = 25;
            this.lblCity.Text = "City:";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // cmbbxState
            // 
            this.cmbbxState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(322, 387);
            this.cmbbxState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(186, 26);
            this.cmbbxState.TabIndex = 24;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(278, 392);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 20);
            this.lblState.TabIndex = 23;
            this.lblState.Text = "State:";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // cmbbxCountry
            // 
            this.cmbbxCountry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCountry.FormattingEnabled = true;
            this.cmbbxCountry.Items.AddRange(new object[] {
            "India",
            "USA",
            "UK",
            "Australia"});
            this.cmbbxCountry.Location = new System.Drawing.Point(101, 389);
            this.cmbbxCountry.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxCountry.Name = "cmbbxCountry";
            this.cmbbxCountry.Size = new System.Drawing.Size(141, 26);
            this.cmbbxCountry.TabIndex = 22;
            this.cmbbxCountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged);
            this.cmbbxCountry.Enter += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(24, 392);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(62, 20);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "Country:";
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // txtAddressInf
            // 
            this.txtAddressInf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressInf.Location = new System.Drawing.Point(101, 242);
            this.txtAddressInf.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressInf.Multiline = true;
            this.txtAddressInf.Name = "txtAddressInf";
            this.txtAddressInf.Size = new System.Drawing.Size(423, 113);
            this.txtAddressInf.TabIndex = 20;
            this.txtAddressInf.TextChanged += new System.EventHandler(this.txtAddressInf_TextChanged);
            // 
            // lblAddressInf
            // 
            this.lblAddressInf.AutoSize = true;
            this.lblAddressInf.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressInf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressInf.Location = new System.Drawing.Point(23, 211);
            this.lblAddressInf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressInf.Name = "lblAddressInf";
            this.lblAddressInf.Size = new System.Drawing.Size(140, 20);
            this.lblAddressInf.TabIndex = 19;
            this.lblAddressInf.Text = "Address Information:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(101, 470);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 26);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 474);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(562, 464);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 46);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(497, 117);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(190, 26);
            this.txtPhoneNo.TabIndex = 13;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.txtPhoneNo_TextChanged);
            // 
            // txtEmailID
            // 
            this.txtEmailID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailID.Location = new System.Drawing.Point(101, 165);
            this.txtEmailID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(218, 26);
            this.txtEmailID.TabIndex = 12;
            this.txtEmailID.TextChanged += new System.EventHandler(this.txtEmailID_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(403, 122);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(81, 20);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "Contact No:";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailID.Location = new System.Drawing.Point(24, 165);
            this.lblEmailID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(66, 20);
            this.lblEmailID.TabIndex = 10;
            this.lblEmailID.Text = "Email ID:";
            // 
            // rdbbtnOther
            // 
            this.rdbbtnOther.AutoSize = true;
            this.rdbbtnOther.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnOther.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbbtnOther.Location = new System.Drawing.Point(226, 119);
            this.rdbbtnOther.Margin = new System.Windows.Forms.Padding(2);
            this.rdbbtnOther.Name = "rdbbtnOther";
            this.rdbbtnOther.Size = new System.Drawing.Size(61, 24);
            this.rdbbtnOther.TabIndex = 7;
            this.rdbbtnOther.TabStop = true;
            this.rdbbtnOther.Text = "Other";
            this.rdbbtnOther.UseVisualStyleBackColor = false;
            this.rdbbtnOther.CheckedChanged += new System.EventHandler(this.rdbbtnOther_CheckedChanged);
            // 
            // rdbbtnFemale
            // 
            this.rdbbtnFemale.AutoSize = true;
            this.rdbbtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnFemale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbbtnFemale.Location = new System.Drawing.Point(157, 117);
            this.rdbbtnFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbbtnFemale.Name = "rdbbtnFemale";
            this.rdbbtnFemale.Size = new System.Drawing.Size(72, 24);
            this.rdbbtnFemale.TabIndex = 6;
            this.rdbbtnFemale.TabStop = true;
            this.rdbbtnFemale.Text = "Female";
            this.rdbbtnFemale.UseVisualStyleBackColor = false;
            this.rdbbtnFemale.CheckedChanged += new System.EventHandler(this.rdbbtnFemale_CheckedChanged);
            // 
            // rdbbtnMale
            // 
            this.rdbbtnMale.AutoSize = true;
            this.rdbbtnMale.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnMale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbbtnMale.Location = new System.Drawing.Point(104, 117);
            this.rdbbtnMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbbtnMale.Name = "rdbbtnMale";
            this.rdbbtnMale.Size = new System.Drawing.Size(56, 24);
            this.rdbbtnMale.TabIndex = 5;
            this.rdbbtnMale.TabStop = true;
            this.rdbbtnMale.Text = "Male";
            this.rdbbtnMale.UseVisualStyleBackColor = false;
            this.rdbbtnMale.CheckedChanged += new System.EventHandler(this.rdbbtnMale_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(23, 119);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(104, 74);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(384, 26);
            this.txtStaffName.TabIndex = 1;
            this.txtStaffName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtStaffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffName_KeyPress);
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(24, 79);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(80, 20);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Staff Name:";
            // 
            // grpbxStaffInfo1
            // 
            this.grpbxStaffInfo1.BackColor = System.Drawing.Color.Transparent;
            this.grpbxStaffInfo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpbxStaffInfo1.Controls.Add(this.cmbbxStaffPosition);
            this.grpbxStaffInfo1.Controls.Add(this.lblStaffPosition);
            this.grpbxStaffInfo1.Controls.Add(this.txtPinCode);
            this.grpbxStaffInfo1.Controls.Add(this.lblPinCode);
            this.grpbxStaffInfo1.Controls.Add(this.cmbbxCity);
            this.grpbxStaffInfo1.Controls.Add(this.lblCity);
            this.grpbxStaffInfo1.Controls.Add(this.cmbbxState);
            this.grpbxStaffInfo1.Controls.Add(this.lblState);
            this.grpbxStaffInfo1.Controls.Add(this.cmbbxCountry);
            this.grpbxStaffInfo1.Controls.Add(this.lblCountry);
            this.grpbxStaffInfo1.Controls.Add(this.txtAddressInf);
            this.grpbxStaffInfo1.Controls.Add(this.lblAddressInf);
            this.grpbxStaffInfo1.Controls.Add(this.txtPassword);
            this.grpbxStaffInfo1.Controls.Add(this.lblPassword);
            this.grpbxStaffInfo1.Controls.Add(this.btnSave);
            this.grpbxStaffInfo1.Controls.Add(this.txtPhoneNo);
            this.grpbxStaffInfo1.Controls.Add(this.txtEmailID);
            this.grpbxStaffInfo1.Controls.Add(this.lblContact);
            this.grpbxStaffInfo1.Controls.Add(this.lblEmailID);
            this.grpbxStaffInfo1.Controls.Add(this.rdbbtnOther);
            this.grpbxStaffInfo1.Controls.Add(this.rdbbtnFemale);
            this.grpbxStaffInfo1.Controls.Add(this.rdbbtnMale);
            this.grpbxStaffInfo1.Controls.Add(this.lblGender);
            this.grpbxStaffInfo1.Controls.Add(this.txtStaffName);
            this.grpbxStaffInfo1.Controls.Add(this.lblStaffName);
            this.grpbxStaffInfo1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxStaffInfo1.Location = new System.Drawing.Point(20, 33);
            this.grpbxStaffInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxStaffInfo1.Name = "grpbxStaffInfo1";
            this.grpbxStaffInfo1.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxStaffInfo1.Size = new System.Drawing.Size(774, 531);
            this.grpbxStaffInfo1.TabIndex = 1;
            this.grpbxStaffInfo1.TabStop = false;
            this.grpbxStaffInfo1.Text = "Staff-Information";
            this.grpbxStaffInfo1.Enter += new System.EventHandler(this.grpbxStaffInfo1_Enter);
            // 
            // errorStaffReg
            // 
            this.errorStaffReg.ContainerControl = this;
            // 
            // frmStaff_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.ClientSize = new System.Drawing.Size(874, 609);
            this.Controls.Add(this.grpbxStaffInfo1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStaff_Registration";
            this.Text = "Staff_Registration";
            this.grpbxStaffInfo1.ResumeLayout(false);
            this.grpbxStaffInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorStaffReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxStaffPosition;
        private System.Windows.Forms.Label lblStaffPosition;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbbxCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtAddressInf;
        private System.Windows.Forms.Label lblAddressInf;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.RadioButton rdbbtnOther;
        private System.Windows.Forms.RadioButton rdbbtnFemale;
        private System.Windows.Forms.RadioButton rdbbtnMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.GroupBox grpbxStaffInfo1;
        private System.Windows.Forms.ErrorProvider errorStaffReg;
    }
}