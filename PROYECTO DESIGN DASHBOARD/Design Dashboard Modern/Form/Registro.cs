using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.Clases;
using Design_Dashboard_Modern.Models;

namespace Design_Dashboard_Modern
{
    public partial class Registro : Form
    {
        private string MensajeError;

        private string MensajeOK;

        public Registro()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string strConexion = null;

            bool blnValida = false;

            MensajeError = string.Empty;

            MensajeOK = string.Empty;

            if (chCuenta1.Checked || chCuenta2.Checked)
            {
                strConexion = this.GetContextoDB();

                var contexto = new DBContext(ConfigurationManager.ConnectionStrings[strConexion].ConnectionString);

                using (contexto)
                {
                    bool exists = contexto.ModeloUsuario.Any(t => t.Usuario == tbMail.Text);

                    if (!exists)
                    {
                        ModelsUsuario nuevoUsuario = new ModelsUsuario();

                        nuevoUsuario.Usuario = tbMail.Text;

                        nuevoUsuario.Contraseña = tbContraseña.Text;

                        nuevoUsuario.FechaAlta = DateTime.Now;

                        nuevoUsuario.PasswordConfirmacion = tbConfirmarContra.Text;

                        blnValida = this.ValidacionUsuario(nuevoUsuario, contexto);

                        if (!blnValida)
                        {
                            contexto.ModeloUsuario.Add(nuevoUsuario);

                            contexto.SaveChanges();

                            this.Hide();

                            Form loginUsuario = new Login();

                            loginUsuario.Show();

                            MensajeOK += "Usuario ingresado Correctamente" + Environment.NewLine;
                        }
                    }
                    else
                    {
                        MensajeError += "El usuario ingresado ya existe" + Environment.NewLine;
                    }

                    contexto.Dispose();
                }
            }
            else
            {
                MensajeError += "Debe seleccionar una Cuenta" + Environment.NewLine;
            }

            this.MsjeValidacion();
        }

        private string GetContextoDB()
        {
            string strConexion = null;

            if (chCuenta1.Checked)
            {
                strConexion = "DBConexionC1";
            }
            else if (chCuenta2.Checked)
            {
                strConexion = "DBConexionC2";
            }

            return strConexion;
        }

        private bool ValidacionUsuario(ModelsUsuario usuario, DBContext contexto)
        {
            bool blnValida = false;

            ValidationContext validationContext = new ValidationContext(usuario, null, null);

            List<ValidationResult> resultadoValidacion = new List<ValidationResult>();

            Validator.TryValidateObject(usuario, validationContext, resultadoValidacion, true);

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

        private void chCuenta1_CheckedChanged(object sender, EventArgs e)
        {
            this.ConfiguracionCheckBox(chCuenta1);
        }

        private void chCuenta2_CheckedChanged(object sender, EventArgs e)
        {
            this.ConfiguracionCheckBox(chCuenta2);
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

        private List<CheckBox> ListaCheckBox()
        {
            List<CheckBox> lstCheck = new List<CheckBox>();

            lstCheck.Add(chCuenta1);

            lstCheck.Add(chCuenta2);

            return lstCheck;
        }


        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form loginUsuario = new Login();

            loginUsuario.Show();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        #endregion
    }
}
