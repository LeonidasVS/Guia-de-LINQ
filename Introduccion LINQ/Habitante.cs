using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_LINQ
{
    // Definición de la clase Habitante con modificador de acceso interno
    internal class Habitante
    {
        // Propiedad pública de tipo int para almacenar el identificador del habitante
        public int idHabitante { get; set; }

        // Propiedad pública de tipo string para almacenar el nombre del habitante
        public string Nombre { get; set; }

        // Propiedad pública de tipo int para almacenar la edad del habitante
        public int Edad { get; set; }

        // Propiedad pública de tipo int para almacenar el identificador de la casa donde vive el habitante
        public int idCasa { get; set; }

        // Método público que devuelve una cadena de texto con información sobre el habitante
        public string datoHabitante()
        {
            // Retorna una cadena formateada con el nombre, edad y id de la casa del habitante
            return $"Soy {Nombre} con edad de {Edad} años viviendo en la casa {idCasa}";
        }
    }

}
