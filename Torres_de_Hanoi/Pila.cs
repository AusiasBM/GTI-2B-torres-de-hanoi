using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    public class Pila
    {
        public int Size { get; set; } // Cantidad de elementos que tiene la pila
        public int Top { get; set; } // Valor del elemento más alto de la lista

        public List<Disco> Elementos = new List<Disco>(); // Lista de los discos que tiene la pila

        // Permite colocar un disco a la pila
        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;
            Top = d.Valor;
        }

        // Extrae el disco de la parte superior de la pila
        public Disco pop()
        {
            Disco eliminado = Elementos[Size - 1];
            Elementos.Remove(Elementos[Size - 1]);
            Size--; // Restamos uno al tamaño de la lista
            if (Size == 0) // Comprobamos si la lista está vacía
            {
                // Si está vacía, Top será 0
                Top = 0;
            }
            else
            {
                // Sinó Top es el siguiente disco
                Top = Elementos[Size - 1].Valor;
            }
            return eliminado;
        } 
            

        // Nos dice si la pila está vacía o no.
        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
        }

    }
}
