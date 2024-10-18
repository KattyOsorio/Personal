using Microsoft.Win32;

namespace condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //.14. El número de pulsaciones que debe tener una persona por cada 10 segundos de
            //ejercicio aeróbico se calcula con la fórmula:
            //Género femenino (1): número de pulsaciones = (220 - edad en años)/10
            //Género masculino (2): número de pulsaciones = (210 - edad en años)/10
            //Lea la edad y el género y muestre el número de pulsaciones.

            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu género (1.Femenino, 2.Masculino): ");
            float genero = float.Parse(Console.ReadLine());

            float pulsaciones;

            if (genero == 1)
            {
                pulsaciones = (220 - edad) / 10f;
            }
            else if (genero == 2)
            {
                pulsaciones = (210 - edad) / 10f;
            }
            else
            {
                Console.WriteLine("Género inválido");
                return; 
            }

            Console.WriteLine($"El número de pulsaciones es: {pulsaciones}");
        }
    }
}
