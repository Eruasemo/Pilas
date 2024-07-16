using System;

public class Nodo
{
	private object dato;
	private Nodo anterior;
	public Nodo(object vDato)
	{
		this.dato = vDato;
		this.anterior = null;
	}

	public Nodo(object vDato, Nodo nodoAnterior)
    {
		this.dato = vDato;
		this.anterior = nodoAnterior;
	}

	public object Dato
    {
        get
        {
			return this.dato;
        }

        set
        {
			this.dato = value;
        }
    }

    public Nodo Anterior
    {
        get
        {
            return this.anterior;
        }

        set
        {
            this.anterior = value;
        }
    }
}
