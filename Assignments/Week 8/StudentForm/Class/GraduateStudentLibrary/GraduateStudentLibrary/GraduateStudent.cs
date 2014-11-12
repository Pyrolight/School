using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace GraduateStudentLibrary
{
    /*
    Class Name: GraduateStudent
    Author: Michael Fesser
    Version: #1.0
    Description: This class holds the specific information related to a graduate student.  It also builds the output string for the student.
    Dependencies: None.
    Change History: None.
    */
    public class GraduateStudent : Student
    {
        public String degree { get; set; }
        public String collegeName { get; set; }
        public String collegeAddress { get; set; }

        public GraduateStudent()
            : base()
        {
        }

        // This constructor passes the general student information to the base class and populates the graduate student fields
        public GraduateStudent(string id, string lastName, string firstName, string address, string phoneNumber, string degree, string collegeName, string collegeAddress)
            : base(id, lastName, firstName, address, phoneNumber)
        {
            this.degree = degree;
            this.collegeName = collegeName;
            this.collegeAddress = collegeAddress;
        }

        /*
        Method name: ToString
        Version: #1.0
        Author: Michael Fesser
        Description: This overridden ToString() method is used to build the string that is used to display the student information.  
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public override String ToString()
        {
            // Get the general student information from the base class ToString() and add build a string with it and the graduate student information
            String gradStudentInfo = "Student Information\r\n\r\n" + base.ToString() + "\r\n\r\n\r\nGraduate Information\r\n\r\nDegree Awarded:  " + degree + "\r\nCollege:  " + collegeName + "\r\nAddress:  "
                + collegeAddress;
            return gradStudentInfo;
        }
    }
}
