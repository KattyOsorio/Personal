using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar al usuario un número y calcular cuál es el cuadrado del número ($2^2=4$).

            Console.WriteLine("Ingrese un número: ");
             var num1 = Convert.ToDouble(Console.ReadLine());
            var cuadrado = num1 * num1;

            Console.WriteLine($"El cuadrado de {num1} es: {cuadrado}"); 




        }
    }
}
