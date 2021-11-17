using Inventario.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Formularios
{
    public partial class FormInformeTiendas : Form
    {
        private Registro_TiendasEntities3 db = new Registro_TiendasEntities3();
        public FormInformeTiendas()
        {
            InitializeComponent();
            CargarReporte();
        }
        private void CargarReporte()
        {
            var listatiendas = (from t in db.Tienda
                                select new
                                {
                                    t.id_tienda,
                                    tiendanom = t.nombre,
                                    tiendaubi = t.ubicacion,
                                    tiendafono = t.telefono,
                                    tiendacorreo = t.correo,
                                    encargado = t.Encargado.nombre
                                }).ToList();
            if (listatiendas.Count() > 0)
            {
                ReportDataSource report = new ReportDataSource("Tiendas", listatiendas);
                rvTiendas.LocalReport.DataSources.Clear();
                rvTiendas.LocalReport.DataSources.Add(report);
                rvTiendas.RefreshReport();
            }
        }
    }
}
