using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Achievement_Management_System
{
    // Defining Exceptions
    class InvaildIDException : ApplicationException
    {
        public InvaildIDException(string exceptionMessage)
                : base(exceptionMessage) { }
    }
    public enum StudentState { AtSchool, Graduated, ExchangeStudent }

    public enum AddElementResult
    {
        OK,
        AlreadyHaveTheSameID,
        FullOfElement
    }
    public enum EditElementResult
    {
        OK,
        ElementNotFound
    }
    public enum RemoveElementResult
    {
        OK,
        ElementNotFound
    }

    public partial class Student
    {
        private string name;
        private string id;
        private bool sex;
        private StudentState state = 0;
        private int enrollmentYear;
        private string major;
        private string classNumber;
        private bool isCheater;
        private Subject[] subjects = new Subject[1000];
        private int subjectLastPosition = 0;
        private Dictionary<string, int> SubjectMap
            = new Dictionary<string, int>();

        public AddElementResult AddSubject(Subject newSubject)
        {
            if (SubjectMap.ContainsKey(newSubject.Name.ToString()))
                return AddElementResult.AlreadyHaveTheSameID;
            else
            {
                for(int i=0; i<=subjects.Length; i++)
                    if (!SubjectMap.ContainsValue(i))
                    {
                        subjectLastPosition = Math.Max(i, subjectLastPosition);
                        subjects[i] = newSubject.Clone() as Subject;
                        SubjectMap.Add(newSubject.Name.ToString(), i);
                        return AddElementResult.OK;
                    }
                return AddElementResult.FullOfElement;
            }
        }

        public EditElementResult EditSubject(Subject theSubject)
        {
            if (!SubjectMap.ContainsKey(theSubject.Name.ToString()))
                return EditElementResult.ElementNotFound;
            else
            {
                subjects[SubjectMap[theSubject.Name.ToString()]] = theSubject;
                return EditElementResult.OK;
            }
        }

        public RemoveElementResult RemoveSubject(Subject subject)
        {
            if (!SubjectMap.ContainsKey(subject.Name.ToString()))
                return RemoveElementResult.ElementNotFound;
            else
            {
                SubjectMap.Remove(subject.Name.ToString());
                return RemoveElementResult.OK;
            }
        }
        public RemoveElementResult RemoveSubject(int subjectIndex)
        {
            if (!SubjectMap.ContainsKey(subjectIndex.ToString()))
                return RemoveElementResult.ElementNotFound;
            else
            {
                SubjectMap.Remove(subjectIndex.ToString());
                return RemoveElementResult.OK;
            }
        }

        public List<Subject> ListSubjects()
        {
            List<Subject> subjectList = new List<Subject>();
            for (int i = 0; i <= subjectLastPosition; i++)
                if (SubjectMap.ContainsValue(i))
                {
                    if (subjects[i] == null)
                        throw new Exception("AddNullSubjectToList");
                    subjectList.Add(subjects[i]);
                }
            return subjectList;
        }

        public Subject FindSubjectWithName(string theName)
        {
            if (!SubjectMap.ContainsKey(theName))
                return null;
            foreach(Subject theSubject in subjects)
            {
                // Exception: theSubject is null
                if (theSubject.Name == theName)
                    return theSubject;
            }
            return null;
        }

        public void ClearSubjects()
        {
            for (int i = 0; i <= subjectLastPosition; i++)
                subjects[i] = null;
        }

        public Student(string stuName, string stuID, string stuMajor, int stuYear,
            string stuClassNumber, bool stuSex, StudentState stuState = 0)
        {
            this.name = stuName;
            this.id = stuID;
            this.state = stuState;
            this.major = stuMajor;
            this.enrollmentYear = stuYear;
            this.classNumber = stuClassNumber;
            this.sex = stuSex;
        }
        public string Name
        { get { return name; } set { name = value; } }
        public string ID
        { get { return id; } set { id = value; } }
        public bool Sex
        { get { return sex; } set { sex = value; } }
        public string Class
        { get { return classNumber; } set { classNumber = value; } }
        public string Major
        { get { return major; } set { major = value; } }
        public StudentState State
        { get { return state; } set { state = value; } }
        public int Year
        { get { return enrollmentYear; } set { enrollmentYear = value; } }
        public bool CheaterState
        { get { return isCheater; } set { isCheater = value; } }
        

    }
}
