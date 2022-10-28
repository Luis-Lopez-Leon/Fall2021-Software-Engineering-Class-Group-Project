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
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
        }

        private void Goals_Click(object sender, EventArgs e)
        {
            this.Hide();
            Goals goals = new Goals();
            goals.Show();

        }

        private void Bluetooth_Click(object sender, EventArgs e)
        {
            this.Hide();
            BluetoothMonitoring bluetoothMonitoring = new BluetoothMonitoring();
            bluetoothMonitoring.Show();

        }

        private void Reminders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reminders reminders = new Reminders();
            reminders.Show();
        }

        private void Screening_Click(object sender, EventArgs e)
        {
            this.Hide();
            Survey survey = new Survey();
            survey.Show();
        }

        private void Scheduler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scheduler scheduler = new Scheduler();
            scheduler.Show();
        }

        private void MeetNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeetNow meetNow = new MeetNow();
            meetNow.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tools_Load(object sender, EventArgs e)
        {

        }
    }
}
