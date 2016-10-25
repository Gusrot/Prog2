using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicioInterfaz
{
    public class Deportivo : Auto, IAFIP
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp)
            : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }

        public double CalcularImpuesto()
        {
            double impuesto;

            impuesto = this._precio * 1.33;

            return impuesto;
        }

        public double RetornarImpuesto
        {
            get { throw new NotImplementedException(); }
        }
    }
}
