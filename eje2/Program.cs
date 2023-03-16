using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del rectángulo: ");
        double altura = double.Parse(Console.ReadLine());

        double perimetro = 2 * (ancho + altura);
        double area = ancho * altura;
        double diagonal = Math.Sqrt(ancho * ancho + altura * altura);

        Console.WriteLine("Perímetro: " + perimetro);
        Console.WriteLine("Área: " + area);
        Console.WriteLine("Diagonal: " + diagonal);
    }
}
