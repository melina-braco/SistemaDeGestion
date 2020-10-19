using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Design_Dashboard_Modern.Clases;
using Design_Dashboard_Modern.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Design_Dashboard_Modern
{
    public partial class Mercaderia : Form
    {
        private string _strContextoDB;

        private string _MensajeError;

        private string _MensajeOK;

        public Mercaderia(string strContextoDB)
        {
            InitializeComponent();

            _strContextoDB = strContextoDB;

            _MensajeOK = string.Empty;

            _MensajeError = string.Empty;
        }

        private void Mercaderia_Load(object sender, EventArgs e)
        {
            this.VisibilidadPanel(pnlConsulta);

            this.Consultar(dgvConsulta);

            this.LoadAutoComplete(cbProductoEditar);

            this.LoadAutoComplete(cbProductoEliminar);
        }

        private void pbConsulta_Click(object sender, EventArgs e)
        {
            this.VisibilidadPanel(pnlConsulta);

            this.Consultar(dgvConsulta);

            this.BlanquearControladores();
        }

        private void pbIngresar_Click(object sender, EventArgs e)
        {
            this.VisibilidadPanel(pnlAgregar);

            this.BlanquearControladores();
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            this.VisibilidadPanel(pnlEditar);

            this.BlanquearControladores();
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            this.VisibilidadPanel(pnlEliminar);

            this.BlanquearControladores();
        }

        #region CRUD

        public void Consultar(DataGridView dgvConsulta)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                var lstProducto = contexto.ModeloProducto.Select(p => new
                {
                    p.Codigo,
                    p.Nombre,
                    p.Descripcion,
                    p.Cantidad,
                    p.PrecioCosto,
                    p.Total,
                    p.FechaIngreso
                }).OrderBy(p => p.Codigo).ToList();

                dgvConsulta.DataSource = lstProducto;

            }

            contexto.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _MensajeOK = string.Empty;

            bool blnValida = false;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(tbCodigoEliminar.Text);

                ModelsProducto producto = contexto.ModeloProducto.Where(p => p.Codigo == intCodigo).Select(x => x).FirstOrDefault(); ;

                blnValida = this.ValidacionProducto(producto, contexto);

                if (!blnValida)
                {
                    contexto.ModeloProducto.Remove(producto);

                    contexto.SaveChanges();

                    _MensajeOK += "Producto Eliminado Correctamente" + Environment.NewLine;
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool blnValida = false;

            _MensajeOK = string.Empty;

            _MensajeError = string.Empty;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            /* verifica que el valor ingresado en el campo codigo se unico  */

            int CodigoArticulo = Convert.ToInt32(tbCodigoAgregar.Text);

            bool exists = contexto.ModeloProducto.Any(p => p.Codigo == CodigoArticulo);

            if (!exists)
            {
                using (contexto)
                {
                    ModelsProducto nuevoProducto = new ModelsProducto();

                    nuevoProducto.Codigo = CodigoArticulo;

                    nuevoProducto.Nombre = tbNombreAgregar.Text;

                    nuevoProducto.Descripcion = tbDescAgregar.Text;

                    nuevoProducto.Cantidad = Convert.ToInt32(tbCantidadAgregar.Value);

                    nuevoProducto.PrecioCosto = tbPrecioAgregar.Value;

                    nuevoProducto.Total = tbCantidadAgregar.Value * tbPrecioAgregar.Value;

                    nuevoProducto.FechaIngreso = dateFIngresoArticulo.Value;

                    blnValida = this.ValidacionProducto(nuevoProducto, contexto);

                    if (!blnValida)
                    {
                        contexto.ModeloProducto.Add(nuevoProducto);

                        contexto.SaveChanges();

                        _MensajeOK += "Producto Ingresado correctamente" + Environment.NewLine;
                    }
                }
            }
            else
            {
                _MensajeError += "El codigo ingresado para dicho articulo ya se encuentra en uso" + Environment.NewLine;
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool blnValida = false;

            _MensajeOK = string.Empty;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(tbCodigoEditar.Text);

                ModelsProducto producto = contexto.ModeloProducto.Where(p => p.Codigo == intCodigo).Select(x => x).FirstOrDefault();

                if (producto != null)
                {
                    /* modifica los campos venta item que tienen informacion del producto */

                    var lstVtaItems = contexto.ModeloVentaItems.Where(p => p.Codigo == intCodigo).ToList();

                    for (int row = 0; row < lstVtaItems.Count; row++)
                    {
                        lstVtaItems[row].NombreProducto = tbNombreEditar.Text;

                        lstVtaItems[row].PrecioCosto = Convert.ToDecimal(tbPrecioEditar.Text);
                    }

                    producto.Nombre = tbNombreEditar.Text;

                    producto.Descripcion = tbDescEditar.Text;

                    producto.Cantidad = Convert.ToInt32(tbCantEditar.Text);

                    producto.PrecioCosto = Convert.ToDecimal(tbPrecioEditar.Text);

                    producto.Total = producto.Cantidad * producto.PrecioCosto;

                    producto.FechaIngreso = tbFechaEditar.Value;

                    blnValida = this.ValidacionProducto(producto, contexto);

                    if (!blnValida)
                    {
                        contexto.SaveChanges();

                        _MensajeOK += "Producto Modificado correctamente" + Environment.NewLine;
                    }
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void cbProductoEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelsProducto producto = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbProductoEditar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                producto = contexto.ModeloProducto.Where(p => p.Codigo == intCodigo).Select(x => x).FirstOrDefault();

                if (producto != null)
                {
                    tbCodigoEditar.Text = producto.Codigo.ToString();

                    tbNombreEditar.Text = producto.Nombre;

                    tbDescEditar.Text = producto.Descripcion;

                    tbCantEditar.Text = producto.Cantidad.ToString();

                    tbPrecioEditar.Text = producto.PrecioCosto.ToString();

                    tbFechaEditar.Value = producto.FechaIngreso;
                }
            }
        }

        private void cbProductoEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelsProducto producto = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbProductoEliminar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                producto = contexto.ModeloProducto.Where(p => p.Codigo == intCodigo).Select(x => x).FirstOrDefault();

                if (producto != null)
                {
                    tbCodigoEliminar.Text = producto.Codigo.ToString();

                    tbNombreEliminar.Text = producto.Nombre;

                    tbDescEliminar.Text = producto.Descripcion;

                    tbCantEliminar.Text = producto.Cantidad.ToString();

                    tbPrecioEliminar.Text = producto.PrecioCosto.ToString();

                    tbFechaEliminar.Value = producto.FechaIngreso;
                }
            }
        }

        #endregion

        #region Filtros

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            this.FiltrarGrid(tbFiltro, cbFiltro, dgvConsulta);
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFiltro.Text = string.Empty;

            tbFiltro.Enabled = true;
        }

        public void FiltrarGrid(TextBox tbFiltro, ComboBox cbFiltro, DataGridView dgvConsulta)
        {
            _MensajeError = string.Empty;

            string strQuery = string.Empty;

            int temp = 0;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                if (!string.IsNullOrEmpty(tbFiltro.Text))
                {
                    switch (cbFiltro.SelectedItem.ToString())
                    {
                        case "Codigo":
                        case "Cantidad":                    

                            strQuery = " = " + tbFiltro.Text;

                            /* Valida si es un valor nuemerico */

                            if (int.TryParse(tbFiltro.Text, out temp))
                            {
                                var query = contexto.ModeloProducto.SqlQuery(
                                 "SELECT * FROM " + "Producto WHERE " + cbFiltro.SelectedItem.ToString() + " " + strQuery).ToList();

                                dgvConsulta.DataSource = query;
                            }

                            break;

                        case "Nombre":

                            /* Valida si es un valor nuemerico*/

                            strQuery = " = '" + tbFiltro.Text + "'";

                            if (!int.TryParse(tbFiltro.Text, out temp))
                            {
                                var query = contexto.ModeloProducto.SqlQuery(
                                 "SELECT * FROM " + "Producto WHERE " + cbFiltro.SelectedItem.ToString() + " " + strQuery).ToList();

                                dgvConsulta.DataSource = query;
                            }

                            break;

                        default:

                            strQuery = null;

                            break;
                    }
                }
                else
                {
                    Consultar(dgvConsulta);
                }

                contexto.Dispose();
            }
        }

        #endregion

        private void pbExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel.ToCsV(dgvConsulta);
        }

        private void VisibilidadPanel(Panel pnlVisible)
        {
            List<Panel> pnl = new List<Panel>();

            pnl.Add(pnlAgregar);

            pnl.Add(pnlConsulta);

            pnl.Add(pnlEditar);

            pnl.Add(pnlEliminar);

            pnl.Remove(pnlVisible);

            foreach (Panel i in pnl)
            {
                i.Hide();
            }

            pnlVisible.Show();
        }

        private void BlanquearControladores()
        {
            tbCodigoAgregar.Text = string.Empty;

            tbNombreAgregar.Text = string.Empty;

            tbDescAgregar.Text = string.Empty;

            tbCantidadAgregar.Value = 1;

            tbPrecioAgregar.Value = 0.000m;

            this.LoadAutoComplete(cbProductoEditar);

            this.LoadAutoComplete(cbProductoEliminar);


        }

        public void LoadAutoComplete(ComboBox comboBox)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strContextoDB].ConnectionString);

            using (contexto)
            {
                comboBox.DataSource = contexto.ModeloProducto.Select(a => a.Codigo + "  -  " + a.Nombre).ToList();
            }

            if (comboBox.Items.Count == 0)
            {
                comboBox.Text = "No hay datos Ingresados";

                comboBox.Enabled = false;

                tbCodigoEliminar.Text = string.Empty;

                tbDescEliminar.Text = string.Empty;

                tbNombreEliminar.Text = string.Empty;

                tbCantEliminar.Text = string.Empty;

                tbPrecioEliminar.Text = string.Empty;

                btnEliminar.Enabled = false;


                tbCodigoEditar.Text = string.Empty;

                tbNombreEditar.Text = string.Empty;

                tbDescEditar.Text = string.Empty;

                tbCantEditar.Value = 1;

                tbPrecioEditar.Value = 0.000m;

                tbCodigoEditar.Enabled = false;

                tbNombreEditar.Enabled = false;

                tbDescEditar.Enabled = false;

                tbCantEditar.Enabled = false;

                tbPrecioEditar.Enabled = false;

                tbFechaEditar.Enabled = false;

                btnModificar.Enabled = false;

            }
            else
            {
                comboBox.Enabled = true;

                tbNombreEditar.Enabled = true;

                tbDescEditar.Enabled = true;

                tbCantEditar.Enabled = true;

                tbPrecioEditar.Enabled = true;

                tbFechaEditar.Enabled = true;

                btnModificar.Enabled = true;

                btnEliminar.Enabled = true;
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

        private bool ValidacionProducto(ModelsProducto producto, DBContext contexto)
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

        #endregion
    }
}
