using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceccionBasica
{
    public class Auto
    {
        public string marca;
        public int numero;
        public List<Rueda> michetti;

        public Auto(string marca, int numero)
        {
            this.marca = marca;
            this.numero = numero;
            this.michetti = new List<Rueda>();
        }

        public void Andar()
        {
            if (this.michetti.Count >= 4)
            {
                Console.WriteLine("Bicipresidenta");
                try
                {
                    foreach (Rueda item in this.michetti)
                    {
                        item.rodar();
                    }
                }
                catch (PinchaduraEx x)
                {
                    
                    throw new AutoEx(this,x.horaDeLaEx,x.horaDeLaExTexto);
                }
                
            }
            else
            {
                throw new MiExcepcion(DateTime.Now, "Macri gato " + DateTime.Now.ToString());

            }
        }

    }
}
