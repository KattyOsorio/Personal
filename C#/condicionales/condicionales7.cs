using System;

namespace MyApp

// 7. Conversión de temperaturas. Crear un menú de opciones. 
{
    internal class Program
    {
        static double FahrenheitACelsius(double f)
        {
            return (f - 32) / 1.8;
        }

        static double FahrenheitAKelvin(double f)
        {
            return (f + 459.67) / 1.8;
        }

        static double FahrenheitARankine(double f)
        {
            return f + 459.67;
        }

        static double FahrenheitAReaumur(double f)
        {
            return (f - 32) / 2.25;
        }

        static double CelsiusAFahrenheit(double c)
        {
            return c * 1.8 + 32;
        }

        static double CelsiusAKelvin(double c)
        {
            return c + 273.15;
        }

        static double CelsiusARankine(double c)
        {
            return c * 1.8 + 32 + 459.67;
        }

        static double CelsiusAReaumur(double c)
        {
            return c * 0.8;
        }

        static double KelvinACelsius(double k)
        {
            return k - 273.15;
        }

        static double KelvinAFahrenheit(double k)
        {
            return k * 1.8 - 459.67;
        }

        static double KelvinARankine(double k)
        {
            return k * 1.8;
        }

        static double KelvinAReaumur(double k)
        {
            return (k - 273.15) * 0.8;
        }

        static double RankineACelsius(double ra)
        {
            return (ra - 32 - 459.67) / 1.8;
        }

        static double RankineAFahrenheit(double ra)
        {
            return ra - 459.67;
        }

        static double RankineAKelvin(double ra)
        {
            return ra / 1.8;
        }

        static double RankineAReaumur(double ra)
        {
            return (ra - 32 - 459.67) / 2.25;
        }

        static double ReaumurACelsius(double re)
        {
            return re * 1.25;
        }

        static double ReaumurAFahrenheit(double re)
        {
            return re * 2.25 + 32;
        }

        static double ReaumurAKelvin(double re)
        {
            return re * 2.25 + 273.15;
        }

        static double ReaumurARankine(double re)
        {
            return re * 2.25 + 32 + 459.67;
        }

        static void MenuConversionTemperaturas()
        {
            Console.WriteLine("Seleccione la conversión de temperaturas que desea realizar:");
            Console.WriteLine("1. Fahrenheit a Celsius");
            Console.WriteLine("2. Fahrenheit a Kelvin");
            Console.WriteLine("3. Fahrenheit a Rankine");
            Console.WriteLine("4. Fahrenheit a Réaumur");
            Console.WriteLine("5. Celsius a Fahrenheit");
            Console.WriteLine("6. Celsius a Kelvin");
            Console.WriteLine("7. Celsius a Rankine");
            Console.WriteLine("8. Celsius a Réaumur");
            Console.WriteLine("9. Kelvin a Celsius");
            Console.WriteLine("10. Kelvin a Fahrenheit");
            Console.WriteLine("11. Kelvin a Rankine");
            Console.WriteLine("12. Kelvin a Réaumur");
            Console.WriteLine("13. Rankine a Celsius");
            Console.WriteLine("14. Rankine a Fahrenheit");
            Console.WriteLine("15. Rankine a Kelvin");
            Console.WriteLine("16. Rankine a Réaumur");
            Console.WriteLine("17. Réaumur a Celsius");
            Console.WriteLine("18. Réaumur a Fahrenheit");
            Console.WriteLine("19. Réaumur a Kelvin");
            Console.WriteLine("20. Réaumur a Rankine");

            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion >= 1 && opcion <= 20)
            {
                Console.Write("Ingrese la temperatura a convertir: ");
                double temperatura = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Fahrenheit a Celsius: {FahrenheitACelsius(temperatura)}");
                        break;
                    case 2:
                        Console.WriteLine($"Fahrenheit a Kelvin: {FahrenheitAKelvin(temperatura)}");
                        break;
                    case 3:
                        Console.WriteLine($"Fahrenheit a Rankine: {FahrenheitARankine(temperatura)}");
                        break;
                    case 4:
                        Console.WriteLine($"Fahrenheit a Réaumur: {FahrenheitAReaumur(temperatura)}");
                        break;
                    case 5:
                        Console.WriteLine($"Celsius a Fahrenheit: {CelsiusAFahrenheit(temperatura)}");
                        break;
                    case 6:
                        Console.WriteLine($"Celsius a Kelvin: {CelsiusAKelvin(temperatura)}");
                        break;
                    case 7:
                        Console.WriteLine($"Celsius a Rankine: {CelsiusARankine(temperatura)}");
                        break;
                    case 8:
                        Console.WriteLine($"Celsius a Réaumur: {CelsiusAReaumur(temperatura)}");
                        break;
                    case 9:
                        Console.WriteLine($"Kelvin a Celsius: {KelvinACelsius(temperatura)}");
                        break;
                    case 10:
                        Console.WriteLine($"Kelvin a Fahrenheit: {KelvinAFahrenheit(temperatura)}");
                        break;
                    case 11:
                        Console.WriteLine($"Kelvin a Rankine: {KelvinARankine(temperatura)}");
                        break;
                    case 12:
                        Console.WriteLine($"Kelvin a Réaumur: {KelvinAReaumur(temperatura)}");
                        break;
                    case 13:
                        Console.WriteLine($"Rankine a Celsius: {RankineACelsius(temperatura)}");
                        break;
                    case 14:
                        Console.WriteLine($"Rankine a Fahrenheit: {RankineAFahrenheit(temperatura)}");
                        break;
                    case 15:
                        Console.WriteLine($"Rankine a Kelvin: {RankineAKelvin(temperatura)}");
                        break;
                    case 16:
                        Console.WriteLine($"Rankine a Réaumur: {RankineAReaumur(temperatura)}");
                        break;
                    case 17:
                        Console.WriteLine($"Réaumur a Celsius: {ReaumurACelsius(temperatura)}");
                        break;
                    case 18:
                        Console.WriteLine($"Réaumur a Fahrenheit: {ReaumurAFahrenheit(temperatura)}");
                        break;
                    case 19:
                        Console.WriteLine($"Réaumur a Kelvin: {ReaumurAKelvin(temperatura)}");
                        break;
                    case 20:
                        Console.WriteLine($"Réaumur a Rankine: {ReaumurARankine(temperatura)}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Escoja una opción válida.");
            }
        }

        static void Main(string[] args)
        {
            MenuConversionTemperaturas();
        }
    }
}
