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

namespace Miniprojet.Agent.Client
{
    public partial class Ajouter : Form
    {
        Agent agent = new Agent();

        public Ajouter()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            this.Hide();
            a.Show();
        }

        private void Reset()
        {
            Cd_client.BackColor = Color.White;
            Cin.BackColor = Color.White;
            Nom.BackColor = Color.White;
            Tel.BackColor = Color.White;
            Nat.BackColor = Color.White;
            Adr_client.BackColor = Color.White;
            Prenom.BackColor = Color.White;
            P_Org.BackColor = Color.White;
            NumPass.BackColor = Color.White;
            R_soc.BackColor = Color.White;
            Cd_fisc.BackColor = Color.White;

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            Cd_client.Enabled = true;
            Adr_client.Enabled = true;
            Tel.Enabled = true;
            Cin.Enabled = true;
            Nom.Enabled = true;
            Prenom.Enabled = true;

            NumPass.Enabled = false;
            NumPass.BackColor = Color.Red;
            Nat.Enabled = true;
            Nat.BackColor = Color.Red;
            P_Org.Enabled = false;
            P_Org.BackColor = Color.Red;
            R_soc.Enabled = false;
            R_soc.BackColor = Color.Red;
            Cd_fisc.Enabled = false;
            Cd_fisc.BackColor = Color.Red;

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            RadioButton rb = null;

            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                rb = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                if (rb.Checked)
                    break;
            }

