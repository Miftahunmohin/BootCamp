namespace StudentResultInfoApp.UI
{
    partial class EnrollUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regNoFindButton = new System.Windows.Forms.Button();
            this.studentRegNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentCourseEnrollButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentEnrollCourseListView = new System.Windows.Forms.ListView();
            this.studentCourseComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.courseEnrollDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regNoFindButton
            // 
            this.regNoFindButton.Location = new System.Drawing.Point(289, 23);
            this.regNoFindButton.Name = "regNoFindButton";
            this.regNoFindButton.Size = new System.Drawing.Size(96, 25);
            this.regNoFindButton.TabIndex = 0;
            this.regNoFindButton.Text = "FindStudent";
            this.regNoFindButton.UseVisualStyleBackColor = true;
            this.regNoFindButton.Click += new System.EventHandler(this.regNoFindButton_Click);
            // 
            // studentRegNoTextBox
            // 
            this.studentRegNoTextBox.Location = new System.Drawing.Point(143, 26);
            this.studentRegNoTextBox.Name = "studentRegNoTextBox";
            this.studentRegNoTextBox.Size = new System.Drawing.Size(114, 20);
            this.studentRegNoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reg No";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(143, 60);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.studentNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.Location = new System.Drawing.Point(143, 96);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(242, 20);
            this.studentEmailTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // studentCourseEnrollButton
            // 
            this.studentCourseEnrollButton.Location = new System.Drawing.Point(376, 171);
            this.studentCourseEnrollButton.Name = "studentCourseEnrollButton";
            this.studentCourseEnrollButton.Size = new System.Drawing.Size(76, 29);
            this.studentCourseEnrollButton.TabIndex = 0;
            this.studentCourseEnrollButton.Text = "Enroll";
            this.studentCourseEnrollButton.UseVisualStyleBackColor = true;
            this.studentCourseEnrollButton.Click += new System.EventHandler(this.studentCourseEnrollButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentEnrollCourseListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enrolled Course";
            // 
            // studentEnrollCourseListView
            // 
            this.studentEnrollCourseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.studentEnrollCourseListView.GridLines = true;
            this.studentEnrollCourseListView.Location = new System.Drawing.Point(10, 19);
            this.studentEnrollCourseListView.Name = "studentEnrollCourseListView";
            this.studentEnrollCourseListView.Size = new System.Drawing.Size(513, 109);
            this.studentEnrollCourseListView.TabIndex = 0;
            this.studentEnrollCourseListView.UseCompatibleStateImageBehavior = false;
            this.studentEnrollCourseListView.View = System.Windows.Forms.View.Details;
            // 
            // studentCourseComboBox
            // 
            this.studentCourseComboBox.FormattingEnabled = true;
            this.studentCourseComboBox.Location = new System.Drawing.Point(143, 131);
            this.studentCourseComboBox.Name = "studentCourseComboBox";
            this.studentCourseComboBox.Size = new System.Drawing.Size(242, 21);
            this.studentCourseComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Course";
            // 
            // courseEnrollDateTimePicker
            // 
            this.courseEnrollDateTimePicker.Location = new System.Drawing.Point(143, 175);
            this.courseEnrollDateTimePicker.Name = "courseEnrollDateTimePicker";
            this.courseEnrollDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.courseEnrollDateTimePicker.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enrollment Date";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Enroll Date";
            // 
            // EnrollUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 375);
            this.Controls.Add(this.courseEnrollDateTimePicker);
            this.Controls.Add(this.studentCourseComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentEmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentRegNoTextBox);
            this.Controls.Add(this.studentCourseEnrollButton);
            this.Controls.Add(this.regNoFindButton);
            this.Name = "EnrollUI";
            this.Text = "EnrollUI";
            this.Load += new System.EventHandler(this.EnrollUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regNoFindButton;
        private System.Windows.Forms.TextBox studentRegNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button studentCourseEnrollButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView studentEnrollCourseListView;
        private System.Windows.Forms.ComboBox studentCourseComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker courseEnrollDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}