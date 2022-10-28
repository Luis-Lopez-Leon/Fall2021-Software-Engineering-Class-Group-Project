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
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tools tools = new Tools();
            tools.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_covid_Click(object sender, EventArgs e)
        {
            this.Hide();
            CovidScreening covidScreening = new CovidScreening();
            covidScreening.Show();
        }

        private void btn_gad7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gad7Screening gad7Screening = new Gad7Screening();
            gad7Screening.Show();
        }

        private void btn_tuberculosis_Click(object sender, EventArgs e)
        {
            this.Hide();
            TuberculosisScreening tuberculosisScreening = new TuberculosisScreening();
            tuberculosisScreening.Show();

        }

        private void btn_PHQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHQScreening pHQScreening = new PHQScreening();
            pHQScreening.Show();
        }

        private void btn_stress_Click(object sender, EventArgs e)
        {
            this.Hide();
            StressScreening stressScreening = new StressScreening();
            stressScreening.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CageScreening cageScreening = new CageScreening();
            cageScreening.Show();
        }

        private void Survey_Load(object sender, EventArgs e)
        {

        }
    }
}
