using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Health_Care_App
{
    public partial class Login : Form
    {
        string username;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = Username.Text;
            string password = Password.Text;

            string connectionString = @"server=(localdb)\MSSQLLocalDB;database=Test Database;integrated Security=SSPI;";

            /*using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement = "SELECT * FROM dbo.Login Where Username = '" + username + "' and Password = '" + password + "'";
                string output = "";
                bool loginSuccessful = false;
                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    _con.Open();
                    SqlDataReader dataReader = _cmd.ExecuteReader();
                    
                    while(dataReader.Read())
                    {
                        if(dataReader.HasRows)
                        {
                            loginSuccessful = true;
                        }
                    }

                    if(loginSuccessful)
                    {
                        this.Hide();
                        MainMenu menu = new MainMenu();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful");
                        Password.Text = "";
                        Username.Text = "";
                    }

                    _con.Close();
                    dataReader.Close();
                    _cmd.Dispose();
                }
            }*/

            if(username == "admin" && password == "password1")
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful");
                Password.Text = "";
                Username.Text = "";
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassReset password = new PassReset();
            password.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
