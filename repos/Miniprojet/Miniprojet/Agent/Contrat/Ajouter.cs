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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            this.Hide();
            a.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            RadioButton rb = null;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                rb = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb.Checked)
                    break;
            }
            if (rb.Text == "Voiture" || rb.Text=="Camion")
            {
                textBox7.Enabled = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                radioButton2.Enabled = true;
            }
            else 
            {
                radioButton1.Checked = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox7.Enabled = true;


                textBox6.Enabled = false;
                radioButton2.Enabled=false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = false;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = false;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;

            textBox6.Enabled = false;
            radioButton2.Enabled = false;
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
                
                    string Insertion1 = "insert into contrat values (?,?,?,?,?,?,?,?,?,?)";
                    string strverif = "select count(*) from contrat where num_contrat=?";

                    MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
                    MySqlParameter p1 = new MySqlParameter("p1", textBox1.Text);
                    cmd1.Parameters.Add(p1);
                    MySqlParameter p2 = new MySqlParameter("p2", textBox3.Text);
                    cmd1.Parameters.Add(p2);
                    MySqlParameter p3 = new MySqlParameter("p3", textBox4.Text);
                    cmd1.Parameters.Add(p3);
                    MySqlParameter p4 = new MySqlParameter("p4", textBox2.Text);
                    cmd1.Parameters.Add(p4);
                    MySqlParameter p5 = new MySqlParameter("p5", textBox5.Text);
                    cmd1.Parameters.Add(p5);
                    MySqlParameter p6 = new MySqlParameter("p6", dateTimePicker1.Text);
                    cmd1.Parameters.Add(p6);
                    MySqlParameter p7 = new MySqlParameter("p7", dateTimePicker2.Text);
                    cmd1.Parameters.Add(p7);
                    MySqlParameter p8 = new MySqlParameter("p8", rb.Text);
                    cmd1.Parameters.Add(p8);
                    MySqlParameter p9 = new MySqlParameter("p9", textBox6.Text);
                    cmd1.Parameters.Add(p9);
                    MySqlParameter p10 = new MySqlParameter("p10", textBox7.Text);
                    cmd1.Parameters.Add(p10);

                    MySqlCommand verif = new MySqlCommand(strverif, ManipulationBD.Cnn);
                    MySqlParameter p16 = new MySqlParameter("p16", textBox1.Text);
                    verif.Parameters.Add(p16);

                    long n = (long)verif.ExecuteScalar();
                    if (n == 0)
                    {
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Ajout effectuez");
                    }
                    else
                    {
                        MessageBox.Show("Ajout Impossible car Risque de Doublon");
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
