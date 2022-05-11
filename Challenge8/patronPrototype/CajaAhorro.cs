using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8
{
    public class CajaAhorro : Cuenta, Prototype
    {
        private int interes;
        private Auto auto;

        public int Interes { get { return interes; }  set { interes = value; } }
        public Auto Auto { get { return auto; } }
        public CajaAhorro(string nombre, string apellido, double saldo,Banco banco,int interes,Auto auto) : base(nombre, apellido, saldo,banco)
        {
            this.interes = interes;
            this.auto = auto;
        }
        public Prototype clone()
        {
            CajaAhorro clone = null;
            clone = (CajaAhorro)base.clone();
            clone.auto = (Auto)this.auto.clone();
            return clone;
        }

        public override string ToString()
        {
            return base.ToString() + " interes: " + this.interes + "auto: " + this.auto;
        }
    }
}
