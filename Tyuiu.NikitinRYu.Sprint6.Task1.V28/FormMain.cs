using System.Text;
using Tyuiu.NikitinRYu.Sprint6.Task1.V28.Lib;

namespace Tyuiu.NikitinRYu.Sprint6.Task1.V28
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
                int startStep = int.Parse(textBoxStart.Text);
                int stopStep = int.Parse(textBoxFinish.Text);

                DataService ds = new DataService();

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult.Clear();

                textBoxResult.AppendText("----------+----------" + Environment.NewLine);
                textBoxResult.AppendText("|    х     |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("----------+---------" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    string strLine = String.Format("|{0,5:d}    | {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult.AppendText("-----+-----" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Никитин Р.Ю.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateIntegerInput(sender as TextBox, e);
        }

        private void textBoxFinish_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateIntegerInput(sender as TextBox, e);
        }

        private void ValidateIntegerInput(TextBox textBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && textBox.Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
