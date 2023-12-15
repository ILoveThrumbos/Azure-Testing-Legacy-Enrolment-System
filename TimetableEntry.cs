using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EnrolmentAdminService
{
    [DataContract]
    public class TimetableEntry
    {
        [DataMember]
        public int StudentID;

        [DataMember]
        public string StudentName;

        [DataMember]
        public int CourseID;
        [DataMember]
        public string CourseName;
    }
}