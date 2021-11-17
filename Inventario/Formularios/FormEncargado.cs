using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Models;

namespace Inventario.Formularios
{
    public partial class FormEncargado : Form
    {
        private Registro_TiendasEntities3 db = new Registro_TiendasEntities3();
        int idEncargado = 0;
        private ValidarRut valrut = new ValidarRut();
        private SoloNumeros num = new SoloNumeros();
        public FormEncargado()
        {
            InitializeComponent();
            cargarEncargados();
            cargarCargos();
        }
        private void cargarCargos()
        {
            var listaCargos = db.Rol.OrderBy(c => c.nombre_rol).ToList();

            cb_Cargo.DataSource = listaCargos;
            cb_Cargo.ValueMember = "id_rol";
            cb_Cargo.DisplayMember = "nombre_rol";

            cb_Cargo.SelectedIndex = -1;
        }
        private void cargarEncargados()
        {
            var listaEncargados = db.Encargado.ToList();

            dgvEncargados.DataSource = listaEncargados;
            dgvEncargados.Columns[0].Visible = false;
            dgvEncargados.Columns[8].Visible = false;
        }

        private void dgvEncargados_MouseClick(object sender, MouseEventArgs e)
        {
            idEncargado = int.Parse(dgvEncargados.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvEncargados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEncargados.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvEncargados.CurrentRow.Cells[3].Value.ToString();
            txtRut.Text = dgvEncargados.CurrentRow.Cells[4].Value.ToString();
            txt_Correo.Text = dgvEncargados.CurrentRow.Cells[5].Value.ToString();
            txt_Password.Text = dgvEncargados.CurrentRow.Cells[6].Value.ToString();
            cb_Cargo.SelectedValue = int.Parse(dgvEncargados.CurrentRow.Cells[7].Value.ToString());

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
            if (string.IsNullOrEmpty(txt_Correo.Text))
                error += "Debe ingresar correo \n";
            if (string.IsNullOrEmpty(txt_Password.Text))
                error += "Debe ingresar contraseña \n";
            if (string.IsNullOrEmpty(cb_Cargo.Text.Trim()))
                error += "Debe seleccionar una Cargo \n";
            return error;
        }

        private void guardarencargado()
        {
            Encargado encargado = new Encargado();
            encargado.nombre = txtNombre.Text.Trim();
            encargado.apellido = txtApellido.Text.Trim();
            encargado.telefono = int.Parse(txtTelefono.Text);
            encargado.rut = txtRut.Text.Trim();
            encargado.correo = txt_Correo.Text.Trim();
            encargado.contraseña = txt_Password.Text.Trim();
            encargado.id_rol = int.Parse(cb_Cargo.SelectedValue.ToString());

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
            encargado.correo = txt_Correo.Text.Trim();
            encargado.contraseña = txt_Password.Text.Trim();
            encargado.id_rol = int.Parse(cb_Cargo.SelectedValue.ToString());

            db.SaveChanges();
        }
        private void Limpiar()
        {
            idEncargado = 0;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtRut.Text = "";
            txt_Correo.Text = "";
            txt_Password.Text = "";
            cb_Cargo.SelectedIndex = -1;

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
        private bool email_bien_escrito(string email)
        {
            string mailFormat = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, mailFormat))
            {
                if (Regex.Replace(email, mailFormat, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            bool verificar = email_bien_escrito(txt_Correo.Text);
            if (verificar == false)
            {
                MessageBox.Show("El correo no tiene el formato correcto");
                txt_Correo.Focus();
            }
        }
    }
}
