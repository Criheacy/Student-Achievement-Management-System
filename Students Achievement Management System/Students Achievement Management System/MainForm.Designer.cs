namespace Students_Achievement_Management_System
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1New = new System.Windows.Forms.ToolStripMenuItem();
            this.MD2StudentDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1S1 = new System.Windows.Forms.ToolStripSeparator();
            this.MD1Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1S3 = new System.Windows.Forms.ToolStripSeparator();
            this.MD1Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1S4 = new System.Windows.Forms.ToolStripSeparator();
            this.MD1Inport = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftExcel工作簿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文本文档TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1Export = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1S5 = new System.Windows.Forms.ToolStripSeparator();
            this.MD1Close = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.MD1S6 = new System.Windows.Forms.ToolStripSeparator();
            this.MD1Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑科目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSD1Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MSD1EditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.MSD1RemoveStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.MSD1S1 = new System.Windows.Forms.ToolStripSeparator();
            this.MSD1EditScore = new System.Windows.Forms.ToolStripMenuItem();
            this.MSD1EditScores = new System.Windows.Forms.ToolStripMenuItem();
            this.MSD1S2 = new System.Windows.Forms.ToolStripSeparator();
            this.MSD1ImportScore = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩数据包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel工作簿EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSD1S3 = new System.Windows.Forms.ToolStripSeparator();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.TreePage = new System.Windows.Forms.TabPage();
            this.StudentTree = new System.Windows.Forms.TreeView();
            this.TreeMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshStudentTree = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPage = new System.Windows.Forms.TabPage();
            this.EnableAdvancedSearch = new System.Windows.Forms.CheckBox();
            this.AdvancedSearchFrame = new System.Windows.Forms.GroupBox();
            this.AS_ShowGraduatedStudents = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchKeyText = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NALock = new System.Windows.Forms.CheckBox();
            this.StudentTable = new System.Windows.Forms.ListView();
            this.stuID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stuClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TableD1Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TableD1S1 = new System.Windows.Forms.ToolStripSeparator();
            this.TableD1EditInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.TableD1EditSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.TableD1Entry = new System.Windows.Forms.ToolStripMenuItem();
            this.TableD1S2 = new System.Windows.Forms.ToolStripSeparator();
            this.TableD1Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOnlyLock = new System.Windows.Forms.CheckBox();
            this.ListLock = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.InportExcelDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveJsonDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenJsonDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.TreePage.SuspendLayout();
            this.TreeMenuStrip.SuspendLayout();
            this.SearchPage.SuspendLayout();
            this.AdvancedSearchFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TableMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.学生SToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(1015, 30);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MD1New,
            this.MD1S1,
            this.MD1Open,
            this.MD1S3,
            this.MD1Save,
            this.MD1SaveAs,
            this.MD1S4,
            this.MD1Inport,
            this.MD1Export,
            this.MD1S5,
            this.MD1Close,
            this.MD1Reset,
            this.MD1S6,
            this.MD1Exit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // MD1New
            // 
            this.MD1New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MD2StudentDatabase});
            this.MD1New.Name = "MD1New";
            this.MD1New.Size = new System.Drawing.Size(224, 26);
            this.MD1New.Text = "新建(&N)";
            // 
            // MD2StudentDatabase
            // 
            this.MD2StudentDatabase.Name = "MD2StudentDatabase";
            this.MD2StudentDatabase.Size = new System.Drawing.Size(188, 26);
            this.MD2StudentDatabase.Text = "学生数据库(D)";
            // 
            // MD1S1
            // 
            this.MD1S1.Name = "MD1S1";
            this.MD1S1.Size = new System.Drawing.Size(221, 6);
            // 
            // MD1Open
            // 
            this.MD1Open.Name = "MD1Open";
            this.MD1Open.Size = new System.Drawing.Size(224, 26);
            this.MD1Open.Text = "打开(&O)";
            // 
            // MD1S3
            // 
            this.MD1S3.Name = "MD1S3";
            this.MD1S3.Size = new System.Drawing.Size(221, 6);
            // 
            // MD1Save
            // 
            this.MD1Save.Name = "MD1Save";
            this.MD1Save.Size = new System.Drawing.Size(224, 26);
            this.MD1Save.Text = "保存(&S)";
            this.MD1Save.Click += new System.EventHandler(this.SaveJsonByButton);
            // 
            // MD1SaveAs
            // 
            this.MD1SaveAs.Name = "MD1SaveAs";
            this.MD1SaveAs.Size = new System.Drawing.Size(224, 26);
            this.MD1SaveAs.Text = "另存为...";
            // 
            // MD1S4
            // 
            this.MD1S4.Name = "MD1S4";
            this.MD1S4.Size = new System.Drawing.Size(221, 6);
            // 
            // MD1Inport
            // 
            this.MD1Inport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftExcel工作簿ToolStripMenuItem,
            this.文本文档TToolStripMenuItem});
            this.MD1Inport.Name = "MD1Inport";
            this.MD1Inport.Size = new System.Drawing.Size(224, 26);
            this.MD1Inport.Text = "导入(&I)";
            // 
            // microsoftExcel工作簿ToolStripMenuItem
            // 
            this.microsoftExcel工作簿ToolStripMenuItem.Name = "microsoftExcel工作簿ToolStripMenuItem";
            this.microsoftExcel工作簿ToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.microsoftExcel工作簿ToolStripMenuItem.Text = "Excel 工作簿(E)...";
            this.microsoftExcel工作簿ToolStripMenuItem.Click += new System.EventHandler(this.LoadExcelByButton);
            // 
            // 文本文档TToolStripMenuItem
            // 
            this.文本文档TToolStripMenuItem.Name = "文本文档TToolStripMenuItem";
            this.文本文档TToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.文本文档TToolStripMenuItem.Text = "文本文档(T)...";
            // 
            // MD1Export
            // 
            this.MD1Export.Name = "MD1Export";
            this.MD1Export.Size = new System.Drawing.Size(224, 26);
            this.MD1Export.Text = "导出(&E)";
            // 
            // MD1S5
            // 
            this.MD1S5.Name = "MD1S5";
            this.MD1S5.Size = new System.Drawing.Size(221, 6);
            // 
            // MD1Close
            // 
            this.MD1Close.Name = "MD1Close";
            this.MD1Close.Size = new System.Drawing.Size(224, 26);
            this.MD1Close.Text = "关闭当前项目(&C)";
            // 
            // MD1Reset
            // 
            this.MD1Reset.Name = "MD1Reset";
            this.MD1Reset.Size = new System.Drawing.Size(224, 26);
            this.MD1Reset.Text = "重置学生数据库";
            this.MD1Reset.Click += new System.EventHandler(this.MD1Reset_Click);
            // 
            // MD1S6
            // 
            this.MD1S6.Name = "MD1S6";
            this.MD1S6.Size = new System.Drawing.Size(221, 6);
            // 
            // MD1Exit
            // 
            this.MD1Exit.Name = "MD1Exit";
            this.MD1Exit.Size = new System.Drawing.Size(224, 26);
            this.MD1Exit.Text = "退出(&E)";
            this.MD1Exit.Click += new System.EventHandler(this.MD1Exit_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑科目ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.编辑EToolStripMenuItem.Text = "科目(&E)";
            // 
            // 编辑科目ToolStripMenuItem
            // 
            this.编辑科目ToolStripMenuItem.Name = "编辑科目ToolStripMenuItem";
            this.编辑科目ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.编辑科目ToolStripMenuItem.Text = "科目编辑器...";
            this.编辑科目ToolStripMenuItem.Click += new System.EventHandler(this.ShowSubjectEditor);
            // 
            // 学生SToolStripMenuItem
            // 
            this.学生SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSD1Add,
            this.MSD1EditStudent,
            this.MSD1RemoveStudent,
            this.MSD1S1,
            this.MSD1EditScore,
            this.MSD1EditScores,
            this.MSD1S2,
            this.MSD1ImportScore,
            this.MSD1S3});
            this.学生SToolStripMenuItem.Name = "学生SToolStripMenuItem";
            this.学生SToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.学生SToolStripMenuItem.Text = "学生(&S)";
            // 
            // MSD1Add
            // 
            this.MSD1Add.Name = "MSD1Add";
            this.MSD1Add.Size = new System.Drawing.Size(224, 26);
            this.MSD1Add.Text = "添加新学生...";
            this.MSD1Add.Click += new System.EventHandler(this.AddStudentInformation_Click);
            // 
            // MSD1EditStudent
            // 
            this.MSD1EditStudent.Name = "MSD1EditStudent";
            this.MSD1EditStudent.Size = new System.Drawing.Size(224, 26);
            this.MSD1EditStudent.Text = "编辑基本信息...";
            this.MSD1EditStudent.Click += new System.EventHandler(this.EditStudentsInformation_Click);
            // 
            // MSD1RemoveStudent
            // 
            this.MSD1RemoveStudent.Name = "MSD1RemoveStudent";
            this.MSD1RemoveStudent.Size = new System.Drawing.Size(224, 26);
            this.MSD1RemoveStudent.Text = "删除学生";
            // 
            // MSD1S1
            // 
            this.MSD1S1.Name = "MSD1S1";
            this.MSD1S1.Size = new System.Drawing.Size(221, 6);
            // 
            // MSD1EditScore
            // 
            this.MSD1EditScore.Name = "MSD1EditScore";
            this.MSD1EditScore.Size = new System.Drawing.Size(224, 26);
            this.MSD1EditScore.Text = "编辑成绩...";
            this.MSD1EditScore.Click += new System.EventHandler(this.MSD1EditScore_Click);
            // 
            // MSD1EditScores
            // 
            this.MSD1EditScores.Name = "MSD1EditScores";
            this.MSD1EditScores.Size = new System.Drawing.Size(224, 26);
            this.MSD1EditScores.Text = "批量编辑成绩...";
            // 
            // MSD1S2
            // 
            this.MSD1S2.Name = "MSD1S2";
            this.MSD1S2.Size = new System.Drawing.Size(221, 6);
            // 
            // MSD1ImportScore
            // 
            this.MSD1ImportScore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩数据包ToolStripMenuItem,
            this.excel工作簿EToolStripMenuItem});
            this.MSD1ImportScore.Name = "MSD1ImportScore";
            this.MSD1ImportScore.Size = new System.Drawing.Size(224, 26);
            this.MSD1ImportScore.Text = "导入外部成绩文件";
            // 
            // 成绩数据包ToolStripMenuItem
            // 
            this.成绩数据包ToolStripMenuItem.Name = "成绩数据包ToolStripMenuItem";
            this.成绩数据包ToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.成绩数据包ToolStripMenuItem.Text = "成绩数据包(&P)...";
            // 
            // excel工作簿EToolStripMenuItem
            // 
            this.excel工作簿EToolStripMenuItem.Name = "excel工作簿EToolStripMenuItem";
            this.excel工作簿EToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.excel工作簿EToolStripMenuItem.Text = "Excel 工作簿(&E)...";
            // 
            // MSD1S3
            // 
            this.MSD1S3.Name = "MSD1S3";
            this.MSD1S3.Size = new System.Drawing.Size(221, 6);
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.TreePage);
            this.TabPage.Controls.Add(this.SearchPage);
            this.TabPage.Location = new System.Drawing.Point(4, 3);
            this.TabPage.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(380, 638);
            this.TabPage.TabIndex = 2;
            this.TabPage.TabStop = false;
            // 
            // TreePage
            // 
            this.TreePage.Controls.Add(this.StudentTree);
            this.TreePage.Location = new System.Drawing.Point(4, 28);
            this.TreePage.Margin = new System.Windows.Forms.Padding(4);
            this.TreePage.Name = "TreePage";
            this.TreePage.Padding = new System.Windows.Forms.Padding(4);
            this.TreePage.Size = new System.Drawing.Size(372, 606);
            this.TreePage.TabIndex = 0;
            this.TreePage.Text = "层级列表";
            this.TreePage.UseVisualStyleBackColor = true;
            // 
            // StudentTree
            // 
            this.StudentTree.ContextMenuStrip = this.TreeMenuStrip;
            this.StudentTree.Location = new System.Drawing.Point(8, 8);
            this.StudentTree.Margin = new System.Windows.Forms.Padding(4);
            this.StudentTree.Name = "StudentTree";
            this.StudentTree.Size = new System.Drawing.Size(356, 590);
            this.StudentTree.TabIndex = 0;
            this.StudentTree.TabStop = false;
            this.StudentTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.StudentTree_AfterSelect);
            // 
            // TreeMenuStrip
            // 
            this.TreeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TreeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshStudentTree});
            this.TreeMenuStrip.Name = "TreeMenuStrip";
            this.TreeMenuStrip.Size = new System.Drawing.Size(109, 28);
            // 
            // RefreshStudentTree
            // 
            this.RefreshStudentTree.Name = "RefreshStudentTree";
            this.RefreshStudentTree.Size = new System.Drawing.Size(108, 24);
            this.RefreshStudentTree.Text = "刷新";
            this.RefreshStudentTree.Click += new System.EventHandler(this.RefreshStudentTree_Click);
            // 
            // SearchPage
            // 
            this.SearchPage.Controls.Add(this.EnableAdvancedSearch);
            this.SearchPage.Controls.Add(this.AdvancedSearchFrame);
            this.SearchPage.Controls.Add(this.SearchButton);
            this.SearchPage.Controls.Add(this.SearchKeyText);
            this.SearchPage.Location = new System.Drawing.Point(4, 25);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchPage.Size = new System.Drawing.Size(372, 609);
            this.SearchPage.TabIndex = 1;
            this.SearchPage.Text = "查找";
            this.SearchPage.UseVisualStyleBackColor = true;
            // 
            // EnableAdvancedSearch
            // 
            this.EnableAdvancedSearch.AutoSize = true;
            this.EnableAdvancedSearch.Location = new System.Drawing.Point(7, 43);
            this.EnableAdvancedSearch.Name = "EnableAdvancedSearch";
            this.EnableAdvancedSearch.Size = new System.Drawing.Size(145, 23);
            this.EnableAdvancedSearch.TabIndex = 3;
            this.EnableAdvancedSearch.Text = "启用高级查找";
            this.EnableAdvancedSearch.UseVisualStyleBackColor = true;
            this.EnableAdvancedSearch.CheckedChanged += new System.EventHandler(this.EnableAdvancedSearch_CheckedChanged);
            // 
            // AdvancedSearchFrame
            // 
            this.AdvancedSearchFrame.Controls.Add(this.AS_ShowGraduatedStudents);
            this.AdvancedSearchFrame.Enabled = false;
            this.AdvancedSearchFrame.Location = new System.Drawing.Point(7, 72);
            this.AdvancedSearchFrame.Name = "AdvancedSearchFrame";
            this.AdvancedSearchFrame.Size = new System.Drawing.Size(352, 426);
            this.AdvancedSearchFrame.TabIndex = 2;
            this.AdvancedSearchFrame.TabStop = false;
            this.AdvancedSearchFrame.Text = "高级选项";
            // 
            // AS_ShowGraduatedStudents
            // 
            this.AS_ShowGraduatedStudents.AutoSize = true;
            this.AS_ShowGraduatedStudents.Location = new System.Drawing.Point(7, 28);
            this.AS_ShowGraduatedStudents.Name = "AS_ShowGraduatedStudents";
            this.AS_ShowGraduatedStudents.Size = new System.Drawing.Size(164, 23);
            this.AS_ShowGraduatedStudents.TabIndex = 0;
            this.AS_ShowGraduatedStudents.TabStop = false;
            this.AS_ShowGraduatedStudents.Text = "显示已离校学生";
            this.AS_ShowGraduatedStudents.ThreeState = true;
            this.AS_ShowGraduatedStudents.UseVisualStyleBackColor = true;
            this.AS_ShowGraduatedStudents.CheckedChanged += new System.EventHandler(this.AS_ShowGraduatedStudents_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(294, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(65, 29);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "查找";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchKeyText
            // 
            this.SearchKeyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchKeyText.Location = new System.Drawing.Point(7, 8);
            this.SearchKeyText.Name = "SearchKeyText";
            this.SearchKeyText.Size = new System.Drawing.Size(281, 28);
            this.SearchKeyText.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TabPage);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NALock);
            this.splitContainer1.Panel2.Controls.Add(this.StudentTable);
            this.splitContainer1.Panel2.Controls.Add(this.AddOnlyLock);
            this.splitContainer1.Panel2.Controls.Add(this.ListLock);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTerm);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxYear);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(991, 646);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.TabStop = false;
            // 
            // NALock
            // 
            this.NALock.AutoSize = true;
            this.NALock.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NALock.Location = new System.Drawing.Point(120, 5);
            this.NALock.Name = "NALock";
            this.NALock.Size = new System.Drawing.Size(76, 29);
            this.NALock.TabIndex = 7;
            this.NALock.TabStop = false;
            this.NALock.Text = " N/A";
            this.NALock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NALock.UseVisualStyleBackColor = true;
            this.NALock.CheckedChanged += new System.EventHandler(this.NALock_CheckedChanged);
            // 
            // StudentTable
            // 
            this.StudentTable.AllowColumnReorder = true;
            this.StudentTable.AllowDrop = true;
            this.StudentTable.BackColor = System.Drawing.Color.White;
            this.StudentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stuID,
            this.stuName,
            this.stuClass});
            this.StudentTable.ContextMenuStrip = this.TableMenuStrip;
            this.StudentTable.FullRowSelect = true;
            this.StudentTable.GridLines = true;
            this.StudentTable.HideSelection = false;
            this.StudentTable.Location = new System.Drawing.Point(3, 39);
            this.StudentTable.Name = "StudentTable";
            this.StudentTable.Size = new System.Drawing.Size(593, 598);
            this.StudentTable.TabIndex = 0;
            this.StudentTable.UseCompatibleStateImageBehavior = false;
            this.StudentTable.View = System.Windows.Forms.View.Details;
            this.StudentTable.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.StudentTable_ColumnClick);
            this.StudentTable.Leave += new System.EventHandler(this.StudentTable_Leave);
            this.StudentTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StudentTable_MouseDoubleClick);
            // 
            // stuID
            // 
            this.stuID.Tag = "学号";
            this.stuID.Text = "学号";
            this.stuID.Width = 164;
            // 
            // stuName
            // 
            this.stuName.Tag = "姓名";
            this.stuName.Text = "姓名";
            this.stuName.Width = 107;
            // 
            // stuClass
            // 
            this.stuClass.Tag = "学院班级";
            this.stuClass.Text = "学院班级";
            this.stuClass.Width = 92;
            // 
            // TableMenuStrip
            // 
            this.TableMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TableMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TableD1Add,
            this.TableD1S1,
            this.TableD1EditInformation,
            this.TableD1EditSubject,
            this.TableD1Entry,
            this.TableD1S2,
            this.TableD1Delete});
            this.TableMenuStrip.Name = "TableMenuStrip";
            this.TableMenuStrip.Size = new System.Drawing.Size(187, 136);
            // 
            // TableD1Add
            // 
            this.TableD1Add.Name = "TableD1Add";
            this.TableD1Add.Size = new System.Drawing.Size(186, 24);
            this.TableD1Add.Text = "添加新学生(&A)...";
            this.TableD1Add.Click += new System.EventHandler(this.AddStudentInformation_Click);
            // 
            // TableD1S1
            // 
            this.TableD1S1.Name = "TableD1S1";
            this.TableD1S1.Size = new System.Drawing.Size(183, 6);
            // 
            // TableD1EditInformation
            // 
            this.TableD1EditInformation.Name = "TableD1EditInformation";
            this.TableD1EditInformation.Size = new System.Drawing.Size(186, 24);
            this.TableD1EditInformation.Text = "编辑信息(E)...";
            this.TableD1EditInformation.Click += new System.EventHandler(this.EditStudentsInformation_Click);
            // 
            // TableD1EditSubject
            // 
            this.TableD1EditSubject.Name = "TableD1EditSubject";
            this.TableD1EditSubject.Size = new System.Drawing.Size(186, 24);
            this.TableD1EditSubject.Text = "编辑科目(&S)...";
            this.TableD1EditSubject.Click += new System.EventHandler(this.ShowSubjectEditor);
            // 
            // TableD1Entry
            // 
            this.TableD1Entry.Name = "TableD1Entry";
            this.TableD1Entry.Size = new System.Drawing.Size(186, 24);
            this.TableD1Entry.Text = "录入成绩(&I)...";
            this.TableD1Entry.Click += new System.EventHandler(this.TableD1Entry_Click);
            // 
            // TableD1S2
            // 
            this.TableD1S2.Name = "TableD1S2";
            this.TableD1S2.Size = new System.Drawing.Size(183, 6);
            // 
            // TableD1Delete
            // 
            this.TableD1Delete.Name = "TableD1Delete";
            this.TableD1Delete.Size = new System.Drawing.Size(186, 24);
            this.TableD1Delete.Text = "删除学生(&D)";
            this.TableD1Delete.Click += new System.EventHandler(this.TableD1Delete_Click);
            // 
            // AddOnlyLock
            // 
            this.AddOnlyLock.AutoSize = true;
            this.AddOnlyLock.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddOnlyLock.Image = ((System.Drawing.Image)(resources.GetObject("AddOnlyLock.Image")));
            this.AddOnlyLock.Location = new System.Drawing.Point(64, 0);
            this.AddOnlyLock.Name = "AddOnlyLock";
            this.AddOnlyLock.Size = new System.Drawing.Size(81, 42);
            this.AddOnlyLock.TabIndex = 6;
            this.AddOnlyLock.TabStop = false;
            this.AddOnlyLock.Text = " ";
            this.AddOnlyLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddOnlyLock.UseVisualStyleBackColor = true;
            this.AddOnlyLock.CheckedChanged += new System.EventHandler(this.AddOnlyLock_CheckedChanged);
            // 
            // ListLock
            // 
            this.ListLock.AutoSize = true;
            this.ListLock.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListLock.Image = ((System.Drawing.Image)(resources.GetObject("ListLock.Image")));
            this.ListLock.Location = new System.Drawing.Point(12, 0);
            this.ListLock.Name = "ListLock";
            this.ListLock.Size = new System.Drawing.Size(81, 42);
            this.ListLock.TabIndex = 5;
            this.ListLock.TabStop = false;
            this.ListLock.Text = " ";
            this.ListLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ListLock.UseVisualStyleBackColor = true;
            this.ListLock.CheckedChanged += new System.EventHandler(this.ListLock_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "学期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "年   第";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Items.AddRange(new object[] {
            "一",
            "二"});
            this.comboBoxTerm.Location = new System.Drawing.Point(485, 7);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(53, 26);
            this.comboBoxTerm.TabIndex = 2;
            this.comboBoxTerm.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBoxTerm.TextUpdate += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.comboBoxYear.Location = new System.Drawing.Point(305, 7);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(91, 26);
            this.comboBoxYear.TabIndex = 1;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBoxYear.TextUpdate += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // InportExcelDialog
            // 
            this.InportExcelDialog.DefaultExt = "xlsx";
            this.InportExcelDialog.Filter = "Excel文件|*.xlsx";
            this.InportExcelDialog.Title = "导入学生名单Excel文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(784, 692);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Made By C6H12O6 @ SDU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(12, 692);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version 1.0";
            // 
            // SaveJsonDialog
            // 
            this.SaveJsonDialog.DefaultExt = "json";
            this.SaveJsonDialog.Filter = "JSON文件|*.json";
            // 
            // OpenJsonDialog
            // 
            this.OpenJsonDialog.Filter = "json文件|*.json";
            this.OpenJsonDialog.Title = "打开json文件";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩管理系统 V1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabPage.ResumeLayout(false);
            this.TreePage.ResumeLayout(false);
            this.TreeMenuStrip.ResumeLayout(false);
            this.SearchPage.ResumeLayout(false);
            this.SearchPage.PerformLayout();
            this.AdvancedSearchFrame.ResumeLayout(false);
            this.AdvancedSearchFrame.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TableMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MD1New;
        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage TreePage;
        private System.Windows.Forms.TreeView StudentTree;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView StudentTable;
        private System.Windows.Forms.TabPage SearchPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑科目ToolStripMenuItem;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchKeyText;
        private System.Windows.Forms.CheckBox EnableAdvancedSearch;
        private System.Windows.Forms.GroupBox AdvancedSearchFrame;
        private System.Windows.Forms.CheckBox AS_ShowGraduatedStudents;
        private System.Windows.Forms.ToolStripMenuItem MD2StudentDatabase;
        private System.Windows.Forms.ToolStripSeparator MD1S1;
        private System.Windows.Forms.ToolStripMenuItem MD1Open;
        private System.Windows.Forms.ToolStripSeparator MD1S3;
        private System.Windows.Forms.ToolStripMenuItem MD1Save;
        private System.Windows.Forms.ToolStripMenuItem MD1SaveAs;
        private System.Windows.Forms.ToolStripSeparator MD1S4;
        private System.Windows.Forms.ToolStripMenuItem MD1Inport;
        private System.Windows.Forms.ToolStripMenuItem MD1Export;
        private System.Windows.Forms.ToolStripSeparator MD1S5;
        private System.Windows.Forms.ToolStripMenuItem MD1Close;
        private System.Windows.Forms.ToolStripSeparator MD1S6;
        private System.Windows.Forms.ToolStripMenuItem MD1Exit;
        private System.Windows.Forms.OpenFileDialog InportExcelDialog;
        private System.Windows.Forms.ToolStripMenuItem microsoftExcel工作簿ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文本文档TToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader stuID;
        private System.Windows.Forms.ColumnHeader stuName;
        private System.Windows.Forms.ColumnHeader stuClass;
        private System.Windows.Forms.CheckBox ListLock;
        private System.Windows.Forms.ContextMenuStrip TableMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TableD1Add;
        private System.Windows.Forms.ToolStripSeparator TableD1S1;
        private System.Windows.Forms.ToolStripMenuItem TableD1EditInformation;
        private System.Windows.Forms.ToolStripMenuItem TableD1Entry;
        private System.Windows.Forms.ToolStripSeparator TableD1S2;
        private System.Windows.Forms.ToolStripMenuItem TableD1Delete;
        private System.Windows.Forms.CheckBox AddOnlyLock;
        private System.Windows.Forms.ToolStripMenuItem 学生SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSD1EditStudent;
        private System.Windows.Forms.ToolStripMenuItem MSD1RemoveStudent;
        private System.Windows.Forms.ToolStripSeparator MSD1S1;
        private System.Windows.Forms.ToolStripMenuItem MSD1EditScore;
        private System.Windows.Forms.ToolStripMenuItem MSD1EditScores;
        private System.Windows.Forms.ToolStripSeparator MSD1S2;
        private System.Windows.Forms.ToolStripMenuItem MSD1ImportScore;
        private System.Windows.Forms.ToolStripMenuItem 成绩数据包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel工作簿EToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator MSD1S3;
        private System.Windows.Forms.ToolStripMenuItem MSD1Add;
        private System.Windows.Forms.ToolStripMenuItem MD1Reset;
        private System.Windows.Forms.ContextMenuStrip TreeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RefreshStudentTree;
        private System.Windows.Forms.ToolStripMenuItem TableD1EditSubject;
        private System.Windows.Forms.CheckBox NALock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog SaveJsonDialog;
        private System.Windows.Forms.OpenFileDialog OpenJsonDialog;
    }
}