using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar dos números al usuario
            Console.Write("Ingresa un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int mayor, menor;

            // Comparar los números para encontrar el mayor y el menor
            if (num1 > num2)
            {
                mayor = num1;
                menor = num2;
            }
            else if (num2 > num1)
            {
                mayor = num2;
                menor = num1;
            }
            else
            {
                Console.WriteLine("Los números son iguales :)");
                return; // Salir del programa si los números son iguales
            }

            // Imprimir el mayor y el menor
            Console.WriteLine($"El número mayor es {mayor}");
            Console.WriteLine($"El número menor es {menor}");
        }
    }
}
