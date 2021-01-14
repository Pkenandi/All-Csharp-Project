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
    public partial class Tunisien : Form
    {
        public Connexion Link;

        public Tunisien()
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
            }else if(textBox12.Text == "")
            {
                MessageBox.Show(" Il y a un champ vide ! ");
            }else
                if(textBox12.Text != textBox10.Text)
            {
                MessageBox.Show(" Les mots de passe ne correspondent pas !! ");
            }else
            {
                if(Link.Connected)
                {
                    Link.cmd = new MySqlCommand(" INSERT INTO tunisien values (@CodeC,@CIN,@Nom,@Prenom,@NumTel,@AdresseT,@UserNameT,@PwdT,@ConfPwdT)", Link.connexion);
                    Link.cmd.Parameters.AddWithValue("@CodeC", int.Parse(textBox1.Text));
                    Link.cmd.Parameters.AddWithValue("@CIN", int.Parse(textBox2.Text));
                    Link.cmd.Parameters.AddWithValue("@Nom", textBox3.Text);
                    Link.cmd.Parameters.AddWithValue("@Prenom", textBox5.Text);
                    Link.cmd.Parameters.AddWithValue("@NumTel", int.Parse(textBox7.Text));
                    Link.cmd.Parameters.AddWithValue("@AdresseT", textBox9.Text);
                    Link.cmd.Parameters.AddWithValue("@UserNameT", textBox11.Text);
                    Link.cmd.Parameters.AddWithValue("@PwdT", textBox10.Text);
                    Link.cmd.Parameters.AddWithValue("@ConfPwdT", textBox12.Text);

                    Link.cmd.ExecuteNonQuery();
                    Link.cmd.Parameters.Clear();

                }else
                {
                    MessageBox.Show(" Vous n'etes pas connectez !! ");
                }

                Societé societé = new Societé();
                societé.Show();

            }
        }
    }
}
