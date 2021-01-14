namespace Miniprojet.Agent
{
    partial class Agent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerHhhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesContratsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnContratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnContratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnContratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnContratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 37);
            this.panel1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(534, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU DE GESTION AGENT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerHhhToolStripMenuItem,
            this.gererLesFacturesToolStripMenuItem,
            this.gererLesContratsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(54, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 27);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerHhhToolStripMenuItem
            // 
            this.gérerHhhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierUnClientToolStripMenuItem,
            this.supprimerUnClientToolStripMenuItem,
            this.rechercherUnClientToolStripMenuItem});
            this.gérerHhhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gérerHhhToolStripMenuItem.Name = "gérerHhhToolStripMenuItem";
            this.gérerHhhToolStripMenuItem.Size = new System.Drawing.Size(107, 23);
            this.gérerHhhToolStripMenuItem.Text = "Gestion Client";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter un client";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierUnClientToolStripMenuItem
            // 
            this.modifierUnClientToolStripMenuItem.Name = "modifierUnClientToolStripMenuItem";
            this.modifierUnClientToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.modifierUnClientToolStripMenuItem.Text = "Modifier un client";
            this.modifierUnClientToolStripMenuItem.Click += new System.EventHandler(this.modifierUnClientToolStripMenuItem_Click);
            // 
            // supprimerUnClientToolStripMenuItem
            // 
            this.supprimerUnClientToolStripMenuItem.Name = "supprimerUnClientToolStripMenuItem";
            this.supprimerUnClientToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.supprimerUnClientToolStripMenuItem.Text = "Supprimer un client";
            this.supprimerUnClientToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnClientToolStripMenuItem_Click);
            // 
            // rechercherUnClientToolStripMenuItem
            // 
            this.rechercherUnClientToolStripMenuItem.Name = "rechercherUnClientToolStripMenuItem";
            this.rechercherUnClientToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.rechercherUnClientToolStripMenuItem.Text = "Rechercher un client";
            // 
            // gererLesFacturesToolStripMenuItem
            // 
            this.gererLesFacturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneFactureToolStripMenuItem,
            this.modifierUneFactureToolStripMenuItem,
            this.supprimerUneFactureToolStripMenuItem,
            this.rechercherUneFactureToolStripMenuItem});
            this.gererLesFacturesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gererLesFacturesToolStripMenuItem.Name = "gererLesFacturesToolStripMenuItem";
            this.gererLesFacturesToolStripMenuItem.Size = new System.Drawing.Size(117, 23);
            this.gererLesFacturesToolStripMenuItem.Text = "Gestion Facture";
            // 
            // ajouterUneFactureToolStripMenuItem
            // 
            this.ajouterUneFactureToolStripMenuItem.Name = "ajouterUneFactureToolStripMenuItem";
            this.ajouterUneFactureToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.ajouterUneFactureToolStripMenuItem.Text = "Ajouter une facture";
            this.ajouterUneFactureToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneFactureToolStripMenuItem_Click);
            // 
            // modifierUneFactureToolStripMenuItem
            // 
            this.modifierUneFactureToolStripMenuItem.Name = "modifierUneFactureToolStripMenuItem";
            this.modifierUneFactureToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.modifierUneFactureToolStripMenuItem.Text = "Modifier une facture";
            this.modifierUneFactureToolStripMenuItem.Click += new System.EventHandler(this.modifierUneFactureToolStripMenuItem_Click);
            // 
            // supprimerUneFactureToolStripMenuItem
            // 
            this.supprimerUneFactureToolStripMenuItem.Name = "supprimerUneFactureToolStripMenuItem";
            this.supprimerUneFactureToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.supprimerUneFactureToolStripMenuItem.Text = "Supprimer une facture";
            this.supprimerUneFactureToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneFactureToolStripMenuItem_Click);
            // 
            // rechercherUneFactureToolStripMenuItem
            // 
            this.rechercherUneFactureToolStripMenuItem.Name = "rechercherUneFactureToolStripMenuItem";
            this.rechercherUneFactureToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.rechercherUneFactureToolStripMenuItem.Text = "Rechercher une facture";
            // 
            // gererLesContratsToolStripMenuItem
            // 
            this.gererLesContratsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnContratToolStripMenuItem,
            this.modifierUnContratToolStripMenuItem,
            this.supprimerUnContratToolStripMenuItem,
            this.rechercherUnContratToolStripMenuItem});
            this.gererLesContratsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gererLesContratsToolStripMenuItem.Name = "gererLesContratsToolStripMenuItem";
            this.gererLesContratsToolStripMenuItem.Size = new System.Drawing.Size(119, 23);
            this.gererLesContratsToolStripMenuItem.Text = "Gestion Contrat";
            // 
            // ajouterUnContratToolStripMenuItem
            // 
            this.ajouterUnContratToolStripMenuItem.Name = "ajouterUnContratToolStripMenuItem";
            this.ajouterUnContratToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.ajouterUnContratToolStripMenuItem.Text = "Ajouter un contrat";
            this.ajouterUnContratToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnContratToolStripMenuItem_Click);
            // 
            // modifierUnContratToolStripMenuItem
            // 
            this.modifierUnContratToolStripMenuItem.Name = "modifierUnContratToolStripMenuItem";
            this.modifierUnContratToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.modifierUnContratToolStripMenuItem.Text = "Modifier un contrat";
            this.modifierUnContratToolStripMenuItem.Click += new System.EventHandler(this.modifierUnContratToolStripMenuItem_Click);
            // 
            // supprimerUnContratToolStripMenuItem
            // 
            this.supprimerUnContratToolStripMenuItem.Name = "supprimerUnContratToolStripMenuItem";
            this.supprimerUnContratToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.supprimerUnContratToolStripMenuItem.Text = "Supprimer un contrat";
            this.supprimerUnContratToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnContratToolStripMenuItem_Click);
            // 
            // rechercherUnContratToolStripMenuItem
            // 
            this.rechercherUnContratToolStripMenuItem.Name = "rechercherUnContratToolStripMenuItem";
            this.rechercherUnContratToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.rechercherUnContratToolStripMenuItem.Text = "Rechercher un contrat";
            // 
            // Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 413);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Agent";
            this.Text = "Agent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerHhhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererLesContratsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnContratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnContratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnContratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnContratToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}