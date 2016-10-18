using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Laboratorio
    {
        public string Nombre;
        public List<PC> miLab;

        public Laboratorio()
        {
            miLab = new List<PC>();
        }
        public Laboratorio(string nombre):this()
        {
            this.Nombre = nombre;
        }
        public PC this[int indice]
        {
            get 
            {
                if(indice >= 0 && indice <= this.miLab.Count)
                return this.miLab[indice];
                return null;
            }
            set
            {
                if (indice == this.miLab.Count)
                    this.miLab.Add(value);
                else
                {
                    if (indice >= 0 && indice < this.miLab.Count)
                    {
                        this.miLab[indice] = value;
                    }
                }
                
            }
        }
    }
}
