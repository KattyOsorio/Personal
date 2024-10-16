using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14. Solicitar al usuario una distancia en metros y transformar a km., cm.
            //y mm. 

            Console.WriteLine("Introduce la distancia en metros: "); 
            var metros = Convert.ToDouble(Console.ReadLine());

            var kilometros = metros / 100;
            var centimetros = metros * 100; 
            var milimetros = metros * 1000;

            Console.WriteLine($"La distancia de {metros} metros equivale a: ");
            Console.WriteLine($"- {kilometros} killometros.");
            Console.WriteLine($"- {centimetros} centimetros.");
            Console.WriteLine($"- {milimetros} milimetros. ");
        }
    }
}
   
