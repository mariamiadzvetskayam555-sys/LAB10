namespace LAB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxEvent.Items.Add("Шоу талантов");
            comboBoxEvent.Items.Add("Хакатон");
            comboBoxEvent.Items.Add("Спортивные соревнования");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show(
                "Введите имя участника!",
                "Ошибка ввода",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            foreach (char c in textBoxName.Text)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show(
                    "Имя не должно содержать цифр!",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show(
                "Введите возраст целым числом.",
                "Ошибка ввода",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            if (age < 0 || age > 120)
            {
                MessageBox.Show("Возраст должен быть от 0 до 120.");
                return;
            }

            if (comboBoxEvent.SelectedItem == null)
            {
                MessageBox.Show(
                    "Выберите мероприятие из списка!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string form = "";
            if (radioButtonInAbsentia.Checked)
            {
                form = "заочно";
            }
            else if (radioButtonInPerson.Checked)
            {
                form = "очно";
            }
            else
            {
                MessageBox.Show(
                    "Выберите формат участия!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string notification = "";
            if (checkBoxNotification.Checked)
            {
                notification = "включены";
            }
            else
            {
                notification = "выключены";
            }

            labelResult.Text = $"Участник: {textBoxName.Text}\n" +
                                $"Возраст: {age}\n" +
                                $"Мероприятие: {comboBoxEvent.SelectedItem}\n" +
                                $"Формат: {form}\n" +
                                $"Уведомления: {notification}";
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            comboBoxEvent.SelectedIndex = -1;
            radioButtonInAbsentia.Checked = false;
            radioButtonInPerson.Checked = false;
            checkBoxNotification.Checked = false;
            labelResult.Text = "";
        }
    }
}
