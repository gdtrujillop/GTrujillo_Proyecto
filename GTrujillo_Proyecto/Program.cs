using System.Collections;
using System.Text.RegularExpressions;

namespace GTrujillo_Proyecto
{
    internal class Program
    {
        public static int contCoins = 0;
        public static int contLong = 0;
        public static int contTotal = 0;
        public static ArrayList historialConversiones = new ArrayList();

        static void Main(string[] args)
        {
             MenuPrincipal();

         }

            static void MenuPrincipal()
            {
            Console.WriteLine("***********************");
            Console.WriteLine("SISTEMA DE CONVERSIÓN");
            Console.WriteLine("***********************");
            Console.WriteLine("-- Version 9.6.1--\n");
            Console.WriteLine("MENU PRINCIPAL:\n");
            Console.WriteLine("1. PARA CONVERSION DE MONEDAS");
            Console.WriteLine("2. PARA CONVERSION DE LONGITUD");
            Console.WriteLine("3. PARA REPORTE DEL DIA");
            Console.WriteLine("4. PARA SALIR DEL SISTEMA\n");

            Console.WriteLine("INGRESAR OPCION:");
            int opcion = Convert.ToInt16(Console.ReadLine());
            
            switch (opcion)
            {

                case 1:
                    Console.WriteLine("SI DESEA CONVERTIR SOLES A DOLARES, MARQUE 1");
                    Console.WriteLine("SI DESEA CONVERTIR SOLES A EUROS, MARQUE 2\n");
                    Console.WriteLine("INGRESAR OPCION:");
                    int opcion1 = Convert.ToInt16(Console.ReadLine());

                    switch (opcion1)
                    {
                        case 1:
                            Console.WriteLine("INGRESAR MONTO EN SOLES PARA CONVERTIRLO A DOLARES:");
                            double soles = Convert.ToDouble(Console.ReadLine());
                            double resul1 = Double.Round(soles / 3.77);
                            Console.WriteLine("EL RESULTADO DE LA CONVERSIÓN DE SOLES A DOLARES ES: " + resul1 + " DOLARES\n");
                            contCoins++;
                            contTotal++;
                            historialConversiones.Add(contTotal+".- " + soles +" SOLES A DOLARES ES : $"+ resul1);
                            MenuPrincipal();
                            break;
                        
                        case 2:
                            Console.WriteLine("INGRESAR MONTO EN SOLES PARA CONVERTIRLO A EUROS:");
                            double soles2 = Convert.ToDouble(Console.ReadLine());
                            double resul2 = Double.Round(soles2 / 4.23);
                            Console.WriteLine("EL RESULTADO DE LA CONVERSIÓN DE SOLES A EUROS ES: " + resul2 + " EUROS\n");
                            contCoins++;
                            contTotal++;
                            historialConversiones.Add(contTotal + ".- "+soles2 + " SOLES A EUROS ES : €" + resul2);
                            MenuPrincipal();
                            break;
                        default:
                            Console.WriteLine("XXX INGRESAR OPCION CORRECTA XXX\n\n");
                            MenuPrincipal();
                            break;
                    }


                    break;

                case 2:

                    Console.WriteLine("SI DESEA CONVERTIR CENTIMETROS A METROS, MARQUE 1");
                    Console.WriteLine("SI DESEA CONVERTIR METROS A KILOMETROS, MARQUE 2");
                    Console.WriteLine("SI DESEA CONVERTIR KILOMETROS A METROS, MARQUE 3\n");
                    Console.WriteLine("INGRESAR OPCION:");

                    int opcion2 = Convert.ToInt16(Console.ReadLine());
                    
                    if (opcion2 == 1)
                    {
                        Console.WriteLine("INGRESAR VALOR EN CENTIMETROS:");
                        double cm = Convert.ToDouble(Console.ReadLine());
                        double resul2_1 = (cm / 100);
                        if (cm < 100)
                        {
                            Console.WriteLine("EL VALOR EN CENTIMETROS DEBE SER MAYOR IGUAL A 100 CM:\n\n");
                            MenuPrincipal();
                        }
                        else
                        {
                            Console.WriteLine("EL RESULTADO DE LA CONVERSIÓN DE CENTRIMETROS A METROS ES: " + resul2_1 + " METROS\n");
                            contLong++;
                            contTotal++;
                            historialConversiones.Add(contTotal + ".- "+cm +" CM A METROS ES  : "+ resul2_1+ " METROS.");
                            MenuPrincipal();
                        }

                    }
                    else if (opcion2 == 2)
                    {
                        Console.WriteLine("INGRESAR VALOR EN METROS:");
                        double mt = Convert.ToDouble(Console.ReadLine());
                        double resul2_2 = (mt / 1000);
                        if (mt < 1000)
                        {
                            Console.WriteLine("EL VALOR EN METROS DEBE SER MAYOR IGUAL A 1000 METROS:\n\n");
                            MenuPrincipal();

                        }
                        else
                        {
                            Console.WriteLine("EL RESULTADO DE LA CONVERSIÓN DE METROS A KM ES: " + resul2_2 + " KILOMETROS\n");
                            contLong++;
                            contTotal++;
                            historialConversiones.Add(contTotal + ".- " + mt + " METROS A KM ES : "+resul2_2+" KILOMETROS.");
                            MenuPrincipal();
                        }
                    }
                    else if (opcion2 == 3)
                    {
                        Console.WriteLine("INGRESAR VALOR EN KILOMETROS:");
                        double km = Convert.ToDouble(Console.ReadLine());
                        double resul2_3 = (km * 1000);
                        if (km <1 || km > 100)
                        {
                            Console.WriteLine("EL VALOR EN KILOMETROS DEBE SER MAYOR A 0 Y MENOR A 100:\n\n");
                            MenuPrincipal();
                        }
                        else
                        {
                            Console.WriteLine("EL RESULTADO DE LA CONVERSIÓN DE KM A METROS ES: " + resul2_3 + " METROS\n");
                            contLong++;
                            contTotal++;
                            historialConversiones.Add(contTotal + ".- "+ km + " KM A METROS ES : "+resul2_3+ " METROS.");
                            MenuPrincipal();
                        }
                    }
                    else
                    {
                        Console.WriteLine("XXX INGRESAR OPCION CORRECTA XXX\n\n");
                        MenuPrincipal();
                    }
                break; // break de case 2

                case 3:
                    Console.WriteLine("\n");
                    Console.WriteLine("******* REPORTE DE GESTIONES DEL DÍA *******");
                    Console.WriteLine("--------------------------------------------");
                    MostrarElementos(historialConversiones);
                    Console.WriteLine("********************************************\n");
                    Console.WriteLine("TOTAL DE CONVERSIONES DE MONEDA: "+ contCoins);
                    Console.WriteLine("TOTAL DE CONVERSIONES DE LONGITUD: " + contLong);
                    Console.WriteLine("TOTAL DE CONVERSIONES: " + contTotal);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("----- OPCION INCORRECTA -----\n\n\n");
                    MenuPrincipal();
                    break;
            }

        } // aqui termina el metodo MenuPrincipal

        static void MostrarElementos(ArrayList lista)
        {
            foreach (var operacion in lista)
            {
                Console.WriteLine(operacion);
            }

        }
    }
}
