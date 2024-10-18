using System;

class Program
{
    static void Main()
    {
        //3. Escriba un programa para mostrar n términos de número natural y su suma (Fibonacci).
        //Se le solicita al usuario que ingrese el n término de la serie. Los primeros términos de
        //la serie de Fibonacci son: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, y así sucesivamente.

        Console.Write("Ingrese el total de términos a ver: ");
        int terminos = int.Parse(Console.ReadLine());
        int contador = 0;
        int num1 = 0;
        int num2 = 1;

        while (contador < terminos)
        {
            Console.Write($" {num1}");
            int num3 = num1 + num2;
            num1 = num2;
            num2 = num3;
            contador++;
        }

        Console.WriteLine(); 

    }
}
