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
    public partial class Modifier : Form
    {
        Agent agent = new Agent();

        public Modifier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            this.Hide();
            a.Show();
        }

        private void Reset()
        {
            cd_client.BackColor = Color.White;
            cin.BackColor = Color.White;
            Nom.BackColor = Color.White;
            Tel.BackColor = Color.White;
            adr_client.BackColor = Color.White;
            Prenom.BackColor = Color.White;
            P_org.BackColor = Color.White;
            numPass.BackColor = Color.White;
            R_soc.BackColor = Color.White;
            Cd_fisc.BackColor = Color.White;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            cd_client.Enabled = true;
            adr_client.Enabled = true;
            Tel.Enabled = true;
            cin.Enabled = true;
            Nom.Enabled = true;
            Prenom.Enabled = true;

            numPass.Enabled = false;
            numPass.BackColor = Color.Red;
            P_org.Enabled = false;
            P_org.BackColor = Color.Red;
            R_soc.Enabled = false;
            R_soc.BackColor = Color.Red;
            Cd_fisc.Enabled = false;
            Cd_fisc.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            cd_client.Enabled = true;
            adr_client.Enabled = true;
            Tel.Enabled = true;
            Nom.Enabled = true;
            Prenom.Enabled = true;
            numPass.Enabled = true;
            P_org.Enabled = true;

            cin.Enabled = false;
            cin.BackColor = Color.Red;
            R_soc.Enabled = false;
            R_soc.BackColor = Color.Red;
            Cd_fisc.Enabled = false;
            Cd_fisc.BackColor = Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            cd_client.Enabled = true;
            adr_client.Enabled = true;
            Tel.Enabled = true;
            R_soc.Enabled = true;
            Cd_fisc.Enabled = true;

            cin.Enabled = false;
            cin.BackColor = Color.Red;
            Nom.Enabled = false;
            Nom.BackColor = Color.Red;
            Prenom.Enabled = false;
            Prenom.BackColor = Color.Red;
            numPass.Enabled = false;
            numPass.BackColor = Color.Red;
            P_org.Enabled = false;
            P_org.BackColor = Color.Red;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                cd_client.Enabled = true;
                adr_client.Enabled = true;
                Tel.Enabled = true;
                cin.Enabled = true;
                Nom.Enabled = true;
                Prenom.Enabled = true;

                numPass.Enabled = false;
                numPass.BackColor = Color.Red;
                P_org.Enabled = false;
                P_org.BackColor = Color.Red;
                R_soc.Enabled = false;
                R_soc.BackColor = Color.Red;
                Cd_fisc.Enabled = false;
                Cd_fisc.BackColor = Color.Red;
            }
            else if (rb.Text == "Etranger")
            {
                Reset();
                cd_client.Enabled = true;
                adr_client.Enabled = true;
                Tel.Enabled = true;
                Nom.Enabled = true;
                Prenom.Enabled = true;
                numPass.Enabled = true;
                P_org.Enabled = true;

                cin.Enabled = false;
                cin.BackColor = Color.Red;
                R_soc.Enabled = false;
                R_soc.BackColor = Color.Red;
                Cd_fisc.Enabled = false;
                Cd_fisc.BackColor = Color.Red;
            }
            else
            {
                Reset();
                cd_client.Enabled = true;
                adr_client.Enabled = true;
                Tel.Enabled = true;
                R_soc.Enabled = true;
                Cd_fisc.Enabled = true;

                cin.Enabled = false;
                cin.BackColor = Color.Red;
                Nom.Enabled = false;
                Nom.BackColor = Color.Red;
                Prenom.Enabled = false;
                Prenom.BackColor = Color.Red;
                numPass.Enabled = false;
                numPass.BackColor = Color.Red;
                P_org.Enabled = false;
                P_org.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulationBD.ConnectionDataBase();

                RadioButton rb = null;
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    rb = (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                    if (rb.Checked)
                        break;
                }

                string Tunisien = "update client set code_client = ?, adr_client=?, tel_client=?, cin=?, nom=?, prenom=? where code_client=?";
                string Etranger = "update client set code_client=?,adr_client=?,tel_client=?,nationalite=? , num_passport=?, pays_org=?, nom=?, prenom=? where Code_Client =?";
                string Entreprise = "update client set code_client=?,adr_client=?,tel_client=?,code_fisc=?,rais_soc=? where code_client =?";
               

                MySqlCommand cmd1 = new MySqlCommand(Tunisien, ManipulationBD.Cnn);
                MySqlParameter p1 = new MySqlParameter("p1", cd_client.Text);
                cmd1.Parameters.Add(p1);
                MySqlParameter p2 = new MySqlParameter("p2", adr_client.Text);
                cmd1.Parameters.Add(p2);
                MySqlParameter p3 = new MySqlParameter("p3", Tel.Text);
                cmd1.Parameters.Add(p3);
                MySqlParameter p4 = new MySqlParameter("p4", cin.Text);
                cmd1.Parameters.Add(p4);
                MySqlParameter p5 = new MySqlParameter("p5", Nom.Text);
                cmd1.Parameters.Add(p5);
                MySqlParameter p6 = new MySqlParameter("p6", Prenom.Text);
                cmd1.Parameters.Add(p6);
                MySqlParameter par1 = new MySqlParameter("par1", Cd_mod.Text);
                cmd1.Parameters.Add(par1);


                MySqlCommand cmd2 = new MySqlCommand(Etranger, ManipulationBD.Cnn);
                MySqlParameter e1 = new MySqlParameter("e1", cd_client.Text);
                cmd2.Parameters.Add(e1);
                MySqlParameter e2 = new MySqlParameter("e2", adr_client.Text);
                cmd2.Parameters.Add(e2);
                MySqlParameter e3 = new MySqlParameter("e3", Tel.Text);
                cmd2.Parameters.Add(e3);
                MySqlParameter e4 = new MySqlParameter("e4", Nat.Text);
                cmd2.Parameters.Add(e4);
                MySqlParameter e5 = new MySqlParameter("e5", numPass.Text);
                cmd2.Parameters.Add(e5);
                MySqlParameter e6 = new MySqlParameter("e6", P_org.Text);
                cmd2.Parameters.Add(e6);
                MySqlParameter e7 = new MySqlParameter("e7", Nom.Text);
                cmd2.Parameters.Add(e7);
                MySqlParameter e8 = new MySqlParameter("e8", Prenom.Text);
                cmd2.Parameters.Add(e8);
                MySqlParameter par2 = new MySqlParameter("par2", Cd_mod.Text);
                cmd2.Parameters.Add(par2);

                MySqlCommand cmd3 = new MySqlCommand(Entreprise, ManipulationBD.Cnn);
                MySqlParameter p8 = new MySqlParameter("p8", cd_client.Text);
                cmd3.Parameters.Add(p8);
                MySqlParameter p9 = new MySqlParameter("p9", adr_client.Text);
                cmd3.Parameters.Add(p9);
                MySqlParameter p10 = new MySqlParameter("p10",Tel.Text);
                cmd3.Parameters.Add(p10);
                MySqlParameter p11 = new MySqlParameter("p11", Cd_fisc.Text);
                cmd3.Parameters.Add(p11);
                MySqlParameter p12 = new MySqlParameter("p12", R_soc.Text);
                cmd3.Parameters.Add(p12);
                MySqlParameter par3 = new MySqlParameter("par3", Cd_mod.Text);
                cmd3.Parameters.Add(par3);


                //cmd1.ExecuteNonQuery();
                //MessageBox.Show("Modification effectuez");

                if (rb.Text == "Tunisien")
                     {
                         cmd1.ExecuteNonQuery();
                         MessageBox.Show("Modification effectuez");
                     }
                else if (rb.Text == "Etranger")
                     {
                            cmd2.ExecuteNonQuery();
                            agent.Show();
                            this.Hide();
                            MessageBox.Show("Modification effectuez");
                     }
                else
                     {
                            cmd3.ExecuteNonQuery();
                            agent.Show();
                            this.Hide();
                            MessageBox.Show("Modification effectuez");
                     }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally
            {
                ManipulationBD.DecoonectionDataBase();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulationBD.ConnectionDataBase();

                RadioButton rb = null;
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    rb= (RadioButton)groupBox1.Controls[i];    // On sort dès qu'on trouve le bouton sélectionné
                    if (rb.Checked)
                        break;
                }

                string Client = "select * from client where code_client = ?";
                string Tunisien = "select * from client where code_client=?";
                string Etranger = "select * from client where code_client=?";
                string Entreprise = "select * from client where code_client=?";

                MySqlCommand client = new MySqlCommand(Client, ManipulationBD.Cnn);
                MySqlParameter par = new MySqlParameter("par", cd_client.Text);
                client.Parameters.Add(par);

                MySqlCommand tunisien = new MySqlCommand(Tunisien, ManipulationBD.Cnn);
                MySqlParameter pmt1 = new MySqlParameter("pmt1", cd_client.Text);
                tunisien.Parameters.Add(pmt1);


                MySqlCommand etranger = new MySqlCommand(Etranger, ManipulationBD.Cnn);
                MySqlParameter pmt2 = new MySqlParameter("pmt2", cd_client.Text);
                etranger.Parameters.Add(pmt2);

                MySqlCommand entreprise = new MySqlCommand(Entreprise, ManipulationBD.Cnn);
                MySqlParameter pmt3 = new MySqlParameter("pmt3", cd_client.Text);
                etranger.Parameters.Add(pmt3);

                MySqlDataReader dr = client.ExecuteReader();
                if (dr != null)
                {
                    /*while (dr.Read())
                    {
                        // textBox1.Text = ((int)dr[0]).ToString();
                        textBox1.Text = dr.GetInt32(0).ToString();
                        textBox5.Text = (string)dr[1];
                        textBox4.Text = dr.GetInt32(2).ToString();
                    }
                    dr.Close();*/

                    if (rb.Text == "Tunisien")
                    {
                        while (dr.Read())
                        {
                            cd_client.Text = dr.GetInt32(0).ToString();
                            adr_client.Text = (string)dr[1];
                            Tel.Text = dr.GetInt32(2).ToString();
                           
                        }
                        dr.Close();

                        MySqlDataReader dr1 = tunisien.ExecuteReader();

                        if (dr1 != null)
                        {
                            while (dr1.Read())
                            {
                                cin.Text = ((int)dr[4]).ToString();
                                Nom.Text = (string)dr1[7];
                                Prenom.Text = (string)dr1[8];
                            }
                            dr1.Close();
                        }
                        
                    }
                    else if (rb.Text == "Etranger")
                    {
                        while (dr.Read())
                        {
                            cd_client.Text = dr.GetInt32(0).ToString();
                            adr_client.Text = (string)dr[1];
                            Tel.Text = (string)dr[2];

                        }
                        dr.Close();

                        MySqlDataReader dr1 = etranger.ExecuteReader();
                        if (dr1 != null)
                        {
                            while (dr1.Read())
                            {
                                Nat.Text = (string)dr1[3];
                                numPass.Text = (string)dr[5];
                                P_org.Text = (string)dr1[6];
                                Nom.Text = (string)dr1[7];
                                Prenom.Text = (string)dr1[8];
                            
                            }
                            dr1.Close();
                        }
                    }
                    else
                    {
                        while (dr.Read())
                        {

                            cd_client.Text = dr.GetInt32(0).ToString();
                            adr_client.Text = (string)dr[1];
                            Tel.Text = dr.GetInt32(2).ToString();

                        }
                        dr.Close();

                        MySqlDataReader dr1 = entreprise.ExecuteReader();
                        if (dr1 != null)
                        {
                            while (dr1.Read())
                            {
                                R_soc.Text = ((int)dr1[9]).ToString();
                                Cd_fisc.Text = (string)dr1[10];
                            }
                            dr1.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Modification Impossible car Il n'existe pas !");
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
    }
}
