﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {

            foreach (Personaje pj in personajes)
            {
                pj.Atacar();

            }
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();
        }
    }
}