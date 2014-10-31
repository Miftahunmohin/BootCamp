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
    class ResultGateWay
    {

        private SqlConnection connection;
        string  TABLE_NAME;
        string TABLE_NAME1 ;
        public ResultGateWay()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];

            string connectionString = "";
            TABLE_NAME = "t_Student";
            TABLE_NAME1 = "t_Course";

            if (settings != null)
                connectionString = settings.ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }

        public bool HasThisRegNoValid(string studentRegNo)
        {

            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE Student_RegNo='{0}' ", studentRegNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();




            if (aReader.HasRows)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

  
        public bool SaveForResultUi(Result aResult, Student aStudent)
        {

            connection.Open();

            string query = string.Format("INSERT INTO t_Result VALUES('{0}','{1}')", aStudent.StudentRegNo
                , aStudent.ScorePersent);

            SqlCommand command = new SqlCommand(query, connection);
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();




            if (affectedRows > 0)
                return true;
            return false;

        }

        public List<double> GetAllScore(Student aStudent)
        {
            connection.Open();
            string query = string.Format("SELECT Score FROM t_Result WHERE Student_RegNo='{0}' ", aStudent.StudentRegNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            List<double> allResult = new List<double>();



            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    allResult.Add(Convert.ToDouble(aReader.GetValue(0)));
                }

                connection.Close();
                return allResult;
            }
            connection.Close();
            return allResult;
        }
    }
}
