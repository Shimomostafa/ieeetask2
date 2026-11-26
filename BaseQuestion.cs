using System;
using System.Collections.Generic;
using System.Text;

namespace ieeetask2
{
    internal class BaseQuestion : ICloneable , IComparable
    {
        public string Header;
        public string Body;
        public int Mark;
        public Answer[] Answers;
        public Answer RightAnswer;
        public BaseQuestion(string header, string body, int mark,
                Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(object obj)
        {
            BaseQuestion other = (BaseQuestion)obj;
            return this.Mark.CompareTo(other.Mark);
        }
        public virtual void ShowQuestion()
        {
            Console.WriteLine($"{Header}");
            Console.WriteLine($"{Body}");
            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
        public override string ToString()
        {
            return $"{Header}: {Body} ({Mark} Marks)";
        }
    }
}
