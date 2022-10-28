namespace Health_Care_App
{
    partial class TuberculosisScreening
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
            this.btn_back_tuberculosis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxTuberculosis = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back_tuberculosis
            // 
            this.btn_back_tuberculosis.Image = global::Health_Care_App.Properties.Resources.Arrow_Back_icon;
            this.btn_back_tuberculosis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back_tuberculosis.Location = new System.Drawing.Point(10, 14);
            this.btn_back_tuberculosis.Name = "btn_back_tuberculosis";
            this.btn_back_tuberculosis.Size = new System.Drawing.Size(125, 45);
            this.btn_back_tuberculosis.TabIndex = 0;
            this.btn_back_tuberculosis.Text = "Back";
            this.btn_back_tuberculosis.UseVisualStyleBackColor = true;
            this.btn_back_tuberculosis.Click += new System.EventHandler(this.btn_back_tuberculosis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuberculosis Symptom Screening Questionnaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symptoms of TB disease depend on where in the body the TB bacteria are growing. \r" +
    "\nTB bacteria usually grow in the lungs (pulmonary TB). \r\nTB disease in the lungs" +
    " may cause these symptoms:";
            // 
            // checkedListBoxTuberculosis
            // 
            this.checkedListBoxTuberculosis.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkedListBoxTuberculosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxTuberculosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxTuberculosis.FormattingEnabled = true;
            this.checkedListBoxTuberculosis.Items.AddRange(new object[] {
            "A bad cough that lasts 3 weeks or longer",
            "Pain in the chest",
            "Coughing up blood or sputom(phlegm from deep inside the lungs)",
            "Weakness or fatigue",
            "Weight loss",
            "No appetite",
            "Chills",
            "Fever",
            "Sweating at night"});
            this.checkedListBoxTuberculosis.Location = new System.Drawing.Point(21, 149);
            this.checkedListBoxTuberculosis.Name = "checkedListBoxTuberculosis";
            this.checkedListBoxTuberculosis.Size = new System.Drawing.Size(641, 189);
            this.checkedListBoxTuberculosis.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(735, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "If you have checked one or more of these boxes, please call your doctor for furth" +
    "er Tuberculosis testing.\r\n";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(26, 344);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TuberculosisScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxTuberculosis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back_tuberculosis);
            this.Name = "TuberculosisScreening";
            this.Text = "Tuberculosis Screening";
            this.Load += new System.EventHandler(this.TuberculosisScreening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_tuberculosis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxTuberculosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save;
    }
}