using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceccionBasica
{
    public class Rueda
    {
        public static Random rng;
        public string marca;
        static Rueda()
        {
            rng = new Random();
        }
        public Rueda(string marca)
        { 
            this.marca = marca;
        }
        public void pinchar()
        {
            new PinchaduraEx(this.marca,DateTime.Now,"Algo");
        }
        public void rodar()
        {
            
            int random = rng.Next(1,30);

            if (random == 3)
            {
                this.pinchar();
                
            }
            else
            {
                Console.WriteLine(random);
            }
        }
    }
}
