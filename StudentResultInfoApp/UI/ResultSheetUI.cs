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
    public partial class ResultSheetUI : Form
    {
        private Student aStudent;
        private StudentBLL aStudentBll;
        private Result aResult;
        private string regNFromOther;

        public ResultSheetUI()
        {
            InitializeComponent();
            regNFromOther = "";
        }

        public ResultSheetUI(string text)
        {
            regNFromOther = "";
            aStudentBll = new StudentBLL();
            aStudent =new Student();

            InitializeComponent();

            regNFromOther = text;
            studentRegNoTextBoxInResultSheet.Text = regNFromOther;

        }

        private void findButtonInResultSheet_Click(object sender, EventArgs e)
        {
            aStudent = new Student();
            aStudentBll = new StudentBLL();
            aResult = new Result();

           
            aStudent.StudentRegNo = studentRegNoTextBoxInResultSheet.Text;


           
            {
                aStudent = aStudentBll.FindStudent(aStudent);


                //show in UI
                studentRegNoTextBoxInResultSheet.Text = aStudent.StudentRegNo;
                studentEmailTextBoxInResultSheet.Text = aStudent.StudentEmail;
                studentNameTextBoxInResultSheet.Text = aStudent.StudentName;

                double result = aResult.CalculateAvg(aStudent);

                averageScoreTextBoxInResultSheet.Text = result.ToString();

                string grade = aResult.CalculateGrade(result);
                gradeLetterTextBox.Text = grade;


                ShoInListViewFromDB(aStudent);
            }
        }


        private Course aCourse;
        private CourseBLL aCourseBll;


        private void ShoInListViewFromDB(Student aStudent)
        {



            resultSheetListView.Items.Clear();

            List<Course> courses = new List<Course>();
            ListViewItem listViewItem = new ListViewItem();

            aCourseBll = new CourseBLL();
            courses = aCourseBll.ShoInListViewFromDB(aStudent);





            int i = 1;
            foreach (Course aCourse in courses)
            {



                ListViewItem listViewItem1 = new ListViewItem(i.ToString());
                listViewItem1.SubItems.Add(aCourse.CourseName);
                listViewItem1.SubItems.Add(aCourse.EnrollDate);

                resultSheetListView.Items.Add(listViewItem1);

                i++;
            }


        }
    }
}
