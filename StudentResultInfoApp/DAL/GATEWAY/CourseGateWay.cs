using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentResultInfoApp.DAL.DAO;

namespace StudentResultInfoApp.DAL.GATEWAY
{
    class CourseGateWay
    {
          private SqlConnection connection;

        private string TABLE_NAME;
        private string TABLE_NAME1;



        public CourseGateWay()
        {
            //string conn = @"server=OVI;database=AbcUniversity;integrated security =true";
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];

            string connectionString = "";
            TABLE_NAME = "t_Student";
            TABLE_NAME1 = "t_Course";

            if (settings != null)
                connectionString = settings.ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;


        }
        public List<Course> ShoInListViewFromDB(Student aStudent)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Course " +
                                         "WHERE Student_RegNo='{0}' ", aStudent.StudentRegNo);
            Course aCourse;
            
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Course> courses = new List<Course>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                   aCourse = new Course();
                    aCourse.CourseName = aReader.GetValue(1).ToString();
                    aCourse.EnrollDate = aReader.GetValue(3).ToString();
                    courses.Add(aCourse);
                }
                
            }
         



            connection.Close();


            return courses;

        }

        public List<Course> GetAllCourse()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_CourseName ");
            Course aCourse;

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Course> courses = new List<Course>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aCourse = new Course();
                    aCourse.CourseName = aReader[1].ToString();
                    courses.Add(aCourse);
                }

            }

            connection.Close();
            return courses;
        }
    }
}
