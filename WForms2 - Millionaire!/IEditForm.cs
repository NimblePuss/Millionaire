using System;

namespace WForms2___Millionaire_
{
    public interface IEditForm
    {
        int EditNumQuestion { set; get; }

        string EditQuestion { set; get; }

        string EditAnswer1 { set; get; }

        string EditAnswer2 { set; get; }

        string EditAnswer3 { set; get; }

        string EditAnswer4 { set; get; }

        event EventHandler<EventArgs> EvNumEdQuestion;

        event EventHandler<EventArgs> EvEdQuestion;

        void LetEdQuestion();

        void DontLetEdQuestion();


    }
}
