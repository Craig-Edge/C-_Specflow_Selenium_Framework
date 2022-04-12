using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.FileReaders
{

    public class ReadExcel
    {
        public static IEnumerable<object[]> ReadMyExcel()
        {
        using (ExcelPackage package = new ExcelPackage(new FileInfo("data.xlsx")))
            {
                //Get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                int rowCount = worksheet.Dimension.End.Row; //Get the row count
                for (int row = 2; row <= rowCount; row++)
                {
                    yield return new object[]
                    {
               worksheet.Cells[row ,1].Value?.ToString().Trim(),
              // worksheet.Cells[row ,2].Value?.ToString().Trim(),
              // worksheet.Cells[row ,3].Value?.ToString().Trim(),

                    };
                
                }

            }

        }
    }
}
