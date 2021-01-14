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
    public partial class Etranger : Form
    {
        Connexion Link;

        public Etranger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tunisien tunisien = new Tunisien();
            tunisien.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entreprise entreprise = new Entreprise();
            entreprise.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
            else if (textBox5.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox11.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if (textBox12.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }
            else if(textBox13.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }else if(textBox13.Text != textBox12.Text)
            {
                MessageBox.Show(" mots de passes non identites ! ");
            }else
            {
                if(Link.Connected)
                {
                    Link.cmd = new MySqlCommand(" INSERT INTO etranger values (@CodeC,@@Passport,@Nom,@Prenom,@Pays_O,@Tel,@UserNameE,@Pwd,@ConfPwd)", Link.connexion);
                    Link.cmd.Parameters.AddWithValue("@CodeC", int.Parse(textBox1.Text));
                    Link.cmd.Parameters.AddWithValue("@Passport", int.Parse(textBox2.Text));
                    Link.cmd.Parameters.AddWithValue("@Nom", textBox3.Text);
                    Link.cmd.Parameters.AddWithValue("@Prenom", textBox5.Text);
                    Link.cmd.Parameters.AddWithValue("@Pays_O", int.Parse(textBox7.Text));
                    Link.cmd.Parameters.AddWithValue("@Tel", textBox9.Text);
                    Link.cmd.Parameters.AddWithValue("@Adresse", textBox11.Text);
                    Link.cmd.Parameters.AddWithValue("@UserNameE", textBox10.Text);
                    Link.cmd.Parameters.AddWithValue("@Pwd", textBox12.Text);
                    Link.cmd.Parameters.AddWithValue("@ConfPwd", textBox13.Text);

                    Link.cmd.ExecuteNonQuery();
                    Link.cmd.Parameters.Clear();
                }else
                {
                    MessageBox.Show(" Vous n'etes pas connectez !! ");
                }
            }
        }
    }
}
