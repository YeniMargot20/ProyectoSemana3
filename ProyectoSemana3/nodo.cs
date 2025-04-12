using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3
{
   public class nodo
    { 
        // campos o atributos 
        public int info { set; get; }

        public nodo sig { set; get; }
         // Metodo Costructores me permite procesos de inicializacion  
        public nodo() { }

        public nodo (int valor)
        {
            this.info = valor;
            this.sig = null;  

        }
    }
}
