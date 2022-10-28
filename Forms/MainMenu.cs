using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_App
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void News_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            News news = new News();
            news.Show();
        }

        private void Tools_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tools tools = new Tools();
            tools.Show();
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Messages messages = new Messages();
            messages.Show();
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation navigation = new Navigation();
            navigation.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}
