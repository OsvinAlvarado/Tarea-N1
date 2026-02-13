/*Ejercicio nmumero 22: Calculadora con menú - 
Calculadora que opera hasta que el usuario elija salir. Incluir
operaciones básicas, potencia, raíz cuadrada y porcentaje. Mantener el último resultado para
operaciones encadenadas.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N22_CalculadoraMenu
    {
        public static void Ejecutar()
        {
            Console.Clear();
            double resultado = 0; // para el último resultado
            int opcion;
            bool primeraOperacion = true;

            do
            {
                Console.Clear();
                Console.WriteLine("----- CALCULADORA -----");
                Console.WriteLine($"Último resultado: {resultado}");
                Console.WriteLine("1. Suma ");
                Console.WriteLine("2. Resta ");
                Console.WriteLine("3. Multiplicación ");
                Console.WriteLine("4. División ");
                Console.WriteLine("5. Potencia ");
                Console.WriteLine("6. Raíz cuadrada ");
                Console.WriteLine("7. Porcentaje ");
                Console.WriteLine("8. Salir");
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                double num1, num2;

                switch (opcion)
                {
                    case 1: // Suma
                        if (primeraOperacion)
                        {
                            Console.Write("Ingrese el primer número: ");
                            num1 = double.Parse(Console.ReadLine());
                        }
                        else num1 = resultado;

                        Console.Write("Ingrese el segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        primeraOperacion = false;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 2: // Resta
                        if (primeraOperacion)
                        {
                            Console.Write("Ingrese el primer número: ");
                            num1 = double.Parse(Console.ReadLine());
                        }
                        else num1 = resultado;

                        Console.Write("Ingrese el segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        primeraOperacion = false;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 3: // Multiplicación
                        if (primeraOperacion)
                        {
                            Console.Write("Ingrese el primer número: ");
                            num1 = double.Parse(Console.ReadLine());
                        }
                        else num1 = resultado;

                        Console.Write("Ingrese el segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        primeraOperacion = false;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 4: // División
                        if (primeraOperacion)
                        {
                            Console.Write("Ingrese el primer número: ");
                            num1 = double.Parse(Console.ReadLine());
                        }
                        else num1 = resultado;

                        Console.Write("Ingrese el segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 == 0)
                            Console.WriteLine("Error: división entre 0");
                        else
                        {
                            resultado = num1 / num2;
                            primeraOperacion = false;
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        break;

                    case 5: // Potencia
                        if (primeraOperacion)
                        {
                            Console.Write("Ingrese la base: ");
                            num1 = double.Parse(Console.ReadLine());
                        }
                        else num1 = resultado;

                        Console.Write("Ingrese el exponente: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = Math.Pow(num1, num2);
                        primeraOperacion = false;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 6: // Raíz cuadrada
                        if (primeraOperacion)
                        {
                            Console.Write("Ingrese el número: ");
                            num1 = double.Parse(Console.ReadLine());
                        }
                        else num1 = resultado;

                        if (num1 < 0)
                            Console.WriteLine("Error: no se puede calcular raíz de un número negativo");
                        else
                        {
                            resultado = Math.Sqrt(num1);
                            primeraOperacion = false;
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        break;

                    case 7: // Porcentaje
                        if (primeraOperacion)
                        {
                            Console.Write("Ingrese el número base: ");
                            num1 = double.Parse(Console.ReadLine());
                        }
                        else num1 = resultado;

                        Console.Write("Ingrese el porcentaje: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 * num2 / 100;
                        primeraOperacion = false;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 8:
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

                if (opcion != 8)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 8);
        }
    }
}