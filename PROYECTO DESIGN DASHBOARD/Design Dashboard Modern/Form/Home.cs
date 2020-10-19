using Design_Dashboard_Modern.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Home : Form
    {
        private string strContextoDB;

        private string _MensajeOK;

        public Home(string strContextoDB, string TipoComercio)
        {
            InitializeComponent();

            lblTipoEmpresa.Text = TipoComercio;

            this.strContextoDB = strContextoDB;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.GetDatosEmpresa();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            _MensajeOK = string.Empty;

            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
                ModelsEmpresa empresa = contexto.ModeloEmpresa.Select(x => x).FirstOrDefault();

                if (empresa != null)
                {
                    empresa.Nombre = tbNombre.Text;

                    empresa.Descripcion = tbDesc.Text;

                    empresa.Domicilio = tbDomicilio.Text;

                    empresa.Mail = tbMail.Text;

                    empresa.Telefono = tbTel.Text;

                    empresa.Cuit = tbCuit.Text;

                    empresa.FechaInicio = dateFechaInicio.Value;

                    _MensajeOK += "Datos actualizados correctamente" + Environment.NewLine;
                }
                else
                {
                    ModelsEmpresa empresaNueva = new ModelsEmpresa();

                    empresaNueva.Nombre = tbNombre.Text;

                    empresaNueva.Descripcion = tbDesc.Text;

                    empresaNueva.Domicilio = tbDomicilio.Text;

                    empresaNueva.Mail = tbMail.Text;

                    empresaNueva.Telefono = tbTel.Text;

                    empresaNueva.Cuit = tbCuit.Text;

                    empresaNueva.FechaInicio = dateFechaInicio.Value;

                    contexto.ModeloEmpresa.Add(empresaNueva);

                    _MensajeOK += "Datos ingresados correctamente" + Environment.NewLine;
                }

                contexto.SaveChanges();

                this.MsjeValidacion();
            }

            contexto.Dispose();

            this.GetDatosEmpresa();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario>().ToList();

            foreach(Form index in form)
            {
                index.Hide();
            }

            Form loginUsuario = new Login();

            loginUsuario.Show();
        }

        private void GetDatosEmpresa()
        {
            DBContext contexto = new DBContext(ConfigurationManager.ConnectionStrings[strContextoDB].ConnectionString);

            using (contexto)
            {
               ModelsEmpresa empresa = contexto.ModeloEmpresa.Select(e => e).FirstOrDefault();

                if (empresa != null)
                {
                    tbNombre.Text = empresa.Nombre;

                    tbDesc.Text = empresa.Descripcion;

                    tbDomicilio.Text = empresa.Domicilio;

                    tbMail.Text = empresa.Mail;

                    tbTel.Text = empresa.Telefono;

                    tbCuit.Text = empresa.Cuit;

                    dateFechaInicio.Value = empresa.FechaInicio;

                    contexto.SaveChanges();
                }
            }
            contexto.Dispose();
        }

        #region Validacion

        private void MsjeValidacion()
        {
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

        #endregion

        private void pbIg_Click(object sender, EventArgs e)
        {

        }

        private void pbFace_Click(object sender, EventArgs e)
        {
            //Modificar URL

            System.Diagnostics.Process.Start("https://webprogramacion.com/138/vbnet/acceder-a-una-url-desde-un-winform.aspx");
        }

        #region cambiar IMG

        private void Facebook_cambiarImg(object sender, EventArgs e)
        {
            pbFace.BackgroundImage = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/facebook_gris.png");
        }

        private void Instagram_cambiarImg(object sender, EventArgs e)
        {
            pbIg.BackgroundImage = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/ig_gris.png");
        }

        private void web_cambiarImg(object sender, EventArgs e)
        {
            pbWeb.BackgroundImage = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/web_gris.png");
        }

        private void Twitter_cambiarImg(object sender, EventArgs e)
        {
            pbTwitter.BackgroundImage = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/twitter_gris.png");
        }


        private void Facebook_resetImg(object sender, EventArgs e)
        {
            pbFace.BackgroundImage = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/facebook.png");
        }

        private void Instagram_resetImg(object sender, EventArgs e)
        {
            pbIg.BackgroundImage = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/ig.png");
        }

        private void web_resetImg(object sender, EventArgs e)
        {
            pbWeb.BackgroundImage = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/web.png");
        }

        private void Twitter_resetImg(object sender, EventArgs e)
        {
            pbTwitter.BackgroundImage = Image.FromFile("C:/Users/melin/Documentos/Tecnicatura en Programacion/PP1/SGA/ICONOS/twitter.png");
        }



        #endregion

       
    }
}
