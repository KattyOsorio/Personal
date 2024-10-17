using System;

namespace MyApp
{
    internal class Program

    //6. Crear un programa con un menú de opciones, que permita
    //calcular las áreas de figuras geométricas que se muestran
    //a continuación.
    {

        static double AreaRectangulo(double baseRect, double altura)
        {
            return baseRect * altura;
        }

        static double AreaCuadrado(double lado)
        {
            return lado * lado;
        }

        static double AreaParalelogramo(double basePar, double altura)
        {
            return basePar * altura;
        }

        static double AreaRombo(double diagonalMayor, double diagonalMenor)
        {
            return (diagonalMayor * diagonalMenor) / 2;
        }

        static double AreaTrapecio(double baseMayor, double baseMenor, double altura)
        {
            return ((baseMayor + baseMenor) * altura) / 2;
        }

        static double AreaTriangulo(double baseTri, double altura)
        {
            return (baseTri * altura) / 2;
        }

        static double AreaTrianguloEquilatero(double lado)
        {
            return (lado * lado * Math.Sqrt(3)) / 4;
        }

        static double AreaTrianguloRectangulo(double baseTri, double altura)
        {
            return (baseTri * altura) / 2;
        }

        static double AreaPoligonoRegular(double perimetro, double apotema)
        {
            return (perimetro * apotema) / 2;
        }

        static void Areas()
        {
            while (true)
            {
                Console.WriteLine("\nMenú de cálculo de áreas:");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Paralelogramo");
                Console.WriteLine("4. Rombo");
                Console.WriteLine("5. Trapecio");
                Console.WriteLine("6. Triángulo");
                Console.WriteLine("7. Triángulo Equilátero");
                Console.WriteLine("8. Triángulo Rectángulo");
                Console.WriteLine("9. Polígono Regular");
                Console.WriteLine("10. Salir");

                Console.Write("Seleccione una figura para calcular el área (1-10): ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese la base del rectángulo: ");
                        double baseRect = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del rectángulo: ");
                        double alturaRect = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del rectángulo es: {AreaRectangulo(baseRect, alturaRect)}");
                        break;

                    case "2":
                        Console.Write("Ingrese el lado del cuadrado: ");
                        double lado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del cuadrado es: {AreaCuadrado(lado)}");
                        break;

                    case "3":
                        Console.Write("Ingrese la base del paralelogramo: ");
                        double basePar = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del paralelogramo: ");
                        double alturaPar = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del paralelogramo es: {AreaParalelogramo(basePar, alturaPar)}");
                        break;

                    case "4":
                        Console.Write("Ingrese la diagonal mayor del rombo: ");
                        double diagonalMayor = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la diagonal menor del rombo: ");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del rombo es: {AreaRombo(diagonalMayor, diagonalMenor)}");
                        break;

                    case "5":
                        Console.Write("Ingrese la base mayor del trapecio: ");
                        double baseMayor = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la base menor del trapecio: ");
                        double baseMenor = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del trapecio: ");
                        double alturaTrap = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del trapecio es: {AreaTrapecio(baseMayor, baseMenor, alturaTrap)}");
                        break;

                    case "6":
                        Console.Write("Ingrese la base del triángulo: ");
                        double baseTri = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del triángulo: ");
                        double alturaTri = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del triángulo es: {AreaTriangulo(baseTri, alturaTri)}");
                        break;

                    case "7":
                        Console.Write("Ingrese el lado del triángulo equilátero: ");
                        double ladoEqui = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del triángulo equilátero es: {AreaTrianguloEquilatero(ladoEqui)}");
                        break;

                    case "8":
                        Console.Write("Ingrese la base del triángulo rectángulo: ");
                        double baseTriRec = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del triángulo rectángulo: ");
                        double alturaTriRec = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del triángulo rectángulo es: {AreaTrianguloRectangulo(baseTriRec, alturaTriRec)}");
                        break;

                    case "9":
                        Console.Write("Ingrese el perímetro del polígono regular: ");
                        double perimetro = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la apotema del polígono regular: ");
                        double apotema = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área del polígono regular es: {AreaPoligonoRegular(perimetro, apotema)}");
                        break;

                    case "10":
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida, por favor intente nuevamente.");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Areas();
        }
    }
}
