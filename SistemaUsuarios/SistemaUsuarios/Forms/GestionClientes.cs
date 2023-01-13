using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaUsuarios.Dao;
using SistemaUsuarios.Models;

namespace SistemaUsuarios
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            listClientes.Items.Clear();
            ClienteDao clienteDao = new ClienteDao();
            List<Cliente> list = new List<Cliente>();
            list = clienteDao.ConsultarClientes();
            foreach (var cliente in list)
            {
                listClientes.Items.Add(cliente);
            }
        }

        private void limpiarCampos()
        {
            lblId.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtTarjeta.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 & txtApellido.Text.Length > 0
                & txtTelefono.Text.Length > 0 & txtTarjeta.Text.Length > 0) 
            {
                ClienteDao clienteDao = new ClienteDao();
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.TarjetaDeCredito = txtTarjeta.Text;

                if (lblEnunciado.Text == "Actualice el Usuario")
                {
                    clienteDao.ActualizarCliente(cliente, Int32.Parse(lblId.Text));
                    MessageBox.Show("Cliente Actualizado con éxito");
                    lblEnunciado.Text = "Agregue el Usuario";
                    lblId.Text = "";
                }
                else if (lblEnunciado.Text == "Agregue el Usuario")
                {
                    clienteDao.AñadirCliente(cliente);
                    MessageBox.Show("Cliente Añadido con éxito");
                }
                actualizarLista();
                limpiarCampos();
            } else
            {
                MessageBox.Show("Por Favor Llene todos los campos");
            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedItem != null)
            {
                Cliente cliente = (Cliente)listClientes.SelectedItem;
                ClienteDao clienteDao = new ClienteDao();
                clienteDao.EliminarCliente(cliente.Id);
                actualizarLista();
                MessageBox.Show("Eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Haga Una selección");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedItem != null)
            {
                ClienteDao clienteDao = new ClienteDao();
                Cliente cliente = (Cliente)listClientes.SelectedItem;
                String original = lblEnunciado.Text;
                lblEnunciado.Text = "Actualice el Usuario";
                lblId.Text = cliente.Id.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtTelefono.Text = cliente.Telefono;
                txtTarjeta.Text = cliente.TarjetaDeCredito;
            } else
            {
                MessageBox.Show("Haga Una selección");
            }
              
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listClientes.SelectedItem != null)
            {
                btnGuardar.Visible = false;
                var cliente = (Cliente)listClientes.SelectedItem;
                lblEnunciado.Text = "Información del Usuario";
                lblId.Text = cliente.Id.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtTelefono.Text = cliente.Telefono;
                txtTarjeta.Text = cliente.TarjetaDeCredito;
            } else
            {
                MessageBox.Show("Haga Una selección");
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            lblEnunciado.Text = "Agregue el Usuario";
            btnGuardar.Visible = true;
            limpiarCampos();
        }
    }
}
