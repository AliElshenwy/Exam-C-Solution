using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class Practical_Exam :Exam
    {
        public Practical_Exam(int _timeOfExam, List<Question> _question) : base(_timeOfExam, _question)
        {
        }

        public Practical_Exam(DateTime examTime, int _timeOfExam, List<Question> _question):base(_timeOfExam, _question)
        {

        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical-Exam:");
            double totalGradeCorrect = 0;
            double totalGrade = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var question in Questions)
            {
                int answerId;
                do
                {
                    question.ShowQuestion();
                    Console.WriteLine("Your Answer : ");
                } while (!int.TryParse(Console.ReadLine(), out answerId));

                
                if (question.AnswerList[answerId - 1].Equals(question.CorrectAnswerID))
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine($" Rong  Correct answer : {question.CorrectAnswerID}");
            }
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.Elapsed.Hours}:{stopwatch.Elapsed.Minutes}:{stopwatch.Elapsed.TotalSeconds}");

            Console.WriteLine($"Your Grade is {totalGradeCorrect} from {totalGrade}");
        }
    }
}
    

