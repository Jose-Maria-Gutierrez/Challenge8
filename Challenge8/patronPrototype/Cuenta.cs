using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8
{
    public class Cuenta : Prototype
    {
        private string nombre;
        private string apellido;
        private double saldo;
        private Banco banco;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } }
        public double Saldo { get { return saldo; } }
        public Banco Banco { get { return banco; } }  
        public Cuenta(string nombre, string apellido, double saldo,Banco banco)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.saldo = saldo;
            this.banco = banco;
        }
        public override string ToString()
        {
            return this.nombre + " " + this.apellido + " " + this.saldo + "\n" + this.banco.ToString();
        }

        public Prototype clone()
        {
            Cuenta clone = null;
            clone = (Cuenta)MemberwiseClone();
            clone.banco = (Banco)this.banco.clone();
            return clone;
        }
    }
}
