using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class CuentaJoven : Cuenta
    {
        private int _edad;
        private int bonificacion;
        public int Edad
        {
            get { return _edad; }
        }
        public int Bonificacion 
        {
            get { return bonificacion;}
        }
        
        public CuentaJoven(string titular,int edad,int bonificacion) : base(titular)
        {
            this._edad = edad;
            this.bonificacion = bonificacion;
        }
        public CuentaJoven(String titular,double saldo,int edad,int bonificacion) : base(titular, saldo)
        {
            this._edad = edad;
            this.bonificacion = bonificacion;
        }
        bool esTitularValido(int edad)
        {
            return edad >= 18 && edad < 25;
        }

        public override void retirar(double cantidad)
        {
            if(esTitularValido(this._edad)) base.retirar(cantidad);
        }

        public override void mostrar()
        {
            Console.WriteLine("cuenta joven con bonificacion de " + this.bonificacion + "%");
            base.mostrar();
        }

    }
}
