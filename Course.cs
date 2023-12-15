using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EnrolmentAdminService
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int CourseID;

        [DataMember]
        public string CourseName;

        [DataMember]
        public decimal Cost;
    }
}