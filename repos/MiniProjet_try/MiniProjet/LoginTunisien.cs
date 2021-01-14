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
    public partial class LoginTunisien : Form
    {
        Connexion Link;
        Societé Log;

        public LoginTunisien()
        {
            InitializeComponent();
        }

        //private void LoginTunisien_Load(object sender, EventArgs e)
        //{
        //    this.Opacity = 0.1;
        //    Tunisien_timer.Start();

        //}

        //private void Tunisien_timer_Tick(object sender, EventArgs e)
        //{
        //    if( this.Opacity <= 0.1)
        //    {
        //        this.Opacity += 0.025;
        //    }else
        //    {
        //        Tunisien_timer.Stop();
        //    }
        //}
        

        private void button3_Click(object sender, EventArgs e)
        {
            LoginEtranger etranger = new LoginEtranger();
            etranger.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginTunisien tunisien = new LoginTunisien();
            tunisien.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tunisien tunisien = new Tunisien();
            tunisien.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Link.Connected)
            {
                if(textBox1.Text == "@UserNameT" && textBox2.Text == "@PwdT")
                {
                    Log = new Societé();
                    Log.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show(" Données incorrectes !! ");
                }
            }else
            {
                MessageBox.Show(" Vous n'etes pas connectez !!  ");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