            if (rb.Text == "Tunisien")
            {
                Reset();
                Cd_client.Enabled = true;
                Cd_client.BackColor = Color.WhiteSmoke;
                Adr_client.Enabled = true;
                Adr_client.BackColor = Color.WhiteSmoke;
                Tel.Enabled = true;
                Tel.BackColor = Color.WhiteSmoke;
                Cin.Enabled = true;
                Cin.BackColor = Color.WhiteSmoke;
                Nom.Enabled = true;
                Nom.BackColor = Color.WhiteSmoke;
                Prenom.Enabled = true;
                Prenom.BackColor = Color.WhiteSmoke;

                NumPass.Enabled = false;
                NumPass.BackColor = Color.Red;
                Nat.Enabled = false;
                Nat.BackColor = Color.Red;
                P_Org.Enabled = false;
                P_Org.BackColor = Color.Red;
                R_soc.Enabled = false;
                R_soc.BackColor = Color.Red;
                Cd_fisc.Enabled = false;
                Cd_fisc.BackColor = Color.Red;
            }
            else if (rb.Text == "Etranger")
            {
                Reset();
                Cd_client.Enabled = true;
                Cd_client.BackColor = Color.WhiteSmoke;
                Adr_client.Enabled = true;
                Adr_client.BackColor = Color.WhiteSmoke;
                Tel.Enabled = true;
                Tel.BackColor = Color.WhiteSmoke;
                Nat.Enabled = true;
                Nat.BackColor = Color.WhiteSmoke;
                Nom.Enabled = true;
                Nom.BackColor = Color.WhiteSmoke;
                Prenom.Enabled = true;
                Prenom.BackColor = Color.WhiteSmoke;
                NumPass.Enabled = true;
                NumPass.BackColor = Color.WhiteSmoke;
                P_Org.Enabled = true;
                P_Org.BackColor = Color.WhiteSmoke;

                Cin.Enabled = false;
                Cin.BackColor = Color.Red;
                R_soc.Enabled = false;
                R_soc.BackColor = Color.Red;
                Cd_fisc.Enabled = false;
                Cd_fisc.BackColor = Color.Red;
            }
            else 
            {
                Reset();
                Cd_client.Enabled = true;
                Cd_client.BackColor = Color.WhiteSmoke;
                Adr_client.Enabled = true;
                Adr_client.BackColor = Color.WhiteSmoke;
                Tel.Enabled = true;
                P_Org.BackColor = Color.WhiteSmoke;
                R_soc.Enabled = true;
                R_soc.BackColor = Color.WhiteSmoke;
                Cd_fisc.Enabled = true;
                Cd_fisc.BackColor = Color.WhiteSmoke;

                Cin.Enabled = false;
                Cin.BackColor = Color.Red;
                Nom.Enabled = false;
                Nom.BackColor = Color.Red;
                Prenom.Enabled = false;
                Prenom.BackColor = Color.Red;
                NumPass.Enabled = false;
                NumPass.BackColor = Color.Red;
                P_Org.Enabled = false;
                P_Org.BackColor = Color.Red;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            Cd_client.Enabled = true;
            Cd_client.BackColor = Color.WhiteSmoke;
            Adr_client.Enabled = true;
            Adr_client.BackColor = Color.WhiteSmoke;
            Tel.Enabled = true;
            Tel.BackColor = Color.WhiteSmoke;
            Nat.Enabled = true;
            Nat.BackColor = Color.WhiteSmoke;
            Nom.Enabled = true;
            Nom.BackColor = Color.WhiteSmoke;
            Prenom.Enabled = true;
            Prenom.BackColor = Color.WhiteSmoke;
            NumPass.Enabled = true;
            NumPass.BackColor = Color.WhiteSmoke;
            P_Org.Enabled = true;
            P_Org.BackColor = Color.WhiteSmoke;

            Cin.Enabled = false;
            Cin.BackColor = Color.Red;
            R_soc.Enabled = false;
            R_soc.BackColor = Color.Red;
            Cd_fisc.Enabled = false;
            Cd_fisc.BackColor = Color.Red;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            Cd_client.Enabled = true;
            Cd_client.BackColor = Color.WhiteSmoke;
            Adr_client.Enabled = true;
            Adr_client.BackColor = Color.WhiteSmoke;
            Tel.Enabled = true;
            Tel.BackColor = Color.WhiteSmoke;
            R_soc.Enabled = true;
            R_soc.BackColor = Color.WhiteSmoke;
            Cd_fisc.Enabled = true;
            Cd_fisc.BackColor = Color.WhiteSmoke;

            Cin.Enabled = false;
            Cin.BackColor = Color.Red;
            Nom.Enabled = false;
            Nom.BackColor = Color.Red;
            Prenom.Enabled = false;
            Prenom.BackColor = Color.Red;
            Nat.Enabled = true;
            Nat.BackColor = Color.Red;
            NumPass.Enabled = false;
            NumPass.BackColor = Color.Red;
            P_Org.Enabled = false;
            P_Org.BackColor = Color.Red;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Agent.Acteur = Connection.Login.User_name;
            Agent.Operation = " a ajouter un nouveau client ";

            try
            {
                ManipulationBD.ConnectionDataBase();

                RadioButton rb = null;
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    rb = (RadioButton)groupBox1.Controls[i];    
                    if (rb.Checked)
                        break;
                }

                    string Tunisien = "insert into client values (@code_client,@adr_client,@tel_client,null,@cin,null,null,@nom,@prenom,null,null)";
                    string Etranger = "insert into client values (@code_client,@adr_client,@tel_client,@nationalite,null,@num_passport,@pays_org,@nom,@prenom,null,null)";
                    string Entreprise = "insert into client values (@code_client,@adr_client,@tel_client,null,null,null,null,null,null,@code_fisc,@rais_soc)";
                    string Historique = "insert into historique values(null, @Operation,@Acteur)";
                    string strverif = "select count(*) from client where Code_Client=?";

                    MySqlCommand cmd1 = new MySqlCommand(Tunisien, ManipulationBD.Cnn);
                    cmd1.Parameters.AddWithValue("@code_client", Cd_client.Text);
                    cmd1.Parameters.AddWithValue("@adr_client", Adr_client.Text); 
                    cmd1.Parameters.AddWithValue("@tel_client", Tel.Text);
                    cmd1.Parameters.AddWithValue("@cin", Cin.Text);
                    cmd1.Parameters.AddWithValue("@nom", Nom.Text);
                    cmd1.Parameters.AddWithValue("@prenom", Prenom.Text);

                    MySqlCommand cmd2 = new MySqlCommand(Etranger, ManipulationBD.Cnn);
                    cmd2.Parameters.AddWithValue("@code_client", Cd_client.Text);
                    cmd2.Parameters.AddWithValue("@adr_client", Adr_client.Text);
                    cmd2.Parameters.AddWithValue("@tel_client", Tel.Text);
                    cmd2.Parameters.AddWithValue("@nationalite", Nat.Text);
                    cmd2.Parameters.AddWithValue("@num_passport", NumPass.Text);
                    cmd2.Parameters.AddWithValue("@pays_org", P_Org.Text);
                    cmd2.Parameters.AddWithValue("@nom", Nom.Text);
                    cmd2.Parameters.AddWithValue("@prenom", Prenom.Text);

                    MySqlCommand cmd3 = new MySqlCommand(Entreprise, ManipulationBD.Cnn);
                    cmd3.Parameters.AddWithValue("@code_client", Cd_client.Text);
                    cmd3.Parameters.AddWithValue("@adr_client", Adr_client.Text);
                    cmd3.Parameters.AddWithValue("@tel_client", Tel.Text);
                    cmd3.Parameters.AddWithValue("@code_fisc", Cd_fisc.Text);
                    cmd3.Parameters.AddWithValue("@rais_soc", R_soc.Text);

                    MySqlCommand Cmd = new MySqlCommand(Historique, ManipulationBD.Cnn);
                Cmd.Parameters.AddWithValue("@Operation", (string)Agent.Operation);
                Cmd.Parameters.AddWithValue("@Acteur", (string)Agent.Acteur);

                    MySqlCommand verif = new MySqlCommand(strverif, ManipulationBD.Cnn);
                    MySqlParameter p16 = new MySqlParameter("p16", Cd_client.Text);
                    verif.Parameters.Add(p16);

                    long n = (long)verif.ExecuteScalar();

                    if (n == 0)
                    {

                        if (rb.Text == "Tunisien")
                        {
                            cmd1.ExecuteNonQuery();
                                Cmd.ExecuteNonQuery();
                                agent.Show();
                            this.Hide();
                        MessageBox.Show("Ajout effectuez");
                    }
                        else if (rb.Text == "Etranger")
                        {
                            cmd2.ExecuteNonQuery();
                                Cmd.ExecuteNonQuery();
                                   agent.Show();
                            this.Hide();
                        MessageBox.Show("Ajout effectuez");

                    }
                        else
                        {
                            cmd3.ExecuteNonQuery();
                                Cmd.ExecuteNonQuery();
                                    new Agent().Show();
                                this.Hide();
                            MessageBox.Show("Ajout effectuez");
                            

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ajout Impossible car Risque de Doublon");
                    }
                    
                    
            }
            catch(Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally
            {
                ManipulationBD.DecoonectionDataBase();
            }
        }

        //Events_OnClick

        private void TextBox1_Click(object sender, EventArgs e)
        {
            Cd_client.BackColor = Color.WhiteSmoke;
            Cd_client.BorderStyle = BorderStyle.Fixed3D;

        }

        private void TextBox5_Click(object sender, EventArgs e)
        {
            Adr_client.BackColor = Color.WhiteSmoke;
            Adr_client.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox4_Click(object sender, EventArgs e)
        {
            Tel.BackColor = Color.WhiteSmoke;
            Tel.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            Cin.BackColor = Color.WhiteSmoke;
            Cin.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            Nom.BackColor = Color.WhiteSmoke;
            Nom.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox6_Click(object sender, EventArgs e)
        {
            Prenom.BackColor = Color.WhiteSmoke;
            Prenom.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox8_Click(object sender, EventArgs e)
        {
            NumPass.BackColor = Color.WhiteSmoke;
            NumPass.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox7_Click(object sender, EventArgs e)
        {
            P_Org.BackColor = Color.WhiteSmoke;
            P_Org.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox10_Click(object sender, EventArgs e)
        {
            Cd_fisc.BackColor = Color.WhiteSmoke;
            Cd_fisc.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox9_Click(object sender, EventArgs e)
        {
            R_soc.BackColor = Color.WhiteSmoke;
            R_soc.BorderStyle = BorderStyle.Fixed3D;
        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            Adr_client.BackColor = Color.WhiteSmoke;
            Adr_client.BorderStyle = BorderStyle.Fixed3D;
        }

        //Events_MouseUp

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            Cd_client.BackColor = Color.WhiteSmoke;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Agent().Show();
        }
    }
}
