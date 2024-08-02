using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class Subject
    {
    
            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public Exam SubjectExam { get; set; }

            public void CreateExam(Exam exam)
            {
                SubjectExam = exam;
            }


            public override string ToString()
            {
                return $"SubjectId : {SubjectId} , SubjectName : {SubjectName}";
            }
        
    }
}
