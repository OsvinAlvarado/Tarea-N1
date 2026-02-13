/*Ejercicio N9 : Clasificación de triángulos -
 Dados tres lados, determinar si forman un triángulo válido y
clasificarlo (equilátero, isósceles, escaleno) y por sus ángulos (rectángulo, acutángulo,
obtusángulo).*/

using System;

namespace Ejercicios.Bloque2
{
    class Ejercicio_N9_ClasificacionDatos
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la medida del primer lado: ");
            int l1;
            while(!int.TryParse(Console.ReadLine(), out l1) || l1 <= 0)
            {
                Console.WriteLine("Error. Ingrese un numero valido para el lado 1: ");
            }

            Console.WriteLine("Ingrese la medida del segundo lado: ");
            int l2;
            while(!int.TryParse(Console.ReadLine(), out l2) || l2 <= 0)
            {
                Console.WriteLine("Error. Ingrese un numero valido para el lado 2: ");

            }
            Console.WriteLine("Ingrese la medida del tercer lado: ");
            int l3;
            while(!int.TryParse(Console.ReadLine(), out l3) || l3 <= 0)
            {
                Console.WriteLine("Error. Ingrese un numero valido para el lado 3: ");

            }

            if((l1 + l2) > l3 && (l1 + l3 > l2) && (l2 + l3 > l1))
            {
                
                Console.WriteLine($"Es un triangulo {PorSuLado(l1, l2, l3)}");
                Console.WriteLine($"Y por sus angulos es un :  {PorSuAngulo(l1, l2, l3)}");
                Console.Write("Presione enter para continuar ...");
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("Error. Ingresa valores validos para crear un triangulo: ");
            }


        }

        public static string PorSuLado(int a, int b, int c)
        {
            if ( a == b && b == c)
            {
                return "Equilatero";
            } 
            if (a == b || a == c || b == c)
            {
                return "Isoceles";
            }

            return "Escaleno";

        }

        public static string PorSuAngulo(int a, int b, int c)
        {
            // Elevamos al cuadrado
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            if ( a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2)
            {
                return "Rectangulo";
            }
            if ( a2 + b2 < c2 || a2 + c2 < b2 || b2 + c2 < a2)
            {
                return "Obtusangulo";
            }

            return "Acutangulo";
        }
    }
}