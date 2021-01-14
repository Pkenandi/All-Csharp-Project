using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnage
{
    class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Personne( int ID, string nom, string prenom, int age )
        {
            Id = ID;
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public Personne()
        {

        }
    }
}
