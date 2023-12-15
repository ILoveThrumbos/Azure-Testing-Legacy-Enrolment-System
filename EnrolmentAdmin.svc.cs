using EnrolmentAdminService.EnrolmentDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace EnrolmentAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnrolmentAdmin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EnrolmentAdmin.svc or EnrolmentAdmin.svc.cs at the Solution Explorer and start debugging.
    public class Enrolment : IEnrolmentAdmin
    {
        private EnrolmentDataTableAdapters.EnrolmentTableAdapter enrolmentTA = new EnrolmentDataTableAdapters.EnrolmentTableAdapter();

        public List<Enrolment1> GetEnrolments()
        {

            EnrolmentData.EnrolmentDataTable table = enrolmentTA.GetData();
            List<Enrolment1> enrolmentList = new List<Enrolment1>();
            // string test = "";
            foreach (DataRow row in table)
            {
                Enrolment1 enrolment = new Enrolment1();
                enrolment.Grade = row["Grade"].ToString();
                enrolment.StudentID = (int)row["StudentID"];
                enrolment.CourseID = (int)row["CourseID"];
                enrolmentList.Add(enrolment);
            }
            return enrolmentList;
        }


        public void EnrolStudent(int studentID, int courseID)
        {
            enrolmentTA.EnrolStudent(studentID, courseID);  
                
        }

        public Enrolment1 GetEnrolmentByCourseID(int courseID)
        {
            EnrolmentData.EnrolmentDataTable table = enrolmentTA.GetEnrolmentByCourseID(courseID);
            Enrolment1 enrolment = new Enrolment1();

            enrolment.Grade = table.Rows[0]["Grade"].ToString();
            enrolment.StudentID = (int)table.Rows[0]["StudentID"];
            enrolment.CourseID = (int)table.Rows[0]["CourseID"];

            return enrolment;



        }

    }


}

