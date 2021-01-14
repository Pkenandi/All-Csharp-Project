using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace examen1
{
    class DBconnection
    {
        public static string Link = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\kevin\Desktop\Examen_1.accdb";

        public static OleDbConnection cnn = new OleDbConnection(Link);

    }
}
