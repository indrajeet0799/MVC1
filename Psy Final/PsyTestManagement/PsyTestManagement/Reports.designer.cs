namespace PsyTestManagement
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnyearly = new System.Windows.Forms.Button();
            this.btnmonthly = new System.Windows.Forms.Button();
            this.btntesttype = new System.Windows.Forms.Button();
            this.btnagediffcount = new System.Windows.Forms.Button();
            this.btndailypayment = new System.Windows.Forms.Button();
            this.grdviewdailyclient = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txttotalpayment = new System.Windows.Forms.TextBox();
            this.btndaily = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.calender = new System.Windows.Forms.DateTimePicker();
            this.btnpayment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lbltotalpayment = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewdailyclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnyearly
            // 
            this.btnyearly.BackColor = System.Drawing.Color.PaleGreen;
            this.btnyearly.FlatAppearance.BorderSize = 0;
            this.btnyearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyearly.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyearly.Location = new System.Drawing.Point(879, 159);
            this.btnyearly.Margin = new System.Windows.Forms.Padding(2);
            this.btnyearly.Name = "btnyearly";
            this.btnyearly.Size = new System.Drawing.Size(33, 26);
            this.btnyearly.TabIndex = 29;
            this.btnyearly.Text = "YY";
            this.btnyearly.UseVisualStyleBackColor = false;
            this.btnyearly.Click += new System.EventHandler(this.btnyearlypayment_Click);
            // 
            // btnmonthly
            // 
            this.btnmonthly.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnmonthly.FlatAppearance.BorderSize = 0;
            this.btnmonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmonthly.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmonthly.Location = new System.Drawing.Point(829, 159);
            this.btnmonthly.Margin = new System.Windows.Forms.Padding(2);
            this.btnmonthly.Name = "btnmonthly";
            this.btnmonthly.Size = new System.Drawing.Size(33, 26);
            this.btnmonthly.TabIndex = 26;
            this.btnmonthly.Text = "MM";
            this.btnmonthly.UseVisualStyleBackColor = false;
            this.btnmonthly.Click += new System.EventHandler(this.btnmonthly_Click);
            // 
            // btntesttype
            // 
            this.btntesttype.BackColor = System.Drawing.Color.Plum;
            this.btntesttype.FlatAppearance.BorderSize = 0;
            this.btntesttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntesttype.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntesttype.Location = new System.Drawing.Point(334, 27);
            this.btntesttype.Margin = new System.Windows.Forms.Padding(2);
            this.btntesttype.Name = "btntesttype";
            this.btntesttype.Size = new System.Drawing.Size(119, 44);
            this.btntesttype.TabIndex = 28;
            this.btntesttype.Text = "Test Type";
            this.btntesttype.UseVisualStyleBackColor = false;
            this.btntesttype.Click += new System.EventHandler(this.btntesttype_Click);
            // 
            // btnagediffcount
            // 
            this.btnagediffcount.BackColor = System.Drawing.Color.SkyBlue;
            this.btnagediffcount.FlatAppearance.BorderSize = 0;
            this.btnagediffcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagediffcount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagediffcount.Location = new System.Drawing.Point(586, 27);
            this.btnagediffcount.Margin = new System.Windows.Forms.Padding(2);
            this.btnagediffcount.Name = "btnagediffcount";
            this.btnagediffcount.Size = new System.Drawing.Size(123, 44);
            this.btnagediffcount.TabIndex = 27;
            this.btnagediffcount.Text = "Client ( Age)";
            this.btnagediffcount.UseVisualStyleBackColor = false;
            this.btnagediffcount.Click += new System.EventHandler(this.btnagediffcount_Click);
            // 
            // btndailypayment
            // 
            this.btndailypayment.BackColor = System.Drawing.Color.SkyBlue;
            this.btndailypayment.FlatAppearance.BorderSize = 0;
            this.btndailypayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndailypayment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndailypayment.Location = new System.Drawing.Point(104, 27);
            this.btndailypayment.Margin = new System.Windows.Forms.Padding(2);
            this.btndailypayment.Name = "btndailypayment";
            this.btndailypayment.Size = new System.Drawing.Size(116, 44);
            this.btndailypayment.TabIndex = 25;
            this.btndailypayment.Text = "Payment";
            this.btndailypayment.UseVisualStyleBackColor = false;
            this.btndailypayment.Click += new System.EventHandler(this.btndailypayment_Click);
            // 
            // grdviewdailyclient
            // 
            this.grdviewdailyclient.AllowUserToAddRows = false;
            this.grdviewdailyclient.AllowUserToDeleteRows = false;
            this.grdviewdailyclient.AllowUserToResizeColumns = false;
            this.grdviewdailyclient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdviewdailyclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdviewdailyclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdviewdailyclient.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdviewdailyclient.Location = new System.Drawing.Point(30, 194);
            this.grdviewdailyclient.Margin = new System.Windows.Forms.Padding(2);
            this.grdviewdailyclient.Name = "grdviewdailyclient";
            this.grdviewdailyclient.RowHeadersVisible = false;
            this.grdviewdailyclient.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdviewdailyclient.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdviewdailyclient.RowTemplate.Height = 28;
            this.grdviewdailyclient.Size = new System.Drawing.Size(1128, 282);
            this.grdviewdailyclient.TabIndex = 30;
            this.grdviewdailyclient.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdviewdailyclient_DataBindingComplete);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(115, 181);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(989, 363);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 88);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 115);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 41;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.Leave += new System.EventHandler(this.dateTimePicker2_Leave);
            // 
            // txttotalpayment
            // 
            this.txttotalpayment.Location = new System.Drawing.Point(902, 148);
            this.txttotalpayment.Margin = new System.Windows.Forms.Padding(2);
            this.txttotalpayment.Name = "txttotalpayment";
            this.txttotalpayment.Size = new System.Drawing.Size(119, 20);
            this.txttotalpayment.TabIndex = 43;
            // 
            // btndaily
            // 
            this.btndaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndaily.Location = new System.Drawing.Point(785, 159);
            this.btndaily.Margin = new System.Windows.Forms.Padding(2);
            this.btndaily.Name = "btndaily";
            this.btndaily.Size = new System.Drawing.Size(33, 26);
            this.btndaily.TabIndex = 45;
            this.btndaily.Text = "DD";
            this.btndaily.UseVisualStyleBackColor = true;
            this.btndaily.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "label3";
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(902, 116);
            this.calender.Margin = new System.Windows.Forms.Padding(2);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(135, 20);
            this.calender.TabIndex = 47;
            this.calender.ValueChanged += new System.EventHandler(this.calender_ValueChanged);
            // 
            // btnpayment
            // 
            this.btnpayment.BackColor = System.Drawing.Color.Plum;
            this.btnpayment.FlatAppearance.BorderSize = 0;
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.Location = new System.Drawing.Point(835, 27);
            this.btnpayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(119, 44);
            this.btnpayment.TabIndex = 48;
            this.btnpayment.Text = "Payment Graph";
            this.btnpayment.UseVisualStyleBackColor = false;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "From Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "To Date";
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(510, 97);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(55, 19);
            this.lblsearch.TabIndex = 51;
            this.lblsearch.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(569, 98);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(131, 20);
            this.txtsearch.TabIndex = 52;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lbltotalpayment
            // 
            this.lbltotalpayment.AutoSize = true;
            this.lbltotalpayment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpayment.Location = new System.Drawing.Point(791, 149);
            this.lbltotalpayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalpayment.Name = "lbltotalpayment";
            this.lbltotalpayment.Size = new System.Drawing.Size(79, 16);
            this.lbltotalpayment.TabIndex = 53;
            this.lbltotalpayment.Text = "Total Fees";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(115, 205);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(989, 363);
            this.chart2.TabIndex = 54;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(115, 223);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(989, 346);
            this.chart3.TabIndex = 55;
            this.chart3.Text = "chart3";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 487);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.lbltotalpayment);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnpayment);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndaily);
            this.Controls.Add(this.txttotalpayment);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.grdviewdailyclient);
            this.Controls.Add(this.btnyearly);
            this.Controls.Add(this.btnmonthly);
            this.Controls.Add(this.btntesttype);
            this.Controls.Add(this.btnagediffcount);
            this.Controls.Add(this.btndailypayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdviewdailyclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyearly;
        private System.Windows.Forms.Button btnmonthly;
        private System.Windows.Forms.Button btntesttype;
        private System.Windows.Forms.Button btnagediffcount;
        private System.Windows.Forms.Button btndailypayment;
        private System.Windows.Forms.DataGridView grdviewdailyclient;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txttotalpayment;
        private System.Windows.Forms.Button btndaily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker calender;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lbltotalpayment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}