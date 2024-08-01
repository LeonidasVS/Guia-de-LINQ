using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_LINQ
{
    internal class Habitante
    {
        public int idHabitante { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int idCasa{ get; set; }

        public string datoHabitante()
        {
            return $"Soy {Nombre} con edad de {Edad} años viviendo en la casa {idCasa}";
        }
    }
}
