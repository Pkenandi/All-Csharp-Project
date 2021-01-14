namespace Miniprojet.Agent.Client
{
    partial class Ajouter
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Adr_client = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Cin = new System.Windows.Forms.TextBox();
            this.Cd_client = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.P_Org = new System.Windows.Forms.TextBox();
            this.NumPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.R_soc = new System.Windows.Forms.TextBox();
            this.Cd_fisc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Nat = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(176, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ajouter un Client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 32);
            this.panel1.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton3);
            this.groupBox1.Controls.Add(this.RadioButton2);
            this.groupBox1.Controls.Add(this.RadioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(119, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 40);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type client";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(167, 14);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(83, 21);
            this.RadioButton3.TabIndex = 13;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Entreprise";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(94, 14);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(74, 21);
            this.RadioButton2.TabIndex = 13;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Etranger";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(23, 14);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(72, 21);
            this.RadioButton1.TabIndex = 12;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Tunisien";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(193, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(61, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Confirmer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(44, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Prenom Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(44, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nom Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(44, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "CIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(44, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Telphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(44, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Adresse Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Code Client";
            // 
            // Prenom
            // 
            this.Prenom.BackColor = System.Drawing.Color.White;
            this.Prenom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prenom.Location = new System.Drawing.Point(149, 301);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(238, 20);
            this.Prenom.TabIndex = 37;
            this.Prenom.Click += new System.EventHandler(this.TextBox6_Click);
            // 
            // Adr_client
            // 
            this.Adr_client.BackColor = System.Drawing.Color.White;
            this.Adr_client.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Adr_client.Location = new System.Drawing.Point(149, 129);
            this.Adr_client.Name = "Adr_client";
            this.Adr_client.Size = new System.Drawing.Size(238, 20);
            this.Adr_client.TabIndex = 36;
            this.Adr_client.Click += new System.EventHandler(this.TextBox5_Click);
            this.Adr_client.MouseHover += new System.EventHandler(this.textBox5_MouseHover);
            // 
            // Tel
            // 
            this.Tel.BackColor = System.Drawing.Color.White;
            this.Tel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tel.Location = new System.Drawing.Point(149, 167);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(238, 20);
            this.Tel.TabIndex = 35;
            this.Tel.Click += new System.EventHandler(this.TextBox4_Click);
            // 
            // Nom
            // 
            this.Nom.BackColor = System.Drawing.Color.White;
            this.Nom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nom.Location = new System.Drawing.Point(149, 262);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(238, 20);
            this.Nom.TabIndex = 34;
            this.Nom.Click += new System.EventHandler(this.TextBox3_Click);
            // 
            // Cin
            // 
            this.Cin.BackColor = System.Drawing.Color.White;
            this.Cin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cin.Location = new System.Drawing.Point(149, 203);
            this.Cin.Name = "Cin";
            this.Cin.Size = new System.Drawing.Size(238, 20);
            this.Cin.TabIndex = 33;
            this.Cin.Click += new System.EventHandler(this.TextBox2_Click);
            // 
            // Cd_client
            // 
            this.Cd_client.BackColor = System.Drawing.Color.White;
            this.Cd_client.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cd_client.Location = new System.Drawing.Point(149, 94);
            this.Cd_client.Name = "Cd_client";
            this.Cd_client.Size = new System.Drawing.Size(238, 20);
            this.Cd_client.TabIndex = 32;
            this.Cd_client.Click += new System.EventHandler(this.TextBox1_Click);
            this.Cd_client.MouseLeave += new System.EventHandler(this.TextBox1_MouseLeave);
            this.Cd_client.MouseHover += new System.EventHandler(this.TextBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(44, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Pays Origine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(37, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Numero Passport";
            // 
            // P_Org
            // 
            this.P_Org.BackColor = System.Drawing.Color.White;
            this.P_Org.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P_Org.Location = new System.Drawing.Point(149, 365);
            this.P_Org.Name = "P_Org";
            this.P_Org.Size = new System.Drawing.Size(238, 20);
            this.P_Org.TabIndex = 47;
            this.P_Org.Click += new System.EventHandler(this.TextBox7_Click);
            // 
            // NumPass
            // 
            this.NumPass.BackColor = System.Drawing.Color.White;
            this.NumPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NumPass.Location = new System.Drawing.Point(149, 331);
            this.NumPass.Name = "NumPass";
            this.NumPass.Size = new System.Drawing.Size(238, 20);
            this.NumPass.TabIndex = 46;
            this.NumPass.Click += new System.EventHandler(this.TextBox8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(44, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Raison Social";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(44, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Code Fiscale";
            // 
            // R_soc
            // 
            this.R_soc.BackColor = System.Drawing.Color.White;
            this.R_soc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.R_soc.Location = new System.Drawing.Point(149, 441);
            this.R_soc.Name = "R_soc";
            this.R_soc.Size = new System.Drawing.Size(238, 20);
            this.R_soc.TabIndex = 51;
            this.R_soc.Click += new System.EventHandler(this.TextBox9_Click);
            // 
            // Cd_fisc
            // 
            this.Cd_fisc.BackColor = System.Drawing.Color.White;
            this.Cd_fisc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cd_fisc.Location = new System.Drawing.Point(149, 406);
            this.Cd_fisc.Name = "Cd_fisc";
            this.Cd_fisc.Size = new System.Drawing.Size(238, 20);
            this.Cd_fisc.TabIndex = 50;
            this.Cd_fisc.Click += new System.EventHandler(this.TextBox10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(44, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Nationalite";
            // 
            // Nat
            // 
            this.Nat.BackColor = System.Drawing.Color.White;
            this.Nat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nat.Location = new System.Drawing.Point(149, 233);
            this.Nat.Name = "Nat";
            this.Nat.Size = new System.Drawing.Size(238, 20);
            this.Nat.TabIndex = 54;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(317, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 56;
            this.button3.Text = "Retour";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(494, 539);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Nat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.R_soc);
            this.Controls.Add(this.Cd_fisc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.P_Org);
            this.Controls.Add(this.NumPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Adr_client);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Cin);
            this.Controls.Add(this.Cd_client);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Ajouter";
            this.Text = "Ajouter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Adr_client;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Cin;
        private System.Windows.Forms.TextBox Cd_client;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox P_Org;
        private System.Windows.Forms.TextBox NumPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox R_soc;
        private System.Windows.Forms.TextBox Cd_fisc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Nat;
        private System.Windows.Forms.Button button3;
    }
}