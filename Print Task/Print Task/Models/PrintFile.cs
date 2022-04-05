using Print_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Print_Task.Models
{
    class PrintFile
    {
        public static void Print(IPrintableFile file)
        {
            file.Print();
        }
    }
}
