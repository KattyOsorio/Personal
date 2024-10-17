using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar número al usuario y determinar si es par,
            //impar o es cero. 

            Console.WriteLine("Ingrese un número: "); 
            var num =int.Parse(Console.ReadLine());

            if (num == 0) {

                Console.WriteLine("El número es 0"); }

            else if (num % 2 == 0) {

                Console.WriteLine("El numero es par"); }

            else {

                Console.WriteLine("El número es impar"); }
        }
    }
}
