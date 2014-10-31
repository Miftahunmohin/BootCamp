using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentResultInfoApp.DAL.DAO;
using StudentResultInfoApp.DAL.GATEWAY;

namespace StudentResultInfoApp.BLL
{
    class ResultBll
    {

        StudentGateway aStudentGateway = new StudentGateway();
        private ResultGateWay aResultGateWay;


        public string SaveFromResultUi(Result aResult, Student aStudent)
        {
           aResultGateWay = new ResultGateWay();
            if (!HasThisRegNoValid(aStudent.StudentRegNo))
            {
                return "RegNo not exist";
            }
            else
            {
                return aResultGateWay.SaveForResultUi(aResult,aStudent).ToString();

            }
        }
        private bool HasThisRegNoValid(string studentRegNo)
        {
            return aResultGateWay.HasThisRegNoValid(studentRegNo);
        }
        
    }
}
