using System;
using System.Collections.Generic;
using System.Text;

namespace ieeetask2
{
    internal class subject
    {
        public int subjectID { get; set; }
        public string subjectName { get; set; }
        public Base_Exam Exam {  get; set; }
        public subject(int subjectID, string subjectName, Base_Exam exam)
        {
            this.subjectID = subjectID;
            this.subjectName = subjectName;
            Exam = exam;
        }
        public void CreateExam(int choice , BaseQuestion[] questions)
        {
            if (choice == 1)
            {
                Exam = new Final_Exam(60 , questions.Length , questions);
            }else if (choice == 2)
            {
                Exam = new Practical_Exam(60 , questions.Length , questions);
            }
            else
            {
                Console.WriteLine("invailed");
            }
        }
    }

}
