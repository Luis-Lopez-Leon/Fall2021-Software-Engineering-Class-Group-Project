
namespace Health_Care_App
{
    partial class Navigation
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
            this.Back = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Search_data = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-1, 156);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Search_data);
            this.splitContainer1.Panel1.Controls.Add(this.Zip);
            this.splitContainer1.Panel1.Controls.Add(this.State);
            this.splitContainer1.Panel1.Controls.Add(this.City);
            this.splitContainer1.Panel1.Controls.Add(this.Street);
            this.splitContainer1.Panel1.Controls.Add(this.txt_zip);
            this.splitContainer1.Panel1.Controls.Add(this.txt_state);
            this.splitContainer1.Panel1.Controls.Add(this.txt_city);
            this.splitContainer1.Panel1.Controls.Add(this.txt_street);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1188, 512);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(906, 512);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(88, 62);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(178, 20);
            this.txt_street.TabIndex = 0;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(88, 125);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(178, 20);
            this.txt_city.TabIndex = 0;
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(88, 197);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(178, 20);
            this.txt_state.TabIndex = 0;
            // 
            // txt_zip
            // 
            this.txt_zip.Location = new System.Drawing.Point(88, 269);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.Size = new System.Drawing.Size(178, 20);
            this.txt_zip.TabIndex = 0;
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.BackColor = System.Drawing.SystemColors.Control;
            this.Street.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Street.Location = new System.Drawing.Point(3, 57);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(64, 24);
            this.Street.TabIndex = 1;
            this.Street.Text = "Street";
            this.Street.Click += new System.EventHandler(this.label1_Click);
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.BackColor = System.Drawing.SystemColors.Control;
            this.Zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip.Location = new System.Drawing.Point(7, 269);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(40, 24);
            this.Zip.TabIndex = 4;
            this.Zip.Text = "Zip";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.BackColor = System.Drawing.SystemColors.Control;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(3, 197);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(56, 24);
            this.State.TabIndex = 3;
            this.State.Text = "State";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.BackColor = System.Drawing.SystemColors.Control;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(3, 125);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(44, 24);
            this.City.TabIndex = 2;
            this.City.Text = "City";
            // 
            // Search_data
            // 
            this.Search_data.Location = new System.Drawing.Point(88, 332);
            this.Search_data.Name = "Search_data";
            this.Search_data.Size = new System.Drawing.Size(121, 35);
            this.Search_data.TabIndex = 5;
            this.Search_data.Text = "Search";
            this.Search_data.UseVisualStyleBackColor = true;
            this.Search_data.Click += new System.EventHandler(this.Search_data_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Navigation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Health_Care_App.Properties.Resources.navigation_icon;
            this.pictureBox1.Location = new System.Drawing.Point(539, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 123);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1186, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Back);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Button Search_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}