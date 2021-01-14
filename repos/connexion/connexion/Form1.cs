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

        //Connexion a la base des données

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == " Se connecter ")
            {
                connexion = new MySqlConnection("database=tchat; server=localhost; userID=root; pwd='' ");
                
                try
                {
                    if (connexion.State == ConnectionState.Closed)
                    {
                        connexion.Open();
                    }
                    button1.Text = " Se deconnecter ";
                    connected = true;

                }catch(Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                }
               
            }else
            {
                //connexion.Close();
                button1.Text = " Se connecter ";
                connected = false;

            }
        }

        //Ajout d'un ou +++ elements 

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show(" Entrez un nom !!");
            }else 
                if( textBox2.Text == "")
            {
                MessageBox.Show(" Entrez l'age !! ");
            }else
            {
                if(connected)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users VALUES (NULL,@nom,@age)", connexion);
                    cmd.Parameters.AddWithValue("@nom", textBox1.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(textBox2.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show(" Ajout avec succés !!");

                }else
                {
                    MessageBox.Show(" Veillez vous connectez a une base des données !! ");
                }
            }
        }
        
        //Affichage des elements;

        private void button3_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                listView1.Items.Clear();

                MySqlCommand cmd = new MySqlCommand(" SELECT * from users ",connexion);
                using (MySqlDataReader lire = cmd.ExecuteReader())
                {
                    while(lire.Read())
                    {
                        string id = lire["id"].ToString();
                        string nom = lire["nom"].ToString();
                        string age = lire["age"].ToString();

                        listView1.Items.Add(new ListViewItem(new [] { id, nom, age }))   ;

                    }
                }
            }
            else
                MessageBox.Show(" Vous n'etes pas connecter !! ");
        }

        // Suppression d'un element

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(connected)
            {
                if(listView1.SelectedItems.Count > 0)
                {

                    ListViewItem champ = listView1.SelectedItems[0];
                    string id = champ.SubItems[0].Text;
                    MySqlCommand cmd = new MySqlCommand(" DELETE from users where id = @id ", connexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    champ.Remove();
                    MessageBox.Show(" Element supprimer !! ");

                }
            }
        }

        //Modification des attributs

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem champ = listView1.SelectedItems[0];

                string id = champ.SubItems[0].Text;
                string nom = champ.SubItems[1].Text;
                string age = champ.SubItems[2].Text;

                using (Modification edit = new Modification())
                {
                    edit.id = id;
                    edit.Nom = nom;
                    edit.Age = age;

                    if(edit.ShowDialog() == DialogResult.Yes)
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE users SET nom=@nom, age=@age WHERE id=@id ", connexion);
                        cmd.Parameters.AddWithValue("@nom", edit.Nom);
                        cmd.Parameters.AddWithValue("@age", edit.Age);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        champ.SubItems[1].Text = edit.Nom;
                        champ.SubItems[2].Text = edit.Age;

                        MessageBox.Show(" Element Modifier !! ");

                    }
                }
            }
        }

                            //  RECHERCHE DANS UNE TABLE

        // Recherche avec id 

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * from users WHERE id=@id ", connexion);
            cmd.Parameters.AddWithValue("@id", textBox3.Text);
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

        //Recherche avec le nom et l'age 

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * from users WHERE nom=@nom and age = @age ", connexion);
            cmd.Parameters.AddWithValue("@nom", textBox4.Text);
            cmd.Parameters.AddWithValue("@age", textBox5.Text);
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

        // Recherche avec age inferieur a ...

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * from users WHERE age < @age ", connexion);
            cmd.Parameters.AddWithValue("@age", textBox6.Text);
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

        // Tri des element de la table par <Nom> ;

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * from users ORDER BY nom ", connexion);
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
    }
}