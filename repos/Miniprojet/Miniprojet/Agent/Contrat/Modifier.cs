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
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }

        private void Modifier_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            this.Hide();
            a.Show();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = false;

            textBox1.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox6.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = false;

            textBox1.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox6.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            textBox1.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox8.Enabled = true;

            textBox6.Enabled = false;
            radioButton2.Enabled = false;
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
            if (rb.Text == "Voiture" || rb.Text == "Camion")
            {
                textBox8.Enabled = false;

                textBox1.Enabled = true;
                textBox5.Enabled = true;
                textBox4.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox6.Enabled = true;
                radioButton2.Enabled = true;
            }
            else
            {
                radioButton1.Checked = true;
                textBox1.Enabled = true;
                textBox5.Enabled = true;
                textBox4.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox8.Enabled = true;


                textBox6.Enabled = false;
                radioButton2.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
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

                RadioButton rb = null;
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    rb = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                    if (rb.Checked)
                        break;
                }

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
                else if (textBox4.Text == "")
                {
                    MessageBox.Show(" Champ vide !! ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show(" Champ vide !! ");
                }
                else if (textBox6.Text == "")
                {
                    MessageBox.Show(" Champ vide !! ");
                }
                else if (textBox7.Text == "")
                {
                    MessageBox.Show(" Champ vide !! ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show(" Champ vide !! ");
                }
                else
                {
                    string Insertion1 = "update contrat set Numero_Contrat=?,Numero_Chassis=?,Numero=?,Code_Client=?,Montant_Avance=?,Date_Debut_Loc=?,Date_Retour_prev=?,Chauffeur=?,Valeur_Compteur_Km=?,Valeur_Compteur_Heure=? where Numero_Contrat=?";
                    string strverif = "select count(*) from contrat where Numero_Contrat=?";

                    MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
                    MySqlParameter p1 = new MySqlParameter("p1", textBox1.Text);
                    cmd1.Parameters.Add(p1);
                    MySqlParameter p2 = new MySqlParameter("p2", textBox4.Text);
                    cmd1.Parameters.Add(p2);
                    MySqlParameter p3 = new MySqlParameter("p3", textBox2.Text);
                    cmd1.Parameters.Add(p3);
                    MySqlParameter p4 = new MySqlParameter("p4", textBox5.Text);
                    cmd1.Parameters.Add(p4);
                    MySqlParameter p5 = new MySqlParameter("p5", textBox3.Text);
                    cmd1.Parameters.Add(p5);
                    MySqlParameter p6 = new MySqlParameter("p6", dateTimePicker1.Text);
                    cmd1.Parameters.Add(p6);
                    MySqlParameter p7 = new MySqlParameter("p7", dateTimePicker2.Text);
                    cmd1.Parameters.Add(p7);
                    MySqlParameter p8 = new MySqlParameter("p8", rb.Text);
                    cmd1.Parameters.Add(p8);
                    MySqlParameter p9 = new MySqlParameter("p9", textBox6.Text);
                    cmd1.Parameters.Add(p9);
                    MySqlParameter p10 = new MySqlParameter("p10", textBox8.Text);
                    cmd1.Parameters.Add(p10);
                    MySqlParameter p11 = new MySqlParameter("p11", textBox7.Text);
                    cmd1.Parameters.Add(p11);

                    MySqlCommand verif = new MySqlCommand(strverif, ManipulationBD.Cnn);
                    MySqlParameter p16 = new MySqlParameter("p16", textBox1.Text);
                    verif.Parameters.Add(p16);

                    long n = (long)verif.ExecuteScalar();
                    if (n == 1)
                    {
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuez");
                    }
                    else
                    {
                        MessageBox.Show("Modification Impossible car cet Contrat n'existe pas");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulationBD.ConnectionDataBase();

                RadioButton rb1 = null;
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    rb1 = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                    if (rb1.Checked)
                        break;
                }


                string update = "select * from contrat where Numero_Contrat=?";

                MySqlCommand cmd = new MySqlCommand(update, ManipulationBD.Cnn);
                MySqlParameter p = new MySqlParameter("p", textBox7.Text);
                cmd.Parameters.Add(p);

                MySqlDataReader dr = cmd.ExecuteReader();
                if(dr!=null)
                {
                    while(dr.Read())
                    {
                        rb1.Text = (string)dr[7];
                        dateTimePicker1.Text = ((DateTime)dr[6]).ToString();
                        dateTimePicker2.Text= ((DateTime)dr[5]).ToString();
                        textBox1.Text = ((int)dr[0]).ToString();
                        textBox5.Text = ((int)dr[3]).ToString();
                        textBox4.Text = ((int)dr[1]).ToString();
                        textBox2.Text = ((int)dr[2]).ToString();
                        textBox3.Text = ((int)dr[4]).ToString();
                        textBox6.Text=((int)dr[8]).ToString();
                        textBox8.Text = ((int)dr[9]).ToString();
                    }
                }
            }
            catch(Exception r)
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
