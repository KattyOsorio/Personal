using System;

class Program
{
    static void Main()
    {
        //9.Escriba un programa para calcular el factorial de un número dado.
        int numero = 5;
        Console.WriteLine($"El factorial de {numero} es: {Factorial(numero)}");
    }

    static long Factorial(int n)
    {
        long resultado = 1;

        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;

    }
}

