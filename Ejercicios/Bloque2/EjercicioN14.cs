/*Ejercicio numero 14: Cajero automático - 
Simular retiro: verificar que el monto sea múltiplo de 20, no exceda el
saldo (inicializado en código) y mostrar desglose de billetes entregados.*/

using   System;

 namespace Ejercicios.Bloque2
 {
    class Ejercicio_N14_CajeroAutomatico
    {
        public static void Ejecutar()
        {
            Console.Clear();
            int saldo = 50000;
            Console.WriteLine("Ingrese la cantidad a retirar: ");
            int retiro;
            while(!int.TryParse(Console.ReadLine(), out retiro) || retiro % 20 != 0 || retiro <= 0 || retiro > saldo)
            {
                Console.WriteLine("Error. Ingrese una cantidad valida a retirar: ");
            }

            saldo -= retiro;
            
            int[] billetes = {500, 200, 100, 20};

            foreach(int billete in billetes)
            {
                int cantidad = retiro/billete;

                if(cantidad > 0)
                {
                    Console.WriteLine($"{cantidad} billete(s) de Lps. {billete}");
                    retiro = retiro % billete;
                    
                }
            }
                    Console.WriteLine($"\nSaldo restante: Lps. {saldo}");
                    Console.Write("\nPresione enter para continuar... ");
                    Console.ReadKey();
                    
        }
    }
 }