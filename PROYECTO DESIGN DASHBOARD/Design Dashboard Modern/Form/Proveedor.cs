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
    public partial class Proveedor : Form
    {
        private string strContextoDB;

        private string MensajeError;

        private string MensajeOK;

        public Proveedor(string strContextoDB)
        {
            InitializeComponent();

            this.VisibilidadPanel(pnlConsulta);

            this.strContextoDB = strContextoDB;

            MensajeError = string.Empty;

            MensajeOK = string.Empty;
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlConsulta);

            this.Consultar(dgvConsulta);

            this.LoadAutoComplete(cbProveedorEditar);

            this.LoadAutoComplete(cbProveedorEliminar);
        }

        private void pbConsulta_Click_3(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlConsulta);

            this.Consultar(dgvConsulta);

            this.BlanquearControladores();
        }

        private void pbIngresar_Click_3(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlAgregar);

            this.BlanquearControladores();
        }

        private void pbEditar_Click_3(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlEditar);

            this.BlanquearControladores();
        }

        private void pbEliminar_Click_3(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlEliminar);

            this.BlanquearControladores();
        }

        #region CRUD

        private void Consultar(DataGridView dgvConsulta)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                var lstProveedor = contexto.ModeloProveedor.Select
                    (p => new { p.Cuit, p.Nombre, p.Descripcion, p.Domicilio, p.Telefono, p.Mail })
                    .OrderBy(p => p.Nombre).ToList();

                dgvConsulta.DataSource = lstProveedor;

                contexto.Dispose();
            }
        }

        private void btnIngresar_Click_3(object sender, EventArgs e)
        {
            bool blnValida = false;

            MensajeOK = string.Empty;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                ModelsProveedor nuevoproveedor = new ModelsProveedor();

                nuevoproveedor.Nombre = tbNombreAgregar.Text;

                nuevoproveedor.Descripcion = tbDescAgregar.Text;

                nuevoproveedor.Domicilio = tbDomicilioAgregar.Text;

                nuevoproveedor.Mail = tbMailAgregar.Text;

                nuevoproveedor.Telefono = tbTelAgregar.Text;

                nuevoproveedor.Cuit = tbCuitAgregar.Text;

                nuevoproveedor.FechaIngreso = dateFIngresoProveedor.Value;

                blnValida = this.ValidacionProveedor(nuevoproveedor, contexto);

                if (!blnValida)
                {
                    contexto.ModeloProveedor.Add(nuevoproveedor);

                    contexto.SaveChanges();

                    MensajeOK += "Proveedor Ingresado correctamente" + Environment.NewLine;
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void btnEliminar_Click_3(object sender, EventArgs e)
        {
            bool blnValida = false;

            MensajeOK = string.Empty;

            ModelsProveedor proveedor = null;

            int intCodigo = Convert.ToInt32(cbProveedorEliminar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                proveedor = contexto.ModeloProveedor.Where(p => p.IdProveedores == intCodigo).Select(x => x).FirstOrDefault(); ;

                blnValida = this.ValidacionProveedor(proveedor, contexto);

                if (!blnValida)
                {
                    contexto.ModeloProveedor.Remove(proveedor);

                    contexto.SaveChanges();

                    MensajeOK += "Proveedor Eliminado correctamente" + Environment.NewLine;
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void btnModificar_Click_3(object sender, EventArgs e)
        {
            bool blnValida = false;

            MensajeOK = string.Empty;

            ModelsProveedor proveedor = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbProveedorEditar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                proveedor = contexto.ModeloProveedor.Where(p => p.IdProveedores == intCodigo).Select(x => x).FirstOrDefault();

                if (proveedor != null)
                {
                    proveedor.IdProveedores = intCodigo;

                    proveedor.Nombre = tbNombreEditar.Text;

                    proveedor.Descripcion = tbDescEditar.Text;

                    proveedor.Domicilio = tbDomicilioEditar.Text;

                    proveedor.Telefono = tbTelEditar.Text;

                    proveedor.Mail = tbMailEditar.Text;

                    proveedor.Cuit = tbCuitEditar.Text;

                    proveedor.FechaIngreso = tbFechaIngEditar.Value;

                    blnValida = this.ValidacionProveedor(proveedor, contexto);

                    if (!blnValida)
                    {
                        contexto.SaveChanges();

                        MensajeOK += "Proveedor Modificado correctamente" + Environment.NewLine;
                    }
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void ComboProveedorEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelsProveedor proveedor = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbProveedorEliminar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                proveedor = contexto.ModeloProveedor.Where(p => p.IdProveedores == intCodigo).Select(x => x).FirstOrDefault();

                if (proveedor != null)
                {
                    tbNombreEliminar.Text = proveedor.Nombre;

                    tbDescEliminar.Text = proveedor.Descripcion;

                    tbDomicilioEliminar.Text = proveedor.Domicilio;

                    tbMailEliminar.Text = proveedor.Mail;

                    tbTelEliminar.Text = proveedor.Telefono;

                    tbCuitEliminar.Text = proveedor.Cuit;

                    tbFechaIngEliminar.Value = proveedor.FechaIngreso;
                }
            }
        }

        private void ComboProveedorEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelsProveedor proveedor = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbProveedorEditar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                proveedor = contexto.ModeloProveedor.Where(p => p.IdProveedores == intCodigo).Select(x => x).FirstOrDefault();

                if (proveedor != null)
                {                   
                    tbNombreEditar.Text = proveedor.Nombre;

                    tbDescEditar.Text = proveedor.Descripcion;

                    tbDomicilioEditar.Text = proveedor.Domicilio;

                    tbMailEditar.Text = proveedor.Mail;

                    tbTelEditar.Text = proveedor.Telefono;

                    tbCuitEditar.Text = proveedor.Cuit;

                    tbFechaIngEditar.Value = proveedor.FechaIngreso;
                }
            }
        }

        #endregion

        #region Filtros

        public void FiltrarGrid(TextBox tbFiltro, ComboBox cbFiltro, DataGridView dgvConsulta)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            string strQuery = null;

            int temp = 0;

            using (contexto)
            {
                if (!string.IsNullOrEmpty(tbFiltro.Text))
                {
                    switch (cbFiltro.SelectedItem.ToString())
                    {
                        case "Codigo":

                            strQuery = " = " + tbFiltro.Text;

                            if (int.TryParse(tbFiltro.Text, out temp))
                            {
                                var query = contexto.ModeloProducto.SqlQuery(
                                 "SELECT * FROM " + "Producto WHERE " + cbFiltro.SelectedItem.ToString() + " " + strQuery).ToList();

                                dgvConsulta.DataSource = query;
                            }

                            break;

                        case "Nombre":
                        case "Telefono":
                        case "Cuit":

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

        private void tbFiltro_TextChanged_3(object sender, EventArgs e)
        {
            this.FiltrarGrid(tbFiltro, cbFiltro, dgvConsulta);
        }

        private void cbFiltro_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            tbFiltro.Text = string.Empty;

            tbFiltro.Enabled = true;
        }

        #endregion

        private void pbExcel_Click_3(object sender, EventArgs e)
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

            tbNombreAgregar.Text = string.Empty;

            tbDescAgregar.Text = string.Empty;

            tbTelAgregar.Text = string.Empty;

            tbDomicilioAgregar.Text = string.Empty;

            tbMailAgregar.Text = string.Empty;

            this.LoadAutoComplete(cbProveedorEditar);

            this.LoadAutoComplete(cbProveedorEliminar);
        }

        public void LoadAutoComplete(ComboBox comboBox)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                comboBox.DataSource = contexto.ModeloProveedor.Select(a => a.IdProveedores + "  -  " + a.Nombre).ToList();
            }

            if (comboBox.Items.Count == 0)
            {

                comboBox.Text = "No hay datos Ingresados";

                comboBox.Enabled = false;


                tbDescEliminar.Text = string.Empty;

                tbNombreEliminar.Text = string.Empty;

                tbCuitEliminar.Text = string.Empty;

                tbMailEliminar.Text = string.Empty;

                tbTelEliminar.Text = string.Empty;

                tbDomicilioEliminar.Text = string.Empty;


                btnEliminar.Enabled = false;


                tbDescEditar.Text = string.Empty;

                tbNombreEditar.Text = string.Empty;

                tbCuitEditar.Text = string.Empty;

                tbMailEditar.Text = string.Empty;

                tbTelEditar.Text = string.Empty;

                tbDomicilioEditar.Text = string.Empty;


                tbDescEditar.Enabled = false;

                tbNombreEditar.Enabled = false;

                tbCuitEditar.Enabled = false;

                tbMailEditar.Enabled = false;

                tbTelEditar.Enabled = false;

                tbDomicilioEditar.Enabled = false;

                tbFechaIngEditar.Enabled = false;


                btnModificar.Enabled = false;
            }
            else
            {
                comboBox.Enabled = true;

                btnModificar.Enabled = true;

                btnEliminar.Enabled = true;


                tbDescEditar.Enabled = true;

                tbNombreEditar.Enabled = true;

                tbCuitEditar.Enabled = true;

                tbMailEditar.Enabled = true;

                tbTelEditar.Enabled = true;

                tbDomicilioEditar.Enabled = true;

                tbFechaIngEditar.Enabled = true;
            }

            contexto.Dispose();
        }

        #region Validacion

        private void MsjeValidacion()
        {
            if (MensajeError.Count() > 0)
            {
                this.FormValidacion(MensajeError, 1);
            }
            if (MensajeOK.Count() > 0)
            {
                this.FormValidacion(MensajeOK, 2);
            }
        }

        private void FormValidacion(string msje, int tipo)
        {
            var form = Application.OpenForms.OfType<Mensaje>().FirstOrDefault();

            Mensaje frMsje = form ?? new Mensaje(msje, tipo);

            frMsje.Show();
        }

        private bool ValidacionProveedor(ModelsProveedor proveedor, DBContext contexto)
        {
            bool blnValida = false;

            MensajeError = string.Empty;

            ValidationContext validationContext = new ValidationContext(proveedor, null, null);

            List<ValidationResult> resultadoValidacion = new List<ValidationResult>();

            Validator.TryValidateObject(proveedor, validationContext, resultadoValidacion, true);

            if (resultadoValidacion.Count() > 0)
            {
                foreach (var error in resultadoValidacion)
                {
                    MensajeError += error.ErrorMessage + Environment.NewLine;
                }

                blnValida = true;
            }

            return blnValida;
        }

        #endregion

    }
}
