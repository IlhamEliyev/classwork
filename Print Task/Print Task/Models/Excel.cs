using Print_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Print_Task.Models
{
    class Excel : IPrintableFile
    {
        public string FileName { get ; set ; }
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public Excel(string name, int rc, int cc)
        {
            FileName = name;
            RowCount = rc;
            ColumnCount = cc;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} printed. Row count = {RowCount}, Column count = {ColumnCount}");
        }
    }
}
