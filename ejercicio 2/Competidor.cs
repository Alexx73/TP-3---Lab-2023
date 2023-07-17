using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Competidor
    {
        private int puntos;
        private int cantidad_X;

        public Competidor(int id, string nombre ,int edad, string club )
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;

            Club = club;
            Puntos = 0;
            Cantidad_X = 0;


            //Puntaje = puntaje;
            //Centros = centros;
        }

        public int Puntos { get; private set; }
        public int Cantidad_X { get; private set; }


        public string Nombre { get; private set; }
        public int Edad { get; private set; }

        public string Club { get; private set; }

        public int Id { get; private set; }

        //public int Puntaje { get; private set; }
        //public int Centros { get; private set; }

    }
}
