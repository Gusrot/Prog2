using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceccionBasica
{
    public class Carrera
    {
        public List<Auto> misAutos;
        public string Autodromo;


        public Carrera(string autodromo)
        {
            this.Autodromo = autodromo;
            this.misAutos = new List<Auto>();




        }
        public void correrCarrera()
        {
            if (this.misAutos.Count > 0)
            {
                Console.WriteLine("Hay auto");
                foreach (Auto item in this.misAutos)
                {
                    item.Andar();
                }
            }
            else
            {
                throw new  MiExcepcion(DateTime.Now , DateTime.Now.ToString());
            }
        }
    }
}
