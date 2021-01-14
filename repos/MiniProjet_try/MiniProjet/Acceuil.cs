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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            LoginTunisien Tn = new LoginTunisien();
            Tn.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            LoginEtranger Etr = new LoginEtranger();
            Etr.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginEntreprise Ent = new LoginEntreprise();
            Ent.Show();
            this.Close();

        }

        
    }
}
