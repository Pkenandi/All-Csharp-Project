using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniprojet.Acceuil
{
    public partial class Bienvenue : Form
    {
        public Bienvenue()
        {
            InitializeComponent();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            Connection.SingIn f = new Connection.SingIn(); 
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection.Login f = new Connection.Login();
            this.Hide();
            f.Show();
            
        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            Connection.SingIn f = new Connection.SingIn();
            this.Hide();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Connection.Login f = new Connection.Login();
            this.Hide();
            f.Show();
        }
    }
}
