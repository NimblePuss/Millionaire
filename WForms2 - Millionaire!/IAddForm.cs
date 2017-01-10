using System;

namespace WForms2___Millionaire_
{
    public interface IAddForm
    {
        string AddQuestion { set; get; }
        string AddAnswer1 { set; get; }
        string AddAnswer2 { set; get; }
        string AddAnswer3 { set; get; }
        string AddAnswer4 { set; get; }

        event EventHandler<EventArgs> EvAddQues;
        void LetAddQuestion();
        void DontLetAddQuestion();
    }
}
