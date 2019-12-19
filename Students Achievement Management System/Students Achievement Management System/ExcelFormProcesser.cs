using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MSExcel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.IO;

namespace Students_Achievement_Management_System
{
    public class ExcelReader
    {
        public List<Student> LoadExcel(string fileName)
        {
            MSExcel.Application theExcel = new MSExcel.Application();
            // theExcel.Visible = true;//设置EXC1打开后可见

            MSExcel.Workbooks wbs = theExcel.Workbooks;
            MSExcel._Workbook wb = wbs.Add(fileName);//打开并显示EXCEL文件

            object Nothing = Missing.Value;
            MSExcel._Worksheet Exsheet;
            Exsheet = wb.Sheets[1];
            Exsheet.Activate();


            List<System.Windows.Forms.ListViewItem> StudentDataList
                = new List<System.Windows.Forms.ListViewItem>();

            List<Student> resultStudent = new List<Student>();

            // Exsheet.Name
            int sRowcount = Exsheet.Rows.Count;
            
            for (int i=1; i<=sRowcount; i++)
            {
                string stuMajor = ((MSExcel.Range)Exsheet.Cells[i, 1]).Text;
                string stuID = ((MSExcel.Range)Exsheet.Cells[i, 2]).Text;
                string stuName = ((MSExcel.Range)Exsheet.Cells[i, 3]).Text;
                bool stuSex =
                    (((MSExcel.Range)Exsheet.Cells[i, 4]).Text == "男");
                string stuClass = ((MSExcel.Range)Exsheet.Cells[i, 5]).Text;

                if (stuID == null || stuID == "") break;
                int stuYear = Convert.ToInt32(stuID.Substring(0, 4));

                Student newStudent = new Student(stuName, stuID, stuMajor, stuYear, stuClass, stuSex);
                resultStudent.Add(newStudent);
            }

            if (wb != null)
                wb.Close(true, Type.Missing, Type.Missing);
            theExcel.Quit();
            System.GC.GetGeneration(theExcel);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(theExcel);

            return resultStudent;
        }
    }
}
