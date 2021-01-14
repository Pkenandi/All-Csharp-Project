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

namespace Miniprojet.Agent.Client
{
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            this.Hide();
            a.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            RadioButton rb = null;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                rb = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb.Checked)
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulationBD.ConnectionDataBase();

                RadioButton rb = null;
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    rb = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                    if (rb.Checked)
                        break;
                }

                string Tunisien = "delete from client where code_client=?";
                string Etranger = "delete from client where code_client=?";
                string Entreprise = "delete from client where code_client=?";
                string strverif = "select count(*) from client where code_client=?";

                MySqlCommand cmd1 = new MySqlCommand(Tunisien, ManipulationBD.Cnn);
                MySqlParameter p1 = new MySqlParameter("code_client", cd_client.Text);
                cmd1.Parameters.Add(p1);

                MySqlCommand cmd2 = new MySqlCommand(Etranger, ManipulationBD.Cnn);
                MySqlParameter p2 = new MySqlParameter("code_client", cd_client.Text);
                cmd2.Parameters.Add(p2);

                MySqlCommand cmd3 = new MySqlCommand(Entreprise, ManipulationBD.Cnn);
                MySqlParameter p3 = new MySqlParameter("code_client", cd_client.Text);
                cmd3.Parameters.Add(p3);

                MySqlCommand verif = new MySqlCommand(strverif, ManipulationBD.Cnn);
                MySqlParameter par = new MySqlParameter("par", cd_client.Text);
                verif.Parameters.Add(par);

                long n=(long)verif.ExecuteScalar();

                if(n > 0)
                {
                    if (rb.Text == "Tunisien")
                    {
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Suppression effectuez");
                    }
                    else if (rb.Text == "Etranger")
                    {
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Suppression effectuez");
                    }
                    else
                    {
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Suppression effectuez");
                    }
                }
                else
                {
                    MessageBox.Show("Suppression Impossible car Il n'existe pas !");
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally
            {
                ManipulationBD.DecoonectionDataBase();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Agent().Show();
        }
    }
}
