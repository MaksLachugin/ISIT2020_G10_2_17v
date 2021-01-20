namespace task6_17visual
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelBuild = new System.Windows.Forms.Label();
            this.listViewObj = new System.Windows.Forms.ListView();
            this.buttonReadDLL = new System.Windows.Forms.Button();
            this.labelBuilder = new System.Windows.Forms.Label();
            this.labelPathLib = new System.Windows.Forms.Label();
            this.labelParams = new System.Windows.Forms.Label();
            this.textBoxParams = new System.Windows.Forms.TextBox();
            this.labelObj = new System.Windows.Forms.Label();
            this.labelNameObj = new System.Windows.Forms.Label();
            this.textBoxNameObj = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPath = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonObjInvoke = new System.Windows.Forms.Button();
            this.textBoxObjParams = new System.Windows.Forms.TextBox();
            this.labelObjParams = new System.Windows.Forms.Label();
            this.labelObjMethods = new System.Windows.Forms.Label();
            this.comboBoxObjMethods = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(142, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(283, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(6, 160);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(130, 24);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(142, 55);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(429, 21);
            this.comboBoxClasses.TabIndex = 2;
            this.comboBoxClasses.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasses_SelectedIndexChanged);
            // 
            // labelClass
            // 
            this.labelClass.Location = new System.Drawing.Point(3, 55);
            this.labelClass.Margin = new System.Windows.Forms.Padding(3);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(133, 21);
            this.labelClass.TabIndex = 3;
            this.labelClass.Text = "Класс";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBuild
            // 
            this.labelBuild.Location = new System.Drawing.Point(6, 82);
            this.labelBuild.Margin = new System.Windows.Forms.Padding(3);
            this.labelBuild.Name = "labelBuild";
            this.labelBuild.Size = new System.Drawing.Size(130, 20);
            this.labelBuild.TabIndex = 4;
            this.labelBuild.Text = "Конструктор";
            this.labelBuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewObj
            // 
            this.listViewObj.HideSelection = false;
            this.listViewObj.Location = new System.Drawing.Point(6, 29);
            this.listViewObj.Name = "listViewObj";
            this.listViewObj.Size = new System.Drawing.Size(214, 205);
            this.listViewObj.TabIndex = 6;
            this.listViewObj.UseCompatibleStateImageBehavior = false;
            // 
            // buttonReadDLL
            // 
            this.buttonReadDLL.Location = new System.Drawing.Point(6, 29);
            this.buttonReadDLL.Name = "buttonReadDLL";
            this.buttonReadDLL.Size = new System.Drawing.Size(130, 20);
            this.buttonReadDLL.TabIndex = 7;
            this.buttonReadDLL.Text = "Считать";
            this.buttonReadDLL.UseVisualStyleBackColor = true;
            this.buttonReadDLL.Click += new System.EventHandler(this.buttonReadDLL_Click);
            // 
            // labelBuilder
            // 
            this.labelBuilder.Location = new System.Drawing.Point(139, 82);
            this.labelBuilder.Margin = new System.Windows.Forms.Padding(3);
            this.labelBuilder.Name = "labelBuilder";
            this.labelBuilder.Size = new System.Drawing.Size(432, 20);
            this.labelBuilder.TabIndex = 8;
            this.labelBuilder.Text = "builder";
            this.labelBuilder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPathLib
            // 
            this.labelPathLib.Location = new System.Drawing.Point(3, 4);
            this.labelPathLib.Margin = new System.Windows.Forms.Padding(3);
            this.labelPathLib.Name = "labelPathLib";
            this.labelPathLib.Size = new System.Drawing.Size(133, 20);
            this.labelPathLib.TabIndex = 9;
            this.labelPathLib.Text = "Путь к библиотеке";
            this.labelPathLib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelParams
            // 
            this.labelParams.Location = new System.Drawing.Point(6, 108);
            this.labelParams.Margin = new System.Windows.Forms.Padding(3);
            this.labelParams.Name = "labelParams";
            this.labelParams.Size = new System.Drawing.Size(130, 20);
            this.labelParams.TabIndex = 10;
            this.labelParams.Text = "Параметры";
            this.labelParams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxParams
            // 
            this.textBoxParams.Location = new System.Drawing.Point(142, 108);
            this.textBoxParams.Name = "textBoxParams";
            this.textBoxParams.Size = new System.Drawing.Size(429, 20);
            this.textBoxParams.TabIndex = 11;
            // 
            // labelObj
            // 
            this.labelObj.Location = new System.Drawing.Point(3, 3);
            this.labelObj.Margin = new System.Windows.Forms.Padding(3);
            this.labelObj.Name = "labelObj";
            this.labelObj.Size = new System.Drawing.Size(217, 20);
            this.labelObj.TabIndex = 12;
            this.labelObj.Text = "Объекты";
            this.labelObj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameObj
            // 
            this.labelNameObj.Location = new System.Drawing.Point(6, 134);
            this.labelNameObj.Margin = new System.Windows.Forms.Padding(3);
            this.labelNameObj.Name = "labelNameObj";
            this.labelNameObj.Size = new System.Drawing.Size(130, 20);
            this.labelNameObj.TabIndex = 13;
            this.labelNameObj.Text = "Имя объекта";
            this.labelNameObj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameObj
            // 
            this.textBoxNameObj.Location = new System.Drawing.Point(142, 135);
            this.textBoxNameObj.Name = "textBoxNameObj";
            this.textBoxNameObj.Size = new System.Drawing.Size(429, 20);
            this.textBoxNameObj.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPath);
            this.panel1.Controls.Add(this.labelPathLib);
            this.panel1.Controls.Add(this.textBoxNameObj);
            this.panel1.Controls.Add(this.buttonReadDLL);
            this.panel1.Controls.Add(this.labelNameObj);
            this.panel1.Controls.Add(this.textBoxParams);
            this.panel1.Controls.Add(this.labelClass);
            this.panel1.Controls.Add(this.labelBuilder);
            this.panel1.Controls.Add(this.labelBuild);
            this.panel1.Controls.Add(this.labelParams);
            this.panel1.Controls.Add(this.comboBoxClasses);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.textBoxPath);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(575, 193);
            this.panel1.TabIndex = 15;
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(432, 4);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(75, 20);
            this.buttonPath.TabIndex = 15;
            this.buttonPath.Text = "Изменить";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonObjInvoke);
            this.panel2.Controls.Add(this.textBoxObjParams);
            this.panel2.Controls.Add(this.labelObjParams);
            this.panel2.Controls.Add(this.labelObjMethods);
            this.panel2.Controls.Add(this.comboBoxObjMethods);
            this.panel2.Controls.Add(this.labelInfo);
            this.panel2.Controls.Add(this.richTextBoxInfo);
            this.panel2.Controls.Add(this.labelObj);
            this.panel2.Controls.Add(this.listViewObj);
            this.panel2.Location = new System.Drawing.Point(12, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 328);
            this.panel2.TabIndex = 16;
            // 
            // buttonObjInvoke
            // 
            this.buttonObjInvoke.Location = new System.Drawing.Point(9, 295);
            this.buttonObjInvoke.Name = "buttonObjInvoke";
            this.buttonObjInvoke.Size = new System.Drawing.Size(127, 26);
            this.buttonObjInvoke.TabIndex = 19;
            this.buttonObjInvoke.Text = "Вызвать";
            this.buttonObjInvoke.UseVisualStyleBackColor = true;
            // 
            // textBoxObjParams
            // 
            this.textBoxObjParams.Location = new System.Drawing.Point(142, 268);
            this.textBoxObjParams.Name = "textBoxObjParams";
            this.textBoxObjParams.Size = new System.Drawing.Size(283, 20);
            this.textBoxObjParams.TabIndex = 18;
            // 
            // labelObjParams
            // 
            this.labelObjParams.Location = new System.Drawing.Point(3, 268);
            this.labelObjParams.Margin = new System.Windows.Forms.Padding(3);
            this.labelObjParams.Name = "labelObjParams";
            this.labelObjParams.Size = new System.Drawing.Size(133, 20);
            this.labelObjParams.TabIndex = 17;
            this.labelObjParams.Text = "Параметры";
            this.labelObjParams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelObjMethods
            // 
            this.labelObjMethods.Location = new System.Drawing.Point(6, 241);
            this.labelObjMethods.Margin = new System.Windows.Forms.Padding(3);
            this.labelObjMethods.Name = "labelObjMethods";
            this.labelObjMethods.Size = new System.Drawing.Size(130, 21);
            this.labelObjMethods.TabIndex = 16;
            this.labelObjMethods.Text = "Метод";
            this.labelObjMethods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxObjMethods
            // 
            this.comboBoxObjMethods.FormattingEnabled = true;
            this.comboBoxObjMethods.Location = new System.Drawing.Point(142, 241);
            this.comboBoxObjMethods.Name = "comboBoxObjMethods";
            this.comboBoxObjMethods.Size = new System.Drawing.Size(283, 21);
            this.comboBoxObjMethods.TabIndex = 15;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(227, 3);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(195, 23);
            this.labelInfo.TabIndex = 14;
            this.labelInfo.Text = "Информация о объекте";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(227, 29);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(198, 205);
            this.richTextBoxInfo.TabIndex = 13;
            this.richTextBoxInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelBuild;
        private System.Windows.Forms.ListView listViewObj;
        private System.Windows.Forms.Button buttonReadDLL;
        private System.Windows.Forms.Label labelBuilder;
        private System.Windows.Forms.Label labelPathLib;
        private System.Windows.Forms.Label labelParams;
        private System.Windows.Forms.TextBox textBoxParams;
        private System.Windows.Forms.Label labelObj;
        private System.Windows.Forms.Label labelNameObj;
        private System.Windows.Forms.TextBox textBoxNameObj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Label labelObjMethods;
        private System.Windows.Forms.ComboBox comboBoxObjMethods;
        private System.Windows.Forms.Label labelObjParams;
        private System.Windows.Forms.Button buttonObjInvoke;
        private System.Windows.Forms.TextBox textBoxObjParams;
        private System.Windows.Forms.Button buttonPath;
    }

}

