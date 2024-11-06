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

    
    public bool Agregar(Nodo nuevoNodo)
    {
        if (nuevoNodo != null)
        {
            
            if (ExisteDNI(nuevoNodo.DNI))
            {
                return false; 
            }

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

            return true; 
        }

        return false; 
    }



    public bool ExisteDNI(int dni)
    {
        Nodo actual = Primero;

        
        while (actual != null)
        {
            if (actual.DNI == dni)
            {
                return true; 
            }
            actual = actual.Siguiente; 
        }

        return false; 
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
            return null; 
        }

        
        Nodo nodoEliminado = Primero;

        
        Primero = Primero.Siguiente;

        
        if (Primero == null)
        {
            Ultimo = null;
        }

       
        return nodoEliminado;
    }

}
