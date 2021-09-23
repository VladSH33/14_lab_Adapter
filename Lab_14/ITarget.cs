using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14
{
    interface ITarget
    {
        void AddToExcel(IEnumerable<string[]> csv, string excelFileName, string workSheetName);
    }
}
