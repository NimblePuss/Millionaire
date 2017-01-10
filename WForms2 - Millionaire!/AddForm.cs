using System;
using System.Windows.Forms;

namespace WForms2___Millionaire_
{
    public partial class AddForm : Form, IAddForm
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public string AddQuestion
        {
            set { textBoxQuestion.Text = value; }
            get { return textBoxQuestion.Text.Trim(); }
        }

        public string AddAnswer1
        {
            set { textBoxAnswer1.Text = value; }
            get { return textBoxAnswer1.Text.Trim(); }
        }

        public string AddAnswer2
        {
            set { textBoxAnswer2.Text = value; }
            get { return textBoxAnswer2.Text.Trim(); }
        }

        public string AddAnswer3
        {
            set { textBoxAnswer3.Text = value; }
            get { return textBoxAnswer3.Text.Trim(); }
        }

        public string AddAnswer4
        {
            set { textBoxAnswer4.Text = value; }
            get { return textBoxAnswer4.Text.Trim(); }
        }

        // Представление выставляет наружу подписку на происходящие в нем события
        public event EventHandler<EventArgs> EvAddQues;

        public void LetAddQuestion()
        {
            MessageBox.Show("Вопрос успешно добавлен!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        public void DontLetAddQuestion()
        {
            MessageBox.Show("Не все поля заполнены!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.None;
        }
        private void Addbutton1_Click(object sender, EventArgs e) // добавить
        {
            if (EvAddQues != null)
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                EvAddQues(this, EventArgs.Empty);
        }

        private void Addbutton2_Click(object sender, EventArgs e) // отмена
        {
           Close();
        }

        private void AddQueslabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // вопрос
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // ответ1
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // ответ2
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e) // ответ3
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e) // ответ4
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
