using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace WForms2___Millionaire_
{
    public class PlayPresenter
    {
        ListQuestions _list = new ListQuestions();
        private readonly IPlayForm _view;
        Timer t;
        List<Questions> copyl;
        List<string> q;
        public int i;
        int count;
        public PlayPresenter(IPlayForm view)
        {
            _view = view;
            _list.SetSerializer(new XMLSerializer());
            _list.LoadList(); 
                 
            _view.EvStartGame += new EventHandler<EventArgs>(OnStartGame);
            _view.EvCheckButtonUp += new EventHandler<EventArgs>(OnCheckButtonUp);
            _view.Ev50to50 += new EventHandler<EventArgs>(On50to50);
            _view.EvCallFriend += new EventHandler<EventArgs>(OnCallFriend);
            _view.EvHelpPeople += new EventHandler<EventArgs>(OnHelpPeople);
            _view.EvStopGame += new EventHandler<EventArgs> (OnStopGame);
        }

        private void OnStartGame(object sender, EventArgs e)
        {
            copyl = new List<Questions>();
            q = new List<string>();
            t = new Timer();
            i = 0;
            count = 0;
            copyl = _list.RandQuestion();

            OnNextQuestion(sender, e);

            _view.ButtonA1Enabled = true;
            _view.ButtonA2Enabled = true;
            _view.ButtonA3Enabled = true;
            _view.ButtonA4Enabled = true;
            _view.SettingsButtons();

            _view.PercentPrBarA = null;
            _view.PercentPrBarB = null;
            _view.PercentPrBarC = "";
            _view.PercentPrBarD = "";     
        }
        private void OnNextQuestion(object sender, EventArgs e)
        {
            _list.TrueAnswer = copyl[i].Answer1;
            q = _list.RandAnswer(copyl[i]);

            _view.OutputQuestion = copyl[i].Question;
            _view.OutputAnswer1 = "A: ";
            _view.OutputAnswer1 += q[0];
            _view.OutputAnswer2 = "B: ";
            _view.OutputAnswer2 += q[1];
            _view.OutputAnswer3 = "C: ";
            _view.OutputAnswer3 += q[2];
            _view.OutputAnswer4 = "D: ";
            _view.OutputAnswer4 += q[3];
          
        }


        private void OnTimer(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += TimerStop;
            t.Start();           
        }

        private int sec = 0;
        private void TimerStop(object sender, EventArgs e)
        {

            sec++;
            if (sec == 2)
            {
                t.Stop();
                OnNextQuestion(sender, EventArgs.Empty);
                sec = 0;
            }
        }
        private void OnCheckButtonUp(object sender, EventArgs e)
        {
           
            if (_view.ButtonUp.Substring(3) == _list.TrueAnswer)
            {
                _view.SoundTrue();
                _view.AnswerPresenter = "Правильно!!!|\nВы выиграли ";
                string LB = _view.TextListBox;
                
                _view.AnswerPresenter += LB.Substring(4);
                _view.AnswerPresenter += " гривен!";
                _view.ButtonUpCheck.BackColor = Color.Green;
                OnTimer(sender, EventArgs.Empty);
                i++;
                _view.ButtonA1Enabled = true;
                _view.ButtonA2Enabled = true;
                _view.ButtonA3Enabled = true;
                _view.ButtonA4Enabled = true;
                if (count == 14)
                {
                    _view.YouWin();
                    t.Stop();
                    return;
                }
                count++;
            }
            else
            {
                _view.ChangeColorA1 = Color.Cyan;
                _view.ChangeColorA2 = Color.Cyan;
                _view.ChangeColorA3 = Color.Cyan;
                _view.ChangeColorA4 = Color.Cyan;
                _view.AnswerPresenter = "Вы проиграли!!!\nПравильный ответ: ";
                _view.AnswerPresenter += _list.TrueAnswer;
                _view.ButtonUpCheck.BackColor = Color.Red;
                _view.GameOver();
                t.Stop();
                return;
            }
        }

        private void OnStopGame(object sender, EventArgs e)
        {
            _view.AnswerPresenter = "Игра остановленна!\n Вы выиграли ";
            string LB = _view.TextListBox2;
            _view.AnswerPresenter += LB.Substring(4);
            _view.AnswerPresenter += " гривен!";
            _view.StopGame();
            t.Stop();
        }

        private void On50to50(object sender, EventArgs e)
        {
            if (_list.TrueAnswer == _view.OutputAnswer1.Substring(3))
            {
                _view.OutputAnswer2 = "";
                _view.OutputAnswer4 = "";
                _view.ButtonA2Enabled = false;
                _view.ButtonA4Enabled = false;
            }
            else if (_list.TrueAnswer == _view.OutputAnswer2.Substring(3))
            {
                _view.OutputAnswer1 = "";
                _view.OutputAnswer3 = "";
                _view.ButtonA1Enabled = false;
                _view.ButtonA3Enabled = false;
            }
            else if (_list.TrueAnswer == _view.OutputAnswer3.Substring(3))
            {
                _view.OutputAnswer1 = "";
                _view.OutputAnswer4 = "";
                _view.ButtonA1Enabled = false;
                _view.ButtonA4Enabled = false;
            }
            else if (_list.TrueAnswer == _view.OutputAnswer4.Substring(3))
            {
                _view.OutputAnswer2 = "";
                _view.OutputAnswer3 = "";
                _view.ButtonA2Enabled = false;
                _view.ButtonA3Enabled = false;
            }
            
        }

        private void OnCallFriend(object sender, EventArgs e)
        {
            _view.AnswerFriend += "Я думаю это ";
            _view.AnswerFriend += _list.TrueAnswer; //.Substring(3);
        }

        private void OnHelpPeople(object sender, EventArgs e)
        {
            if (_list.TrueAnswer == _view.OutputAnswer1.Substring(3))
            {
                _view.PrBarA.Value = 48;
                _view.PercentPrBarA = "A: 48 % ";
                _view.PrBarB.Value = 15;
                _view.PercentPrBarB = "B: 15 % ";
                _view.PrBarC.Value = 21;
                _view.PercentPrBarC = "C: 21 % ";
                _view.PrBarD.Value = 16;
                _view.PercentPrBarD = "D: 16 % ";
            }
            else if (_list.TrueAnswer == _view.OutputAnswer2.Substring(3))
            {
                _view.PrBarA.Value = 34;
                _view.PercentPrBarA = "A: 34 % ";
                _view.PrBarB.Value = 37;
                _view.PercentPrBarB = "B: 37 % ";
                _view.PrBarC.Value = 15;
                _view.PercentPrBarC = "C: 15 % ";
                _view.PrBarD.Value = 14;
                _view.PercentPrBarD = "D: 14 % ";
            }
            else if (_list.TrueAnswer == _view.OutputAnswer3.Substring(3))
            {
                _view.PrBarA.Value = 22;
                _view.PercentPrBarA = "A: 22 % ";
                _view.PrBarB.Value = 24;
                _view.PercentPrBarB = "B: 24 % ";
                _view.PrBarC.Value = 28;
                _view.PercentPrBarC = "C: 28 % ";
                _view.PrBarD.Value = 26;
                _view.PercentPrBarD = "D: 26 % ";
            }
            else if (_list.TrueAnswer == _view.OutputAnswer4.Substring(3))
            {
                _view.PrBarA.Value = 21;
                _view.PercentPrBarA = "A: 21 % ";
                _view.PrBarB.Value = 26;
                _view.PercentPrBarB = "B: 26 % ";
                _view.PrBarC.Value = 26;
                _view.PercentPrBarC = "C: 26 % ";
                _view.PrBarD.Value = 27;
                _view.PercentPrBarD = "D: 27 % ";
            }
        }
    }
}
