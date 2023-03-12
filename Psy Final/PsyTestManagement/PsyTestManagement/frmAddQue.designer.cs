namespace PsyTestManagement
{
    partial class frmAddQue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQue));
            this.cmbbxQueType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbxQueGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbxMarkingSystem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbbxbehaviorType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdQuestionDetails = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQue = new System.Windows.Forms.TextBox();
            this.lblAddQue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuestionDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbxQueType
            // 
            this.cmbbxQueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbbxQueType, "cmbbxQueType");
            this.cmbbxQueType.FormattingEnabled = true;
            this.cmbbxQueType.Items.AddRange(new object[] {
            resources.GetString("cmbbxQueType.Items"),
            resources.GetString("cmbbxQueType.Items1")});
            this.cmbbxQueType.Name = "cmbbxQueType";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // cmbbxQueGroup
            // 
            this.cmbbxQueGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbbxQueGroup, "cmbbxQueGroup");
            this.cmbbxQueGroup.FormattingEnabled = true;
            this.cmbbxQueGroup.Items.AddRange(new object[] {
            resources.GetString("cmbbxQueGroup.Items"),
            resources.GetString("cmbbxQueGroup.Items1"),
            resources.GetString("cmbbxQueGroup.Items2"),
            resources.GetString("cmbbxQueGroup.Items3"),
            resources.GetString("cmbbxQueGroup.Items4"),
            resources.GetString("cmbbxQueGroup.Items5"),
            resources.GetString("cmbbxQueGroup.Items6"),
            resources.GetString("cmbbxQueGroup.Items7")});
            this.cmbbxQueGroup.Name = "cmbbxQueGroup";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // cmbbxMarkingSystem
            // 
            this.cmbbxMarkingSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbbxMarkingSystem, "cmbbxMarkingSystem");
            this.cmbbxMarkingSystem.FormattingEnabled = true;
            this.cmbbxMarkingSystem.Items.AddRange(new object[] {
            resources.GetString("cmbbxMarkingSystem.Items"),
            resources.GetString("cmbbxMarkingSystem.Items1")});
            this.cmbbxMarkingSystem.Name = "cmbbxMarkingSystem";
            this.cmbbxMarkingSystem.SelectedIndexChanged += new System.EventHandler(this.cmbbxMarkingSystem_SelectedIndexChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // cmbbxbehaviorType
            // 
            this.cmbbxbehaviorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbbxbehaviorType, "cmbbxbehaviorType");
            this.cmbbxbehaviorType.FormattingEnabled = true;
            this.cmbbxbehaviorType.Items.AddRange(new object[] {
            resources.GetString("cmbbxbehaviorType.Items"),
            resources.GetString("cmbbxbehaviorType.Items1"),
            resources.GetString("cmbbxbehaviorType.Items2")});
            this.cmbbxbehaviorType.Name = "cmbbxbehaviorType";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // grdQuestionDetails
            // 
            this.grdQuestionDetails.AllowUserToAddRows = false;
            resources.ApplyResources(this.grdQuestionDetails, "grdQuestionDetails");
            this.grdQuestionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdQuestionDetails.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdQuestionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuestionDetails.Name = "grdQuestionDetails";
            this.grdQuestionDetails.RowHeadersVisible = false;
            this.grdQuestionDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdQuestionDetails_CellClick);
            this.grdQuestionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdQuestionDetails_CellContentClick);
            this.grdQuestionDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdQuestionDetails_DataBindingComplete);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQue
            // 
            resources.ApplyResources(this.txtQue, "txtQue");
            this.txtQue.Name = "txtQue";
            // 
            // lblAddQue
            // 
            resources.ApplyResources(this.lblAddQue, "lblAddQue");
            this.lblAddQue.BackColor = System.Drawing.Color.Transparent;
            this.lblAddQue.Name = "lblAddQue";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnExel
            // 
            this.btnExel.BackgroundImage = global::PsyTestManagement.Properties.Resources.excel_icon__1_;
            resources.ApplyResources(this.btnExel, "btnExel");
            this.btnExel.Name = "btnExel";
            this.btnExel.UseVisualStyleBackColor = true;
            this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PsyTestManagement.Properties.Resources.search_icon__1_;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::PsyTestManagement.Properties.Resources.search_icon__1_;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtQNo
            // 
            resources.ApplyResources(this.txtQNo, "txtQNo");
            this.txtQNo.Name = "txtQNo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::PsyTestManagement.Properties.Resources.refresh_icon;
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_30_at_6_34_36_PM;
            resources.ApplyResources(this.btnImport, "btnImport");
            this.btnImport.Name = "btnImport";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // frmAddQue
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbbxQueType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbbxQueGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbbxMarkingSystem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbbxbehaviorType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdQuestionDetails);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQue);
            this.Controls.Add(this.lblAddQue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExel);
            this.Controls.Add(this.btnRefresh);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmAddQue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddQue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdQuestionDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxQueType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbxQueGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbxMarkingSystem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbbxbehaviorType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdQuestionDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQue;
        private System.Windows.Forms.Label lblAddQue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}