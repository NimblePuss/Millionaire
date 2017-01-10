using System;

namespace WForms2___Millionaire_
{
    [Serializable]
    public class Questions
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }


          // для XML-сериализации необходим конструктор по умолчанию
        public Questions()
        {
            this.Question = "";
            this.Answer1 = "";
            this.Answer2 = "";
            this.Answer3 = "";
            this.Answer4 = "";
        }

        public Questions(string ques, string answ1, string answ2, string answ3, string answ4)
        {
            Question = ques;
            Answer1 = answ1;
            Answer2 = answ2;
            Answer3 = answ3;
            Answer4 = answ4;
        }

    }
}
