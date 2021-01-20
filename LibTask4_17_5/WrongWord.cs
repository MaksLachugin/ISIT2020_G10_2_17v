using System.Collections.Generic;

namespace LibTask4_17_5
{
    public class WrongWord
    {
        private string stroka;

        public string Stroka { get => stroka; set => stroka = value; }
        public List<int> IndexBadWords { get => indexBadWords; set => indexBadWords = value; }

        private List<int> indexBadWords;

        public WrongWord(string s, List<int> badWords)
        {
            Stroka = s;
            IndexBadWords = badWords;
        }
        public WrongWord(string s)
        {
            Stroka = s;
            IndexBadWords = new List<int>();
        }
        public bool IsWrongChar(int i)
        {
            return IndexBadWords.Contains(i);
        }

        public string EndOfWord(int i)
        {
            return Stroka.Substring(i + 1, Stroka.Length - i - 1);
        }
        public string StartOfWord(int i)
        {
            return Stroka.Substring(0, i);
        }

        public int Length()
        {
            return Stroka.Length;
        }
        public char[] ToCharArray()
        {
            return Stroka.ToCharArray();
        }
    }
}
