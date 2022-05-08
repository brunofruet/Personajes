using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal class PersonajeDeFuerza: Personaje
    {
        public void AsignarAtributos(string nombre, int agilidad, int magia)
        {   Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            int fuerza = 100;
            Fuerza = fuerza;
        }

        public override double CalcularDanio()
        {
             return Agilidad/2 + 3 * Fuerza + Magia/4;
        }
    }
}
