namespace TestManagement
{
    partial class frmLayoutDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDailyClient = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMonthlyTests = new System.Windows.Forms.Label();
            this.lblMonthlyTest = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonthlyClients = new System.Windows.Forms.Label();
            this.lblMonthlyClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDailyTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartMonthlyGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMonthlyGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblDailyClient);
            this.panel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(365, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 75);
            this.panel4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(39, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Daily Clients";
            // 
            // lblDailyClient
            // 
            this.lblDailyClient.AutoSize = true;
            this.lblDailyClient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyClient.ForeColor = System.Drawing.Color.Black;
            this.lblDailyClient.Location = new System.Drawing.Point(72, 42);
            this.lblDailyClient.Name = "lblDailyClient";
            this.lblDailyClient.Size = new System.Drawing.Size(16, 20);
            this.lblDailyClient.TabIndex = 3;
            this.lblDailyClient.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orchid;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblMonthlyTests);
            this.panel3.Controls.Add(this.lblMonthlyTest);
            this.panel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(839, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 75);
            this.panel3.TabIndex = 7;
            // 
            // lblMonthlyTests
            // 
            this.lblMonthlyTests.AutoSize = true;
            this.lblMonthlyTests.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyTests.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyTests.Location = new System.Drawing.Point(29, 14);
            this.lblMonthlyTests.Name = "lblMonthlyTests";
            this.lblMonthlyTests.Size = new System.Drawing.Size(96, 20);
            this.lblMonthlyTests.TabIndex = 5;
            this.lblMonthlyTests.Text = "Monthly Tests";
            // 
            // lblMonthlyTest
            // 
            this.lblMonthlyTest.AutoSize = true;
            this.lblMonthlyTest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyTest.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyTest.Location = new System.Drawing.Point(76, 43);
            this.lblMonthlyTest.Name = "lblMonthlyTest";
            this.lblMonthlyTest.Size = new System.Drawing.Size(16, 20);
            this.lblMonthlyTest.TabIndex = 1;
            this.lblMonthlyTest.Text = "0";
            this.lblMonthlyTest.Click += new System.EventHandler(this.lblTestCount_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMonthlyClients);
            this.panel2.Controls.Add(this.lblMonthlyClient);
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(603, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 75);
            this.panel2.TabIndex = 8;
            // 
            // lblMonthlyClients
            // 
            this.lblMonthlyClients.AutoSize = true;
            this.lblMonthlyClients.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyClients.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyClients.Location = new System.Drawing.Point(21, 14);
            this.lblMonthlyClients.Name = "lblMonthlyClients";
            this.lblMonthlyClients.Size = new System.Drawing.Size(106, 20);
            this.lblMonthlyClients.TabIndex = 5;
            this.lblMonthlyClients.Text = "Monthly Clients";
            // 
            // lblMonthlyClient
            // 
            this.lblMonthlyClient.AutoSize = true;
            this.lblMonthlyClient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyClient.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyClient.Location = new System.Drawing.Point(72, 43);
            this.lblMonthlyClient.Name = "lblMonthlyClient";
            this.lblMonthlyClient.Size = new System.Drawing.Size(16, 20);
            this.lblMonthlyClient.TabIndex = 3;
            this.lblMonthlyClient.Text = "0";
            this.lblMonthlyClient.Click += new System.EventHandler(this.lblClientCount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDailyTest);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(166, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 75);
            this.panel1.TabIndex = 6;
            // 
            // lblDailyTest
            // 
            this.lblDailyTest.AutoSize = true;
            this.lblDailyTest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyTest.ForeColor = System.Drawing.Color.Black;
            this.lblDailyTest.Location = new System.Drawing.Point(65, 33);
            this.lblDailyTest.Name = "lblDailyTest";
            this.lblDailyTest.Size = new System.Drawing.Size(16, 20);
            this.lblDailyTest.TabIndex = 1;
            this.lblDailyTest.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Tests";
            // 
            // ChartMonthlyGraph
            // 
            this.ChartMonthlyGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartMonthlyGraph.BackColor = System.Drawing.Color.Transparent;
            this.ChartMonthlyGraph.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartMonthlyGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartMonthlyGraph.Legends.Add(legend1);
            this.ChartMonthlyGraph.Location = new System.Drawing.Point(166, 152);
            this.ChartMonthlyGraph.Name = "ChartMonthlyGraph";
            this.ChartMonthlyGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Monthly Clients";
            series1.XValueMember = "Months";
            series1.YValueMembers = "Tests";
            this.ChartMonthlyGraph.Series.Add(series1);
            this.ChartMonthlyGraph.Size = new System.Drawing.Size(701, 386);
            this.ChartMonthlyGraph.TabIndex = 10;
            this.ChartMonthlyGraph.Text = "Monthly Graph";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = " Monthly Graph";
            title1.Text = " Monthly Clients";
            this.ChartMonthlyGraph.Titles.Add(title1);
            this.ChartMonthlyGraph.Click += new System.EventHandler(this.ChartMonthlyGraph_Click);
            // 
            // frmLayoutDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 576);
            this.Controls.Add(this.ChartMonthlyGraph);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLayoutDashboard";
            this.Text = "LayoutDashboard";
            this.Load += new System.EventHandler(this.frmLayoutDashboard_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMonthlyGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDailyClient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMonthlyTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMonthlyClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDailyTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMonthlyGraph;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblMonthlyTests;
        private System.Windows.Forms.Label lblMonthlyClients;
    }
}