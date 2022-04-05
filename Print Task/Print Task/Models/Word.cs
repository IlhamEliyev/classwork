using Print_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Print_Task.Models
{
    class Word : IPrintableFile
    {
        public string FileName { get ; set ; }
        public int WordCount { get; set; }
        public Word(string name, int wc)
        {
            FileName = name;
            WordCount = wc;
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} printed. Word count = {WordCount}");
        }
    }
}
