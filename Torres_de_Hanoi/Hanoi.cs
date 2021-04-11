﻿using System;
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
            if ( a.Top < b.Top ){

                if( a.Size == 0)
                {
                    a.push(b.pop());
                }
                else
                {
                    b.push(a.pop());
                }

            }else{ 
                if ( a.Top > b.Top ){
                    if (b.Size == 0)
                    {
                        b.push(a.pop());
                    }
                    else
                    {
                        a.push(b.pop());
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

                }

            }
            else{ // Sinó es par entra aquí

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
                }

            }

            return m;
        }

    }
}
