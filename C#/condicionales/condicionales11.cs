using Microsoft.Win32;

namespace condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //11. El precio que debe pagar un cliente por una pizza depende del tamaño seleccionado
            //como se muestra a continuación:

            // Si cada ingrediente adicional cuesta $4.000.Escribir un programa que solicite al empleado
            // encargado de registrar las ventas, el tamaño de la pizza y el número de ingredientes
            // adicionales y muestre al cliente el precio que debe pagar.

            Console.Write("Ingrese el tamaño de la pizza (1, 2 o 3): ");
            int tamaño = int.Parse(Console.ReadLine());
            int precio;

            if (tamaño == 1)
            {
                precio = 15000;
            }
            else if (tamaño == 2)
            {
                precio = 24000;
            }
            else if (tamaño == 3)
            {
                precio = 36000;
            }
            else
            {
                Console.WriteLine("Tamaño de pizza inválido. Por favor, ingrese un tamaño válido (1, 2, o 3).");
                return;
            }

            Console.Write("Ingrese el número de ingredientes adicionales: ");
            int numIngredientesAdicionales = int.Parse(Console.ReadLine());

            int costoIngredienteAdicional = 4000;
            int costoAdicionales = numIngredientesAdicionales * costoIngredienteAdicional;
            int precioTotal = precio + costoAdicionales;

            Console.WriteLine($"El precio de la pizza con {numIngredientesAdicionales} ingredientes adicionales es: ${precioTotal}");


        }
    }
}
