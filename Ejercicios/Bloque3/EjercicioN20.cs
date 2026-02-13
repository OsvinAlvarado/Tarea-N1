/*Ejercicio numero 20: Validación de contraseña -
 Solicitar contraseña hasta que cumpla: mínimo 8 caracteres, al
menos una mayúscula, una minúscula, un número y un carácter especial. Indicar qué falta en
cada intento.*/

using System;

namespace Ejercicios.Bloque3
{
    class Ejercicio_N20_ValidacionContrasena
    {
        public static void Ejecutar()
        {
             Console.Clear();
            string contraseña;
            bool valida = false;

            while (!valida)
            {
                Console.Write("Ingrese una contraseña: ");
                contraseña = Console.ReadLine();

                bool tieneMayuscula = false;
                bool tieneMinuscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;

                if (contraseña.Length >= 8)
                {
                    foreach (char c in contraseña)
                    {
                        if (char.IsUpper(c))
                            tieneMayuscula = true;
                        else if (char.IsLower(c))
                            tieneMinuscula = true;
                        else if (char.IsDigit(c))
                            tieneNumero = true;
                        else
                            tieneEspecial = true;
                    }
                }

                valida = true;

                if (contraseña.Length < 8)
                {
                    Console.WriteLine("Debe tener al menos 8 caracteres.");
                    valida = false;
                }
                if (!tieneMayuscula)
                {
                    Console.WriteLine("Falta una letra mayúscula.");
                    valida = false;
                }
                if (!tieneMinuscula)
                {
                    Console.WriteLine("Falta una letra minúscula.");
                    valida = false;
                }
                if (!tieneNumero)
                {
                    Console.WriteLine("Falta un número.");
                    valida = false;
                }
                if (!tieneEspecial)
                {
                    Console.WriteLine("Falta un carácter especial.");
                    valida = false;
                }

                if (valida)
                {
                    Console.WriteLine(" Contraseña válida.");
                }
                else
                {
                    Console.WriteLine("\nIntente de nuevo...\n");
                }
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}