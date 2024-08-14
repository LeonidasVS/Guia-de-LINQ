using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_LINQ
{
    internal class Casa
    {
        public int idCasa { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int numHabitaciones { get; set; }

        public string dameDatosCasa() {

            return $"Direccion: {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numHabitaciones}";
        }
    }
}
