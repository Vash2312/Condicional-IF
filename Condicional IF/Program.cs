using System;

namespace Condicional_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a System Sassano INC.");
            Console.WriteLine("Hola Nesman");
            Console.WriteLine("Introduzca su nombre por favor");

            string nombre = Console.ReadLine();
            
            bool edadb = false;

            if (nombre == "") nombre = "Incognito";
            do
            {
                Console.WriteLine("Por favor Introduzca su edad");
                int edad = 0;
                try
                {
                  edad = int.Parse(Console.ReadLine());
                } catch (FormatException e)
                {
                    Console.WriteLine("Formato Invalido, por favor introduzca un valor numerico. Vuelva a intentarlo:");
                   
                } catch (OverflowException e)
                {
                    Console.WriteLine("Formato Invalido, por favor introduzca un valor mas chico. Vuelva a intentarlo:");
                   
                }
                if (edad > 17) edadb = true;

                if (edad < 18 && edad >0)
                {
                    Console.WriteLine("No cumple los requisitos para seguir operando");
                    Environment.Exit(0);
                }

            } while (!edadb); 

             Console.WriteLine("¿Poseee una cuenta en el Banco? Responda SI o NO");

            bool condicion = false;

            do
            {
                string cuenta = Console.ReadLine();

                int compa = string.Compare(cuenta, "si", true);

                if (compa == 0)
                {
                    Console.WriteLine("Cumple con los requisitos para seguir operando");
                    condicion = true;
                }

                int compa1 = string.Compare(cuenta, "no", true);

                if (compa1 == 0)
                {
                    Console.WriteLine("No cumple los requisitos para seguir operando");
                    Environment.Exit(0);
                }

                if (compa != 0 && compa1 != 0)
                {
                    Console.WriteLine("Respuesta Invalida, por favor responda por SI o por NO");
                }
                } while (!condicion);

              
        inicio:
            
            Console.WriteLine("Bienvenido a nuestro simulador de Inversiones:");
            
            Console.WriteLine("Por favor introduzca el monto a Invertir");
            float dinero = 0;
            bool cash = false;
            do
            {
                try
                {
                    dinero = float.Parse(Console.ReadLine());
                } catch (FormatException ex)
                {
                    Console.WriteLine("Por favor introduce un valor numerico. Ej: 10500. " + ex.Message);
                } catch (OverflowException ex)
                {
                    Console.WriteLine("Valor demasiado largo. Vuelva a intentar:");
                }

                if (dinero > 0) cash = true;
                else Console.WriteLine("Debe ingresar un valor para poder seguir:");
            } while (!cash);

            Console.WriteLine("Introduzca la Tasa Nominal Anual (TNA)");
            float tasa = 0;
            bool tna = false;
            do
            {
                try
                {
                    tasa = float.Parse(Console.ReadLine());
                }catch(FormatException a)
                {
                    Console.WriteLine("Formato invalido, se espera un valor numerico. Vuelva a intentarlo:");
                } catch(OverflowException a)
                {
                    Console.WriteLine("Valor demasiado largo. Vuelva a intentarlo:");
                }

                if (tasa > 0) tna = true;
                else Console.WriteLine("Debe ingresar un valor para poder seguir:");
            } while (!tna);

            Console.WriteLine("Cuantos tiempo (Meses) desea invertir su capital");

            int meses = 0;

            bool mes = false;
            do
            {
                try
                {
                    meses = int.Parse(Console.ReadLine());
                }catch(FormatException m)
                {
                    Console.WriteLine("Formato Invalido, por favor introdusca el tiempo expresado en meses. Ejemplo:1,2,3...");

                }catch (OverflowException m)
                {
                    Console.WriteLine("Error de formato, se espera un valor mas chico. Vuelva a intentar: ");

                }
                if (meses > 0) mes = true;
                else Console.WriteLine("Debes ingresar un valor para poder seguir operando");

            } while (!mes);

            Interes(dinero, tasa, meses, nombre);

            Console.WriteLine("¿Desea seguir Operando? \n1)SI\n2)NO");

            bool seguir = false;

            int resp = 0;

            do
            {
                try
                {
                    resp = int.Parse(Console.ReadLine());

                }catch (FormatException s)
                {
                    Console.WriteLine("Formato Invalido, se espera que eliga una de las opciones anteriores: \n1)SI\n2)NO\nResponda 1 o 2:");

                }
                
                switch (resp)
                {
                    case 1:
                        Console.WriteLine("Gracias por seguir utilizando nuestros servicios.");
                        goto inicio;
                    case 2:
                        Console.WriteLine("Gracias por utilizarnos! Vuelva Pronto.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Intentelo Nuevamente.");
                        break;
                }

            } while (!seguir);
            
        }
        
        static void Interes(float num1, float num2, int num3, string nomb)
        {

            float interesMes = (num1 * num2 * num3) / 1200;

            Console.WriteLine($"El interes generado seria: ${interesMes}");

            Console.WriteLine($"Gracias por utilizarnos {nomb}");

        }
    }
    
}
