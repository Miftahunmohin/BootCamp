using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultInfoApp.DAL.DAO
{
    public class Student
    {
        public string StudentRegNo { get; set; }
        public string  StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string  EnrollDate { get; set; }

        public double ScorePersent { get; set; }
        public Result StudentRestult { set; get; }
        public Course course { set; get; }
 



        public Student(string regNo, string name, string email, string course, string date ,double scorePersent) 
            : this( regNo, name, email, course,date)
        {
            ScorePersent = scorePersent;
        }


        public Student(string regNo,string name,string email,string course,string date):this()
        {
            StudentRegNo = regNo;
            StudentName = name;
            StudentEmail = email;
            StudentCourse = course;
            EnrollDate = date;

        }

        public Student()
        {

        }

       
        
        
        
        
        
        
        
        
        
        
        
        public string StudentCourse { get; set; }
       
    }
}
