namespace PsyTestManagement
{
    partial class frmEditAdmin
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
            this.updateerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPinCode1 = new System.Windows.Forms.TextBox();
            this.lblPinCode1 = new System.Windows.Forms.Label();
            this.cmbbxCity1 = new System.Windows.Forms.ComboBox();
            this.lblCity1 = new System.Windows.Forms.Label();
            this.cmbbxState1 = new System.Windows.Forms.ComboBox();
            this.lblState1 = new System.Windows.Forms.Label();
            this.cmbbxCountry1 = new System.Windows.Forms.ComboBox();
            this.lblCountry1 = new System.Windows.Forms.Label();
            this.txtAddressInf1 = new System.Windows.Forms.TextBox();
            this.lblAddressInf1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtPhoneNo1 = new System.Windows.Forms.TextBox();
            this.lblContact1 = new System.Windows.Forms.Label();
            this.txtStaffName1 = new System.Windows.Forms.TextBox();
            this.lblStaffName1 = new System.Windows.Forms.Label();
            this.grpbxStaffInfo2 = new System.Windows.Forms.GroupBox();
            this.btncancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updateerrorProvider1)).BeginInit();
            this.grpbxStaffInfo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateerrorProvider1
            // 
            this.updateerrorProvider1.ContainerControl = this;
            // 
            // txtPinCode1
            // 
            this.txtPinCode1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode1.Location = new System.Drawing.Point(103, 350);
            this.txtPinCode1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPinCode1.Name = "txtPinCode1";
            this.txtPinCode1.Size = new System.Drawing.Size(132, 26);
            this.txtPinCode1.TabIndex = 28;
            // 
            // lblPinCode1
            // 
            this.lblPinCode1.AutoSize = true;
            this.lblPinCode1.BackColor = System.Drawing.Color.Transparent;
            this.lblPinCode1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode1.Location = new System.Drawing.Point(19, 353);
            this.lblPinCode1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPinCode1.Name = "lblPinCode1";
            this.lblPinCode1.Size = new System.Drawing.Size(70, 20);
            this.lblPinCode1.TabIndex = 27;
            this.lblPinCode1.Text = "Pin Code:";
            // 
            // cmbbxCity1
            // 
            this.cmbbxCity1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCity1.FormattingEnabled = true;
            this.cmbbxCity1.Location = new System.Drawing.Point(527, 300);
            this.cmbbxCity1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxCity1.Name = "cmbbxCity1";
            this.cmbbxCity1.Size = new System.Drawing.Size(141, 26);
            this.cmbbxCity1.TabIndex = 26;
            // 
            // lblCity1
            // 
            this.lblCity1.AutoSize = true;
            this.lblCity1.BackColor = System.Drawing.Color.Transparent;
            this.lblCity1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity1.Location = new System.Drawing.Point(478, 305);
            this.lblCity1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity1.Name = "lblCity1";
            this.lblCity1.Size = new System.Drawing.Size(37, 20);
            this.lblCity1.TabIndex = 25;
            this.lblCity1.Text = "City:";
            // 
            // cmbbxState1
            // 
            this.cmbbxState1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxState1.FormattingEnabled = true;
            this.cmbbxState1.Location = new System.Drawing.Point(316, 300);
            this.cmbbxState1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxState1.Name = "cmbbxState1";
            this.cmbbxState1.Size = new System.Drawing.Size(141, 26);
            this.cmbbxState1.TabIndex = 24;
            this.cmbbxState1.SelectedIndexChanged += new System.EventHandler(this.cmbbxState1_SelectedIndexChanged);
            // 
            // lblState1
            // 
            this.lblState1.AutoSize = true;
            this.lblState1.BackColor = System.Drawing.Color.Transparent;
            this.lblState1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState1.Location = new System.Drawing.Point(272, 305);
            this.lblState1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState1.Name = "lblState1";
            this.lblState1.Size = new System.Drawing.Size(44, 20);
            this.lblState1.TabIndex = 23;
            this.lblState1.Text = "State:";
            // 
            // cmbbxCountry1
            // 
            this.cmbbxCountry1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCountry1.FormattingEnabled = true;
            this.cmbbxCountry1.Items.AddRange(new object[] {
            "India",
            "USA",
            "UK",
            "Australia"});
            this.cmbbxCountry1.Location = new System.Drawing.Point(103, 300);
            this.cmbbxCountry1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbxCountry1.Name = "cmbbxCountry1";
            this.cmbbxCountry1.Size = new System.Drawing.Size(141, 26);
            this.cmbbxCountry1.TabIndex = 22;
            this.cmbbxCountry1.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry1_SelectedIndexChanged);
            // 
            // lblCountry1
            // 
            this.lblCountry1.AutoSize = true;
            this.lblCountry1.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry1.Location = new System.Drawing.Point(19, 306);
            this.lblCountry1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry1.Name = "lblCountry1";
            this.lblCountry1.Size = new System.Drawing.Size(62, 20);
            this.lblCountry1.TabIndex = 21;
            this.lblCountry1.Text = "Country:";
            // 
            // txtAddressInf1
            // 
            this.txtAddressInf1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressInf1.Location = new System.Drawing.Point(104, 203);
            this.txtAddressInf1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressInf1.Multiline = true;
            this.txtAddressInf1.Name = "txtAddressInf1";
            this.txtAddressInf1.Size = new System.Drawing.Size(565, 62);
            this.txtAddressInf1.TabIndex = 20;
            // 
            // lblAddressInf1
            // 
            this.lblAddressInf1.AutoSize = true;
            this.lblAddressInf1.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressInf1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressInf1.Location = new System.Drawing.Point(15, 181);
            this.lblAddressInf1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressInf1.Name = "lblAddressInf1";
            this.lblAddressInf1.Size = new System.Drawing.Size(140, 20);
            this.lblAddressInf1.TabIndex = 19;
            this.lblAddressInf1.Text = "Address Information:";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Yellow;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Location = new System.Drawing.Point(397, 397);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(127, 37);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtPhoneNo1
            // 
            this.txtPhoneNo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo1.Location = new System.Drawing.Point(117, 117);
            this.txtPhoneNo1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNo1.Name = "txtPhoneNo1";
            this.txtPhoneNo1.Size = new System.Drawing.Size(169, 26);
            this.txtPhoneNo1.TabIndex = 13;
            // 
            // lblContact1
            // 
            this.lblContact1.AutoSize = true;
            this.lblContact1.BackColor = System.Drawing.Color.Transparent;
            this.lblContact1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact1.Location = new System.Drawing.Point(19, 117);
            this.lblContact1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact1.Name = "lblContact1";
            this.lblContact1.Size = new System.Drawing.Size(81, 20);
            this.lblContact1.TabIndex = 11;
            this.lblContact1.Text = "Contact No:";
            // 
            // txtStaffName1
            // 
            this.txtStaffName1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName1.Location = new System.Drawing.Point(99, 57);
            this.txtStaffName1.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffName1.Name = "txtStaffName1";
            this.txtStaffName1.Size = new System.Drawing.Size(400, 26);
            this.txtStaffName1.TabIndex = 1;
            // 
            // lblStaffName1
            // 
            this.lblStaffName1.AutoSize = true;
            this.lblStaffName1.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffName1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName1.Location = new System.Drawing.Point(15, 57);
            this.lblStaffName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffName1.Name = "lblStaffName1";
            this.lblStaffName1.Size = new System.Drawing.Size(80, 20);
            this.lblStaffName1.TabIndex = 0;
            this.lblStaffName1.Text = "Staff Name:";
            // 
            // grpbxStaffInfo2
            // 
            this.grpbxStaffInfo2.BackColor = System.Drawing.Color.Transparent;
            this.grpbxStaffInfo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpbxStaffInfo2.Controls.Add(this.btncancle);
            this.grpbxStaffInfo2.Controls.Add(this.txtPinCode1);
            this.grpbxStaffInfo2.Controls.Add(this.lblPinCode1);
            this.grpbxStaffInfo2.Controls.Add(this.cmbbxCity1);
            this.grpbxStaffInfo2.Controls.Add(this.lblCity1);
            this.grpbxStaffInfo2.Controls.Add(this.cmbbxState1);
            this.grpbxStaffInfo2.Controls.Add(this.lblState1);
            this.grpbxStaffInfo2.Controls.Add(this.cmbbxCountry1);
            this.grpbxStaffInfo2.Controls.Add(this.lblCountry1);
            this.grpbxStaffInfo2.Controls.Add(this.txtAddressInf1);
            this.grpbxStaffInfo2.Controls.Add(this.lblAddressInf1);
            this.grpbxStaffInfo2.Controls.Add(this.btnupdate);
            this.grpbxStaffInfo2.Controls.Add(this.txtPhoneNo1);
            this.grpbxStaffInfo2.Controls.Add(this.lblContact1);
            this.grpbxStaffInfo2.Controls.Add(this.txtStaffName1);
            this.grpbxStaffInfo2.Controls.Add(this.lblStaffName1);
            this.grpbxStaffInfo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxStaffInfo2.Location = new System.Drawing.Point(38, 24);
            this.grpbxStaffInfo2.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxStaffInfo2.Name = "grpbxStaffInfo2";
            this.grpbxStaffInfo2.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxStaffInfo2.Size = new System.Drawing.Size(719, 453);
            this.grpbxStaffInfo2.TabIndex = 3;
            this.grpbxStaffInfo2.TabStop = false;
            this.grpbxStaffInfo2.Text = "UpdateAdmin-Information";
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Yellow;
            this.btncancle.FlatAppearance.BorderSize = 0;
            this.btncancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btncancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Location = new System.Drawing.Point(572, 397);
            this.btncancle.Margin = new System.Windows.Forms.Padding(2);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(127, 37);
            this.btncancle.TabIndex = 29;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // frmEditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 488);
            this.Controls.Add(this.grpbxStaffInfo2);
            this.Name = "frmEditAdmin";
            this.Text = "Edit_Admin";
            this.Load += new System.EventHandler(this.frmEdit_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateerrorProvider1)).EndInit();
            this.grpbxStaffInfo2.ResumeLayout(false);
            this.grpbxStaffInfo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider updateerrorProvider1;
        private System.Windows.Forms.GroupBox grpbxStaffInfo2;
        private System.Windows.Forms.TextBox txtPinCode1;
        private System.Windows.Forms.Label lblPinCode1;
        private System.Windows.Forms.ComboBox cmbbxCity1;
        private System.Windows.Forms.Label lblCity1;
        private System.Windows.Forms.ComboBox cmbbxState1;
        private System.Windows.Forms.Label lblState1;
        private System.Windows.Forms.ComboBox cmbbxCountry1;
        private System.Windows.Forms.Label lblCountry1;
        private System.Windows.Forms.TextBox txtAddressInf1;
        private System.Windows.Forms.Label lblAddressInf1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtPhoneNo1;
        private System.Windows.Forms.Label lblContact1;
        private System.Windows.Forms.TextBox txtStaffName1;
        private System.Windows.Forms.Label lblStaffName1;
        private System.Windows.Forms.Button btncancle;
    }
}