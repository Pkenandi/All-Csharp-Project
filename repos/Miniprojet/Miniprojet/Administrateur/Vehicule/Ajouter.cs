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

namespace Miniprojet.Administrateur.Vehicule
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrateur a = new Administrateur();
            this.Hide();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton rb1 = null;
            for (int i = 0; i < Cat.Controls.Count; i++)
            {
                rb1 = (RadioButton)Cat.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb1.Checked)
                    break;
            }

            RadioButton rb3 = null;
            for (int i = 0; i < Etat.Controls.Count; i++)
            {
                rb3 = (RadioButton)Etat.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb3.Checked)
                    break;
            }

            string Insertion1 = "insert into vehicule values ('" + NumCh.Text + "','" + rb1.Text + "','" + Marque.Text + "','" + NbrKm.Text + "','" + NbrHr.Text + "','" + rb3.Text + "')";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            RadioButton rb = null;
            for (int i = 0; i < Cat.Controls.Count; i++)
            {
                rb = (RadioButton)Cat.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb.Checked)
                    break;
            }
            if (rb.Text == "Voiture" || rb.Text == "Camion")
            {
                NbrHr.Enabled = false;

                NumCh.Enabled = true;
                Marque.Enabled = true;
                NbrKm.Enabled = true;
                radioButton4.Enabled = true;
                radioButton7.Enabled = true;
            }
            else
            {
                NbrKm.Enabled = false;

                NumCh.Enabled = true;
                Marque.Enabled = true;
                NbrHr.Enabled = true;
                radioButton4.Enabled = true;
                radioButton7.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            NbrHr.Enabled = false;

            NumCh.Enabled = true;
            Marque.Enabled = true;
            NbrKm.Enabled = true;
            radioButton4.Enabled = true;
            radioButton7.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            NbrHr.Enabled = false;

            NumCh.Enabled = true;
            Marque.Enabled = true;
            NbrKm.Enabled = true;
            radioButton4.Enabled = true;
            radioButton7.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            NbrKm.Enabled = false;

            NumCh.Enabled = true;
            Marque.Enabled = true;
            NbrHr.Enabled = true;
            radioButton4.Enabled = true;
            radioButton7.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Administrateur().Show();
        }
    }
}
