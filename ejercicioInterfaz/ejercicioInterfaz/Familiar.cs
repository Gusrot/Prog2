using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicioInterfaz
{
    public class Familiar:Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos):base(precio,patente)
        {
            this._cantAsientos = cantidadAsientos;
        }
    }
}
