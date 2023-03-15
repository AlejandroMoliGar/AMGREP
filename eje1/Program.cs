using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        double diff = Math.Abs(num1 - num2);
        if (num1 > num2)
        {
            diff *= 2;
        }
        Console.WriteLine("Diferencia absoluta: " + diff);

        for (int i = 1; i <= 99; i++){
            if (i % 2 != 0){
                Console.WriteLine(i);
            }
            Console.WriteLine("Numeros {0}", i);
        }
            
        }
    }