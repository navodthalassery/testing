using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace XamApps.Models
{
    public class Questions
    {
        public Questions()
        {
        }

        public int QId { get; set; }
        public string Qkey { get; set; }
        public string Qdesc { get; set; }
        //public int QType { get { return Convert.ToInt16(QTypes.val); } }
        public int QType { get; set; }
        public ObservableCollection<Answers> AnswerList { get; set; }
    }

    enum QTypes
    {
        val=1,
    }

    public class QuestionList1
    {
        public List<Questions> QuestionList { get; set; }
    }
}
