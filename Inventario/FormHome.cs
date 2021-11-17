using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormHome : Form
    {
        private Form formularioActivo;
        public FormHome()
        {
            InitializeComponent();
        }
        private void abrirFormulario(Form formHijo)
        {

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formHijo;

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContent.Controls.Add(formHijo);
            panelContent.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Formularios.FormMarcas());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Formularios.FormCategorias());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Formularios.FormProductos());
        }

        private void btnTiendas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Formularios.FormTiendas());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
        }
        private void btnEncargado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Formularios.FormEncargado());
        }

        private void btn_reportEncargado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Formularios.FormInformeEncargado());
        }

        private void btn_reportTiendas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Formularios.FormInformeTiendas());
        }

        private void btn_reportProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Formularios.FormInformeProductos());
        }
    }
}
