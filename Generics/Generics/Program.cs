using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Producto> listaProd = new List<Producto>(3);
            List<Persona> listaPer = new List<Persona>(3);
            List<Vehiculo> listaV = new List<Vehiculo>(3);
            List<Mascota> listaMas = new List<Mascota>(3);

            Persona p1 = new Persona("adfasfd", 1651641);
            Persona p2 = new Persona("adfasfd", 1651641);
            Persona p3 = new Persona("adfasfd", 1651641);

            Vehiculo v1 = new Vehiculo("Volkswagen", ConsoleColor.White, "AA 378 AA");
            Vehiculo v2 = new Vehiculo("Volkswagen", ConsoleColor.White, "AA 378 AA");
            Vehiculo v3 = new Vehiculo("Volkswagen", ConsoleColor.White, "AA 378 AA");

            Mascota m1 = new Mascota("Luna", "Perro");
            Mascota m2 = new Mascota("Luna", "Perro");
            Mascota m3 = new Mascota("Luna", "Perro");

            Console.WriteLine(p1.ToString());
            Console.WriteLine(v1.ToString());
            Console.WriteLine(m1.ToString());
            Console.ReadLine();
        }
    }
}
