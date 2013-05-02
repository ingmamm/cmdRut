using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruta: " + Environment.CurrentDirectory);

            int dV=0,i=2,num;
            int digito;
            char charDV;
          
            if (args.Length > 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen; //estilo retro
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();


                foreach (string parametro in args)
                {
                    int count = args[0].Length;
                   
                    {
                         num = int.Parse(parametro);


                        for (int j=0; j<=count ; j++)
                        {
                            digito = num % 10; //obtiene el ultimo digito del numero y se guarda en digito 
                            num /= 10;          //se divide el numero por 10 para reducir el nuemro en un digito
                            
                            dV += digito * i; // se multiplica el digito segun el modulo 11 y se guarda el resultado en dV
                            i++;
                            if (i == 8)   //si i vale 8  se debe volver al valor 2 (modulo 11)
                            {
                                i = 2;
                            }
                            
                            if (j == count) // si j es igual a count se acabaron los numeros, se calcula el modulo 11 a dV y se le resta a 11 el dV 
                            {
                                dV = dV % 11;
                                dV = 11 - dV;
                        
                                break;
                            }
                        }
                       
                    }
                    switch(dV)
                    {
                        case 11: charDV= '0'; 
                                 break;

                        case 10: charDV= 'K';
                                 break;

                        case 9: charDV = '9';
                                break;

                        case 8: charDV = '8';
                                break;

                        case 7: charDV = '7';
                                break;

                        case 6: charDV = '6';
                            break;

                        case 5: charDV = '5';
                            break;

                        case 4: charDV = '4';
                            break;

                        case 3: charDV = '3';
                            break;

                        case 2: charDV = '2';
                                break;

                        case 1: charDV = '1';
                                break;

                        default: charDV = 'E';
                            break;     

                                              
                    }

                    Console.WriteLine("El código verificador del Rut {0}-{1} ", parametro,charDV );
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue; //estilo blueScrn
                Console.WriteLine("No se han encontrado parametros de envio.");
            }
                
               
            
 

            Console.ReadKey();
        }

    }
}
