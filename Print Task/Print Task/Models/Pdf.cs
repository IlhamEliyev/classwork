using Print_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Print_Task.Models
{
    class Pdf : IPrintableFile
    {
        public string FileName { get ; set ; }
        public int PageCount { get; set; }
        public Pdf(string name, int pc)
        {
            FileName = name;
            PageCount = pc;
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} printed. Page count = {PageCount}");
        }
    }
}
