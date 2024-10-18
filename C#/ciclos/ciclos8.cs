using System;

class Program
{
    static void Main()
    {
        //8.Escriba un programa para hacer un patrón como una pirámide con números aumentados en 1.
        //1
        //2 3
        //4 5 6
        //7 8 9 10

        int filas = 4;
        int contador = 1;
        int numeroActual = 1;

        for (int i = 1; i <= filas; i++)
        {

            for (int espacios = filas - i; espacios > 0; espacios--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(numeroActual + " ");
                numeroActual++;
            }

            Console.WriteLine();

        }
    }
}
