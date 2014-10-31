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
    public partial class EnrollUI : Form
    {
        StudentBLL  aStudentBll = new StudentBLL();
        private Student nowInStudent;
        private Student aStudent;
        
        public EnrollUI()
        {
            InitializeComponent();
            List<Course> courses = new List<Course>();



            studentCourseComboBox.DisplayMember = "CourseName";
            courses = aStudentBll.GetAllCourse();
            foreach (Course aCourse in courses)
            {
                studentCourseComboBox.Items.Add(aCourse.CourseName);
            }
        }

        private void studentCourseEnrollButton_Click(object sender, EventArgs e)
        {
           aStudent = new Student();


            aStudent.StudentRegNo = studentRegNoTextBox.Text;
            aStudent.StudentName = studentNameTextBox.Text;
            aStudent.StudentEmail = studentEmailTextBox.Text;
            aStudent.StudentCourse = studentCourseComboBox.Text;

            bool isRequestFromResultUI = aStudentBll.CheckForResultUi(courseEnrollDateTimePicker.Text);

            aStudent.EnrollDate = courseEnrollDateTimePicker.Text;

           String msg = aStudentBll.Save(aStudent);
            MessageBox.Show(msg);
            ShoInListViewFromDB(aStudent);
            
        }


        private int test;
        private CourseBLL aCourseBll;


        private void regNoFindButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student();
            aStudent.StudentRegNo = studentRegNoTextBox.Text;



            {
                aStudent = aStudentBll.FindStudent(aStudent);



                //show in UI
                studentRegNoTextBox.Text = aStudent.StudentRegNo;
                studentEmailTextBox.Text = aStudent.StudentEmail;
                studentNameTextBox.Text = aStudent.StudentName;


                ShoInListViewFromDB(aStudent);

            }
        }

        private void ShoInListViewFromDB(Student aStudent)
        {

            
            
            studentEnrollCourseListView.Items.Clear();

            List<Course> courses = new List<Course>();
            ListViewItem listViewItem = new ListViewItem();

            aCourseBll = new CourseBLL();
             courses = aCourseBll.ShoInListViewFromDB(aStudent);





            int i = 1;
            foreach (Course aCourse in courses)
            {
            
                
                
                ListViewItem listViewItem1= new ListViewItem(i.ToString());
                listViewItem1.SubItems.Add(aCourse.CourseName);
                listViewItem1.SubItems.Add(aCourse.EnrollDate);

             studentEnrollCourseListView.Items.Add(listViewItem1);

                i++;
            }
            

        }

        private void EnrollUI_Load(object sender, EventArgs e)
        {
            
        }


        
       
    }
}
 