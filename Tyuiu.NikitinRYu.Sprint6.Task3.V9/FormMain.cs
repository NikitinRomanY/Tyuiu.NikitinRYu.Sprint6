using Tyuiu.NikitinRYu.Sprint6.Task3.V9.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        int[,] mtrx = new int[5, 5]
        {
            {-14, 25, 26, 18, 17},
            {28, 10, 6, -2, 4},
            {30, 25, -3, 11, -10},
            {11, 32, -5, -20, 25},
            {2, -18, 11, 8, -20}
        };
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                int[,] result = ds.Calculate(mtrx);

                int rows = result.GetLength(0);
                int columns = result.GetLength(1);

                dataGridViewMatrix.Rows.Clear();
                dataGridViewMatrix.RowCount = rows;
                dataGridViewMatrix.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                    }
                }

                textBoxOutput.Text = "Сортировка 5-го столбца выполнена!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Никитин Р.Ю.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
