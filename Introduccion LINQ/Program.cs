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
List<Casa> Casas = new List<Casa>();
List<Habitante> Habitante = new List<Habitante>();

//CASAS

Casas.Add(new Casa
{
    idCasa = 1,
    Direccion="3 av Norte Arcancity",
    Ciudad="Gothan City",
    numHabitaciones=10,
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
Habitante.Add(new Habitante { 
    idHabitante=1,
    Nombre="Anderson Juvini",
    Edad=19,
    idCasa=2
});

Habitante.Add(new Habitante
{
    idHabitante = 2,
    Nombre = "Bryan Alexis",
    Edad = 22,
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


//IEnumerable<Habitante> ListaEdades = from edades in Habitante
//                                     where edades.Edad > 17 && edades.Edad<20
//                                     select edades;
//Console.WriteLine("------------------------------------------");
//foreach (Habitante edades2 in ListaEdades)
//{
//    Console.WriteLine(edades2.datoHabitante());
//}

//Console.WriteLine("------------------------------------------");

//IEnumerable<Habitante> ListaCasas2 = from habitantetemportal in Habitante
//                                     join casatemportal in Casas
//                                     on habitantetemportal.idHabitante equals casatemportal.idCasa
//                                     where casatemportal.Ciudad == "Nueva Concepcion"
//                                     select habitantetemportal;
//Console.WriteLine("\n------------------------------------------");
//foreach (Habitante h in ListaCasas2)
//{
//    Console.WriteLine(h.datoHabitante());
//}
//Console.WriteLine("------------------------------------------");

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

try
{
    var habitantes = Habitante.Single(variableTem => variableTem.Edad <19);
    Console.WriteLine($"Habitante con menos de 20 años {habitantes.datoHabitante()}");
    var habitantes2 = (from objeto in Habitante where objeto.Edad >= 23 select objeto).SingleOrDefault();

    if (habitantes2!=null)
    {
        Console.WriteLine($"Habitante mayor a 20 años {habitantes2.datoHabitante()}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio un ERROR {ex.Message}");
}
#endregion
