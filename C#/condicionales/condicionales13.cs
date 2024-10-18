using Microsoft.Win32;

namespace condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //13.Un reporte de salud muestra una tabla diferente del índice de masa corporal IMC de
            //una persona que se calcula con la fórmula IMC=P/(E*E) en donde P es el peso en Kg. y E
            //es la estatura en metros. Lea un valor de P y de E, calcule el IMC y muestre su estado
            //según la siguiente tabla:

            Console.Write("Ingrese su peso en Kg: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Ingrese su estatura en metros: ");
            float estatura = float.Parse(Console.ReadLine());

            float IMC = peso / (estatura * estatura);

            if (IMC < 18.5)
            {
                Console.WriteLine("Desnutrido.");
            }
            else if (IMC < 25)
            {
                Console.WriteLine("Normal.");
            }
            else if (IMC < 30)
            {
                Console.WriteLine("Sobrepeso.");
            }
            else if (IMC < 35)
            {
                Console.WriteLine("Obesidad Grado 1.");
            }
            else if (IMC < 40)
            {
                Console.WriteLine("Obesidad Grado 2.");
            }
            else if (IMC < 50)
            {
                Console.WriteLine("Obesidad Grado 3.");
            }
            else
            {
                Console.WriteLine("Obesidad Grado 4.");
            }
        }
    }
}
