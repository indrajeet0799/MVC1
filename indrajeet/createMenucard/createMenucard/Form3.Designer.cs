namespace createMenucard
{
    partial class frm3
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
            this.labMenu3 = new System.Windows.Forms.Label();
            this.labPrice3 = new System.Windows.Forms.Label();
            this.txtMenu3 = new System.Windows.Forms.TextBox();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labMenu3
            // 
            this.labMenu3.AutoSize = true;
            this.labMenu3.Location = new System.Drawing.Point(138, 98);
            this.labMenu3.Name = "labMenu3";
            this.labMenu3.Size = new System.Drawing.Size(53, 16);
            this.labMenu3.TabIndex = 0;
            this.labMenu3.Text = "Menu is";
            // 
            // labPrice3
            // 
            this.labPrice3.AutoSize = true;
            this.labPrice3.Location = new System.Drawing.Point(153, 202);
            this.labPrice3.Name = "labPrice3";
            this.labPrice3.Size = new System.Drawing.Size(38, 16);
            this.labPrice3.TabIndex = 1;
            this.labPrice3.Text = "Price";
            // 
            // txtMenu3
            // 
            this.txtMenu3.Location = new System.Drawing.Point(317, 98);
            this.txtMenu3.Name = "txtMenu3";
            this.txtMenu3.Size = new System.Drawing.Size(100, 22);
            this.txtMenu3.TabIndex = 2;
            // 
            // txtPrice3
            // 
            this.txtPrice3.Location = new System.Drawing.Point(317, 202);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.Size = new System.Drawing.Size(100, 22);
            this.txtPrice3.TabIndex = 3;
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrice3);
            this.Controls.Add(this.txtMenu3);
            this.Controls.Add(this.labPrice3);
            this.Controls.Add(this.labMenu3);
            this.Name = "frm3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMenu3;
        private System.Windows.Forms.Label labPrice3;
        private System.Windows.Forms.TextBox txtMenu3;
        private System.Windows.Forms.TextBox txtPrice3;
    }
}