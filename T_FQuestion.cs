using System;
using System.Collections.Generic;
using System.Text;

namespace ieeetask2
{
    internal class T_FQuestion : BaseQuestion
    {
        public T_FQuestion(string header, string body, int mark,Answer[] answers, Answer rightAnswer): base(header, body, mark, answers, rightAnswer)
        {

        }
    }
}
