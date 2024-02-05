using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Pila
{
    class Program
    {
        //
        //Ejercicios para la preparación 
        //

        static void invertirPila(ref Pila<string> pila){
            Pila<string> nueva= new Pila<string>();
            int cant = pila.Cantidad();
            for (int i = 0; i < cant; i++)
            {
                nueva.Push(pila.Pop());
            }

            pila = nueva;
        }  		  

        static Pila<string> sacarIguales(ref Pila<string> pila, string dato){
            Pila<string> nueva = new Pila<string>();
            Pila<string> n_dif = new Pila<string>();

            int cant = pila.Cantidad();
            for (int i = 0; i < cant; i++)
            {
                string aux = pila.Pop();
                if (aux == dato){
                    nueva.Push(aux);
                } else {
                    n_dif.Push(aux);
                }
            }
            pila = n_dif;

            return nueva;
        }

        static void dividirPila(Pila<string> pila){
            int mitad = pila.Cantidad()/2;
            Pila<string> nueva = new Pila<string>();
            
            for (int i = 0; i < mitad; i++)
            {
                nueva.Push(pila.Pop());
            }

            Console.WriteLine("mitad 1");
            pila.Mostrar();
            Console.WriteLine("mitad 2");
            nueva.Mostrar();

        }

        static bool sonIguales(Pila<string> p1, Pila<string> p2){
            if (p1.Cantidad() != p2.Cantidad())
                return false;
            int cant = p1.Cantidad();
            for (int i = 0; i < cant; i++){
                if (p1.Pop() != p2.Pop())
                    return false;
            }
            return true;           
        }

        static int cantVocales(Pila<string> pila){
            int cant = pila.Cantidad();
            int cantVocales = 0;
            for (int i = 0; i < cant; i++)
            {
                if ("aeiou".Contains(pila.Pop())){
                    cantVocales++;
                }
            }
            return cantVocales;
        }

        static Pila<string> concatPilas(Pila<string> p1, Pila<string> p2){
            Pila<string> nueva = new Pila<string>();
            int cant = p1.Cantidad();

            for (int i = 0; i < cant; i++)
            {
                nueva.Push(p1.Pop());
            }
            cant = p2.Cantidad();

            for (int i = 0; i < cant; i++)
            {
                nueva.Push(p2.Pop());
            }
            return nueva;
        }

        static bool Pal(string word){
            string nueva = "";

            for (int i = word.Length - 1; i >= 0; i--){
                nueva += word[i];
            }

            return nueva == word;
        }

        static void Main(string[] args)
        {
            Pila<string> miPila1 = new Pila<string>();
            Pila<string> miPila2 = new Pila<string>();
           
            miPila1.Push("1");
            miPila2.Push("2");
            miPila1.Push("3");
            miPila1.Push("4");
            miPila2.Push("5");
            miPila1.Push("6");
            miPila2.Push("7");
            miPila1.Push("8");
            miPila2.Push("9");

            Console.WriteLine(Pal("amolssapacificapaloma"));

            
        }
    }
}
