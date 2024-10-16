using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que permita calcular la edad de una persona conociendo el año actual y el
            //usuario digita su año de nacimiento.

            var año_actual = DateTime.Now.Year;

            Console.WriteLine("ingresa la fecha de nacimiento");
            var nacimiento = Convert.ToInt32(Console.ReadLine());

            var resultado = año_actual - nacimiento;

            Console.WriteLine($"Tiene {resultado} años de edad");










        }
    }
}
