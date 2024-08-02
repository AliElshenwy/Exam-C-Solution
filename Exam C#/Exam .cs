using Exam_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    abstract class Exam
    {

        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public List< Question> Questions { get; set; }

        public Exam(int _timeOfExam, List<Question> _question)
        {
            TimeOfExam = _timeOfExam;
            Questions = _question;
            NumberOfQuestions = _question.Count;
        }
        public abstract void ShowExam();

        public override string ToString()
        {
            return $"Exam with {NumberOfQuestions} questions and a duration of exam is {TimeOfExam} .";
        }

    }
}



