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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentAdmin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentAdmin.svc or StudentAdmin.svc.cs at the Solution Explorer and start debugging.
    public class StudentAdmin : IStudentAdmin
    {
        private EnrolmentDataTableAdapters.StudentTableAdapter studentTA = new EnrolmentDataTableAdapters.StudentTableAdapter();
        private EnrolmentDataTableAdapters.CourseTableAdapter courseTA = new EnrolmentDataTableAdapters.CourseTableAdapter();

        public void NewStudent(int StudentID, string studentName, DateTime DateEnrolled)
        {
            studentTA.Insert(StudentID, studentName, DateEnrolled);

            return;
        }

        public List<Student> ViewStudent()
        {
            EnrolmentData.StudentDataTable table = studentTA.GetData();
            List<Student> studentList = new List<Student>();
 
            foreach (DataRow row in table)
            {
                Student student = new Student();
                student.StudentID = (int)row["StudentID"];
                student.StudentName = row["StudentName"].ToString();
                student.DateEnrolled = (DateTime)row["DateEnrolled"];
                studentList.Add(student);
            }
            return studentList;
        }

        public List<TimetableEntry> StudentTimetable()
        {
            EnrolmentData.StudentDataTable studentTable = studentTA.GetData();
            EnrolmentData.CourseDataTable courseTable = courseTA.GetData();

            List<TimetableEntry> entries = new List<TimetableEntry>();

            foreach (EnrolmentData.StudentRow studentRow in studentTable.Rows)
            {
                foreach (EnrolmentData.CourseRow courseRow in courseTable.Rows)
                {
                    TimetableEntry entry = new TimetableEntry
                    {
                        StudentID = studentRow.StudentID,
                        StudentName = studentRow.StudentName,
                        CourseID = courseRow.CourseID,
                        CourseName = courseRow.CourseName
                    };

                    entries.Add(entry);
                }
            }

            return entries;
        }



    }



}


