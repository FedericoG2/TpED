public class NodoLista
{
    public int DNI;
    public bool Cliente;
    public NodoLista Siguiente; 

    public NodoLista(int dni)
    {
        DNI = dni;
        Cliente = false;
        Siguiente = null; 
    }
}
