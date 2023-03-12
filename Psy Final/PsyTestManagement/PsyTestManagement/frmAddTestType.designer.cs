
namespace TestManagement
{
    partial class frmAddTestType
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
            this.lblTestTypeName = new System.Windows.Forms.Label();
            this.txtTestTypeName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbbxStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestTypeName
            // 
            this.lblTestTypeName.AutoSize = true;
            this.lblTestTypeName.BackColor = System.Drawing.Color.Transparent;
            this.lblTestTypeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypeName.Location = new System.Drawing.Point(75, 35);
            this.lblTestTypeName.Name = "lblTestTypeName";
            this.lblTestTypeName.Size = new System.Drawing.Size(123, 18);
            this.lblTestTypeName.TabIndex = 0;
            this.lblTestTypeName.Text = "Test Type Name:";
            // 
            // txtTestTypeName
            // 
            this.txtTestTypeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestTypeName.Location = new System.Drawing.Point(237, 32);
            this.txtTestTypeName.Name = "txtTestTypeName";
            this.txtTestTypeName.Size = new System.Drawing.Size(194, 26);
            this.txtTestTypeName.TabIndex = 1;
            this.txtTestTypeName.TextChanged += new System.EventHandler(this.txtTestTypeName_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(75, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 18);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // cmbbxStatus
            // 
            this.cmbbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxStatus.FormattingEnabled = true;
            this.cmbbxStatus.Location = new System.Drawing.Point(237, 92);
            this.cmbbxStatus.Name = "cmbbxStatus";
            this.cmbbxStatus.Size = new System.Drawing.Size(194, 26);
            this.cmbbxStatus.TabIndex = 3;
            this.cmbbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbbxStatus_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(195, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbbxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTestTypeName);
            this.Controls.Add(this.lblTestTypeName);
            this.Name = "frmAddTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddTestType";
            this.Load += new System.EventHandler(this.frmAddTestType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestTypeName;
        private System.Windows.Forms.TextBox txtTestTypeName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbbxStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}