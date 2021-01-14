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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            this.Hide();
            a.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = false;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox7.Enabled = false;
            textBox10.Enabled = true;
            textBox1.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = false;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox7.Enabled = false;
            textBox10.Enabled = true;
            textBox1.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Enabled = true;
            textBox6.Enabled = false;
            textBox2.Enabled = true;
            textBox8.Enabled = false;
            textBox9.Enabled = true;
            textBox7.Enabled = true;
            textBox10.Enabled = true;
            textBox1.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
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
                textBox6.Enabled = true;
                textBox2.Enabled = false;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox7.Enabled = false;
                textBox10.Enabled = true;
                textBox1.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
            }
            else
            {
                textBox5.Enabled = true;
                textBox4.Enabled = true;
                textBox3.Enabled = true;
                textBox6.Enabled = false;
                textBox2.Enabled = true;
                textBox8.Enabled = false;
                textBox9.Enabled = true;
                textBox7.Enabled = true;
                textBox10.Enabled = true;
                textBox1.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
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

                string Insertion1 = "insert into facturation values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
                string strverif = "select count(*) from facturation where Numero_Fact=?";

                MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
                MySqlParameter p1 = new MySqlParameter("p1", textBox5.Text);
                cmd1.Parameters.Add(p1);
                MySqlParameter p2 = new MySqlParameter("p2", textBox3.Text);
                cmd1.Parameters.Add(p2);
                MySqlParameter p3 = new MySqlParameter("p3", textBox4.Text);
                cmd1.Parameters.Add(p3);
                MySqlParameter p4 = new MySqlParameter("p4", rb.Text);
                cmd1.Parameters.Add(p4);
                MySqlParameter p5 = new MySqlParameter("p5", textBox6.Text);
                cmd1.Parameters.Add(p5);
                MySqlParameter p6 = new MySqlParameter("p6", textBox8.Text);
                cmd1.Parameters.Add(p6);
                MySqlParameter p7 = new MySqlParameter("p7", textBox1.Text);
                cmd1.Parameters.Add(p7);
                MySqlParameter p8 = new MySqlParameter("p8", textBox9.Text);
                cmd1.Parameters.Add(p8);
                MySqlParameter p9 = new MySqlParameter("p9", textBox10.Text);
                cmd1.Parameters.Add(p9);
                MySqlParameter p10 = new MySqlParameter("p10", textBox11.Text);
                cmd1.Parameters.Add(p10);
                MySqlParameter p11 = new MySqlParameter("p11", textBox12.Text);
                cmd1.Parameters.Add(p11);
                MySqlParameter p12 = new MySqlParameter("p12", textBox13.Text);
                cmd1.Parameters.Add(p12);
                MySqlParameter p13 = new MySqlParameter("p13", textBox14.Text);
                cmd1.Parameters.Add(p13);
                MySqlParameter p14 = new MySqlParameter("p14", textBox2.Text);
                cmd1.Parameters.Add(p14);
                MySqlParameter p15 = new MySqlParameter("p15", textBox7.Text);
                cmd1.Parameters.Add(p15);

                MySqlCommand verif = new MySqlCommand(strverif, ManipulationBD.Cnn);
                MySqlParameter p16 = new MySqlParameter("p16", textBox5.Text);
                verif.Parameters.Add(p16);

                long n = (long)verif.ExecuteScalar();
                if (n == 0)
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Ajout effectuez");
                }
                else
                {
                    MessageBox.Show("Impossible car Risque de Doublon");
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
