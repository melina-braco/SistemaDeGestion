using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
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
    public partial class Login : Form
    {
        private string _MensajeError;

        private string _TipoComercio;

        public Login()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form registrarUsuario = new Registro();

            registrarUsuario.Show();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            _MensajeError = string.Empty;

            if (chCuenta1.Checked || chCuenta2.Checked)
            {
                var conexion = this.GetContextoDB();

                var contexto = new DBContext(ConfigurationManager.ConnectionStrings[conexion].ConnectionString);

                using (contexto)
                {
                    bool exists = contexto.ModeloUsuario.Any(t => t.Usuario == tbUsuario.Text && t.Contraseña == tbPass.Text);

                    if (exists)
                    {
                        this.Hide();

                        Form frMain = new Formulario(conexion, _TipoComercio);

                        frMain.Show();
                    }
                    else
                    {
                        _MensajeError += "El usuario ingresado no existe" + Environment.NewLine;
                    }
                }

                contexto.Dispose();
            }
            else
            {
                _MensajeError += "Debe seleccionar una Cuenta" + Environment.NewLine;
            }

            if (_MensajeError.Count() > 0)
            {
                this.MsjeBox();
            }
        }

        private string GetContextoDB()
        {
            string strConexion = null;

            if (chCuenta1.Checked)
            {
                strConexion = "DBConexionC1";

                _TipoComercio = "COMERCIO WEB";
            }
            else if (chCuenta2.Checked)
            {
                strConexion = "DBConexionC2";

                _TipoComercio = "COMERCIO FABRICA";
            }

            return strConexion;
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

        private void MsjeBox()
        {
            var form = Application.OpenForms.OfType<Mensaje>().FirstOrDefault();

            Mensaje frMsje = form ?? new Mensaje(_MensajeError, 1);

            frMsje.Show();
        }
    }
}
