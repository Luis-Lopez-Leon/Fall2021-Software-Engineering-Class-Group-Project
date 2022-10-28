
namespace Health_Care_App
{
    partial class Survey
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
            this.btn_covid = new System.Windows.Forms.Button();
            this.btn_gad7 = new System.Windows.Forms.Button();
            this.btn_tuberculosis = new System.Windows.Forms.Button();
            this.btn_PHQ = new System.Windows.Forms.Button();
            this.btn_stress = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "The available screenings are dictated by the medical provider, if you do not see " +
    "the one you\'re looking for, please call your doctor.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 55);
            this.label2.TabIndex = 13;
            this.label2.Text = "Screening Options";
            // 
            // btn_covid
            // 
            this.btn_covid.Location = new System.Drawing.Point(168, 108);
            this.btn_covid.Name = "btn_covid";
            this.btn_covid.Size = new System.Drawing.Size(132, 55);
            this.btn_covid.TabIndex = 14;
            this.btn_covid.Text = "Covid-19";
            this.btn_covid.UseVisualStyleBackColor = true;
            this.btn_covid.Click += new System.EventHandler(this.btn_covid_Click);
            // 
            // btn_gad7
            // 
            this.btn_gad7.Location = new System.Drawing.Point(503, 108);
            this.btn_gad7.Name = "btn_gad7";
            this.btn_gad7.Size = new System.Drawing.Size(132, 55);
            this.btn_gad7.TabIndex = 15;
            this.btn_gad7.Text = "GAD-7";
            this.btn_gad7.UseVisualStyleBackColor = true;
            this.btn_gad7.Click += new System.EventHandler(this.btn_gad7_Click);
            // 
            // btn_tuberculosis
            // 
            this.btn_tuberculosis.Location = new System.Drawing.Point(168, 197);
            this.btn_tuberculosis.Name = "btn_tuberculosis";
            this.btn_tuberculosis.Size = new System.Drawing.Size(132, 55);
            this.btn_tuberculosis.TabIndex = 16;
            this.btn_tuberculosis.Text = "Tuberculosis";
            this.btn_tuberculosis.UseVisualStyleBackColor = true;
            this.btn_tuberculosis.Click += new System.EventHandler(this.btn_tuberculosis_Click);
            // 
            // btn_PHQ
            // 
            this.btn_PHQ.Location = new System.Drawing.Point(504, 197);
            this.btn_PHQ.Name = "btn_PHQ";
            this.btn_PHQ.Size = new System.Drawing.Size(131, 55);
            this.btn_PHQ.TabIndex = 17;
            this.btn_PHQ.Text = "PHQ-9";
            this.btn_PHQ.UseVisualStyleBackColor = true;
            this.btn_PHQ.Click += new System.EventHandler(this.btn_PHQ_Click);
            // 
            // btn_stress
            // 
            this.btn_stress.Location = new System.Drawing.Point(168, 288);
            this.btn_stress.Name = "btn_stress";
            this.btn_stress.Size = new System.Drawing.Size(132, 55);
            this.btn_stress.TabIndex = 18;
            this.btn_stress.Text = "Stress Screening";
            this.btn_stress.UseVisualStyleBackColor = true;
            this.btn_stress.Click += new System.EventHandler(this.btn_stress_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "CAGE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.CausesValidation = false;
            this.Back.Image = global::Health_Care_App.Properties.Resources.Arrow_Back_icon;
            this.Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(105, 38);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_stress);
            this.Controls.Add(this.btn_PHQ);
            this.Controls.Add(this.btn_tuberculosis);
            this.Controls.Add(this.btn_gad7);
            this.Controls.Add(this.btn_covid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "Survey";
            this.Text = "Survey";
            this.Load += new System.EventHandler(this.Survey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_covid;
        private System.Windows.Forms.Button btn_gad7;
        private System.Windows.Forms.Button btn_tuberculosis;
        private System.Windows.Forms.Button btn_PHQ;
        private System.Windows.Forms.Button btn_stress;
        private System.Windows.Forms.Button button1;
    }
}