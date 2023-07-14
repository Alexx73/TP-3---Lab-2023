using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Competidor
    {

        public Competidor(string nombre ,int edad, string club)
        {
            Nombre = nombre;
            Edad = edad;

            Club = club;
            //Puntaje = puntaje;
            //Centros = centros;
        }

        public string Nombre { get; private set; }
        public int Edad { get; private set; }

        public string Club { get; private set; }
        //public int Puntaje { get; private set; }
        //public int Centros { get; private set; }

    }
}
