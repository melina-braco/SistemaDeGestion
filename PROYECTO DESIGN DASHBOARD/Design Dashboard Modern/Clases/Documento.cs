using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern.Clases
{
    class Documento
    {
        /* Metodos comunes a todos los documentos */

        private SaveFileDialog sfd;

       public Documento()
        {
            sfd = new SaveFileDialog();
        }

        public IWorkbook GetWorkbookPlantilla(string File)
        {
            IWorkbook workbook;

            IWorkbook workbookDestino;

            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            workbook = application.Workbooks.Open(File);

            IApplication application2 = excelEngine.Excel;

            workbookDestino = application2.Workbooks.Create(1);

            workbookDestino.Worksheets.AddCopy(workbook.Worksheets[0]);

            workbookDestino.Worksheets[0].Remove();

            return workbookDestino;
        }

        public void ConvertirPDF(IWorksheet sheet, string path)
        {
            ExcelToPdfConverter converter = new ExcelToPdfConverter(sheet);

            PdfDocument pdfDocument = new PdfDocument();

            pdfDocument = converter.Convert();

            if(!string.IsNullOrEmpty(path))
            {
                pdfDocument.Save(path);
            }
            else 
            {
                pdfDocument.Close();
            }
        }

        public string PathGuardar()
        {
            using (sfd)
            {
                sfd.Filter = "pdf files (*.pdf)|*.pdf";

                sfd.FilterIndex = 2;

                sfd.RestoreDirectory = true;

                DialogResult result = sfd.ShowDialog();
            }

            return sfd.FileName;
        }
    }
}
