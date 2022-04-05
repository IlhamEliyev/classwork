using Print_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Print_Task.Models
{
    class PrintFileGen<T> where T : IPrintableFile
    {
        public static void Print(T file)
        {
            file.Print();
        }
    }
}
