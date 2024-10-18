using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8. Solicitar tres números al usuario e imprimirlos en orden
            //ascendente y descendente. 

          
            Console.Write("Ingresa el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            
            int[] numeros = { num1, num2, num3 };

           
            var numAscendentes = numeros.OrderBy(n => n).ToArray();

            
            var numDescendentes = numeros.OrderByDescending(n => n).ToArray();

           
            Console.WriteLine("Números en orden ascendente: " + string.Join(", ", numAscendentes));
            Console.WriteLine("Números en orden descendente: " + string.Join(", ", numDescendentes));
        }
    }
}
