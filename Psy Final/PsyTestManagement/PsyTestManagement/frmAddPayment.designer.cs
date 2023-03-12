
namespace TestManagement
{
    partial class frmAddPayment
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
            this.txtFees = new System.Windows.Forms.TextBox();
            this.lblPaymendMode = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblTestPaperName = new System.Windows.Forms.Label();
            this.lblTPName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cmbbxPaymentMode = new System.Windows.Forms.ComboBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.lblTType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetReceipt = new System.Windows.Forms.Button();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTestType = new System.Windows.Forms.Label();
            this.txtbxRegFees = new System.Windows.Forms.TextBox();
            this.lblRegFees = new System.Windows.Forms.Label();
            this.txtbxCounFees = new System.Windows.Forms.TextBox();
            this.lblCouncelingFees = new System.Windows.Forms.Label();
            this.lblStudId = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblper = new System.Windows.Forms.Label();
            this.txtbxGST = new System.Windows.Forms.TextBox();
            this.lblGST = new System.Windows.Forms.Label();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblRefName = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFees
            // 
            this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.Location = new System.Drawing.Point(561, 93);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(100, 26);
            this.txtFees.TabIndex = 12;
            this.txtFees.TextChanged += new System.EventHandler(this.txtFees_TextChanged);
            this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
            // 
            // lblPaymendMode
            // 
            this.lblPaymendMode.AutoSize = true;
            this.lblPaymendMode.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymendMode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymendMode.Location = new System.Drawing.Point(202, 269);
            this.lblPaymendMode.Name = "lblPaymendMode";
            this.lblPaymendMode.Size = new System.Drawing.Size(121, 18);
            this.lblPaymendMode.TabIndex = 6;
            this.lblPaymendMode.Text = "Payment Mode :";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(390, 97);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(88, 18);
            this.lblTotalFees.TabIndex = 3;
            this.lblTotalFees.Text = "Test Fees : ";
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.BackColor = System.Drawing.Color.Transparent;
            this.lblRs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRs.Location = new System.Drawing.Point(667, 98);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(18, 19);
            this.lblRs.TabIndex = 15;
            this.lblRs.Text = "/-";
            // 
            // lblTestPaperName
            // 
            this.lblTestPaperName.AutoSize = true;
            this.lblTestPaperName.BackColor = System.Drawing.Color.Transparent;
            this.lblTestPaperName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestPaperName.Location = new System.Drawing.Point(191, 114);
            this.lblTestPaperName.Name = "lblTestPaperName";
            this.lblTestPaperName.Size = new System.Drawing.Size(121, 18);
            this.lblTestPaperName.TabIndex = 17;
            this.lblTestPaperName.Text = "TestPaperName";
            // 
            // lblTPName
            // 
            this.lblTPName.AutoSize = true;
            this.lblTPName.BackColor = System.Drawing.Color.Transparent;
            this.lblTPName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPName.Location = new System.Drawing.Point(22, 114);
            this.lblTPName.Name = "lblTPName";
            this.lblTPName.Size = new System.Drawing.Size(137, 18);
            this.lblTPName.TabIndex = 16;
            this.lblTPName.Text = "Test Paper Name :";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(18, 78);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(119, 18);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = " Student Name :";
            // 
            // cmbbxPaymentMode
            // 
            this.cmbbxPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxPaymentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxPaymentMode.FormattingEnabled = true;
            this.cmbbxPaymentMode.Items.AddRange(new object[] {
            "Cash",
            "Online"});
            this.cmbbxPaymentMode.Location = new System.Drawing.Point(378, 265);
            this.cmbbxPaymentMode.Name = "cmbbxPaymentMode";
            this.cmbbxPaymentMode.Size = new System.Drawing.Size(149, 28);
            this.cmbbxPaymentMode.TabIndex = 7;
            this.cmbbxPaymentMode.SelectedIndexChanged += new System.EventHandler(this.cmbbxPaymentMode_SelectedIndexChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(191, 78);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(74, 18);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "FullName";
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionId.Location = new System.Drawing.Point(202, 314);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(111, 18);
            this.lblTransactionId.TabIndex = 13;
            this.lblTransactionId.Text = "Transaction ID:";
            // 
            // lblTType
            // 
            this.lblTType.AutoSize = true;
            this.lblTType.BackColor = System.Drawing.Color.Transparent;
            this.lblTType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTType.Location = new System.Drawing.Point(22, 148);
            this.lblTType.Name = "lblTType";
            this.lblTType.Size = new System.Drawing.Size(81, 18);
            this.lblTType.TabIndex = 2;
            this.lblTType.Text = "Test Type :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(528, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetReceipt
            // 
            this.btnGetReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGetReceipt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGetReceipt.Location = new System.Drawing.Point(359, 386);
            this.btnGetReceipt.Name = "btnGetReceipt";
            this.btnGetReceipt.Size = new System.Drawing.Size(121, 37);
            this.btnGetReceipt.TabIndex = 10;
            this.btnGetReceipt.Text = "Get Receipt";
            this.btnGetReceipt.UseVisualStyleBackColor = false;
            this.btnGetReceipt.Click += new System.EventHandler(this.btnGetReceipt_Click);
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionId.Location = new System.Drawing.Point(378, 310);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(148, 26);
            this.txtTransactionId.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.BackColor = System.Drawing.Color.Transparent;
            this.lblTestType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestType.Location = new System.Drawing.Point(191, 148);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(73, 18);
            this.lblTestType.TabIndex = 4;
            this.lblTestType.Text = "Test Type";
            // 
            // txtbxRegFees
            // 
            this.txtbxRegFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxRegFees.Location = new System.Drawing.Point(561, 22);
            this.txtbxRegFees.Name = "txtbxRegFees";
            this.txtbxRegFees.Size = new System.Drawing.Size(148, 26);
            this.txtbxRegFees.TabIndex = 19;
            // 
            // lblRegFees
            // 
            this.lblRegFees.AutoSize = true;
            this.lblRegFees.BackColor = System.Drawing.Color.Transparent;
            this.lblRegFees.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegFees.Location = new System.Drawing.Point(390, 26);
            this.lblRegFees.Name = "lblRegFees";
            this.lblRegFees.Size = new System.Drawing.Size(136, 18);
            this.lblRegFees.TabIndex = 18;
            this.lblRegFees.Text = "Registration Fees:";
            // 
            // txtbxCounFees
            // 
            this.txtbxCounFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCounFees.Location = new System.Drawing.Point(561, 57);
            this.txtbxCounFees.Name = "txtbxCounFees";
            this.txtbxCounFees.Size = new System.Drawing.Size(148, 26);
            this.txtbxCounFees.TabIndex = 21;
            // 
            // lblCouncelingFees
            // 
            this.lblCouncelingFees.AutoSize = true;
            this.lblCouncelingFees.BackColor = System.Drawing.Color.Transparent;
            this.lblCouncelingFees.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouncelingFees.Location = new System.Drawing.Point(390, 61);
            this.lblCouncelingFees.Name = "lblCouncelingFees";
            this.lblCouncelingFees.Size = new System.Drawing.Size(130, 18);
            this.lblCouncelingFees.TabIndex = 20;
            this.lblCouncelingFees.Text = "Counceling Fees:";
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.BackColor = System.Drawing.Color.Transparent;
            this.lblStudId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudId.Location = new System.Drawing.Point(191, 43);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(73, 18);
            this.lblStudId.TabIndex = 23;
            this.lblStudId.Text = "StudentId";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(22, 43);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(85, 18);
            this.lblStudentId.TabIndex = 22;
            this.lblStudentId.Text = "Student Id :";
            // 
            // lblper
            // 
            this.lblper.AutoSize = true;
            this.lblper.BackColor = System.Drawing.Color.Transparent;
            this.lblper.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblper.Location = new System.Drawing.Point(667, 132);
            this.lblper.Name = "lblper";
            this.lblper.Size = new System.Drawing.Size(25, 19);
            this.lblper.TabIndex = 26;
            this.lblper.Text = "%";
            // 
            // txtbxGST
            // 
            this.txtbxGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxGST.Location = new System.Drawing.Point(561, 127);
            this.txtbxGST.Name = "txtbxGST";
            this.txtbxGST.Size = new System.Drawing.Size(100, 26);
            this.txtbxGST.TabIndex = 25;
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.BackColor = System.Drawing.Color.Transparent;
            this.lblGST.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(390, 131);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(42, 18);
            this.lblGST.TabIndex = 24;
            this.lblGST.Text = "GST:";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTotal.Location = new System.Drawing.Point(378, 221);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.Size = new System.Drawing.Size(148, 26);
            this.txtbxTotal.TabIndex = 28;
            this.txtbxTotal.TextChanged += new System.EventHandler(this.txtbxTotal_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Controls.Add(this.lblRefName);
            this.groupBox1.Controls.Add(this.btnTotal);
            this.groupBox1.Controls.Add(this.lblTPName);
            this.groupBox1.Controls.Add(this.txtbxTotal);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.lblper);
            this.groupBox1.Controls.Add(this.lblTType);
            this.groupBox1.Controls.Add(this.txtbxGST);
            this.groupBox1.Controls.Add(this.lblTestType);
            this.groupBox1.Controls.Add(this.lblGST);
            this.groupBox1.Controls.Add(this.lblTestPaperName);
            this.groupBox1.Controls.Add(this.txtbxCounFees);
            this.groupBox1.Controls.Add(this.lblStudId);
            this.groupBox1.Controls.Add(this.lblCouncelingFees);
            this.groupBox1.Controls.Add(this.lblStudentId);
            this.groupBox1.Controls.Add(this.txtbxRegFees);
            this.groupBox1.Controls.Add(this.txtTransactionId);
            this.groupBox1.Controls.Add(this.lblRegFees);
            this.groupBox1.Controls.Add(this.lblTotalFees);
            this.groupBox1.Controls.Add(this.lblRs);
            this.groupBox1.Controls.Add(this.lblPaymendMode);
            this.groupBox1.Controls.Add(this.cmbbxPaymentMode);
            this.groupBox1.Controls.Add(this.lblTransactionId);
            this.groupBox1.Controls.Add(this.txtFees);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 342);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Information:";
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTotal.Location = new System.Drawing.Point(205, 216);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(121, 37);
            this.btnTotal.TabIndex = 30;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblRefName
            // 
            this.lblRefName.AutoSize = true;
            this.lblRefName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefName.Location = new System.Drawing.Point(391, 165);
            this.lblRefName.Name = "lblRefName";
            this.lblRefName.Size = new System.Drawing.Size(129, 16);
            this.lblRefName.TabIndex = 31;
            this.lblRefName.Text = "Reference Name:";
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(561, 159);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 26);
            this.txtRef.TabIndex = 32;
            // 
            // frmAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.ClientSize = new System.Drawing.Size(977, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetReceipt);
            this.Name = "frmAddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmAddPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label lblPaymendMode;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Label lblTestPaperName;
        private System.Windows.Forms.Label lblTPName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox cmbbxPaymentMode;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblTransactionId;
        private System.Windows.Forms.Label lblTType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetReceipt;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTestType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.Label lblper;
        private System.Windows.Forms.TextBox txtbxGST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.TextBox txtbxCounFees;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.Label lblCouncelingFees;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtbxRegFees;
        private System.Windows.Forms.Label lblRegFees;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblRefName;
    }
}

