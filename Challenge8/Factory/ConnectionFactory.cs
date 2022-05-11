using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8.Factory
{
    public class ConnectionFactory
    {
        public static BaseDatos connect(String bd)
        {
            BaseDatos? bdRetorno = null;
            if (bd.Equals("oracle"))
            {
                bdRetorno = new Oracle();
            }else if (bd.Equals("mysql"))
            {
                bdRetorno = new MySQL();
            }else if (bd.Equals("sql"))
            {
                bdRetorno = new SQL();
            }
            else
            {
                Console.WriteLine("base de datos incorrecta");
            }
            return bdRetorno;
        }
    }
}
