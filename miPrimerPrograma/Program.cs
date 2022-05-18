
var opcionElegida = "S";
while (opcionElegida.ToUpper() == "S") 
{
    Console.Clear();
    //Pedir el nombre de una persona

    Console.WriteLine("Ingrese su nombre");
    //Guardar el nombre en una variable

    var nombrePersona = Console.ReadLine();
    //Saludar 

    Console.WriteLine("¡Hola " + nombrePersona + "!");

    // Si desea o no continuar
    Console.WriteLine("¿Desea continuar? S para si y N para no");
    opcionElegida = Console.ReadLine();
   
}    

if (opcionElegida.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente.");
}
else
{
    Console.WriteLine("Opcion no valida");
}
    
     
    

