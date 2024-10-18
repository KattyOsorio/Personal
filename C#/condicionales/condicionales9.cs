using System;

class Program
{
    static void Main()
    {
        //9. Programa que permita a un usuario tomar una decisión del tipo de pago a
        // usar. Si la cuenta es menor a $150000 pago en efectivo. Si no, si es de
        // $150000 hasta $300000 pago con el celular (dinero electrónico). Si es
        // mayor a $300000 hasta $600000, pago con la tarjeta de débito. Todos los
        // valores superiores a $6000000, pago con la tarjeta de crédito.

        Console.Write("Ingrese el monto de la cuenta: ");
        double cuenta = double.Parse(Console.ReadLine());

        
        if (cuenta < 150000)
        {
            Console.WriteLine("Pago en efectivo.");
        }
        else if (cuenta >= 150000 && cuenta <= 300000)
        {
            Console.WriteLine("Pago con el celular (dinero electrónico).");
        }
        else if (cuenta > 300000 && cuenta <= 600000)
        {
            Console.WriteLine("Pago con tarjeta de débito.");
        }
        else
        {
            Console.WriteLine("Pago con tarjeta de crédito.");
        }
    }
}
