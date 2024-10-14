using System;
using System.Collections.Generic;

namespace TpED.Listas
{
    public class ListaPersonal
    {
        public NodoLista Primero { get; set; } // Referencia al primer nodo de la lista
        public NodoLista Ultimo { get; set; }  // Referencia al último nodo de la lista

        public ListaPersonal()
        {
            // Inicializamos la lista vacía con ambos apuntadores en null
            Primero = null;
            Ultimo = null;
        }

        // Método para verificar si la lista está vacía
        public bool EstaVacia()
        {
            return Primero == null && Ultimo == null;
        }

        // Método para insertar un nodo en la lista de manera FIFO (orden de llegada)
        public void Insertar(NodoLista nuevo)
        {
            if (EstaVacia()) // Si la lista está vacía, creamos el nodo
            {
                Primero = nuevo; // El primer nodo es el nuevo
                Ultimo = nuevo;   // El último nodo también es el nuevo
            }
            else
            {
                Ultimo.Siguiente = nuevo; // El último apunta al nuevo nodo
                Ultimo = nuevo;           // Actualizamos el último nodo a ser el nuevo
            }
        }

        // Método para listar todos los nodos
        public List<NodoLista> Listar()
        {
            List<NodoLista> nodos = new List<NodoLista>(); // Creamos una lista vacía
            NodoLista auxiliar = Primero;                  // Comenzamos desde el primer nodo

            // Recorremos la lista hasta el final
            while (auxiliar != null)
            {
                nodos.Add(auxiliar);            // Añadimos el nodo a la lista
                auxiliar = auxiliar.Siguiente;  // Avanzamos al siguiente nodo
            }

            return nodos; // Devolvemos la lista con todos los nodos
        }

        // Método para buscar y eliminar el primer cliente en la lista
        public NodoLista BuscarCliente()
        {
            NodoLista actual = Primero; // Comenzamos desde el primer nodo

            // Recorremos la lista buscando el primer cliente
            while (actual != null)
            {
                if (actual.Cliente) // Si encontramos un cliente
                {
                    // Guardamos el DNI del cliente para usar en la eliminación
                    int dniCliente = actual.DNI;

                    // Llamamos al método Eliminar para eliminar el cliente
                    Eliminar(dniCliente);

                    return actual; // Devolvemos el nodo cliente eliminado
                }
                actual = actual.Siguiente; // Avanzamos al siguiente nodo
            }

            // Si no encontramos, llamamos al método Atender y devolvemos su resultado
            return Atender(); // Asegúrate de que Atender devuelva un NodoLista
        }


        public NodoLista Atender()
        {
            // Si la lista está vacía, no podemos atender a nadie
            if (Primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return null;
            }

            // Guardamos el primer nodo en una variable temporal
            NodoLista nodoAtendido = Primero;

            // Eliminamos el primer nodo (hacemos que Primero apunte al siguiente)
            Primero = Primero.Siguiente;

            // Si la lista se quedó vacía después de eliminar, actualizamos también Ultimo
            if (Primero == null)
            {
                Ultimo = null;
            }

            // Devolvemos el nodo atendido
            return nodoAtendido;
        }


        // Método para eliminar un nodo por su DNI
        public bool Eliminar(int dni)
        {
            if (Primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return false; // Si la lista está vacía, no hacemos nada
            }

            // Caso 1: El nodo a eliminar es el primero
            if (Primero.DNI == dni)
            {
                Primero = Primero.Siguiente; // El primer nodo ahora es el siguiente

                // Si la lista se vacía, actualizamos también Ultimo
                if (Primero == null)
                {
                    Ultimo = null;
                }
                return true;
            }

            // Caso 2: El nodo a eliminar está en otra posición
            NodoLista actual = Primero;
            NodoLista anterior = null;

            // Recorremos buscando el nodo a eliminar
            while (actual != null && actual.DNI != dni)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            // Si encontramos el nodo
            if (actual != null)
            {
                anterior.Siguiente = actual.Siguiente; // Saltamos el nodo a eliminar

                // Si el nodo eliminado era el último, actualizamos Ultimo
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
