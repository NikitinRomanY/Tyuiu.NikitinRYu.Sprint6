namespace Tyuiu.NikitinRYu.Sprint6.Task3.V9
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
            groupBoxTask = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            labelTask = new Label();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            labelOutput = new Label();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewMatrix);
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(502, 426);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(233, 12);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(138, 142);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(6, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(193, 135);
            labelTask.TabIndex = 0;
            labelTask.Text = "Дан массив 5 на 5 элементов. \r\nВыполнить сортировку \r\nпо возрастанию в пятом столбце.\r\n\r\n-14  25  26  18  17\r\n  28  10   6  -2   4\r\n  30  25  -3  11 -10\r\n  11  32  -5 -20  25\r\n   2 -18  11   8 -20";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Controls.Add(labelOutput);
            groupBoxOutput.Location = new Point(520, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(268, 383);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(6, 37);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(217, 23);
            textBoxOutput.TabIndex = 1;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(6, 19);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(63, 15);
            labelOutput.TabIndex = 0;
            labelOutput.Text = "Результат:";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(707, 415);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(81, 23);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(674, 415);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(27, 23);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт #6 | Таск 3 | Вариант 9 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxOutput;
        private TextBox textBoxOutput;
        private Label labelOutput;
        private Button buttonDone;
        private Button buttonHelp;
        private DataGridView dataGridViewMatrix;
    }
}
