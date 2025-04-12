using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3
{
    class Program
    {
        static void Main(string[] args)
        {
            pilas mipila = new pilas();
            // apilar 3 valores 
            mipila.apilar(70);
            mipila.apilar(20);
            mipila.apilar(60);
            mipila.apilar(40);
            mipila.apilar(80);
            // Otras operaciones 
            Console.WriteLine("valor de la cima: {0}", mipila.vercima());
            Console.WriteLine("quitar elemnetos de la cima : {0}", mipila.desapilar());
            Console.WriteLine("valor de la cima: {0}", mipila.vercima());
            // recorrido de los nodos 
            while (mipila.vercima() != 0)
            {
                Console.WriteLine("{0}\t", mipila.desapilar());
            }
            // apilar 3 valores 
            Console.ReadLine();
            mipila.apilar(70);
            mipila.apilar(20);
            mipila.apilar(60);
            mipila.apilar(40);
            mipila.apilar(80);
            // recorrer pila sin desapilar
            Console.WriteLine("\nRECORRER LOS ELEMENTOS DE LA PILA");
            mipila.mostrarpila();
            Console.WriteLine("\nDESAPILAR ELEMTOS DE LA PILA");
           
        }
    }
}
