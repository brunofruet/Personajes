using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal class Enemigo : IMoverse
    {
        public int Vida { get; set; }
        public int Nivel { get; set; }
        public void MoverseEjeX()
        {
            Console.WriteLine($"El Enemigo avanza {2 * Nivel} unidades en el Eje X");
        }
        public void MoverseEjeY()
        {
            Console.WriteLine($"El Enemigo avanza {2 * Nivel} unidades en el Eje Y");
        }
    }
}
