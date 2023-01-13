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
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtTarjeta.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteDao clienteDao = new ClienteDao();
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjeta.Text;

            if(lblEnunciado.Text == "Actualice el Usuario")
            {
                clienteDao.ActualizarCliente(cliente, Int32.Parse(lblId.Text));
                MessageBox.Show("Cliente Actualizado con éxito");
                lblEnunciado.Text = "Agregue el Usuario";
                lblId.Text = "";
            } else if (lblEnunciado.Text == "Agregue el Usuario")
            {
                clienteDao.AñadirCliente(cliente);
                MessageBox.Show("Cliente Añadido con éxito");
            }
            actualizarLista();
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            ClienteDao clienteDao = new ClienteDao();
            clienteDao.EliminarCliente(cliente.Id);
            actualizarLista();
            MessageBox.Show("Eliminado con éxito");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
        }
    }
}
