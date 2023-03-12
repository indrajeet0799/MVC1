namespace PsyTestManagement
{
    partial class frmChangePassword
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtbxOldPass = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.btnUpdatePassWord = new System.Windows.Forms.Button();
            this.txtbxConfirmPass = new System.Windows.Forms.TextBox();
            this.txtbxNewPass = new System.Windows.Forms.TextBox();
            this.lblcnfirmpassword = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(694, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(204, 42);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtbxOldPass
            // 
            this.txtbxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxOldPass.Location = new System.Drawing.Point(562, 169);
            this.txtbxOldPass.Name = "txtbxOldPass";
            this.txtbxOldPass.Size = new System.Drawing.Size(311, 29);
            this.txtbxOldPass.TabIndex = 14;
            this.txtbxOldPass.TextChanged += new System.EventHandler(this.txtbxOldPass_TextChanged);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(291, 173);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(195, 25);
            this.lblOldPassword.TabIndex = 13;
            this.lblOldPassword.Text = "OLD PASSWORD";
            // 
            // btnUpdatePassWord
            // 
            this.btnUpdatePassWord.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdatePassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassWord.Location = new System.Drawing.Point(356, 441);
            this.btnUpdatePassWord.Name = "btnUpdatePassWord";
            this.btnUpdatePassWord.Size = new System.Drawing.Size(294, 42);
            this.btnUpdatePassWord.TabIndex = 12;
            this.btnUpdatePassWord.Text = "UPDATE PASSWORD";
            this.btnUpdatePassWord.UseVisualStyleBackColor = false;
            this.btnUpdatePassWord.Click += new System.EventHandler(this.btnUpdatePassWord_Click);
            // 
            // txtbxConfirmPass
            // 
            this.txtbxConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirmPass.Location = new System.Drawing.Point(562, 313);
            this.txtbxConfirmPass.Name = "txtbxConfirmPass";
            this.txtbxConfirmPass.Size = new System.Drawing.Size(311, 29);
            this.txtbxConfirmPass.TabIndex = 11;
            // 
            // txtbxNewPass
            // 
            this.txtbxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNewPass.Location = new System.Drawing.Point(562, 236);
            this.txtbxNewPass.Name = "txtbxNewPass";
            this.txtbxNewPass.Size = new System.Drawing.Size(311, 29);
            this.txtbxNewPass.TabIndex = 10;
            // 
            // lblcnfirmpassword
            // 
            this.lblcnfirmpassword.AutoSize = true;
            this.lblcnfirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblcnfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnfirmpassword.Location = new System.Drawing.Point(226, 317);
            this.lblcnfirmpassword.Name = "lblcnfirmpassword";
            this.lblcnfirmpassword.Size = new System.Drawing.Size(260, 25);
            this.lblcnfirmpassword.TabIndex = 9;
            this.lblcnfirmpassword.Text = "CONFIRM  PASSWORD";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(278, 240);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(208, 25);
            this.lblpassword.TabIndex = 8;
            this.lblpassword.Text = " NEW PASSWORD";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 775);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtbxOldPass);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.btnUpdatePassWord);
            this.Controls.Add(this.txtbxConfirmPass);
            this.Controls.Add(this.txtbxNewPass);
            this.Controls.Add(this.lblcnfirmpassword);
            this.Controls.Add(this.lblpassword);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtbxOldPass;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Button btnUpdatePassWord;
        private System.Windows.Forms.TextBox txtbxConfirmPass;
        private System.Windows.Forms.TextBox txtbxNewPass;
        private System.Windows.Forms.Label lblcnfirmpassword;
        private System.Windows.Forms.Label lblpassword;
    }
}