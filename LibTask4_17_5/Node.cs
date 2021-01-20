using System.Collections.Generic;

namespace LibTask4_17_5
{
    class Node
    {
        char ch;
        public char Ch { get => ch; }
        public bool IsEdnCharOfWord { get => isEdnCharOfWord; set => isEdnCharOfWord = value; }
        public List<Node> nodes;
        string parents;

        bool isEdnCharOfWord;

        public Node(char el, bool isWord, string parents)
        {
            this.ch = el;
            this.isEdnCharOfWord = isWord;
            nodes = new List<Node>();
            this.parents = parents;
        }

        public void Add(Node t)
        {
            if (!InChildren(t.ch))
            {
                nodes.Add(t);
            }
        }
        public void Add(char el, bool isWord)
        {
            Add(new Node(el, isWord, parents + ch));

        }
        public void Add(char el)
        {
            Add(el, false);
        }
        public void Add(string word)
        {
            Add(word, true);
        }
        public void Add(string word, bool isWord)
        {
            if (word.Length == 0)
            {
                this.isEdnCharOfWord = isWord;
                return;
            }
            char first = word.ToCharArray()[0];
            if (!InChildren(first))
            {
                Add(first);
            }
            GetChild(first).Add(word.Substring(1));
        }
        public Node GetChild(char el)
        {
            foreach (Node node in nodes)
            {
                if (node.Equals(el))
                {
                    return node;
                }
            }
            return null;
        }
        public Node GetChild(string word)
        {
            if (word.Length == 0)
            {
                return this;
            }
            else if (word.Length == 1)
            {
                return GetChild(word.ToCharArray()[0]);
            }
            else
            {
                return GetChild(word.ToCharArray()[0]).GetChild(word.Substring(1));
            }
        }
        public bool InChildren(char el)
        {
            foreach (Node node in nodes)
            {
                if (node.Equals(el))
                {
                    return true;
                }
            }

            return false;
        }
        public bool Equals(Node node)
        {
            return node.ch == ch && parents.Equals(node.parents);
        }
        public bool Equals(char el)
        {
            return el == ch;
        }
        public bool IsWord(string word)
        {
            if (word.Length == 0)
            {
                return isEdnCharOfWord;
            }
            char first = word.ToCharArray()[0];
            if (InChildren(first))
            {
                return GetChild(first).IsWord(word.Substring(1));
            }
            else
            {
                return false;
            }
        }
        public string GetWord()
        {
            return parents + ch;
        }
        public string GetWord(string word)
        {
            if (IsWord(word))
            {
                if (word.Length == 0)
                {
                    return GetWord();
                }
                else
                {
                    char first = word.ToCharArray()[0];
                    if (InChildren(first))
                    {
                        return GetChild(first).GetWord(word.Substring(1));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        public List<Node> GetChildren()
        {
            return GetChildren("");
        }
        public List<Node> GetChildren(string word)
        {
            if (word.Length == 0)
            {
                return nodes;
            }
            char first = word.ToCharArray()[0];
            if (InChildren(first))
            {
                return GetChild(first).GetChildren(word.Substring(1));
            }
            else
            {
                return new List<Node>();
            }
        }
        public List<Node> GetChildrenWithoutCorrectChild(char el)
        {
            return GetChildrenWithoutCorrectChild("", el);
        }
        public List<Node> GetChildrenWithoutCorrectChild(string word, char el)
        {
            Node[] t = new Node[GetChildren(word).Count];
            GetChildren(word).CopyTo(t);
            List<Node> res = new List<Node>(t);
            res.Remove(GetChild(word + el));
            return res;
        }
    }
}
