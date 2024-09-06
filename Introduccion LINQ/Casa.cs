using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_LINQ
{
    // Definición de la clase Casa con modificador de acceso interno
    internal class Casa
    {
        // Propiedad pública de tipo int para almacenar el identificador de la casa
        public int idCasa { get; set; }

        // Propiedad pública de tipo string para almacenar la dirección de la casa
        public string Direccion { get; set; }

        // Propiedad pública de tipo string para almacenar la ciudad donde se encuentra la casa
        public string Ciudad { get; set; }

        // Propiedad pública de tipo int para almacenar el número de habitaciones de la casa
        public int numHabitaciones { get; set; }

        // Método público que devuelve una cadena de texto con información sobre la casa
        public string dameDatosCasa()
        {
            // Retorna una cadena formateada con la dirección, ciudad y número de habitaciones de la casa
            return $"Direccion: {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numHabitaciones}";
        }
    }

}
