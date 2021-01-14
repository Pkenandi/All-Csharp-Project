using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes
{
    class Program
    {
        static void Main(string[] args)
        {
            Connexion.ConnectTo();

            
            //Operations.AjoutClient();
            //Operations.AjoutAgence();
            //Operations.CreationCompte();
            Operations.ListNumAgents();
            Operations.MoySoldeClient();
            Operations.NbrClientVille();
            Operations.NbrClientZeroAdr();
            //Operations.MajCompte();
            Operations.TotalCompte();
            //Operations.SuppCompteVide();
            Operations.TotalCompteClientX();
            Operations.MoisNaiss();
            Console.WriteLine("\n");
            Operations.PlusEtMoinAgé();

            Connexion.DisconnectTo();
        }
    }
}
