using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Achievement_Management_System
{
    public enum ScoreType { Score, Grade, Pass, None }

    public class StudentScore : ICloneable
    {
        private int termNumber;
        private int termSeason;

        private ScoreType scoreType;
        private bool passState;
        private string grade;
        private double score;

        private bool able;

        private void InitStudentScore(int termNumber, int termSeason)
        {
            this.termNumber = termNumber;
            this.termSeason = termSeason;
            // Have not been assigned
            this.score = -1;
            this.grade = "N/A";
            this.passState = false;
        }

        public object Clone()
        {
            StudentScore ClonedScore = new StudentScore(this.termNumber, this.termSeason);
            ClonedScore.scoreType = this.scoreType;
            ClonedScore.passState = this.passState;
            ClonedScore.grade = this.grade;
            ClonedScore.score = this.score;
            return ClonedScore;
        }

        public StudentScore(int termNumber, int termSeason)
        {
            this.able = false;
            this.InitStudentScore(termNumber, termSeason);
            // this.scoreType = ScoreType.None;
        }
        public bool PassState
        { get { return passState; } set { passState = value; } }
        public string Grade
        { get { return grade; } set { grade = value; } }
        public double Score
        { get { return score; } set { score = value; } }
        public bool Enable { get { return able; } set { able = value; } }
    }
    /*
    public struct StudentScore
    {
        public int termNumber;
        public int termSeason;

        public ScoreType scoreType;
        public bool passState;
        public string grade;
        public double score;

        public bool able;
    }
    */


    public enum SubjectAssessmentMode {None, ByPass, ByGrade, ByScore}

    public class Subject : ICloneable
    {
        private string name;
        private bool tag;
        private SubjectAssessmentMode assessmentMode;
        private double fullMark;
        private bool hasPassLine;
        private double passLine;
        private bool enableRound;
        private bool[] courseTime = new bool[8];
        public List<StudentScore> scores = new List<StudentScore>();

        public Subject()
        {
            // Do Something
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    scores.Add(new StudentScore(i, j));
                }
            }
        }

        public void SetScore(int year, int term, StudentScore stuScore)
        {
            if (year > 4 || year < 1)
                throw new ArgumentException("InvalidTermNumber");
            else if (term > 2 || term < 1)
                throw new ArgumentException("InvalidSeasonNumber");
            else
            {
                scores[(year - 1) * 2 + (term - 1)] = stuScore;
                scores[(year - 1) * 2 + (term - 1)].Enable = true;
            }
        }

        public StudentScore GetScore(int year, int term)
        {
            if (year > 4 || year < 1)
                throw new ArgumentException("InvalidTermNumber");
            else if (term > 2 || term < 1)
                throw new ArgumentException("InvalidSeasonNumber");
            else return scores[(year - 1) * 2 + (term - 1)];
        }

        public bool ScoreEnable(int year, int term)
        {
            return scores[(year - 1) * 2 + (term - 1)].Enable;
        }
        public bool GetCourseTime(int year, int term)
        {
            if (year > 4 || year < 1)
                throw new ArgumentException("InvalidTermNumber");
            else if (term > 2 || term < 1)
                throw new ArgumentException("InvalidSeasonNumber");
            else return CourseTime[(year - 1) * 2 + (term - 1)];
        }

        public object Clone()
        {
            Subject ClonedSubject = new Subject();
            ClonedSubject.AssessmentMode = this.AssessmentMode;
            ClonedSubject.CourseTime = this.CourseTime;
            ClonedSubject.EnableRound = this.EnableRound;
            ClonedSubject.FullMark = this.FullMark;
            ClonedSubject.HasPassLine = this.HasPassLine;
            ClonedSubject.PassLine = this.PassLine;
            ClonedSubject.Name = this.Name;
            ClonedSubject.Tag = this.Tag;
            foreach (StudentScore theScore in this.scores)
                ClonedSubject.scores.Add(theScore.Clone() as StudentScore);
            return ClonedSubject;
        }
        public bool CompareValueTo(Subject b)
        {
            if (this == null || b == null) return false;
            if (this.Name != b.Name) return false;
            else if (this.assessmentMode != b.assessmentMode) return false;
            else if (this.fullMark != b.fullMark) return false;
            else if (this.hasPassLine != b.hasPassLine) return false;
            else if (this.passLine != b.passLine) return false;
            else if (this.enableRound != b.enableRound) return false;
            else if (this.courseTime != b.courseTime) return false;
            return true;
        }

        public string Name { get => name; set => name = value; }
        public SubjectAssessmentMode AssessmentMode { get => assessmentMode; set => assessmentMode = value; }
        public double FullMark { get => fullMark; set => fullMark = value; }
        public bool HasPassLine { get => hasPassLine; set => hasPassLine = value; }
        public double PassLine { get => passLine; set => passLine = value; }
        public bool EnableRound { get => enableRound; set => enableRound = value; }
        public bool[] CourseTime { get => courseTime; set => courseTime = value; }
        public bool Tag { get => tag; set => tag = value; }
    }
}
