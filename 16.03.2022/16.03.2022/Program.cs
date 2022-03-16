using System;

namespace _16._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordCount(" "));
        }
        static int Power(int number) 
        {
            if (number >=1)
            {
                int pow = 0;
                while (number > 1) 
                {
                    if (number % 2 ==0)
                    {
                        pow++;
                        number /= 2;
                    }
                    else
                    {
                        pow = -1;
                        break;
                    }
                }
                return pow;
            }
            return -1;
        }
        static bool NIsBigger(int m, int n) 
        {
            if (m<n) return true;
            return false;
        }
        static double Task2(int n, int m)
        {
            int average = 0;
            int count = 0;
            if (NIsBigger(n, m))
            {
                for (int i = n; i < m; i++)
                {
                    if (i%15==0)
                    {
                        average += i;
                        count++;
                    }
                }
                return (double)average/count;
            }
            else
            {
                Console.WriteLine("M ededi N ededinden boyuk ola bilmez");
                return 0;
            }
        }
        static bool IsComposite(int num)
        {
            for (int i = 2; i*i <= num; i++)
            {
                if (num%i==0)
                {
                    return true;
                }
            }
            return false;
        }

        static int WordCount(string text) 
        {
            int count = 0;
            char[] symbols = {' ','.','!',':',',' };
            bool currentSymbol = false;
            for (int i = 0; i < text.Length-1; i++)
            {
                foreach (char symbol in symbols)
                {
                    if (symbol == text[i])
                    {
                        foreach (char symbol2 in symbols)
                        {
                            if (symbol2 == text[i + 1])
                            {
                                currentSymbol = true;
                                break;
                            }
                        }
                        if (!currentSymbol)
                        {
                            count++;
                            break;
                        }
                    }
                }
                currentSymbol = false;
            }
            return ++count;
        }
    }
}
