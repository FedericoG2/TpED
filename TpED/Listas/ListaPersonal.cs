using System;
using System.Collections.Generic;

namespace TpED.Listas
{
    public class ListaPersonal
    {
        public NodoLista Primero { get; set; } 
        public NodoLista Ultimo { get; set; } 
        public ListaPersonal()
        {
            
            Primero = null;
            Ultimo = null;
        }

     
        public bool EstaVacia()
        {
            return Primero == null && Ultimo == null;
        }

        
        public void Insertar(NodoLista nuevo)
        {
            if (EstaVacia()) 
            {
                Primero = nuevo; 
                Ultimo = nuevo;   
            }
            else
            {
                Ultimo.Siguiente = nuevo; 
                Ultimo = nuevo;          
            }
        }

    
        public List<NodoLista> Listar()
        {
            List<NodoLista> nodos = new List<NodoLista>(); 
            NodoLista auxiliar = Primero;                  


            while (auxiliar != null)
            {
                nodos.Add(auxiliar);            
                auxiliar = auxiliar.Siguiente;  
            }

            return nodos; 
        }

        
        public NodoLista BuscarCliente()
        {
            NodoLista actual = Primero; 

           
            while (actual != null)
            {
                if (actual.Cliente) 
                {
                    
                    int dniCliente = actual.DNI;

                    
                    Eliminar(dniCliente);

                    return actual; 
                }
                actual = actual.Siguiente; 
            }

            
            return Atender(); 
        }


        public NodoLista Atender()
        {
            
            if (Primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return null;
            }

           
            NodoLista nodoAtendido = Primero;

           
            Primero = Primero.Siguiente;

            
            if (Primero == null)
            {
                Ultimo = null;
            }

           
            return nodoAtendido;
        }


        
        public bool Eliminar(int dni)
        {
            if (Primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return false; 
            }

            
            if (Primero.DNI == dni)
            {
                Primero = Primero.Siguiente; 
               
                if (Primero == null)
                {
                    Ultimo = null;
                }
                return true;
            }

            
            NodoLista actual = Primero;
            NodoLista anterior = null;

            
            while (actual != null && actual.DNI != dni)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

           
            if (actual != null)
            {
                anterior.Siguiente = actual.Siguiente; 

               
                if (actual == Ultimo)
                {
                    Ultimo = anterior;
                }
                return true;
            }

            Console.WriteLine("El nodo con el DNI especificado no se encontró.");
            return false;
        }
    }
}
