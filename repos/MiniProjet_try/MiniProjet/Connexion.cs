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

namespace MiniProjet
{
    
    public partial class Connexion : Form
    {
        public MySqlConnection connexion;
            public MySqlCommand cmd;
        public bool Connected = false;

        Acceuil Log;

        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Se connecter")
            {
                connexion = new MySqlConnection("database=tchat; server=localhost; userID=root; pwd='' ");

                try
                {
                    if (connexion.State == ConnectionState.Closed)
                    {
                        connexion.Open();
                    }
                    button1.Text = " Se deconnecter ";
                    Connected = true;
                    Log = new Acceuil();
                    Log.Show();
                    this.Hide();
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                button1.Text = " Se connecter ";
                Connected = false;
                connexion.Close();

            }

            
        }
    }
}
