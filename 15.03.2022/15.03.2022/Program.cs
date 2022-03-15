using System;

namespace _15._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Arrayın ən kiçik elementi ilə ən böyük elementinin yerini dəyişən proqram yazın.
            //2.İstifadəçi tərəfindən daxil edilmiş mətndə bütün a hərflərini e hərfləri ilə yerdəyişən proqram yazın.
            //3.Mətndəki saitlərin sayını tapın.
            #region Istifadeci daxil eden Array
            //Console.WriteLine("Arrayin uzunlugunu daxil edin");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"{i+1}. Elementi daxil edin");
            //    int item = Convert.ToInt32(Console.ReadLine());
            //    nums[i] = item;
            //}
            #endregion
            #region Task1
            //int[] nums = { 1, 2, 3, 432, 54, 2, 54, 78, 12, 34, 56 };
            //int mini = 0;
            //int maxi = 0;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[mini] > nums[i])
            //    {
            //        mini = i;
            //    }
            //    else if(nums[maxi] < nums[i])
            //    {
            //        maxi = i;
            //    }
            //}
            //nums[maxi] = nums[maxi] + nums[mini];
            //nums[mini] = nums[maxi] - nums[mini];
            //nums[maxi] = nums[maxi] - nums[mini];
            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            #endregion
            #region Task2
            //string text = Console.ReadLine();
            //string temp = "";
            //foreach (char letter in text)
            //{
            //    if (letter == 'a')  temp += 'e';
            //    else temp += letter;
            //    Console.WriteLine(temp);
            //}
            //text = temp;
            //Console.WriteLine(text);
            #endregion
            #region Task3
            string text = Console.ReadLine();
            char[] vowels = {'a','i','o','u','e' };
            int count = 0;
            foreach (char letter in text.ToLower())
            {
                foreach (char vowel in vowels)
                {
                    if (letter == vowel) count++;
                }
            }
            Console.WriteLine(count);
            #endregion
        }
    }
}
