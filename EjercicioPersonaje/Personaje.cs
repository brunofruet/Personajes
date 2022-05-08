using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    abstract class Personaje : IMoverse
    {
        public string? Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }
        public double Danio { get; set; }

        public abstract double CalcularDanio();

        public virtual void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño");
        }
        public void MoverseEjeX()
        {
            Console.WriteLine($"El Personaje {Nombre} avanza {Agilidad / 4} unidades en el Eje X");

        }
        public void MoverseEjeY()
        {
            Console.WriteLine($"El Personaje {Nombre} avanza {Agilidad / 4} unidades en el Eje Y");
        }
    }
}
