using LibTask4_17_5;
using System.Windows.Forms;
namespace Task4_17_5visual
{
    public partial class Form1 : Form
    {
        PrefixTree prefixTree = new PrefixTree();

        public Form1()
        {
            InitializeComponent();
            prefixTree.Add("Биба");
            prefixTree.Add("Боба");
            prefixTree.Add("Батя");
            prefixTree.Add("Бист");
            prefixTree.Add("Буст");
            prefixTree.Add("Кактус");
            foreach (string s in prefixTree.GetWords())
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
