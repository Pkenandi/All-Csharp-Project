using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet
{
    public partial class LoginEntreprise : Form
    {
        Connexion Link;
        Societé Log;

        public LoginEntreprise()
        {
            InitializeComponent();
        }

        //private void LoginEntreprise_Load(object sender, EventArgs e)
        //{
        //    this.Opacity = 0.1;
        //    Entreprise_timer.Start();

        //}

        //private void Entreprise_timer_Tick(object sender, EventArgs e)
        //{
        //    if( this.Opacity <= 1.0)
        //    {
        //        this.Opacity += 0.025;

        //    }else
        //    {
        //        Entreprise_timer.Stop();
        //    }
        //}

          private void button2_Click(object sender, EventArgs e)
          {

                LoginEntreprise login = new LoginEntreprise();
                login.Show();
                this.Hide();

          }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginEtranger Etr = new LoginEtranger();
            Etr.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Entreprise entreprise = new Entreprise();
            entreprise.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Link.Connected)
            {
                if(textBox1.Text == "@UsernameE" && textBox2.Text == "@PasswordE")
                {
                    Log = new Societé();
                    Log.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show(" Données Invalides !! ");
                }

            }else
            {
                MessageBox.Show(" Vous etes Hors connexion !! ");
            }
        }
    }
}
