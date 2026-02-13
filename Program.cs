using System.Collections;
using System.ComponentModel.Design;
using Ejercicios.Bloque1;
using Ejercicios.Bloque2;
using Ejercicios.Bloque3;
using Ejercicios.Bloque4;
class Program
{
    static void Main()
    {
        int opcion;
        do // do While Principal
        {
            Console.Clear();
            Console.WriteLine("-----Menu-----"); //menu Principal
            Console.WriteLine("1. Bloque 1.");
            Console.WriteLine("2. Bloque 2.");
            Console.WriteLine("3. Bloque 3.");
            Console.WriteLine("4. Bloque 4.");
            Console.WriteLine("5. Bloque 5.");
            Console.WriteLine("6.Salir");
            Console.WriteLine("Ingrese su opcion: ");
            opcion = int.Parse(Console.ReadLine());
            

            switch (opcion)//Switch Principal
            {
                case 1 : 
                        int OpcionBloque1;
                        do // Do while del bloque 1
                        {
                            Console.Clear();
                            Console.WriteLine("-----Menu Bloque 1-----");// Menu del bloque 1
                            Console.WriteLine("1.Ejercicio N1.");
                            Console.WriteLine("2.Ejercicio N2.");
                            Console.WriteLine("3.Ejercicio N3.");
                            Console.WriteLine("4.Ejercicio N4.");
                            Console.WriteLine("5.Ejercicio N5.");
                            Console.WriteLine("6.Ejercicio N6.");
                            Console.WriteLine("7.Ejercicio N7.");
                            Console.WriteLine("8.Ejercicio N8.");
                            Console.WriteLine("9. Salir");
                            Console.WriteLine("Ingrese su Opcion:");
                            OpcionBloque1 = int.Parse(Console.ReadLine());

                        switch (OpcionBloque1)
                        {
                            case 1 :
                                    Ejercicio_N1_IMC.Ejecutar();
                                    break;

                            case 2 : 
                                    Ejercicio_N2_ConversionTemperatura.Ejecutar();
                                    break;
                            case 3 :
                                    Ejercicio_N3_DesgloseBilletes.Ejecutar();
                                    break;
                            case 4 :
                                    Ejercicio_N4_Calculadora.Ejecutar();
                                    break;
                            case 5 : 
                                    Ejercicio_N5_tiempoTranscurrido.Ejecutar();
                                    break;
                            case 6 : 
                                    Ejercicio_N6_Areaperimetro.Ejecutar();
                                    break;    
                            case 7 : 
                                    Ejercicio_N7_ConversionUnidades.Ejecutar();
                                    break;
                            case 8 : 
                                    Ejercicio_N8_CalculoSalario.Ejecutar();
                                    break;
                        }
                            
                        } while (OpcionBloque1 != 9);
                        break;
                case 2 :
                        int OpcionBloque2;
                        do // do while del bloque 2
                        {
                            Console.Clear();
                            Console.WriteLine("-----Menu Bloque 2-----");//Menu del bloque 2
                            Console.WriteLine("1. Ejercicio N9");
                            Console.WriteLine("2. Ejercicio N10");
                            Console.WriteLine("3. Ejercicio N11");
                            Console.WriteLine("4. Ejercicio N12");
                            Console.WriteLine("5. Ejercicio N13");
                            Console.WriteLine("6. Ejercicio N14");
                            Console.WriteLine("7.Salir");
                            Console.WriteLine("Ingrese su Opcion:");
                            OpcionBloque2 = int.Parse(Console.ReadLine());

                            switch (OpcionBloque2)
                            {
                                case 1 :
                                        Ejercicio_N9_ClasificacionDatos.Ejecutar();
                                        break;
                                case 2 :
                                        Ejercicio_N10_SistemaCalificaciones.Ejecutar();
                                        break;
                                case 3 :
                                        Ejercicio_N11_CalculadoraDescuentos.Ejecutar();
                                        break;
                                case 4 :
                                        Ejercicio_N12_AñoBisiestoMes.Ejecutar();
                                        break;
                                case 5 :
                                        Ejercicio_N13_ValidarFecha.Ejecutar();
                                        break;
                                case 6 :
                                        Ejercicio_N14_CajeroAutomatico.Ejecutar();
                                        break;
                                
                            }

                        } while (OpcionBloque2 != 7); 
                        break;

                case 3 : 
                        int OpcionBloque3;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-----Menu Bloque 3-----");
                            Console.WriteLine("1. Ejercicio N15.");
                            Console.WriteLine("2. Ejercicio N16.");
                            Console.WriteLine("3. Ejercicio N17.");
                            Console.WriteLine("4. Ejercicio N18.");
                            Console.WriteLine("5. Ejercicio N19.");
                            Console.WriteLine("6. Ejercicio N20.");
                            Console.WriteLine("7. Ejercicio N21.");
                            Console.WriteLine("8. Ejercicio N22.");
                            Console.WriteLine("9. Salir.");
                            Console.WriteLine("Ingrese su Opcion:");
                            OpcionBloque3 = int.Parse(Console.ReadLine());

                            switch (OpcionBloque3)
                            {
                                case 1: 
                                        Ejercicio_N15_TablaMultiplicar.Ejecutar();
                                        break;
                                case 2: 
                                        Ejercicio_N16_PrimosRango.Ejecutar();
                                        break;
                                case 3: 
                                        Ejercicio_N17_SerieFibonacci.Ejecutar();
                                        break;
                                case 4: 
                                        Ejercicio_N18_FactorialCombinaciones.Ejecutar();
                                        break;
                                case 5: 
                                        Ejercicio_N19_JuegoAdivinanza.Ejecutar();
                                        break;
                                case 6: 
                                        Ejercicio_N20_ValidacionContrasena.Ejecutar();
                                        break;
                                case 7: 
                                        Ejercicio_N21_PatronAsteriscos.Ejecutar();
                                        break;
                                case 8: 
                                        Ejercicio_N22_CalculadoraMenu.Ejecutar();
                                        break;
                            }
                        } while (OpcionBloque3 != 9);

                        break;

                case 4 :
                        int OpcionBloque4;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-----Menu Bloque 4-----");
                            Console.WriteLine("1. Ejercicio N23.");
                            Console.WriteLine("2. Ejercicio N24.");
                            Console.WriteLine("3. Ejercicio N25.");
                            Console.WriteLine("4. Ejercicio N26.");
                            Console.WriteLine("5. Ejercicio N27.");
                            Console.WriteLine("6. Salir.");
                            Console.WriteLine("Ingrese su Opcion:");
                            OpcionBloque4 = int.Parse(Console.ReadLine());

                            switch (OpcionBloque4)
                            {
                                case 1: 
                                        Ejercicio_N23_EstadisticasCalificaciones.Ejecutar();
                                        break;
                                case 2: 
                                        Ejercicio_N24_BusquedaOrdenamiento.Ejecutar();
                                        break;
                                case 3: 
                                        Ejercicio_N25_RotacionArreglo.Ejecutar();
                                        break;
                                case 4: 
                                        Ejercicio_N26_FrecuenciaElementos.Ejecutar();
                                        break;
                                case 5: 
                                        Ejercicio_N27_TemperaturasSemana.Ejecutar();
                                        break;
                            }
                        } while (OpcionBloque4 != 6);
                        break;

                case 5: 
                        int OpcionBloque5;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-----Menu Bloque 5-----");
                            Console.WriteLine("1. Ejercicio N28.");
                            Console.WriteLine("2. Ejercicio N29.");
                            Console.WriteLine("3. Ejercicio N30.");
                            Console.WriteLine("4. Salir.");
                            Console.WriteLine("Ingrese su Opcion:");
                            OpcionBloque5 = int.Parse(Console.ReadLine());

                            switch (OpcionBloque5)
                            {
                                case 1: 
                                        Ejercicio_N28_MatrizNotasParcial.Ejecutar();
                                        break;
                                case 2: 
                                        Ejercicio_N29_Gato.Ejecutar();
                                        break;
                                case 3: 
                                        Ejercicio_N30_InventarioSimple.Ejecutar();
                                        break;
                            }
                        } while (OpcionBloque5 != 4);

                        break;
            }
            
        } while (opcion != 6);
    }
}