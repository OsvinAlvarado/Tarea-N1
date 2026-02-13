/*Ejercicio numero 12 : Año bisiesto y días del mes -
 Solicitar año y mes, determinar si es bisiesto y mostrar cuántos
días tiene ese mes.*/

using System;

namespace Ejercicios.Bloque2
{
    class Ejercicio_N12_AñoBisiestoMes
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el año: ");
            int año;
            while (!int.TryParse(Console.ReadLine(), out año) || año <= 0)
            {
                Console.WriteLine("Error. Ingrese un año valido: ");
            }

            bool bisiesto = año % 4 == 0 && año % 100 != 0 || año % 400 == 0;
            if(bisiesto)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");

            }

            Console.WriteLine("Ingrese el mes (1-12): ");
            int mes ;
            while(!int.TryParse(Console.ReadLine(), out mes) || mes <= 0 || mes > 12)
            {
                Console.WriteLine("Error. Escriba el numero de mes correctamente: ");
            }

            int dias;

            switch (mes)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                dias = 31;
                break; 

                case 4: case 6: case 9: case 11:
                    dias = 30;
                    break;

                case 2:
                    dias = bisiesto ? 29 : 28;
                    break;
                default:
                    dias = 0; // nunca debería pasar
                    break;
            }

            Console.WriteLine($"El mes {mes} del año {año} tiene {dias} días.");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

        }
    }
}