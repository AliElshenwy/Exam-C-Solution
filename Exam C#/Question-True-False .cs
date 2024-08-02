using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class Question_True_False :Question
    {


        public Question_True_False(string _header, string _body, int  mark, Answer _correctAnswer)
            : base(_header, _body, mark)
        {
            AnswerList = new Answer[]
            {
                new Answer(1,"True"),
                new Answer(2,"False")
            };
        }

        public override void ShowQuestion()
        {
            //Display true/false question format
            Console.WriteLine($"(True/False)    Mark {Mark} Header: {Header} Body: {Body}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}{answer.AnswerText}");
            }
        }
    }
}
    

