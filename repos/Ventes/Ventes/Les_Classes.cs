using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vente
{
    class Client
    {
        public int CodC { set; get; }
        public string NomC { set; get; }
        public float CreditC { set; get; }
        public string AdrC { set; get; }
        public float CA { set; get; }

        public Client(int C, string N, float Cr, string Adr, float ca)
        {
            CodC = C;
            NomC = N;
            CreditC = Cr;
            AdrC = Adr;
            CA = ca;
        }

        public Client()
        {

        }

    }

    class Produit
    {
        public int CodP;
        public string Lib;
        public float PU;
        public int Qtes;
        public string Seuil;

        public Produit()
        {

        }
    }

    class Commande
    {
        public int NumC;
        public string DatC;
        public float CodC;

        public Commande()
        {

        }
    }

    class Facture
    {
        public int NumF;
        public float monyF;
        public string DatF;
        public float CodC;

        public Facture()
        {

        }
    }

    class PC
    {
        public int CodP;
        public int NumC;
        public float Qtec;

        public PC()
        {

        }
    }
}
