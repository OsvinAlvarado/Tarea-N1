/*Ejercicio numero 8: Cálculo de salario semanal 
- Ingresar horas trabajadas y tarifa por hora. Las horas extras (más
de 44) se pagan al 150%. Mostrar desglose y total.*/

using System;

namespace Ejercicios.Bloque1
{
    class Ejercicio_N8_CalculoSalario
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese total de horas trabajadas: ");
            double horasTrabajadas;
            while (!double.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas <= 0 )
            {
                Console.WriteLine("Error. Ingrese un valor valido para horas trabajas: ");
            }

            Console.WriteLine("Ingrese su sueldo por hora: ");
            double sueldoHora;
            while(!double.TryParse(Console.ReadLine(), out sueldoHora) || sueldoHora <= 0)
            {
                Console.WriteLine("Error. Ingrese un valor valido para el sueldo: ");
            } 

            if(horasTrabajadas > 44)
            {
                double horasExtras = horasTrabajadas - 44;
                double porcentajeSueldoExtra = sueldoHora * 1.5;
                double sueldoExtra = horasExtras * porcentajeSueldoExtra;
                double horasTrabajadasNormales = horasTrabajadas - horasExtras;
                double sueldoHoraNormal = sueldoHora * horasTrabajadasNormales;
                double sueldoExtraTotal = sueldoExtra + sueldoHoraNormal; 

                Console.WriteLine($"El total de horas trabajadas normales son: {horasTrabajadasNormales} horas.");
                Console.WriteLine($"Las horas extras son: {horasExtras} horas.");
                Console.WriteLine($"Su sueldo pagado por hora normal es : Lps.{sueldoHoraNormal}");
                Console.WriteLine($"Su pago por las horas extra es: Lps.{sueldoExtra}");
                Console.WriteLine($"Su pago total es: Lps.{sueldoExtraTotal}");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                 double sueldoHoraNormal = sueldoHora * horasTrabajadas;
                 Console.WriteLine($"El total de horas trabajadas son: {horasTrabajadas} horas.");
                 Console.WriteLine($"Su pago total es: Lps.{sueldoHoraNormal}");
                 Console.WriteLine("No tiene horas extras.");
                 Console.WriteLine("No tiene sueldo extras.");
                 Console.WriteLine("Presione enter para continuar...");
                 Console.ReadKey();            
            }
        }
    }
}