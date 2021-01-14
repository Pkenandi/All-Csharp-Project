using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniprojet.Administrateur
{
    public partial class Administrateur : Form
    {
        public Administrateur()
        {
            InitializeComponent();
        }

        private void ajouterCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compte.Ajouter f = new Compte.Ajouter();
            this.Hide();
            f.Show();
        }

        private void modifierCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compte.Modifier f = new Compte.Modifier();
            this.Hide();
            f.Show();
        }

        private void supprimerCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compte.Supprimer f = new Compte.Supprimer();
            this.Hide();
            f.Show();
        }

        private void gestionCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editerTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarif.Ajouter f = new Tarif.Ajouter();
            this.Hide();
            f.Show();
        }

        private void modifierTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarif.Modifier f = new Tarif.Modifier();
            this.Hide(); 
            f.Show();
        }

        private void supprimerTarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarif.Supprimer f = new Tarif.Supprimer();
            this.Hide();
            f.Show();
        }

        private void ajouterVehiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicule.Ajouter f = new Vehicule.Ajouter();
            this.Hide();
            f.Show();
        }

        private void modifierVehiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicule.Modifier f = new Vehicule.Modifier();
            this.Hide();
            f.Show();
        }

        private void supprimerVehiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicule.Supprimer f = new Vehicule.Supprimer();
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
