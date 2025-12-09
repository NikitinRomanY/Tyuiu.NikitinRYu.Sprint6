using System.Text;
using Tyuiu.NikitinRYu.Sprint6.Task7.V8.Lib;
using Tyuiu.NikitinRYu.Sprint6.Task7.V8.Properties;

namespace Tyuiu.NikitinRYu.Sprint6.Task7.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonOpenFile.Image = Resources.folder_page;
            buttonDone.Image = Resources.page_go;
            buttonHelp.Image = Resources.help;
            buttonSave.Image = Resources.page_save;

            openFileDialogTask.Filter = "Значения, разделённые точкой с запятой (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogTask.Filter = "Значения, разделённые точкой с запятой (*.csv)|*.csv|Все файлы (*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            // Разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Определяем количество строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            // Выделяем массив данных
            int[,] arrayValues = new int[rows, columns];

            // Заполняем массив данными
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла
            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask.FileName;

                try
                {
                    // Загружаем данные из файла
                    int[,] arrayValues = LoadFromFileData(openFilePath);

                    // Настраиваем DataGridView для ввода
                    dataGridViewIn.ColumnCount = columns;
                    dataGridViewIn.RowCount = rows;

                    // Настраиваем DataGridView для вывода
                    dataGridViewOut.ColumnCount = columns;
                    dataGridViewOut.RowCount = rows;

                    // Задаем ширину столбцов
                    for (int i = 0; i < columns; i++)
                    {
                        dataGridViewIn.Columns[i].Width = 50;
                        dataGridViewOut.Columns[i].Width = 50;
                    }

                    // Добавляем данные в dataGridViewIn
                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                        }
                    }

                    // Активируем кнопку "Выполнить"
                    buttonDone.Enabled = true;

                    // Показываем информацию
                    textBoxTask.Text = $"Файл загружен. Строк: {rows}, Столбцов: {columns}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем преобразованную матрицу
                int[,] transformedMatrix = ds.GetMatrixAndTransform(openFilePath);

                // Выводим преобразованные данные в dataGridViewOut
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut.Rows[r].Cells[c].Value = transformedMatrix[r, c];
                    }
                }

                // Подсвечиваем 8-й столбец (индекс 7)
                for (int r = 0; r < rows; r++)
                {
                    dataGridViewOut.Rows[r].Cells[7].Style.BackColor = Color.LightYellow;
                }

                // Активируем кнопку "Сохранить"
                buttonSave.Enabled = true;

                // Показываем информацию
                textBoxTask.Text = "Матрица преобразована. 8-й столбец изменён.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при преобразовании матрицы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Всегда сохраняем в C:\DataSprint6\
                string directoryPath = @"C:\DataSprint6\";
                string fileName = "OutPutFileTask7V8.csv";
                string fullPath = Path.Combine(directoryPath, fileName);

                // Создаем папку, если её нет
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Сохраняем
                using (StreamWriter writer = new StreamWriter(fullPath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            writer.Write(dataGridViewOut.Rows[i].Cells[j].Value);
                            if (j < columns - 1)
                            {
                                writer.Write(";");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                // Проверяем и показываем результат
                if (File.Exists(fullPath))
                {
                    MessageBox.Show($"Файл сохранен:\n{fullPath}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("explorer.exe", directoryPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridViewIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Устанавливаем начальные размеры как у преподавателя
            dataGridViewIn.ColumnCount = 50;
            dataGridViewOut.ColumnCount = 50;
            dataGridViewIn.RowCount = 50;
            dataGridViewOut.RowCount = 50;

            // Настраиваем ширину столбцов
            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn.Columns[i].Width = 50;
                dataGridViewOut.Columns[i].Width = 50;
            }
        }
    }
}
