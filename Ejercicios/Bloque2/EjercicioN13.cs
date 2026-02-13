/*Ejercicio numero 13: 13. Validador de fecha
 - Ingresar día, mes y año por separado. Validar que sea una fecha real
considerando días por mes y años bisiestos.*/

using System;

namespace Ejercicios.Bloque2
{
    class Ejercicio_N13_ValidarFecha
    {
        public static void Ejecutar()
        {
             Console.Clear();

            // Aqui Pedimos el año
            Console.WriteLine("Ingrese el año: ");
            int año;
            while (!int.TryParse(Console.ReadLine(), out año) || año <= 0)
            {
                Console.WriteLine("Error. Ingrese un año valido: ");
            }

            // Determinar si es bisiesto
            bool bisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);

            // Pedir mes
            Console.WriteLine("Ingrese el mes (1-12): ");
            int mes;
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.WriteLine("Mes inválido. Ingrese un mes entre 1 y 12: ");
            }

            // Determinamo los dias máximos según mes y el anio bisiesto
            int diasMax = 0;
            switch (mes)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    diasMax = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    diasMax = 30;
                    break;
                case 2:
                    diasMax = bisiesto ? 29 : 28;
                    break;
            }

            // Pedir día
            Console.WriteLine($"Ingrese el día (1-{diasMax}): ");
            int dia;
            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > diasMax)
            {
                Console.WriteLine($"Día inválido. Ingrese un día entre 1 y {diasMax}: ");
            }

            // Aqui Mostramos el resultado
            Console.WriteLine($"\nLa fecha ingresada es: {dia:D2}/{mes:D2}/{año}");
            Console.WriteLine("Fecha válida ");
            

            if (bisiesto)
                Console.WriteLine("El año es bisiesto.");
            else
                Console.WriteLine("El año no es bisiesto.");
                
            Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
        }
    }    
}
