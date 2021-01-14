using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Miniprojet.Connection
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string User_name;

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ManipulationBD.ConnectionDataBase();

                string UserName = user.Text;
                string Password = pwd.Text;
                User_name = user.Text;

                MySqlCommand cmd = new MySqlCommand(" Select * from compte where User_name = ? And Pwd = ? ", ManipulationBD.Cnn);
                MySqlParameter P1 = new MySqlParameter("P1", user.Text);
                cmd.Parameters.Add(P1);
                MySqlParameter P2 = new MySqlParameter("P2", pwd.Text);
                cmd.Parameters.Add(P2);

                MySqlDataReader dr = cmd.ExecuteReader();
                

                if (dr != null)
                {

                    while (dr.Read())
                    {
                        if ((string)dr["type_cmp"] == "Administrateur")
                        {
                            Administrateur.Administrateur a = new Administrateur.Administrateur();
                            a.Show();
                            this.Hide();
                            
                        }
                        else
                        {
                            Agent.Agent a = new Agent.Agent();
                            this.Hide();
                            a.Show();
                        }
                    }
                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                ManipulationBD.DecoonectionDataBase();
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            pwd.Clear();
            pwd.PasswordChar = '*';
            pwd.BackColor = Color.WhiteSmoke;
        }

        private void User_Click(object sender, EventArgs e)
        {
            user.Clear();
            user.BackColor = Color.WhiteSmoke;
        }
        
    }
}
