using System;
using System.Collections.Generic;

public class Cola
{
    public Nodo Primero { get; set; } 
    public Nodo Ultimo { get; set; }  

    
    public Cola()
    {
        Primero = null;
        Ultimo = null;
    }

    public void Agregar(Nodo nuevoNodo)
    {
        if (nuevoNodo != null) 
        {
            
            if (EstaVacia()) 
            {
                Primero = nuevoNodo; 
                Ultimo = nuevoNodo; 
            }
            else 
            {
                Ultimo.Siguiente = nuevoNodo; 
                Ultimo = nuevoNodo; 
            }
        }
        else
        {
            return; //No se deberia agregar
        }
    }



   
    public bool EstaVacia()
    {
        return Primero == null;
    }


    
    public List<Nodo> ListarElementos()
    {
        List<Nodo> nodos = new List<Nodo>(); 
        Nodo actual = Primero; 

        while (actual != null) 
        {
            nodos.Add(actual); 
            actual = actual.Siguiente; 
        }

      

        return nodos; 
    }


    public Nodo Eliminar()
    {
        if (EstaVacia())
        {
            return null; // O lanza una excepción si prefieres
        }

        // Guarda el nodo que se va a eliminar
        Nodo nodoEliminado = Primero;

        // Mueve el puntero Primero al siguiente nodo
        Primero = Primero.Siguiente;

        // Si la cola queda vacía, también actualiza Ultimo
        if (Primero == null)
        {
            Ultimo = null;
        }

        // Devuelve el nodo eliminado
        return nodoEliminado;
    }

}
