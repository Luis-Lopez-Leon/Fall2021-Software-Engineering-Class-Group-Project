using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Health_Care_App.Forms;

namespace Health_Care_App
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void AccountInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfomation accountInfomation = new AccountInfomation();
            accountInfomation.Show();
              
        }

        private void AppSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppSetting appSetting = new AppSetting();
            appSetting.Show();

        }

        private void BluetoothSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            BluetoothSetting bluetoothSetting = new BluetoothSetting();
            bluetoothSetting.Show();

        }

        private void AppInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppsInfo appsInfo = new AppsInfo();
            appsInfo.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
