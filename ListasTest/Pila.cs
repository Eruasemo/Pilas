using System;
using System.Collections.Generic;
using System.Text;

namespace ListasTest
{
    class Pila
    {
        private Nodo tope;
        private string nombre;

        public Pila()
        {
            this.nombre = "Pila sin nombre";
            this.tope = null;
        }

        public Pila(string nombrePila)
        {
            this.nombre = nombrePila;
            this.tope = null;
        }

        public bool PilaVacia()
        {
            return this.tope == null;
        }

        public void Push(object valor)
        {
            Nodo nodo = new Nodo(valor);

            if (PilaVacia())
            {
                this.tope = nodo;
            }
            else
            {
                nodo.Anterior = this.tope;
                this.tope = nodo;
            }
        }

        public object Pop()
        {
            if(PilaVacia())
            {
                throw new PilaVaciaException(this.nombre);
            }
            object elementoSacado = this.tope.Dato;
            this.tope = this.tope.Anterior;
            return elementoSacado;
        }

        public object Peek()
        {
            if (PilaVacia())
            {
                return null;
            }
            return this.tope.Dato;
        }
    }
}
