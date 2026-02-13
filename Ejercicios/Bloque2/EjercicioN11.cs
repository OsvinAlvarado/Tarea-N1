/*Ejercicio numero 11: Calculadora de descuentos - 
Según el monto de compra aplicar descuentos escalonados: 5%
(L500-999), 10% (L1000-2499), 15% (L2500+). Mostrar precio original, descuento y precio final.*/

using System;

namespace Ejercicios.Bloque2
{
    class Ejercicio_N11_CalculadoraDescuentos
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto de su compra: ");
            double monto;
            while(!double.TryParse(Console.ReadLine(), out monto) || monto <= 0)
            {
                Console.WriteLine("Error en el monto de la compra. Ingrese valor valido: ");
            }

            if(monto >= 2500)
            {
                double descuento = monto * 0.15;
                double total = monto - descuento;
                Console.WriteLine($"Su compra es de: Lps. {monto}");
                Console.WriteLine($"Su descuento fue de: Lps. {descuento:F2}");
                Console.WriteLine($"El total a pagar es: Lps. {total:F2}");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();

            }else if (monto >= 1000 && monto <= 2499)
            {
                double descuento = monto * 0.10;
                double total = monto - descuento;
                Console.WriteLine($"Su compra es de: Lps. {monto}");
                Console.WriteLine($"Su descuento fue de: Lps. {descuento:F2}");
                Console.WriteLine($"El total a pagar es: Lps. {total:F2}");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();

            }else if(monto >= 500 && monto <= 999)
            {
                double descuento = monto * 0.05;
                double total = monto - descuento;
                Console.WriteLine($"Su compra es de: Lps. {monto}");
                Console.WriteLine($"Su descuento fue de: Lps. {descuento:F2}");
                Console.WriteLine($"El total a pagar es: Lps. {total:F2}");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();

            }else if(monto < 500)
            {
            
                Console.WriteLine($"Su compra es de: Lps. {monto}");
                Console.WriteLine("Su descuento fue de: Lps. 0");
                Console.WriteLine($"El total a pagar es: Lps. {monto}");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();

            }
        }
    }
}