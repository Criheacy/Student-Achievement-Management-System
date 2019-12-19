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
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        public bool[] studentsDeleted = new bool[1000];
        private List<string> TabledSubject = new List<string>();


        private Dictionary<string, int> studentMap
            = new Dictionary<string, int>();

        private int studentCnt = -1;

        private string[] hierarchyText = new string[4];
        private string[] hierarchyName = new string[4];


        public MainForm()
        {
            InitializeComponent();
        }

        #region HotKeys Settings
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control)     //Ctrl+L
            {
                ListLock.Checked = !ListLock.Checked;
            }
            if ((int)e.Modifiers == ((int)Keys.Control + (int)Keys.Alt) && e.KeyCode == Keys.D0)  //Ctrl + Alt + 数字0
            {
                MessageBox.Show("按下了Control + Alt + 0");
            }
        }

        #endregion

        public void AddNewStudent(Student theStudent)
        {
            if (!studentMap.ContainsKey(theStudent.ID))
            {
                studentCnt++;
                students.Add(theStudent);
                studentMap.Add(theStudent.ID, studentCnt);
            }
        }
        public void RemoveStudent(int studentIndex)
        {
            studentsDeleted[studentIndex] = true;
        }

        /// <summary>
        /// 更新节点node及其子树中有需要更新的部分
        /// </summary>
        /// <param name="dep">node所在的深度</param>
        /// <returns>返回更新后的node子树</returns>
        private TreeNode AddTreeNode(int dep)
        {
            TreeNode updatedTreeNode = new TreeNode();
            updatedTreeNode.Name = hierarchyName[dep];
            updatedTreeNode.Text = hierarchyText[dep];
            if (dep < hierarchyText.Length - 1)
                updatedTreeNode.Nodes.Add((TreeNode)AddTreeNode(dep + 1).Clone());
            return updatedTreeNode;
        }

        /// <summary>
        /// 当前尚未发现需要更新的子树，递归继续当前项的深度
        /// 如果发现需要更新的部分，转交给AddTreeNode
        /// </summary>
        /// <param name="theTree">当前搜索的子树</param>
        /// <param name="dep">当前处于的深度</param>
        /// <returns>返回整颗子树</returns>
        private TreeNode SearchTreeNode(TreeNode theTree, int dep)
        {
            if (theTree.Nodes.ContainsKey(hierarchyText[dep]))
            {
                if (dep < hierarchyText.Length - 1)
                {
                    TreeNode newNode = (TreeNode)SearchTreeNode(theTree.Nodes.Find(hierarchyText[dep], false)[0], dep + 1).Clone();
                    theTree.Nodes.RemoveByKey(hierarchyText[dep]);
                    theTree.Nodes.Add(newNode);
                }
                return theTree;
            }
            else
            {
                theTree.Nodes.Add((TreeNode)AddTreeNode(dep).Clone());
                return theTree;
            }
        }

        private void UpdateStudentTree()
        {
            StudentTree.Nodes.Clear();
            foreach (Student student in students)
            {
                if (studentsDeleted[studentMap[student.ID]])
                    continue;

                hierarchyText[0] = student.Major;
                hierarchyText[1] = student.Year.ToString();
                hierarchyText[2] = student.Class;
                hierarchyText[3] = student.Name;
                
                hierarchyName[0] = student.Major;
                hierarchyName[1] = student.Year.ToString();
                hierarchyName[2] = student.Class;
                hierarchyName[3] = student.ID;

                if (StudentTree.Nodes.ContainsKey(hierarchyText[0]))
                {
                    TreeNode newNode = (TreeNode)SearchTreeNode(StudentTree.Nodes.Find(hierarchyText[0], false)[0], 1).Clone();
                    StudentTree.Nodes.RemoveByKey(hierarchyText[0]);
                    StudentTree.Nodes.Add(newNode);
                }
                else
                    StudentTree.Nodes.Add((TreeNode)AddTreeNode(0).Clone());
            }
        }

        private void debugButton1_Click(object sender, EventArgs e)
        {
            BindingSource sourceA = new BindingSource();
            sourceA.DataSource = new int[10];
            comboBoxYear.DataSource = sourceA;
        }

        private void ShowSubjectEditor(object sender, EventArgs e)
        {
            SubjectEditor theSubjectEditor = new SubjectEditor();
            List<Subject> tabledSubjects = new List<Subject>();
            List<string> tabledSubjectsName = new List<string>();
            tabledSubjects.Clear();
            tabledSubjectsName.Clear();

            bool isInTheSameMajor = true;
            string theSameMajor = "";
            if (students.Count == 0)
            {
                MessageBox.Show("数据库中没有学生。", "无法编辑科目", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (StudentTable.SelectedItems.Count == 0)
            {
                theSubjectEditor.Enable_ApplyForSeletedStudentButton = false;
                foreach (Student theStudent in students)
                {
                    foreach (Subject theSubject in theStudent.ListSubjects())
                    {
                        if (!tabledSubjectsName.Contains(theSubject.Name))
                        {
                            tabledSubjectsName.Add(theSubject.Name);
                            tabledSubjects.Add(theSubject.Clone() as Subject);
                        }
                    }
                }
                theSubjectEditor.Enable_ApplyForSeletedStudentButton = false;
                theSubjectEditor.Enable_ApplyForWholeMajorButton = false;
            }
            else
            {
                theSameMajor = students[studentMap[
                    StudentTable.SelectedItems[0].Tag.ToString()]].Major;
                foreach (ListViewItem studentItem in StudentTable.SelectedItems)
                {
                    Student theStudent = students[studentMap[studentItem.Tag.ToString()]];
                    if (theStudent.Major != theSameMajor)
                        isInTheSameMajor = false;
                    foreach (Subject theSubject in theStudent.ListSubjects())
                    {
                        if (!tabledSubjectsName.Contains(theSubject.Name))
                        {
                            tabledSubjectsName.Add(theSubject.Name);
                            tabledSubjects.Add(theSubject.Clone() as Subject);
                        }
                    }
                }
                if (!isInTheSameMajor)
                    theSubjectEditor.Enable_ApplyForWholeMajorButton = false;
            }
            theSubjectEditor.InitTabledSubject(tabledSubjects);
            theSubjectEditor.UpdateSubjectTable();
            if (!isInTheSameMajor)
                theSubjectEditor.Enable_ApplyForWholeMajorButton = false;
            if (theSubjectEditor.ShowDialog() == DialogResult.OK)
            {
                bool IgnoreSameSubject = false;
                DialogResult autoDialogResult = DialogResult.Cancel;
                List<Student> tempStudentList = new List<Student>();

                if (theSubjectEditor.theResult == SubjectEditorResult.ApplyForSeletedStudent)
                {
                    foreach (ListViewItem studentItem in StudentTable.SelectedItems)
                        tempStudentList.Add(students[studentMap[studentItem.Tag.ToString()]]);
                }
                else if (theSubjectEditor.theResult == SubjectEditorResult.ApplyForWholeMajor)
                {
                    foreach (Student theStudent in students)
                        if (theStudent.Major == theSameMajor)
                            tempStudentList.Add(theStudent);
                }
                else if (theSubjectEditor.theResult == SubjectEditorResult.ApplyForAllStudent)
                {
                    foreach (Student theStudent in students)
                        tempStudentList.Add(theStudent);
                }
                foreach (Student theStudent in tempStudentList)
                {
                    foreach (Subject theOldSubject in theStudent.ListSubjects())
                    {
                        theOldSubject.Tag = false;

                        //EditElementResult editElementResult =
                        //    theStudent.EditSubject(theOldSubject.Clone() as Subject);
                        //if (editElementResult == EditElementResult.ElementNotFound)
                        //    throw new Exception("EditElementNotFound");
                    }
                    // theStudent.ClearSubjects();
                    foreach (Subject theTabledSubject in theSubjectEditor.tabledSubjects)
                    {
                        theTabledSubject.Tag = true;
                        
                        AddElementResult addElementResult =
                            theStudent.AddSubject(theTabledSubject.Clone() as Subject);
                        if (addElementResult == AddElementResult.AlreadyHaveTheSameID)
                        {
                            Subject foundSubject = theStudent.FindSubjectWithName(theTabledSubject.Name);
                            if (foundSubject != null)
                            {
                                if (foundSubject.CompareValueTo(theTabledSubject))
                                {
                                    foundSubject.Tag = true;
                                    continue;
                                }
                            }

                            if (!IgnoreSameSubject)
                            {
                                OKDialogWithCheckBox theNewDialog =
                                    new OKDialogWithCheckBox(("学生" + theStudent.Name + "已有科目" + "\"" + theTabledSubject.Name + "\""),
                                    "提示", "用新信息替换原有科目", "保留原有科目信息", "为以后学生执行同样操作", false);
                                DialogResult theResult = theNewDialog.ShowDialog();
                                if (theResult == DialogResult.OK)
                                {
                                    EditElementResult editElementResult =
                                        theStudent.EditSubject(theTabledSubject.Clone() as Subject);
                                    if (editElementResult == EditElementResult.ElementNotFound)
                                        throw new Exception("EditElementNotFound");
                                }
                                if (theNewDialog.CheckBoxState)
                                {
                                    IgnoreSameSubject = true;
                                    autoDialogResult = theResult;
                                }
                            }
                            else
                            {
                                if (autoDialogResult == DialogResult.OK)
                                {
                                    EditElementResult editElementResult =
                                        theStudent.EditSubject(theTabledSubject.Clone() as Subject);
                                    if (editElementResult == EditElementResult.ElementNotFound)
                                        throw new Exception("EditElementNotFound");
                                }
                            }
                        }
                        else if (addElementResult == AddElementResult.FullOfElement)
                            throw new Exception("SubjectListIsFull");
                    }
                    foreach (Subject theOldSubject in theStudent.ListSubjects())
                    {
                        if (!(theOldSubject.Tag))
                        {
                            RemoveElementResult removeElementResult =
                                students[studentMap[theStudent.ID]].RemoveSubject(theOldSubject);
                            if (removeElementResult == RemoveElementResult.ElementNotFound)
                                throw new Exception("RemoveElementNotFound");
                        }
                    }
                }
                UpdateTable();
            }
        }

        private void AS_ShowGraduatedStudents_CheckedChanged(object sender, EventArgs e)
        {
            if (AS_ShowGraduatedStudents.CheckState == CheckState.Checked)
                AS_ShowGraduatedStudents.Text = "只显示已离校学生";
            else if (AS_ShowGraduatedStudents.CheckState == CheckState.Indeterminate)
                AS_ShowGraduatedStudents.Text = "显示已离校学生";
            else if (AS_ShowGraduatedStudents.CheckState == CheckState.Unchecked)
                AS_ShowGraduatedStudents.Text = "不显示已离校学生";
        }

        private void EnableAdvancedSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableAdvancedSearch.CheckState == CheckState.Checked)
                AdvancedSearchFrame.Enabled = true;
            else if (EnableAdvancedSearch.CheckState == CheckState.Unchecked)
                AdvancedSearchFrame.Enabled = false;
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadExcelFile(string theName)
        {
            ExcelReader theExcelReader = new ExcelReader();

            ProcessingDialog theProcessingDialog = new ProcessingDialog("正在导入Excel文件...");
            theProcessingDialog.SetProcessingPercentage(10);
            theProcessingDialog.Show();

            List<Student> getchStudents = theExcelReader.LoadExcel(theName);
            foreach (Student getchStudent in getchStudents)
                AddNewStudent(getchStudent);

            theProcessingDialog.SetProcessingPercentage(50);

            UpdateStudentTree();

            theProcessingDialog.SetProcessingPercentage(100);
            theProcessingDialog.Dispose();
        }

        private void LoadExcelByButton(object sender, EventArgs e)
        {
            DialogResult theResult = InportExcelDialog.ShowDialog();
            string theName = InportExcelDialog.FileName;
            if (theResult == DialogResult.OK && !string.IsNullOrEmpty(theName))
            {
                LoadExcelFile(theName);
            }
        }

        private void SaveJsonByButton(object sender, EventArgs e)
        {
            DialogResult theResult = SaveJsonDialog.ShowDialog();
            string theName = SaveJsonDialog.FileName;
            if (theResult == DialogResult.OK && !string.IsNullOrEmpty(theName))
            {
                JsonReader.SaveJsonFile(students, theName);
            }
        }

        private ListViewItem StudentFormatToItem(Student theStudent)
        {
            string[] itemInformation = new string[1000];
            itemInformation[0] = theStudent.ID;
            itemInformation[1] = theStudent.Name;
            itemInformation[2] = theStudent.Major + theStudent.Class;

            if (comboBoxYear.SelectedItem != null && comboBoxTerm.SelectedItem != null)
            {
                int nowYear = Convert.ToInt32(comboBoxYear.SelectedItem.ToString())
                    - theStudent.Year + 1;
                int nowTerm = (comboBoxTerm.SelectedItem.ToString() == "一") ? 1 : 2;

                foreach (Subject theSubject in theStudent.ListSubjects())
                {
                    if (!TabledSubject.Contains(theSubject.Name))
                    {
                        TabledSubject.Add(theSubject.Name);
                        ColumnHeader newSubject = (new ColumnHeader());
                        newSubject.Text = theSubject.Name; newSubject.Width = 100; newSubject.Tag = theSubject.Name;
                        StudentTable.Columns.Add(newSubject);
                    }
                }

                for (int i = 1; i <= TabledSubject.Count; i++)
                {
                    if (nowYear < 1)
                    {
                        itemInformation[2 + i] = (NALock.Checked ? "_N/A 该学生尚未入学" : "");
                        break;
                    }
                    else if (nowYear > 4)
                    {
                        itemInformation[2 + i] = (NALock.Checked ? "_N/A 该学生已经毕业" : "");
                        break;
                    }

                    Subject subjectOfTheStudent = theStudent.FindSubjectWithName(TabledSubject[i - 1]);
                    if (subjectOfTheStudent == null)
                        itemInformation[2 + i] = (NALock.Checked ? "_N/A 该学生没有这一科目" : "");
                    else if (!subjectOfTheStudent.GetCourseTime(nowYear, nowTerm))
                        itemInformation[2 + i] = (NALock.Checked ? "_N/A 该科目在此学期不授课" : "");
                    else if (subjectOfTheStudent.AssessmentMode == SubjectAssessmentMode.None)
                        itemInformation[2 + i] = "不评分";
                    else if (!subjectOfTheStudent.GetScore(nowYear, nowTerm).Enable)
                        itemInformation[2 + i] = (NALock.Checked ? "_N/A 尚未录入成绩" : "");
                    else if (subjectOfTheStudent.AssessmentMode == SubjectAssessmentMode.ByPass)
                    {
                        if (subjectOfTheStudent.GetScore(nowYear, nowTerm).PassState)
                            itemInformation[2 + i] = "合格";
                        else itemInformation[2 + i] = "不合格";
                    }
                    else if (subjectOfTheStudent.AssessmentMode == SubjectAssessmentMode.ByGrade)
                        itemInformation[2 + i] = subjectOfTheStudent.GetScore(nowYear, nowTerm).Grade;
                    else if (subjectOfTheStudent.AssessmentMode == SubjectAssessmentMode.ByScore)
                    {
                        string scoreText = "";
                        string passText = "";
                        if (subjectOfTheStudent.EnableRound)
                        {
                            scoreText = Convert.ToInt32(
                                Math.Round(
                                    subjectOfTheStudent.GetScore(nowYear, nowTerm).Score)
                                ).ToString();
                        }
                        else
                        {
                            scoreText = subjectOfTheStudent.GetScore(nowYear, nowTerm).Score.ToString();
                        }
                        if (subjectOfTheStudent.HasPassLine)
                        {
                            if (subjectOfTheStudent.GetScore(nowYear, nowTerm).Score >= subjectOfTheStudent.PassLine)
                                passText = " " + "[及格]";
                            else passText = " " + "[不及格]";
                        }
                        itemInformation[2 + i] = scoreText + passText;
                    }
                }
            }
            ListViewItem newItem = new ListViewItem(itemInformation, -1);
            newItem.Name = theStudent.ID;
            newItem.Tag = theStudent.ID;
            return newItem;
        }

        private void PushToTable(Student theStudent, int index = -1)
        {
            ListViewItem newItem = StudentFormatToItem(theStudent);
            if (index == -1)
                StudentTable.Items.Add(newItem);
            else
            {
                try
                {
                    StudentTable.Items.Insert(index, newItem);
                }
                catch (Exception) { }
            }
        }


        private void PushToTable(List<Student> theStudents)
        {
            foreach (Student theStudent in theStudents)
                if (!StudentTable.Items.ContainsKey(theStudent.ID))
                    PushToTable(theStudent);
        }

        private void ClearTable()
        {
            StudentTable.Items.Clear();

            TabledSubject.Clear();

            StudentTable.Columns.Clear();
            ColumnHeader stuID = (new ColumnHeader());
            stuID.Text = "学号"; stuID.Width = 200; stuID.Tag = "学号";
            ColumnHeader stuName = (new ColumnHeader());
            stuName.Text = "姓名"; stuName.Width = 100; stuName.Tag = "姓名";
            ColumnHeader stuMajorClass = (new ColumnHeader());
            stuMajorClass.Text = "学院班级"; stuMajorClass.Width = 125; stuMajorClass.Tag = "学院班级";
            StudentTable.Columns.AddRange(new ColumnHeader[] { stuID, stuName, stuMajorClass });
        }

        private void UpdateTable()
        {
            List<string> theTabledStudentID = new List<string>();
            foreach (ListViewItem listViewItem in StudentTable.Items)
                theTabledStudentID.Add(listViewItem.Tag.ToString());
            ClearTable();
            foreach (string studentID in theTabledStudentID)
                PushToTable(students[studentMap[studentID]]);
        }

        private void PushNodesToTable(TreeNode theNode)
        {
            if (theNode.Nodes.Count == 0)
                PushToTable(students[studentMap[theNode.Name]]);
            else
                foreach(TreeNode subNode in theNode.Nodes)
                    PushNodesToTable(subNode);
        }


        private void StudentTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ListLock.Checked) return;

            if (!AddOnlyLock.Checked) ClearTable();
            PushNodesToTable(StudentTree.SelectedNode);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Student> searchResult = SearchStudents(SearchKeyText.Text);
            if (searchResult.Count == 0)
            {
                MessageBox.Show("找不到相关学生。",
                    "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (ListLock.Checked)
            {
                DialogResult theDialogResult =
                    MessageBox.Show("学生展示表已被锁定，搜索结果将无法显示。\n是否解锁学生展示表？\n",
                    "警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (theDialogResult == DialogResult.Yes)
                    ListLock.Checked = false;
                else return;
            }
            if (!AddOnlyLock.Checked) ClearTable();
            PushToTable(searchResult);
        }

        private void StudentTable_Leave(object sender, EventArgs e)
        {
            if (StudentTable.ListViewItemSorter == null) return;
            ListViewExtendClass.ListViewColumnSorter comparer 
                = StudentTable.ListViewItemSorter as ListViewExtendClass.ListViewColumnSorter;
            StudentTable.Columns[comparer.SortColumn].Text 
                = (string)StudentTable.Columns[comparer.SortColumn].Tag;
        }
        private void StudentTable_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (StudentTable.ListViewItemSorter == null)
            {
                StudentTable.ListViewItemSorter =
                new ListViewExtendClass.ListViewColumnSorter(e.Column, SortOrder.Ascending);
            }
            ListViewExtendClass.ListViewColumnSorter comparer
                = StudentTable.ListViewItemSorter as ListViewExtendClass.ListViewColumnSorter;
            if (comparer.SortColumn == e.Column)
            {
                if (comparer.Order == SortOrder.Ascending)
                {
                    StudentTable.Columns[e.Column].Text = (string)StudentTable.Columns[e.Column].Tag + " ↓";
                    comparer.Order = SortOrder.Descending;
                }
                else
                {
                    StudentTable.Columns[e.Column].Text = (string)StudentTable.Columns[e.Column].Tag + " ↑";
                    comparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                StudentTable.Columns[comparer.SortColumn].Text = (string)StudentTable.Columns[comparer.SortColumn].Tag;
                comparer.SortColumn = e.Column;
                StudentTable.Columns[e.Column].Text = (string)StudentTable.Columns[e.Column].Tag + " ↑";
                comparer.Order = SortOrder.Ascending;
            }
            StudentTable.Sort();
        }

        private void ChangeTableColor()
        {
            if (ListLock.Checked)
                StudentTable.BackColor = System.Drawing.Color.FromArgb
                    (255, 235, 235, 235);
            else if (AddOnlyLock.Checked)
                StudentTable.BackColor = System.Drawing.Color.FromArgb
                    (255, 247, 235, 235);
            else
                StudentTable.BackColor = System.Drawing.Color.FromArgb
                    (255, 255, 255, 255);
        }

        private void ListLock_CheckedChanged(object sender, EventArgs e)
        {
            if (ListLock.Checked)
                AddOnlyLock.Enabled = false;
            else AddOnlyLock.Enabled = true;
            ChangeTableColor();
        }
        private void AddOnlyLock_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTableColor();
        }

        private void NALock_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void EditStudentsInformation_Click(object sender, EventArgs e)
        {
            StudentEditor theStudentEditor = new StudentEditor();
            List<Student> seletedStudent = new List<Student>();

            if (StudentTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选择任何学生。", "无法编辑信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(ListViewItem theViewedStudent in StudentTable.SelectedItems)
            {
                seletedStudent.Add
                    (students[studentMap[theViewedStudent.Tag.ToString()]]);
            }

            theStudentEditor.InitializeStudentInformation(seletedStudent);
            if (theStudentEditor.ShowDialog() == DialogResult.OK)
            {
                foreach(Student theSeletedStudent in seletedStudent)
                {
                    if (theStudentEditor.resultInformation.changedID)
                    {
                        int studentIndex = studentMap[theSeletedStudent.ID];
                        students[studentIndex].ID
                            = theStudentEditor.resultInformation.ID;
                        if (!studentMap.ContainsKey(theStudentEditor.resultInformation.ID))
                        {
                            studentMap.Add(theStudentEditor.resultInformation.ID,
                                studentIndex);
                        }
                        else
                        {
                            studentMap[theStudentEditor.resultInformation.ID]
                                = studentIndex;
                        }
                        theSeletedStudent.ID = theStudentEditor.resultInformation.ID;
                    }
                    if (theStudentEditor.resultInformation.changedName)
                    {
                        students[studentMap[theSeletedStudent.ID]].Name
                            = theStudentEditor.resultInformation.Name;
                        theSeletedStudent.Name = theStudentEditor.resultInformation.Name;
                    }
                    if (theStudentEditor.resultInformation.changedSex)
                    {
                        students[studentMap[theSeletedStudent.ID]].Sex
                            = theStudentEditor.resultInformation.Sex;
                        theSeletedStudent.Sex = theStudentEditor.resultInformation.Sex;
                    }
                    if (theStudentEditor.resultInformation.changedMajor)
                    {
                        students[studentMap[theSeletedStudent.ID]].Major
                            = theStudentEditor.resultInformation.Major;
                        theSeletedStudent.Major = theStudentEditor.resultInformation.Major;
                    }
                    if (theStudentEditor.resultInformation.changedYear)
                    {
                        students[studentMap[theSeletedStudent.ID]].Year
                            = theStudentEditor.resultInformation.Year;
                        theSeletedStudent.Year = theStudentEditor.resultInformation.Year;
                    }
                    if (theStudentEditor.resultInformation.changedClass)
                    {
                        students[studentMap[theSeletedStudent.ID]].Class
                            = theStudentEditor.resultInformation.Class;
                        theSeletedStudent.Class = theStudentEditor.resultInformation.Class;
                    }
                }

                UpdateStudentTree();

                ClearTable();
                PushToTable(seletedStudent);
            }
            theStudentEditor.Dispose();
        }

        private void AddStudentInformation_Click(object sender, EventArgs e)
        {
            StudentEditor theStudentEditor = new StudentEditor();

            if (theStudentEditor.ShowDialog() == DialogResult.OK)
            {
                if (studentMap.ContainsKey(theStudentEditor.resultInformation.ID))
                {
                    MessageBox.Show("学号与已有学生重复。\n无法添加此学生。", "添加失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Student theNewStudent = new Student(
                    theStudentEditor.resultInformation.Name,
                    theStudentEditor.resultInformation.ID,
                    theStudentEditor.resultInformation.Major,
                    theStudentEditor.resultInformation.Year,
                    theStudentEditor.resultInformation.Class,
                    theStudentEditor.resultInformation.Sex);

                AddNewStudent(theNewStudent);

                UpdateStudentTree();

                ClearTable();
                PushToTable(theNewStudent);
            }
            theStudentEditor.Dispose();
        }

        private void TableD1Delete_Click(object sender, EventArgs e)
        {
            if (StudentTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选择任何学生。", "删除失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult messageBoxResult = MessageBox.Show("确定要删除所选学生吗？\n这些数据将无法恢复。",
                "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (messageBoxResult == DialogResult.Yes)
            {
                foreach (ListViewItem studentItem in StudentTable.SelectedItems)
                {
                    RemoveStudent(studentMap[studentItem.Tag.ToString()]);
                }
                UpdateStudentTree();
                ClearTable();
            }
        }

        private void RefreshStudentTree_Click(object sender, EventArgs e)
        {
            UpdateStudentTree();
        }

        private bool InputScore(Student theStudent, Subject theSubject,
            int nowYear, int nowTerm, bool firstTime = true)
        {
            StudentScoreEditor theScoreEditor = new StudentScoreEditor(
                theStudent, theSubject, 
                theSubject.GetScore(nowYear, nowTerm),
                firstTime
            );

            theScoreEditor.UpdateScoreSettings();

            if (theScoreEditor.ShowDialog() == DialogResult.OK)
            {
                students[studentMap[theStudent.ID]]
                .FindSubjectWithName(theSubject.Name)
                .SetScore(nowYear, nowTerm, theScoreEditor.Score);
                return true;
            }
            else return false;
        }

        private void StudentTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewCell theCell = ListViewCellLocator.GetCell(StudentTable, e.X, e.Y);
            if (comboBoxYear.SelectedItem == null || comboBoxTerm.SelectedItem == null)
                return;

            int nowYear = Convert.ToInt32(comboBoxYear.SelectedItem.ToString())
                - students[studentMap[theCell.Item.Tag.ToString()]].Year + 1;
            int nowTerm = (comboBoxTerm.SelectedItem.ToString() == "一") ? 1 : 2;

            if (nowYear < 1 || nowYear > 4)
                return;

            Subject subjectOfTheStudent = students[studentMap[theCell.Item.Tag.ToString()]]
                .FindSubjectWithName(theCell.Column.Tag.ToString());

            if (subjectOfTheStudent == null ||
                !subjectOfTheStudent.GetCourseTime(nowYear, nowTerm))
                return;

            InputScore(students[studentMap[theCell.Item.Tag.ToString()]],
                students[studentMap[theCell.Item.Tag.ToString()]]
                .FindSubjectWithName(theCell.Column.Tag.ToString()),
                nowYear, nowTerm,
                !students[studentMap[theCell.Item.Tag.ToString()]]
                .FindSubjectWithName(theCell.Column.Tag.ToString()).ScoreEnable(nowYear, nowTerm));

            int itemIndex = StudentTable.Items.IndexOf(theCell.Item);
            ListViewItem _item = theCell.Item;
            StudentTable.Items.Remove(theCell.Item);
            PushToTable(students[studentMap[_item.Tag.ToString()]], itemIndex);
        }

        private void TableD1Entry_Click(object sender, EventArgs e)
        {
            if (StudentTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中任何学生", "无法录入成绩",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 该学生没有这一科目，或点击了不是科目的列
            foreach (ListViewItem stuItem in StudentTable.SelectedItems)
            {
                Student theStudent = students[studentMap[stuItem.Tag.ToString()]];

                int nowYear = Convert.ToInt32(comboBoxYear.SelectedItem.ToString())
                    - theStudent.Year + 1;
                int nowTerm = (comboBoxTerm.SelectedItem.ToString() == "一") ? 1 : 2;

                if (nowYear < 1 || nowYear > 4)
                    return;

                foreach (Subject theSubject in theStudent.ListSubjects())
                {
                    InputScore(theStudent, theSubject,
                        nowYear, nowTerm,
                        !theSubject.ScoreEnable(nowYear, nowTerm));
                }

                int itemIndex = StudentTable.Items.IndexOf(stuItem);
                StudentTable.Items.Remove(stuItem);
                PushToTable(theStudent, itemIndex);
            }
        }

        private void MSD1EditScore_Click(object sender, EventArgs e)
        {
            if (StudentTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中任何学生", "无法录入成绩",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 该学生没有这一科目，或点击了不是科目的列
            foreach (ListViewItem stuItem in StudentTable.SelectedItems)
            {
                Student theStudent = students[studentMap[stuItem.Tag.ToString()]];

                int nowYear = Convert.ToInt32(comboBoxYear.SelectedItem.ToString())
                    - theStudent.Year + 1;
                int nowTerm = (comboBoxTerm.SelectedItem.ToString() == "一") ? 1 : 2;

                if (nowYear < 1 || nowYear > 4)
                    return;

                foreach (Subject theSubject in theStudent.ListSubjects())
                {
                    InputScore(theStudent, theSubject,
                        nowYear, nowTerm,
                        !theSubject.ScoreEnable(nowYear, nowTerm));
                }

                int itemIndex = StudentTable.Items.IndexOf(stuItem);
                StudentTable.Items.Remove(stuItem);
                PushToTable(theStudent, itemIndex);
            }
        }

        private void MD1Reset_Click(object sender, EventArgs e)
        {
            students.Clear();
            ClearTable();
            StudentTree.Nodes.Clear();
        }

        private void MD1Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
