using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace WForms2___Millionaire_
{
    public partial class PlayForm : Form, IPlayForm
    {
        
        public event EventHandler<EventArgs> EvStartGame;
        public event EventHandler<EventArgs> EvCheckButtonUp;
        public event EventHandler<EventArgs> Ev50to50;
        public event EventHandler<EventArgs> EvCallFriend;
        public event EventHandler<EventArgs> EvHelpPeople;
        public event EventHandler<EventArgs> EvStopGame;
        public PlayForm()
        {
            InitializeComponent();
            PlayPresenter PlPr = new PlayPresenter(this);
            buttonAnswer1.Enabled = false;
            buttonAnswer2.Enabled = false;
            buttonAnswer3.Enabled = false;
            buttonAnswer4.Enabled = false;
        }
        public string OutputQuestion 
        {
            set
            { 
                labelQuestion.Text = value;
                labelAnswerPresenter.Visible = false;
                pictureBoxPresenter.Visible = false;
                labelAnswerFriend.Visible = false;
                pictureBoxFriend.Visible = false;
                groupBoxHelpPeople.Visible = false;
               
                listBox1WinSum.SetSelected(num, true);
            }
            get { return labelQuestion.Text;}
        }
        public string OutputAnswer1
        {
            set 
            {
                buttonAnswer1.Text = value; 
                buttonAnswer1.BackColor = Color.Black;
            }
            get { return buttonAnswer1.Text; }
        }
        public string OutputAnswer2 
        {
            set 
            { 
                buttonAnswer2.Text = value;
                buttonAnswer2.BackColor = Color.Black;
            }
            get { return buttonAnswer2.Text; }
        }
        public string OutputAnswer3 
        {
            set 
            { 
                buttonAnswer3.Text = value;
                buttonAnswer3.BackColor = Color.Black;
            }
            get { return buttonAnswer3.Text; }
        }
        public string OutputAnswer4
        {
            set
            {
                buttonAnswer4.Text = value;
                buttonAnswer4.BackColor = Color.Black;
            }
            get { return buttonAnswer4.Text; }
        }
        public string ButtonUp { set; get; }
        public void GameOver()
        {

            labelGameOver.Visible = true;
            labelGameOver.Text = "Игра окончена!!! Вы проиграли!!!";
            buttonAnswer1.Enabled = false;
            buttonAnswer2.Enabled = false;
            buttonAnswer3.Enabled = false;
            buttonAnswer4.Enabled = false;

            listBox1WinSum.SetSelected(0, false);
            buttonStop.Enabled = false; 
            SoundPlayer player = new SoundPlayer("../../false.wav");
            player.Play();
            администраторскийРежимToolStripMenuItem.Enabled = true;
            оПрограммеToolStripMenuItem.Enabled = true; 
        }
        public void YouWin()
        {
            labelGameOver.Visible = true;
            labelGameOver.Text = "Поздравляем!!! Вы выиграли 1000000 гривен!!!";
            buttonAnswer1.Enabled = false;
            buttonAnswer2.Enabled = false;
            buttonAnswer3.Enabled = false;
            buttonAnswer4.Enabled = false;
            listBox1WinSum.SetSelected(0, false);
            buttonStop.Enabled = false; 
            SoundPlayer player = new SoundPlayer("../../winner.wav");
            player.Play();
            администраторскийРежимToolStripMenuItem.Enabled = true;
            оПрограммеToolStripMenuItem.Enabled = true; 
        }
        public void StopGame()
        {
            labelGameOver.Visible = true;
            labelGameOver.Text = "Игра окончена!!!";
            labelQuestion.Enabled = false;
            buttonAnswer1.Enabled = false;
            buttonAnswer2.Enabled = false;
            buttonAnswer3.Enabled = false;
            buttonAnswer4.Enabled = false;
            listBox1WinSum.SetSelected(0, false);
            SoundPlayer player = new SoundPlayer("../../summa.wav");
            player.Play();
            администраторскийРежимToolStripMenuItem.Enabled = true;
            оПрограммеToolStripMenuItem.Enabled = true; 
 
        }
        public string AnswerPresenter // для вывода текста ведущего
        {
            set 
            { 
                labelAnswerPresenter.Text = value;
                labelAnswerPresenter.Visible = true;
                pictureBoxPresenter.Visible = true;
            }
            get { return labelAnswerPresenter.Text; } 
        }

        public string AnswerFriend
        {
            set { labelAnswerFriend.Text = value; }
            get { return labelAnswerFriend.Text; }
        }


        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm Add = new AddForm();
            AddPresenter AddPr = new AddPresenter(Add);
            Add.ShowDialog();
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelForm Del = new DelForm();
            DelPresenter DelPr = new DelPresenter(Del);
            Del.ShowDialog();
        }

        private void редактированиеВопросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm Edit = new EditForm();
            EditPresenter EditPr = new EditPresenter(Edit);
            Edit.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void администраторскийРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SettingsButtons()
        {
            button50to50.BackgroundImage = WForms2___Millionaire_.Properties.Resources._1;
            button50to50.Enabled = true;
            buttonCallFriend.BackgroundImage = WForms2___Millionaire_.Properties.Resources._2;
            labelAnswerFriend.Text = "";
            buttonCallFriend.Enabled = true;
            buttonHelpPeople.BackgroundImage = WForms2___Millionaire_.Properties.Resources._3;
            buttonHelpPeople.Enabled = true;
        }
        public Color ChangeColorA1
        {
            set { buttonAnswer1.BackColor = value; }

            get { return buttonAnswer1.BackColor; }
        }

        public Color ChangeColorA2
        {
            set { buttonAnswer2.BackColor = value; }

            get { return buttonAnswer2.BackColor; }
        }
        public Color ChangeColorA3
        {
            set { buttonAnswer3.BackColor = value; }

            get { return buttonAnswer3.BackColor; }
        }
        public Color ChangeColorA4
        {
            set { buttonAnswer4.BackColor = value; }

            get { return buttonAnswer4.BackColor; }
        }

        public bool ButtonA1Enabled
        {
            set { buttonAnswer1.Enabled = value; }
            get { return buttonAnswer1.Enabled; }
        }
        public bool ButtonA2Enabled
        {
            set { buttonAnswer2.Enabled = value; }
            get { return buttonAnswer2.Enabled; }
        }
        public bool ButtonA3Enabled
        {
            set { buttonAnswer3.Enabled = value; }
            get { return buttonAnswer3.Enabled; }
        }

        public bool ButtonA4Enabled
        {
            set { buttonAnswer4.Enabled = value; }
            get { return buttonAnswer4.Enabled; }
        }

        public Button ButtonUpCheck { set; get; }
        int num = 14;
  
        public string TextListBox { get { return listBox1WinSum.SelectedItem.ToString(); } }
        public string TextListBox2 { get { return listBox1WinSum.Items[num+1].ToString(); } }
        // listBox1WinSum.SelectedItem.ToString()
        // listBox1WinSum.Items[num].ToString();

        private void button7_ClickAswer1(object sender, EventArgs e)
        {
           
            Button b = (Button)sender; // приходит sender ( у нас - имя кнопки)
            ButtonUp = b.Text;
            ButtonUpCheck = b;
            buttonStop.Enabled = true;
            num--;

            if (EvCheckButtonUp != null)
                EvCheckButtonUp(b, EventArgs.Empty); // передаю Button - в EvCheckButtonUp(b!! , а не this

        }
        public void SoundTrue()
        {
            SoundPlayer player = new SoundPlayer("../../true.wav");
            player.Play();
        }

        private void buttonStart_Click(object sender, EventArgs e) // Start
        {
            num = 14;
            if (EvStartGame != null)
                EvStartGame(this, EventArgs.Empty);
            labelQuestion.Enabled = true;
            labelQuestion.Visible = true;
            labelAnswerPresenter.Visible = false;
            администраторскийРежимToolStripMenuItem.Enabled = false;
            оПрограммеToolStripMenuItem.Enabled = false; 
            labelGameOver.Text = null;
            labelGameOver.Visible = false;
            listBox1WinSum.SetSelected(num, true);
            buttonStop.Enabled = false;

            SoundPlayer player = new SoundPlayer("../../begin.wav");
            player.Play();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelAnswerPresenter_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button50to50_Click_1(object sender, EventArgs e) // 50 на 50
        {      
            if (Ev50to50 != null)
                Ev50to50(this, EventArgs.Empty);
            button50to50.BackgroundImage = WForms2___Millionaire_.Properties.Resources._4;
            button50to50.Enabled = false;
            SoundPlayer player = new SoundPlayer("../../gong.wav");
            player.Play();
        }

        private void buttonCallFriend_Click(object sender, EventArgs e) // Звонок другу
        {
            if (EvCallFriend != null)
                EvCallFriend(this, EventArgs.Empty);
            buttonCallFriend.BackgroundImage = WForms2___Millionaire_.Properties.Resources._5;
            labelAnswerFriend.Visible = true;
            pictureBoxFriend.Visible = true;
            buttonCallFriend.Enabled = false;
            SoundPlayer player = new SoundPlayer("../../zvonok.wav");
            player.Play();
        }
        
        public ProgressBar PrBarA
        {
            set {progressBarA = value; }
            get { return progressBarA; }
        }
        public ProgressBar PrBarB
        {
            set { progressBarB = value; }
            get { return progressBarB; }
        }
        public ProgressBar PrBarC
        {
            set { progressBarC = value; }
            get { return progressBarC; }
        } 
        public ProgressBar PrBarD
        {
            set { progressBarD = value; }
            get { return progressBarD; }
        }
        public string PercentPrBarA
        {
            set { labelA.Text = value; }
            get { return labelA.Text; }
        }

        public string PercentPrBarB
        {
            set { labelB.Text = value; }
            get { return labelB.Text; }
        }
        public string PercentPrBarC
        {
            set { labelC.Text = value; }
            get { return labelC.Text; }
        }
        public string PercentPrBarD
        {
            set { labelD.Text = value; }
            get { return labelD.Text; }
        }
        private void buttonHelpPeople_Click(object sender, EventArgs e) // помощь зала
        {
            if (EvHelpPeople != null)
                EvHelpPeople(this, EventArgs.Empty);
            buttonHelpPeople.BackgroundImage = WForms2___Millionaire_.Properties.Resources._6;
            groupBoxHelpPeople.Visible = true;
            buttonHelpPeople.Enabled = false;
            SoundPlayer player = new SoundPlayer("../../zal.wav");
            player.Play();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void начатьИгруToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            num = 14;
            if (EvStartGame != null)
                EvStartGame(this, EventArgs.Empty);
            labelQuestion.Enabled = true;
            labelQuestion.Visible = true;
            labelAnswerPresenter.Visible = false;
            администраторскийРежимToolStripMenuItem.Enabled = false;
            оПрограммеToolStripMenuItem.Enabled = false; 
            labelGameOver.Text = null;
            labelGameOver.Visible = false;
            listBox1WinSum.SetSelected(num, true);
            buttonStop.Enabled = false;

            SoundPlayer player = new SoundPlayer("../../begin.wav");
            player.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (EvStopGame != null)
                EvStopGame(this, EventArgs.Empty);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"game.txt"); 
        }


    }
}
