/*Ejercicio Numero 1:
Calculadora de IMC - Solicitar peso (kg) y altura (m), calcular el índice de masa corporal y
mostrar en qué categoría se encuentra (bajo peso, normal, sobrepeso, obesidad).
*/
using System;

namespace Ejercicios.Bloque1
{
    class Ejercicio_N1_IMC
    {
        public static void Ejecutar()//Aqui creamos EL METODO Ejecutar
        {
            
            
                //Aqui le pedimos al usuario que ingrese su peso
                Console.WriteLine("Ingrese su peso en kg:");
                double peso;
                while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
                    {
                        Console.Write("Error. Ingrese un valor valido para el peso: ");
                    }

                //Aqui le pedimos al usuiario que ingrese su altura
                Console.WriteLine("Ingrese su altura en metros: ");
                double altura;
                while(!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
                {
                    Console.Write("Error. Ingrese un valor valido para la altura: ");
                }

                //Calculamos el IMC
                double imc = peso/(altura * altura);

                //Mostramos el IMC a el usuraio
                Console.WriteLine($"Su IMC es:{imc:F2}");
                if(imc < 18.5)
                {
                    Console.WriteLine("Usted esta en la categoria de: bajo peso");
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadKey();

                }else if(imc < 25)
                {
                    Console.WriteLine("Usted esta en la categoria de: peso normal");
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadKey();

                }else if(imc < 30)
                {
                    Console.WriteLine("Usted esta en la categoria de: sobrepeso");
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Usted esta en la categoria de: Obesidad");
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadKey();
                }
            }
            
            
                
            
        }
    }

