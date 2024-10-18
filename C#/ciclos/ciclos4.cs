using System;

class Program
{
    static void Main()
    {
        //4.Escribe un programa para leer 10 números del teclado y encontrar su suma y promedio.

        float suma = 0;
        int contador = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Introduce un número: ");
            float numero = float.Parse(Console.ReadLine());
            suma += numero;
            contador++;
        }

        float promedio = suma / contador;

        Console.WriteLine($"La suma de los números es: {suma}");
        Console.WriteLine($"El promedio de los números es: {promedio}");


    }
}
