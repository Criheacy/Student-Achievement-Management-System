using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Achievement_Management_System
{
    public partial class StudentEditor : Form
    {
        public StudentInformation resultInformation
            = new StudentInformation();

        public bool InInitialize;

        public enum InformationState
        {
            OK,
            IDMissing,
            NameMissing,
            SexMissing,
            MajorMissing,
            YearMissing,
            ClassMissing
        }

        public StudentEditor()
        {
            InitializeComponent();
        }

        public void InitializeStudentInformation
            (List<Student> theStudents)
        {
            if (theStudents.Count == 0) return;
            InInitialize = true;

            StudentID.Text = theStudents[0].ID;
            StudentName.Text = theStudents[0].Name;
            if (theStudents[0].Sex)
                MaleSex.Checked = true;
            else FemaleSex.Checked = true;
            StudentMajor.Text = theStudents[0].Major;
            YearPicker.Value = new DateTime(theStudents[0].Year, 9, 1);
            StudentClass.Text =
                theStudents[0].Class.Remove(theStudents[0].Class.LastIndexOf("班"));

            foreach(Student theStudent in theStudents)
            {
                if (theStudent.ID != StudentID.Text)
                {
                    resultInformation.changedID = false;
                    StudentID.Text = "（多个学生学号）";
                    StudentID.Enabled = false;
                    // StudentID.BackColor = Color.FromKnownColor(KnownColor.Menu);
                    // StudentID.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
                }
                if (theStudent.Name != StudentName.Text)
                {
                    resultInformation.changedName = false;
                    StudentName.Text = "（多个学生姓名）";
                    StudentName.BackColor = Color.FromKnownColor(KnownColor.Menu);
                    StudentName.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
                }
                if (theStudent.Sex != MaleSex.Checked)
                {
                    resultInformation.changedSex = false;
                    MaleSex.Checked = FemaleSex.Checked = false;
                    MaleSex.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
                    FemaleSex.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
                }
                if (theStudent.Major != StudentMajor.Text)
                {
                    resultInformation.changedMajor = false;
                    StudentMajor.Text = "（多个专业）";
                    StudentMajor.BackColor = Color.FromKnownColor(KnownColor.Menu);
                    StudentMajor.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
                }
                if (theStudent.Class != StudentClass.Text+"班")
                {
                    resultInformation.changedClass = false;
                    StudentClass.Text = "（多个班级）";
                    StudentClass.BackColor = Color.FromKnownColor(KnownColor.Menu);
                    StudentClass.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
                }
                if (theStudent.Year != YearPicker.Value.Year)
                {
                    resultInformation.changedYear = false;
                    YearPicker.BackColor = Color.FromKnownColor(KnownColor.Menu);
                    YearPicker.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
                }
            }

            InInitialize = false ;
        }

        public InformationState GatherDataOnClosing()
        {
            resultInformation.ID = StudentID.Text;
            if (resultInformation.ID.IsNullOrBlank())
                return InformationState.IDMissing;

            resultInformation.Name = StudentName.Text;
            if (resultInformation.Name.IsNullOrBlank())
                return InformationState.NameMissing;

            if (resultInformation.changedSex)
            {
                if (MaleSex.Checked) resultInformation.Sex = true;
                else if (FemaleSex.Checked) resultInformation.Sex = false;
                else return InformationState.SexMissing;
            }

            resultInformation.Major = StudentMajor.Text;
            if (resultInformation.Major.IsNullOrBlank())
                return InformationState.MajorMissing;

            resultInformation.Year = YearPicker.Value.Year;
            
            resultInformation.Class = StudentClass.Text;
            if (resultInformation.Class.IsNullOrBlank())
                return InformationState.ClassMissing;
            resultInformation.Class += "班";

            return InformationState.OK;
        }

        private void StudentID_TextChanged(object sender, EventArgs e)
        {
            if (InInitialize) return;
            if (!resultInformation.changedID)
            {
                resultInformation.changedID = true;
                StudentID.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                StudentID.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {
            if (InInitialize) return;
            if (!resultInformation.changedName)
            {
                resultInformation.changedName = true;
                StudentName.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                StudentName.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void StudentSex_TextChanged(object sender, EventArgs e)
        {
            if (InInitialize) return;
            if (!resultInformation.changedSex)
            {
                resultInformation.changedSex = true;
                FemaleSex.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                MaleSex.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
        }

        private void StudentMajor_TextChanged(object sender, EventArgs e)
        {
            if (InInitialize) return;
            if (!resultInformation.changedMajor)
            {
                resultInformation.changedMajor = true;
                StudentMajor.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                StudentMajor.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void StudentYear_TextChanged(object sender, EventArgs e)
        {
            if (InInitialize) return;
            if (!resultInformation.changedYear)
            {
                resultInformation.changedYear = true;
                YearPicker.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                YearPicker.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void StudentClass_TextChanged(object sender, EventArgs e)
        {
            if (InInitialize) return;
            if (!resultInformation.changedClass)
            {
                resultInformation.changedClass = true;
                StudentClass.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                StudentClass.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            InformationState theState = GatherDataOnClosing();
            if (theState == InformationState.IDMissing)
                MessageBox.Show("请输入学号。", "填写未完成"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == InformationState.NameMissing)
                MessageBox.Show("请输入学生姓名。", "填写未完成"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == InformationState.SexMissing)
                MessageBox.Show("请输入学生性别。", "填写未完成"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == InformationState.MajorMissing)
                MessageBox.Show("请输入学生所属学院。", "填写未完成"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == InformationState.YearMissing)
                MessageBox.Show("请输入学生入学年份。", "填写未完成"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == InformationState.ClassMissing)
                MessageBox.Show("请输入学生所在班级。", "填写未完成"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == InformationState.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }

    public class StudentInformation
    {
        public string ID;
        public string Name;
        public bool Sex;
        public string Major;
        public int Year;
        public string Class;

        public bool changedID;
        public bool changedName;
        public bool changedSex;
        public bool changedMajor;
        public bool changedYear;
        public bool changedClass;

        public StudentInformation()
        {
            changedID = changedName = changedSex
                = changedMajor = changedYear = changedClass = true;
        }

    }
}
