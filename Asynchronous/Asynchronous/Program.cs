using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Normal methodlarla : ");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            SeherYemeyi();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine("Asynchronous methodlarla");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            SeherYemeyiAsync().Wait();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        static async Task CayAsync()
        {
            Console.WriteLine("Caydan su ile dolduruldu");
            Console.WriteLine("Qazin alti yandirildi");
            await Task.Delay(5000);
            Console.WriteLine("Cay qaynadi");
        }
        static async Task YumurtaAsync()
        {
            Console.WriteLine("Yumurta qirildi");
            Console.WriteLine("Yumurta qarisdirildi");
            Console.WriteLine("Yumurta tavaya tokuldu");
            await Task.Delay(3000);
            Console.WriteLine("Yumurta bisdi");
        }
        static async Task SufreAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Sufre hazirdi");
        }
        static async Task SeherYemeyiAsync()
        {
            await Task.WhenAll(CayAsync(),YumurtaAsync(),SufreAsync());
        }
        static void SeherYemeyi()
        {
            Cay();
            Yumurta();
            Sufre();
        }
        static void Cay()
        {
            Console.WriteLine("Caydan su ile dolduruldu");
            Console.WriteLine("Qazin alti yandirildi");
            Thread.Sleep(5000);
            Console.WriteLine("Cay qaynadi");
        }
        static void Yumurta()
        {
            Console.WriteLine("Yumurta qirildi");
            Console.WriteLine("Yumurta qarisdirildi");
            Console.WriteLine("Yumurta tavaya tokuldu");
            Thread.Sleep(3000);
            Console.WriteLine("Yumurta bisdi");
        }
        static void Sufre()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Sufre hazirdi");
        }
    }
}
