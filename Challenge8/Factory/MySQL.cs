using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8.Factory
{
    public class MySQL : BaseDatos
    {
        public override void getConnection()
        {
            Console.WriteLine("conectando con la clase MySQL");
        }
    }
}
