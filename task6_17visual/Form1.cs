using LIbTask6_17;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UtilsPack;

namespace task6_17visual
{
    public partial class Form1 : Form
    {
        private List<ItemType> items;
        private List<Object> itemsObj;
        public Form1()
        {
            InitializeComponent();
            textBoxPath.Text = "D:\\prog\\c#\\ISIT\\LibTask5_17\\bin\\Debug\\LibTask5_17.dll";
            items = new List<ItemType>();
            itemsObj = new List<object>();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            textBoxPath.Text = MyDialogFile.SelectTextFileAndReturnPath();
        }

        private void buttonReadDLL_Click(object sender, EventArgs e)
        {
            items.Clear();
            List<ItemType> list = Reflection.ShowClasses(textBoxPath.Text);
            Console.WriteLine(list.Count);
            foreach (ItemType itemType in list)
            {
                items.Add(itemType);
                comboBoxClasses.Items.Add(itemType.Text);
            }
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBoxClasses.SelectedIndex;
            labelBuilder.Text = Reflection.ShowConstructor(items[i]);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int i = comboBoxClasses.SelectedIndex;
                itemsObj.Add(Reflection.CreateObject(items[i], textBoxParams.Text));
                listViewObj.Items.Add(items[i].Text);
            }
            catch
            {
                Console.WriteLine("biba");
            }
        }
    }
}
