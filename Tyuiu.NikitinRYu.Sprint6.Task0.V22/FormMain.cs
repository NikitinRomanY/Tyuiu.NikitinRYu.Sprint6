using Tyuiu.NikitinRYu.Sprint6.Task0.V22.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task0.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxVarX.Text, out int x))
                {
                    MessageBox.Show("Введите целое число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxVarX.Focus();
                    return;
                }

                DataService ds = new DataService();
                double result = ds.Calculate(x);

                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКСб-25-1 Никитин Р.Ю.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
