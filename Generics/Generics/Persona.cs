using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Persona
    {
        public string nombre;
        public double dni;

        public Persona(string nombre, double dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.dni.ToString());
            sb.AppendLine(this.nombre);

            return sb.ToString();
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1.dni==p2.dni)
                return true;
            return false;
        }
    }
}
