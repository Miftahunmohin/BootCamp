using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentResultInfoApp.DAL.DAO;
using StudentResultInfoApp.DAL.GATEWAY;

namespace StudentResultInfoApp.BLL
{
    class CourseBLL
    {
        private CourseGateWay aCourseGateWay;


        public CourseBLL()
        {
            aCourseGateWay = new CourseGateWay();
        }

        public List<Course> ShoInListViewFromDB(Student aStudent)
        {
            List<Course> courses  =new List<Course>();


            courses = aCourseGateWay.ShoInListViewFromDB(aStudent);
            return courses;
        }

       
    }
}
