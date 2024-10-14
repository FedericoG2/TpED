using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TpED.Clases_Lista_C;
using TpED.Listas;

namespace TpED
{
    public partial class Form1 : Form
    {
        private Cola cola; 
        private ListaCaja listaCaja;
        private ListaPersonal listaPersonal;

        public Form1()
        {
            InitializeComponent();
            cola = new Cola(); 
            listaCaja = new ListaCaja();
            listaPersonal = new ListaPersonal();    

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                if (int.TryParse(txtDNI.Text, out int dni))
                {
                    // Creamos el nuevo nodo con el DNI ingresado
                    Nodo nuevoNodo = new Nodo(dni);

                    // Intentamos agregar el nodo a la cola
                    bool agregado = cola.Agregar(nuevoNodo);

                    if (agregado)
                    {
                        // Si el nodo se agregó correctamente, recargamos la grilla
                        CargarDataGridView();

                        // Limpiamos el campo de texto
                        txtDNI.Clear();
                    }
                    else
                    {
                        // Si el DNI ya estaba en la cola, mostramos un mensaje
                        MessageBox.Show("El DNI ya está en la cola.");
                    }
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
            // Limpiamos las filas y columnas existentes del DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Agregamos las columnas "Orden" y "DNI"
            dataGridView1.Columns.Add("Orden", "Orden");
            dataGridView1.Columns.Add("DNI", "DNI");

            // Obtenemos los nodos de la cola
            List<Nodo> listaDeNodos = cola.ListarElementos();

            // Variable para llevar el conteo del orden
            int orden = 1;

            // Iteramos sobre cada nodo en la lista
            foreach (var nodo in listaDeNodos)
            {
                if (nodo != null)
                {
                    // Convertimos el DNI a cadena de texto
                    string dniString = nodo.DNI.ToString();

                    // Agregamos una nueva fila con el orden y el DNI
                    dataGridView1.Rows.Add(orden, dniString);

                    // Incrementamos el contador de orden
                    orden++;
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
                // Establece el texto de txtIngreso con el DNI del nodo eliminado
                txtIngreso.Text = nodoEliminado.DNI.ToString(); // Convertimos a string
                ActualizarGrilla();
            }
            else
            {
                // Opcional: Manejar el caso cuando no hay nodos para eliminar
                MessageBox.Show("No hay mas datos en la cola");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDNI2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verificamos que haya un valor en el TextBox txtIngreso
            if (string.IsNullOrWhiteSpace(txtIngreso.Text))
            {
                MessageBox.Show("Debe haber un DNI."); // Mensaje de error si el TextBox está vacío
                return; // Salimos del método
            }

            // Obtenemos el número de DNI del TextBox
            if (int.TryParse(txtIngreso.Text, out int dni)) // Validamos que el DNI sea un número
            {
                // Creamos un nuevo nodo usando el DNI y el estado del CheckBox
                NodoLista nuevoNodo = new NodoLista(dni)
                {
                    Cliente = checkCliente.Checked // Asignamos true o false según el CheckBox
                };

                // Verificamos si el RadioButton btnCaja está seleccionado
                if (btnCaja.Checked)
                {
                    // Insertamos el nodo en la lista de Caja
                    listaCaja.Insertar(nuevoNodo);

                    // Cargamos los datos en el DataGridView de Caja
                    CargarGrillaCaja();

                    // Limpiamos los controles
                    txtIngreso.Clear();
                    checkCliente.Checked = false;
                    btnCaja.Checked = false; // Desmarcamos el RadioButton
                }
                // Verificamos si el RadioButton btnPersonal está seleccionado
                else if (btnPersonal.Checked)
                {
                    // Insertamos el nodo en la lista de Personal
                    listaPersonal.Insertar(nuevoNodo);

                    // Cargamos los datos en el DataGridView de Personal
                    CargarGrillaPersonal();

                    // Limpiamos los controles
                    txtIngreso.Clear();
                    checkCliente.Checked = false;
                    btnPersonal.Checked = false; // Desmarcamos el RadioButton
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona la opción de Caja o Personal."); // Mensaje si ningún RadioButton está seleccionado
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un DNI válido."); // Mensaje de error si el DNI no es válido
            }
        }

        // Método para cargar la grilla de Caja
        private void CargarGrillaCaja()
        {
            // Limpiamos el DataGridView antes de listar los elementos
            dataGridCaja.Rows.Clear();

            // Configuramos las columnas del DataGridView si no están configuradas
            if (dataGridCaja.Columns.Count == 0)
            {
                dataGridCaja.Columns.Add("Orden", "Orden");
                dataGridCaja.Columns.Add("DNI", "DNI");
                dataGridCaja.Columns.Add("Cliente", "Cliente");
            }

            // Listamos todos los nodos y los cargamos en el DataGridView
            var nodos = listaCaja.Listar();

            // Cargamos los datos en el DataGridView
            int orden = 1; // Variable para llevar el orden de los nodos
            foreach (var nodo in nodos)
            {
                dataGridCaja.Rows.Add(orden++, nodo.DNI, nodo.Cliente ? "Sí" : "No"); // Agregamos fila con el orden, DNI y "Sí"/"No" para el cliente
            }
        }

        // Método para cargar la grilla de Personal
        private void CargarGrillaPersonal()
        {
            // Limpiamos el DataGridView antes de listar los elementos
            dataGridPersonal.Rows.Clear();

            // Configuramos las columnas del DataGridView si no están configuradas
            if (dataGridPersonal.Columns.Count == 0)
            {
                dataGridPersonal.Columns.Add("Orden", "Orden");
                dataGridPersonal.Columns.Add("DNI", "DNI");
                dataGridPersonal.Columns.Add("Cliente", "Cliente");
            }

            // Listamos todos los nodos y los cargamos en el DataGridView
            var nodos = listaPersonal.Listar();

            // Cargamos los datos en el DataGridView
            int orden = 1; // Variable para llevar el orden de los nodos
            foreach (var nodo in nodos)
            {
                dataGridPersonal.Rows.Add(orden++, nodo.DNI, nodo.Cliente ? "Sí" : "No"); // Agregamos fila con el orden, DNI y "Sí"/"No" para el cliente
            }
        }

        private bool primerInicioPersonal = true; // Variable para controlar si es el primer clic de personal

        private void atenderPersonal_Click(object sender, EventArgs e)
        {
            NodoLista nodoAtendido;

            if (primerInicioPersonal)
            {
                // En el primer clic, atendemos al primer nodo de la lista personal
                nodoAtendido = listaPersonal.Atender();
                primerInicioPersonal = false; // Cambiamos el estado a no primer clic
            }
            else
            {
                // En clics subsecuentes, buscamos un nodo con Cliente
                nodoAtendido = listaPersonal.BuscarCliente(); 
                primerInicioPersonal = true ;
            }

            // Verificamos si se obtuvo un nodo atendido
            if (nodoAtendido != null)
            {
                // Cargamos el DNI en el TextBox
                txtPersonal.Text = nodoAtendido.DNI.ToString(); // Convertimos el DNI a string y lo asignamos al TextBox

                // Refrescamos la grilla dataGridPersonal
                CargarGrillaPersonal(); // Este método debería implementar la lógica para cargar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("No hay mas personas para atender."); // Mensaje si no hay más personas
            }
        }

        private bool primerInicioCaja = true; // Variable para controlar si es el primer clic de personal

        private void atenderCaja_Click(object sender, EventArgs e)
        {
            NodoLista nodoAtendido;

            if (primerInicioCaja)
            {
                // En el primer clic, atendemos al primer nodo de la lista caja
                nodoAtendido = listaCaja.Atender(); // Suponiendo que Atender obtiene el primer nodo
                primerInicioCaja = false; // Cambiamos el estado a no primer clic
            }
            else
            {
                // En clics subsecuentes, buscamos en los primeros 3
                nodoAtendido = listaCaja.BuscarCliente(); // Método que deberías tener en tu clase ListaCaja
                primerInicioCaja = true; // Restablecemos el estado para el siguiente clic
            }

            // Verificamos si se obtuvo un nodo atendido
            if (nodoAtendido != null)
            {
                // Cargamos el DNI en el TextBox
                txtCaja.Text = nodoAtendido.DNI.ToString(); // Convertimos el DNI a string y lo asignamos al TextBox

                // Refrescamos la grilla dataGridCaja
                CargarGrillaCaja(); // Este método debería implementar la lógica para cargar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("No hay más personas para atender."); // Mensaje si no hay más personas
            }
        }
    }
}
