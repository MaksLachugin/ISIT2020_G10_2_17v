using System;

namespace task1_17
{
    public class Utils
    {
        public static int[] MinsInRows(int[][] arr)
        {
            int[] res = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = Min(arr[i]);
            }

            return res;
        }

        private static int Min(int[] arr)
        {
            int res = arr[0];


            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(res) > Math.Abs(arr[i]))
                {
                    res = arr[i];
                }
            }

            return res;
        }

        public static int[][] ReadArr2FromConsole()
        {
            Console.Write("Введите размер матрицы: ");
            int n = GetInt();

            int[][] arr2 = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr2[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите [{0}][{1}] элемент: ", i, j);
                    arr2[i][j] = GetInt();
                }
            }

            return arr2;
        }

        private static int GetInt()
        {
            int result;
            string s = Console.ReadLine();
            while (!int.TryParse(s, out result))
            {
                s = Console.ReadLine();
            }

            return result;
        }

        public static void Write(int[][] arr2)
        {
            foreach (int[] arr in arr2)
            {
                foreach (int el in arr)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public static void Write(int[] arr)
        {
            foreach (int el in arr)
            {
                Console.WriteLine(el);
            }
        }
    }
}