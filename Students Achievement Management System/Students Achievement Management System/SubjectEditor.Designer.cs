namespace Students_Achievement_Management_System
{
    partial class SubjectEditor
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
            this.SubjectTable = new System.Windows.Forms.ListView();
            this.SubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectAssessmentMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectCourseTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.RemoveSubjectButton = new System.Windows.Forms.Button();
            this.ApplyForAllStudents = new System.Windows.Forms.Button();
            this.ApplyForWholeMajor = new System.Windows.Forms.Button();
            this.ApplyForSeletedStudent = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectTable
            // 
            this.SubjectTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubjectName,
            this.SubjectAssessmentMode,
            this.SubjectCourseTime});
            this.SubjectTable.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubjectTable.FullRowSelect = true;
            this.SubjectTable.GridLines = true;
            this.SubjectTable.HideSelection = false;
            this.SubjectTable.Location = new System.Drawing.Point(13, 13);
            this.SubjectTable.Name = "SubjectTable";
            this.SubjectTable.Size = new System.Drawing.Size(551, 425);
            this.SubjectTable.TabIndex = 0;
            this.SubjectTable.UseCompatibleStateImageBehavior = false;
            this.SubjectTable.View = System.Windows.Forms.View.Details;
            // 
            // SubjectName
            // 
            this.SubjectName.Text = "科目名称";
            this.SubjectName.Width = 107;
            // 
            // SubjectAssessmentMode
            // 
            this.SubjectAssessmentMode.Text = "评分方式";
            this.SubjectAssessmentMode.Width = 107;
            // 
            // SubjectCourseTime
            // 
            this.SubjectCourseTime.Text = "课程时间";
            this.SubjectCourseTime.Width = 340;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddSubjectButton.Location = new System.Drawing.Point(570, 13);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(218, 46);
            this.AddSubjectButton.TabIndex = 1;
            this.AddSubjectButton.Text = "添加科目(&A)";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // RemoveSubjectButton
            // 
            this.RemoveSubjectButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RemoveSubjectButton.Location = new System.Drawing.Point(570, 118);
            this.RemoveSubjectButton.Name = "RemoveSubjectButton";
            this.RemoveSubjectButton.Size = new System.Drawing.Size(218, 47);
            this.RemoveSubjectButton.TabIndex = 2;
            this.RemoveSubjectButton.Text = "移除科目(&R)";
            this.RemoveSubjectButton.UseVisualStyleBackColor = true;
            this.RemoveSubjectButton.Click += new System.EventHandler(this.RemoveSubjectButton_Click);
            // 
            // ApplyForAllStudents
            // 
            this.ApplyForAllStudents.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ApplyForAllStudents.Location = new System.Drawing.Point(570, 391);
            this.ApplyForAllStudents.Name = "ApplyForAllStudents";
            this.ApplyForAllStudents.Size = new System.Drawing.Size(218, 47);
            this.ApplyForAllStudents.TabIndex = 3;
            this.ApplyForAllStudents.Text = "应用于所有学生(&P)";
            this.ApplyForAllStudents.UseVisualStyleBackColor = true;
            this.ApplyForAllStudents.Click += new System.EventHandler(this.ApplyForAllStudents_Click);
            // 
            // ApplyForWholeMajor
            // 
            this.ApplyForWholeMajor.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ApplyForWholeMajor.Location = new System.Drawing.Point(570, 338);
            this.ApplyForWholeMajor.Name = "ApplyForWholeMajor";
            this.ApplyForWholeMajor.Size = new System.Drawing.Size(218, 47);
            this.ApplyForWholeMajor.TabIndex = 4;
            this.ApplyForWholeMajor.Text = "应用于全专业(&O)";
            this.ApplyForWholeMajor.UseVisualStyleBackColor = true;
            this.ApplyForWholeMajor.Click += new System.EventHandler(this.ApplyForWholeMajor_Click);
            // 
            // ApplyForSeletedStudent
            // 
            this.ApplyForSeletedStudent.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ApplyForSeletedStudent.Location = new System.Drawing.Point(570, 285);
            this.ApplyForSeletedStudent.Name = "ApplyForSeletedStudent";
            this.ApplyForSeletedStudent.Size = new System.Drawing.Size(218, 47);
            this.ApplyForSeletedStudent.TabIndex = 5;
            this.ApplyForSeletedStudent.Text = "应用于选中学生(&I)";
            this.ApplyForSeletedStudent.UseVisualStyleBackColor = true;
            this.ApplyForSeletedStudent.Click += new System.EventHandler(this.ApplyForSeletedStudent_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelButton.Location = new System.Drawing.Point(570, 232);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(218, 47);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "不应用(&C)";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditSubjectButton
            // 
            this.EditSubjectButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EditSubjectButton.Location = new System.Drawing.Point(570, 65);
            this.EditSubjectButton.Name = "EditSubjectButton";
            this.EditSubjectButton.Size = new System.Drawing.Size(218, 47);
            this.EditSubjectButton.TabIndex = 7;
            this.EditSubjectButton.Text = "编辑科目(&E)";
            this.EditSubjectButton.UseVisualStyleBackColor = true;
            this.EditSubjectButton.Click += new System.EventHandler(this.EditSubjectButton_Click);
            // 
            // SubjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditSubjectButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyForSeletedStudent);
            this.Controls.Add(this.ApplyForWholeMajor);
            this.Controls.Add(this.ApplyForAllStudents);
            this.Controls.Add(this.RemoveSubjectButton);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.SubjectTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "科目编辑器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView SubjectTable;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Button RemoveSubjectButton;
        private System.Windows.Forms.ColumnHeader SubjectName;
        private System.Windows.Forms.Button ApplyForAllStudents;
        private System.Windows.Forms.Button ApplyForWholeMajor;
        private System.Windows.Forms.Button ApplyForSeletedStudent;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditSubjectButton;
        private System.Windows.Forms.ColumnHeader SubjectAssessmentMode;
        private System.Windows.Forms.ColumnHeader SubjectCourseTime;
    }
}