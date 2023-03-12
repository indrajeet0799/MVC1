namespace createMenucard
{
    partial class frmMenu
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
            this.labType = new System.Windows.Forms.Label();
            this.labMenu = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.cmbbxMenu = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(164, 158);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(39, 16);
            this.labType.TabIndex = 0;
            this.labType.Text = "Type";
            this.labType.Click += new System.EventHandler(this.labType_Click);
            // 
            // labMenu
            // 
            this.labMenu.AutoSize = true;
            this.labMenu.Location = new System.Drawing.Point(163, 217);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(40, 16);
            this.labMenu.TabIndex = 1;
            this.labMenu.Text = "Menu";
            this.labMenu.Click += new System.EventHandler(this.label2_Click);
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(158, 277);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(38, 16);
            this.labPrice.TabIndex = 2;
            this.labPrice.Text = "Price";
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Items.AddRange(new object[] {
            "MH",
            "GJ",
            "SOUTH INDIAN"});
            this.cmbbxType.Location = new System.Drawing.Point(312, 136);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(121, 24);
            this.cmbbxType.TabIndex = 3;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // cmbbxMenu
            // 
            this.cmbbxMenu.FormattingEnabled = true;
            this.cmbbxMenu.Location = new System.Drawing.Point(312, 214);
            this.cmbbxMenu.Name = "cmbbxMenu";
            this.cmbbxMenu.Size = new System.Drawing.Size(121, 24);
            this.cmbbxMenu.TabIndex = 4;
            this.cmbbxMenu.SelectedIndexChanged += new System.EventHandler(this.cmbbxMenu_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(312, 286);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(287, 377);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(88, 41);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbbxMenu);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labMenu);
            this.Controls.Add(this.labType);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.ComboBox cmbbxMenu;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnShow;
    }
}