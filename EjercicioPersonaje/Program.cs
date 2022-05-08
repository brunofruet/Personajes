using EjercicioPersonaje;

var personaje1 = new PersonajeDeMagia();

personaje1.AsignarAtributosMagia("bruno", 20, 80);
personaje1.CalcularDanio();

var personaje2 = new PersonajeDeFuerza();

personaje2.AsignarAtributos("juan", 50, 70);
personaje2.CalcularDanio();
var personaje3 = new PersonajeDeAgilidad();

personaje3.AsignarAtributos("pedro", 60, 50, 50);
personaje3.CalcularDanio();

var enemigo1 = new Enemigo();
enemigo1.Vida = 10000;
enemigo1.Nivel = 10;

var pjs1 = new List<Personaje>();
pjs1.Add(personaje1);
pjs1.Add(personaje2);
pjs1.Add(personaje3);

Turno.Atacarse(pjs1);
Turno.MoverFichas(enemigo1);
foreach (var p in pjs1)
    Turno.MoverFichas(p);
