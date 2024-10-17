using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Preguntar al usuario el nombre y la edad, si es mayor o
            //igual a 18 años mostrar el mensaje "Usted es mayor de edad",
            //de lo contrario "Usted es menor de edad". Si el número
            //ingresado es negativo o la edad ingresada es mayor a 100
            //años, mostrar al usuario un mensaje de ingresar una edad
            //válida.

            Console.WriteLine("Ingresa tu nombre: "); 
            var nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            var edad = Convert.ToInt32(Console.ReadLine());

            if (edad <0 || edad >100) {

                Console.WriteLine($" {nombre} Ingresa una edad validad."); }

            else if (edad >=18 ) {

                Console.WriteLine($"{nombre} eres mayor de edad. "); }

            else {

                Console.WriteLine($"{nombre} eres menor de edad. "); }
        }
    }
}
