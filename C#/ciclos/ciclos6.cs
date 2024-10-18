using System;

class Program
{
    static void Main()
    {
       //6.scriba un programa para mostrar el patrón como triángulo con un asterisco. El patrón como:

        int altura = 5;

        
        for (int fila = 1; fila <= altura; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        
        for (int fila = altura - 1; fila >= 1; fila--)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
