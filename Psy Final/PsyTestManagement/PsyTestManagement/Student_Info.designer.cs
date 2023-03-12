namespace PsyTestManagement
{
    partial class frmStudentInfo
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
            this.grdStudentInfo = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbove18Fetch = new System.Windows.Forms.Button();
            this.btnBelow18Fetch = new System.Windows.Forms.Button();
            this.btnExcel1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStudentInfo
            // 
            this.grdStudentInfo.AllowUserToAddRows = false;
            this.grdStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStudentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentInfo.Location = new System.Drawing.Point(8, 140);
            this.grdStudentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grdStudentInfo.Name = "grdStudentInfo";
            this.grdStudentInfo.RowHeadersVisible = false;
            this.grdStudentInfo.RowHeadersWidth = 62;
            this.grdStudentInfo.RowTemplate.Height = 28;
            this.grdStudentInfo.Size = new System.Drawing.Size(972, 312);
            this.grdStudentInfo.TabIndex = 1;
            this.grdStudentInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_Info_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 40);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::PsyTestManagement.Properties.Resources.refresh_icon;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(300, 17);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 38);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PsyTestManagement.Properties.Resources.search_icon__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(200, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnAbove18Fetch
            // 
            this.btnAbove18Fetch.BackColor = System.Drawing.Color.Yellow;
            this.btnAbove18Fetch.FlatAppearance.BorderSize = 0;
            this.btnAbove18Fetch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAbove18Fetch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAbove18Fetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbove18Fetch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbove18Fetch.Location = new System.Drawing.Point(525, 33);
            this.btnAbove18Fetch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbove18Fetch.Name = "btnAbove18Fetch";
            this.btnAbove18Fetch.Size = new System.Drawing.Size(90, 32);
            this.btnAbove18Fetch.TabIndex = 6;
            this.btnAbove18Fetch.Text = "Above 18";
            this.btnAbove18Fetch.UseVisualStyleBackColor = false;
            this.btnAbove18Fetch.Click += new System.EventHandler(this.btnAbove18Fetch_Click);
            // 
            // btnBelow18Fetch
            // 
            this.btnBelow18Fetch.BackColor = System.Drawing.Color.Yellow;
            this.btnBelow18Fetch.FlatAppearance.BorderSize = 0;
            this.btnBelow18Fetch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBelow18Fetch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBelow18Fetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBelow18Fetch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBelow18Fetch.Location = new System.Drawing.Point(652, 33);
            this.btnBelow18Fetch.Margin = new System.Windows.Forms.Padding(2);
            this.btnBelow18Fetch.Name = "btnBelow18Fetch";
            this.btnBelow18Fetch.Size = new System.Drawing.Size(90, 32);
            this.btnBelow18Fetch.TabIndex = 7;
            this.btnBelow18Fetch.Text = "Below 18";
            this.btnBelow18Fetch.UseVisualStyleBackColor = false;
            this.btnBelow18Fetch.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExcel1
            // 
            this.btnExcel1.BackgroundImage = global::PsyTestManagement.Properties.Resources.excel_icon__1_;
            this.btnExcel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel1.Location = new System.Drawing.Point(375, 18);
            this.btnExcel1.Name = "btnExcel1";
            this.btnExcel1.Size = new System.Drawing.Size(39, 38);
            this.btnExcel1.TabIndex = 8;
            this.btnExcel1.UseVisualStyleBackColor = true;
            this.btnExcel1.Click += new System.EventHandler(this.btnExcel1_Click);
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 469);
            this.Controls.Add(this.btnExcel1);
            this.Controls.Add(this.btnBelow18Fetch);
            this.Controls.Add(this.btnAbove18Fetch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grdStudentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Student Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudent_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStudentInfo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAbove18Fetch;
        private System.Windows.Forms.Button btnBelow18Fetch;
        private System.Windows.Forms.Button btnExcel1;
    }
}

