using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Article
    {
        public int Reference { get; set; }
        public string Designation { get; set; }
        public float Prix { get; set; }

        public Article(int Ref, string Des, float P)
        {

            Reference = Ref;
            Designation = Des;
            Prix = P;

        }

        public Article()
        {

        }

    }
}
