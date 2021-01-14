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

namespace MiniProjet
{
    public partial class Entreprise : Form
    {
        Connexion link;
       
        public Entreprise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etranger etranger = new Etranger();
            etranger.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tunisien tunisien = new Tunisien();
            tunisien.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else
                if (textBox3.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox8.Text != textBox7.Text)
            {
                MessageBox.Show(" les mots de passe ne correspondent pas !! ");
            }
            else
            {
                if (link.Connected)
                {

                    link.cmd = new MySqlCommand(" INSERT INTO entreprise values (@CodeC,@CodeFiscal,@RaisonS,@AdresseE,@TelE,@UsernameE,@PasswordE,@ConfirmPwdE)", link.connexion);
                    link.cmd.Parameters.AddWithValue("@CodeC", int.Parse(textBox1.Text));
                    link.cmd.Parameters.AddWithValue("@CodeFiscal", int.Parse(textBox2.Text));
                    link.cmd.Parameters.AddWithValue("@RaisonS", textBox3.Text);
                    link.cmd.Parameters.AddWithValue("@AdresseE", textBox4.Text);
                    link.cmd.Parameters.AddWithValue("@TelE", int.Parse(textBox5.Text));
                    link.cmd.Parameters.AddWithValue("@UsernameE", textBox6.Text);
                    link.cmd.Parameters.AddWithValue("@PasswordE", textBox7.Text);
                    link.cmd.Parameters.AddWithValue("@ConfirmPwdE", textBox8.Text);

                    link.cmd.ExecuteNonQuery();
                    //link.cmd.Parameters.Clear();

                }
                else
                {
                    MessageBox.Show(" Vous n'etes pas connecter !! ");
                }
            }
        }

            

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
        }
    }
}
