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
            //prefixTree.AddStrings(MyFileOperation.ReadFromFileInArray("D:\\prog\\c#\\ISIT\\Dic_Big1.dic"));
            prefixTree.Add("куст");
            prefixTree.Add("хуба");
            prefixTree.Add("хуби");
            prefixTree.Add("хиби");
            prefixTree.Add("киба");
            prefixTree.Add("Буба");
            prefixTree.Add("Батя");
            prefixTree.Add("Бист");
            prefixTree.Add("Буст");
            prefixTree.Add("Кактус");
        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            bool t = prefixTree.IsWord(textBox1.Text);
            if (t)
            {
                labelCheck.Text = "Слова написано верно";
            }
            else
            {
                labelCheck.Text = "Слова не существует или допущенна очепятка";
            }
            listBoxOne.Items.Clear();
            listBoxTwo.Items.Clear();
            listBoxThree.Items.Clear();
            foreach (string s in prefixTree.FindManyMissprintInStr(textBox1.Text, 1).ToArray())
            {
                listBoxOne.Items.Add(s);
            }
            if (textBox1.Text.Length > 1)
            {
                foreach (string s in prefixTree.FindManyMissprintInStr(textBox1.Text, 2).ToArray())
                {
                    listBoxTwo.Items.Add(s);
                }
                if (textBox1.Text.Length > 2)
                {
                    foreach (string s in prefixTree.FindManyMissprintInStr(textBox1.Text, 3).ToArray())
                    {
                        listBoxThree.Items.Add(s);
                    }
                }
            }
        }
    }
}
