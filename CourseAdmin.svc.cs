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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CourseAdmin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CourseAdmin.svc or CourseAdmin.svc.cs at the Solution Explorer and start debugging.
    public class CourseAdmin : ICourseAdmin
    {
        private EnrolmentDataTableAdapters.CourseTableAdapter courseTA = new EnrolmentDataTableAdapters.CourseTableAdapter();

        public void NewCourse(int CourseID, string CourseName, decimal Cost)
        {

            courseTA.Insert(CourseID, CourseName, Cost);
        }

        public List<Course> ViewCourse()
        {

            EnrolmentData.CourseDataTable table = courseTA.GetData();
            List<Course> courseList = new List<Course>();

            foreach (DataRow row in table)
            {
                Course course = new Course();
                course.CourseID = (int)row["CourseID"];
                course.CourseName = row["CourseName"].ToString();
                course.Cost = (decimal)row["Cost"];
                courseList.Add(course);
            }
            return courseList;
        }

        public List<Course> DisplayBill()
        {
            EnrolmentData.CourseDataTable table = courseTA.GetData();
            List<Course> courseList = new List<Course>();

            foreach (DataRow row in table)
            {
                Course course = new Course();
                course.CourseID = (int)row["CourseID"];
                course.CourseName = row["CourseName"].ToString();
                course.Cost = (decimal)row["Cost"];
                courseList.Add(course);
            }
            return courseList;
        }

    }
}
