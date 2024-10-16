using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular el área de un cuadrado, la longitud
            //de un lado la ingresa el usuario.

            Console.WriteLine("Introduce el numero del primer lado: ");
            var lado1 =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el segundo lado: ");
            var lado2 = Convert.ToDouble(Console.ReadLine());

            var resultado = lado1 * lado2;

            Console.WriteLine($"El area del cuadrado es: {resultado} ");
        }
    }
}
