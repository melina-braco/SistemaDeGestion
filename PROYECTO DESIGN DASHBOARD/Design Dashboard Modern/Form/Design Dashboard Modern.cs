using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Data.Entity;
using System.Windows.Forms.DataVisualization.Charting;
using Design_Dashboard_Modern.Clases;

namespace Design_Dashboard_Modern
{
    public partial class Formulario : Form
    {
        private string _strContextoDB;

        private string _TipoComercio;

        public Formulario(string strContextoDB, string TipoComercio)
        {
            InitializeComponent();

            this._strContextoDB = strContextoDB;

            this._TipoComercio = TipoComercio;

            var form = Application.OpenForms.OfType<Home>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }

            Home frHome = new Home(_strContextoDB, _TipoComercio);

            AddFormInPanel(frHome);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            Form form = pnlMain.Controls.OfType<Form>().First();

            if (Sidebar.Width == 270)
            {
                Sidebar.Hide();
                Sidebar.Width = 60;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 45;
                AnimacionSidebar.Show(Sidebar);

                pnlMain.Width = 1000;

                form.Location = new Point((pnlMain.Width - form.Width) / 2, (pnlMain.Height - form.Height) / 2);     
            }
            else
            {
                Sidebar.Hide();
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);

                pnlMain.Width = 800;

                form.Location = new Point((pnlMain.Width - form.Width) / 2, (pnlMain.Height - form.Height) / 2);
            }
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Mercaderia>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }

            Mercaderia frMercaderiaHome = new Mercaderia(_strContextoDB);

            AddFormInPanel(frMercaderiaHome);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Home>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }

            Home frHome = new Home(_strContextoDB, _TipoComercio);

            AddFormInPanel(frHome);
        }

        private void VentasBtn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Ventas>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }

            Ventas frVentas = new Ventas(_strContextoDB);

            AddFormInPanel(frVentas);
        }

        private void GananciasBtn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Ganancias>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }

            Ganancias frGanancias = new Ganancias(_strContextoDB);

            AddFormInPanel(frGanancias);
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Clientes>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }

            Clientes frClientes = new Clientes(_strContextoDB);

            AddFormInPanel(frClientes);
        }

        private void ProveedoresBtn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Proveedor>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }

            Proveedor frProveedor = new Proveedor(_strContextoDB);

            AddFormInPanel(frProveedor);
        }

        private void DocumentacionBtn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Documentacion>().FirstOrDefault();

            if (form != null)
            {
                form.Close();
            }

            Documentacion frDocumentacion = new Documentacion(_strContextoDB);

            AddFormInPanel(frDocumentacion); 
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.pnlMain.Controls.Count != 0)

                this.pnlMain.Controls.RemoveAt(0);

            fh.TopLevel = false;

            fh.FormBorderStyle = FormBorderStyle.None;

            this.pnlMain.Controls.Add(fh);

            this.pnlMain.Tag = fh;

            fh.Show();
        }
    }
}