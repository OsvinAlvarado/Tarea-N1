/*Ejercicio numero 30: Inventario simple - 
Matriz para 5 productos con: código, nombre (usar arreglo paralelo de
strings), cantidad y precio. Menú para: mostrar inventario, buscar producto, actualizar cantidad,
calcular valor total del inventario.*/

using System;

namespace Ejercicios.Bloque4
{
    class Ejercicio_N30_InventarioSimple
    {
        public static void Ejecutar()
        {
            Console.Clear();

            int[,] inventario = new int[5, 3]; // [i,0]=codigo, [i,1]=cantidad, [i,2]=precio
            string[] nombres = new string[5];

            // Ingreso de productos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nProducto {i + 1}");

                Console.Write("Código: ");
                inventario[i, 0] = int.Parse(Console.ReadLine());

                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Cantidad: ");
                inventario[i, 1] = int.Parse(Console.ReadLine());

                Console.Write("Precio: ");
                inventario[i, 2] = int.Parse(Console.ReadLine());
            }

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("----- MENÚ INVENTARIO -----");
                Console.WriteLine("1. Mostrar inventario");
                Console.WriteLine("2. Buscar producto por código");
                Console.WriteLine("3. Actualizar cantidad");
                Console.WriteLine("4. Calcular valor total del inventario");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nCódigo\tNombre\tCantidad\tPrecio");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"{inventario[i,0]}\t{nombres[i]}\t{inventario[i,1]}\t\t{inventario[i,2]}");
                        }
                        break;

                    case 2:
                        Console.Write("\nIngrese código a buscar: ");
                        int buscar = int.Parse(Console.ReadLine());
                        bool encontrado = false;

                        for (int i = 0; i < 5; i++)
                        {
                            if (inventario[i, 0] == buscar)
                            {
                                Console.WriteLine($"Código: {inventario[i,0]}");
                                Console.WriteLine($"Nombre: {nombres[i]}");
                                Console.WriteLine($"Cantidad: {inventario[i,1]}");
                                Console.WriteLine($"Precio: {inventario[i,2]}");
                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                            Console.WriteLine("Producto no encontrado.");
                        break;

                    case 3:
                        Console.Write("\nIngrese código del producto: ");
                        int cod = int.Parse(Console.ReadLine());
                        bool actualizado = false;

                        for (int i = 0; i < 5; i++)
                        {
                            if (inventario[i, 0] == cod)
                            {
                                Console.Write("Nueva cantidad: ");
                                inventario[i, 1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Cantidad actualizada.");
                                actualizado = true;
                                break;
                            }
                        }

                        if (!actualizado)
                            Console.WriteLine("Producto no encontrado.");
                        break;

                    case 4:
                        double total = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            total += inventario[i, 1] * inventario[i, 2];
                        }
                        Console.WriteLine($"Valor total del inventario: L. {total}");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}