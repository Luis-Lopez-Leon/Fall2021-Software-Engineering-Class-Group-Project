
namespace Health_Care_App
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Login login = new Login();
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
            this.News = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.Button();
            this.Messages = new System.Windows.Forms.Button();
            this.Navigation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Signout = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // News
            // 
            this.News.Location = new System.Drawing.Point(245, 181);
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(149, 61);
            this.News.TabIndex = 0;
            this.News.Text = "News";
            this.News.UseVisualStyleBackColor = true;
            this.News.Click += new System.EventHandler(this.News_Click);
            // 
            // Tools
            // 
            this.Tools.Location = new System.Drawing.Point(443, 181);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(155, 61);
            this.Tools.TabIndex = 1;
            this.Tools.Text = "Tools";
            this.Tools.UseVisualStyleBackColor = true;
            this.Tools.Click += new System.EventHandler(this.Tools_Click);
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(245, 359);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(149, 55);
            this.Messages.TabIndex = 2;
            this.Messages.Text = "Messages";
            this.Messages.UseVisualStyleBackColor = true;
            this.Messages.Click += new System.EventHandler(this.Messages_Click);
            // 
            // Navigation
            // 
            this.Navigation.Location = new System.Drawing.Point(443, 359);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(165, 55);
            this.Navigation.TabIndex = 3;
            this.Navigation.Text = "Navigation";
            this.Navigation.UseVisualStyleBackColor = true;
            this.Navigation.Click += new System.EventHandler(this.Navigation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome back User";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Health_Care_App.Properties.Resources.map_icon;
            this.pictureBox3.Location = new System.Drawing.Point(626, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 131);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Health_Care_App.Properties.Resources.tool_kit_icon;
            this.pictureBox4.Location = new System.Drawing.Point(626, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 123);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Health_Care_App.Properties.Resources.messages_icon;
            this.pictureBox2.Location = new System.Drawing.Point(77, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 131);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Health_Care_App.Properties.Resources.news_icon__4_;
            this.pictureBox1.Location = new System.Drawing.Point(77, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 126);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // Signout
            // 
            this.Signout.Image = global::Health_Care_App.Properties.Resources.sign_error_icon;
            this.Signout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Signout.Location = new System.Drawing.Point(12, 12);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(122, 40);
            this.Signout.TabIndex = 6;
            this.Signout.Text = "Sign Out";
            this.Signout.UseVisualStyleBackColor = true;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // Settings
            // 
            this.Settings.Image = global::Health_Care_App.Properties.Resources.Settings_icon;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(673, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(127, 40);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(812, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Navigation);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.News);
            this.Name = "MainMenu";
            this.Text = "333";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button News;
        private System.Windows.Forms.Button Tools;
        private System.Windows.Forms.Button Messages;
        private System.Windows.Forms.Button Navigation;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}