namespace ShoppingForm
{
    partial class Ordercs
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTypeOrder = new System.Windows.Forms.Label();
            this.lblProductOrder = new System.Windows.Forms.Label();
            this.lblPriceOrder = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datagridviewOroder = new System.Windows.Forms.DataGridView();
            this.btnLogoutOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewOroder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Information";
            // 
            // lblTypeOrder
            // 
            this.lblTypeOrder.AutoSize = true;
            this.lblTypeOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOrder.Location = new System.Drawing.Point(136, 54);
            this.lblTypeOrder.Name = "lblTypeOrder";
            this.lblTypeOrder.Size = new System.Drawing.Size(53, 23);
            this.lblTypeOrder.TabIndex = 1;
            this.lblTypeOrder.Text = "Type";
            // 
            // lblProductOrder
            // 
            this.lblProductOrder.AutoSize = true;
            this.lblProductOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductOrder.Location = new System.Drawing.Point(136, 88);
            this.lblProductOrder.Name = "lblProductOrder";
            this.lblProductOrder.Size = new System.Drawing.Size(78, 23);
            this.lblProductOrder.TabIndex = 2;
            this.lblProductOrder.Text = "Product";
            // 
            // lblPriceOrder
            // 
            this.lblPriceOrder.AutoSize = true;
            this.lblPriceOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceOrder.Location = new System.Drawing.Point(95, 468);
            this.lblPriceOrder.Name = "lblPriceOrder";
            this.lblPriceOrder.Size = new System.Drawing.Size(55, 23);
            this.lblPriceOrder.TabIndex = 3;
            this.lblPriceOrder.Text = "Price";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(282, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(282, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 6;
            // 
            // datagridviewOroder
            // 
            this.datagridviewOroder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewOroder.Location = new System.Drawing.Point(99, 157);
            this.datagridviewOroder.Name = "datagridviewOroder";
            this.datagridviewOroder.RowHeadersWidth = 51;
            this.datagridviewOroder.RowTemplate.Height = 24;
            this.datagridviewOroder.Size = new System.Drawing.Size(368, 255);
            this.datagridviewOroder.TabIndex = 7;
            this.datagridviewOroder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewOroder_CellContentClick);
            // 
            // btnLogoutOrder
            // 
            this.btnLogoutOrder.Location = new System.Drawing.Point(172, 557);
            this.btnLogoutOrder.Name = "btnLogoutOrder";
            this.btnLogoutOrder.Size = new System.Drawing.Size(92, 47);
            this.btnLogoutOrder.TabIndex = 8;
            this.btnLogoutOrder.Text = "Logout";
            this.btnLogoutOrder.UseVisualStyleBackColor = true;
            this.btnLogoutOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(328, 557);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(89, 47);
            this.btnClearOrder.TabIndex = 9;
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            // 
            // Ordercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 616);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnLogoutOrder);
            this.Controls.Add(this.datagridviewOroder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPriceOrder);
            this.Controls.Add(this.lblProductOrder);
            this.Controls.Add(this.lblTypeOrder);
            this.Controls.Add(this.label1);
            this.Name = "Ordercs";
            this.Text = "Ordercs";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewOroder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTypeOrder;
        private System.Windows.Forms.Label lblProductOrder;
        private System.Windows.Forms.Label lblPriceOrder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView datagridviewOroder;
        private System.Windows.Forms.Button btnLogoutOrder;
        private System.Windows.Forms.Button btnClearOrder;
    }
}