using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio del producto: ");

            String precio;
            precio = Console.ReadLine();

            int numPrecio;
            numPrecio = Int16.Parse(precio);

            int iva;
            iva = (numPrecio * 21) / 100;

            int resultado_iva;
            resultado_iva = numPrecio + iva ;

            Console.WriteLine("El precio es: " + precio );
            Console.WriteLine("El IVA es de: " + iva);
            Console.WriteLine("El precio total es: " + resultado_iva);
            Console.ReadLine();

        
        }
    }
}
