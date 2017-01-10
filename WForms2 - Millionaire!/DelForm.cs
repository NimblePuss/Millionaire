using System;
using System.Windows.Forms;

namespace WForms2___Millionaire_
{
    public partial class DelForm : Form, IDelForm
    {
        public DelForm()
        {
            InitializeComponent();
        }

        public int DelNumQuestion
        {
            set { numericUpDownDelQues.Value = value; }
            get { return Convert.ToInt32(numericUpDownDelQues.Value); }
        }

        public string DelQuestion
        {
            set { textBoxDelQuestion.Text = value; }
            get { return textBoxDelQuestion.Text.Trim(); }
        }

        public event EventHandler<EventArgs> EvNumDelQuestion;

        public event EventHandler<EventArgs> EvDelQuestion;
        public void LetDelQuestion()
        {
            MessageBox.Show("Вопрос удален!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (EvNumDelQuestion != null)
                EvNumDelQuestion(this, EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e) // OK
        {
            if (EvDelQuestion != null)
                EvDelQuestion(this, EventArgs.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)  // отмена
        {
            Close();
        }
    }
}
