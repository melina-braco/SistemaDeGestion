using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.Clases
{
    class  IntMail
    {
        private MailMessage msjeMail;

        private string _destinatario;

        private string _asunto;

        private string _archivo;

        public IntMail(string destinatario, string asunto, string archivo)
        {
            this._destinatario = destinatario;

            this._asunto = asunto;

            this._archivo = archivo;
        }

        public  void Enviar()
        {
            string strPaginaWeb = "http://www.sunrush.com.ar/";

            msjeMail = new MailMessage();

            msjeMail.From = new MailAddress("braconaro.melina.38697@gmail.com");

            msjeMail.To.Add(_destinatario);

            msjeMail.Subject = _asunto;

            msjeMail.IsBodyHtml = true;

            msjeMail.Body =
                  "<h1 style='color:#C63A1C; font-size:30px;'>OVA.AMOBLAMIENTO</h1> <br />"
                + $"Se adjunta a {_destinatario} <br />" 
                + $"<p>el resumen de la Documentacion efectuada el dia {DateTime.Today.ToShortDateString()} <br /> <br /></p>"
                + $"<a  style='color:#939393;' href={strPaginaWeb}> {strPaginaWeb} </a>";

            this.AdjuntarArchivo(_archivo);

            try
            {
                ConfigurarCredenciales().Send(msjeMail);
            }
            catch (Exception e)
            {

            }
            msjeMail.Dispose();
        }

        private   SmtpClient ConfigurarCredenciales()
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            smtp.Credentials = new System.Net.NetworkCredential("braconaro.melina.38697@gmail.com", "Liceo1993");

            smtp.EnableSsl = true;

            smtp.Host = "smtp.gmail.com";

            smtp.Port = 587;

            return smtp;
        }

        private  void AdjuntarArchivo(string archivo)
        {
            Attachment atFile = new Attachment(archivo, MediaTypeNames.Application.Octet);

            if (!string.IsNullOrEmpty(archivo))
            {
                msjeMail.Attachments.Add(atFile);
            }
        }
    }
}
