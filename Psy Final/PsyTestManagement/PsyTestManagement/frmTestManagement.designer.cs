
namespace TestManagement
{
    partial class frmTestManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestManagement));
            this.btnNewTestPaper = new System.Windows.Forms.Button();
            this.grdTestPaper = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTestPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewTestPaper
            // 
            this.btnNewTestPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewTestPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewTestPaper.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTestPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTestPaper.ForeColor = System.Drawing.Color.White;
            this.btnNewTestPaper.Location = new System.Drawing.Point(18, 13);
            this.btnNewTestPaper.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTestPaper.Name = "btnNewTestPaper";
            this.btnNewTestPaper.Size = new System.Drawing.Size(238, 54);
            this.btnNewTestPaper.TabIndex = 0;
            this.btnNewTestPaper.Text = "New Test Paper";
            this.btnNewTestPaper.UseVisualStyleBackColor = false;
            this.btnNewTestPaper.Click += new System.EventHandler(this.btnNewTestPaper_Click);
            // 
            // grdTestPaper
            // 
            this.grdTestPaper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTestPaper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTestPaper.BackgroundColor = System.Drawing.Color.White;
            this.grdTestPaper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTestPaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTestPaper.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdTestPaper.Location = new System.Drawing.Point(10, 74);
            this.grdTestPaper.Name = "grdTestPaper";
            this.grdTestPaper.RowHeadersVisible = false;
            this.grdTestPaper.RowHeadersWidth = 62;
            this.grdTestPaper.Size = new System.Drawing.Size(927, 379);
            this.grdTestPaper.TabIndex = 1;
            this.grdTestPaper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTestPaper_CellClick);
            this.grdTestPaper.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdTestPaper_CellFormatting);
            this.grdTestPaper.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdTestPaper_DataBindingComplete);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(273, 24);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 36);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(475, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(424, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // frmTestManagement
            // 
            this.AccessibleName = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 465);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grdTestPaper);
            this.Controls.Add(this.btnNewTestPaper);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTestManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTestManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTestPaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewTestPaper;
        private System.Windows.Forms.DataGridView grdTestPaper;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

