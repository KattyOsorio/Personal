using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.Programa que permita determinar el salario a pagar a un empleado,
            //teniendo como entradas el salario diario y el número de días trabajados.
            //Tenga en cuenta que al empleado se le debe descontar el 10% por concepto de
            //pensión y 15% por concepto de salud.

            Console.WriteLine("Introduce el salario diario del empleado: ");
            var salarioDiario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el número de días trabajados: "); 
            var diasTrabajados = Convert.ToInt32(Console.ReadLine());

            var salarioBruto = salarioDiario * diasTrabajados;
            var descuentoPension = salarioBruto * 0.10;
            var descuentoSalud = salarioBruto * 0.15;
            var salarioNeto = salarioBruto - descuentoPension - descuentoSalud;

            Console.WriteLine($"El salario bruto del empleado es: {salarioBruto:C} ");
            Console.WriteLine($"El descuento por pensión es: {descuentoPension:C}");
            Console.WriteLine($"El descuento por salud es: {descuentoSalud:c}");
            Console.WriteLine($"El salario neto a pagar al empleado es: {salarioNeto:C}"); 

        }
    }
}
