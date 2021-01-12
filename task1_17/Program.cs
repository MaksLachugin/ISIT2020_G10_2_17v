using System;


//17.	Дана матрица А(n x n). Построить вектор, каждый элемент которого содержит наименьший по абсолютной величине элемент строки.
namespace task1_17
{
    class Program
    {
        public static void Main(string[] args)
        {
            Utils.Write(Utils.MinsInRows(Utils.ReadArr2FromConsole()));
        }
    }
}