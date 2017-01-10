using System;
using System.Collections.Generic;

namespace WForms2___Millionaire_
{
    [Serializable]
    public class ListQuestions
    {
        List<Questions> list;

        ISerializer serialize;
        Random rnd = new Random();


        public ListQuestions()
        {
            list = new List<Questions>();
        }

        public int Index { set; get; }
        public int Count 
        {
            get {return list.Count; } 
        }
        public void SetSerializer(ISerializer serialize)
        {
            this.serialize = serialize;
            
        }

        public string PrintQues
        {
            get { return list[Index].Question;}
        }

        public string PrintAnswer1
        {
            get { return list[Index].Answer1; }
        }

        public string TrueAnswer { set; get; }
        public string PrintAnswer2
        {
            get { return list[Index].Answer2; }
        }

        public string PrintAnswer3
        {
            get { return list[Index].Answer3; }
        }

        public string PrintAnswer4
        {
            get { return list[Index].Answer4; }
        }

        public void Add(Questions q)
        {
            list.Add(q);     
        }

        public void Remove(int index)
        {
            list.RemoveAt(index);
        }

        public void Edit(int index, Questions q)
        {
            list.Insert(index, q);
        }

        public List<Questions> RandQuestion()
        {
            List<Questions> CopyList = new List<Questions>();
            Questions temp = new Questions();
            for (int i = 0; i < list.Count; i++)
            {
                CopyList.Add(list[i]);
            }
           
            int n = CopyList.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                temp = CopyList[k];
                CopyList[k] = CopyList[n];
                CopyList[n] = temp;
                
            }
            return CopyList;
        }

        public List<string> RandAnswer(Questions q)
        {
            List<string> str = new List<string>();
            
            str.Add(q.Answer1);
            str.Add(q.Answer2);
            str.Add(q.Answer3);
            str.Add(q.Answer4);

            int n = str.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                string temp = str[k];
                str[k] = str[n];
                str[n] = temp;
            }
            return str;
        }

        public void Save()
        {
            serialize.Save(list);
        }

        public void LoadList()
        {
            list = serialize.Load() as List<Questions>;
        }
    }
}
