using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class Answer
    {   
            public int AnswerId { get; set; }
            public string AnswerText { get; set; }

            public Answer(int _answerID, string _answerText)
            {
                AnswerId   = _answerID;
                AnswerText = _answerText;
            }

            public override string ToString()
            {
                return $"AnswerID : {AnswerId} , AnswerText : {AnswerText}";
            }



        
    }

}
