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
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Administrateur a = new Administrateur();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            RadioButton rb = null;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                rb = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb.Checked)
                    break;
            }
            string Insertion = "update compte set id_cmp='" + ID.Text + "',nom_cmp='" + Nom.Text + "',prenom_cmp='" + Prenom.Text + "',tel_cmp='" + Tel.Text + "',User_name='" + Username.Text + "',Pwd='" + Pwd.Text + "',type_cmp='" + rb.Text + "' " + "where Pwd='" + Pwd_modif.Text + "'";
            MySqlCommand cmd = new MySqlCommand(Insertion, ManipulationBD.Cnn);
            try
            {
                Administrateur admin = new Administrateur();

                ManipulationBD.ConnectionDataBase();
                cmd.ExecuteNonQuery();
                admin.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Administrateur().Show();
        }
    }
}
