namespace Tyuiu.NikitinRYu.Sprint6.Task0.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxFormula = new PictureBox();
            labelVarX = new Label();
            textBoxVarX = new TextBox();
            labelResult = new Label();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            textBoxTask = new TextBox();
            groupBoxTask = new GroupBox();
            buttonHelp = new Button();
            groupBoxInput = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(552, 22);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(218, 40);
            pictureBoxFormula.TabIndex = 2;
            pictureBoxFormula.TabStop = false;
            // 
            // labelVarX
            // 
            labelVarX.AutoSize = true;
            labelVarX.Location = new Point(6, 47);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(86, 15);
            labelVarX.TabIndex = 5;
            labelVarX.Text = "Переменная X";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(6, 65);
            textBoxVarX.MaxLength = 10;
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 23);
            textBoxVarX.TabIndex = 6;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 22);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 15);
            labelResult.TabIndex = 7;
            labelResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 40);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 8;
            textBoxResult.TabStop = false;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(630, 393);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(158, 45);
            buttonDone.TabIndex = 9;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(478, 225);
            textBoxTask.TabIndex = 10;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(776, 277);
            groupBoxTask.TabIndex = 11;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(570, 393);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(48, 45);
            buttonHelp.TabIndex = 12;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(labelVarX);
            groupBoxInput.Controls.Add(textBoxVarX);
            groupBoxInput.Location = new Point(12, 298);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(235, 140);
            groupBoxInput.TabIndex = 13;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResult);
            groupBox1.Controls.Add(labelResult);
            groupBox1.Location = new Point(658, 298);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(130, 79);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxInput);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Таск 0 | Вариант 22 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxFormula;
        private Label labelVarX;
        private TextBox textBoxVarX;
        private Label labelResult;
        private TextBox textBoxResult;
        private Button buttonDone;
        private TextBox textBoxTask;
        private GroupBox groupBoxTask;
        private Button buttonHelp;
        private GroupBox groupBoxInput;
        private GroupBox groupBox1;
    }
}
