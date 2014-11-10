using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        public String studentId { get; set; }
        public String lastName { get; set; }
        public String firstName { get; set; }
        public String address { get; set; }
        public String phoneNumber { get; set; }

        public override String ToString()
        {
            String studentInfo = "Student Id:  " + studentId + "\r\nLast Name:  " + lastName + "\r\nFirst Name:  "
                + firstName + "\r\nAddress:  " + address + "\r\nPhone Number:  " + phoneNumber;
            return studentInfo;
        }
    }
}
