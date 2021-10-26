using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Models;

namespace Inventario.Formularios
{
    public partial class FormEncargado : Form
    {
        private Registro_TiendasEntities2 db = new Registro_TiendasEntities2();
        int idEncargado = 0;
        private ValidarRut valrut = new ValidarRut();
        private SoloNumeros num = new SoloNumeros();
        public FormEncargado()
        {
            InitializeComponent();
            cargarEncargados();
        }

        private void cargarEncargados()
        {
            var listaEncargados = db.Encargado.ToList();

            dgvEncargados.DataSource = listaEncargados;
            dgvEncargados.Columns[0].Visible = false;
            dgvEncargados.Columns[5].Visible = false;
        }

        private void dgvEncargados_MouseClick(object sender, MouseEventArgs e)
        {
            idEncargado = int.Parse(dgvEncargados.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvEncargados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEncargados.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvEncargados.CurrentRow.Cells[3].Value.ToString();
            txtRut.Text = dgvEncargados.CurrentRow.Cells[4].Value.ToString();

            btnEliminar.Enabled = true;
        }
        private string Validar()
        {
            string error = string.Empty;
            if (string.IsNullOrEmpty(txtNombre.Text))
                error = "Debe ingresar nombre \n";
            if (string.IsNullOrEmpty(txtApellido.Text))
                error += "Debe ingresar apellido \n";
            if (string.IsNullOrEmpty(txtTelefono.Text))
                error += "Debe ingresar telefono \n";
            if (string.IsNullOrEmpty(txtRut.Text))
                error += "Debe ingresar rut \n";

            return error;
        }

        private void guardarencargado()
        {
            Encargado encargado = new Encargado();
            encargado.nombre = txtNombre.Text.Trim();
            encargado.apellido = txtApellido.Text.Trim();
            encargado.telefono = int.Parse(txtTelefono.Text);
            encargado.rut = txtRut.Text.Trim();

            db.Encargado.Add(encargado);
            db.SaveChanges();
        }
        private void editarencargado()
        {
            Encargado encargado = db.Encargado.Find(idEncargado);
            encargado.nombre = txtNombre.Text.Trim();
            encargado.apellido = txtApellido.Text.Trim();
            encargado.telefono = int.Parse(txtTelefono.Text);
            encargado.rut = txtRut.Text.Trim();

            db.SaveChanges();
        }
        private void Limpiar()
        {
            idEncargado = 0;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtRut.Text = "";

            dgvEncargados.ClearSelection();
            btnEliminar.Enabled = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = Validar();
            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "Falta datos");
            }
            else
            {
                if (idEncargado == 0)
                {
                    guardarencargado();
                }
                else
                {
                    editarencargado();
                }
                MessageBox.Show("Datos del encargado guardado");
                cargarEncargados();
                Limpiar();
            }
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            if (txtRut.Text.Trim() != string.Empty)
            {
                if (!valrut.validarRut(txtRut.Text.Trim()))
                {
                    MessageBox.Show("El rut ingresado no es valido");
                    txtRut.Focus();
                }
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            if (txtRut.Text.Trim() != "")
            {
                txtRut.Text = valrut.formatearRut(txtRut.Text.Trim());
                txtRut.Select(txtRut.Text.Length, 0);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.soloNumeros(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEncargado > 0)
            {
                var respuesta = MessageBox.Show("¿Desea eliminar los datos de " + txtNombre.Text + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (respuesta == DialogResult.Yes)
                {
                    Encargado cargo = db.Encargado.Find(idEncargado);
                    db.Encargado.Remove(cargo);

                    db.SaveChanges();
                    cargarEncargados();
                    Limpiar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
