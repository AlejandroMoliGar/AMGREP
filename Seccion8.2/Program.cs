using seccion8._2;
Formulario formulario = new Formulario();

Console.WriteLine ("Dame tu Nombre: ");

formulario.Nombre = Console.ReadLine();

Console.WriteLine("Dame tu edad: ");

formulario.Edad = byte.Parse(Console.ReadLine());

Console.WriteLine("Dame tu estatura: ");

formulario.Estatura = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el costo de tortillas en tu tienda sercana: ");

formulario.costoKiloTortilla = decimal.Parse(Console.ReadLine());

formulario.ImprimirDatos();