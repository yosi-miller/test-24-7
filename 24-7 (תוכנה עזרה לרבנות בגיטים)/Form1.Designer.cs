namespace _24_7__תוכנה_עזרה_לרבנות_בגיטים_
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbmDayOfWeak = new System.Windows.Forms.ComboBox();
            this.cbmDayOfMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1724, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "היום בשבוע";
            // 
            // cbmDayOfWeak
            // 
            this.cbmDayOfWeak.FormattingEnabled = true;
            this.cbmDayOfWeak.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.cbmDayOfWeak.Location = new System.Drawing.Point(1637, 277);
            this.cbmDayOfWeak.Name = "cbmDayOfWeak";
            this.cbmDayOfWeak.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbmDayOfWeak.Size = new System.Drawing.Size(258, 39);
            this.cbmDayOfWeak.TabIndex = 2;
            // 
            // cbmDayOfMonth
            // 
            this.cbmDayOfMonth.FormattingEnabled = true;
            this.cbmDayOfMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cbmDayOfMonth.Location = new System.Drawing.Point(1171, 277);
            this.cbmDayOfMonth.Name = "cbmDayOfMonth";
            this.cbmDayOfMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbmDayOfMonth.Size = new System.Drawing.Size(258, 39);
            this.cbmDayOfMonth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1258, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 80);
            this.label3.TabIndex = 3;
            this.label3.Text = "היום בחודש";
            // 
            // cbmMonth
            // 
            this.cbmMonth.FormattingEnabled = true;
            this.cbmMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר א",
            "אדר ב",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.cbmMonth.Location = new System.Drawing.Point(726, 277);
            this.cbmMonth.Name = "cbmMonth";
            this.cbmMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbmMonth.Size = new System.Drawing.Size(258, 39);
            this.cbmMonth.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "חודש";
            // 
            // cbmYear
            // 
            this.cbmYear.FormattingEnabled = true;
            this.cbmYear.Items.AddRange(new object[] {
            "תשפ\"ד",
            "תשפ\"ה",
            "תשפ\"ו",
            "תשפ\"ז",
            "תשפ\"ח",
            "תשפ\"ט",
            "תש\"צ",
            "תשצ\"א",
            "תשצ\"ב",
            "תשצ\"ג"});
            this.cbmYear.Location = new System.Drawing.Point(333, 277);
            this.cbmYear.Name = "cbmYear";
            this.cbmYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbmYear.Size = new System.Drawing.Size(258, 39);
            this.cbmYear.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "שנה";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(333, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 103);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "כתיבה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(533, 861);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(89, 32);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "תוצאה";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2130, 1101);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbmYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbmMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbmDayOfMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbmDayOfWeak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmDayOfWeak;
        private System.Windows.Forms.ComboBox cbmDayOfMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblResult;
    }
}

