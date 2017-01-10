using System;
using System.Windows.Forms;

namespace WForms2___Millionaire_
{
    public partial class EditForm : Form, IEditForm
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public int EditNumQuestion
        {
            set { numericUpDownEditQues.Value = value; }
            get { return Convert.ToInt32(numericUpDownEditQues.Value); }
        }

        public string EditQuestion
        {
            set { textBoxEditQuestion.Text = value; }
            get { return textBoxEditQuestion.Text.Trim(); }
        }

        public string EditAnswer1
        {
            set { textBoxEditAnswer1.Text = value; }
            get { return textBoxEditAnswer1.Text.Trim(); }
        }

        public string EditAnswer2
        {
            set { textBoxEditAnswer2.Text = value; }
            get { return textBoxEditAnswer2.Text.Trim(); }
        }

        public string EditAnswer3
        {
            set { textBoxEditAnswer3.Text = value; }
            get { return textBoxEditAnswer3.Text.Trim(); }
        }

        public string EditAnswer4
        {
            set { textBoxEditAnswer4.Text = value; }
            get { return textBoxEditAnswer4.Text.Trim(); }
        }

        public event EventHandler<EventArgs> EvNumEdQuestion;
        public event EventHandler<EventArgs> EvEdQuestion;

        public void LetEdQuestion()
        {
            MessageBox.Show("Вопрос отредактирован!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        public void DontLetEdQuestion()
        {

            MessageBox.Show("Не все поля заполнены!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (EvNumEdQuestion != null)
                EvNumEdQuestion(this, EventArgs.Empty);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //OK
        {
            if (EvEdQuestion != null)
                EvEdQuestion(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e) //Cansel
        {
            Close();
        }
    }
}
