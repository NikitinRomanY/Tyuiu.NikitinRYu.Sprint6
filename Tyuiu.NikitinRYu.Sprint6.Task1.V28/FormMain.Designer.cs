namespace Tyuiu.NikitinRYu.Sprint6.Task1.V28
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
            labelTask = new Label();
            groupBoxInput = new GroupBox();
            textBoxFinish = new TextBox();
            labelFinish = new Label();
            textBoxStart = new TextBox();
            labelStart = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxOutput = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(438, 244);
            groupBoxTask.TabIndex = 0;
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
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxFinish);
            groupBoxInput.Controls.Add(labelFinish);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Location = new Point(12, 262);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(243, 76);
            groupBoxInput.TabIndex = 1;
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
            textBoxFinish.KeyPress += textBoxFinish_KeyPress;
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
            textBoxStart.KeyPress += textBoxStart_KeyPress;
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
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(261, 283);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(48, 45);
            buttonHelp.TabIndex = 14;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(322, 285);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(128, 45);
            buttonDone.TabIndex = 13;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Location = new Point(466, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(322, 426);
            groupBoxOutput.TabIndex = 15;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(310, 398);
            textBoxResult.TabIndex = 0;
            textBoxResult.WordWrap = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт #6 | Таск 1 | Вариант 28 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxInput;
        private TextBox textBoxFinish;
        private Label labelFinish;
        private TextBox textBoxStart;
        private Label labelStart;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxOutput;
        private TextBox textBoxResult;
    }
}
