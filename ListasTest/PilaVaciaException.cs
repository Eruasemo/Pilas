using System;
using System.Collections.Generic;
using System.Text;

namespace ListasTest
{
    class PilaVaciaException : ApplicationException
    {
        public PilaVaciaException(string nombre)
            : base("La pila llamada " + nombre + " esta vacía.")
        {

        }
        

    }
}
