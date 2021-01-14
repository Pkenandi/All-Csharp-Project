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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrateur a = new Administrateur();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton rb1 = null;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                rb1 = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb1.Checked)
                    break;
            }

            string Insertion1 = "insert into tarification values ('" + numtarif.Text + "',' " + rb1.Text + " ' ,' " + T_chauff.Text + " ','" + T_Loc.Text + "','" + T_heure.Text + "','" + T_km.Text + "','" + Date_T.Text + "')";
            MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
            try
            {
                ManipulationBD.ConnectionDataBase();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout effectuez");
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
            this.Hide();
            new Administrateur().Show();
        }
    }
}
