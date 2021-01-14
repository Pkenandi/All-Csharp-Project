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
    public partial class LoginEtranger : Form
    {
        Connexion Link;
        Societé Log;

        public LoginEtranger()
        {
            InitializeComponent();
        }


        //private void LoginEtranger_Load(object sender, EventArgs e)
        //{
        //    this.Opacity = 0.1;
        //    Etranger_timer.Start();

        //}

        //private void Etranger_timer_Tick(object sender, EventArgs e)
        //{
        //    if(this.Opacity <= 0.1)
        //    {
        //        this.Opacity += 0.025;
        //    }else
        //    {
        //        Etranger_timer.Stop();
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            LoginEntreprise Ent = new LoginEntreprise();
            Ent.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginTunisien Tn = new LoginTunisien();
            Tn.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Entreprise Entr = new Entreprise();
            Entr.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Link.Connected)
            {
                if (textBox1.Text == "@UserNameE" && textBox2.Text == "@Pwd")
                {
                    Log = new Societé();
                    Log.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(" Données invalides !! ");
                }

            }
            else
            {
                MessageBox.Show(" Vous n'etes pas connectez !! ");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.ForeColor = Color.WhiteSmoke;
            panel3.ForeColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            panel1.ForeColor = Color.WhiteSmoke;

            textBox1.ForeColor = Color.WhiteSmoke;
            panel3.ForeColor = Color.WhiteSmoke;

        }
    }
}
