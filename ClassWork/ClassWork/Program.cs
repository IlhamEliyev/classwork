using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //          1.Verilmiş M ədədindən N ədədinə qədər olan ədələrin cəmini taın
            //          2. 1 - dən N - ə qədər 15ə bölünən ədədlərin ədədi ortası
            //          3.Verilmiş ədədin neçə mərtəbəli olduğunu tapın(mənfi ədədlər də
            //          daxil)
            //          4.Ndən Mə qədər ədədlər içində 21ə bölünən ədəd olub olmadığını tapın
            //          5.Ədədin 2 - nin neçənci qüvvəti olduğunu tapın
            #region EdediOrta
            //int n = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;
            //double count = 0;
            //if (n>0)
            //{
            //    for (int i = 15; i < n; i+=15)
            //    {
            //        sum += i;
            //        count++;
            //    }
            //}
            //else Console.WriteLine("Eded menfi ola bilmez");
            //if (count > 0) Console.WriteLine(sum/count);
            //else Console.WriteLine(0);
            #endregion
            #region Task3
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 1;
            //if (n < 0) n = n * (-1);
            //while (n>9)
            //{
            //    n = n / 10;
            //    count++;
            //}
            //Console.WriteLine(count);
            #endregion
            #region Task4
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //if (n>=0 && m>n)
            //{
            //    bool isDivided = false;
            //    for (int i = n; i < m; i++)
            //    {
            //        if (i%21==0)
            //        {
            //            isDivided = true;
            //            break;
            //        }
            //    }
            //    if (isDivided) Console.WriteLine("Bolunur");
            //    else Console.WriteLine("Bolunmur");
            //}
            //else
            //{
            //    Console.WriteLine("Ededleri duzgun daxil edin");
            //}
            #endregion
            #region Task5
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>0)
            {
                //bool isPower = false;
                int power = 0;
                while (n>1)
                {
                    if (n%2==0)
                    {
                        power++;
                        n /= 2;
                        //isPower=true;
                    }
                    else
                    {
                        //isPower = false;
                        power=0;
                        break;
                    }
                }
                if (n != 1 && power > 0) Console.WriteLine(power);
                else Console.WriteLine("2-nin quvveti deyildir");
            }
            else
            {
                Console.WriteLine("Eded menfi ola bilmez");
            }
            #endregion
        }
    }
}
