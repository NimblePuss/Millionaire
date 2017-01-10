using System;

namespace WForms2___Millionaire_
{
    public class DelPresenter
    {    
        ListQuestions _list = new ListQuestions();
        private readonly IDelForm _view;

        public DelPresenter(IDelForm view)
        {
            _view = view;
            _list.SetSerializer(new XMLSerializer());
            _list.LoadList();
            _view.DelQuestion = _list.PrintQues; // выводим сразу первый вопрос на форму
            _view.EvNumDelQuestion += new EventHandler<EventArgs>(OnEvNumDelQues);
            _view.EvDelQuestion += new EventHandler<EventArgs>(OnEvDelQues);
        }

        private void OnEvNumDelQues(object sender, EventArgs e)
        {
            _list.Index = _view.DelNumQuestion - 1;
            if (_view.DelNumQuestion > 0 && _view.DelNumQuestion <= _list.Count)
            {
                _view.DelQuestion = _list.PrintQues;
            }
            else
                _view.DelNumQuestion = _list.Count;

        }

        private void OnEvDelQues(object sender, EventArgs e)
        {       
            _list.Remove(_list.Index);
            _list.Save();
            _view.LetDelQuestion();
        }


    }
}
