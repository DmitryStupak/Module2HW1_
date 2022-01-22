using System;

namespace NixFirst4HW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            bool rightNum = false;
            while (!rightNum)
            {
                Console.WriteLine("Введите размерность массива. Число должно быть целым, больше нуля");
                rightNum = int.TryParse(Console.ReadLine(), out n);
            }

            Task1(n);
        }

        public static void Task1(int n)
        {
            if (n > 0)
            {
                int[] arr = new int[n];
                int el = 0;
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = random.Next(1, 26);

                    /*Console.Write($"{arr[i]} ");*/
                    if (arr[i] % 2 == 0)
                    {
                        el++;
                    }
                }

                Console.WriteLine();
                int[] arr1 = new int[el];
                int[] arr2 = new int[n - el];
                int count1 = 0;
                int count2 = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        arr1[count1] = arr[i];
                        count1++;
                    }
                    else
                    {
                        arr2[count2] = arr[i];
                        count2++;
                    }
                }

                foreach (var item in NumToChar(arr1).arr)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
                foreach (var item in NumToChar(arr2).arr)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
                if (NumToChar(arr1).count > NumToChar(arr2).count)
                {
                    Console.Write($"В первом массиве больше букв в верхнем регистре - {NumToChar(arr1).count}");
                }

                if (NumToChar(arr2).count > NumToChar(arr1).count)
                {
                    Console.Write($"Во втором массиве больше букв в верхнем регистре - {NumToChar(arr2).count}");
                }

                if (NumToChar(arr2).count == NumToChar(arr1).count)
                {
                    Console.WriteLine();
                    Console.WriteLine("Массивы с одинаковым кол-вом букв в верхнем регистре");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Размер массива не может быть отрицательным или 0");
            }
        }

        public static (char[] arr, int count) NumToChar(int[] arr)
        {
            char[] res = new char[arr.Length];
            char[] let = new char[27];
            int count = 0;
            for (int i = 1; i < 27; i++)
            {
                let[i] = Convert.ToChar(i + 96);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < let.Length; j++)
                {
                    if (arr[i] == j)
                    {
                        if (arr[i] == 1 || arr[i] == 5 || arr[i] == 9 || arr[i] == 4 || arr[i] == 8 || arr[i] == 10)
                        {
                            res[i] = char.ToUpper(let[j]);
                            count++;
                        }
                        else
                        {
                            res[i] = let[j];
                        }
                    }
                }
            }

            return (arr: res, count: count);
        }
    }
}
