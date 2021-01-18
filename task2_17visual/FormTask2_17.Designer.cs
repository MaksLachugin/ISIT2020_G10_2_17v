using UtilsPack;

namespace task2_17visual
{
    partial class FormTask2_17
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRead = new System.Windows.Forms.Label();
            this.labelWrite = new System.Windows.Forms.Label();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labelEdge = new System.Windows.Forms.Label();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.numericUpDownLen = new System.Windows.Forms.NumericUpDown();
            this.labelLen = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRead
            // 
            this.labelRead.Location = new System.Drawing.Point(14, 14);
            this.labelRead.Margin = new System.Windows.Forms.Padding(5);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(160, 20);
            this.labelRead.TabIndex = 0;
            this.labelRead.Text = "Путь к файлу чтения данных";
            this.labelRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWrite
            // 
            this.labelWrite.Location = new System.Drawing.Point(14, 44);
            this.labelWrite.Margin = new System.Windows.Forms.Padding(5);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(160, 20);
            this.labelWrite.TabIndex = 1;
            this.labelWrite.Text = "Путь к файлу записи данных";
            this.labelWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRead
            // 
            this.textBoxRead.Location = new System.Drawing.Point(184, 14);
            this.textBoxRead.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.Size = new System.Drawing.Size(205, 20);
            this.textBoxRead.TabIndex = 2;
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Location = new System.Drawing.Point(184, 44);
            this.textBoxWrite.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(205, 20);
            this.textBoxWrite.TabIndex = 3;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(399, 14);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 20);
            this.buttonRead.TabIndex = 4;
            this.buttonRead.Text = "Изменить";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(399, 44);
            this.buttonWrite.Margin = new System.Windows.Forms.Padding(5);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 20);
            this.buttonWrite.TabIndex = 5;
            this.buttonWrite.Text = "Изменить";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // labelEdge
            // 
            this.labelEdge.Location = new System.Drawing.Point(14, 74);
            this.labelEdge.Margin = new System.Windows.Forms.Padding(5);
            this.labelEdge.Name = "labelEdge";
            this.labelEdge.Size = new System.Drawing.Size(160, 20);
            this.labelEdge.TabIndex = 6;
            this.labelEdge.Text = "Выровнять по";
            this.labelEdge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.Checked = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(184, 74);
            this.radioButtonLeft.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(95, 20);
            this.radioButtonLeft.TabIndex = 7;
            this.radioButtonLeft.TabStop = true;
            this.radioButtonLeft.Text = "Левому краю";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.Location = new System.Drawing.Point(289, 74);
            this.radioButtonRight.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(100, 20);
            this.radioButtonRight.TabIndex = 8;
            this.radioButtonRight.Text = "Правому краю";
            this.radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLen
            // 
            this.numericUpDownLen.Location = new System.Drawing.Point(184, 104);
            this.numericUpDownLen.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownLen.Name = "numericUpDownLen";
            this.numericUpDownLen.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownLen.TabIndex = 9;
            this.numericUpDownLen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelLen
            // 
            this.labelLen.Location = new System.Drawing.Point(14, 104);
            this.labelLen.Margin = new System.Windows.Forms.Padding(5);
            this.labelLen.Name = "labelLen";
            this.labelLen.Size = new System.Drawing.Size(160, 20);
            this.labelLen.TabIndex = 10;
            this.labelLen.Text = "Длина строки";
            this.labelLen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(17, 132);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(157, 30);
            this.buttonRun.TabIndex = 11;
            this.buttonRun.Text = "Запуск";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(262, 268);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(289, 170);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(499, 268);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // FormTask2_17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.labelLen);
            this.Controls.Add(this.numericUpDownLen);
            this.Controls.Add(this.radioButtonRight);
            this.Controls.Add(this.radioButtonLeft);
            this.Controls.Add(this.labelEdge);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxWrite);
            this.Controls.Add(this.textBoxRead);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.labelRead);
            this.Name = "FormTask2_17";
            this.Text = "FormTask2_17";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.Label labelWrite;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label labelEdge;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.NumericUpDown numericUpDownLen;
        private System.Windows.Forms.Label labelLen;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}