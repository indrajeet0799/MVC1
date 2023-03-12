namespace Client_Student_Information_2
{
    partial class frmEnterExam
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
            this.cmbbxSelecttesttype = new System.Windows.Forms.ComboBox();
            this.btnEnterExam = new System.Windows.Forms.Button();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbbxSelecttesttype
            // 
            this.cmbbxSelecttesttype.FormattingEnabled = true;
            this.cmbbxSelecttesttype.Location = new System.Drawing.Point(265, 105);
            this.cmbbxSelecttesttype.Name = "cmbbxSelecttesttype";
            this.cmbbxSelecttesttype.Size = new System.Drawing.Size(268, 21);
            this.cmbbxSelecttesttype.TabIndex = 4;
            this.cmbbxSelecttesttype.SelectedIndexChanged += new System.EventHandler(this.cmbbxSelecttesttype_SelectedIndexChanged);
            // 
            // btnEnterExam
            // 
            this.btnEnterExam.BackColor = System.Drawing.Color.Yellow;
            this.btnEnterExam.FlatAppearance.BorderSize = 0;
            this.btnEnterExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterExam.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterExam.ForeColor = System.Drawing.Color.Black;
            this.btnEnterExam.Location = new System.Drawing.Point(297, 260);
            this.btnEnterExam.Name = "btnEnterExam";
            this.btnEnterExam.Size = new System.Drawing.Size(164, 48);
            this.btnEnterExam.TabIndex = 5;
            this.btnEnterExam.Text = "Enter Exam";
            this.btnEnterExam.UseVisualStyleBackColor = false;
            this.btnEnterExam.Click += new System.EventHandler(this.btnEnterExam_Click);
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegister.ForeColor = System.Drawing.Color.Blue;
            this.linkLabelRegister.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelRegister.Location = new System.Drawing.Point(602, 350);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(92, 25);
            this.linkLabelRegister.TabIndex = 6;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register";
            this.linkLabelRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Test Paper";
            // 
            // frmEnterExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.btnEnterExam);
            this.Controls.Add(this.cmbbxSelecttesttype);
            this.Name = "frmEnterExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Client_Enter_Exam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEnterExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbbxSelecttesttype;
        private System.Windows.Forms.Button btnEnterExam;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Label label1;
    }
}