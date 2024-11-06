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

      // Metodo que agrega nodos a la cola  
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                if (int.TryParse(txtDNI.Text, out int dni))
                {
                    
                    Nodo nuevoNodo = new Nodo(dni);

                    
                    bool agregado = cola.Agregar(nuevoNodo);

                    if (agregado)
                    {
                        
                        CargarDataGridView();

                       
                        txtDNI.Clear();
                    }
                    else
                    {
                       
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


        //Actualiza la primer grilla
        private void ActualizarGrilla()
        {
            CargarDataGridView();
        }

        // Carga de la primer grilla
        private void CargarDataGridView()
        {
            
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            
            dataGridView1.Columns.Add("Orden", "Orden");
            dataGridView1.Columns.Add("DNI", "DNI");

            
            List<Nodo> listaDeNodos = cola.ListarElementos();

            
            int orden = 1;

            
            foreach (var nodo in listaDeNodos)
            {
                if (nodo != null)
                {
                    
                    string dniString = nodo.DNI.ToString();

                    
                    dataGridView1.Rows.Add(orden, dniString);

                    
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

        // Metodo que va retirando de la cola los nodos segun orden primero en entrar primero en salir.
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            Nodo nodoEliminado = cola.Eliminar();

           
            if (nodoEliminado != null)
            {
                
                txtIngreso.Text = nodoEliminado.DNI.ToString(); 
                ActualizarGrilla();
            }
            else
            {
                
                MessageBox.Show("No hay mas datos en la cola");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDNI2_TextChanged(object sender, EventArgs e)
        {

        }

        // Metodo que deriva a la lista que corresponda , Cajas o Atencion Personal
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtIngreso.Text))
            {
                MessageBox.Show("Debe haber un DNI."); 
                return; 
            }

            
            if (int.TryParse(txtIngreso.Text, out int dni)) 
            {
                
                NodoLista nuevoNodo = new NodoLista(dni)
                {
                    Cliente = checkCliente.Checked 
                };

                
                if (btnCaja.Checked)
                {
                    
                    listaCaja.Insertar(nuevoNodo);

                    
                    CargarGrillaCaja();

                    
                    txtIngreso.Clear();
                    checkCliente.Checked = false;
                    btnCaja.Checked = false;
                }
                
                else if (btnPersonal.Checked)
                {
                    
                    listaPersonal.Insertar(nuevoNodo);

                   
                    CargarGrillaPersonal();

                    
                    txtIngreso.Clear();
                    checkCliente.Checked = false;
                    btnPersonal.Checked = false; 
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona la opción de Caja o Personal."); 
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un DNI válido."); 
            }
        }

        
        private void CargarGrillaCaja()
        {
            
            dataGridCaja.Rows.Clear();

            
            if (dataGridCaja.Columns.Count == 0)
            {
                dataGridCaja.Columns.Add("Orden", "Orden");
                dataGridCaja.Columns.Add("DNI", "DNI");
                dataGridCaja.Columns.Add("Cliente", "Cliente");
            }

            
            var nodos = listaCaja.Listar();

            int orden = 1; 
            foreach (var nodo in nodos)
            {
                dataGridCaja.Rows.Add(orden++, nodo.DNI, nodo.Cliente ? "Sí" : "No"); 
            }
        }

        private void CargarGrillaPersonal()
        {
           
            dataGridPersonal.Rows.Clear();

            
            if (dataGridPersonal.Columns.Count == 0)
            {
                dataGridPersonal.Columns.Add("Orden", "Orden");
                dataGridPersonal.Columns.Add("DNI", "DNI");
                dataGridPersonal.Columns.Add("Cliente", "Cliente");
            }

            
            var nodos = listaPersonal.Listar();

            
            int orden = 1; 
            foreach (var nodo in nodos)
            {
                dataGridPersonal.Rows.Add(orden++, nodo.DNI, nodo.Cliente ? "Sí" : "No"); 
            }
        }

        private bool primeroInicioPersonal = true; 

        private void atenderPersonal_Click(object sender, EventArgs e)
        {
            NodoLista nodoAtendido;

            if (primeroInicioPersonal)
            {
                
                nodoAtendido = listaPersonal.Atender();
                primeroInicioPersonal = false; 
            }
            else
            {
                
                nodoAtendido = listaPersonal.BuscarCliente(); 
                primeroInicioPersonal = true ;
            }

        
            if (nodoAtendido != null)
            {
                
                txtPersonal.Text = nodoAtendido.DNI.ToString(); 

              
                CargarGrillaPersonal(); 
            }
            else
            {
                MessageBox.Show("No hay mas personas para atender.");
                txtPersonal.Clear();
            }
        }

        private bool primeroInicioCaja = true; 

        private void atenderCaja_Click(object sender, EventArgs e)
        {
            NodoLista nodoAtendido;

            if (primeroInicioCaja)
            {
               
                nodoAtendido = listaCaja.Atender(); 
                primeroInicioCaja = false; 
            }
            else
            {
               
                nodoAtendido = listaCaja.BuscarCliente(); 
                primeroInicioCaja = true; 
            }

            
            if (nodoAtendido != null)
            {
               
                txtCaja.Text = nodoAtendido.DNI.ToString();
               
                CargarGrillaCaja();
            }
            else
            {
                MessageBox.Show("No hay más personas para atender."); 
                txtCaja.Clear();
            }
        }
    }
}
