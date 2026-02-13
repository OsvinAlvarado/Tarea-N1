/*Ejercicio numero 4:Calculadora de préstamo simple 
- Solicitar monto, tasa de interés anual y plazo en meses.
Calcular el interés total y la cuota mensual fija.
*/

using System;
using System.Numerics;

namespace Ejercicios.Bloque1
{
    class Ejercicio_N4_Calculadora
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese su monto total:");
            int monto;
            while (!int.TryParse(Console.ReadLine(), out monto) || monto <= 0)
            {
                Console.WriteLine("Error. Ingrese un valor valido para monto: ");
            }

            Console.WriteLine("Ingrese su tasa de interes anual: ");
            double tasaInteres;
             while(!double.TryParse(Console.ReadLine(), out tasaInteres) || tasaInteres <= 0)
            {
                Console.WriteLine("Error. Ingrese un valor valido para la tasa de interes: ");
            }

            Console.WriteLine("Ingrese su plazo en meses: ");
            int plazosMeses;
            while (!int.TryParse(Console.ReadLine(), out plazosMeses) || plazosMeses <= 0)
            {
                Console.WriteLine("Error. Ingrese un valor valido para plazos: ");
            } 

            double intereses = monto * (tasaInteres*0.01) * (plazosMeses/12);

            double total = monto + intereses; 

            double cuota = monto/plazosMeses;

            Console.WriteLine($"El interes total es de {total} Lps. Y la cuota es de {cuota} Lps.");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

        
        }
    }
}