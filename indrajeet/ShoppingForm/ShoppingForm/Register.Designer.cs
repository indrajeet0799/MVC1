namespace ShoppingForm
{
    partial class frmRegister
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
            this.lblTypeRegister = new System.Windows.Forms.Label();
            this.lblNameRegister = new System.Windows.Forms.Label();
            this.lblEmailRegister = new System.Windows.Forms.Label();
            this.lblContactRegister = new System.Windows.Forms.Label();
            this.lblGenderRegister = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.cmbTypeRegister = new System.Windows.Forms.ComboBox();
            this.txtNameRegister = new System.Windows.Forms.TextBox();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClaerRegister = new System.Windows.Forms.Button();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.txtState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTypeRegister
            // 
            this.lblTypeRegister.AutoSize = true;
            this.lblTypeRegister.Location = new System.Drawing.Point(86, 63);
            this.lblTypeRegister.Name = "lblTypeRegister";
            this.lblTypeRegister.Size = new System.Drawing.Size(39, 16);
            this.lblTypeRegister.TabIndex = 0;
            this.lblTypeRegister.Text = "Type";
            this.lblTypeRegister.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNameRegister
            // 
            this.lblNameRegister.AutoSize = true;
            this.lblNameRegister.Location = new System.Drawing.Point(86, 108);
            this.lblNameRegister.Name = "lblNameRegister";
            this.lblNameRegister.Size = new System.Drawing.Size(44, 16);
            this.lblNameRegister.TabIndex = 1;
            this.lblNameRegister.Text = "Name";
            // 
            // lblEmailRegister
            // 
            this.lblEmailRegister.AutoSize = true;
            this.lblEmailRegister.Location = new System.Drawing.Point(86, 168);
            this.lblEmailRegister.Name = "lblEmailRegister";
            this.lblEmailRegister.Size = new System.Drawing.Size(57, 16);
            this.lblEmailRegister.TabIndex = 2;
            this.lblEmailRegister.Text = "Email ID";
            // 
            // lblContactRegister
            // 
            this.lblContactRegister.AutoSize = true;
            this.lblContactRegister.Location = new System.Drawing.Point(92, 226);
            this.lblContactRegister.Name = "lblContactRegister";
            this.lblContactRegister.Size = new System.Drawing.Size(73, 16);
            this.lblContactRegister.TabIndex = 3;
            this.lblContactRegister.Text = "Contact No";
            // 
            // lblGenderRegister
            // 
            this.lblGenderRegister.AutoSize = true;
            this.lblGenderRegister.Location = new System.Drawing.Point(86, 291);
            this.lblGenderRegister.Name = "lblGenderRegister";
            this.lblGenderRegister.Size = new System.Drawing.Size(52, 16);
            this.lblGenderRegister.TabIndex = 4;
            this.lblGenderRegister.Text = "Gender";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(92, 356);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 16);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State";
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Location = new System.Drawing.Point(92, 411);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(67, 16);
            this.lblPasswordRegister.TabIndex = 6;
            this.lblPasswordRegister.Text = "Password";
            // 
            // cmbTypeRegister
            // 
            this.cmbTypeRegister.FormattingEnabled = true;
            this.cmbTypeRegister.Items.AddRange(new object[] {
            "Admin",
            "customer"});
            this.cmbTypeRegister.Location = new System.Drawing.Point(234, 55);
            this.cmbTypeRegister.Name = "cmbTypeRegister";
            this.cmbTypeRegister.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeRegister.TabIndex = 7;
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.Location = new System.Drawing.Point(234, 108);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(100, 22);
            this.txtNameRegister.TabIndex = 8;
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.Location = new System.Drawing.Point(234, 162);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(100, 22);
            this.txtEmailRegister.TabIndex = 9;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(234, 226);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(100, 22);
            this.txtContactNo.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(234, 405);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(89, 464);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 37);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClaerRegister
            // 
            this.btnClaerRegister.Location = new System.Drawing.Point(271, 464);
            this.btnClaerRegister.Name = "btnClaerRegister";
            this.btnClaerRegister.Size = new System.Drawing.Size(84, 37);
            this.btnClaerRegister.TabIndex = 14;
            this.btnClaerRegister.Text = "Clear";
            this.btnClaerRegister.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(234, 287);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 15;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(342, 287);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 16;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(234, 350);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 22);
            this.txtState.TabIndex = 17;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 565);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.btnClaerRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.txtNameRegister);
            this.Controls.Add(this.cmbTypeRegister);
            this.Controls.Add(this.lblPasswordRegister);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblGenderRegister);
            this.Controls.Add(this.lblContactRegister);
            this.Controls.Add(this.lblEmailRegister);
            this.Controls.Add(this.lblNameRegister);
            this.Controls.Add(this.lblTypeRegister);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeRegister;
        private System.Windows.Forms.Label lblNameRegister;
        private System.Windows.Forms.Label lblEmailRegister;
        private System.Windows.Forms.Label lblContactRegister;
        private System.Windows.Forms.Label lblGenderRegister;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPasswordRegister;
        private System.Windows.Forms.ComboBox cmbTypeRegister;
        private System.Windows.Forms.TextBox txtNameRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClaerRegister;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.TextBox txtState;
    }
}