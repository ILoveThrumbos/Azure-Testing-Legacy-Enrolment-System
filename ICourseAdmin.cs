using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace EnrolmentAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICourseAdmin" in both code and config file together.
    [ServiceContract]
    public interface ICourseAdmin
    {
        [OperationContract]
        void NewCourse(int CourseID, string CourseName, decimal Cost);

        [OperationContract]
        List<Course> ViewCourse();

        [OperationContract]
        List<Course> DisplayBill();
    }
}
