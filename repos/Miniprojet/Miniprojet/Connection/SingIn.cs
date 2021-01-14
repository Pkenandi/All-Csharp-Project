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


namespace Miniprojet.Connection
{
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }

        private void ConnectAdmin_Load(object sender, EventArgs e)
        {
            
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

                string Insertion = "insert into compte values (?,?,?,?,?,?,?)";

                MySqlCommand cmd = new MySqlCommand(Insertion, ManipulationBD.Cnn);

                MySqlParameter p1 = new MySqlParameter("id_cmp", Id.Text);
                cmd.Parameters.Add(p1);
                MySqlParameter p2 = new MySqlParameter("nom_cmp", nom.Text);
                cmd.Parameters.Add(p2);
                MySqlParameter p3 = new MySqlParameter("prenom", Prenom.Text);
                cmd.Parameters.Add(p3);
                MySqlParameter p5 = new MySqlParameter("tel_cmp", Tel.Text);
                cmd.Parameters.Add(p5);
                MySqlParameter p6 = new MySqlParameter("User_name", Username.Text);
                cmd.Parameters.Add(p6);
                MySqlParameter p7 = new MySqlParameter("Pwd", Pwd.Text);
                cmd.Parameters.Add(p7);
                MySqlParameter p4 = new MySqlParameter("type", rb.Text);
                cmd.Parameters.Add(p4);

                cmd.ExecuteNonQuery();

                if(rb.Text=="Administrateur")
                {
                    Administrateur.Administrateur a = new Administrateur.Administrateur();
                    this.Hide();
                    a.Show();
                }
                else
                {
                    Agent.Agent a = new Agent.Agent();
                    this.Hide();
                    a.Show();
                }
                //MessageBox.Show(rb.Text);
            }
            catch(Exception r)
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
