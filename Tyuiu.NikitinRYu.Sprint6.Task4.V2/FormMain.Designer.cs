namespace Tyuiu.NikitinRYu.Sprint6.Task4.V2
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
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxInput = new GroupBox();
            textBoxFinish_NRY = new TextBox();
            labelFinish = new Label();
            textBoxStart_NRY = new TextBox();
            labelStart = new Label();
            buttonDone = new Button();
            buttonsSave_NRY = new Button();
            buttonHelp_NRY = new Button();
            groupBoxOutput = new GroupBox();
            textBoxResult_NRY = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(400, 70);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(8, 22);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(388, 45);
            labelTask.TabIndex = 0;
            labelTask.Text = "Написать программу, которая выводит таблицу значений функции:\r\nРезультат вывести в textBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V2.txt по нажатию кнопки.";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxFinish_NRY);
            groupBoxInput.Controls.Add(labelFinish);
            groupBoxInput.Controls.Add(textBoxStart_NRY);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Location = new Point(420, 13);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(240, 70);
            groupBoxInput.TabIndex = 18;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных:";
            // 
            // textBoxFinish_NRY
            // 
            textBoxFinish_NRY.Location = new Point(128, 37);
            textBoxFinish_NRY.Name = "textBoxFinish_NRY";
            textBoxFinish_NRY.Size = new Size(100, 23);
            textBoxFinish_NRY.TabIndex = 3;
            textBoxFinish_NRY.Text = "5";
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
            // textBoxStart_NRY
            // 
            textBoxStart_NRY.Location = new Point(6, 37);
            textBoxStart_NRY.Name = "textBoxStart_NRY";
            textBoxStart_NRY.Size = new Size(100, 23);
            textBoxStart_NRY.TabIndex = 1;
            textBoxStart_NRY.Text = "-5";
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
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(810, 13);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(140, 70);
            buttonDone.TabIndex = 20;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonsSave_NRY
            // 
            buttonsSave_NRY.BackColor = Color.MediumBlue;
            buttonsSave_NRY.Location = new Point(956, 12);
            buttonsSave_NRY.Name = "buttonsSave_NRY";
            buttonsSave_NRY.Size = new Size(140, 70);
            buttonsSave_NRY.TabIndex = 22;
            buttonsSave_NRY.Text = "Сохранить";
            buttonsSave_NRY.UseVisualStyleBackColor = false;
            buttonsSave_NRY.Click += buttonsSave_Click;
            // 
            // buttonHelp_NRY
            // 
            buttonHelp_NRY.BackColor = Color.DodgerBlue;
            buttonHelp_NRY.Location = new Point(1102, 12);
            buttonHelp_NRY.Name = "buttonHelp_NRY";
            buttonHelp_NRY.Size = new Size(140, 70);
            buttonHelp_NRY.TabIndex = 23;
            buttonHelp_NRY.Text = "Справка";
            buttonHelp_NRY.UseVisualStyleBackColor = false;
            buttonHelp_NRY.Click += buttonHelp_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxResult_NRY);
            groupBoxOutput.Location = new Point(3, 6);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(277, 561);
            groupBoxOutput.TabIndex = 24;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод:";
            // 
            // textBoxResult_NRY
            // 
            textBoxResult_NRY.Location = new Point(6, 22);
            textBoxResult_NRY.Multiline = true;
            textBoxResult_NRY.Name = "textBoxResult_NRY";
            textBoxResult_NRY.Size = new Size(267, 533);
            textBoxResult_NRY.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxInput);
            panel1.Controls.Add(buttonHelp_NRY);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBoxTask);
            panel1.Controls.Add(buttonsSave_NRY);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 97);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOutput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 579);
            panel2.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartFunction);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(286, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 579);
            panel3.TabIndex = 27;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(9, 6);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(947, 561);
            chartFunction.TabIndex = 0;
            chartFunction.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(286, 97);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 579);
            splitter1.TabIndex = 28;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 676);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Таск 4 | Вариант 2 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxInput;
        private TextBox textBoxFinish_NRY;
        private Label labelFinish;
        private TextBox textBoxStart_NRY;
        private Label labelStart;
        private Button buttonHelp_NRY;
        private GroupBox groupBoxOutput;
        private TextBox textBoxResult_NRY;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private Button buttonDone;
        private Button buttonsSave_NRY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
