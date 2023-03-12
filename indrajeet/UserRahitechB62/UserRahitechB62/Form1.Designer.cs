namespace UserRahitechB62
{
    partial class Frm
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
            this.lalName = new System.Windows.Forms.Label();
            this.lalAddress = new System.Windows.Forms.Label();
            this.lalRahitech = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.Location = new System.Drawing.Point(170, 124);
            this.lalName.Name = "lalName";
            this.lalName.Size = new System.Drawing.Size(44, 16);
            this.lalName.TabIndex = 0;
            this.lalName.Text = "Name";
            // 
            // lalAddress
            // 
            this.lalAddress.AutoSize = true;
            this.lalAddress.Location = new System.Drawing.Point(170, 222);
            this.lalAddress.Name = "lalAddress";
            this.lalAddress.Size = new System.Drawing.Size(58, 16);
            this.lalAddress.TabIndex = 1;
            this.lalAddress.Text = "Address";
            // 
            // lalRahitech
            // 
            this.lalRahitech.AutoSize = true;
            this.lalRahitech.Location = new System.Drawing.Point(278, 39);
            this.lalRahitech.Name = "lalRahitech";
            this.lalRahitech.Size = new System.Drawing.Size(60, 16);
            this.lalRahitech.TabIndex = 2;
            this.lalRahitech.Text = "Rahitech";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(363, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(364, 216);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(228, 336);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 41);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(170, 82);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 16);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "id";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(364, 82);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(408, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 41);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(581, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 41);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lalRahitech);
            this.Controls.Add(this.lalAddress);
            this.Controls.Add(this.lalName);
            this.Name = "Frm";
            this.Text = "Form1";
           // this.Load += new System.EventHandler(this.Frm_Load);//
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalName;
        private System.Windows.Forms.Label lalAddress;
        private System.Windows.Forms.Label lalRahitech;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

