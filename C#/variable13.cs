using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13. Solicitar tiempo en segundos y transformar a horas, minutos y segundos restantes.

            Console.WriteLine("Introduce el tiempo en segundos: ");
            var segundos = Convert.ToInt32(Console.ReadLine());

            var horas = segundos / 3600;
            var segundosRestantes = segundos % 3600;
            var minutos = segundosRestantes / 60;
            var segundosFinales = segundosRestantes % 60;

            Console.WriteLine($"El tiempo de {segundos} segundos equivale a {horas} horas, {minutos} minutos y {segundosFinales} segundos.");
        }
    }
}
