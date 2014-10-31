using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentResultInfoApp.DAL.GATEWAY;

namespace StudentResultInfoApp.DAL.DAO
{
    public class Result
    {
        public  double Score { set; get; }

        private ResultGateWay aResultGateWay;

        public double CalculateAvg(Student aStudent)
        {
            aResultGateWay = new ResultGateWay();
            List<double> allResult = new List<double>();

            
            allResult = aResultGateWay.GetAllScore(aStudent);

            double total = 0;

            foreach (double d in allResult)
            {
            total += d;
            }


            double avgResult = total/allResult.Count;


            return avgResult;
        }

        public string CalculateGrade(double score)
        {
            if (score >= 90)
                return "A";
            else if(score >= 70 && score < 90)
            {
                return "B";
            }
            else if (score >= 50 && score < 70)
            {
                return "C";
            }
            else
            {
                return "F";
            }
        }
    }
}
