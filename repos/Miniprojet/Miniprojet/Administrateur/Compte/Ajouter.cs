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

namespace Miniprojet.Administrateur.Compte
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulationBD.ConnectionDataBase();

                RadioButton rb = null;
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    rb = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                    if (rb.Checked)
                        break;
                }
                string Insertion = "insert into compte values ('" + Id.Text + "','" + Nom.Text + "','" + Prenom.Text + "','" + Tel.Text + "','" + UserName.Text + "','" + Pwd.Text + "','" + rb.Text + "')";
                MySqlCommand cmd = new MySqlCommand(Insertion, ManipulationBD.Cnn);

                cmd.ExecuteNonQuery();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Connection.Login().Show();
        }
    }
}
