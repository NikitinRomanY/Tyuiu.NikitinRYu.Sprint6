namespace Tyuiu.NikitinRYu.Sprint6.Task7.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            textBoxTask = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridViewIn = new DataGridView();
            labelInput = new Label();
            splitter1 = new Splitter();
            panel4 = new Panel();
            dataGridViewOut = new DataGridView();
            labelOutput = new Label();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            saveFileDialogTask = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Controls.Add(buttonHelp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 64);
            panel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(165, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 55);
            buttonSave.TabIndex = 2;
            toolTip.SetToolTip(buttonSave, "Сохраняет результат");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(84, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 55);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Выводит слова, в которых встречается r в результирующую матрицу");
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
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Location = new Point(811, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 55);
            buttonHelp.TabIndex = 0;
            toolTip.SetToolTip(buttonHelp, "Сведения о исполнителе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask.Location = new Point(3, 3);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(883, 53);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxTask);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 60);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewIn);
            panel3.Controls.Add(labelInput);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 400);
            panel3.TabIndex = 3;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(12, 21);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.Size = new Size(270, 367);
            dataGridViewIn.TabIndex = 1;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(3, 3);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(36, 15);
            labelInput.TabIndex = 0;
            labelInput.Text = "Ввод:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(288, 124);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(5, 400);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewOut);
            panel4.Controls.Add(labelOutput);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(293, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(596, 400);
            panel4.TabIndex = 5;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(6, 21);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.Size = new Size(578, 367);
            dataGridViewOut.TabIndex = 2;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(6, 3);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(45, 15);
            labelOutput.TabIndex = 0;
            labelOutput.Text = "Вывод:";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // saveFileDialogTask
            // 
            saveFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 524);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт #6 | Таск 7 | Вариант 8 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxTask;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private Panel panel4;
        private DataGridView dataGridViewIn;
        private Label labelInput;
        private DataGridView dataGridViewOut;
        private Label labelOutput;
        private Button buttonSave;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private OpenFileDialog saveFileDialogTask;
    }
}
