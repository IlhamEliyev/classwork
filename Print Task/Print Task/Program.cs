using Print_Task.Interfaces;
using Print_Task.Models;
using System;

namespace Print_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excel excel = new Excel("Table.xlsx", 20, 15);
            Word word = new Word("File.docx", 20);
            //Pdf pdf = new Pdf("Book.pdf",350);
            //PrintFile.Print(word);
            //PrintFile.Print(excel);
            //PrintFile.Print(pdf);
            //IPrintableFile file = new Word("File.docx", 20);
            //Console.WriteLine(file.GetType());
            PrintFileGen<Word>.Print(word);
        }
    }
}
