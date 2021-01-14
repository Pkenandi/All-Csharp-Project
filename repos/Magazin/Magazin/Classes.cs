using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    class Magazin
    {
        public int NumMag { set; get; }
        public string LocMag { set; get; }
        public string Gerant { set; get; }

        public Magazin()
            {

            }

        public Magazin(int N, string L )
        {
            NumMag = N;
            LocMag = L;
        }

        public Magazin(int N, string L, string G)
        {
            NumMag = N;
            LocMag = L;
            Gerant = G;
        }

        public string toString()
        {
            return "   " + NumMag + " | " + LocMag; 
        }
    }

    class Fournisseur
    {
        public int NumF { set; get; }
        public string NomF { set; get; }


        public Fournisseur()
        {

        }
    }

    class Article
    {
        public int NumA { set; get; }
        public string NomA { set; get; }
        public float Poids { set; get; }
        public string Couleur { set; get; }
        public float PrixAchat { set; get; }
        public float PrixVente { set; get; }
        public float FArticle { set; get; }
        public float MB { set; get; }

        public Article()
        {

        }

        public Article(int N, string Nom, float PA, float PV)
        {
            NumA = N;
            NomA = Nom;
            PrixAchat = PA;
            PrixVente = PV;

        }

        public Article(int N, string Nom, float PoidsA, string CouleurA)
        {
            NumA = N;
            NomA = Nom;
            Poids = PoidsA;
            Couleur = CouleurA;

        }

        public Article(int N, float PA, float PV, float MB)
        {
            NumA = N;
            PrixAchat = PA;
            PrixVente = PV;
            this.MB = MB;
        }

        public Article(int N, string Nom, float PA)
        {
            NumA = N;
            NomA = Nom;
            PrixAchat = PA;

        }

        public string toString()
        {
            return " Num :  " + NumA + " | Nom Article : " + NomA + " | Prix d'achat : " + PrixAchat + " | Prix de vente : " + PrixVente;
        }

        public string toString1()
        {
            return " Num :  " + NumA + " | Nom Article : " + NomA + " | Poids : " + Poids + " | Couleur : " + this.Couleur;
        }

        public string toString2()
        {
            return " Num :  " + NumA + " | Nom Article : " + NomA + " | Poids : " + Poids ;
        }

        public string toString3()
        {
            return " Num :  " + NumA + " | Nom Article : " + NomA + " | Prix d'achat : " + PrixAchat;
        }

        public string toString4()
        {
            return " Num :  " + NumA + " | Prix d'achat : " + PrixAchat + " | Prix de vente : " + PrixVente + " Marge Benef : " + this.MB;
        }
    }
}
