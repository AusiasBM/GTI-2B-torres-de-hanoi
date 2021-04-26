using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    public class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if ( a.Top < b.Top ) { // Comprobamos si a es menor a b

                if (a.isEmpty()) // Comprobamos si a está vacia
                {
                    a.push(b.pop()); // En caso de que esté vacia significa que a no es menor a b, sino que a es 0
                }
                else
                {
                    b.push(a.pop()); // Sino a si que es menor a b
                }

            }else{ 
                if ( a.Top > b.Top) // Comprobamos si b es menor a a
                { 

                    if (b.isEmpty()) // Comprobamos si b está vacia
                    {
                        b.push(a.pop()); // En ese caso b no es menor a a
                    }
                    else
                    {
                        a.push(b.pop()); // Si está llena b es menor a a
                    }
                    
                } 
            }
        }

        /* n Discos
         * ini pila inicial
         * fin pila final
         * aux pila auxiliar
         * */
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0; // Declaramos m, será el número de movimientos utilizados.

            if ( n % 2 == 0  ){ // Comprovamos si n es par

                Console.WriteLine("Es par");
                Console.ReadKey();
                // Mientras no haya solución se hace el while
                while (fin.Size != n)
                {
                    mover_disco(ini, aux); m++; // Movemos disco de ini a aux o de aux a ini y sumamos 1 a m.
                    Console.WriteLine("Movemos disco de ini a aux");
                    if (fin.Size == n) break;
                    mover_disco(ini, fin); m++; // Movemos disco de ini a fin o de fin a ini y sumamos 1 a m.
                    Console.WriteLine("Movemos disco de ini a fin");
                    if (fin.Size == n) break;
                    mover_disco(aux, fin); m++; // Movemos disco de aux a ini o de ini a aux y sumamos 1 a m.
                    Console.WriteLine("Movemos disco de aux a fin");

                    //Console.ReadKey();
                }

            }
            else{ // Sinó es par entra aquí

                Console.WriteLine("Es impar");
                Console.ReadKey();
                // Mientras no haya solución se hace el while
                while (fin.Size != n)
                {
                    mover_disco(ini, fin); m++; // Movemos disco de ini a fin o de fin a ini y sumamos 1 a m.
                    Console.WriteLine("Movemos disco de ini a fin");
                    if ( fin.Size == n ) break;
                    
                    mover_disco(ini, aux); m++; // Movemos disco de ini a aux o de aux a ini y sumamos 1 a m.
                    Console.WriteLine("Movemos disco de ini a aux");
                    if (fin.Size == n ) break;
                    
                    mover_disco(aux, fin); m++; // Movemos disco de aux a ini o de ini a aux y sumamos 1 a m.
                    Console.WriteLine("Movemos disco de aux a fin");

                    //Console.ReadKey();
                }

            }

            return m;
        }

    }
}
