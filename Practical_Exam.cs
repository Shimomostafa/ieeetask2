using System;
using System.Collections.Generic;
using System.Text;

namespace ieeetask2
{
    internal class Practical_Exam : Base_Exam
    {
        public Practical_Exam(int time, int numberOfQuestions, BaseQuestion[] questions) : base(time, numberOfQuestions, questions)
        {

        }
        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            ShowExamDate();
            TakeAnswers();
            Console.WriteLine("Correct Answers:");
            foreach (BaseQuestion question in Questions)
            {
                Console.WriteLine($"{question.Header} : {question.RightAnswer.AnswerText}");
            }
        }
    }
}
