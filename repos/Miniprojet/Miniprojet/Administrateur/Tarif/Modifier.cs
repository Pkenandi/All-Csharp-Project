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
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrateur a = new Administrateur();
            this.Hide();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RadioButton rb1 = null;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                rb1 = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb1.Checked)
                    break;
            }

            string Insertion1 = "update tarification set Id_tarif = ' " + numtarif.Text + " ', categorie = ' " + rb1.Text + " ',tarif_chauff=' " + T_chauff.Text + "',tarif_loc_jr='" + T_Loc.Text + "',tarif_hr_trv='" + T_heure.Text + "',tarif_km_parc='" +T_km.Text + "',date_tarif='" + Date_T.Text + " ' " + "where Id_tarif='" + numTarif_modif.Text + "'";
            MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
            try
            {
                //Administrateur admin = new Administrateur();
                ManipulationBD.ConnectionDataBase();
                cmd1.ExecuteNonQuery();
                cmd1.Parameters.Clear();
                new Administrateur().Show();
                this.Hide();

                MessageBox.Show("Modification effectuez");
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