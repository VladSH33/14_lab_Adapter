using System;
using System.Collections.Generic;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            var lines = adapter.ReadCsv("sample.csv");
            adapter.AddToExcel(lines, "output.xlsx", "workSheet");
        }
    }
}
