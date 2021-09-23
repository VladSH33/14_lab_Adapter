using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lab_14
{
    public class Adaptee
    {
        public IEnumerable<string[]> ReadCsv(string fileName, char delimiter = ',')
        {
            var lines = File.ReadAllLines(fileName, Encoding.UTF8).Select(a => a.Split(delimiter));
            return lines;
        }
    }
}
