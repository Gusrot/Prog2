using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Vehiculo
    {
        public string marca;
        public ConsoleColor color;
        public string patente;

        public Vehiculo(string marca, ConsoleColor color, string patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.marca);
            sb.AppendLine(this.color.ToString());
            sb.AppendLine(this.patente);

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1.patente == v2.patente)
                return true;
            return false;
        }
    }
}
