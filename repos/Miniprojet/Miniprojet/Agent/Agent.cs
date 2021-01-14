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

namespace Miniprojet.Agent
{
    public partial class Agent : Form
    {
        public Agent()
        {
            InitializeComponent();
        }

        public static string Operation;
        public static string Acteur;

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client.Ajouter f = new Client.Ajouter();
            this.Hide();
            f.Show();
        }

        private void modifierUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client.Modifier f = new Client.Modifier();
            this.Hide();
            f.Show();
        }

        private void supprimerUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client.Supprimer f = new Client.Supprimer();
            this.Hide();
            f.Show();
        }

        private void ajouterUnContratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contrat.Ajouter f = new Contrat.Ajouter();
            this.Hide();
            f.Show();
        }

        private void modifierUnContratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contrat.Modifier f = new Contrat.Modifier();
            this.Hide();
            f.Show();
        }

        private void supprimerUnContratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contrat.Supprimer f = new Contrat.Supprimer();
            this.Hide();
            f.Show();
        }

        private void ajouterUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarification.Ajouter f = new Tarification.Ajouter();
            this.Hide();
            f.Show();
        }

        private void modifierUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarification.Modifier f = new Tarification.Modifier();
            this.Hide();
            f.Show();
        }

        private void supprimerUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarification.Supprimer f = new Tarification.Supprimer();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Connection.Login().Show();
        }
    }
}
