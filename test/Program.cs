using System;
using System.Collections.Generic;
using LibTask5_17;
using LIbTask6_17;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Form1();
        }

        public static void Form1()
        {
            string text = "D:\\prog\\c#\\ISIT\\test\\bin\\Debug\\LibTask5_17.dll";
            List<ItemType> items = new List<ItemType>();
            List<object> itemsObj = new List<object>();
            List<ItemType> list = Reflection.ShowClasses(text);
            Console.WriteLine(list.Count);
            foreach (ItemType itemType in list)
            {
                Console.WriteLine(itemType.Text);
                items.Add(itemType);
            }

            Console.WriteLine(Reflection.ShowConstructor(list[0]));
            Object f=  Reflection.CreateObject(list[0]);
            IFigure figure = f as Rhombus;
            Console.WriteLine(((Rhombus)f) is Rhombus);
            Console.WriteLine(figure);
        }
    }
}