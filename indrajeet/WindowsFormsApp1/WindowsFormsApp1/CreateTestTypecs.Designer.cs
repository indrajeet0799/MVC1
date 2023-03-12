namespace WindowsFormsApp1
{
    partial class frmTestTypecs
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
            this.labCreateTestType = new System.Windows.Forms.Label();
            this.labTestType = new System.Windows.Forms.Label();
            this.labDuration = new System.Windows.Forms.Label();
            this.labMarks = new System.Windows.Forms.Label();
            this.txtTestTyoe = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCreateTestType
            // 
            this.labCreateTestType.AutoSize = true;
            this.labCreateTestType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCreateTestType.Location = new System.Drawing.Point(53, 36);
            this.labCreateTestType.Name = "labCreateTestType";
            this.labCreateTestType.Size = new System.Drawing.Size(171, 24);
            this.labCreateTestType.TabIndex = 0;
            this.labCreateTestType.Text = "Create Test Type";
            // 
            // labTestType
            // 
            this.labTestType.AutoSize = true;
            this.labTestType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestType.Location = new System.Drawing.Point(129, 135);
            this.labTestType.Name = "labTestType";
            this.labTestType.Size = new System.Drawing.Size(84, 19);
            this.labTestType.TabIndex = 1;
            this.labTestType.Text = "Test Type";
            // 
            // labDuration
            // 
            this.labDuration.AutoSize = true;
            this.labDuration.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDuration.Location = new System.Drawing.Point(129, 206);
            this.labDuration.Name = "labDuration";
            this.labDuration.Size = new System.Drawing.Size(77, 19);
            this.labDuration.TabIndex = 2;
            this.labDuration.Text = "Duration";
            // 
            // labMarks
            // 
            this.labMarks.AutoSize = true;
            this.labMarks.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMarks.Location = new System.Drawing.Point(129, 278);
            this.labMarks.Name = "labMarks";
            this.labMarks.Size = new System.Drawing.Size(56, 19);
            this.labMarks.TabIndex = 3;
            this.labMarks.Text = "Marks";
            // 
            // txtTestTyoe
            // 
            this.txtTestTyoe.Location = new System.Drawing.Point(390, 135);
            this.txtTestTyoe.Name = "txtTestTyoe";
            this.txtTestTyoe.Size = new System.Drawing.Size(188, 22);
            this.txtTestTyoe.TabIndex = 4;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(390, 281);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(188, 22);
            this.txtMarks.TabIndex = 5;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(390, 206);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(188, 22);
            this.txtDuration.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(133, 408);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(369, 408);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // frmTestTypecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 536);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtTestTyoe);
            this.Controls.Add(this.labMarks);
            this.Controls.Add(this.labDuration);
            this.Controls.Add(this.labTestType);
            this.Controls.Add(this.labCreateTestType);
            this.Name = "frmTestTypecs";
            this.Text = "CreateTestTypecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCreateTestType;
        private System.Windows.Forms.Label labTestType;
        private System.Windows.Forms.Label labDuration;
        private System.Windows.Forms.Label labMarks;
        private System.Windows.Forms.TextBox txtTestTyoe;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}