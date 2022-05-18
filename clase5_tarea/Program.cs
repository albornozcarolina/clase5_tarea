
// Borrar la pantalla

Console.Clear();

//  Pedir el nombre de una persona

Console.WriteLine("Ingrese su nombre: ");
var nombre = Console.ReadLine(); //asigno una variable para que se guarde el dato que estoy solicitando

// Saludar al usuario

Console.WriteLine("¡Hola "  + nombre + "!" );

// Preguntar si se quiere continuar.

Console.WriteLine("¿Desea continuar? (S/N)");

// Ingresa opcion Si o No
var respuesta = Console.ReadLine();


while (respuesta.ToUpper() == "S")
{
    Console.WriteLine("Ud respondió que SI.");
    Console.Clear();
    Console.WriteLine("Ingrese su nombre: "); 
    nombre = Console.ReadLine();
    Console.WriteLine("¡Hola " + nombre + "!");
    Console.WriteLine("¿Desea continuar?");
    Console.WriteLine("Ingrese S/N");
    respuesta = Console.ReadLine();
}
if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente. ");
}
else
{
    Console.WriteLine("Opcion no válida.");
}


