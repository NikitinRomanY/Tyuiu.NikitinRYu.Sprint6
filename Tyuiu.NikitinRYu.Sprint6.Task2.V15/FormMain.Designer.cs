namespace Tyuiu.NikitinRYu.Sprint6.Task2.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxOutput = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewTasks = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxInput = new GroupBox();
            textBoxFinish = new TextBox();
            labelFinish = new Label();
            textBoxStart = new TextBox();
            labelStart = new Label();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxTask.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(chartFunction);
            groupBoxOutput.Controls.Add(dataGridViewTasks);
            groupBoxOutput.Location = new Point(466, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(635, 426);
            groupBoxOutput.TabIndex = 20;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Результат";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(180, 23);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(449, 397);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] { X, Result });
            dataGridViewTasks.Location = new Point(6, 22);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersVisible = false;
            dataGridViewTasks.Size = new Size(154, 327);
            dataGridViewTasks.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Result
            // 
            Result.HeaderText = "F:(X)";
            Result.Name = "Result";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(261, 283);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(48, 45);
            buttonHelp.TabIndex = 19;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(322, 285);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(128, 45);
            buttonDone.TabIndex = 18;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxFinish);
            groupBoxInput.Controls.Add(labelFinish);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Location = new Point(12, 262);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(243, 76);
            groupBoxInput.TabIndex = 17;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Входные данные";
            // 
            // textBoxFinish
            // 
            textBoxFinish.Location = new Point(128, 37);
            textBoxFinish.Name = "textBoxFinish";
            textBoxFinish.Size = new Size(100, 23);
            textBoxFinish.TabIndex = 3;
            textBoxFinish.Text = "5";
            // 
            // labelFinish
            // 
            labelFinish.AutoSize = true;
            labelFinish.Location = new Point(128, 19);
            labelFinish.Name = "labelFinish";
            labelFinish.Size = new Size(82, 15);
            labelFinish.TabIndex = 2;
            labelFinish.Text = "Финиш шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 37);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 1;
            textBoxStart.Text = "-5";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 19);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(72, 15);
            labelStart.TabIndex = 0;
            labelStart.Text = "Старт шага:";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(438, 244);
            groupBoxTask.TabIndex = 16;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(6, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(382, 15);
            labelTask.TabIndex = 0;
            labelTask.Text = "Написать программу, которая выводит таблицу значений функции:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 450);
            Controls.Add(groupBoxOutput);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт #6 | Таск 2 | Вариант 15 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOutput;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxInput;
        private TextBox textBoxFinish;
        private Label labelFinish;
        private TextBox textBoxStart;
        private Label labelStart;
        private GroupBox groupBoxTask;
        private Label labelTask;
        private DataGridView dataGridViewTasks;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
