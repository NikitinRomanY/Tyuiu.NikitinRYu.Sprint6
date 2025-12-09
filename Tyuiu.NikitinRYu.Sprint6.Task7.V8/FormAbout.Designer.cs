namespace Tyuiu.NikitinRYu.Sprint6.Task7.V8
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOK = new Button();
            labelDescription = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(542, 246);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 5;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(288, 19);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(284, 67);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Таск 7 выполнил студент группы ИБКСб-25-1 Никитин Р.Ю.\r\nПрограмма выполнена на языке программирования C#.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profIkon;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 257);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 281);
            Controls.Add(buttonOK);
            Controls.Add(labelDescription);
            Controls.Add(pictureBox1);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOK;
        private Label labelDescription;
        private PictureBox pictureBox1;
    }
}