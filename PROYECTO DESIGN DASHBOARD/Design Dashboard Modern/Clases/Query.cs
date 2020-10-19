using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Dashboard_Modern.Models;

namespace Design_Dashboard_Modern.Clases
{
    class Query
    {
        /* Query comunes a mas de un modulo (para no repetir codigo)*/

        private string _strConexion;

        public Query(string strConexion)
        {
            _strConexion = strConexion;
        }

        public List<ModelsVentas> qVenta_cFecha(int mes, int año)
        {
            List<ModelsVentas> lstVenta;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                lstVenta = contexto.ModeloVentas.Where(
                    v => v.FechaEgreso.Month == mes && v.FechaEgreso.Year == año).ToList();
            }

            contexto.Dispose();

            return lstVenta;
        }

        public List<ModelsVentaItems> qVenta_Ganancia(int mes, int año)
        {
            List<ModelsVentaItems> lstVenta;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                lstVenta = contexto.ModeloVentaItems.Where(
                    v => v.FechaEgreso.Month == mes && v.FechaEgreso.Year == año).ToList();
            }

            contexto.Dispose();

            return lstVenta;
        }

        public List<ModelsProducto> qProducto_cFecha(int mes, int año)
        {
            List<ModelsProducto> lstProducto;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                lstProducto = contexto.ModeloProducto.Where(
                   p => p.FechaIngreso.Month == mes && p.FechaIngreso.Year == año).ToList();
            }

            contexto.Dispose();

            return lstProducto;
        }

        public List<ModelsProducto> qProducto_c(int codigo)
        {
            List<ModelsProducto> lstProducto;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                lstProducto = contexto.ModeloProducto.Where(p => p.Codigo == codigo).ToList();
            }

            contexto.Dispose();

            return lstProducto;
        }

        public void qProducto_uCantidad(int codigo, int cantidad)
        {
            /* update a la table producto campo cantidad*/

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                ModelsProducto producto = contexto.ModeloProducto.Where(p => p.Codigo == codigo).FirstOrDefault();

                producto.Cantidad = cantidad;

                contexto.SaveChanges();
            }

            contexto.Dispose();
        }

        public void qProducto_uTotal(int codigo, decimal total)
        {
            /* update a la table producto campo cantidad*/

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                ModelsProducto producto = contexto.ModeloProducto.Where(p => p.Codigo == codigo).FirstOrDefault();

                producto.Total = total;

                contexto.SaveChanges();
            }

            contexto.Dispose();
        }

        public ModelsEmpresa qEmpresa_c()
        {
            ModelsEmpresa empresa;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[_strConexion].ConnectionString);

            using (contexto)
            {
                empresa = contexto.ModeloEmpresa.ToList().FirstOrDefault();
            }

            contexto.Dispose();

            return empresa;
        }

    }
}
