using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Solicitar número al usuario y determinar si es negativo,
            //positivo o cero.

            Console.WriteLine("Ingresa un numero: ");
            var num = Convert.ToDouble(Console.ReadLine());


            if (num == 0) {

                Console.WriteLine("El numero es 0."); }

            else if (num < 0 ) {

                Console.WriteLine(" El numero es negativo."); }

            else {

                Console.WriteLine($" El numero es positivo. "); }
        }
    }
}
