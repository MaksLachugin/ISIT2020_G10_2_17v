using System;
using System.Windows.Forms;
using UtilsPack;
using LibTask2_17;

namespace task2_17visual
{
    public partial class FormTask2_17 : Form
    {
        public FormTask2_17()
        {
            InitializeComponent();
            textBoxRead.Text = MyDialogFile.BasePathInProject()+ "Name1.txt";
            textBoxWrite.Text = MyDialogFile.BasePathInProject() + "Name2.txt";
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            // кнопка выбора файла чтения
            string s = MyDialogFile.SelectTextFileAndReturnPath();
            if (s.Length > 0)
                textBoxRead.Text = s;
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            // кнопка выбора файла чтения
            string s = MyDialogFile.SelectTextFileAndReturnPath();
            if (s.Length > 0)
                textBoxWrite.Text = s;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = MyFileOperation.ReadFromFile(textBoxRead.Text);
            AnalysisText.ReCreateText(textBoxRead.Text, textBoxWrite.Text, (radioButtonLeft.Checked) ? Aling.Left : Aling.Right, (int) numericUpDownLen.Value);
            richTextBox2.Text = MyFileOperation.ReadFromFile(textBoxWrite.Text);
        }
    }
}
