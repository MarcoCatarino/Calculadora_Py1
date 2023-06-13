using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_18.Clases
{
    public class Usuario
    {
        string Nombre { get; set; }
        string ApellidoMaterno { get; set; }
        string ApellidoPaterno { get; set; }
        string Carrera { get; set; }
        int Edad { get; set; }


        public void imprmirPeticion()
        {
            Console.Write("Nombre               > ");
            Nombre = Console.ReadLine();

            Console.Write("\nApellido Materno     > ");
            ApellidoMaterno = Console.ReadLine();

            Console.Write("\nApellido Paterno     > ");
            ApellidoPaterno = Console.ReadLine();

            Console.Write("\nCarrera              > ");
            Carrera = Console.ReadLine();
             
            Console.Write("\nEdad                 > ");
            Edad = int.Parse(Console.ReadLine());

            if (Edad >= 18)
            {
                Console.Clear();
                Calculadora calculadora = new Calculadora();
                calculadora.Calculate();
            }
            else 
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERES MENOR DE EDAD");
                Console.ForegroundColor = ConsoleColor.White;


                Console.ReadKey();
                Console.Clear();
                imprmirPeticion();
            }
        }
    }
}
