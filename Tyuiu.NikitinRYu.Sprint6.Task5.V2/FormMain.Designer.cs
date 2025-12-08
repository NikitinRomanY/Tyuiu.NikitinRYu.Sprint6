namespace Tyuiu.NikitinRYu.Sprint6.Task5.V2
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
            splitter1 = new Splitter();
            panel3 = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridViewNums = new DataGridView();
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            buttonsOpen = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            panel2.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            panel1.SuspendLayout();
            groupBoxTask.SuspendLayout();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(286, 97);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 579);
            splitter1.TabIndex = 32;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartFunction);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(286, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 579);
            panel3.TabIndex = 31;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(11, 9);
            chartFunction.Name = "chartFunction";
            chartFunction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(947, 561);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOutput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 579);
            panel2.TabIndex = 30;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewNums);
            groupBoxOutput.Location = new Point(3, 6);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(277, 561);
            groupBoxOutput.TabIndex = 24;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод:";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(9, 22);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.Size = new Size(262, 533);
            dataGridViewNums.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBoxTask);
            panel1.Controls.Add(buttonsOpen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 97);
            panel1.TabIndex = 29;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DodgerBlue;
            buttonHelp.Location = new Point(1102, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(140, 70);
            buttonHelp.TabIndex = 23;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
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
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(781, 70);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // labelTask
            // 
            labelTask.Location = new Point(8, 22);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(767, 45);
            labelTask.TabIndex = 0;
            labelTask.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView. Вывести все отрицательные числа. Построить \r\nдиаграмму по этим значениям.";
            // 
            // buttonsOpen
            // 
            buttonsOpen.BackColor = Color.MediumBlue;
            buttonsOpen.Location = new Point(956, 12);
            buttonsOpen.Name = "buttonsOpen";
            buttonsOpen.Size = new Size(140, 70);
            buttonsOpen.TabIndex = 22;
            buttonsOpen.Text = "Открыть файл";
            buttonsOpen.UseVisualStyleBackColor = false;
            buttonsOpen.Click += buttonsOpen_Click;
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
            Text = "Спринт #6 | Таск 5 | Вариант 2 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            panel2.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            panel1.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Splitter splitter1;
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBoxOutput;
        private TextBox textBoxResult_NRY;
        private Panel panel1;
        private Button buttonHelp;
        private TextBox textBoxFinish_NRY;
        private TextBox textBoxStart_NRY;
        private Button buttonHelp_NRY;
        private Button buttonDone;
        private GroupBox groupBoxTask;
        private Label labelTask;
        private Button buttonsOpen;
        private DataGridView dataGridViewNums;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
