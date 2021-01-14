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
    public partial class Societé : Form
    {
        public Societé()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel1.Height >= 114)
            {
                timer1.Enabled = false;
            }else
            {
                panel1.Height += 10;
            }
        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
            timer1.Enabled = true;

        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Height = 0;
        }
    }
}
