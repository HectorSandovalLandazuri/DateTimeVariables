
using System.Globalization;

DateTime today=DateTime.Now;
DateTime today1 = DateTime.UtcNow;
Console.WriteLine( today.ToString(format:"d"));
Console.WriteLine(today.ToString(format: "t"));
Console.WriteLine(today.ToString(format: "G"));
Console.WriteLine(today.ToString(format: "MMMM dd, yyyy hh:mm tt zzz "));
Console.WriteLine(today1.ToString(format: "MMMM dd, yyyy hh:mm tt zzz "));



DateTime birthday = DateTime.ParseExact("9/8/1975", "d/M/yyyy",CultureInfo.InvariantCulture);



Console.Write("Nombre: ");
string nombre= Console.ReadLine();
Console.Write("Edad: ");
string txtEdad= Console.ReadLine();

bool EdadValida = int.TryParse(txtEdad, out int edad);


if (nombre.ToLower() == "héctor" || nombre.ToLower() == "claudia") {
    nombre = $"Profesor {nombre}";
}

if (EdadValida)
{
    if (edad<21)
    {
        Console.WriteLine($"Espera {21-edad} años para empezar esta clase {nombre}.");
    }else
    {
        Console.WriteLine($"Bievenido a la clase {nombre}.");
    }
}else
{
    Console.WriteLine("No es una edad válida.");
}

