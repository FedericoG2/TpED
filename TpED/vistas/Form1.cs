using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TpED
{
    public partial class Form1 : Form
    {
        private Cola cola; 

        public Form1()
        {
            InitializeComponent();
            cola = new Cola(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                
                if (int.TryParse(txtDNI.Text, out int dni))
                {
                    
                    Nodo nuevoNodo = new Nodo(dni);

                    
                    cola.Agregar(nuevoNodo);

                    
                    CargarDataGridView();

                   
                    txtDNI.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.");
                }
            }
            else
            {
                MessageBox.Show("El campo DNI está vacío.");
            }
        }

        private void ActualizarGrilla()
        {
            CargarDataGridView();
        }
       
        private void CargarDataGridView()
        {
            
            dataGridView1.Rows.Clear();

           
            dataGridView1.Columns.Clear(); 

            dataGridView1.Columns.Add("DNI", "DNI");

            List<Nodo> listaDeNodos = cola.ListarElementos();

        
            foreach (var nodo in listaDeNodos)
            {
                
                if (nodo != null)
                {
                    
                    string dniString = nodo.DNI.ToString();

                    
                    dataGridView1.Rows.Add(dniString);
                }
                else
                {
                    Console.WriteLine("Nodo nulo encontrado."); 
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Llama al método Eliminar y guarda el nodo eliminado
            Nodo nodoEliminado = cola.Eliminar();

            // Verifica si se eliminó un nodo
            if (nodoEliminado != null)
            {
                // Establece el texto de txtDNI2 con el DNI del nodo eliminado
                txtDNI2.Text = nodoEliminado.DNI.ToString(); // Convertimos a string
                ActualizarGrilla();
            }
            else
            {
                // Opcional: Manejar el caso cuando no hay nodos para eliminar
                MessageBox.Show("No hay mas datos en la cola");
            }
        }
    }
}
