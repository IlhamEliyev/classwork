using System;

namespace _17_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 6, -2, 4, 19, 7 };
            ChangeMaxAndMin(nums);
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
        static int Sum(int n, int m) 
        {
            int sum = 0;
            Swap(ref n, ref m);
            for (int i = n; i < m; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Swap(ref int n12, ref int m12) 
        {
            if (n12>m12)
            {
                n12 += m12;
                m12 = n12 - m12;
                n12 -= m12;
            }
        }
        static void ChangeMaxAndMin(int[] arr) 
        {

            //{1,2,4,6,8,-1,22 }
            int mini = 0, maxi = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[maxi] < arr[i])
                {
                    maxi = i;
                }
                else if (arr[mini] > arr[i])
                {
                    mini = i;
                }
            }
            int temp = arr[maxi];
            arr[maxi] = arr[mini];
            arr[mini] = temp;
        }
    }
}
