using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3
{
    public class Cola
    {
        // campos  o atributos 
        private NodoCola frente, final, nuevo;
        // metodo constructor
        public Cola()
        {
            frente = null;
            final = null;
        }
        // metodo para crear si esta vacia o no esta vacia 
        public bool EsVacia()
        {
            return frente == null;// iniciando en Null por que la cola esta vacia 
        }
        // metodo para encolar 
        public void Encolar(int valor)
        {
            nuevo = new NodoCola(valor);
            if (EsVacia()) // preguntando por la cola vacia 
            {
                frente = nuevo;// iniciando 
                final = nuevo;
            }
            else
            {
                final.sig = nuevo;
                final = nuevo;
            }
        }
        // Metodo desencolar 
        public int Desencolar()
        {
            int valor;
            if (!EsVacia())// Si no esta vacio..?
            {
                valor = frente.info;
                frente = frente.sig;
                if (frente == null) final = null;
            }
            else
                valor = 0;
            return valor;

        }
        //Metodo Ver Frente
        public int verFrente()
        {
            if (EsVacia())
                return frente.info;
            else
                return 0;
        }
        // metodo mostrar cola 
        public void Mostrar()
        {
            NodoCola ptr = frente;
            Console.WriteLine("\n---LISTADO DE ELEMENTOS---");
            while (ptr != null)
            {
                Console.Write("{0},", ptr.info);
                ptr = ptr.sig;
            }

        }
    }
}
