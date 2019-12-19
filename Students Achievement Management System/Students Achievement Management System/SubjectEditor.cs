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
    public enum SubjectEditorResult
    {
        Cancel,
        ApplyForSeletedStudent,
        ApplyForWholeMajor,
        ApplyForAllStudent
    }
    public partial class SubjectEditor : Form
    {
        public List<Subject> tabledSubjects = new List<Subject>();

        public SubjectEditorResult theResult;

        private Subject FindSubjectWithName(string ID)
        {
            foreach (Subject theSubject in tabledSubjects)
            {
                if (theSubject.Name.ToString() == ID)
                    return theSubject;
            }
            return null;
        }

        public bool Enable_ApplyForSeletedStudentButton
        {
            set
            {
                ApplyForSeletedStudent.Enabled = value;
            }
        }
        public bool Enable_ApplyForWholeMajorButton
        {
            set
            {
                ApplyForWholeMajor.Enabled = value;
            }
        }
        public bool Enable_ApplyForAllStudentButton
        {
            set
            {
                ApplyForAllStudents.Enabled = value;
            }
        }

        public SubjectEditor()
        {
            InitializeComponent();
        }

        public void InitTabledSubject(List<Subject> initSubjects)
        {
            tabledSubjects.Clear();
            tabledSubjects.AddRange(initSubjects);
        }

        private void ClearSubjectTable()
        {
            SubjectTable.Items.Clear();
        }

        private string ConvertToText(SubjectAssessmentMode theAssessmentMode)
        {
            if (theAssessmentMode ==
                Students_Achievement_Management_System.SubjectAssessmentMode.None)
                return "不评分";
            else if (theAssessmentMode ==
                Students_Achievement_Management_System.SubjectAssessmentMode.ByPass)
                return "及格制";
            else if (theAssessmentMode ==
                Students_Achievement_Management_System.SubjectAssessmentMode.ByGrade)
                return "等级制";
            else if (theAssessmentMode ==
                Students_Achievement_Management_System.SubjectAssessmentMode.ByScore)
                return "分数制";
            else return "";
        }

        private string ConvertToText(bool[] theCourseTime)
        {
            string[] theText = {"大一上学期","大一下学期","大二上学期","大二下学期",
                "大三上学期","大三下学期","大四上学期","大四下学期"};
            int CourseTimeCnt = 0;
            string PositiveText = "";
            string NegativeText = "";
            for (int i=0; i<theCourseTime.Length; i++)
            {
                if (theCourseTime[i])
                {
                    if (PositiveText == "") PositiveText += theText[i];
                    else PositiveText += (", " + theText[i]);
                    CourseTimeCnt++;
                }
                else
                {
                    if (NegativeText == "") NegativeText += theText[i];
                    else NegativeText += (", " + theText[i]);
                }
            }
            if (CourseTimeCnt == theCourseTime.Length)
                return "所有学期";
            if (CourseTimeCnt <= theCourseTime.Length / 2)
                return PositiveText;
            else
                return "除了" + NegativeText;
        }

        private void PushToTable(Subject theSubject)
        {
            ListViewItem newItem = new ListViewItem
                (new string[] { theSubject.Name,
                    ConvertToText(theSubject.AssessmentMode),
                    ConvertToText(theSubject.CourseTime),
                    theSubject.Name.ToString()}, -1);
            newItem.Name = theSubject.Name;
            newItem.Tag = theSubject.Name;
            SubjectTable.Items.Add(newItem);
        }

        public void UpdateSubjectTable()
        {
            ClearSubjectTable();
            foreach(Subject subject in tabledSubjects)
                    PushToTable(subject);
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            Subject newSubject = new Subject();
            bool addSuccess = false;
            using (SubjectEditor_EditSubject newForm
                = new SubjectEditor_EditSubject())
            {
                newForm.theState = FormState.FirstTime;
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    newSubject = newForm.resultClass;
                    addSuccess = true;
                }
                newForm.Dispose();
            }
            if (addSuccess)
            {
                tabledSubjects.Add(newSubject);
                UpdateSubjectTable();
            }
        }

        private void EditSubjectButton_Click(object sender, EventArgs e)
        {
            int SelectedCnt = SubjectTable.SelectedItems.Count;
            if (SelectedCnt == 1)
            {
                Subject theSubject = FindSubjectWithName(SubjectTable.SelectedItems[0].Tag.ToString());
                bool editSuccess = false;
                using (SubjectEditor_EditSubject newForm
                    = new SubjectEditor_EditSubject())
                {
                    newForm.theState = FormState.ReOpen;
                    newForm.InitializeSubject(theSubject);
                    if (newForm.ShowDialog() == DialogResult.OK)
                    {
                        theSubject = newForm.resultClass;
                        editSuccess = true;
                    }
                }
                if (editSuccess)
                {
                    tabledSubjects[tabledSubjects.IndexOf(FindSubjectWithName(theSubject.Name))] = theSubject;
                    UpdateSubjectTable();
                }
            }
        }

        private void RemoveSubjectButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem theItem in SubjectTable.SelectedItems)
            {
                tabledSubjects.Remove(FindSubjectWithName(theItem.Tag.ToString()));
            }
            UpdateSubjectTable();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void ApplyForSeletedStudent_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.theResult = SubjectEditorResult.ApplyForSeletedStudent;
            this.Close();
        }

        private void ApplyForWholeMajor_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.theResult = SubjectEditorResult.ApplyForWholeMajor;
            this.Close();
        }

        private void ApplyForAllStudents_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.theResult = SubjectEditorResult.ApplyForAllStudent;
            this.Close();
        }

    }
}
