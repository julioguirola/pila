using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Pila
{
    class Pila<T>
    {
    	public Nodo<T> tope;

        public Pila()
        {
            tope = null;
        }
        
        public Pila(T info)
        {
        	tope = new Nodo<T>(info);
        }

        public void Push(T valor)
        {
            Nodo<T> aux = new Nodo<T>();
            aux.Info = valor;
            if (tope == null)
            {
                tope = aux; // se asigna aux como unico nodo
                aux.Prox = null; // como solo hay un dato, el puntero apunta a null
            }
            else
            {
                // si la pila no esta vacia el puntero se inserta arriba de la pila
                // es decir, en el tope
                aux.Prox = tope;
                tope = aux;
            }
        }

        public int Cantidad()
        {
            Nodo<T> puntero = new Nodo<T>();
            puntero = tope;
            int cant = 0;
            while (puntero != null)
            {
                cant++;
                puntero = puntero.Prox;
            }
            return cant;
        }

        public void Mostrar()
        {
            Nodo<T> puntero;
            puntero = tope;
            Console.WriteLine("{0}", puntero.Info);
            // se corre el puntero de tope a el fondo
            while (puntero.Prox != null)
            {
                puntero = puntero.Prox;
                Console.WriteLine("{0}", puntero.Info);
            }
        }

        public T Pop()
        { 
           T valor = default(T);
           if (tope == null)
           {
               Console.WriteLine("Pila Vacia");
           }
           else
           {
               //se elimina el ultimo en entrar y se retorna el valor que se elimina
               valor = tope.Info;
               tope = tope.Prox;
           }
           return valor;
        }

        //
        //Ejercicios para la preparación 
        //
        

        public void eliminarElm(int pos){
            if (pos < 0 || pos >= Cantidad() ){
                Console.WriteLine("Posicion invalida");
                return;
            }
            Nodo<T> aux = tope;
            if (pos == 0){
                Pop();
                return;
            }
            for (int i = 1; i < pos; i++)
            {
                aux = aux.Prox;
            }
            aux.Prox = aux.Prox.Prox;
        }
    }
}
