using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular la distancia recorrida en un movimiento
            //rectilíneo. Recuerde $x=v*t$ donde $v$ es velocidad y $t$ es tiempo.
            //Solicitar al usuario velocidad en kilómetros por hora (Km/h) y tiempo
            //en horas (h) para obtener la distancia en kilómetros (Km).

            Console.WriteLine("Ingrese la velocidad en km/h: "); 
            var velocidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese tiempo en horas: "); 
            var tiempo = Convert.ToDouble(Console.ReadLine());

            var resultado = velocidad * tiempo;

            Console.WriteLine($"La distancia recorrida es: {resultado} kilometros");



        }
    }
}
