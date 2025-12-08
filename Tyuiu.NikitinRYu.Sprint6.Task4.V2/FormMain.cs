using System.Windows.Forms.VisualStyles;
using Tyuiu.NikitinRYu.Sprint6.Task4.V2.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task4.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int startStep = -5;
                int stopStep = 5;

                int len = (stopStep - startStep) + 1;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Clear();
                this.chartFunction.Titles.Add("График функции");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_NRY.Text = "";
                chartFunction.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_NRY.AppendText($"F({startStep}) = {valueArray[i]}" + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void buttonDone_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int startStep = Convert.ToInt32(textBoxStart_NRY.Text);
        //        int stopStep = Convert.ToInt32(textBoxFinish_NRY.Text);

        //        int len = ds.GetMassFunction(startStep, stopStep).Length;
        //        double[] valueArray;
        //        valueArray = new double[len];
        //        valueArray = ds.GetMassFunction(startStep, stopStep);

        //        this.chartFunction.Titles.Clear();
        //        this.chartFunction.Titles.Add("График функции");
        //        this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
        //        this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

        //        textBoxResult_NRY.Text = "";
        //        chartFunction.Series[0].Points.Clear();

        //        for (int i = 0; i <= len - 1; i++)
        //        {
        //            textBoxResult_NRY.AppendText($"F({startStep}) = {valueArray[i]}" + Environment.NewLine);
        //            this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
        //            startStep++;
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private void buttonsSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V2.txt";
                File.WriteAllText(path, textBoxResult_NRY.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-25-1 Никитин Р.Ю.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
