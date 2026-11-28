namespace ieeetask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select the type of exam ");
            Console.WriteLine("1 - final exam");
            Console.WriteLine("2 - practical exam");
            int choice;
            do
            {
                Console.Write("Enter 1 or 2: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (!isNumber || (choice != 1 && choice != 2))
                {
                    Console.WriteLine("Invalid choice! Try Again.");
                }
            } while (choice != 1 && choice != 2);

            int numberOfQuestions = 0;
            do
            {
                Console.Write("Enter number of Questions: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out numberOfQuestions);

                if (!isNumber || numberOfQuestions <= 0)
                {
                    Console.WriteLine("Please enter a valid positive number!");
                    numberOfQuestions = 0;
                }
            } while (numberOfQuestions <= 0);

            int examTime = 0;
            do
            {
                Console.Write("Enter Exam Time (45 - 180 Minutes): ");
                bool isNumber = int.TryParse(Console.ReadLine(), out examTime);

                if (!isNumber || examTime < 45 || examTime > 120)
                {
                    Console.WriteLine("Please enter a time between 30 and 180 minutes!");
                    examTime = 0;
                }

            } while (examTime < 45 || examTime > 120);

            BaseQuestion[] questions = new BaseQuestion[numberOfQuestions];
            for (int i = 0; i < questions.Length; i++)
            {
                int TypeOfQuestion = 1;

                if (choice == 1)
                {
                    do
                    {
                        Console.WriteLine("Select the type of Question :");
                        Console.WriteLine("1 : MCQ");
                        Console.WriteLine("2 : True / False");

                        bool isNumber = int.TryParse(Console.ReadLine(), out TypeOfQuestion);

                        if (!isNumber || (TypeOfQuestion != 1 && TypeOfQuestion != 2))
                        {
                            Console.WriteLine("Invalid question type! Try Again.");
                            TypeOfQuestion = 0;
                        }
                    }while (TypeOfQuestion != 1 && TypeOfQuestion != 2);    
                }

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();
                int mark = 0;
                do
                {
                    Console.Write("Enter Question Mark: ");
                    bool isNumber = int.TryParse(Console.ReadLine(), out mark);
                    if (!isNumber || mark <= 0)
                    {
                        Console.WriteLine("Please enter a valid positive mark!");
                        mark = 0;
                    }

                } while (mark <= 0);

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
                    int rightAnswerId = 0;
                    do
                    {
                        Console.Write("Enter Right Answer ID (1-4): ");
                        bool isNumber = int.TryParse(Console.ReadLine(), out rightAnswerId);

                        if (!isNumber || rightAnswerId < 1 || rightAnswerId > 4)
                        {
                            Console.WriteLine("Invalid Answer ID! Enter a number from 1 to 4.");
                            rightAnswerId = 0;
                        }

                    } while (rightAnswerId < 1 || rightAnswerId > 4);

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
                    int rightAnswerId = 0;
                    do
                    {
                        Console.Write("Enter Right Answer ID (1-2): ");
                        bool isNumber = int.TryParse(Console.ReadLine(), out rightAnswerId);

                        if (!isNumber || rightAnswerId < 1 || rightAnswerId > 2)
                        {
                            Console.WriteLine("Invalid Answer ID! Enter 1 or 2.");
                            rightAnswerId = 0;
                        }

                    } while (rightAnswerId < 1 || rightAnswerId > 2);

                    Answer rightAnswer = answers[rightAnswerId - 1];

                    questions[i] = new T_FQuestion(header, body, mark, answers, rightAnswer);

                }
            }
            subject Csharp = new subject(1, "C#", null);
            Csharp.CreateExam(choice, questions , examTime);
            Console.Clear();
            Csharp.Exam.ShowExam();
        }
    }
}
