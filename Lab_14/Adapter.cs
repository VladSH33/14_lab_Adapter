using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ClosedXML.Excel;

namespace Lab_14
{
    class Adapter : Adaptee, ITarget
    {
        public void AddToExcel(IEnumerable<string[]> csv, string excelFileName, string workSheetName)
        {
            var workbook = new XLWorkbook();
            workbook.AddWorksheet(workSheetName);
            var ws = workbook.Worksheet(workSheetName);

            int row = 1;
            foreach (var line in csv)
            {
                int col = 1;
                foreach (var item in line)
                {
                    ws.Cell(row, col).Value = item;
                    col++;
                }
                row++;
            }
            workbook.SaveAs(excelFileName);
        }
    }
}
