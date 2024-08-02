using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class Question_MCQ :Question
    {
            public Question_MCQ(string _header, string _body, int  mark, Answer[] _answers, Answer _correctAnswer)
                : base(_header, _body, mark)
            {
                CorrectAnswerID = _correctAnswer;
                AnswerList = _answers;
            }

            public override void ShowQuestion()
            {
                
                Console.WriteLine($" (Question_MCQ) : Mark {Mark}Header: {Header} Body: {Body}");
                foreach (var answer in AnswerList)
                {
                    Console.WriteLine($"{answer.AnswerId} , {answer.AnswerText}");
                }
            }
        
    }
}
