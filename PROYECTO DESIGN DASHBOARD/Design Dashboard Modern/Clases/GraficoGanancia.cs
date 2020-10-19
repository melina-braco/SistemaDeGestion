using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using Design_Dashboard_Modern.Models;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Clases
{
    class GraficoGanancia
    {
        /* Pantalla ganancias grafico primer solapa */

        private string strConexion;

        public GraficoGanancia(string strConexion)
        {
            this.strConexion = strConexion;
        }

        public void EstilosGrafico(Chart chart)
        {
            chart.Series["Serie1"].IsVisibleInLegend = false;

            chart.ChartAreas[0].BackColor = Color.Transparent;

            Font font = new Font("Arial", 8.0f);

            chart.ChartAreas[0].AxisX.LabelStyle.Font = font;

            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            chart.ChartAreas[0].AxisX.LineColor = Color.White;

            chart.ChartAreas[0].AxisY.LineColor = Color.White;

            chart.ChartAreas[0].AxisX.Title = "Meses";

            chart.ChartAreas[0].AxisX.TitleForeColor = Color.White;

            chart.ChartAreas[0].AxisY.Title = "Ganancia en $";

            chart.ChartAreas[0].AxisY.TitleForeColor = Color.White;
        }

        public void SetDatos(int intAño, Chart grafico)
        {
            Dictionary<string, decimal> dic = new Dictionary<string, decimal>();

            grafico.Series["Serie1"].Points.Clear();

            dic.Add("Enero", GetGanancia(intAño, 1));

            dic.Add("Febrero", GetGanancia(intAño, 2));

            dic.Add("Marzo", GetGanancia(intAño, 3));

            dic.Add("Abril", GetGanancia(intAño, 4));

            dic.Add("Mayo", GetGanancia(intAño, 5));

            dic.Add("Junio", GetGanancia(intAño, 6));

            dic.Add("Julio", GetGanancia(intAño, 7));

            dic.Add("Agosto", GetGanancia(intAño, 8));

            dic.Add("Septiembre", GetGanancia(intAño, 9));

            dic.Add("Octubre", GetGanancia(intAño, 10));

            dic.Add("Noviembre", GetGanancia(intAño, 11));

            dic.Add("Diciembre", GetGanancia(intAño, 12));

            foreach (KeyValuePair<string, decimal> d in dic)
            {
                grafico.Series["Serie1"].Points.AddXY(d.Key, d.Value);
            }

        }

        public decimal GetGanancia(int año, int mes)
        {
            decimal ganancias = 0;

            decimal total = 0;

            var contexto = new DBContext(ConfigurationManager.ConnectionStrings[strConexion].ConnectionString);

            using (contexto)
            {
                Query query = new Query(strConexion);

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

            return total;
        }

        public void SaveImg(Chart chart)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPeg Imagen|*.jpg|Bitmap Imagen|*.bmp|PNG Imagen|*.png";

            saveFileDialog1.Title = "Guardar Grafico";

            saveFileDialog1.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                chart.SaveImage(fs, ChartImageFormat.Png);
            }

            saveFileDialog1.Dispose();
        }
    }
}
