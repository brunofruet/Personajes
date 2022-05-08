using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal class PersonajeDeAgilidad : Personaje
    {
        public void AsignarAtributos(string nombre, int agilidad, int fuerza, int magia)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;
        }

        public override double CalcularDanio()
        {
           return Fuerza / 2 * Agilidad * Magia / 2;
        }
    }
}
