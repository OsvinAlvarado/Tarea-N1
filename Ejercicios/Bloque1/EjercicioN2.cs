/*Ejercicio Numero2: Conversión de temperatura -
 Crear un menú que permita convertir entre Celsius, Fahrenheit y
Kelvin. El usuario elige la conversión deseada.
*/

using System;

namespace Ejercicios.Bloque1
{
    class Ejercicio_N2_ConversionTemperatura //Creamos la clase del ejercicio 2
    {
        public static void Ejecutar() // creamos un metodo llamado ejecutar que resuelve el ejercicio
        {
            int opcion;
            do 
            {
                Console.Clear();//El menu del ejercicio
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Convertir C a F");
                Console.WriteLine("2. Convertir F a C");
                Console.WriteLine("3. Convertir C a K");
                Console.WriteLine("4. Convertir K a C");
                Console.WriteLine("5. Salir.");
                Console.WriteLine("Ingrese su opcion: ");
                opcion = int.Parse(Console.ReadLine()); // aqui se registra la respuesta

                double grados = 0; // se inicializa la variable grados
                if(opcion != 5) // un if que evita que se pregunte la temperatura si se quiere salir.
                {
                    Console.WriteLine("Ingrese temperatura: "); // se toma la temperatura
                    while(!double.TryParse(Console.ReadLine(), out grados))
                    {
                        Console.WriteLine("Error. Ingrese un valor valido para grados: ");
                    }
                }
                    
                double resultado = 0;

                switch (opcion)
                {
                    case 1 : 
                            resultado = (grados * 9/5) +32; 
                            Console.WriteLine($"La temperatura en Fahrenheit son {resultado} grados.");
                            Console.Write("\nPresione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                    case 2 : 
                            resultado = (grados - 32) * 5/9; 
                            Console.WriteLine($"La temperatura en Celsius son {resultado:F2} grados.");
                            Console.Write("\nPresione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                    case 3 : 
                            resultado = grados + 273.15; 
                            Console.WriteLine($"La temperatura en Kelvin son {resultado:F2} grados.");
                            Console.Write("\nPresione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                    case 4 :
                            resultado = grados -273.15; 
                            Console.WriteLine($"La temperatura en Celsius son {resultado} grados.");
                            Console.Write("\nPresione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                }

            } while (opcion != 5);
                
        }
    }
}