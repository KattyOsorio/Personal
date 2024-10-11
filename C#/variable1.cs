namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: " +
                "");
             var num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            var num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            var num3 = Convert.ToDouble(Console.ReadLine());

            var resultado = num1 * num2 * num3;

            Console.WriteLine($"El resultado es: {resultado}");


        }
    }
}
