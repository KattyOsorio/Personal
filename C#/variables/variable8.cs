using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8. Programa que permita ingresar 5 números y calcular el promedio.

            var suma = 0;
            for (var i = 1; i <= 5; i++) {
                Console.WriteLine($"Introduce el numero: {i} ");

                var numero = Convert.ToInt32( Console.ReadLine() );
                suma += numero; 
            }

            var promedio = suma / 5;
            Console.WriteLine($"El promedio de los 5 números ingresados es: {promedio} ");
          
        }
    }
}
