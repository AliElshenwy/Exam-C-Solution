

namespace Exam_C_
{
    abstract class Question (string header, string body, int mark)
    {

        public string Header { get; set; } = header;
        public string Body { get; set; } = body;
        public int Mark { get; set; } = mark;
        public Answer[] AnswerList { get; set; }
        public Answer CorrectAnswerID { get; set; }  
        public static int Count { get; internal set; }
         
        public abstract void ShowQuestion();  

        public override string ToString()
        {
            return $"Header : {Header} , Body : {Body} , Mark : {Mark}";
        }



        public bool CheckAnswer(Answer selectAnswerId)
        {
            return selectAnswerId == CorrectAnswerID;
        }

    };
}








