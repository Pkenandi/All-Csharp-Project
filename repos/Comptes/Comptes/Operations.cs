using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Comptes
{
    class Operations
    {
        public static MySqlCommand cmd;
        public static MySqlDataReader Lire;
        public static List<Client> AllClients = new List<Client>();
        static Compte C = new Compte();
        static Client Clt = new Client();
        static Agence Agt = new Agence();

        public static void CreationCompte()
        {
            Console.Write(" Numero du Compte : ");
            C.NumCompte = int.Parse(Console.ReadLine());
            Console.Write(" Numero du Client : ");
            C.NumClient = int.Parse(Console.ReadLine());
            Console.Write(" Numero de l'Agent : ");
            C.NumAgence = int.Parse(Console.ReadLine());
            Console.Write(" Solde : ");
            C.Solde = int.Parse(Console.ReadLine());

            cmd = new MySqlCommand(" Insert into compte values (@NumCompte,@NumClient,@NumAgent,@Solde)", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumCompte", C.NumCompte);
            cmd.Parameters.AddWithValue("@NumClient", C.NumClient);
            cmd.Parameters.AddWithValue("@NumAgent", C.NumAgence);
            cmd.Parameters.AddWithValue("@Solde", C.Solde);

            cmd.ExecuteNonQuery();
            Console.WriteLine(" Ajout Effectuer !! ");

        }

        public static void AjoutClient()
        {
            Console.Write(" Numero du Client : ");
            Clt.NumClient = int.Parse(Console.ReadLine());
            Console.Write(" Nom du Client : ");
            Clt.NomClient = Console.ReadLine();
            Console.Write(" Ville du Client : ");
            Clt.VilleClient = Console.ReadLine();
            Console.Write(" Date naissance : ");
            Clt.Date = DateTime.Parse(Console.ReadLine());

            cmd = new MySqlCommand(" Insert into client values (@NumClient,@NomClient,@Ville,@DatNaiss)", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumClient", Clt.NumClient);
            cmd.Parameters.AddWithValue("@NomClient", Clt.NomClient);
            cmd.Parameters.AddWithValue("@Ville", Clt.VilleClient);
            cmd.Parameters.AddWithValue("@DatNaiss", Clt.Date);

            cmd.ExecuteNonQuery();
            Console.WriteLine(" Ajout Effectuer !! ");

        }

        public static void AjoutAgence()
        {
            Console.Write(" Numero de l'Agence: ");
            Agt.NumAgence = int.Parse(Console.ReadLine());
            Console.Write(" Nom de l'agence : ");
            Agt.NomAgence = Console.ReadLine();
            Console.Write(" Ville de l'agence : ");
            Agt.VilleAgence = Console.ReadLine();

            cmd = new MySqlCommand(" Insert into agence values ( @NumAgence, @NomAgence,@VilleAgence)", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumAgence", Agt.NumAgence);
            cmd.Parameters.AddWithValue("@NomAgence", Agt.NomAgence);
            cmd.Parameters.AddWithValue("@VilleAgence", Agt.VilleAgence);

            cmd.ExecuteNonQuery();
            Console.WriteLine(" Ajout Effectuer !! ");

        }

        public static void ListNumAgents()
        {
            cmd = new MySqlCommand(" select (NumClient) from compte ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumClient", C.NumClient);

            using (Lire = cmd.ExecuteReader())
            {
                if (Lire != null)
                {
                    int ctr = 1;

                    while (Lire.Read())
                        {
                            Console.WriteLine(" Code client <"+ ctr + " > : " + Lire.GetDouble(0) );
                            ctr++;
                        }
                }else
                {
                    Console.WriteLine(" Zero client !");
                }
            }
        }

        public static void MoySoldeClient()
        {
            cmd = new MySqlCommand(" Select avg(Solde) as moySolde from compte C, client c where C.Numclient = c.NumClient having (moySolde) > 1000 ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@Solde", C.Solde);

            int Rep = Convert.ToInt32(cmd.ExecuteScalar());
            if(Rep != 0)
            {
                Console.WriteLine(" Le solde moyen des clients dont le solde > 2500 est : " + Rep);
            }else
            {
                Console.WriteLine(" Zero client !! ");
            }
        }

        public static void NbrClientVille()
        {
            cmd = new MySqlCommand(" Select count(*) from client where Ville = 'Kinshasa' ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@Ville", Clt.VilleClient);

            int Nbr = Convert.ToInt32(cmd.ExecuteScalar());
            if(Nbr > 0)
            {
                Console.WriteLine( " <" + Nbr + "> Client(s) habite(nt) à Kinshasa ");
            }else
            {
                Console.WriteLine(" Zero client !! ");
            }
        }

        public static void NbrClientZeroAdr()
        {
            cmd = new MySqlCommand(" Select count(*) from client where Ville = '' ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@Ville", Clt.VilleClient);

            int Nbr = Convert.ToInt32(cmd.ExecuteScalar());

            if(Nbr > 0)
            {
                Console.WriteLine(" <" + Nbr + "> clients ne possedent pas d'adresse (ville) ");
            }else
            {
                Console.WriteLine(" Tout les clients possedent une adresse (ville) ");
            }
        }

        public static void MajCompte()
        {
            cmd = new MySqlCommand("Update compte set Solde = Solde + (50) where NumAgence = @NumAgence ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@Solde", C.Solde);
            cmd.Parameters.AddWithValue("@NumAgence", 005);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Mise a jour effectuée !! ");

        }

        public static void TotalCompte()
        {
            cmd = new MySqlCommand(" Select count(*)  from compte group by (NumClient) having(count(*)) > 1 order by NumClient desc  ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumClient", C.NumClient);

            Lire = cmd.ExecuteReader();

            while(Lire.Read())
            {
                Console.WriteLine(Lire.GetDouble(0));
            }

            Lire.Close();

        }

        public static void SuppCompteVide()
        {
            cmd = new MySqlCommand(" select count(*) from compte where Solde = 0", Connexion.Connect);
            cmd.Parameters.AddWithValue("@Solde", C.Solde);

            int nbr = Convert.ToInt32(cmd.ExecuteScalar());

            if (nbr > 0)
            {
                cmd = new MySqlCommand(" Delete from compte where Solde = 0", Connexion.Connect);
                cmd.Parameters.AddWithValue("@Solde", C.Solde);

                cmd.ExecuteNonQuery();

                Console.WriteLine(" Suppression effectuée !! ");
            }
            else
                Console.WriteLine(" Tout les comptes possedent un solde > 0");
        }

        public static void TotalCompteClientX()
        {
            cmd = new MySqlCommand(" Select count(*) from compte where NumClient = NumAgence", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumClient", C.NumClient);
            cmd.Parameters.AddWithValue("@NumAgence", C.NumAgence);

            int Nbr = Convert.ToInt32(cmd.ExecuteScalar());

            if (Nbr > 0)
            {
                Console.WriteLine(" Il  y a <" + Nbr + "> client(s) dans l'agence N°2 ");
            }
            else
                Console.WriteLine(" Zero client ");
        }

        public static void MoisNaiss()
        {
            try
            {
                
                cmd = new MySqlCommand(" Select NumClient,NomClient,Ville,DatNaiss, trim(Ville) as ville_trim from  client where month(DatNaiss) = @DatNaiss and right(NomClient, 3) = 'ssi' ", Connexion.Connect);
                cmd.Parameters.AddWithValue("@DatNaiss", 5); 
                
                Lire = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(Lire);
                foreach(DataRow row in dataTable.Rows)
                {
                    AllClients.Add(
                        new Client(
                            int.Parse(row["NumClient"].ToString()), 
                            row["NomClient"].ToString(), 
                            row["Ville"].ToString(), 
                            DateTime.Parse(row["DatNaiss"].ToString())
                            )
                       );
                }   

                foreach(Client currentClient in AllClients)
                {
                    Console.WriteLine(currentClient.toString());
                }

                Lire.Close();

            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public static void PlusEtMoinAgé()
        {
            cmd = new MySqlCommand("SELECT NumClient,NomClient,Ville,DatNaiss, max(DatNaiss)  FROM client ", Connexion.Connect);
            Lire = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(Lire);
            foreach (DataRow row in dataTable.Rows)
            {
                AllClients.Add(
                    new Client(
                        int.Parse(row["NumClient"].ToString()),
                        row["NomClient"].ToString(),
                        row["Ville"].ToString(),
                        DateTime.Parse(row["DatNaiss"].ToString())
                        )
                   ); break;
            }

            foreach (Client currentClient in AllClients)
            {
                Console.WriteLine(currentClient.toString());
            }


        }
    }
}
