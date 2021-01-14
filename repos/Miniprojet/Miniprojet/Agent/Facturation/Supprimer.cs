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

namespace Miniprojet.Agent.Tarification
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
            if (rb.Text == "Voiture" || rb.Text == "Camion")
            {

                textBox5.Enabled = true;
                textBox4.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox5.Enabled = true;
                textBox4.Enabled = true;
                textBox3.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulationBD.ConnectionDataBase();

                string Insertion1 = "delete from facturation where Numero_Fact=?";
                string strverif = "select count(*) from facturation where Numero_Fact=?";

                MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
                MySqlParameter p1 = new MySqlParameter("Fact", textBox5.Text);
                cmd1.Parameters.Add(p1);

                MySqlCommand verif = new MySqlCommand(strverif, ManipulationBD.Cnn);
                MySqlParameter p16 = new MySqlParameter("p16", textBox5.Text);
                verif.Parameters.Add(p16);

                long n = (long)verif.ExecuteScalar();
                if (n == 1)
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Suppression effectuez");
                }
                else
                {
                    MessageBox.Show("Impossible car cet Contrat n'existe pas");
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
