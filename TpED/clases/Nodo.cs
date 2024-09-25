public class Nodo
{
    public int DNI { get; set; }
    public Nodo Siguiente { get; set; }
    public bool Cliente { get; set; }

   
    public Nodo(int dni)
    {
        this.DNI = dni;
        this.Siguiente = null;
        this.Cliente = false; 
    }
}
