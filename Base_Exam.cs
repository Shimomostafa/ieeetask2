using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ieeetask2
{
    internal abstract class Base_Exam
    {
        public int Time_of_exam;
        public int NumOfQuestions;
        public BaseQuestion[] Questions {  get; set; }
        public Answer[] StdAnswers { get; set; }
        public DateTime ExamDate { get; set; }
        public Base_Exam(int time, int numberOfQuestions, BaseQuestion[] questions)
        {
            Time_of_exam = time;
            NumOfQuestions = numberOfQuestions;
            Questions = questions;
            ExamDate = DateTime.Now;
            StdAnswers = new Answer[numberOfQuestions];
        }
        public void ShowExamDate()
        {
            Console.WriteLine($"Exam Date: {ExamDate}");
            Console.WriteLine($"you have {Time_of_exam}S");
        }
        public abstract void ShowExam();
        public void TakeAnswers()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].ShowQuestion();
                
                bool isValid = false;
                while (!isValid)
                {
                    Console.Write("Enter Answer ID : ");
                    int answerId = int.Parse(Console.ReadLine());
                    foreach (Answer ans in Questions[i].Answers)
                    {
                        if (ans.AnswerID == answerId)
                        {
                            StdAnswers[i] = ans;
                            isValid = true;
                            break;
                        }
                    }
                    if (!isValid)
                    {
                        Console.WriteLine("Invalid Answer ID! Try Again.");
                    }
                }
                
            }
        }
    }
}
