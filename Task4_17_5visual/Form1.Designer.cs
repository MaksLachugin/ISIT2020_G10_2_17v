namespace Task4_17_5visual
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxOne = new System.Windows.Forms.ListBox();
            this.listBoxTwo = new System.Windows.Forms.ListBox();
            this.listBoxThree = new System.Windows.Forms.ListBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Одна очепятка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(253, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Две очепятки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(494, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "Три очепятки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxOne
            // 
            this.listBoxOne.FormattingEnabled = true;
            this.listBoxOne.Location = new System.Drawing.Point(12, 90);
            this.listBoxOne.Name = "listBoxOne";
            this.listBoxOne.Size = new System.Drawing.Size(235, 134);
            this.listBoxOne.TabIndex = 6;
            // 
            // listBoxTwo
            // 
            this.listBoxTwo.FormattingEnabled = true;
            this.listBoxTwo.Location = new System.Drawing.Point(256, 90);
            this.listBoxTwo.Name = "listBoxTwo";
            this.listBoxTwo.Size = new System.Drawing.Size(232, 134);
            this.listBoxTwo.TabIndex = 7;
            // 
            // listBoxThree
            // 
            this.listBoxThree.FormattingEnabled = true;
            this.listBoxThree.Location = new System.Drawing.Point(497, 91);
            this.listBoxThree.Name = "listBoxThree";
            this.listBoxThree.Size = new System.Drawing.Size(232, 134);
            this.listBoxThree.TabIndex = 8;
            // 
            // labelCheck
            // 
            this.labelCheck.Location = new System.Drawing.Point(256, 12);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(232, 20);
            this.labelCheck.TabIndex = 9;
            this.labelCheck.Text = "ожидаю слово";
            this.labelCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 235);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.listBoxThree);
            this.Controls.Add(this.listBoxTwo);
            this.Controls.Add(this.listBoxOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxOne;
        private System.Windows.Forms.ListBox listBoxTwo;
        private System.Windows.Forms.ListBox listBoxThree;
        private System.Windows.Forms.Label labelCheck;
    }
}

