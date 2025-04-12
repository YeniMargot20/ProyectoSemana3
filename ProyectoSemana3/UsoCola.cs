using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3
{

     class UsoCola
    {
      static void Main(string[] args)
        {
            Cola miCola = new Cola();

            miCola.Encolar(10);
            miCola.Encolar(20);
            miCola.Encolar(30);
            miCola.Encolar(40);
            miCola.Encolar(50);
            miCola.Mostrar();

            miCola.Desencolar();
            miCola.Mostrar();
            Console.ReadLine();
        }
    }

}
