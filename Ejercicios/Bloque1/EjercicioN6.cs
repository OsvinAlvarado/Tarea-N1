/*Ejercicio numero 6: Área y perímetro 
- Menú para calcular área y perímetro de: círculo, triángulo, rectángulo y
trapecio. Validar que los valores ingresados sean positivos.*/

using System;
using System.ComponentModel;
using System.Security;

namespace Ejercicios.Bloque1
{
    class Ejercicio_N6_Areaperimetro
    {
        public static void Ejecutar()
        {
            int opcion;
            do
            {   Console.Clear();
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Calcular Área y Perímetro del círculo.");
                Console.WriteLine("2. Calcular Área y Perímetro del Triángulo.");
                Console.WriteLine("3. Calcular Área y Perímetro del rectángulo.");
                Console.WriteLine("4. Calcular Área y Perímetro del trapecio.");
                Console.WriteLine("5. Salir.");
                Console.WriteLine("Ingrese su opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1 :
                            Console.WriteLine("Ingrese el radio del circulo en metros: ");
                            int radio;
                            while(int.TryParse(Console.ReadLine(), out radio) || radio <= 0)
                            {
                                Console.WriteLine("Error. Ingrese un valor valido para el radio: ");
                            }

                            double area = Math.PI * (radio * radio);
                            double perimetro = Math.PI * (2 * radio);

                            Console.WriteLine($"El Área del circulo es: {area:F2}m cuadrados. \n El perimetro es: {perimetro:F2}m");
                            Console.WriteLine("Presione enter para continuar...");
                            Console.ReadKey();
                            break;

                    case 2 :
                            int opcionTriangulo;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("-----Menu Triangulo-----");
                                Console.WriteLine("1. Área y perimetro Triangulo Equilatero.");
                                Console.WriteLine("2. Área y perimetro Triangulo Isocees.");
                                Console.WriteLine("3. Área y perimetro Triangulo Escaleno.");
                                Console.WriteLine("4. Salir.");
                                Console.WriteLine("Ingrese su opcion: ");
                                opcionTriangulo = int.Parse(Console.ReadLine());

                            switch (opcionTriangulo) // SWITCH DEL TRIANGLO
                            {
                                case 1 :
                                        Console.WriteLine("Ingrese la medida de la altura: ");
                                        int alturaTriangulo;
                                        while(!int.TryParse(Console.ReadLine(), out alturaTriangulo) || alturaTriangulo <= 0)
                                        {
                                            Console.WriteLine("Error. Ingrese un valor valido para la altura: ");
                                        }

                                        Console.WriteLine("Ingrese la medida de la base: ");
                                        int baseTriangulo ;
                                        while(!int.TryParse(Console.ReadLine(), out baseTriangulo) || baseTriangulo <= 0)
                                        {
                                            Console.WriteLine("Error. Ingrese un valor valido para la base: ");
                                        }

                                        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

                                        int perimetroTriangulo = baseTriangulo * 3;

                                        Console.WriteLine($"El Área del triangulo es: {areaTriangulo:F2} m^2");
                                        Console.WriteLine($"El Perimetro del triangulo es: {perimetroTriangulo:F2} m");
                                        Console.WriteLine($"Presione enter para continuar...");
                                        Console.ReadKey();
                                        break;

                                case 2 :
                                        Console.WriteLine("Ingrese la medida de la base: ");
                                        int baseTriangulo2;
                                        while(!int.TryParse(Console.ReadLine(), out baseTriangulo2) || baseTriangulo2 <= 0)
                                        {
                                            Console.WriteLine("Error. Ingrese un valor valido para la base: ");
                                        }

                                        Console.WriteLine("Ingrese la medida de uno de sus lados: ");
                                        int ladoTriangulo;
                                        while(!int.TryParse(Console.ReadLine(), out ladoTriangulo) || ladoTriangulo <= 0)
                                        {
                                            Console.WriteLine("Error. Ingrese un valor valido para el lado: ");
                                        }

                                        double h = Math.Sqrt(((ladoTriangulo * ladoTriangulo) - ((baseTriangulo2 / 2) * (baseTriangulo2 / 2))));

                                        double areaTriangulo2 = (baseTriangulo2 * h) / 2;

                                        int perimetroTriangulo2 = baseTriangulo2 + ladoTriangulo * 2;

                                        Console.WriteLine($"El Área del triangulo es: {areaTriangulo2:F2} m^2.");
                                        Console.WriteLine($"El Perimetro del triangulo es: {perimetroTriangulo2:F2} m.");
                                        Console.WriteLine($"Presione enter para continuar...");
                                        Console.ReadKey();
                                        
                                        break;

                                case 3 : 
                                        Console.WriteLine("Escriba la medida del primer lado:");
                                        int lado1;
                                        while (!int.TryParse(Console.ReadLine(), out lado1) || lado1 <= 0)
                                        {
                                            Console.WriteLine("Error. Ingrese un valor valido para el primer lado: ");
                                        }

                                        Console.WriteLine("Escriba la medida del segundo lado:");
                                        int lado2;
                                         while(!int.TryParse(Console.ReadLine(), out lado2) || lado2 <= 0)
                                        {
                                            Console.WriteLine("Error. Ingrese un valor valido para el segundo lado: ");
                                        }

                                        Console.WriteLine("Escriba la medida del tercer lado:");
                                        int lado3;
                                         while(!int.TryParse(Console.ReadLine(), out lado3) || lado3 <= 0)
                                        {
                                            Console.WriteLine("Error. Ingrese un valor valido para el tercer lado: ");
                                        }

                                        int perimetroTriangulo3 = lado1 + lado2 + lado3;

                                        double semiperimetroTriangulo = (lado1 + lado2 + lado3) / 2.0;

                                        double areaTriangulo3 = Math.Sqrt(semiperimetroTriangulo * (semiperimetroTriangulo - lado1) * (semiperimetroTriangulo - lado2) * (semiperimetroTriangulo - lado3));

                                        Console.WriteLine($"El Área del triangulo es: {areaTriangulo3:F2} m^2.");
                                        Console.WriteLine($"El Perimetro del triangulo es: {perimetroTriangulo3:F2} m.");
                                        Console.WriteLine($"Presione enter para continuar...");
                                        Console.ReadKey();
                                        break;           
                            }

                            } while (opcionTriangulo != 4);
                                        break;

                    case 3 : 
                            Console.WriteLine("Ingrese la altura del rectangulo: ");
                            int alturaRectangulo;
                             while(!int.TryParse(Console.ReadLine(), out alturaRectangulo) || alturaRectangulo <= 0)
                            {
                                Console.WriteLine("Error. Ingrese un valor valido para la altura: ");
                            }

                            Console.WriteLine("Ingrese la base del rectangulo: ");
                            int baseRectangulo;
                             while(!int.TryParse(Console.ReadLine(), out baseRectangulo) || baseRectangulo <= 0)
                            {
                                Console.WriteLine("Error. Ingrese un valor valido para la base: ");
                            } 

                            int areaRectangulo = baseRectangulo * alturaRectangulo;

                            int perimetroRectangulo = 2 * baseRectangulo + 2 * alturaRectangulo;

                            Console.WriteLine($"El Área del rectangulo es: {areaRectangulo:F2} m^2.");
                            Console.WriteLine($"El Perimetro del rectangulo es: {perimetroRectangulo:F2} m.");
                            Console.WriteLine($"Presione enter para continuar...");
                            Console.ReadKey();

                            break;

                    case 4 : 
                            Console.WriteLine("Ingrese la altura del trapecio: ");
                            int alturaTrapecio;
                             while(!int.TryParse(Console.ReadLine(), out alturaTrapecio) || alturaTrapecio <= 0)
                            {
                                Console.WriteLine("Error. Ingrese un valor valido para la altura: ");
                            }

                            Console.WriteLine("Ingrese la base mayor del trapecio: ");
                            int baseMayor;
                             while(!int.TryParse(Console.ReadLine(), out baseMayor) || baseMayor <= 0)
                            {
                                Console.WriteLine("Error. Ingrese un valor valido para la base mayor: ");
                            }

                            Console.WriteLine("Ingrese la base menor del trapecio: ");
                            int baseMenor;
                             while(!int.TryParse(Console.ReadLine(), out baseMenor) || baseMenor <= 0)
                            {
                                Console.WriteLine("Error. Ingrese un valor valido para la base menor: ");        
                            }

                            Console.WriteLine("Ingrese el lado 1 del trapecio: ");
                            int l1;
                            while(!int.TryParse(Console.ReadLine(), out l1) || l1 <= 0)
                            {
                                Console.WriteLine("Error. Ingrese un valor valido para el lado 1: ");       
                            }

                            Console.WriteLine("Ingrese el lado 2 del trapecio: ");
                            int l2;
                             while(!int.TryParse(Console.ReadLine(), out l2) || l2 <= 0)
                            {
                                Console.WriteLine("Error. Ingrese un valor valido para el segundo lado: ");        
                            }

                            double areaTrapecio = (baseMayor + baseMenor) * alturaTrapecio / 2; 

                            int perimetroTrapecio = baseMayor + baseMenor + l1 + l2;

                            Console.WriteLine($"El Área del trapecio es: {areaTrapecio:F2} m^2.");
                            Console.WriteLine($"El Perimetro del trapecio es: {perimetroTrapecio:F2} m.");
                            Console.WriteLine($"Presione enter para continuar...");
                            Console.ReadKey();

                            break;
                }
                
            } while (opcion != 5);
        }
    }
}