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

namespace Miniprojet.Administrateur.Tarif
{
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrateur a = new Administrateur();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Insertion1 = "delete from tarification where Id_tarif =?";
            MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
            MySqlParameter p1 = new MySqlParameter("Id_tarif", textBox6.Text);
            cmd1.Parameters.Add(p1);
            try
            {
                ManipulationBD.ConnectionDataBase();
                cmd1.ExecuteNonQuery();
                cmd1.Parameters.Clear();
                MessageBox.Show("Suppression effectuez");
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
            ManipulationBD.ConnectionDataBase();

            listView1.Items.Clear();

            MySqlCommand cmd = new MySqlCommand(" Select * from tarification", ManipulationBD.Cnn);
            using (MySqlDataReader read = cmd.ExecuteReader())
            {
                while(read.Read())
                {
                    string ID = read["Id_tarif"].ToString();
                    string Cat = read["categorie"].ToString();
                    string TC = read["tarif_chauff"].ToString();
                    string TL = read["tarif_loc_jr"].ToString();
                    string TH = read["tarif_loc_jr"].ToString();
                    string TKm = read["tarif_km_parc"].ToString();
                    string DT = read["date_tarif"].ToString();

                    listView1.Items.Add(new ListViewItem(new[] { ID, Cat, TC,TL, TH, TKm, DT }));
                }
            }

            ManipulationBD.DecoonectionDataBase();
        }
    }
}
