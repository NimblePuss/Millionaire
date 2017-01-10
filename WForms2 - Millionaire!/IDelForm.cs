using System;

namespace WForms2___Millionaire_
{
    public interface IDelForm
    {
        int DelNumQuestion { set; get; }
        string DelQuestion { set; get; }

        event EventHandler<EventArgs> EvNumDelQuestion;
        
        event EventHandler<EventArgs> EvDelQuestion;

        void LetDelQuestion();
    }
}
