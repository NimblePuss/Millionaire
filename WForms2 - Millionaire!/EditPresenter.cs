using System;

namespace WForms2___Millionaire_
{
    public class EditPresenter
    {
        ListQuestions _list = new ListQuestions();
        private readonly IEditForm _view;

        public EditPresenter(IEditForm view)
        {
            _view = view;
            _list.SetSerializer(new XMLSerializer());
            _list.LoadList();
            // выводим на форму первый вопрос и 4 варианта ответа
            _view.EditQuestion = _list.PrintQues;
            _view.EditAnswer1 = _list.PrintAnswer1;
            _view.EditAnswer2 = _list.PrintAnswer2;
            _view.EditAnswer3 = _list.PrintAnswer3;
            _view.EditAnswer4 = _list.PrintAnswer4;
            _view.EvNumEdQuestion += new EventHandler<EventArgs>(OnEdNumQues);
            _view.EvEdQuestion += new EventHandler<EventArgs>(OnEdQues);
        }

        private void OnEdNumQues(object sender, EventArgs e)
        {
            _list.Index = _view.EditNumQuestion - 1;
            if (_view.EditNumQuestion > 0 && _view.EditNumQuestion <= _list.Count)
            {
                _view.EditQuestion = _list.PrintQues;
                _view.EditAnswer1 = _list.PrintAnswer1;
                _view.EditAnswer2 = _list.PrintAnswer2;
                _view.EditAnswer3 = _list.PrintAnswer3;
                _view.EditAnswer4 = _list.PrintAnswer4;
            }
            else
                _view.EditNumQuestion = _list.Count;

        }

        private void OnEdQues(object sender, EventArgs e)
        {
            Questions _q = new Questions();
            _q.Question = _view.EditQuestion;
            _q.Answer1 = _view.EditAnswer1;
            _q.Answer2 = _view.EditAnswer2;
            _q.Answer3 = _view.EditAnswer3;
            _q.Answer4 = _view.EditAnswer4;

            if (_view.EditQuestion != "" && _view.EditAnswer1 != "" && _view.EditAnswer2 != "" &&
                _view.EditAnswer3 != "" && _view.EditAnswer4 != "")
            {
                _list.Remove(_list.Index);
                _list.Edit(_list.Index, _q);
                _list.Save();
                _view.LetEdQuestion();
            }
            else
                _view.DontLetEdQuestion();
        }
    }
}
