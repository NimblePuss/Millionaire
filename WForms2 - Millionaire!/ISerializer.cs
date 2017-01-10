using System.Collections.Generic;

namespace WForms2___Millionaire_
{
    public interface ISerializer
    {
        void Save(ICollection<Questions> collection);
        ICollection<Questions> Load();
    }
}
