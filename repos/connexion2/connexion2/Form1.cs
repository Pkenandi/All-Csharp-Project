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

namespace connexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection connexion;
        bool connected = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == " Se connecter ")
            {
                connexion = new MySqlConnection("database=tchat; server=localhost; userID=root; pwd=root;");

                try
                {
                    if (connexion.State == ConnectionState.Closed)
                    {
                        connexion.Open();
                    }
                    button1.Text = " Se deconnecter ";
                    connected = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                //connexion.Close();
                button1.Text = " Se connecter ";
                connected = false;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(" Entrez un nom !!");
            }
            else
               if (textBox2.Text == "")
            {
                MessageBox.Show(" Entrez l'age !! ");
            }
            else
            {
                if (connected)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users VALUES (NULL,@nom,@age)", connexion);
                    cmd.Parameters.AddWithValue("@nom", textBox1.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(textBox2.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show(" Ajout avec succés !!");

                }
                else
                {
                    MessageBox.Show(" Veillez vous connectez a une base des données !! ");
                }
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (connected)
            {
                listView1.Items.Clear();

                MySqlCommand cmd = new MySqlCommand(" SELECT * from users ", connexion);
                using (MySqlDataReader lire = cmd.ExecuteReader())
                {
                    while (lire.Read())
                    {
                        string id = lire["id"].ToString();
                        string nom = lire["nom"].ToString();
                        string age = lire["age"].ToString();

                        listView1.Items.Add(new ListViewItem(new[] { id, nom, age }));

                    }
                }
            }
            else
                MessageBox.Show(" Vous n'etes pas connecter !! ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
