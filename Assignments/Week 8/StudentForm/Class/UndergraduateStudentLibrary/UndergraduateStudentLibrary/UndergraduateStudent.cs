using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace UndergraduateStudentLibrary
{
   /*
   Class Name: UndergraduateStudent
   Author: Michael Fesser
   Version: #1.0
   Description: This class holds the specific information related to a undergraduate student.  It also builds the output string for the student.
   Dependencies: None.
   Change History: None.
   */
    public class UndergraduateStudent : Student
    {
        public String classification { get; set; }
        public String guardianLastName { get; set; }
        public String guardianFirstName { get; set; }
        public String guardianAddress { get; set; }
        public String guardianPhone { get; set; }

        public UndergraduateStudent()
            : base()
        {
        }

        // This constructor passes the general student information to the base class and populates the graduate student fields
        public UndergraduateStudent(string id, string lastName, string firstName, string address, string phoneNumber, string classification, string guardianLastName,
            string guardianFirstName, string guardianAddress, string guardianPhone)
            : base(id, lastName, firstName, address, phoneNumber)
        {
            this.classification = classification;
            this.guardianLastName = guardianLastName;
            this.guardianFirstName = guardianFirstName;
            this.guardianAddress = guardianAddress;
            this.guardianPhone = guardianPhone;
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
            // Get the general student information from the base class ToString() and add build a string with it and the undergraduate student information
            String undergraduateInfo = "Student Information\r\n\r\n" + base.ToString() + "\r\n\r\n\r\nUndergraduate Information\r\n\r\nClassification:  " 
                + classification + "\r\nGuardian Last Name:  " + guardianLastName + "\r\nGuardian First Name:  " + guardianFirstName + "\r\nGuardian Address:  " 
                + guardianAddress + "\r\nGuardian Phone Number:  " + guardianPhone;
            return undergraduateInfo;
        }
    }
}
