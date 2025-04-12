using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3
{
    public class NodoCola
    {
        // campos o atributos de la clase 
        public int info { set; get; }
        public NodoCola sig { set; get; }

        // metodos constructor  

        public NodoCola() { }
         public NodoCola(int valor)
        {
            this.info = valor;
            this.sig = null; 
        }

    }
}
