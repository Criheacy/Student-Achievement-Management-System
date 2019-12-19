using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Achievement_Management_System
{
    public partial class MainForm : Form
    {
        public List<Student> SearchStudents(string Key)
        {
            List<Student> searchResult = new List<Student>();
            foreach(Student student in students)
            {
                if (studentsDeleted[studentMap[student.ID]])
                    continue;

                if (student.Class.Contains(Key)
                    || student.ID.Contains(Key)
                    || student.Major.Contains(Key)
                    || student.Year.ToString().Contains(Key)
                    || student.Name.Contains(Key)
                    || ((student.Sex ? "男" : "女") == Key)
                    || (Key.Contains("作弊") && student.CheaterState))
                    searchResult.Add(student);
            }
            return searchResult;
        }
    }
}
