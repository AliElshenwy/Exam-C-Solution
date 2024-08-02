namespace Exam_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuestions, examType, examTime, questionType, correctAnswerId, numberOfChoices;
            double mark;
            char startExam;
            do
            {
                Console.WriteLine("please enter the type of the Exam (1- Final | 2- Practical):");
            } while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2));

            
            do
            {
                Console.WriteLine("Please enter the time for the Exam from (20 min to 150 min)");
            } while (!int.TryParse(Console.ReadLine(), out examTime) || examTime < 30 || examTime > 180);

            List<Question> questions = new List<Question>();

            do
            {
                Console.Write("Enter the number of qestions: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions));

            Console.Clear();    

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"Enter Details for question {i + 1}");
                do   
                {
                    Console.WriteLine($"Question {i + 1} Type (1-True/False or 2-MCQ) answer by 1 or 2: ");
                } while (!int.TryParse(Console.ReadLine(), out questionType) || (questionType != 1 && questionType != 2));

                Console.Clear();

                if (questionType == 1)      
                {
                    Console.WriteLine("True | False Questions");

                    Console.WriteLine("Please Enter header or name of subject");
                    string? header = Console.ReadLine();

                    Console.WriteLine("Please Enter Question Body");
                    string? body = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("Please Enter Question Mark");
                    } while (!double.TryParse(Console.ReadLine(), out mark));

                    do
                    {
                        Console.Write("Please Enter the Correct Answer ID (1- True | 2- False)");
                    } while (!int.TryParse(Console.ReadLine(), out correctAnswerId) || (correctAnswerId != 1 && correctAnswerId != 2));

                    Answer correctAnswer = correctAnswerId == 1 ? new Answer(1, "True") : new Answer(2, "False");

                    questions.Add(new Question_True_False(header, body,(int ) mark, correctAnswer));

                }
                else if (questionType == 2)
                {
                    Console.WriteLine("MCQ Question");

                    Console.WriteLine("Please Enter header or name of subject");
                    string? header = Console.ReadLine();

                    Console.WriteLine("Please Enter Question Body");
                    string? body = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("Please Enter the Mark of question");
                    } while (!double.TryParse(Console.ReadLine(), out mark));

                    do
                    {
                        Console.WriteLine("Please Enter the number of choices");
                    } while (!int.TryParse(Console.ReadLine(), out numberOfChoices));

                    Answer[] answers = new Answer[numberOfChoices]; 

                    Console.WriteLine("Choices of Question");

                    for (int j = 0; j < numberOfChoices; j++)
                    {
                        Console.WriteLine($"Please Enter the answer of Choice Number {j + 1}");
                        string? choiceText = Console.ReadLine();
                        answers[j] = new Answer(j + 1, choiceText);
                    }

                    do
                    {
                        Console.WriteLine("Please Enter the Correct answer ID");
                    } while (!int.TryParse(Console.ReadLine(), out correctAnswerId) || !(correctAnswerId <= numberOfChoices));
                    Answer correctAnswer = answers[correctAnswerId - 1];

                    questions.Add(new Question_MCQ(header, body, (int)mark, answers, correctAnswer));
                }
            }

            Exam exam = examType == 1 ? new Final_Exam(examTime, questions) : new Practical_Exam(examTime, questions);


            Console.Clear();

            do
            {
                Console.WriteLine("DO you want to start Exam (Y/N)");
            } while (!char.TryParse(Console.ReadLine(), out startExam) || (char.ToUpper(startExam) != 'Y' && char.ToUpper(startExam) != 'N'));

            if (char.ToUpper(startExam) == 'Y')
            {
                Console.Clear();
                Subject subject = new Subject();
                Console.WriteLine($"Your Exam Details ({exam})");
                subject.CreateExam(exam);
               
            }
            else if (char.ToUpper(startExam) == 'N')
                Console.WriteLine("The Exam has finished due to your answer to not start the Exam");
        }

    }
    
}
