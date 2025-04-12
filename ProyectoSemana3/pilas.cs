using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3
{
   public class pilas
    {
        // atributos o campos de la clase 
        private nodo cima, nuevo; 
        // Metodo mconstructor 
         public pilas()
        {
            cima = null; 
        }
        // Metodo Esta vacia 
         public bool estavacia()
        {
           return (cima == null) ;

            // esta se puede  ---- operador ternario 
            // 1) if (cima ==null) -- return true; else -- return false; 
            // 2) return(cima==null?true: false);
            // 3) retur (cima==null); 

        }
        // Metodo apilar 
        public void apilar (int valor)
        {
            nuevo = new nodo(valor); // instancio y pasando el valor
            nuevo.sig = cima;
            cima = nuevo;
        }
        // metodo Desapilar 
        public int desapilar()
        {
            // preguntando por si la pila esta vacia 
            if (!estavacia())
            {
                int valor = cima.info;
                cima = cima.sig;
                return valor;
            }
            else
                return 0;   
            
        }
        // metodo ver cima  --- Esta metodo es para ver quien se esta quedado en la cima 
        public int vercima()
        {
            if (!estavacia())
                return cima.info;
            else
                return 0;
        }
        // recorrer pila sin desapilarlos y mostrar 
        public void mostrarpila()
        {
            nodo ptr = cima;
            while (ptr != null)
            {
                Console.WriteLine("{0},", ptr.info);
                ptr = ptr.sig;
            }
        }
     
    }
}
