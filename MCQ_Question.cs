using System;
using System.Collections.Generic;
using System.Text;

namespace ieeetask2
{
    internal class MCQ_Question : BaseQuestion
    {
        public MCQ_Question(string header, string body, int mark,Answer[] answers, Answer rightAnswer): base(header, body, mark, answers, rightAnswer)
        {
        }
        
    }
}
