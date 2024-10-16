using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular el 20% de cualquier número de entrada.

            Console.WriteLine("Por favor introduce el numero: "); 
            var num = Convert.ToDouble(Console.ReadLine());

            var porcentaje = num * 0.20;


            Console.WriteLine($"El porcentaje del numero es: {porcentaje}");





        }
    }
}
