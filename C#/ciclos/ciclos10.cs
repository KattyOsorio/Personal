using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        //10.Escriba un programa para mostrar un patrón como Z con asteriscos. 

        int altura = 7;
        MostrarPatronZ(altura);
    }

    static void MostrarPatronZ(int altura)
    {
       
        Console.WriteLine(new string('*', altura));

        for (int i = 1; i < altura - 1; i++)
        {
            
            Console.WriteLine(new string(' ', altura - i - 1) + "*");
        }

       
        Console.WriteLine(new string('*', altura));





    }
}

