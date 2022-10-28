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
    public partial class Gad7Screening : Form
    {
        public Gad7Screening()
        {
            InitializeComponent();
        }

        private void btn_back_gda7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Survey survey = new Survey();
            survey.Show();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Gad7Screening_Load(object sender, EventArgs e)
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
