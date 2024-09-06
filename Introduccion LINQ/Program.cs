// See https://aka.ms/new-console-template for more information

#region Arrays
//string[] palabras;
//palabras = new string[] { "Gato", "Perro", "Lagarta", "Tortuga", "Yo","raton","Johanna" };

//List<string> resultado = new List<string>();

//foreach(string animal in palabras)
//{
//    if (animal.Length>5)
//    {
//        resultado.Add(animal);
//    }
//}

//foreach(var i in resultado)
//{
//    Console.WriteLine(i);
//}


//Console.WriteLine("---------------------");
//IEnumerable<string> list = from i in palabras where i.Length > 5 select i;


//foreach (var listado in list)
//{
//    Console.WriteLine(listado);
//}
//Console.WriteLine("---------------------");

#endregion

using Introduccion_LINQ;

#region Guia LINQ
// ---- GUIA DE LINQ ----- //
// Crear una nueva lista de objetos de tipo Casa
// Esta lista se utilizará para almacenar y manejar múltiples instancias de la clase Casa.
List<Casa> Casas = new List<Casa>();

// Crear una nueva lista de objetos de tipo Habitante
// Esta lista se utilizará para almacenar y manejar múltiples instancias de la clase Habitante.
List<Habitante> Habitante = new List<Habitante>();

//CASAS

// Agregar un nuevo objeto de tipo Casa a la lista Casas
// El objeto representará una casa con las siguientes propiedades
Casas.Add(new Casa
{
    // Establece el identificador único de la casa como 1
    idCasa = 1,

    // Establece la dirección de la casa como "3 av Norte Arcancity"
    Direccion = "3 av Norte Arcancity",

    // Establece la ciudad donde se encuentra la casa como "Gothan City"
    Ciudad = "Gothan City",

    // Establece el número de habitaciones en la casa como 10
    numHabitaciones = 10,
});



Casas.Add(new Casa
{
    idCasa = 2,
    Direccion = "8 calle poniente",
    Ciudad = "Nueva Concepcion",
    numHabitaciones = 5,
});

Casas.Add(new Casa
{
    idCasa = 3,
    Direccion = "7 av suroeste ",
    Ciudad = "Nueva Concepcion",
    numHabitaciones = 4,
});

Casas.Add(new Casa
{
    idCasa = 4,
    Direccion = "2 calle oriente",
    Ciudad = "Metapan",
    numHabitaciones = 6,
});


//HABITANTES
// Agregar un nuevo objeto de tipo Habitante a la lista Habitante
// El objeto representará a un habitante con las siguientes propiedades
Habitante.Add(new Habitante
{
    // Establece el identificador único del habitante como 1
    idHabitante = 1,

    // Establece el nombre del habitante como "Anderson Juvini"
    Nombre = "Anderson Juvini",

    // Establece la edad del habitante como 19 años
    Edad = 19,

    // Establece el identificador de la casa en la que vive el habitante como 2
    idCasa = 2
});


Habitante.Add(new Habitante
{
    idHabitante = 2,
    Nombre = "Bryan Alexis",
    Edad = 19,
    idCasa = 2
});

Habitante.Add(new Habitante
{
    idHabitante = 3,
    Nombre = "Rafael Edmundo",
    Edad = 23,
    idCasa = 1
});

Habitante.Add(new Habitante
{
    idHabitante = 4,
    Nombre = "Carlos Salguero",
    Edad = 18,
    idCasa = 1
});

/*
// Consulta para filtrar los habitantes cuya edad está entre 18 y 19 años
// `IEnumerable<Habitante>` es una interfaz que representa una colección de objetos `Habitante` que se puede enumerar.
// La consulta usa LINQ (Language Integrated Query) para seleccionar los habitantes con edades mayores a 17 y menores a 20.
IEnumerable<Habitante> ListaEdades = from edades in Habitante
                                     where edades.Edad > 17 && edades.Edad < 20
                                     select edades;

// Imprime una línea de separación en la consola
Console.WriteLine("------------------------------------------");

// Itera sobre cada objeto `Habitante` en la colección `ListaEdades`
// y llama al método `datoHabitante()` para imprimir los detalles del habitante en la consola
foreach (Habitante edades2 in ListaEdades)
{
    // Imprime los detalles del habitante actual
    Console.WriteLine(edades2.datoHabitante());
}

// Imprime una línea de separación en la consola
Console.WriteLine("------------------------------------------");

// Consulta para encontrar los habitantes que viven en casas ubicadas en "Nueva Concepcion"
// Esta consulta utiliza una cláusula `join` para combinar la lista de `Habitante` con la lista de `Casa`
// en función de que el `idCasa` del habitante coincida con el `idCasa` de la casa.
IEnumerable<Habitante> ListaCasas2 = from habitantetemportal in Habitante
                                     join casatemportal in Casas
                                     on habitantetemportal.idCasa equals casatemportal.idCasa
                                     where casatemportal.Ciudad == "Nueva Concepcion"
                                     select habitantetemportal;

// Imprime una línea de separación en la consola
Console.WriteLine("\n------------------------------------------");

// Itera sobre cada objeto `Habitante` en la colección `ListaCasas2`
// y llama al método `datoHabitante()` para imprimir los detalles del habitante en la consola
foreach (Habitante h in ListaCasas2)
{
    // Imprime los detalles del habitante actual
    Console.WriteLine(h.datoHabitante());
}

// Imprime una línea de separación en la consola
Console.WriteLine("------------------------------------------");
*/

#endregion

#region Guia LAMBDA
// ---- GUIA DE LAMBDA ----- //

//var primeraCasa = Casas.First();

