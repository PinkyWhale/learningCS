using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");

            String txtIngreso;

            txtIngreso = Console.ReadLine();

            int numIngreso = Int16.Parse(txtIngreso); // Parseo de 

            int resultado;

            resultado = numIngreso * 2;

            Console.WriteLine("La multiplicacion x 2 del nuemro es: " + resultado);
            Console.WriteLine("Pausa, pulse enter para terminar.");
            Console.ReadLine();
        }
    }
}
