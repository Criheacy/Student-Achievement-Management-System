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
    public partial class StudentScoreEditor : Form
    {
        public static string[] GradeLevel = new string[]
        {
            "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-",
            "D+", "D", "D-", "E+", "E", "E-", "F+", "F", "F-"
        };

        private SubjectAssessmentMode assessmentMode;
        private StudentScore score;
        private double fullMark;
        private bool enableRound;
        private bool hasPassLine;
        private double passLine;

        public StudentScoreEditor(Student theStudent, Subject theSubject,
            StudentScore theScore, bool theFirstTime = true)
        {
            InitializeComponent();

            this.enableRound = theSubject.EnableRound;
            this.hasPassLine = theSubject.HasPassLine;
            this.passLine = theSubject.PassLine;
            this.fullMark = theSubject.FullMark;
            this.assessmentMode = theSubject.AssessmentMode;

            if (assessmentMode == SubjectAssessmentMode.None)
            {
                this.Controls.Remove(PassGroup);
                this.Controls.Remove(ScoreGroup);
                this.Controls.Remove(GradeGroup);
                OKButton.Parent = this;
                OKButton.Location = new Point(228, 90);
                this.Size = new Size(360, 180);
            }
            else if (assessmentMode == SubjectAssessmentMode.ByPass)
            {
                this.Controls.Remove(ScoreGroup);
                this.Controls.Remove(GradeGroup);
                PassGroup.Parent = this;
                OKButton.Parent = this;
                PassGroup.Location = new Point(12, 90);
                OKButton.Location = new Point(228, 163);
                if (theFirstTime)
                {
                    PassButton.Checked = true;
                    FailButton.Checked = false;
                }
                else
                {
                    if (theScore.PassState)
                    {
                        PassButton.Checked = true;
                        FailButton.Checked = false;
                    }
                    else
                    {
                        PassButton.Checked = false;
                        FailButton.Checked = true;
                    }
                }
                this.Update();
                this.Size = new Size(360, 254);
            }
            else if (assessmentMode == SubjectAssessmentMode.ByGrade)
            {
                this.Controls.Remove(PassGroup);
                this.Controls.Remove(ScoreGroup);
                GradeGroup.Parent = this;
                OKButton.Parent = this;
                GradeGroup.Location = new Point(12, 90);
                OKButton.Location = new Point(228, 244);
                if (theFirstTime)
                {
                    GradeText.Text = "A+";
                }
                else
                {
                    GradeText.Text = theScore.Grade;
                }
                this.Update();
                this.Size = new Size(360, 335);
            }
            else if (assessmentMode == SubjectAssessmentMode.ByScore)
            {
                this.Controls.Remove(PassGroup);
                this.Controls.Remove(GradeGroup);
                ScoreGroup.Parent = this;
                OKButton.Parent = this;
                ScoreGroup.Location = new Point(12, 90);
                OKButton.Location = new Point(228, 205);
                ScoreText.Maximum = Convert.ToDecimal(fullMark);
                if (theFirstTime)
                {
                    ScoreText.Value = ScoreText.Maximum;
                }
                else
                {
                    try
                    {
                        ScoreText.Value = Convert.ToDecimal(theScore.Score);
                    }
                    catch (Exception)
                    {
                        ScoreText.Value = ScoreText.Maximum;
                    }
                }
                ScoreText.Select(0, ScoreText.Value.ToString().Length);
                this.Update();
                this.Size = new Size(361, 296);
            }
            StudentInformationText.Text = "学生" + "：" + theStudent.ID + " " + theStudent.Name;
            SubjectInformationText.Text = "科目" + "："  + theSubject.Name;
            this.score = theScore;
        }

        public void UpdateScoreSettings()
        {
            if (assessmentMode != SubjectAssessmentMode.ByScore)
                return;
            ScoreText.Maximum = Convert.ToDecimal(fullMark);
            if (hasPassLine)
            {
                if (enableRound)
                {
                    PassLineHint.Text = "及格线：" + Convert.ToInt32(passLine).ToString();
                    ScoreText.Increment = 1M;
                    ScoreText.DecimalPlaces = 0;
                }
                else
                {
                    PassLineHint.Text = "及格线：" + passLine.ToString();
                    ScoreText.Increment = 0.1M;
                    ScoreText.DecimalPlaces = 1;
                }
                if (Convert.ToDouble(ScoreText.Value) < passLine)
                {
                    PassLineState.Text = "（不及格）";
                    PassLineState.ForeColor = Color.FromKnownColor(KnownColor.Red);
                }
                else
                {
                    PassLineState.Text = "（及格）";
                    PassLineState.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                }
            }
        }

        private void CheckIllegal(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else if (GradeText.TextLength == 0)
            {
                if (e.KeyChar == 'A' || e.KeyChar == 'B' || e.KeyChar == 'C'
                    || e.KeyChar == 'D' || e.KeyChar == 'E' || e.KeyChar == 'F')
                    e.Handled = false;
                else e.Handled = true;
            }
            else if (GradeText.TextLength == 1)
            {
                if (e.KeyChar == '+' || e.KeyChar == '-')
                    e.Handled = false;
                else e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private bool mutual = true;
        
        public bool EnableRound { set => enableRound = value; }
        public double PassLine { set => passLine = value; }
        public bool HasPassLine { set => hasPassLine = value; }
        public double FullMark { set => fullMark = value; }
        public StudentScore Score { get => score; }

        private void GradeText_TextChanged(object sender, EventArgs e)
        {
            if (!mutual) return;
            mutual = false;
            for (int i = 0; i < GradeLevel.Length; i++)
                if (GradeText.Text == GradeLevel[i])
                    GradeTraceBar.Value = i;
            mutual = true;
        }

        private void GradeTraceBar_Scroll(object sender, EventArgs e)
        {
            if (!mutual) return;
            mutual = false;
            GradeText.Text = GradeLevel[GradeTraceBar.Value];
            mutual = true;
        }

        private void ScoreText_ValueChanged(object sender, EventArgs e)
        {
            if (hasPassLine)
            {
                if (Convert.ToDouble(ScoreText.Value) < passLine)
                {
                    PassLineState.Text = "（不及格）";
                    PassLineState.ForeColor = Color.FromKnownColor(KnownColor.Red);
                }
                else
                {
                    PassLineState.Text = "（及格）";
                    PassLineState.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (assessmentMode == SubjectAssessmentMode.None)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (assessmentMode == SubjectAssessmentMode.ByPass)
            {
                if (PassButton.Checked) this.score.PassState = true;
                else if (FailButton.Checked) this.score.PassState = false;
                else
                {
                    MessageBox.Show("请选择合格状态。", "填写未完成",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (assessmentMode == SubjectAssessmentMode.ByGrade)
            {
                this.score.Grade = GradeText.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (assessmentMode == SubjectAssessmentMode.ByScore)
            {
                this.score.Score = Convert.ToDouble(ScoreText.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
