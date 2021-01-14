using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes
{
    class Compte
    {
        public int NumCompte { set; get; }
        public int NumClient { set; get; }
        public int NumAgence { set; get; }
        public int Solde { set; get; }

        public Compte()
        {

        }

    }

    class Client
    {
        public int NumClient { set; get; }
        public string NomClient { set; get; }
        public string VilleClient { set; get; }
        public DateTime Date { set; get; }

        public Client()
        {

        }

        public Client(int NumC, string NomC, string VilleC, DateTime Dt)
        {
            NumClient = NumC;
            NomClient = NomC;
            VilleClient = VilleC;
            Date = Dt;
        }

        public string toString()
        {
            return (" Num Client : " + NumClient + "| Nom Client : " + NomClient + "| Ville : " + VilleClient + "| Date naissance : " + Date );
        }
    }

    class Agence
    {
        public int NumAgence;
        public string NomAgence;
        public string VilleAgence;

        public Agence()
        {

        }

    }

}
