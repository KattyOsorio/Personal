using System;

class Program
{
    static void Main()
    {
        //10. Leer el número de llantas de una compra y mostrar el valor que debe
        //pagarse. El almacén las vende con la siguiente política: Si se compran
        //menos de 6 llantas, el precio unitario es $240000. Si se compran 6 o 7,
        //el precio unitario es $221000, y si se compran más de 7 llantas, el precio
        //unitario es $180000.

        Console.WriteLine("Ingrese el numero de llantas:  ");
        var numLlantas = Convert.ToInt32(Console.ReadLine());
        var precioUnitario = 240000;
        

        if (numLlantas > 7)
        {
            precioUnitario = 180000;
        }

        else if (numLlantas >= 6 && numLlantas <= 7)
        {
            precioUnitario = 221000;
        }

        else
        {
            precioUnitario = 180000;
        }

            var total = numLlantas * precioUnitario;
            Console.WriteLine($"El total a pagar es: {total}");

    }
}
