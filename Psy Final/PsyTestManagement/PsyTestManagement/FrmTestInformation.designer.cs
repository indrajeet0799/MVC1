namespace PsyTestManagement
{
    partial class FrmTestInformation
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
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.lblStudId = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblTestPaper = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartTset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudId
            // 
            this.txtStudId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudId.Location = new System.Drawing.Point(175, 169);
            this.txtStudId.Margin = new System.Windows.Forms.Padding(5);
            this.txtStudId.Name = "txtStudId";
            this.txtStudId.Size = new System.Drawing.Size(160, 26);
            this.txtStudId.TabIndex = 0;
            this.txtStudId.Leave += new System.EventHandler(this.txtStudId_Leave);
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.BackColor = System.Drawing.Color.Transparent;
            this.lblStudId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudId.Location = new System.Drawing.Point(19, 172);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(132, 19);
            this.lblStudId.TabIndex = 2;
            this.lblStudId.Text = "Enter Student Id";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(437, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 29);
            this.label.TabIndex = 3;
            this.label.Text = "परीक्षेचे नाव";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // lblTestPaper
            // 
            this.lblTestPaper.AutoSize = true;
            this.lblTestPaper.BackColor = System.Drawing.Color.Transparent;
            this.lblTestPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestPaper.Location = new System.Drawing.Point(622, 25);
            this.lblTestPaper.Name = "lblTestPaper";
            this.lblTestPaper.Size = new System.Drawing.Size(159, 29);
            this.lblTestPaper.TabIndex = 4;
            this.lblTestPaper.Text = "Paper Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "गुण";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = " :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.BackColor = System.Drawing.Color.Transparent;
            this.lblMarks.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(633, 72);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(29, 22);
            this.lblMarks.TabIndex = 8;
            this.lblMarks.Text = "५०";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "वेळ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = " :";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(623, 125);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 22);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "१ तास";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "सूचना :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnStartTset
            // 
            this.btnStartTset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStartTset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTset.Location = new System.Drawing.Point(442, 605);
            this.btnStartTset.Name = "btnStartTset";
            this.btnStartTset.Size = new System.Drawing.Size(257, 51);
            this.btnStartTset.TabIndex = 18;
            this.btnStartTset.Text = "Start Test";
            this.btnStartTset.UseVisualStyleBackColor = false;
            this.btnStartTset.Click += new System.EventHandler(this.btnStartTset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(260, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(570, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "ज्ञानेश्वरीमध्ये वर्णन केलेल्या त्रिगुणांचा प्रभाव तुमच्यावर कसा आहे हे ठरविवारी " +
    "ही चाचणी आहे. ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(260, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(379, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "यामध्ये समाजात आढळणारी विविध वर्तन  वैशिष्ट्  दिली आहेत.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(260, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(753, 22);
            this.label14.TabIndex = 26;
            this.label14.Text = "त्यावर्तन वैशिष्ट्याप्रमाने तुम्ही किती वागता त्याचा विचार करून त्यापुढिल \'\'नेहमी" +
    "च\', बऱ्याचदा,\' \'कधीतरी\' आणि \'कधीच नाही\' ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(260, 406);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(467, 22);
            this.label15.TabIndex = 27;
            this.label15.Text = "या चार पर्यायांपैकी एका पर्यायाच्या रकान्यात अशी सहमती दर्शक खूण करा. ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(260, 444);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(241, 22);
            this.label18.TabIndex = 30;
            this.label18.Text = "तुम्ही दिलेली माहिती गुप्त ठेवली जाईल.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(498, 444);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(450, 22);
            this.label20.TabIndex = 32;
            this.label20.Text = "तिचा उपयोग संशोधनाभ्यास आणि तुम्हाला मार्गदर्शनासाठीच केला जाईल, ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(260, 484);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(461, 22);
            this.label22.TabIndex = 34;
            this.label22.Text = "चाचनी सोडविताना काही विधानांची पुनरावृत्ती झाली आहे असे तुम्हाला वाटेल.";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(260, 521);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(549, 22);
            this.label23.TabIndex = 35;
            this.label23.Text = "तरीही अगदी नि:शंकपणे सर्व चाचणी भरभर सोडवा . काही शंका असल्यास आवश्य विचारा.";
            // 
            // FrmTestInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::PsyTestManagement.Properties.Resources.WhatsApp_Image_2022_11_16_at_11_03_12_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 694);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStartTset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTestPaper);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblStudId);
            this.Controls.Add(this.txtStudId);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTestInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Test_Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudId;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblTestPaper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartTset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
    }
}

