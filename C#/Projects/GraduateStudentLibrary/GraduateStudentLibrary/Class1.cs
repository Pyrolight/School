using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace GraduateStudentLibrary 
{
    public class GraduateStudent: Student
    {
        public String degree { get; set; }
        public String collegeName { get; set; }
        public String collegeAddress { get; set; }

        public override String ToString()
        {
            String gradStudentInfo = "Degree Awarded:  " + degree + "\r\nCollege  " + collegeName + "\r\nAddress:  "
                + collegeAddress;
            return gradStudentInfo;
        }
    }
}
