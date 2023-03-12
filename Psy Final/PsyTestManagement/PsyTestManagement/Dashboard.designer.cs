namespace TestManagement
{
    partial class frmDashboard
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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.MenuStripTabs = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientRegToolMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.REPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTop = new System.Windows.Forms.MenuStrip();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROGILESETTINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITPROFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHANGEPASSWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTabs.SuspendLayout();
            this.MenuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDashboard.Location = new System.Drawing.Point(218, 43);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(800, 494);
            this.pnlDashboard.TabIndex = 6;
            this.pnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Dashboard);
            // 
            // MenuStripTabs
            // 
            this.MenuStripTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MenuStripTabs.BackgroundImage = global::PsyTestManagement.Properties.Resources.image;
            this.MenuStripTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuStripTabs.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStripTabs.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.MenuStripTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.ClientRegToolMenuStrip,
            this.ClientInfoToolStripMenuItem,
            this.TestManagementToolStripMenuItem,
            this.REPORTToolStripMenuItem,
            this.ResultToolStripMenuItem,
            this.PaymentToolStripMenuItem,
            this.SettingManagmentToolStripMenuItem});
            this.MenuStripTabs.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MenuStripTabs.Location = new System.Drawing.Point(0, 43);
            this.MenuStripTabs.Name = "MenuStripTabs";
            this.MenuStripTabs.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStripTabs.Size = new System.Drawing.Size(218, 494);
            this.MenuStripTabs.TabIndex = 5;
            this.MenuStripTabs.Text = "MenuStripTabs";
            this.MenuStripTabs.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripTabs_ItemClicked);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(213, 43);
            this.dashboardToolStripMenuItem.Text = "DASHBOARD";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // ClientRegToolMenuStrip
            // 
            this.ClientRegToolMenuStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientRegToolMenuStrip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientRegToolMenuStrip.Name = "ClientRegToolMenuStrip";
            this.ClientRegToolMenuStrip.Padding = new System.Windows.Forms.Padding(10);
            this.ClientRegToolMenuStrip.Size = new System.Drawing.Size(213, 43);
            this.ClientRegToolMenuStrip.Text = "CLIENT REGISTRATION";
            this.ClientRegToolMenuStrip.Click += new System.EventHandler(this.ClientRegToolMenuStrip_Click);
            // 
            // ClientInfoToolStripMenuItem
            // 
            this.ClientInfoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientInfoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientInfoToolStripMenuItem.Name = "ClientInfoToolStripMenuItem";
            this.ClientInfoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.ClientInfoToolStripMenuItem.Size = new System.Drawing.Size(213, 43);
            this.ClientInfoToolStripMenuItem.Text = "CLIENT INFO";
            this.ClientInfoToolStripMenuItem.Click += new System.EventHandler(this.ClientInfoToolStripMenuItem_Click);
            // 
            // TestManagementToolStripMenuItem
            // 
            this.TestManagementToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestManagementToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TestManagementToolStripMenuItem.Name = "TestManagementToolStripMenuItem";
            this.TestManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.TestManagementToolStripMenuItem.Size = new System.Drawing.Size(213, 43);
            this.TestManagementToolStripMenuItem.Text = "TEST MANAGEMENT";
            this.TestManagementToolStripMenuItem.Click += new System.EventHandler(this.TestManagementToolStripMenuItem_Click);
            // 
            // REPORTToolStripMenuItem
            // 
            this.REPORTToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REPORTToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem";
            this.REPORTToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.REPORTToolStripMenuItem.Size = new System.Drawing.Size(213, 43);
            this.REPORTToolStripMenuItem.Text = "REPORT";
            this.REPORTToolStripMenuItem.Click += new System.EventHandler(this.REPORTToolStripMenuItem_Click);
            // 
            // ResultToolStripMenuItem
            // 
            this.ResultToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ResultToolStripMenuItem.Name = "ResultToolStripMenuItem";
            this.ResultToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.ResultToolStripMenuItem.Size = new System.Drawing.Size(213, 43);
            this.ResultToolStripMenuItem.Text = "RESULT";
            this.ResultToolStripMenuItem.Click += new System.EventHandler(this.ResultToolStripMenuItem_Click);
            // 
            // PaymentToolStripMenuItem
            // 
            this.PaymentToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem";
            this.PaymentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.PaymentToolStripMenuItem.Size = new System.Drawing.Size(213, 43);
            this.PaymentToolStripMenuItem.Text = "PAYMENT";
            this.PaymentToolStripMenuItem.Click += new System.EventHandler(this.PaymentToolStripMenuItem_Click);
            // 
            // SettingManagmentToolStripMenuItem
            // 
            this.SettingManagmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffInfoToolStripMenuItem,
            this.AddTestTypeToolStripMenuItem});
            this.SettingManagmentToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingManagmentToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SettingManagmentToolStripMenuItem.Name = "SettingManagmentToolStripMenuItem";
            this.SettingManagmentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.SettingManagmentToolStripMenuItem.Size = new System.Drawing.Size(213, 43);
            this.SettingManagmentToolStripMenuItem.Text = "SETTINGS";
            this.SettingManagmentToolStripMenuItem.Click += new System.EventHandler(this.SettingManagmentToolStripMenuItem_Click);
            // 
            // StaffInfoToolStripMenuItem
            // 
            this.StaffInfoToolStripMenuItem.BackgroundImage = global::PsyTestManagement.Properties.Resources.image;
            this.StaffInfoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StaffInfoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.StaffInfoToolStripMenuItem.Name = "StaffInfoToolStripMenuItem";
            this.StaffInfoToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.StaffInfoToolStripMenuItem.Text = "Staff Information";
            this.StaffInfoToolStripMenuItem.Click += new System.EventHandler(this.StaffInfoToolStripMenuItem_Click);
            // 
            // AddTestTypeToolStripMenuItem
            // 
            this.AddTestTypeToolStripMenuItem.BackgroundImage = global::PsyTestManagement.Properties.Resources.image;
            this.AddTestTypeToolStripMenuItem.Name = "AddTestTypeToolStripMenuItem";
            this.AddTestTypeToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.AddTestTypeToolStripMenuItem.Text = "Add Test Type";
            // 
            // MenuStripTop
            // 
            this.MenuStripTop.BackColor = System.Drawing.Color.White;
            this.MenuStripTop.BackgroundImage = global::PsyTestManagement.Properties.Resources.image;
            this.MenuStripTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStripTop.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.MenuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem});
            this.MenuStripTop.Location = new System.Drawing.Point(0, 0);
            this.MenuStripTop.Name = "MenuStripTop";
            this.MenuStripTop.Padding = new System.Windows.Forms.Padding(10);
            this.MenuStripTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuStripTop.Size = new System.Drawing.Size(1018, 43);
            this.MenuStripTop.TabIndex = 4;
            this.MenuStripTop.Text = "MenuStripTop";
            this.MenuStripTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripTop_ItemClicked);
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.aDMINToolStripMenuItem.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.aDMINToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aDMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROGILESETTINGToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            this.aDMINToolStripMenuItem.Click += new System.EventHandler(this.aDMINToolStripMenuItem_Click);
            // 
            // pROGILESETTINGToolStripMenuItem
            // 
            this.pROGILESETTINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITPROFILEToolStripMenuItem,
            this.cHANGEPASSWORDToolStripMenuItem});
            this.pROGILESETTINGToolStripMenuItem.Name = "pROGILESETTINGToolStripMenuItem";
            this.pROGILESETTINGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pROGILESETTINGToolStripMenuItem.Text = "PROGILE SETTING";
            // 
            // eDITPROFILEToolStripMenuItem
            // 
            this.eDITPROFILEToolStripMenuItem.Name = "eDITPROFILEToolStripMenuItem";
            this.eDITPROFILEToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.eDITPROFILEToolStripMenuItem.Text = "EDIT PROFILE";
            this.eDITPROFILEToolStripMenuItem.Click += new System.EventHandler(this.eDITPROFILEToolStripMenuItem_Click);
            // 
            // cHANGEPASSWORDToolStripMenuItem
            // 
            this.cHANGEPASSWORDToolStripMenuItem.Name = "cHANGEPASSWORDToolStripMenuItem";
            this.cHANGEPASSWORDToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cHANGEPASSWORDToolStripMenuItem.Text = "CHANGE PASSWORD";
            this.cHANGEPASSWORDToolStripMenuItem.Click += new System.EventHandler(this.cHANGEPASSWORDToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 537);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.MenuStripTabs);
            this.Controls.Add(this.MenuStripTop);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.MenuStripTabs.ResumeLayout(false);
            this.MenuStripTabs.PerformLayout();
            this.MenuStripTop.ResumeLayout(false);
            this.MenuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientRegToolMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem REPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StaffInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTestTypeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStripTabs;
        private System.Windows.Forms.MenuStrip MenuStripTop;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROGILESETTINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITPROFILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHANGEPASSWORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}