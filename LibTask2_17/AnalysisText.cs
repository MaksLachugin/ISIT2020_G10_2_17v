using System;
using UtilsPack;

namespace LibTask2_17
{
    public class AnalysisText
    {
        public static void ReCreateText(string pathRead, string pathWrite, Aling aling, int n)
        {
            string text = MyFileOperation.ReadFromFile(pathRead);
            string[] arrWords = Strip(text);

            string[] arrStrings = ReCreateStrings(arrWords, n);
            arrStrings = SetAling(arrStrings, aling, n);
            MyFileOperation.WriteInFile(pathWrite, arrStrings);
        }

        private static string[] Strip(string text)
        {
            string[] words = text.Split(new char[] { ' ', ' ', '\t', '\n', '\r' });

            return DeleteEmptyStrings(words);
        }
        private static string[] ReCreateStrings(string[] arrWords, int n)
        {
            string[] lines = new string[arrWords.Length];

            int i = 0;
            for (int j = 0; j < arrWords.Length; j++)
            {
                if (string.IsNullOrEmpty(lines[i]))
                {
                    lines[i] = arrWords[j];
                }
                else if (lines[i].Length + arrWords[j].Length + 1 <= n)
                {
                    lines[i] += " " + arrWords[j];
                }
                else
                {
                    i++;
                    lines[i] = arrWords[j];
                }
            }
            string[] t = new string[i];
            Array.Copy(lines, t, i);
            return t;
        }

        private static string[] DeleteEmptyStrings(string[] lines)
        {

            int count = 0;
            foreach (string s in lines)
            {
                if (!(string.IsNullOrEmpty(s) || s.Length == 0))
                {
                    count++;
                }
            }
            string[] t = new string[count];
            int i = 0;
            foreach (string s in lines)
            {
                if (!(string.IsNullOrEmpty(s) || s.Length == 0))
                {
                    t[i] = s;
                    i++;
                }
                if (i == count)
                {
                    break;
                }
            }
            return t;

        }

        private static string[] SetAling(string[] arrStrings, Aling aling, int n)
        {
            if (aling == Aling.Right)
            {
                for (int i = 0; i < arrStrings.Length; i++)
                {
                    arrStrings[i] = AddSpace(arrStrings[i], n);
                }
            }
            return arrStrings;
        }

        private static string AddSpace(string s, int n)
        {
            while (s.Length < n)
            {
                s = " " + s;
            }

            return s;
        }
    }
}
