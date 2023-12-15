using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EnrolmentAdminService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudentID;

        [DataMember]
        public string StudentName;

        [DataMember]
        public DateTime DateEnrolled;

    }
}