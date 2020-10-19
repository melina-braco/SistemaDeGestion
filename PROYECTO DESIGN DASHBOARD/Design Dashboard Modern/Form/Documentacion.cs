using System;
using System.Data;
using System.Windows.Forms;
using Design_Dashboard_Modern.Clases;
using Design_Dashboard_Modern.Models;
using System.Configuration;
using System.Linq;
using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Design_Dashboard_Modern
{
    public partial class Documentacion : Form
    {
        private string strContextoDB;

        private string Path;

        private int TipoDocumentacion;

        private bool _ExisteDatosEmpresa;

        private bool _ExisteDatosCliente;

        public Documentacion(string strContextoDB)
        {
            InitializeComponent();

            this.strContextoDB = strContextoDB;
        }

        private void Documentacion_Load(object sender, EventArgs e)
        {
            this.GetDatosEmpresa();

            this.LoadAutoCompleteClientes(cbCliente);

            //this.LoadAutoCompleteProductos(cbProducto);

            //this.ColumnaTablaRemito();

            this.LoadAutoCompleteVenta();

            if (this.ExisteCheckBoxHabilitado() && this.ExisteDatosComboVenta())
            {
                btnGenerarDocumentacion.Enabled = true;
            }
            else
            {
                btnGenerarDocumentacion.Enabled = false;
            }
        }

        private List<CheckBox> ListaCheckBox()
        {
            List<CheckBox> lstCheck = new List<CheckBox>();

            lstCheck.Add(cbFactura);

            lstCheck.Add(cbNC);

            lstCheck.Add(cbND);

            lstCheck.Add(cbRemito);

            lstCheck.Add(cbOrdenCompra);

            lstCheck.Add(cbOrdenVenta);

            return lstCheck;
        }

        private bool ExisteCheckBoxHabilitado()
        {
            /* Devuelve true si hay algun checkBox habilitado*/

            bool blnHabilitados = false;

            foreach (CheckBox index in this.ListaCheckBox())
            {
                if (index.Checked)
                {
                    blnHabilitados = true;
                }
            }

            return blnHabilitados;
        }

        private void ConfiguracionCheckBox(CheckBox cbHabilitado)
        {
            List<CheckBox> lstCheck = this.ListaCheckBox();

            if (this.ExisteCheckBoxHabilitado())
            {
                lstCheck.Remove(cbHabilitado);

                foreach (CheckBox i in lstCheck)
                {
                    i.Enabled = false;
                }

                cbHabilitado.Enabled = true;
            }
            else
            {
                foreach (CheckBox i in lstCheck)
                {
                    i.Enabled = true;
                }
            }
        }

        private void ControlTabPage(TabPage tabPage, bool estaHabilitado)
        {
            /* Habilita o deshabilita los controladores pertenecientes al tabPage ingresado por parametro*/

            foreach (Control ctl in tabPage.Controls)
            {
                ctl.Enabled = estaHabilitado;
            }

            tcTipoDoc.SelectedTab = tabPage;
        }

        #region Configuracion CheckBox

        private void cbFactura_CheckedChanged(object sender, EventArgs e)
        {
            /* Habilita el checkbox pasado por parametro  */

            this.ConfiguracionCheckBox(cbFactura);

            if (this.ExisteCheckBoxHabilitado())
            {
                TipoDocumentacion = 1;

                btnGenerarDocumentacion.Enabled = true;

                btnGenerarDocumentacion.Enabled = true;

                this.ControlTabPage(tbFacturaItems, true);
            }
            else
            {
                this.ControlTabPage(tbFacturaItems, false);

                pdfDocView.Load(@"C:\Users\melin\Documentos\Tecnicatura en Programacion\PP1\SGA\PROYECTO DESIGN DASHBOARD\Design Dashboard Modern\Plantilla\_blank.pdf");

                btnGenerarDocumentacion.Enabled = false;

                btnMail.Enabled = false;
            }
        }

        private void cbNC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbND_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbOrdenCompra_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbOrdenVenta_CheckedChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private void GenerarDocumentacion_Click(object sender, EventArgs e)
        {
            switch (TipoDocumentacion)
            {
                case 1:

                    this.FacturaPDF();

                    break;
            }

            btnMail.Enabled = true;
        }

        #region Remito

        //private void RemitoPDF()
        //{
        //    Documento documento = new Documento();

        //    IWorkbook workbook = documento.GetWorkbookPlantilla(@"C:\Users\melin\Documentos\Tecnicatura en Programacion\PP1\SGA\PROYECTO DESIGN DASHBOARD\Design Dashboard Modern\Plantilla\Remito.xlsx");

        //    IWorksheet sheet = workbook.Worksheets[0];

        //    #region Cabecera

        //    sheet.Range["G2"].Text = DateTime.Today.ToShortDateString().ToString();

        //    if (_ExisteDatosEmpresa)
        //    {
        //        sheet.Range["B6"].Text = tbDomicilioEmpresa.Text;

        //        sheet.Range["B7"].Text = tbMailEmpresa.Text;

        //        sheet.Range["B8"].Text = $"Tel: {tbTelEmpresa.Text}";

        //        sheet.Range["F5"].Text = $"Cuit: {tbCuit.Text}";

        //        sheet.Range["F6"].Text = "ING BRUTOS CM 33-33333333-3";

        //        sheet.Range["F7"].Text = "INICIO ACTIVIDAD 9/2019";

        //        sheet.Range["C11"].Text = tbNombre.Text;

        //        sheet.Range["C12"].Text = tbDomicilio.Text;

        //        sheet.Range["G15"].Text = tbCuit.Text;
        //    }

        //    #endregion

        //    #region Items

        //    int filaExcel = 23;

        //    int columnaExcel = 2;

        //    for (int row = 0; row < dtItemsRemito.Rows.Count; row++)
        //    {
        //        columnaExcel = 2;

        //        for (int column = 0; column < dtItemsRemito.Columns.Count; column++)
        //        {
        //            sheet[filaExcel, columnaExcel].Value = dtItemsRemito.Rows[row][column].ToString();

        //            columnaExcel = columnaExcel + 2;
        //        }

        //        filaExcel++;
        //    }

        //    #endregion

        //    Path = documento.PathGuardar();

        //    documento.ConvertirPDF(sheet, Path);

        //    workbook.Close();

        //    pdfDocView.Load(Path);
        //}

        //private void ColumnaTablaRemito()
        //{
        //    dtItemsRemito = new DataTable();

        //    dtItemsRemito.Columns.Add("Cantidad", typeof(int));

        //    dtItemsRemito.Columns.Add("Nombre Producto", typeof(string));

        //    GrillaItemRemito.DataSource = dtItemsRemito;
        //}

        //private void AgregarItemsRemito()
        //{
        //    string strProducto = cbProducto.SelectedValue.ToString().Split('-')[1].TrimStart().TrimEnd();

        //    dtItemsRemito.Rows.Add(new object[]
        //    {
        //        tbCantidad.Value,
        //        strProducto,
        //    });

        //    tbCantidad.Value = 0;

        //    GrillaItemRemito.DataSource = dtItemsRemito;

        //    this.CalcularTotalItems("Cantidad", dtItemsRemito);
        //}

        //private void AgregarItems_Click(object sender, EventArgs e)
        //{
        //    switch (TipoDocumentacion)
        //    {
        //        case 1:

        //            break;

        //        case 2:

        //            this.AgregarItemsRemito();

        //            break;
        //    }
        //}

        //private void CalcularTotalItems(string columna, DataTable dtItems)
        //{
        //    decimal aux = 0;

        //    for (int index = 0; index < dtItems.Rows.Count; index++)
        //    {
        //        aux += Convert.ToDecimal(dtItems.Rows[index][columna].ToString());
        //    }

        //    tbTotal.Text = Convert.ToString(aux);
        //}

        #endregion

        #region Factura

        private void FacturaPDF()
        {
            Documento documento = new Documento();

            IWorkbook workbook = documento.GetWorkbookPlantilla(@"C:\Users\melin\Documentos\Tecnicatura en Programacion\PP1\SGA\PROYECTO DESIGN DASHBOARD\Design Dashboard Modern\Plantilla\Factura.xlsx");

            IWorksheet sheet = workbook.Worksheets[0];

            #region Cabecera

            sheet.Range["C11"].Text = DateTime.Today.ToShortDateString().ToString();

            if (!string.IsNullOrEmpty(tbValidez.Text))
            {
                sheet.Range["I11"].Text = tbValidez.Text;
            }
            else
            {
                sheet.Range["I11"].Text = "No definido";
            }

            if (_ExisteDatosEmpresa)
            {
                sheet.Range["A4"].Text = tbNombreEmpresa.Text;

                sheet.Range["A5"].Text = tbDomicilioEmpresa.Text;

                sheet.Range["A6"].Text = $"CUIT-NIF: {tbCuitEmpresa.Text}";

                sheet.Range["A7"].Text = $"Telefono: {tbTelEmpresa.Text}";

                sheet.Range["A8"].Text = $"E-Mail: {tbMailEmpresa.Text}";
            }

            if (_ExisteDatosCliente)
            {
                sheet.Range["F4"].Text = $"Nombre: {tbNombre.Text}";

                sheet.Range["F5"].Text = $"Direccion: {tbDomicilio.Text}";

                sheet.Range["F6"].Text = $"CUIT-NIF: {tbCuit.Text}";

                sheet.Range["F7"].Text = $"Telefono: {tbTel.Text}";

                sheet.Range["F8"].Text = $"E-Mail: {tbMail.Text}";
            }

            #endregion

            #region item

            decimal Total = 0;

            if (this.ExisteDatosComboVenta())
            {
                int idVenta = Convert.ToInt32(cbVenta.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

                using (contexto)
                {
                    var ventaCabecera = contexto.ModeloVentas.Where(p => p.IdVentas == idVenta).Select(p =>
                    new { p.IdVentas, p.cliente.Nombre, p.Observacion, p.Total, p.FechaEgreso })
                    .OrderBy(p => p.IdVentas).FirstOrDefault();

                    var lstVtaItems = contexto.ModeloVentaItems.Where(p => p.IdVentas == idVenta).Select(p =>
                       new
                       {
                           p.Codigo,
                           p.NombreProducto,
                           p.PrecioCosto,
                           p.Cantidad,
                           p.PrecioVenta,
                           p.SubTotal,
                           p.FechaEgreso
                       })
                            .OrderBy(p => p.Codigo).ToList();


                    sheet.Range["G1"].Text = ventaCabecera.IdVentas.ToString();

                    int filaExcel = 14;

                    int columnaExcel = 1;

                    for (int row = 0; row < lstVtaItems.Count; row++)
                    {
                        sheet[filaExcel, columnaExcel].Value = lstVtaItems[row].NombreProducto;

                        columnaExcel = columnaExcel + 4;

                        sheet[filaExcel, columnaExcel].Value = lstVtaItems[row].Cantidad.ToString();

                        columnaExcel = columnaExcel + 2;

                        sheet[filaExcel, columnaExcel].Value = lstVtaItems[row].PrecioVenta.ToString();

                        columnaExcel = columnaExcel + 2;

                        sheet[filaExcel, columnaExcel].Value = lstVtaItems[row].SubTotal.ToString();

                        Total += lstVtaItems[row].SubTotal;

                        filaExcel++;

                        columnaExcel = 1;
                    }

                    sheet.Range["I40"].Text = Total.ToString();
                }
            }

            sheet.Range["I41"].Text = tbDescuento.Value.ToString();

            sheet.Range["I42"].Text = 
                ((Total - (Total * Convert.ToDecimal(tbDescuento.Value)) /100)).ToString();

            #endregion

            Path = documento.PathGuardar();

            documento.ConvertirPDF(sheet, Path);

            workbook.Close();

            if(!string.IsNullOrEmpty(Path))
            {
                pdfDocView.Load(Path);
            }
        }

        public void LoadAutoCompleteVenta()
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                cbVenta.DataSource = contexto.ModeloVentas.Select(
                    a => a.IdVentas + "  -  " + a.FechaEgreso + "  -  " + a.cliente.Nombre + "  -  $" + a.Total).ToList();
            }

            if (cbVenta.Items.Count > 0)
            {
                lblVentaFC.Visible = true;

                lblVentaItemsFC.Visible = true;

                cbVenta.Enabled = true;

                btnGenerarDocumentacion.Enabled = true;
            }
            else
            {
                cbVenta.Text = "No hay datos Ingresados";

                cbVenta.Enabled = false;

                lblVentaFC.Visible = false;

                lblVentaItemsFC.Visible = false;

                btnGenerarDocumentacion.Enabled = false;
            }

            contexto.Dispose();
        }

        private void cbVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* carga la venta y la lista de venta asociadas al combo seleccionado */

            if (cbVenta.Items.Count > 0)
            {
                int idVenta = Convert.ToInt32(cbVenta.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

                using (contexto)
                {
                    var lstVta = contexto.ModeloVentas.Where(p => p.IdVentas == idVenta).Select(p =>
                    new
                    {
                        p.IdVentas,
                        p.cliente.Nombre,
                        p.Observacion,
                        p.Total,
                        p.FechaEgreso
                    }).OrderBy(p => p.IdVentas).ToList();

                    var lstVtaItems = contexto.ModeloVentaItems.Where(p => p.IdVentas == idVenta).Select(p =>
                    new
                    {
                        p.Codigo,
                        p.NombreProducto,
                        p.PrecioCosto,
                        p.Cantidad,
                        p.PrecioVenta,
                        p.SubTotal,
                        p.FechaEgreso
                    }).OrderBy(p => p.Codigo).ToList();

                    dgvVentaItems.DataSource = lstVtaItems;

                    dgvVenta.DataSource = lstVta;
                }

                contexto.Dispose();
            }
        }

        private bool ExisteDatosComboVenta()
        {
            bool existenDatos = false;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                cbVenta.DataSource = contexto.ModeloVentas.Select(
                    a => a.IdVentas + "  -  " + a.FechaEgreso + "  -  " + a.cliente.Nombre + "  -  $" + a.Total).ToList();
            }

            if (cbVenta.Items.Count > 0)
            {
                existenDatos = true;
            }

            return existenDatos;
        }

        #endregion

        private void LoadAutoCompleteClientes(ComboBox comboBox)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                comboBox.DataSource = contexto.ModeloCliente.Select(a => a.IdCliente + "  -  " + a.Nombre).ToList();
            }

            if (comboBox.Items.Count == 0)
            {
                comboBox.Text = comboBox.Text = "No hay datos Ingresados";

                comboBox.Enabled = false;
            }

            contexto.Dispose();
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            Form frMail = new Mail(this.Path);

            frMail.Show();
        }

        #region  Datos cliente / Empresa

        private ModelsCliente GetCliente(int intCodigo)
        {
            ModelsCliente cliente = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                cliente = contexto.ModeloCliente.Where(p => p.IdCliente == intCodigo).Select(x => x).FirstOrDefault();
            }

            contexto.Dispose();

            return cliente;
        }

        private void ComboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ExisteDatosCliente = false;

            int intCodigo = Convert.ToInt32(cbCliente.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

            ModelsCliente cliente = this.GetCliente(intCodigo);

            if (cliente != null)
            {
                tbNombre.Text = cliente.Nombre;

                tbDescripcion.Text = cliente.Descripcion;

                tbDomicilio.Text = cliente.Domicilio;

                tbTel.Text = cliente.Telefono;

                tbMail.Text = cliente.Mail;

                tbCuit.Text = cliente.Cuit;

                _ExisteDatosCliente = true;
            }
        }

        private void GetDatosEmpresa()
        {
            _ExisteDatosEmpresa = false;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                ModelsEmpresa empresa = contexto.ModeloEmpresa.Select(e => e).FirstOrDefault();

                if (empresa != null)
                {
                    tbNombreEmpresa.Text = empresa.Nombre;

                    tbDescEmpresa.Text = empresa.Descripcion;

                    tbDomicilioEmpresa.Text = empresa.Domicilio;

                    tbMailEmpresa.Text = empresa.Mail;

                    tbTelEmpresa.Text = empresa.Telefono;

                    tbCuitEmpresa.Text = empresa.Cuit;

                    contexto.SaveChanges();

                    this._ExisteDatosEmpresa = true;
                }
            }

            contexto.Dispose();
        }

        #endregion
    }
}
