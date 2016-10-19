using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Mascota
    {
        public string nombre;
        public string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.raza);
            sb.AppendLine(this.nombre);

            return sb.ToString();
        }

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            if (m1.nombre == m2.nombre && m1.raza == m2.raza)
                return true;
            return false;
        }
    }
}
