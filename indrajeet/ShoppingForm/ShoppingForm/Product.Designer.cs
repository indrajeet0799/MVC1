namespace ShoppingForm
{
    partial class frmProduct
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
            this.lblTypeProduct = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbTypeProduct = new System.Windows.Forms.ComboBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeProduct
            // 
            this.lblTypeProduct.AutoSize = true;
            this.lblTypeProduct.Location = new System.Drawing.Point(109, 42);
            this.lblTypeProduct.Name = "lblTypeProduct";
            this.lblTypeProduct.Size = new System.Drawing.Size(39, 16);
            this.lblTypeProduct.TabIndex = 0;
            this.lblTypeProduct.Text = "Type";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(108, 108);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(53, 16);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // cmbTypeProduct
            // 
            this.cmbTypeProduct.FormattingEnabled = true;
            this.cmbTypeProduct.Location = new System.Drawing.Point(238, 34);
            this.cmbTypeProduct.Name = "cmbTypeProduct";
            this.cmbTypeProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeProduct.TabIndex = 2;
            this.cmbTypeProduct.SelectedIndexChanged += new System.EventHandler(this.cmbTypeProduct_SelectedIndexChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(238, 102);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 22);
            this.txtProduct.TabIndex = 3;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(162, 228);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProduct.TabIndex = 4;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.Location = new System.Drawing.Point(353, 228);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(75, 23);
            this.btnClearProduct.TabIndex = 5;
            this.btnClearProduct.Text = "Clear";
            this.btnClearProduct.UseVisualStyleBackColor = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.cmbTypeProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblTypeProduct);
            this.Name = "frmProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbTypeProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnClearProduct;
    }
}