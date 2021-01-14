using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connexion
{
    public partial class Modification : Form
    {
        public string id { set { textBox1.Text = value; } }
        public string Nom { get { return textBox2.Text; } set { textBox2.Text = value; } }
        public string Age { get { return textBox3.Text; } set { textBox3.Text = value; } }

        public Modification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
