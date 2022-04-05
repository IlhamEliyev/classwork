using System;
using System.Collections.Generic;
using System.Text;

namespace Print_Task.Interfaces
{
    interface IPrintableFile
    {
        public string FileName { get; set; }
        void Print();
    }
}
