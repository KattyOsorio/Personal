using System;

class Program
{
    static void Main()
    {
        //5. Escriba un programa para mostrar la tabla de multiplicar de un entero dado.

        int numero = 7;
        Console.WriteLine($"Tabla de multiplicar del {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");


        }
    }
}
