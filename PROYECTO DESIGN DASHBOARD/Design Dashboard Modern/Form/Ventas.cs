using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Design_Dashboard_Modern.Clases;
using Design_Dashboard_Modern.Models;
using System.Data;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using Spire.License;

namespace Design_Dashboard_Modern
{
    public partial class Ventas : Form
    {
        private string _strContextoDB;

        private string _MensajeError;

        private string _MensajeOK;

        private DataTable dt;

        private Query query;

        public Ventas(string strContextoDB)
        {
            InitializeComponent();

            _strContextoDB = strContextoDB;

            _MensajeOK = string.Empty;

            _MensajeError = string.Empty;

            dt = new DataTable();

            query = new Query(strContextoDB);
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            this.VisibilidadPanel(pnlConsulta);

            this.LoadAutoCompleteClientes(cbClienteVta);

            this.LoadAutoCompleteProductos(cbProducto);

            this.InicializarItemsDataTable();

            this.GetVentas(dgvConsultaVta);
        }

        private void pbConsulta_Click_1(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlConsulta);

            this.GetVentas(dgvConsultaVta);
        }

        private void pbIngresar_Click_1(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlAgregar);

            btnIngresar.Visible = false;

        }

        private void InicializarItemsDataTable()
        {
            dt.Columns.Add("Codigo", typeof(string));

            dt.Columns.Add("Producto", typeof(string));

            dt.Columns.Add("Precio Costo", typeof(string));

            dt.Columns.Add("cantidad", typeof(string));

            dt.Columns.Add("Precio Venta", typeof(string));

            dt.Columns.Add("SubTotal", typeof(string));

            GrillaVentaItems.DataSource = dt;
        }

        #region CRUD

        private void GetVentas(DataGridView dgvConsulta)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                var lstVta = contexto.ModeloVentas.Select(p => new { p.IdVentas, p.cliente.Nombre, p.Observacion, p.Total, p.FechaEgreso }).ToList();

                dgvConsulta.DataSource = lstVta;
            }

            contexto.Dispose();
        }

        private void GetVentasItems(DataGridView dgvConsulta, int IdItems)
        {
            dgvConsultaVtaItems.Visible = true;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                var lstVta = contexto.ModeloVentaItems.Where(p => p.IdVentas == IdItems).Select(p =>
                    new { p.Codigo, p.NombreProducto, p.PrecioCosto, p.Cantidad, p.PrecioVenta, p.SubTotal, p.FechaEgreso }).ToList();

                dgvConsulta.DataSource = lstVta;
            }

            contexto.Dispose();
        }

        private ModelsCliente GetCliente(int intCodigo)
        {
            ModelsCliente cliente = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                cliente = contexto.ModeloCliente.Where(p => p.IdCliente == intCodigo).Select(x => x).FirstOrDefault();
            }

            contexto.Dispose();

            return cliente;
        }

        private void IngresarVenta_Click_1(object sender, EventArgs e)
        {
            bool esValidaLaVenta = false;

            _MensajeOK = string.Empty;

            decimal TotalVenta = 0;

            ModelsVentas venta = new ModelsVentas();

            ModelsVentaItems ventaItems;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                var Codigo = Convert.ToInt32(cbClienteVta.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                venta.Total = CalcularTotalItems();

                venta.FechaEgreso = dateFEgresoVta.Value;

                ModelsCliente cliente = this.GetCliente(Codigo);

                venta.IdCliente = cliente.IdCliente;

                esValidaLaVenta = this.ValidacionVenta(venta);

                if (!esValidaLaVenta)
                {
                    #region items Venta

                    /*Los Items en el data table a esta instancias ya estan validados*/

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ventaItems = new ModelsVentaItems();

                        ventaItems.NombreProducto = dt.Rows[i]["Producto"].ToString();

                        ventaItems.Codigo = Convert.ToInt32(dt.Rows[i]["Codigo"].ToString());

                        ventaItems.Cantidad = Convert.ToInt32(dt.Rows[i]["Cantidad"].ToString());

                        ventaItems.PrecioVenta = Convert.ToDecimal(dt.Rows[i]["Precio Venta"].ToString());

                        ventaItems.PrecioCosto = Convert.ToDecimal(dt.Rows[i]["Precio Costo"].ToString());

                        ventaItems.SubTotal = ventaItems.Cantidad * ventaItems.PrecioVenta;

                        ventaItems.FechaEgreso = dateFEgresoVta.Value;

                        contexto.ModeloVentaItems.Add(ventaItems);
                    }

                    #endregion
                  
                    #region Actualizar cantidades del producto al guardar y total

                    ModelsProducto producto = null;

                    foreach (DataGridViewRow row in GrillaVentaItems.Rows)
                    {
                        int CodigoFila = Convert.ToInt32(row.Cells["Codigo"].Value);

                        producto = contexto.ModeloProducto.Where(p => p.Codigo == CodigoFila).Select(x => x).FirstOrDefault();

                        if (producto != null)
                        {
                            int nuevaCantidad = producto.Cantidad - Convert.ToInt32(row.Cells["Cantidad"].Value);

                            query.qProducto_uCantidad(CodigoFila, nuevaCantidad);

                            query.qProducto_uTotal(CodigoFila, (producto.PrecioCosto * nuevaCantidad));

                            TotalVenta += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                        }
                    }

                    venta.Total = TotalVenta;

                    contexto.ModeloVentas.Add(venta);

                    #endregion

                    contexto.SaveChanges();

                    _MensajeOK += "Datos ingresados correctamente" + Environment.NewLine;


                    dt.Clear();
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.EliminarCantidadCero();

            this.LoadAutoCompleteProductos(cbProducto);

            this.BlanquearControladores();

            this.VisibilidadPanel(pnlConsulta);

            this.GetVentas(dgvConsultaVta);
        }

        private void IngresarVentaItems_Click(object sender, EventArgs e)
        {
            /* Se carga el data table al ingresar items*/

            ModelsProducto producto = null;

            decimal precioCosto = 0;

            string strProducto = cbProducto.SelectedValue.ToString().Split('-')[1].TrimStart().TrimEnd();

            int intCodigo = Convert.ToInt32(cbProducto.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

            decimal dcSubTotal = tbCantidad.Value * tbPrecioU.Value;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                producto = contexto.ModeloProducto.Where(p => p.Codigo == intCodigo).Select(x => x).FirstOrDefault();

                if (producto != null)
                {
                    precioCosto = producto.PrecioCosto;
                }
            }

            contexto.Dispose();

            /* se agrega contenido al dt las columnas estan definidas en el metodo InicializarItemsDataTable() */

            dt.Rows.Add(new object[]
            {
                intCodigo,
                strProducto,
                precioCosto,
                tbCantidad.Text,
                tbPrecioU.Text,
                dcSubTotal
            });

            GrillaVentaItems.DataSource = dt;

            tbCantidad.Maximum = producto.Cantidad - CantidadProductoIngresados(intCodigo);

            if (GrillaVentaItems.RowCount > 0)
            {
                btnIngresar.Visible = true;
            }
            else
            {
                btnIngresar.Visible = false;
            }
        }

        private void GrillaVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _MensajeOK = string.Empty;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvConsultaVta.Rows[e.RowIndex];

                if (row.Cells[0].Selected)
                {
                    /* Obtiene los Items de las ventas seleccionada */

                    int idVenta = Convert.ToInt32(row.Cells[2].Value);

                    this.GetVentasItems(dgvConsultaVtaItems, idVenta);

                    dgvConsultaVtaItems.Visible = true;
                }
                if (row.Cells[1].Selected)
                {
                    /* Elimina la venta selecionada y su respectivos Items */

                    int intIdVenta = Convert.ToInt32(row.Cells[2].Value);

                    using (contexto)
                    {
                        List<ModelsVentaItems> ventaItems = contexto.ModeloVentaItems.Where(p => p.IdVentas == intIdVenta).Select(x => x).ToList();

                        if (ventaItems.Count > 0)
                        {
                            foreach (ModelsVentaItems items in ventaItems)
                            {
                                bool exists = contexto.ModeloProducto.Any(p => p.Codigo == items.Codigo);

                                if (exists)
                                {
                                    this.ModificarMercaderiaEliminada(items);
                                }
                                else
                                {
                                    this.AgregarMercaderiaEliminada(items);
                                }
                            }
                        }

                        ModelsVentas venta = contexto.ModeloVentas.Where(p => p.IdVentas == intIdVenta).Select(x => x).FirstOrDefault();

                        contexto.ModeloVentas.Remove(venta);

                        contexto.SaveChanges();

                        dgvConsultaVtaItems.Visible = false;

                        _MensajeOK += "Ventas eliminadas correctamenta, los items asociados se incluyeron al Stock de Producto" + Environment.NewLine;
                    }
                }

                contexto.Dispose();

                this.MsjeValidacion();

                this.GetVentas(dgvConsultaVta);

            }
        }

        private void ModificarMercaderiaEliminada(ModelsVentaItems item)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            ModelsProducto producto = null;

            using (contexto)
            {
                /* Aumenta la cantidad del producto al eliminar una venta y recalcula el nuevo total*/

                producto = contexto.ModeloProducto.Where(p => p.Codigo == item.Codigo).Select(x => x).FirstOrDefault();

                if (producto != null)
                {
                    producto.Cantidad = producto.Cantidad + item.Cantidad;

                    producto.Total = producto.Cantidad * producto.PrecioCosto;

                    contexto.SaveChanges();
                }
            }

            contexto.Dispose();
        }

        private void AgregarMercaderiaEliminada(ModelsVentaItems item)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                ModelsProducto nuevoProducto = new ModelsProducto();

                nuevoProducto.Codigo = item.Codigo;

                nuevoProducto.Nombre = item.NombreProducto;

                nuevoProducto.Descripcion = item.Descripcion;

                nuevoProducto.Cantidad = Convert.ToInt32(item.Cantidad.ToString());

                nuevoProducto.PrecioCosto = Convert.ToDecimal(item.PrecioCosto);

                nuevoProducto.Total = Convert.ToDecimal(Convert.ToInt32(item.Cantidad) * Convert.ToDecimal(item.PrecioCosto));

                nuevoProducto.FechaIngreso = DateTime.Now;

                bool blnValida = this.ValidacionProducto(nuevoProducto);

                if (!blnValida)
                {
                    contexto.ModeloProducto.Add(nuevoProducto);

                    contexto.SaveChanges();
                }
            }

            contexto.Dispose();
        }

        private bool ValidacionProducto(ModelsProducto producto)
        {
            bool blnValida = false;

            _MensajeError = string.Empty;

            ValidationContext validationContext = new ValidationContext(producto, null, null);

            List<ValidationResult> resultadoValidacion = new List<ValidationResult>();

            Validator.TryValidateObject(producto, validationContext, resultadoValidacion, true);

            if (resultadoValidacion.Count() > 0)
            {
                foreach (var error in resultadoValidacion)
                {
                    _MensajeError += error.ErrorMessage + Environment.NewLine;
                }

                blnValida = true;
            }

            return blnValida;
        }

        private void GrillaVentaItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Grilla Ventas items que tiene cargado el data table al ingresar articulo*/

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GrillaVentaItems.Rows[e.RowIndex];

                if (row.Cells[0].Selected)
                {
                    dt.Rows[e.RowIndex].Delete();
                }
            }

            if(GrillaVentaItems.RowCount <= 0)
            {
                btnIngresar.Visible = false;
            }
        }

        private decimal CalcularTotalItems()
        {
            decimal aux = 0;

            foreach (DataGridViewRow row in GrillaVentaItems.Rows)
            {
                aux += Convert.ToDecimal(Convert.ToDecimal(row.Cells["SubTotal"].Value));
            }

            return aux;
        }

        #endregion

        public void LoadAutoCompleteClientes(ComboBox comboBox)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                comboBox.DataSource = contexto.ModeloCliente.Select(a => a.IdCliente + "  -  " + a.Nombre).ToList();
            }

            contexto.Dispose();
        }

        public void LoadAutoCompleteProductos(ComboBox comboBox)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                comboBox.DataSource = contexto.ModeloProducto.Select(a => a.Codigo + "  -  " + a.Nombre).ToList();
            }

            if (cbProducto.Items.Count == 0)
            {
                pbAgregarItemsVenta.Enabled = false;

                tbCantidad.Enabled = false;

                tbPrecioU.Enabled = false;

                comboBox.Text = "No hay datos Ingresados";

                comboBox.Enabled = false;

                tbCantidad.ResetText();

                tbPrecioU.ResetText();
            }

            contexto.Dispose();
        }

        private void BlanquearControladores()
        {
            dt.Clear();

            this.LoadAutoCompleteClientes(cbClienteVta);

            this.LoadAutoCompleteProductos(cbProducto);
        }

        private void pbExcel_Click_1(object sender, EventArgs e)
        {
            ExportarExcel.ToCsV(dgvConsultaVta);
        }

        private void VisibilidadPanel(Panel pnlVisible)
        {
            List<Panel> pnl = new List<Panel>();

            pnl.Add(pnlAgregar);

            pnl.Add(pnlConsulta);

            pnl.Remove(pnlVisible);

            foreach (Panel i in pnl)
            {
                i.Hide();
            }

            pnlVisible.Show();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Determina el valor maximo y minimo de producto que puede ingresas en el texbox de cantidad y precio*/

            int Codigo = Convert.ToInt32(cbProducto.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

            ModelsProducto producto = query.qProducto_c(Codigo).FirstOrDefault();

            tbCantidad.Value = 0;

            tbPrecioU.Minimum = producto.PrecioCosto;

            tbPrecioU.Value = producto.PrecioCosto;

            tbCantidad.Maximum = producto.Cantidad - CantidadProductoIngresados(Codigo);
        }

        private int CantidadProductoIngresados(int codigo)
        {
            int sumatoriaCantidad = 0;

            foreach (DataGridViewRow row in GrillaVentaItems.Rows)
            {
                if (Convert.ToInt32(row.Cells["Codigo"].Value) == codigo)
                {
                    sumatoriaCantidad += Convert.ToInt32(row.Cells["Cantidad"].Value);
                }
            }

            return sumatoriaCantidad;
        }

        private void EliminarCantidadCero()
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                List<ModelsProducto> lstProducto = contexto.ModeloProducto.Where(p => p.Cantidad == 0).Select(x => x).ToList();

                foreach (ModelsProducto producto in lstProducto)
                {
                    contexto.ModeloProducto.Remove(producto);
                }

                contexto.SaveChanges();
            }

            contexto.Dispose();
        }

        #region Validacion

        private void MsjeValidacion()
        {
            if (_MensajeError.Count() > 0)
            {
                this.FormValidacion(_MensajeError, 1);
            }
            if (_MensajeOK.Count() > 0)
            {
                this.FormValidacion(_MensajeOK, 2);
            }
        }

        private void FormValidacion(string msje, int tipo)
        {
            var form = Application.OpenForms.OfType<Mensaje>().FirstOrDefault();

            Mensaje frMsje = form ?? new Mensaje(msje, tipo);

            frMsje.Show();
        }

        private bool ValidacionVenta(ModelsVentas venta)
        {
            bool blnValida = false;

            _MensajeError = string.Empty;

            ValidationContext validationContext = new ValidationContext(venta, null, null);

            List<ValidationResult> resultadoValidacion = new List<ValidationResult>();

            Validator.TryValidateObject(venta, validationContext, resultadoValidacion, true);

            if (resultadoValidacion.Count() > 0)
            {
                foreach (var error in resultadoValidacion)
                {
                    _MensajeError += error.ErrorMessage + Environment.NewLine;
                }

                blnValida = true;
            }

            return blnValida;
        }

        #endregion

    }
}
