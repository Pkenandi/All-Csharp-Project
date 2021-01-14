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

namespace Miniprojet.Agent.Contrat
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulationBD.ConnectionDataBase();

                if (textBox1.Text == "")
                {
                    MessageBox.Show(" Champ vide !!");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show(" Champ vide !! ");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show(" Champ vide !! ");
                }
                else
                {
                    string Insertion1 = "delete from contrat where Numero_Contrat=?";
                    string strverif = "select count(*) from contrat where Numero_Contrat=?";

                    MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
                    MySqlParameter p1 = new MySqlParameter("Contrat", textBox1.Text);
                    cmd1.Parameters.Add(p1);

                    MySqlCommand verif = new MySqlCommand(strverif, ManipulationBD.Cnn);
                    MySqlParameter p16 = new MySqlParameter("p16", textBox1.Text);
                    verif.Parameters.Add(p16);

                    long n = (long)verif.ExecuteScalar();
                    if (n == 1)
                    {
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Suppression effectuez");
                    }
                    else
                    {
                        MessageBox.Show("Suppression Impossible Car le Contrat N'existe pas");
                    }
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
    }
}
