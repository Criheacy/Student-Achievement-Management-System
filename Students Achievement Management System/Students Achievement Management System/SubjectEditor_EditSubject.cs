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
    public enum FormState { FirstTime, ReOpen }
    public enum CompleteState { OK ,NameMissing, AssessmentModeMissing,
        FullMarkMissing, FullMarkError, PassLineMissing, PassLineError,
        PassLineToHighError, RoundStateMissing, NoneOfCourseTime }
    public partial class SubjectEditor_EditSubject : Form
    {
        public FormState theState;
        private string savedName;
        public Subject resultClass;

        public SubjectEditor_EditSubject()
        {
            InitializeComponent();
        }

        public void InitializeSubject(Subject theSubject, bool multy = false)
        {
            savedName = theSubject.Name;
            if (multy)
            {
                ES_SubjectName.Text = "（多个科目名称）";
                ES_SubjectName.Enabled = false;
            }
            else
            {
                ES_SubjectName.Text = theSubject.Name;
                ES_SubjectName.Enabled = true;
            }

            if (theSubject.AssessmentMode == SubjectAssessmentMode.None)
                ES_AssessmentModeNoneButton.Checked = true;
            else if (theSubject.AssessmentMode == SubjectAssessmentMode.ByPass)
                ES_AssessmentModeByPassButton.Checked = true;
            else if (theSubject.AssessmentMode == SubjectAssessmentMode.ByGrade)
                ES_AssessmentModeByGradeButton.Checked = true;
            else if (theSubject.AssessmentMode == SubjectAssessmentMode.ByScore)
                ES_AssessmentModeByScoreButton.Checked = true;

            if (theSubject.AssessmentMode == SubjectAssessmentMode.ByScore)
            {
                ES_WhenAssessmodeByScoreGroup.Enabled = true;

                ES_FullMark.Text = theSubject.FullMark.ToString();

                if (theSubject.HasPassLine)
                {
                    ES_SetPassLineCheck.Checked = true;
                    ES_PassLine.Enabled = true;
                    ES_PassLine.Text = theSubject.PassLine.ToString();
                }
                else
                {
                    ES_SetPassLineCheck.Checked = false;
                    ES_PassLine.Enabled = false;
                }
                if (theSubject.EnableRound)
                    ES_RoundCheck.Checked = true;
                else ES_RoundCheck.Checked = false;
            }
            else
            {
                ES_WhenAssessmodeByScoreGroup.Enabled = false;
            }

            Freshman1.Checked = Freshman2.Checked =
            Sophomore1.Checked = Sophomore2.Checked =
            Junior1.Checked = Junior2.Checked =
            Senior1.Checked = Senior2.Checked = false;

            if (theSubject.CourseTime[0]) Freshman1.Checked = true;
            if (theSubject.CourseTime[1]) Freshman2.Checked = true;
            if (theSubject.CourseTime[2]) Sophomore1.Checked = true;
            if (theSubject.CourseTime[3]) Sophomore2.Checked = true;
            if (theSubject.CourseTime[4]) Junior1.Checked = true;
            if (theSubject.CourseTime[5]) Junior2.Checked = true;
            if (theSubject.CourseTime[6]) Senior1.Checked = true;
            if (theSubject.CourseTime[7]) Senior2.Checked = true;
        }

        public CompleteState GatherDataOnClosing()
        {
            resultClass = new Subject();
            if (theState == FormState.ReOpen)
                resultClass.Name = savedName;
            resultClass.Name = ES_SubjectName.Text;
            if (resultClass.Name.IsNullOrBlank())
                return CompleteState.NameMissing;

            if (ES_AssessmentModeNoneButton.Checked)
                resultClass.AssessmentMode = SubjectAssessmentMode.None;
            else if (ES_AssessmentModeByPassButton.Checked)
                resultClass.AssessmentMode = SubjectAssessmentMode.ByPass;
            else if (ES_AssessmentModeByGradeButton.Checked)
                resultClass.AssessmentMode = SubjectAssessmentMode.ByGrade;
            else if (ES_AssessmentModeByScoreButton.Checked)
                resultClass.AssessmentMode = SubjectAssessmentMode.ByScore;
            else return CompleteState.AssessmentModeMissing;

            if (ES_AssessmentModeByScoreButton.Checked)
            {
                string FullMarkString = ES_FullMark.Text;
                if (FullMarkString.IsNullOrBlank())
                    return CompleteState.FullMarkMissing;
                try
                {
                    resultClass.FullMark = Convert.ToDouble(FullMarkString);
                }
                catch (Exception)
                {
                    return CompleteState.FullMarkError;
                }

                if (ES_SetPassLineCheck.Checked)
                {
                    resultClass.HasPassLine = true;
                    string PassLineString = ES_PassLine.Text;
                    if (PassLineString.IsNullOrBlank())
                        return CompleteState.PassLineMissing;
                    try
                    {
                        resultClass.PassLine = Convert.ToDouble(PassLineString);
                    }
                    catch (Exception)
                    {
                        return CompleteState.PassLineError;
                    }
                    if (resultClass.PassLine > resultClass.FullMark)
                        return CompleteState.PassLineToHighError;
                }
                else resultClass.HasPassLine = false;

                if (ES_RoundCheck.Checked)
                    resultClass.EnableRound = true;
                else resultClass.EnableRound = false;
            }
            else
            {
                resultClass.HasPassLine = false;
                resultClass.PassLine = 0;
                resultClass.EnableRound = false;
                resultClass.FullMark = 0;
            }

            resultClass.CourseTime = new bool[]
            { false, false, false, false, false, false, false, false };
            if (Freshman1.Checked)  resultClass.CourseTime[0] = true;
            if (Freshman2.Checked)  resultClass.CourseTime[1] = true;
            if (Sophomore1.Checked) resultClass.CourseTime[2] = true;
            if (Sophomore2.Checked) resultClass.CourseTime[3] = true;
            if (Junior1.Checked)    resultClass.CourseTime[4] = true;
            if (Junior2.Checked)    resultClass.CourseTime[5] = true;
            if (Senior1.Checked)    resultClass.CourseTime[6] = true;
            if (Senior2.Checked)    resultClass.CourseTime[7] = true;

            bool NoneOfCourseTimeCheck = true;
            for (int i=0; i<resultClass.CourseTime.Length; i++)
            {
                if (resultClass.CourseTime[i])
                {
                    NoneOfCourseTimeCheck = false;
                    break;
                }
            }
            if (NoneOfCourseTimeCheck)
                return CompleteState.NoneOfCourseTime;

            return CompleteState.OK;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            CompleteState theState = GatherDataOnClosing();
            if (theState == CompleteState.NameMissing)
                MessageBox.Show("请填写'科目名称'选项。", "填写未完成",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == CompleteState.AssessmentModeMissing)
                MessageBox.Show("请选择至少一项'评分标准'。", "填写未完成",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == CompleteState.FullMarkMissing)
                MessageBox.Show("请输入该科目的'满分'分数。", "填写未完成",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == CompleteState.FullMarkError)
                MessageBox.Show("请填写正确的'满分'数字。", "数字格式错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (theState == CompleteState.PassLineMissing)
                MessageBox.Show("请输入该科目的'及格线'分数。", "填写未完成",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == CompleteState.PassLineError)
                MessageBox.Show("请填写正确的'及格线'数字。", "数字格式错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (theState == CompleteState.PassLineToHighError)
                MessageBox.Show("及格分数不能高于满分分数。", "及格线过高",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (theState == CompleteState.NoneOfCourseTime)
                MessageBox.Show("请选择至少一学期的课程时间", "填写未完成",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (theState == CompleteState.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ES_AssessmentModeByScoreButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ES_AssessmentModeByScoreButton.Checked)
                ES_WhenAssessmodeByScoreGroup.Enabled = true;
            else ES_WhenAssessmodeByScoreGroup.Enabled = false;
        }

        private void ES_SetPassLineCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ES_SetPassLineCheck.Checked)
                ES_PassLine.Enabled = true;
            else ES_PassLine.Enabled = false;
        }
    }

}
