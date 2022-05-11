using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8
{
    public class Banco : Prototype
    {
        private string nombreBanco;
        private string ciudad;
        public string NombreBanco { get { return nombreBanco; } }
        public string Ciudad { get { return ciudad; } set { ciudad = value; } }
        public Banco(string nombreBanco,string ciudad)
        {
            this.nombreBanco = nombreBanco;
            this.ciudad = ciudad;
        }

        public override string ToString()
        {
            return "banco: " + nombreBanco + " " + ciudad;
        }

        public Prototype clone()
        {
            Banco clone = null;
            clone = (Banco)this.MemberwiseClone();
            return clone;
        }
    }
}
