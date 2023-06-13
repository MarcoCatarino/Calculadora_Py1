using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_18.Clases
{
    public class Calculadora
    {
        public void Calculate()
        {
            string opcion;

            int num1, num2;

            Console.WriteLine("     OPCIONES =\n");
            Console.WriteLine("1. SUMA");
            Console.WriteLine("2. RESTA");
            Console.WriteLine("3. MULTIMPLICACION");
            Console.WriteLine("4. DIVISION\n");

            Console.Write(">  ");
            opcion = Console.ReadLine();

            switch (opcion) 
            {
                case "1":
                case "Suma":
                case "suma":

                    Console.Clear();

                    Console.Write("Escribe tu 1er numero    > ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Escribe tu 2ndo numero:  > ");
                    num2 = int.Parse(Console.ReadLine());

                    int respuestaS = num1 + num2;

                    Console.WriteLine("Tu respues es = " + respuestaS);

                    Console.ReadLine();
                    Console.Clear();
                    Calculate();

                    break;


                case "2":
                case "Resta":
                case "resta":

                    Console.Clear();

                    Console.Write("Escribe tu 1er numero    > ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Escribe tu 2ndo numero:  > ");
                    num2 = int.Parse(Console.ReadLine());

                    int respuestaR = num1 - num2;

                    Console.WriteLine("Tu respues es = " + respuestaR);

                    Console.ReadLine();
                    Console.Clear();
                    Calculate();

                    break;


                case "3":
                case "Multiplicacion":
                case "multiplicacion":

                    Console.Clear();

                    Console.Write("Escribe tu 1er numero    > ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Escribe tu 2ndo numero:  > ");
                    num2 = int.Parse(Console.ReadLine());

                    int respuestaM = num1 * num2;

                    Console.WriteLine("Tu respues es = " + respuestaM);

                    Console.ReadLine();
                    Console.Clear();
                    Calculate();

                    break;


                case "4":
                case "Dividir":
                case "dividir":

                    Console.Clear();

                    Console.Write("Escribe tu 1er numero    > ");
                    float num3 = float.Parse(Console.ReadLine());

                    Console.Write("Escribe tu 2ndo numero:  > ");
                    float num4 = float.Parse(Console.ReadLine());

                    float respuestaD = num3 / num4;

                    Console.WriteLine("Tu respues es = " + respuestaD);

                    Console.ReadLine();
                    Console.Clear();
                    Calculate();

                    break;


                default:
                    
                    Console.WriteLine("OPCION INVALIDA");
                    Console.ReadKey();
                    Console.Clear();
                    Calculate();
                    
                    break;
            }
        }
    }
}
