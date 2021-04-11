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
            int pesoDisco = 0; // El peso del disco en cada momento que pedimos uno.
            bool pesoCorrecto = false; // Nos dice si el peso introducido es inferior al anterior
            for (int i = 1; i <= cantidadDiscos; i++)
            {
                // Creamos un While para que pregunte el peso del disco mientras no sea inferior al anterior
                while (!pesoCorrecto)
                {
                    // Preguntamos el peso que quiere de disco
                    Console.WriteLine("¿De que tamaño quieres que sea el disco " + i + "?");
                    pesoDisco = int.Parse(Console.ReadLine()); // Añadimos el peso a la variable pesoDisco
                    
                    // Comprovamos si la lista ini está vacía
                    if (ini.isEmpty())
                    {
                        // Si está insertamos el disco directamente
                        ini.push(new Disco(pesoDisco));
                        pesoCorrecto = true;
                    }
                    else // Entramos si la pila ini tiene algún disco
                    {
                        // Preguntamos el peso del disco es inferior al que está ya puesto
                        if (ini.Top > pesoDisco)
                        {
                            pesoCorrecto = true; // Ponemos que el peso introducido es correcto
                            ini.push(new Disco(pesoDisco)); // Creamos un disco y lo insertamos en ini
                        }
                    }
                }

                pesoCorrecto = false;
            }

            Hanoi hanoi = new Hanoi();

            int movimientosHechos = hanoi.iterativo( cantidadDiscos, ini, fin, aux );
            double movimientoRequeridos = Math.Pow(2, cantidadDiscos) - 1;

            Console.WriteLine("Número de discos: " + cantidadDiscos);
            Console.WriteLine("Número de movimentos necesarios mínimos: " + movimientoRequeridos);
            Console.WriteLine("Número de movimentos hechos: " + movimientosHechos);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
