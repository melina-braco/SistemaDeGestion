using Design_Dashboard_Modern.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Mail : Form
    {
        private string _Path;

        private string _MensajeError;

        private string _MensajeOK;

        public Mail(string Path)
        {
            InitializeComponent();

            this._Path = Path;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            _MensajeOK = string.Empty;

            _MensajeError = string.Empty;

            Regex regex = new Regex("^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$");

            if (regex.IsMatch(tbMail.Text))
            {
                IntMail mail = new IntMail(tbMail.Text, "Documentacion Comercial", _Path);

                mail.Enviar();

                _MensajeOK += "Se envio el mail de manera correcta con la documentacion correspondiente" + Environment.NewLine;

                this.MsjeValidacion();

                this.Close();
            }
            else
            {
                _MensajeError += "El formato del mail ingresado NO es valido" + Environment.NewLine;

                this.MsjeValidacion();
            }            
        }

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
    }
}
