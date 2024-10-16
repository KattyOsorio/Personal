using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que permita calcular el 30%, el 60% y el 90% de cualquier número.

            Console.WriteLine(" introduce un numero: "); 
            var num1 = Convert.ToDouble(Console.ReadLine());

            var porcentaje_30 = num1 * 0.30;
            var porcentaje_60 = num1 * 0.60;
            var porcentaje_90 = num1 * 0.90;

            Console.WriteLine($" El porcentaje del primer numero es: {porcentaje_30}");
            Console.WriteLine($" El porcentaje del segundo numero es: {porcentaje_60}");
            Console.WriteLine($" El porcentaje del tercer numero es: {porcentaje_90}");


        }
    }
}
