using Tyuiu.NikitinRYu.Sprint6.Task5.V2.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V2.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                // Очищаем DataGridView и Chart
                dataGridViewNums.Rows.Clear();
                chartFunction.Series[0].Points.Clear();

                // Получаем данные из файла
                double[] numsArray = ds.LoadFromDataFile(path);

                // Заполняем DataGridView
                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.Columns[0].Width = 50;
                dataGridViewNums.Columns[0].HeaderText = "Номер";
                dataGridViewNums.Columns[1].Width = 100;
                dataGridViewNums.Columns[1].HeaderText = "Отрицательное число";

                for (int i = 0; i < numsArray.Length; i++)
                {
                    dataGridViewNums.Rows.Add(i + 1, numsArray[i].ToString("F3"));
                }

                // Строим диаграмму
                chartFunction.ChartAreas[0].AxisX.Title = "Номер элемента";
                chartFunction.ChartAreas[0].AxisY.Title = "Значение";
                chartFunction.Series[0].LegendText = "Отрицательные числа";

                for (int i = 0; i < numsArray.Length; i++)
                {
                    chartFunction.Series[0].Points.AddXY(i + 1, numsArray[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем файл в блокноте
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-25-1 Никитин Р.Ю.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
