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
using Design_Dashboard_Modern.Models;
using System.Configuration;

namespace Design_Dashboard_Modern.Clases
{
    class GrillaEstadisticas
    {
        /* Grilla de estadisticas informacion ampliada del grafico de ganacias */

        private string _strConexion;

        Query query;

        public GrillaEstadisticas(string strConexion)
        {
            _strConexion = strConexion;

             query = new Query(strConexion);
        }

        public void GetGrillaEstadisticas(int año, DataGridView dgv)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mes   ", typeof(string));

            dt.Columns.Add("Cantidad Productos obtenidos", typeof(string));

            dt.Columns.Add("Gastos en Productos", typeof(string));

            dt.Columns.Add("cantidad de Ventas realizadas", typeof(string));

            dt.Columns.Add("Ganancias obtenidas", typeof(string));

            //dt.Columns.Add("Ganancias", typeof(string));

            for (int index = 1; index <= 12; index++)
            {
                dt.Rows.Add(new object[] 
                {   
                    this.GetMes(index), 
                    this.GetCantidadProductos(año, index),
                    this.GetMontoProductos(año, index),
                    this.GetCantidadVentas(año, index),
                    this.GetGanancia(año, index), 
                   // this.GetGanancia(año, index) 
                });
            }

            dgv.DataSource = dt;
        }

        private string GetMes(int numeroMes)
        {
            string strMes = string.Empty;

            switch (numeroMes)
            {
                case 1:

                    strMes = "Enero";
                    break;

                case 2:
                    strMes = "Febrero";
                    break;

                case 3:

                    strMes = "Marzo";
                    break;

                case 4:
                    strMes = "Abril";
                    break;

                case 5:

                    strMes = "Mayo";
                    break;

                case 6:
                    strMes = "Junio";
                    break;

                case 7:

                    strMes = "Julio";
                    break;

                case 8:
                    strMes = "Agosto";
                    break;

                case 9:
                    strMes = "Septiembre";
                    break;

                case 10:

                    strMes = "Octubre";
                    break;

                case 11:
                    strMes = "Noviembre";
                    break;

                case 12:
                    strMes = "Diciembre";
                    break;
            }

            return strMes;
        }

        private int GetCantidadProductos(int año, int mes)
        {
            /* Obtiene la cantidad de productos en un determinado mes y año */

            int intCantidad = 0;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                var queryProducto = query.qProducto_cFecha(mes, año);

                foreach (ModelsProducto index in queryProducto)
                {
                    intCantidad += index.Cantidad;
                }
            }

            contexto.Dispose();

            return intCantidad;
        }

        private string GetMontoProductos(int año, int mes)
        {
            /* Obtiene el monto total en pesos de productos en un determinado mes y año */

            decimal dcTotal = 0;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                Query query = new Query(_strConexion);

                var queryProducto = query.qProducto_cFecha(mes, año);

                foreach (ModelsProducto index in queryProducto)
                {
                    dcTotal += index.Total;
                }
            }

            return "$ " + dcTotal;
        }

        private int GetCantidadVentas(int año, int mes)
        {
            /* Obtiene la cantidad de ventas en un determinado mes y año*/

            int intCantidad = 0;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                var queryVenta = query.qVenta_cFecha(mes, año);

                intCantidad = queryVenta.Count();
            }

            return intCantidad;
        }

        private string GetMontoVentas(int año, int mes)
        {
            /* Obtiene el monto total en pesos de ventas en un determinado mes y año */

            decimal dcTotal = 0;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                var queryVenta = query.qVenta_cFecha(mes, año);

                foreach (ModelsVentas index in queryVenta)
                {
                    dcTotal += index.Total;
                }

                contexto.Dispose();

                return "$ " + dcTotal;
            }
        }

        public string GetGanancia(int año, int mes)
        {
            decimal ganancias = 0;

            decimal total = 0;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                Query query = new Query(_strConexion);

                List<ModelsVentaItems> lstItems = query.qVenta_Ganancia(mes, año);

                if (lstItems.Count > 0)
                {
                    foreach (ModelsVentaItems item in lstItems)
                    {
                        ganancias = item.Cantidad * (item.PrecioVenta - item.PrecioCosto);

                        total += ganancias;
                    }
                }
            }

            contexto.Dispose();

            return "$ " + total.ToString();
        }
    }
}
