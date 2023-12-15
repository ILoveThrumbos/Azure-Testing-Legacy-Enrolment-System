using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace EnrolmentAdminService
{
    [DataContract]
    public class Enrolment1
    {
        [DataMember]
        public int StudentID;

        [DataMember]
        public int CourseID;

        [DataMember]
        public string Grade;
    }
}