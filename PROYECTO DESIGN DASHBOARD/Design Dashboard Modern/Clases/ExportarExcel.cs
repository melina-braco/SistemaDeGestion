using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Design_Dashboard_Modern.Clases
{
    static class ExportarExcel
    {
        public static void ToCsV(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            excel.Rows.Cells.Font.Name = "Microsoft Tai Le";

            int IndiceColumna = 0;

            //Header

            foreach (DataGridViewColumn col in tabla.Columns) 
            {
                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            excel.Range[excel.Cells[1, 1], excel.Cells[1, tabla.Columns.Count]].Font.Bold = true;

            int IndeceFila = 0;

            //Items

            foreach (DataGridViewRow row in tabla.Rows)
            {
                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }

            excel.Visible = true;
        }
    }
}

