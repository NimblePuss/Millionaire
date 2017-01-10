using System;
using System.Windows.Forms;
using System.Drawing;




namespace WForms2___Millionaire_
{
    public interface IPlayForm
    {
        string OutputQuestion { set; get; }
        string OutputAnswer1 { set; get; }
        string OutputAnswer2 { set; get; }
        string OutputAnswer3 { set; get; }
        string OutputAnswer4 { set; get; }

        string ButtonUp { set; get; }
        string AnswerPresenter { set; get; }

        string AnswerFriend { set; get; }

        string TextListBox { get; }
        string TextListBox2 { get; }
        Button ButtonUpCheck { set; get; }

        ProgressBar PrBarA { set; get; }
        ProgressBar PrBarB { set; get; }
        ProgressBar PrBarC { set; get; }
        ProgressBar PrBarD { set; get; }
        string PercentPrBarA { set; get; }
        string PercentPrBarB { set; get; }
        string PercentPrBarC { set; get; }
        string PercentPrBarD { set; get; }
        void SettingsButtons();

        Color ChangeColorA1 { set; get; }
        Color ChangeColorA2 { set; get; }
        Color ChangeColorA3 { set; get; }    
        Color ChangeColorA4 { set; get; }

        bool ButtonA1Enabled { set; get; }
        bool ButtonA2Enabled { set; get; }
        bool ButtonA3Enabled { set; get; }
        bool ButtonA4Enabled { set; get; }

        event EventHandler<EventArgs> EvStartGame;

        event EventHandler<EventArgs> EvCheckButtonUp;

        event EventHandler<EventArgs> Ev50to50;

        event EventHandler<EventArgs> EvCallFriend;

        event EventHandler<EventArgs> EvHelpPeople;

        event EventHandler<EventArgs> EvStopGame;

        void GameOver();
        void YouWin();
        void SoundTrue();
        void StopGame();

    }
}
