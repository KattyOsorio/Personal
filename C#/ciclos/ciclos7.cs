using System;

class Program
{
    static void Main()
    {
        //7.Escriba un programa para mostrar el patrón como un triángulo rectángulo con un número.
        //El patrón como:

        // 1
        //12
        //123
        //1234
        //12345

        int altura = 5;

        for (int fila = 1; fila <= altura; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write(columna);
            }
            Console.WriteLine();



        }
    }
}
