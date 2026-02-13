/*ejercicio numero 10: Sistema de calificaciones UNAH 
- Ingresar nota de 0-100 y mostrar: letra (A, B, C, D, F),
descripción y si aprobó o reprobó. Incluir validación de rango.*/

using System;
using System.Runtime.CompilerServices;

namespace Ejercicios.Bloque2
{
    class Ejercicio_N10_SistemaCalificaciones
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su calificacion: ");
            int calificacion;
            while(!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 0 || calificacion > 100)//Aqui valido el rango de la calificacion
            {
                Console.WriteLine("Error. Ingrese una calificacion correcta (0-100): ");//Si ingresa mal la calificacion, salta este error.
            }

            if (calificacion >= 90)//Aqui se clasifican las notas.
            {
                Console.WriteLine("Letra: A.");
                Console.WriteLine("Descripcion: Excelente.");
                Console.WriteLine("Estado: Aprobado.");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
                
            }else if(calificacion >= 80 && calificacion <= 89)
            {
                Console.WriteLine("Letra: B.");
                Console.WriteLine("Descripcion: Bueno.");
                Console.WriteLine("Estado: Aprobado.");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
            }else if(calificacion >= 65 && calificacion <= 79)
            {
                Console.WriteLine("Letra: C.");
                Console.WriteLine("Descripcion: Regular.");
                Console.WriteLine("Estado: Aprobado.");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
            }else if(calificacion >= 60 && calificacion <= 64)
            {
                Console.WriteLine("Letra: D.");
                Console.WriteLine("Descripcion: Deficiente.");
                Console.WriteLine("Estado: Reprobado.");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
            }else if(calificacion <= 59)
            {
                Console.WriteLine("Letra: F.");
                Console.WriteLine("Descripcion: Reprobado.");
                Console.WriteLine("Estado: Reprobado.");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
            }
        }
    }
}