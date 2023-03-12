namespace ShoppingForm
{
    partial class frmSize
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
            this.lblTypeSize = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblRealPrice = new System.Windows.Forms.Label();
            this.cmbTypeSize = new System.Windows.Forms.ComboBox();
            this.cmbProductSize = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.txtRealPrice = new System.Windows.Forms.TextBox();
            this.btnSaveSize = new System.Windows.Forms.Button();
            this.btnClearSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeSize
            // 
            this.lblTypeSize.AutoSize = true;
            this.lblTypeSize.Location = new System.Drawing.Point(158, 56);
            this.lblTypeSize.Name = "lblTypeSize";
            this.lblTypeSize.Size = new System.Drawing.Size(39, 16);
            this.lblTypeSize.TabIndex = 0;
            this.lblTypeSize.Text = "Type";
            this.lblTypeSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(158, 103);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(53, 16);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(158, 151);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 16);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Location = new System.Drawing.Point(158, 189);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(37, 16);
            this.lblMRP.TabIndex = 3;
            this.lblMRP.Text = "MRP";
            // 
            // lblRealPrice
            // 
            this.lblRealPrice.AutoSize = true;
            this.lblRealPrice.Location = new System.Drawing.Point(158, 233);
            this.lblRealPrice.Name = "lblRealPrice";
            this.lblRealPrice.Size = new System.Drawing.Size(67, 16);
            this.lblRealPrice.TabIndex = 4;
            this.lblRealPrice.Text = "RealPrice";
            // 
            // cmbTypeSize
            // 
            this.cmbTypeSize.FormattingEnabled = true;
            this.cmbTypeSize.Location = new System.Drawing.Point(269, 56);
            this.cmbTypeSize.Name = "cmbTypeSize";
            this.cmbTypeSize.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeSize.TabIndex = 5;
            this.cmbTypeSize.SelectedIndexChanged += new System.EventHandler(this.cmbTypeSize_SelectedIndexChanged);
            // 
            // cmbProductSize
            // 
            this.cmbProductSize.FormattingEnabled = true;
            this.cmbProductSize.Location = new System.Drawing.Point(269, 100);
            this.cmbProductSize.Name = "cmbProductSize";
            this.cmbProductSize.Size = new System.Drawing.Size(121, 24);
            this.cmbProductSize.TabIndex = 6;
            this.cmbProductSize.SelectedIndexChanged += new System.EventHandler(this.cmbProductSize_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(269, 148);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 7;
            // 
            // txtMRP
            // 
            this.txtMRP.Location = new System.Drawing.Point(269, 183);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(100, 22);
            this.txtMRP.TabIndex = 8;
            // 
            // txtRealPrice
            // 
            this.txtRealPrice.Location = new System.Drawing.Point(269, 233);
            this.txtRealPrice.Name = "txtRealPrice";
            this.txtRealPrice.Size = new System.Drawing.Size(100, 22);
            this.txtRealPrice.TabIndex = 9;
            // 
            // btnSaveSize
            // 
            this.btnSaveSize.Location = new System.Drawing.Point(150, 337);
            this.btnSaveSize.Name = "btnSaveSize";
            this.btnSaveSize.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSize.TabIndex = 10;
            this.btnSaveSize.Text = "Save";
            this.btnSaveSize.UseVisualStyleBackColor = true;
            this.btnSaveSize.Click += new System.EventHandler(this.btnSaveSize_Click);
            // 
            // btnClearSize
            // 
            this.btnClearSize.Location = new System.Drawing.Point(391, 337);
            this.btnClearSize.Name = "btnClearSize";
            this.btnClearSize.Size = new System.Drawing.Size(75, 23);
            this.btnClearSize.TabIndex = 11;
            this.btnClearSize.Text = "Clear";
            this.btnClearSize.UseVisualStyleBackColor = true;
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearSize);
            this.Controls.Add(this.btnSaveSize);
            this.Controls.Add(this.txtRealPrice);
            this.Controls.Add(this.txtMRP);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbProductSize);
            this.Controls.Add(this.cmbTypeSize);
            this.Controls.Add(this.lblRealPrice);
            this.Controls.Add(this.lblMRP);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblTypeSize);
            this.Name = "frmSize";
            this.Text = "Size";
            this.Load += new System.EventHandler(this.frmSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeSize;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblRealPrice;
        private System.Windows.Forms.ComboBox cmbTypeSize;
        private System.Windows.Forms.ComboBox cmbProductSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.TextBox txtRealPrice;
        private System.Windows.Forms.Button btnSaveSize;
        private System.Windows.Forms.Button btnClearSize;
    }
}