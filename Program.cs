namespace ieeetask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select the type of exam ");
            Console.WriteLine("1 - final exam");
            Console.WriteLine("2 - practical exam");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter number of Questions : ");
            int numberOfQuestions = int.Parse(Console.ReadLine());
            BaseQuestion[] questions = new BaseQuestion[numberOfQuestions];
            for (int i = 0; i < questions.Length; i++)
            {
                int TypeOfQuestion = 1;

                if (choice == 1)
                {
                    Console.WriteLine("Select the type of Question :");
                    Console.WriteLine("1 : MCQ");
                    Console.WriteLine("2 : True / False");
                    TypeOfQuestion = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());
                if (TypeOfQuestion == 1)
                {
                    int numberOfAnswers = 4;
                    Answer[] answers = new Answer[numberOfAnswers];
                    for (int j = 0; j < numberOfAnswers; j++)
                    {
                        Console.Write($"Enter Answer {j + 1}: ");
                        string answerText = Console.ReadLine();
                        answers[j] = new Answer(j + 1, answerText);
                    }
                    Console.Write("Enter Right Answer ID (1=>4): ");
                    int rightAnswerId = int.Parse(Console.ReadLine());
                    Answer rightAnswer = answers[rightAnswerId - 1];
                    questions[i] = new MCQ_Question(header,body,mark,answers,rightAnswer);
                }
                else if (TypeOfQuestion == 2)
                {
                    Answer[] answers =
                    {
                        new Answer(1,"True"),
                        new Answer(2,"False")
                    };
                    Console.Write("Enter Right Answer ID (1-2): ");
                    int rightAnswerId = int.Parse(Console.ReadLine());
                    Answer rightAnswer = answers[rightAnswerId - 1];
                    questions[i] = new T_FQuestion(header, body, mark, answers, rightAnswer);

                }
                else
                {
                    Console.WriteLine("invailed type");
                    i--;
                }
            }
            subject Csharp = new subject(1, "C#", null);
            Csharp.CreateExam(choice, questions);
            Console.Clear();
            Csharp.Exam.ShowExam();
        }
    }
}
