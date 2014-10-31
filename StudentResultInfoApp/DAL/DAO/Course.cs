using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultInfoApp.DAL.DAO
{
    public class Course
    {
        public int CourseId { get; set; }
       
        public string CourseName { get; set; }
        public string EnrollDate { get; set; }

        public Course(string regNo, string name,string enrollDate)
        {
         
            CourseName = name;
            EnrollDate = enrollDate;
        }

        public Course()
        {
            // TODO: Complete member initialization
        }
    }
}
