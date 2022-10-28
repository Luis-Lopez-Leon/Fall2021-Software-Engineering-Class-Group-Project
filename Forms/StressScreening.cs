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
    public partial class StressScreening : Form
    {
        public StressScreening()
        {
            InitializeComponent();
        }

        private void btn_stress_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Survey survey = new Survey();
            survey.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StressScreening_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Hide();
            Survey survey = new Survey();
            survey.Show();
        }
    }
}
