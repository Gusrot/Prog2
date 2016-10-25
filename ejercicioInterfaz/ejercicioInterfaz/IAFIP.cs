using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicioInterfaz
{
    public interface IAFIP
    {
        double CalcularImpuesto();

        double RetornarImpuesto
        {
            get;
        }
    }
}
