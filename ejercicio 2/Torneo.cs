using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{


    class Torneo
    {
        private string primerPuesto;
        private string segundoPuesto;
        private string tercerPuesto;

        public Torneo(int minRondas, int maxRondas)
        {
            //nroRondas = new Random().Next(int.MinValue, int.MaxValue);
            NroRondas = new Random().Next(minRondas, maxRondas);
        }

        public Torneo()
        {
            NroRondas = new Random().Next(5, 10);
        }

        public Torneo(int rondas)
        {
            NroRondas = rondas;
        }

        public int NroRondas { get; private set; }

        // public int NroCliente { get; private set; }

        public void ordenarLista()
        {
            // aca ordenamos la lista de competidores despues de cada ronda
        }

        public string calcularPodio()
        {
            // devuelve los primeros 3 lugares luego de haber ordenado la lista de competidores
            primerPuesto = "Pedro"; // por ejemplo

            return primerPuesto;
        }

    }
}
