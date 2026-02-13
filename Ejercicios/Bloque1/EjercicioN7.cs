/*Ejercicio numero 7: Conversión de unidades de almacenamiento 
- Convertir entre bytes, KB, MB, GB y TB según
elección del usuario.*/

using System;

namespace Ejercicios.Bloque1
{
    class Ejercicio_N7_ConversionUnidades
    {
        public static void Ejecutar()
        {
           int opcionConvercion;
           double cantidad;
           double B;
           double KB;
           double MB;
           double GB;
           double TB;
           do
           {
            Console.Clear();
            Console.WriteLine("-----Menu de Conversion de Unidades-----");
            Console.WriteLine("1. Convertir bytes.");
            Console.WriteLine("2. Convertir KB.");
            Console.WriteLine("3. Convertir MB.");
            Console.WriteLine("4. Convertir GB.");
            Console.WriteLine("5. Convertir Tb.");
            Console.WriteLine("6. Salir.");
            Console.WriteLine("Ingrese su opcion: ");
            opcionConvercion = int.Parse(Console.ReadLine());

                switch (opcionConvercion)
                {
                    case 1 :
                            Console.WriteLine("Ingrese la cantidad de Bytes");
                            if (!double.TryParse(Console.ReadLine(), out  cantidad))
                            {
                                Console.WriteLine("Valor inválido");
                                break;
                            }

                            KB = cantidad / 1024;
                            MB = cantidad / (1024 * 1024);
                            GB = cantidad / (1024 * 1024 * 1024);
                            TB = cantidad / (1024.0 * 1024 * 1024 * 1024);

                            Console.WriteLine("Las conversiones son: ");
                            Console.WriteLine($"En KB: {KB:F2}. En MB: {MB:F2}. En GB: {GB:F2}. En TB: {TB:F2}");
                            Console.WriteLine("Presione enter para continuar...");
                            Console.ReadKey();
                            break;
                    case 2 :
                            Console.WriteLine("Ingrese la cantidad de KB");
                            if (!double.TryParse(Console.ReadLine(), out  cantidad))
                            {
                                Console.WriteLine("Valor inválido");
                                break;
                            }

                            B = cantidad * 1024;
                            MB = cantidad / 1024;
                            GB = cantidad / (1024 * 1024);
                            TB = cantidad / (1024.0 * 1024 * 1024);

                            Console.WriteLine("Las conversiones son: ");
                            Console.WriteLine($"En B: {B:F2}. En MG: {MB:F2}. En GB: {GB:F2}. En TB: {TB:F2}");
                            Console.WriteLine("Presione enter para continuar...");
                            Console.ReadKey();
                            break;
                    case 3 :
                            Console.WriteLine("Ingrese la cantidad de MB");
                            if (!double.TryParse(Console.ReadLine(), out  cantidad))
                            {
                                Console.WriteLine("Valor inválido");
                                break;
                            }

                            B = cantidad * (1024 * 1024);
                            KB = cantidad * 1024;
                            GB = cantidad / 1024;
                            TB = cantidad / (1024.0 * 1024);

                            Console.WriteLine("Las conversiones son: ");
                            Console.WriteLine($"En B: {B:F2}. En KB: {KB:F2}. En GB: {GB:F2}. En TB: {TB:F2}");
                            Console.WriteLine("Presione enter para continuar...");
                            Console.ReadKey();
                            break;
                    case 4 :
                            Console.WriteLine("Ingrese la cantidad de GB");
                            if (!double.TryParse(Console.ReadLine(), out  cantidad))
                            {
                                Console.WriteLine("Valor inválido");
                                break;
                            }

                            B = cantidad * (1024 * 1024 * 1024);
                            KB = cantidad * (1024 * 1024);
                            MB = cantidad * 1024;
                            TB = cantidad / 1024;

                            Console.WriteLine("Las conversiones son: ");
                            Console.WriteLine($"En B: {B:F2}. En KB: {KB:F2}. En MB: {MB:F2}. En TB: {TB:F2}");
                            Console.WriteLine("Presione enter para continuar...");
                            Console.ReadKey();
                            break;
                    case 5 :
                            Console.WriteLine("Ingrese la cantidad de TB");
                            if (!double.TryParse(Console.ReadLine(), out  cantidad))
                            {
                                Console.WriteLine("Valor inválido");
                                break;
                            }

                            B = cantidad * (1024.0 * 1024 * 1024 * 1024);
                            KB = cantidad * (1024 * 1024 * 1024);
                            MB = cantidad * (1024 * 1024);
                            GB = cantidad * 1024;

                            Console.WriteLine("Las conversiones son: ");
                            Console.WriteLine($"En B: {B:F2}. En KB: {KB:F2}. En MB: {MB:F2}. En GB: {GB:F2}");
                            Console.WriteLine("Presione enter para continuar...");
                            Console.ReadKey();
                            break;
                }

           } while (opcionConvercion != 6);
        }
    }
}