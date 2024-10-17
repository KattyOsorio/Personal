using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar cinco notas al estudiante
            Console.Write("Ingresa la primera nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa la segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa la tercera nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa la cuarta nota: ");
            float nota4 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa la quinta nota: ");
            float nota5 = float.Parse(Console.ReadLine());

            // Calcular el promedio
            float promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            // Mostrar si aprobó o no
            if (promedio >= 3.0)
            {
                Console.WriteLine("Usted aprobó.");
            }
            else
            {
                Console.WriteLine("Usted no aprobó.");
            }
        }
    }
}
