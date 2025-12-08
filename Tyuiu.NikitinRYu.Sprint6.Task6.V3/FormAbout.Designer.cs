namespace Tyuiu.NikitinRYu.Sprint6.Task6.V3
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
            pictureBox1 = new PictureBox();
            labelDescription = new Label();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profIkon;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 257);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(288, 19);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(284, 67);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Таск 6 выполнил студент группы ИБКСб-25-1 Никитин Р.Ю.\r\nПрограмма выполнена на языке программирования C#.";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(542, 246);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += button1_Click;
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

        private PictureBox pictureBox1;
        private Label labelDescription;
        private Button buttonOK;
    }
}