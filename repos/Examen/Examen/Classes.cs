using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Etudiant
    {
        public int NumInst ;
        public string Nom;
        public DateTime DateNaiss;
    }

    class Module
    {
        public int Code;
        public string Titre;
    }

    class Notes
    {
        public int IdEtudiant;
        public int IdModule;
        public float DS;
        public float Examen;

    }
}
