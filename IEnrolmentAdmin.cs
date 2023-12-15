using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace EnrolmentAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnrolmentAdmin" in both code and config file together.
    [ServiceContract]
    public interface IEnrolmentAdmin
    {
        [OperationContract]
        void EnrolStudent(int studentID, int courseID);

        [OperationContract]
        Enrolment1 GetEnrolmentByCourseID(int courseID);

        [OperationContract]
        List<Enrolment1> GetEnrolments();
    }
}
