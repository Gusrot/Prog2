using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicioInterfaz
{
    public class Avion:Vehiculo,IAFIP
    {
        protected double _velocidadMaxima;
    
        public Avion(double precio, double velMax):base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        double IAFIP.CalcularImpuesto()
        {
            double impuesto;

            impuesto = (base._precio * 33) / 100;

            return impuesto;
        }

        double IAFIP.RetornarImpuesto
        {
            get { return this.CalcularImpuesto(); }
        }
    }
}
