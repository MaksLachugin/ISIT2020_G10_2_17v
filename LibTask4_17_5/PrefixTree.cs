using System.Collections.Generic;

namespace LibTask4_17_5
{
    public class PrefixTree
    {
        Node first;

        public PrefixTree()
        {
            first = new Node('\0', false, "");
        }
        public void Add(string str)
        {
            first.Add(str.ToLower());
        }
        public void AddChar(char el)
        {
            first.Add(el.ToString().ToLower().ToCharArray()[0]);
        }
        public void AddChar(char el, string parents)
        {
            first.Add((parents + el).ToLower(), false);
        }
        public bool IsWord(string str)
        {

            return first.IsWord(str.ToLower());
        }
        public List<WrongWord> FindOneMissprint(string word)
        {
            return FindMissprint(new WrongWord(word.ToLower()));
        }
        public List<WrongWord> FindMissprint(WrongWord word)
        {
            List<WrongWord> res = new List<WrongWord>();
            for (int i = 0; i < word.Length(); i++)
            {
                if (word.IsWrongChar(i))
                {
                    continue;
                }

                List<Node> wrongNodes = first.GetChildrenWithoutCorrectChild(word.StartOfWord(i), word.ToCharArray()[i]);
                string endOfWord = word.EndOfWord(i);
                foreach (Node node in wrongNodes)
                {
                    if (node.IsWord(endOfWord))
                    {
                        List<int> t = new List<int>();
                        t.Add(i);
                        res.Add(new WrongWord(node.GetWord(endOfWord), t));
                    }
                }
            }
            return res;
        }
        public List<WrongWord> FindManyMissprint(string word, int count)
        {
            List<WrongWord> temp = new List<WrongWord>();
            List<WrongWord> result = new List<WrongWord>();
            result.Add(new WrongWord(word));
            for (int i = 0; i < count; i++)
            {
                foreach (WrongWord element in result)
                {
                    temp.AddRange(FindMissprint(element));
                }
                result.Clear();
                result = Clone(temp);
                temp.Clear();
            }
            return temp;
        }
        private List<WrongWord> Clone(List<WrongWord> list)
        {
            WrongWord[] t = new WrongWord[list.Count];
            list.CopyTo(t);
            return new List<WrongWord>();
        }
        public List<string> GetWords()
        {
            List<string> listWords = new List<string>();
            List<Node> q = first.GetChildren();
            while (q.Count != 0)
            {
                if (q[0] != null && q[0].IsEdnCharOfWord)
                {
                    listWords.Add(q[0].GetWord().Substring(1));
                }
                q.AddRange(q[0].GetChildren());
                q.RemoveAt(0);
            }
            return listWords;
        }

        public void AddStrings(string[] words)
        {
            foreach (string s in words)
            {
                Add(s.ToLower());
            }
        }
    }
}
