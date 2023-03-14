
Console.WriteLine("Escribe tu Nombre:");
string Nombre = Console.ReadLine();

Console.WriteLine(Nombre);

byte Edad;

Console.WriteLine("Escribe tu edad: ");

Edad = byte.Parse(Console.ReadLine());

Console.WriteLine("Tu edad es de: {0} años",Edad);
Console.WriteLine("Cuanto mides: ");
double Estatura = double.Parse(Console.ReadLine());
Console.WriteLine("Tu estatura es de {0}", Estatura);

Console.WriteLine("Cuanto cuesta el kilo de tortillas: ");

decimal costoKiloTortilla = decimal.Parse(Console.ReadLine());

Console.WriteLine("El kilo cuesta: {0}", costoKiloTortilla);
