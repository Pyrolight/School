using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    /*
    Class Name: Student
    Author: Michael Fesser
    Version: #1.0
    Description: This class holds the general information related to all students.  It also builds the output string for the student.
    Dependencies: None.
    Change History: None.
    */
    public class Student
    {
        public String studentId { get; set; }
        public String lastName { get; set; }
        public String firstName { get; set; }
        public String address { get; set; }
        public String phoneNumber { get; set; }


        public Student()
        {
        }

        // Accepts basic student information and sets the fields.
        public Student(string id, string lastName, string firstName, string address, string phoneNumber)
        {
            this.studentId = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        /*
        Method name: ToString
        Version: #1.0
        Author: Michael Fesser
        Description: This overridden ToString() method is used to build the basic student information string.  
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public override String ToString()
        {
            String studentInfo = "Student Id:  " + this.studentId + "\r\nLast Name:  " + this.lastName + "\r\nFirst Name:  "
                + this.firstName + "\r\nAddress:  " + this.address + "\r\nPhone Number:  " + this.phoneNumber;
            return studentInfo;
        }
    }
}
