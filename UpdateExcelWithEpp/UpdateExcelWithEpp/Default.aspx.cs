using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOpenXml;
using System.IO;


namespace UpdateExcelWithEpp
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }       

        protected void Button1_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }

        private static void UpdateExcel()
        {
            string filePath = @"D:\Documento.xlsx";

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[1];

                worksheet.SetValue(3, 2, "Servicio1");
                worksheet.SetValue(4, 2, "Motivo1");
                worksheet.SetValue(5, 2, "Trabajo1");

                package.Save();
            }
        }

        private static void CreateExcel()
        {
            string rutaArchivo = @"D:\Documento.xlsx";

            using (ExcelPackage package = new ExcelPackage(new FileInfo(rutaArchivo)))
            {
                var worksheet = package.Workbook.Worksheets.Add("Contenido");

                worksheet.Cells["B1"].Value = "Hello world!";

                package.Save();
            }
        }
    }
}