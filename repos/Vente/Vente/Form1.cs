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

namespace Vente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Connextion a la base des données

        MySqlConnection Connexion;
        bool connected = false;

        private void button1_Click(object sender, EventArgs e)
        {
           if(button1.Text == "Se Connecter a la Base des données")
            {
                Connexion = new MySqlConnection("database = vente; server = localhost; userId = root; pwd = '' ");

                try
                {
                    if(Connexion.State == ConnectionState.Closed)
                    {
                        Connexion.Open();
                        
                    }
                    button1.Text = " Se deconnecter a la Base des données ";
                    connected = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }else
            {
                button1.Text = "Se Connecter a la Base des données";
                connected = false;
            }
        }

        //Ajout d'un produit 

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show(" Inserer le code du produit ! ");
            }else if(textBox2.Text == "")
            {
                MessageBox.Show(" Inserer le Nom du produit ! ");
            }else if(textBox3.Text == "")
            {
                MessageBox.Show(" Inserer le prix unitaire ! ");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show(" Inserer la quantité ! ");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show(" Inserer le seuil ! ");
            }else
            {
                if(connected)
                {
                    MySqlCommand cmd = new MySqlCommand(" INSERT INTO produit values (@CodP,@libellé,@PU,@Qtes,@Seuil)", Connexion);
                    cmd.Parameters.AddWithValue("@CodP", textBox1.Text);
                    cmd.Parameters.AddWithValue("@libellé", textBox2.Text);
                    cmd.Parameters.AddWithValue("@PU", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Qtes", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Seuil", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show(" Produit Ajouter ! ");

                }else
                {
                    MessageBox.Show(" Veilllez vous connecter a une base des données");
                }
            }

        }

        //Affichage de la liste des produits

        private void button4_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                listView1.Items.Clear();

                MySqlCommand cmd = new MySqlCommand(" SELECT * from produit ", Connexion);
                using (MySqlDataReader lire = cmd.ExecuteReader())
                {
                    while (lire.Read())
                    {
                        string Code = lire["CodP"].ToString();
                        string Lib = lire["libellé"].ToString();
                        string PU = lire["PU"].ToString();
                        string Qtes = lire["Qtes"].ToString();
                        string Seuil = lire["Seuil"].ToString();

                        listView1.Items.Add(new ListViewItem(new[] { Code, Lib, PU, Qtes, Seuil }));

                    }
                }
            }
            else
                MessageBox.Show(" Vous n'etes pas connecter !! ");
        }

        // Insertion d'un Client

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show(" Inserer le nom du client ! ");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show(" Inserer l'adresse du client  ! ");
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show(" Inserer le Chiffre d'affaire  !!! ");
            }
            else
            {
                if (connected)
                {
                    MySqlCommand cmd = new MySqlCommand(" INSERT INTO client values (NULL,@NomC,@CreditC,@AdrC,@CA)", Connexion);
                    cmd.Parameters.AddWithValue("@NomC", textBox6.Text);
                    cmd.Parameters.AddWithValue("@CreditC", textBox8.Text);
                    cmd.Parameters.AddWithValue("@AdrC", textBox7.Text);
                    cmd.Parameters.AddWithValue("@CA", textBox9.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show(" L'identité client a eté ajouter ! ");

                }
                else
                {
                    MessageBox.Show(" Veilllez vous connecter a une base des données");
                }
            }

        }

        // Affichage de la liste des clients

        private void button5_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                listView2.Items.Clear();

                MySqlCommand cmd = new MySqlCommand(" SELECT * from client ", Connexion);
                using (MySqlDataReader lire = cmd.ExecuteReader())
                {
                    while (lire.Read())
                    {
                        string Code = lire["CodC"].ToString();
                        string Nom = lire["NomC"].ToString();
                        string Credit = lire["CreditC"].ToString();
                        string Adresse = lire["AdrC"].ToString();
                        string Ch_Aff = lire["CA"].ToString();

                        listView2.Items.Add(new ListViewItem(new[] { Code, Nom, Credit, Adresse, Ch_Aff }));

                    }
                }
            }
            else
                MessageBox.Show(" Vous n'etes pas connecter !! ");
        }

        // Somme chiffre d'affaire

        private void button6_Click(object sender, EventArgs e)
        {
            bool lecture;

            if(connected)
            {
                listView3.Items.Clear();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader resultat;

                cmd.Connection = Connexion;
                cmd.CommandText = (" SELECT SUM(CA) as 'som_ca' from client");

                try
                {
                    listView3.Items.Clear();
                    resultat = cmd.ExecuteReader();

                    if(resultat.HasRows == true)
                    {
                        lecture = resultat.Read();

                        while(lecture == true)
                        {
                            listView3.Items.Add(resultat.GetString(0));
                            lecture = resultat.Read();
                        }
                    }
                    lecture = resultat.Read();
                    resultat.Close();
                } catch( Exception ex)
                {
                    MessageBox.Show(" Erreur d'Execute reader ");
                }
            }
        }

        //Moyenne Prix Unitaire

        private void button7_Click(object sender, EventArgs e)
        {
            bool lecture;

            if (connected)
            {
                listView4.Items.Clear();
                MySqlCommand cmd = new MySqlCommand(" SELECT avg(PU) as 'moy_pu' from produit",Connexion);
                MySqlDataReader resultat;
                

                try
                {
                    listView4.Items.Clear();
                    resultat = cmd.ExecuteReader();

                    if (resultat.HasRows == true)
                    {
                        lecture = resultat.Read();

                        while (lecture == true)
                        {
                            listView4.Items.Add(resultat.GetString(0));
                            lecture = resultat.Read();
                        }
                    }
                    lecture = resultat.Read();
                    resultat.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " Erreur d'Execute reader ");
                }
            }
        }

        // Valeur Min et Max de la quantité

        private void button8_Click(object sender, EventArgs e)
        {
            bool lecture;

            if (connected)
            {
                listView5.Items.Clear();
                MySqlCommand cmd = new MySqlCommand(" SELECT MAX(Qtes) from produit UNION SELECT  MIN(Qtes)  from produit", Connexion);
                MySqlDataReader resultat;


                try
                {
                    listView5.Items.Clear();
                    resultat = cmd.ExecuteReader();

                    if (resultat.HasRows == true)
                    {
                        lecture = resultat.Read();

                        while (lecture == true)
                        {
                            listView5.Items.Add(resultat.GetString(0));
                            lecture = resultat.Read();
                        }
                    }
                    lecture = resultat.Read();
                    resultat.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " Erreur d'Execute reader ");
                }
            }else
            {
                MessageBox.Show(" Vous n'etes pas connecter !! ");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
                MessageBox.Show(" Inserer le numero de la commande !!");
            else
             if (textBox11.Text == "")
                MessageBox.Show(" Inserer la date de la commande !! ");
            else
             if (textBox12.Text == "")
                MessageBox.Show(" Inserer le code du client !!");
            else
            if(connected)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO commande values(@NumC,@DatC,@CodC)", Connexion);
                cmd.Parameters.AddWithValue("@NumC", textBox10.Text);
                cmd.Parameters.AddWithValue("@DatC", textBox11.Text);
                cmd.Parameters.AddWithValue("@CodC", textBox12.Text);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }else
            {
                MessageBox.Show(" Vous etes pas connecter !! ");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                listView6.Items.Clear();

                MySqlCommand cmd = new MySqlCommand(" SELECT * from commande", Connexion);
                using (MySqlDataReader lire = cmd.ExecuteReader())
                {
                    while (lire.Read())
                    {
                        string Numero= lire["NumC"].ToString();
                        string Date = lire["DatC"].ToString();
                        string Code = lire["CodC"].ToString();
                       

                        listView6.Items.Add(new ListViewItem(new[] { Numero, Date,Code }));

                    }
                }
            }
            else
                MessageBox.Show(" Vous n'etes pas connecter !! ");
        }

        
    }
}
