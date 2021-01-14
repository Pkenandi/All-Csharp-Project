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
            string Insertion1 = "delete from compte where Pwd=?";
            MySqlCommand cmd1 = new MySqlCommand(Insertion1, ManipulationBD.Cnn);
            MySqlParameter p1 = new MySqlParameter("Pwd", Pwd.Text);
            cmd1.Parameters.Add(p1);
            try
            {
                Administrateur admin = new Administrateur();
                ManipulationBD.ConnectionDataBase();
                cmd1.ExecuteNonQuery();
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

    }
}
