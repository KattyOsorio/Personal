using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Calcular la hipotenusa con el Teorema de Pitágoras (sin usar funciones).

            Console.WriteLine("Introduce la longitud del primer cateto: "); 
            var cateto1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce la longitud del segundo cateto: "); 
            var cateto2 = Convert.ToDouble(Console.ReadLine());

            var hipotenusa = cateto1 + cateto2 * cateto2;

            Console.WriteLine($"La longitud de la hipotenusa es: {hipotenusa} "); 
        }
    }
}
