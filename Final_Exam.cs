using System;
using System.Collections.Generic;
using System.Text;

namespace ieeetask2
{
    internal class Final_Exam : Base_Exam
    {
        public Final_Exam(int time, int numberOfQuestions, BaseQuestion[] questions): base(time, numberOfQuestions,questions)
        {

        }
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            ShowExamDate();
            TakeAnswers();
                int grade = 0;
                for (int i = 0; i < Questions.Length; i++)
                {
                    if (StdAnswers[i].AnswerID == Questions[i].RightAnswer.AnswerID)
                    {
                        grade += Questions[i].Mark;
                    }
                }
                Console.WriteLine($"your grade : {grade}");
            }
        }
    }
