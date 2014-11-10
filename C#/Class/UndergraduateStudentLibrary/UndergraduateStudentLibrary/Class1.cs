using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace UndergraduateStudentLibrary
{
    public class UndergraduateStudent : Student
    {
        public String classification { get; set; }
        public String guardianLastName { get; set; }
        public String guardianFirstName { get; set; }
        public String guardianAddress { get; set; }
        public String guardianPhone { get; set; }

        public override String ToString()
        {
            String undergradInfo = "Classification:  " + classification + "\r\nGuardian Last Name:  " + guardianLastName + "\r\nGuardian First Name:  "
                + guardianFirstName + "\r\nGuardian Address:  " + guardianAddress + "\r\nGuardian Phone Number:  " + guardianPhone;
            return undergradInfo;
        }
    }
}
