using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            Console.WriteLine("¿Cuantos discos quieres?");
            int cantidadDiscos;
            cantidadDiscos = int.Parse(Console.ReadLine());

            for (int i = 0; i <= cantidadDiscos; i++)
            {
                Console.WriteLine("¿De que tamaño quieres que sea el disco " + i + "?");
                cantidadDiscos = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("El texto introducido es: " + cantidadDiscos);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
