using Tyuiu.NikitinRYu.Sprint6.Task2.V15.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task2.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Никитин Р.Ю.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxFinish.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Clear();
                this.chartFunction.Titles.Add("График функции");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                dataGridViewTasks.Rows.Clear();
                chartFunction.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewTasks.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;

        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;

        }
    }
}
