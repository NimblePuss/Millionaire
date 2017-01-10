using System;

namespace WForms2___Millionaire_
{
    public class AddPresenter
    {
        private readonly Questions _ques = new Questions();
        //private readonly List<Questions> _list = new List<Questions>();
        private readonly IAddForm _view;


        // Принцип инверсии зависимостей
        public AddPresenter(IAddForm view)
        {
            _view = view;
            // Презентер подписывается на уведомления о событиях Представления
            _view.EvAddQues += new EventHandler<EventArgs>(OnEvAddQues);
            UpdateView();
        }

        private void OnEvAddQues(object sender, EventArgs e)
        {
            ListQuestions l = new ListQuestions();
            l.SetSerializer(new XMLSerializer());
            l.LoadList();
            // В ответ на изменения в Представлении необходимо изменить Модель
            _ques.Question = _view.AddQuestion;
            _ques.Answer1 = _view.AddAnswer1;
            _ques.Answer2 = _view.AddAnswer2;
            _ques.Answer3 = _view.AddAnswer3;
            _ques.Answer4 = _view.AddAnswer4;
            
            if (_view.AddQuestion != "" && _view.AddAnswer1 != "" && _view.AddAnswer2 != ""
                && _view.AddAnswer3 != "" && _view.AddAnswer4 != "")
            {
                
                l.Add(_ques);
                l.Save();
                _view.LetAddQuestion();
            }
            else
                _view.DontLetAddQuestion();

            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
            UpdateView();
        }

        private void UpdateView()
        {
            _view.AddQuestion = _ques.Question;
            _view.AddAnswer1 = _ques.Answer1;
            _view.AddAnswer2 = _ques.Answer2;
            _view.AddAnswer3 = _ques.Answer3;
            _view.AddAnswer4 = _ques.Answer4;
        }
    }
}
