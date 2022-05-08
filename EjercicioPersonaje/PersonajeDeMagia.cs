using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal class PersonajeDeMagia: Personaje
    {
        public void AsignarAtributos(string nombre, int agilidad, int fuerza, int magia)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;
        }
        public void AsignarAtributosMagia(string nombre, int agilidad, int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            int magia = 60;
            Magia = magia;
            Fuerza = fuerza;
        }

        public override double CalcularDanio()
        {
            return Agilidad + Fuerza + Magia * 4;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia");
        }
    }
}
