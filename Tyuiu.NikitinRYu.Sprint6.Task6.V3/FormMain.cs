using Tyuiu.NikitinRYu.Sprint6.Task6.V3.Lib;
using Tyuiu.NikitinRYu.Sprint6.Task6.V3.Properties;

namespace Tyuiu.NikitinRYu.Sprint6.Task6.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonOpenFile.Image = Resources.folder_page;
            buttonDone.Image = Resources.page_go;
            buttonHelp.Image = Resources.help;
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            // Настраиваем диалог открытия файла
            openFileDialogTask.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialogTask.FilterIndex = 1;
            openFileDialogTask.InitialDirectory = @"C:\";

            // Открываем диалог
            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask.FileName;

                try
                {
                    // Показываем содержимое файла
                    textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);

                    // Активируем кнопку выполнения
                    buttonDone.Enabled = true;

                    // Показываем информацию
                    textBoxTask.Text = $"Файл открыт: {Path.GetFileName(openFilePath)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что файл выбран
                if (string.IsNullOrEmpty(openFilePath) || !File.Exists(openFilePath))
                {
                    MessageBox.Show("Сначала откройте файл!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Обрабатываем файл и ищем слова с буквой 'r'
                string result = ds.CollectTextFromFile(openFilePath);

                // Выводим результат
                textBoxResult.Text = result;

                // Показываем статистику
                if (string.IsNullOrEmpty(result))
                {
                    textBoxTask.Text = "Слов с буквой 'r' не найдено";
                }
                else
                {
                    int wordCount = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    textBoxTask.Text = $"Найдено слов с буквой 'r': {wordCount}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
