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
using StudentResultInfoApp.UI;

namespace StudentResultInfoApp
{
    public partial class MainUI : Form
    {
        private StudentBLL aStudentBll;

        public MainUI()
        {
            InitializeComponent();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            EnrollUI aEnrollUi = new EnrollUI();

            aEnrollUi.ShowDialog();
        }

        private void enrollResultButton_Click(object sender, EventArgs e)
        {
            ResultEntryUI aResultEntryUi = new ResultEntryUI();
            aResultEntryUi.ShowDialog();

        }

        private void showResultSheetButton_Click(object sender, EventArgs e)
        {
            ResultSheetUI aResultSheetUi = new ResultSheetUI();
            aResultSheetUi.ShowDialog();

        }
    }
}
