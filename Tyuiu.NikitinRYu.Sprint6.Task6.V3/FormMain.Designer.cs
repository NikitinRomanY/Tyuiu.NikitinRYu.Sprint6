namespace Tyuiu.NikitinRYu.Sprint6.Task6.V3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            textBoxTask = new TextBox();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            panel2 = new Panel();
            textBoxLoadFromFile = new TextBox();
            labelIn = new Label();
            splitter1 = new Splitter();
            panel3 = new Panel();
            textBoxResult = new TextBox();
            labelOut = new Label();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxTask);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Controls.Add(buttonHelp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 118);
            panel1.TabIndex = 0;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(3, 64);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(794, 46);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "Дан файл InPutFileTask6V3.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается r в результирующею строку";
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(84, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 55);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Выводит слова, в которых встречается r в результирующею строку");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(3, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 55);
            buttonOpenFile.TabIndex = 1;
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(722, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 55);
            buttonHelp.TabIndex = 0;
            toolTip.SetToolTip(buttonHelp, "Сведения о исполнителе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxLoadFromFile);
            panel2.Controls.Add(labelIn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 332);
            panel2.TabIndex = 1;
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(3, 21);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ReadOnly = true;
            textBoxLoadFromFile.Size = new Size(194, 308);
            textBoxLoadFromFile.TabIndex = 1;
            // 
            // labelIn
            // 
            labelIn.AutoSize = true;
            labelIn.Location = new Point(3, 3);
            labelIn.Name = "labelIn";
            labelIn.Size = new Size(36, 15);
            labelIn.TabIndex = 0;
            labelIn.Text = "Ввод:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 118);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 332);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxResult);
            panel3.Controls.Add(labelOut);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(203, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 332);
            panel3.TabIndex = 3;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 21);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(588, 308);
            textBoxResult.TabIndex = 1;
            // 
            // labelOut
            // 
            labelOut.AutoSize = true;
            labelOut.Location = new Point(6, 3);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(45, 15);
            labelOut.TabIndex = 0;
            labelOut.Text = "Вывод:";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт #6 | Таск 6 | Вариант 3 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonHelp;
        private Splitter splitter1;
        private Panel panel3;
        private TextBox textBoxTask;
        private Button buttonDone;
        private Button buttonOpenFile;
        private TextBox textBoxLoadFromFile;
        private Label labelIn;
        private Label labelOut;
        private TextBox textBoxResult;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogTask;
    }
}
