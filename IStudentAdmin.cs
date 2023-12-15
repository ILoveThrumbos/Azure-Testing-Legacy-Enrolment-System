using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace EnrolmentAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentAdmin" in both code and config file together.
    [ServiceContract]
    public interface IStudentAdmin
    {
        [OperationContract]
        void NewStudent(int StudentID, string studentName, DateTime DateEnrolled);

        [OperationContract]
        List<Student> ViewStudent();

        [OperationContract]
        List<TimetableEntry> StudentTimetable();
    }
}
