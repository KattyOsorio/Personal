using Microsoft.Win32;

namespace condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //12.Un local vende sus productos con la siguiente promoción. Si compra hasta 5
            //artículos, no hay descuento. Si compra más de 5 artículos, pero menos de 10, el
            //precio unitario se reduce en 5%. Si compra 10 o más artículos, el precio unitario se
            //reduce en 8%. Ingrese un dato de cantidad y el valor del precio unitario original.
            //Calcule y muestre el valor total a pagar.

            Console.Write("Ingrese la cantidad de artículos comprados: ");
            int cantidadArticulos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario original: $");
            float precioUnitarioOriginal = float.Parse(Console.ReadLine());

            float descuento;

            if (cantidadArticulos <= 5)
            {
                descuento = 0;
            }
            else if (cantidadArticulos < 10)
            {
                descuento = 0.05f;
            }
            else
            {
                descuento = 0.08f;
            }

            float precioConDescuento = precioUnitarioOriginal * (1 - descuento);
            float valorTotal = precioConDescuento * cantidadArticulos;

            Console.WriteLine($"El valor total a pagar es: ${valorTotal:F2}");



        }
    }
}
