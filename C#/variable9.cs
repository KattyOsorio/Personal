using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9. Programa que permita a una tienda saber el valor que pagara un cliente por
            //la compra de varios elementos de la misma referencia. Debe tener como entradas
            //el valor unitario, la cantidad de productos comprados y al valor final se debe
            //adicionar el 16% correspondiente al IVA.

            Console.WriteLine("Introduce el valor unitario del producto: ");
            var valorUnitario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inroduce la cantidad de productos comprados: ");
            var cantidad = Convert.ToInt32(Console.ReadLine());

            var subtotal1 = valorUnitario * cantidad;

            var iva = subtotal1 * 0.16;

            var total = subtotal1 + iva;

            Console.WriteLine($"El subtotal de la compra es: {subtotal1:C} ");
            Console.WriteLine($"El monto del IVA es: {iva:C}");
            Console.WriteLine($"El total a pagar (Incluyendo el 16% de IVA) es: {total:C}");
        }
    }
}
