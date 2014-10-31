using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentResultInfoApp.BLL;
using StudentResultInfoApp.DAL.DAO;

namespace StudentResultInfoApp.UI
{
    public partial class ResultEntryUI : Form
    {

        private StudentBLL aStudentBll;
        private Student aStudent;
        private ResultBll aResultBll;
        private Result aResult;

        public ResultEntryUI()
        {
            InitializeComponent();
            List<Course> courses = new List<Course>();


            aStudentBll = new StudentBLL();
            studentCourseComboBox.DisplayMember = "CourseName";
            courses = aStudentBll.GetAllCourse();
            foreach (Course aCourse in courses)
            {
                studentCourseComboBox.Items.Add(aCourse.CourseName);
            }

        }


        private void regNoFindButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student();
            aStudentBll = new StudentBLL();
            
            aStudent.StudentRegNo = studentRegNoTextBox.Text;



            {
                aStudent = aStudentBll.FindStudent(aStudent);



                //show in UI
                studentRegNoTextBox.Text = aStudent.StudentRegNo;
                studentEmailTextBox.Text = aStudent.StudentEmail;
                studentNameTextBox.Text = aStudent.StudentName;
            }
        }

        private void SaveForResultUi_Click(object sender, EventArgs e)
        {
            aStudentBll = new StudentBLL();
            aStudent = new Student();
            aResultBll = new ResultBll();
            aResult = new Result();


             aStudent.StudentRegNo = studentRegNoTextBox.Text;
            aStudent.StudentName = studentNameTextBox.Text;
            aStudent.StudentEmail = studentEmailTextBox.Text;
            aStudent.StudentCourse = studentCourseComboBox.Text;
            aStudent.EnrollDate = courseEnrollDateTimePicker.Text;
            aStudent.ScorePersent = Convert.ToDouble(scorePersentTextBox.Text);
            aResult.Score = aStudent.ScorePersent;

            string msg  = "op Performed";


           aStudentBll.SaveForResultUi(aStudent,aResult);
           string aa = aResultBll.SaveFromResultUi(aResult,aStudent);

            MessageBox.Show(aa);
        }

        private void viewResultSheetButton_Click(object sender, EventArgs e)
        {

            
            ResultSheetUI aResultSheetUi = new ResultSheetUI(studentRegNoTextBox.Text);
            aResultSheetUi.ShowDialog();
        }

     
    }
}
