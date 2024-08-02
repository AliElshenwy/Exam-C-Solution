using Exam_C_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class Final_Exam : Exam
    {
        public Final_Exam(DateTime examTime, int _timeOfExam, List<Question> _question)
            : base(_timeOfExam, _question)
        {
        }

        public Final_Exam(int _timeOfExam, List<Question> _question) : base(_timeOfExam, _question)
        {
        }

        
        public override void ShowExam()
        {
            Console.WriteLine("Final-Exam");
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
                    Console.Write("Your answer : ");
                } while (!int.TryParse(Console.ReadLine(), out answerId));

                
                if (question.AnswerList[answerId - 1].Equals(question.CorrectAnswerID))
                {
                    Console.WriteLine("Correct!");
                    totalGradeCorrect += question.Mark;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    totalGrade += question.Mark;
                }
            }
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            string formattedTime = $"{elapsedTime.Hours}:{elapsedTime.Minutes}:{elapsedTime.TotalSeconds}";
            Console.WriteLine($"Time : {formattedTime}");

            Console.WriteLine($"Your Grade is {totalGradeCorrect} from {totalGrade}");
            ShowAnswer();
        }

        public void ShowAnswer()
        {
            foreach (var item in Questions)
            {
                for (int i = 0; i <= Questions.Count; i++)
                {
                    Console.WriteLine($"Question {i + 1} : {item.Body}");
                }
            }
        }

    }

}





