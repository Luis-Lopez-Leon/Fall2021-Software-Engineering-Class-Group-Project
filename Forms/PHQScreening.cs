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
    public partial class PHQScreening : Form
    {
        public PHQScreening()
        {
            InitializeComponent();
        }

        private void btn_PHQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Survey survey = new Survey();
            survey.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Hide();
            Survey survey = new Survey();
            survey.Show();
        }
    }
}
