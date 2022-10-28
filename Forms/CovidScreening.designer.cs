namespace Health_Care_App
{
    partial class CovidScreening
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
            this.label_covid1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_back_covid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_covid1
            // 
            this.label_covid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_covid1.Location = new System.Drawing.Point(10, 78);
            this.label_covid1.Name = "label_covid1";
            this.label_covid1.Size = new System.Drawing.Size(771, 23);
            this.label_covid1.TabIndex = 0;
            this.label_covid1.Text = "Regardless of your vaccination status, have you experienced any of the symptoms i" +
    "n the list below in the past 48 hours?\r\n";
            this.label_covid1.Click += new System.EventHandler(this.label_covid1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Fever or chills",
            "Cough",
            "Shortness of breath or difficulty breathing",
            "Fatigue",
            "Muscle or body aches",
            "Headache",
            "New loss of taste or smell",
            "Sore throat",
            "Congestion or runny nose",
            "Nausea or vomiting",
            "Diarrhea"});
            this.checkedListBox1.Location = new System.Drawing.Point(14, 113);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(701, 252);
            this.checkedListBox1.TabIndex = 11;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btn_back_covid
            // 
            this.btn_back_covid.Image = global::Health_Care_App.Properties.Resources.Arrow_Back_icon;
            this.btn_back_covid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back_covid.Location = new System.Drawing.Point(14, 10);
            this.btn_back_covid.Name = "btn_back_covid";
            this.btn_back_covid.Size = new System.Drawing.Size(100, 39);
            this.btn_back_covid.TabIndex = 12;
            this.btn_back_covid.Text = "Back";
            this.btn_back_covid.UseVisualStyleBackColor = true;
            this.btn_back_covid.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "If you have checked one or more of these boxes, please call your doctor for futhe" +
    "r Covid testing.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Covid-19 Screening";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(14, 359);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 26);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CovidScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back_covid);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label_covid1);
            this.Name = "CovidScreening";
            this.Text = "Covid Screening";
            this.Load += new System.EventHandler(this.CovidScreening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_covid1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_back_covid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
    }
}