//Console.WriteLine(primeraCasa.dameDatosCasa());

//Habitante personaEdad = (from variableHabitante in Habitante
//                         where variableHabitante.Edad >20
//                         select variableHabitante).First();

//Console.WriteLine(personaEdad.datoHabitante());


////Lo mismo pero con LAMBDA

//var huespedes = Habitante.First(x => x.Edad > 20);

//Console.WriteLine(huespedes.datoHabitante());

//Casa buscarCasa = Casas.FirstOrDefault(x => x.numHabitaciones > 3 && x.numHabitaciones<7);
//if (buscarCasa==null)
//{
//    Console.WriteLine("NO EXISTE NADA");
//    return;
//}
//Console.WriteLine($"SI EXISTE: \nLa {buscarCasa.dameDatosCasa()}");

#endregion

#region Guia Clausula Last y LasOrDefault

//Casa ultimacasa = Casas.Last(temp=>temp.idCasa>1);
//Console.WriteLine(ultimacasa.dameDatosCasa());
//Console.WriteLine("---------------------------------------------------------\n");

//var h1 = (from objetoHabitante in Habitante where objetoHabitante.Edad >=20 select objetoHabitante).LastOrDefault();

//if (h1 == null)
//{
//    Console.WriteLine("Algo fallo");
//    return;
//}
//Console.WriteLine(h1.datoHabitante());
#endregion

#region Clausulas ElementAt y ElementAtrOrDefault

//var terceraCasa = Casas.ElementAt(2);
//Console.WriteLine($"La tercera casa es: {terceraCasa.dameDatosCasa()}");

//var buscarError = Casas.ElementAtOrDefault(3);

//if (buscarError!=null)
//{
//    Console.WriteLine($"La tercera casa es: {buscarError.dameDatosCasa()}");
//}

//Console.WriteLine("----------------------------------------------------------------------------\n");
//var segundoHabitante = (from habitantedos in Habitante select habitantedos).ElementAtOrDefault(2);
//Console.WriteLine($"El segundo habitante es: {segundoHabitante.datoHabitante()}");
#endregion

#region Clausula single y singleOrDefault

//try
//{
//    var habitantes = Habitante.Single(variableTem => variableTem.Edad <19);
//    Console.WriteLine($"Habitante con menos de 20 años {habitantes.datoHabitante()}");
//    var habitantes2 = (from objeto in Habitante where objeto.Edad >= 23 select objeto).SingleOrDefault();

//    if (habitantes2!=null)
//    {
//        Console.WriteLine($"Habitante mayor a 20 años {habitantes2.datoHabitante()}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrio un ERROR {ex.Message}");
//}
#endregion

#region Clausula OfType
//var listadoEmpleados = new List<Empleado>()
//{

//    new Medico(){Nombre="Jorge Luis"},
//    new Empleado(){nombre="Juan Leonidas"}

//};

//var medico = listadoEmpleados.OfType<Medico>();

//Console.WriteLine(medico.Single().Nombre);

#endregion

#region Clausula OrderBy  y OrderbyDescending
// ORDENANDO DE MANERA ASCENDENTE // 

//var edadA = Habitante.OrderBy(x => x.Edad);
//var edadAC = from vt in Habitante orderby vt.Edad select vt;

//foreach (var edades in edadA /*o edadesAC*/)
//{
//    Console.WriteLine(edades.datoHabitante());
//}


// ORDENANDO DE MANERA DESCENDENTE //

//var listadoEdad = Habitante.OrderByDescending(x => x.Edad);

//foreach (var edades in listadoEdad)
//{
//    Console.WriteLine(edades.datoHabitante());
//}

//Console.WriteLine("---------------------------------------------------------------");

//var listadoEdad2 = from obejeto in Habitante orderby obejeto.Edad descending select obejeto;

//foreach (var edades in listadoEdad2)
//{
//    Console.WriteLine(edades.datoHabitante());
//}
#endregion

#region Clausula ThenBy y ThenByDescending

//ORDENANDO DE MANERA ASCENDENTE

//var habitantes = Habitante.OrderBy(x => x.Edad).ThenBy(x => x.Nombre);

//foreach (var edad in habitantes)
//{
//    Console.WriteLine(edad.datoHabitante());
//}

//Console.WriteLine("---------------------------------------------------------------");

//var habitante2 = from objeto in Habitante orderby objeto.Edad, objeto.Nombre ascending select objeto;

//foreach (var h in habitante2)
//{
//    Console.WriteLine(h.datoHabitante());
//}

//ORDENANDO DE MANERA DESCENTEDENTE

var habitantes4 = Habitante.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

// Itera sobre cada objeto Habitante en la colección ordenada 'habitantes4'
// e imprime los detalles del habitante en la consola
foreach (var h in habitantes4)
{
    // Imprime los detalles del habitante actual llamando al método datoHabitante()
    Console.WriteLine(h.datoHabitante());
}

// Imprime una línea de separación en la consola para mejorar la legibilidad
Console.WriteLine("---------------------------------------------------------------");

// Consulta LINQ que ordena los habitantes primero por edad en orden ascendente y luego por nombre en orden descendente
// Utiliza la sintaxis de consulta LINQ con 'orderby' para la primera ordenación y 'descending' para la segunda.
var lista4 = from h in Habitante
             orderby h.Edad, h.Nombre descending
             select h;

// Itera sobre cada objeto Habitante en la colección ordenada 'lista4'
// e imprime los detalles del habitante en la consola
foreach (var h in lista4)
{
    // Imprime los detalles del habitante actual llamando al método datoHabitante()
    Console.WriteLine(h.datoHabitante());
}
#endregion