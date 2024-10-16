using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11.Programa que solicite un número al usuario y permita calcular la raíz
            //cuadrada del mismo (sin usar función). 

            Console.WriteLine("Introduce un número: ");
            var numero = Convert.ToDouble(Console.ReadLine());

            var aproximacion = numero / 2;
            var tolerancia = 0.0001;
            var diferencia = double.MaxValue;

            while (diferencia > tolerancia){

                var nuevaAproximacion = 0.5 * (aproximacion + numero / aproximacion);
                diferencia = Math.Abs(nuevaAproximacion - aproximacion);
                aproximacion = nuevaAproximacion; 

            }
            Console.WriteLine($"La raiz cuadrada aproximada de {numero} es:{aproximacion} ");
        }
    }
}
