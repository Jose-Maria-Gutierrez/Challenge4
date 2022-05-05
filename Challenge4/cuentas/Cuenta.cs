using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Cuenta
    {
        private String _titular;
        private double _saldo;

        public String Titular
        {
            get { return _titular; }
        }
        public double Saldo
        {
            get { return _saldo; }
        }

        public Cuenta(String titular)
        {
            this._titular = titular;
            this._saldo = 0;
        }

        public Cuenta(String titular, double saldo)
        {
            this._titular = titular;
            this._saldo = saldo;
        }

        public virtual void mostrar()
        {
            Console.WriteLine(this.Titular + " tiene $" + this.Saldo);
        }

        public void ingresar(double cantidad)
        {
            this._saldo += cantidad>0 ? cantidad : 0;
        }

        public virtual void retirar(double cantidad)
        {
            this._saldo -= cantidad;
        }

    }
}
