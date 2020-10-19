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
    public partial class Clientes : Form
    {
        private string strContextoDB;

        private string MensajeError;

        private string MensajeOK;

        public Clientes(string strContextoDB)
        {
            InitializeComponent();

            this.strContextoDB = strContextoDB;

            this.LoadAutoComplete(cbClienteEditar);

            this.LoadAutoComplete(cbClienteEliminar);

            MensajeError = string.Empty;

            MensajeOK = string.Empty;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.VisibilidadPanel(pnlConsulta);

            this.Consultar(dgvConsulta);
        }

        private void pbConsulta_Click_2(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlConsulta);

            this.Consultar(dgvConsulta);

            this.BlanquearControladores();
        }

        private void pbIngresar_Click_2(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlAgregar);

            this.BlanquearControladores();
        }

        private void pbEditar_Click_2(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlEditar);

            this.BlanquearControladores();
        }

        private void pbEliminar_Click_2(object sender, EventArgs e)
        {
            VisibilidadPanel(pnlEliminar);

            this.BlanquearControladores();
        }

        #region CRUD

        public void Consultar(DataGridView dgvConsulta)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                var lstCliente = contexto.ModeloCliente.Select
                    (p => new { p.Cuit,  p.Nombre, p.Descripcion, p.Domicilio, p.Telefono, p.Mail })
                    .OrderBy(p => p.Nombre).ToList();

                dgvConsulta.DataSource = lstCliente;
            }

            contexto.Dispose();
        }  

        private void btnIngresar_Click_2(object sender, EventArgs e)
        {
            bool blnValida = false;

            MensajeOK = string.Empty;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {              
                ModelsCliente nuevocliente = new ModelsCliente();

                nuevocliente.Nombre = tbNombreAgregar.Text;

                nuevocliente.Descripcion = tbDescAgregar.Text;

                nuevocliente.Domicilio = tbDescAgregar.Text;

                nuevocliente.Mail = tbMailAgregar.Text;

                nuevocliente.Telefono = tbTelAgregar.Text;

                nuevocliente.Cuit = tbCuitAgregar.Text;

                nuevocliente.FechaIngreso = dateFIngresoCliente.Value;

                blnValida = this.ValidacionCliente(nuevocliente, contexto);

                if (!blnValida)
                {
                    contexto.ModeloCliente.Add(nuevocliente);

                    contexto.SaveChanges();

                    MensajeOK += "Cliente Ingresado correctamente" + Environment.NewLine;
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void btnEliminar_Click_2(object sender, EventArgs e)
        {
            bool blnValida = false;

            MensajeOK = string.Empty;

            ModelsCliente cliente = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbClienteEliminar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                cliente = contexto.ModeloCliente.Where(p => p.IdCliente == intCodigo).Select(x => x).FirstOrDefault(); ;

                blnValida = this.ValidacionCliente(cliente, contexto);

                if (!blnValida)
                {
                    contexto.ModeloCliente.Remove(cliente);

                    contexto.SaveChanges();

                    MensajeOK += "Cliente Eliminado correctamente" + Environment.NewLine;
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void btnModificar_Click_2(object sender, EventArgs e)
        {
            MensajeOK = string.Empty;

            bool blnValida = false;

            ModelsCliente cliente = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbClienteEditar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                cliente = contexto.ModeloCliente.Where(p => p.IdCliente == intCodigo).Select(x => x).FirstOrDefault();

                if (cliente != null)
                {
                    cliente.IdCliente = intCodigo;

                    cliente.Nombre = tbNombreEditar.Text;

                    cliente.Descripcion = tbDescEditar.Text;

                    cliente.Domicilio = tbDomicilioEditar.Text;

                    cliente.Telefono = tbTelEditar.Text;

                    cliente.Mail = tbMailEditar.Text;

                    cliente.Cuit = tbCuitEditar.Text;

                    blnValida = this.ValidacionCliente(cliente, contexto);

                    if (!blnValida)
                    {
                        contexto.SaveChanges();

                        MensajeOK += "Cliente Modificado correctamente" + Environment.NewLine;
                    }
                }
            }

            contexto.Dispose();

            this.MsjeValidacion();

            this.Consultar(dgvConsulta);

            this.VisibilidadPanel(pnlConsulta);
        }

        private void cbClienteEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelsCliente cliente = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbClienteEditar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                cliente = contexto.ModeloCliente.Where(p => p.IdCliente == intCodigo).Select(x => x).FirstOrDefault();

                if (cliente != null)
                {
                    tbNombreEditar.Text = cliente.Nombre;

                    tbDescEditar.Text = cliente.Descripcion;

                    tbDomicilioEditar.Text = cliente.Domicilio;

                    tbTelEditar.Text = cliente.Telefono;

                    tbMailEditar.Text = cliente.Mail;

                    tbCuitEditar.Text = cliente.Cuit;

                    tbFechaIngEditar.Text = cliente.FechaIngreso.ToString();
                }
            }
        }

        private void cbClienteEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelsCliente cliente = null;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                int intCodigo = Convert.ToInt32(cbClienteEliminar.SelectedValue.ToString().Split('-')[0].TrimStart().TrimEnd());

                cliente = contexto.ModeloCliente.Where(p => p.IdCliente == intCodigo).Select(x => x).FirstOrDefault();

                if (cliente != null)
                { 
                    tbNombreEliminar.Text = cliente.Nombre;

                    tbDescEliminar.Text = cliente.Descripcion;

                    tbDomicilioEliminar.Text = cliente.Domicilio;

                    tbTelEliminar.Text = cliente.Telefono;

                    tbMailEliminar.Text = cliente.Mail;

                    tbCuitEliminar.Text = cliente.Cuit;

                    tbFechaIngEliminar.Text = cliente.FechaIngreso.ToString();
                }
            }
        }

        #endregion

        #region Filtros

        private void tbFiltro_TextChanged_2(object sender, EventArgs e)
        {
            this.FiltrarGrid(tbFiltro, cbFiltro, dgvConsulta);
        }

        private void cbFiltro_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            tbFiltro.Text = string.Empty;

            tbFiltro.Enabled = true;
        }

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

        #endregion

        private void pbExcel_Click_2(object sender, EventArgs e)
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

            this.LoadAutoComplete(cbClienteEditar);

            this.LoadAutoComplete(cbClienteEliminar);
        }

        public void LoadAutoComplete(ComboBox comboBox)
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                comboBox.DataSource = contexto.ModeloCliente.Select(a => a.IdCliente + "  -  " + a.Nombre).ToList();
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

        private bool ValidacionCliente(ModelsCliente cliente, DBContext contexto)
        {
            bool blnValida = false;

            MensajeError = string.Empty;

            ValidationContext validationContext = new ValidationContext(cliente, null, null);

            List<ValidationResult> resultadoValidacion = new List<ValidationResult>();

            Validator.TryValidateObject(cliente, validationContext, resultadoValidacion, true);

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
