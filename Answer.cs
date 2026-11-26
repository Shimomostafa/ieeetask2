using System;
using System.Collections.Generic;
using System.Text;

namespace ieeetask2
{
    internal class Answer
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
        public Answer( int answerid , string answertext)
        {
            AnswerID = answerid;
            AnswerText = answertext;
        }
        public override string ToString()
        {
            return ($"{AnswerID}:{AnswerText}");
        }
    }
}
