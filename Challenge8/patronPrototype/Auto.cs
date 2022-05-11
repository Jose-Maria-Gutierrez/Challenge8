using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8
{
    public class Auto : Prototype
    {
        private string marca;
        public string Marca { get { return marca; } set { marca = value; } }
        public Auto(string marca)
        {
            this.marca = marca;
        }
        public override string ToString()
        {
            return this.marca;
        }

        public Prototype clone()
        {
            Auto clon = null;
            clon = (Auto)this.MemberwiseClone();
            return clon;
        }   
    }
}
