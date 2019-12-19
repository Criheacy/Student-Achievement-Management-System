namespace Students_Achievement_Management_System
{
    partial class SubjectEditor_EditSubject
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
            this.ES_AcceptButton = new System.Windows.Forms.Button();
            this.ES_CancelButton = new System.Windows.Forms.Button();
            this.ES_SubjectName = new System.Windows.Forms.TextBox();
            this.ES_SubjectNameLabel = new System.Windows.Forms.Label();
            this.ES_AssessmentModeGroup = new System.Windows.Forms.GroupBox();
            this.ES_WhenAssessmodeByScoreGroup = new System.Windows.Forms.GroupBox();
            this.ES_FullMarkLabel = new System.Windows.Forms.Label();
            this.ES_PassLine = new System.Windows.Forms.TextBox();
            this.ES_SetPassLineCheck = new System.Windows.Forms.CheckBox();
            this.ES_FullMark = new System.Windows.Forms.TextBox();
            this.ES_RoundCheck = new System.Windows.Forms.CheckBox();
            this.ES_AssessmentModeByScoreButton = new System.Windows.Forms.RadioButton();
            this.ES_AssessmentModeByGradeButton = new System.Windows.Forms.RadioButton();
            this.ES_AssessmentModeByPassButton = new System.Windows.Forms.RadioButton();
            this.ES_AssessmentModeNoneButton = new System.Windows.Forms.RadioButton();
            this.ES_CourseTimeGroup = new System.Windows.Forms.GroupBox();
            this.ES_CourseTimePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ES_Senior = new System.Windows.Forms.Label();
            this.Senior2 = new System.Windows.Forms.CheckBox();
            this.ES_Sophomore = new System.Windows.Forms.Label();
            this.Junior2 = new System.Windows.Forms.CheckBox();
            this.ES_Junior = new System.Windows.Forms.Label();
            this.Sophomore2 = new System.Windows.Forms.CheckBox();
            this.ES_FirstTerm = new System.Windows.Forms.Label();
            this.Freshman2 = new System.Windows.Forms.CheckBox();
            this.ES_SecondTerm = new System.Windows.Forms.Label();
            this.ES_Freshman = new System.Windows.Forms.Label();
            this.Senior1 = new System.Windows.Forms.CheckBox();
            this.Freshman1 = new System.Windows.Forms.CheckBox();
            this.Sophomore1 = new System.Windows.Forms.CheckBox();
            this.Junior1 = new System.Windows.Forms.CheckBox();
            this.ES_AttributeGroup = new System.Windows.Forms.GroupBox();
            this.ES_AssessmentModeGroup.SuspendLayout();
            this.ES_WhenAssessmodeByScoreGroup.SuspendLayout();
            this.ES_CourseTimeGroup.SuspendLayout();
            this.ES_CourseTimePanel.SuspendLayout();
            this.ES_AttributeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ES_AcceptButton
            // 
            this.ES_AcceptButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ES_AcceptButton.Location = new System.Drawing.Point(316, 391);
            this.ES_AcceptButton.Name = "ES_AcceptButton";
            this.ES_AcceptButton.Size = new System.Drawing.Size(102, 36);
            this.ES_AcceptButton.TabIndex = 1;
            this.ES_AcceptButton.Text = "确认(&A)";
            this.ES_AcceptButton.UseVisualStyleBackColor = true;
            this.ES_AcceptButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ES_CancelButton
            // 
            this.ES_CancelButton.Location = new System.Drawing.Point(200, 391);
            this.ES_CancelButton.Name = "ES_CancelButton";
            this.ES_CancelButton.Size = new System.Drawing.Size(102, 36);
            this.ES_CancelButton.TabIndex = 2;
            this.ES_CancelButton.Text = "取消(&C)";
            this.ES_CancelButton.UseVisualStyleBackColor = true;
            this.ES_CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ES_SubjectName
            // 
            this.ES_SubjectName.Location = new System.Drawing.Point(97, 25);
            this.ES_SubjectName.Name = "ES_SubjectName";
            this.ES_SubjectName.Size = new System.Drawing.Size(291, 28);
            this.ES_SubjectName.TabIndex = 1;
            // 
            // ES_SubjectNameLabel
            // 
            this.ES_SubjectNameLabel.AutoSize = true;
            this.ES_SubjectNameLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ES_SubjectNameLabel.Location = new System.Drawing.Point(6, 28);
            this.ES_SubjectNameLabel.Name = "ES_SubjectNameLabel";
            this.ES_SubjectNameLabel.Size = new System.Drawing.Size(85, 19);
            this.ES_SubjectNameLabel.TabIndex = 0;
            this.ES_SubjectNameLabel.Text = "科目名称";
            // 
            // ES_AssessmentModeGroup
            // 
            this.ES_AssessmentModeGroup.Controls.Add(this.ES_WhenAssessmodeByScoreGroup);
            this.ES_AssessmentModeGroup.Controls.Add(this.ES_AssessmentModeByScoreButton);
            this.ES_AssessmentModeGroup.Controls.Add(this.ES_AssessmentModeByGradeButton);
            this.ES_AssessmentModeGroup.Controls.Add(this.ES_AssessmentModeByPassButton);
            this.ES_AssessmentModeGroup.Controls.Add(this.ES_AssessmentModeNoneButton);
            this.ES_AssessmentModeGroup.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ES_AssessmentModeGroup.Location = new System.Drawing.Point(13, 84);
            this.ES_AssessmentModeGroup.Name = "ES_AssessmentModeGroup";
            this.ES_AssessmentModeGroup.Size = new System.Drawing.Size(408, 155);
            this.ES_AssessmentModeGroup.TabIndex = 6;
            this.ES_AssessmentModeGroup.TabStop = false;
            this.ES_AssessmentModeGroup.Text = "评分标准";
            // 
            // ES_WhenAssessmodeByScoreGroup
            // 
            this.ES_WhenAssessmodeByScoreGroup.Controls.Add(this.ES_FullMarkLabel);
            this.ES_WhenAssessmodeByScoreGroup.Controls.Add(this.ES_PassLine);
            this.ES_WhenAssessmodeByScoreGroup.Controls.Add(this.ES_SetPassLineCheck);
            this.ES_WhenAssessmodeByScoreGroup.Controls.Add(this.ES_FullMark);
            this.ES_WhenAssessmodeByScoreGroup.Controls.Add(this.ES_RoundCheck);
            this.ES_WhenAssessmodeByScoreGroup.Enabled = false;
            this.ES_WhenAssessmodeByScoreGroup.Location = new System.Drawing.Point(179, 21);
            this.ES_WhenAssessmodeByScoreGroup.Name = "ES_WhenAssessmodeByScoreGroup";
            this.ES_WhenAssessmodeByScoreGroup.Size = new System.Drawing.Size(223, 122);
            this.ES_WhenAssessmodeByScoreGroup.TabIndex = 4;
            this.ES_WhenAssessmodeByScoreGroup.TabStop = false;
            this.ES_WhenAssessmodeByScoreGroup.Text = "按分数评分时：";
            // 
            // ES_FullMarkLabel
            // 
            this.ES_FullMarkLabel.AutoSize = true;
            this.ES_FullMarkLabel.Location = new System.Drawing.Point(11, 29);
            this.ES_FullMarkLabel.Name = "ES_FullMarkLabel";
            this.ES_FullMarkLabel.Size = new System.Drawing.Size(104, 19);
            this.ES_FullMarkLabel.TabIndex = 8;
            this.ES_FullMarkLabel.Text = "设定满分：";
            // 
            // ES_PassLine
            // 
            this.ES_PassLine.Enabled = false;
            this.ES_PassLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ES_PassLine.Location = new System.Drawing.Point(155, 57);
            this.ES_PassLine.MaxLength = 5;
            this.ES_PassLine.Name = "ES_PassLine";
            this.ES_PassLine.Size = new System.Drawing.Size(45, 25);
            this.ES_PassLine.TabIndex = 7;
            // 
            // ES_SetPassLineCheck
            // 
            this.ES_SetPassLineCheck.AutoSize = true;
            this.ES_SetPassLineCheck.Location = new System.Drawing.Point(13, 59);
            this.ES_SetPassLineCheck.Name = "ES_SetPassLineCheck";
            this.ES_SetPassLineCheck.Size = new System.Drawing.Size(145, 23);
            this.ES_SetPassLineCheck.TabIndex = 6;
            this.ES_SetPassLineCheck.Text = "划定及格线：";
            this.ES_SetPassLineCheck.UseVisualStyleBackColor = true;
            this.ES_SetPassLineCheck.CheckedChanged += new System.EventHandler(this.ES_SetPassLineCheck_CheckedChanged);
            // 
            // ES_FullMark
            // 
            this.ES_FullMark.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ES_FullMark.Location = new System.Drawing.Point(120, 25);
            this.ES_FullMark.MaxLength = 5;
            this.ES_FullMark.Name = "ES_FullMark";
            this.ES_FullMark.Size = new System.Drawing.Size(45, 25);
            this.ES_FullMark.TabIndex = 5;
            // 
            // ES_RoundCheck
            // 
            this.ES_RoundCheck.AutoSize = true;
            this.ES_RoundCheck.Location = new System.Drawing.Point(13, 93);
            this.ES_RoundCheck.Name = "ES_RoundCheck";
            this.ES_RoundCheck.Size = new System.Drawing.Size(164, 23);
            this.ES_RoundCheck.TabIndex = 3;
            this.ES_RoundCheck.Text = "四舍五入到整数";
            this.ES_RoundCheck.UseVisualStyleBackColor = true;
            // 
            // ES_AssessmentModeByScoreButton
            // 
            this.ES_AssessmentModeByScoreButton.AutoSize = true;
            this.ES_AssessmentModeByScoreButton.Location = new System.Drawing.Point(10, 113);
            this.ES_AssessmentModeByScoreButton.Name = "ES_AssessmentModeByScoreButton";
            this.ES_AssessmentModeByScoreButton.Size = new System.Drawing.Size(125, 23);
            this.ES_AssessmentModeByScoreButton.TabIndex = 3;
            this.ES_AssessmentModeByScoreButton.TabStop = true;
            this.ES_AssessmentModeByScoreButton.Text = "按分数评分";
            this.ES_AssessmentModeByScoreButton.UseVisualStyleBackColor = true;
            this.ES_AssessmentModeByScoreButton.CheckedChanged += new System.EventHandler(this.ES_AssessmentModeByScoreButton_CheckedChanged);
            // 
            // ES_AssessmentModeByGradeButton
            // 
            this.ES_AssessmentModeByGradeButton.AutoSize = true;
            this.ES_AssessmentModeByGradeButton.Location = new System.Drawing.Point(10, 84);
            this.ES_AssessmentModeByGradeButton.Name = "ES_AssessmentModeByGradeButton";
            this.ES_AssessmentModeByGradeButton.Size = new System.Drawing.Size(125, 23);
            this.ES_AssessmentModeByGradeButton.TabIndex = 2;
            this.ES_AssessmentModeByGradeButton.TabStop = true;
            this.ES_AssessmentModeByGradeButton.Text = "按等级评分";
            this.ES_AssessmentModeByGradeButton.UseVisualStyleBackColor = true;
            // 
            // ES_AssessmentModeByPassButton
            // 
            this.ES_AssessmentModeByPassButton.AutoSize = true;
            this.ES_AssessmentModeByPassButton.Location = new System.Drawing.Point(10, 55);
            this.ES_AssessmentModeByPassButton.Name = "ES_AssessmentModeByPassButton";
            this.ES_AssessmentModeByPassButton.Size = new System.Drawing.Size(163, 23);
            this.ES_AssessmentModeByPassButton.TabIndex = 1;
            this.ES_AssessmentModeByPassButton.TabStop = true;
            this.ES_AssessmentModeByPassButton.Text = "按合格与否评分";
            this.ES_AssessmentModeByPassButton.UseVisualStyleBackColor = true;
            // 
            // ES_AssessmentModeNoneButton
            // 
            this.ES_AssessmentModeNoneButton.AutoSize = true;
            this.ES_AssessmentModeNoneButton.Location = new System.Drawing.Point(10, 26);
            this.ES_AssessmentModeNoneButton.Name = "ES_AssessmentModeNoneButton";
            this.ES_AssessmentModeNoneButton.Size = new System.Drawing.Size(87, 23);
            this.ES_AssessmentModeNoneButton.TabIndex = 0;
            this.ES_AssessmentModeNoneButton.TabStop = true;
            this.ES_AssessmentModeNoneButton.Text = "不评分";
            this.ES_AssessmentModeNoneButton.UseVisualStyleBackColor = true;
            // 
            // ES_CourseTimeGroup
            // 
            this.ES_CourseTimeGroup.Controls.Add(this.ES_CourseTimePanel);
            this.ES_CourseTimeGroup.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ES_CourseTimeGroup.Location = new System.Drawing.Point(13, 245);
            this.ES_CourseTimeGroup.Name = "ES_CourseTimeGroup";
            this.ES_CourseTimeGroup.Size = new System.Drawing.Size(408, 140);
            this.ES_CourseTimeGroup.TabIndex = 4;
            this.ES_CourseTimeGroup.TabStop = false;
            this.ES_CourseTimeGroup.Text = "课程时间";
            // 
            // ES_CourseTimePanel
            // 
            this.ES_CourseTimePanel.ColumnCount = 5;
            this.ES_CourseTimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ES_CourseTimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.ES_CourseTimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.ES_CourseTimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.ES_CourseTimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.ES_CourseTimePanel.Controls.Add(this.ES_Senior, 4, 0);
            this.ES_CourseTimePanel.Controls.Add(this.Senior2, 4, 2);
            this.ES_CourseTimePanel.Controls.Add(this.ES_Sophomore, 2, 0);
            this.ES_CourseTimePanel.Controls.Add(this.Junior2, 3, 2);
            this.ES_CourseTimePanel.Controls.Add(this.ES_Junior, 3, 0);
            this.ES_CourseTimePanel.Controls.Add(this.Sophomore2, 2, 2);
            this.ES_CourseTimePanel.Controls.Add(this.ES_FirstTerm, 0, 1);
            this.ES_CourseTimePanel.Controls.Add(this.Freshman2, 1, 2);
            this.ES_CourseTimePanel.Controls.Add(this.ES_SecondTerm, 0, 2);
            this.ES_CourseTimePanel.Controls.Add(this.ES_Freshman, 1, 0);
            this.ES_CourseTimePanel.Controls.Add(this.Senior1, 4, 1);
            this.ES_CourseTimePanel.Controls.Add(this.Freshman1, 1, 1);
            this.ES_CourseTimePanel.Controls.Add(this.Sophomore1, 2, 1);
            this.ES_CourseTimePanel.Controls.Add(this.Junior1, 3, 1);
            this.ES_CourseTimePanel.Location = new System.Drawing.Point(11, 27);
            this.ES_CourseTimePanel.Name = "ES_CourseTimePanel";
            this.ES_CourseTimePanel.RowCount = 3;
            this.ES_CourseTimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ES_CourseTimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ES_CourseTimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ES_CourseTimePanel.Size = new System.Drawing.Size(391, 105);
            this.ES_CourseTimePanel.TabIndex = 11;
            // 
            // ES_Senior
            // 
            this.ES_Senior.AutoSize = true;
            this.ES_Senior.Location = new System.Drawing.Point(318, 0);
            this.ES_Senior.Name = "ES_Senior";
            this.ES_Senior.Size = new System.Drawing.Size(66, 19);
            this.ES_Senior.TabIndex = 13;
            this.ES_Senior.Text = "四年级";
            // 
            // Senior2
            // 
            this.Senior2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Senior2.AutoSize = true;
            this.Senior2.BackColor = System.Drawing.SystemColors.Control;
            this.Senior2.Checked = true;
            this.Senior2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Senior2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Senior2.Location = new System.Drawing.Point(344, 73);
            this.Senior2.Name = "Senior2";
            this.Senior2.Size = new System.Drawing.Size(18, 17);
            this.Senior2.TabIndex = 7;
            this.Senior2.UseVisualStyleBackColor = false;
            // 
            // ES_Sophomore
            // 
            this.ES_Sophomore.AutoSize = true;
            this.ES_Sophomore.Location = new System.Drawing.Point(168, 0);
            this.ES_Sophomore.Name = "ES_Sophomore";
            this.ES_Sophomore.Size = new System.Drawing.Size(66, 19);
            this.ES_Sophomore.TabIndex = 14;
            this.ES_Sophomore.Text = "二年级";
            // 
            // Junior2
            // 
            this.Junior2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Junior2.AutoSize = true;
            this.Junior2.BackColor = System.Drawing.SystemColors.Control;
            this.Junior2.Checked = true;
            this.Junior2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Junior2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Junior2.Location = new System.Drawing.Point(268, 73);
            this.Junior2.Name = "Junior2";
            this.Junior2.Size = new System.Drawing.Size(18, 17);
            this.Junior2.TabIndex = 6;
            this.Junior2.UseVisualStyleBackColor = false;
            // 
            // ES_Junior
            // 
            this.ES_Junior.AutoSize = true;
            this.ES_Junior.Location = new System.Drawing.Point(243, 0);
            this.ES_Junior.Name = "ES_Junior";
            this.ES_Junior.Size = new System.Drawing.Size(66, 19);
            this.ES_Junior.TabIndex = 12;
            this.ES_Junior.Text = "三年级";
            // 
            // Sophomore2
            // 
            this.Sophomore2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sophomore2.AutoSize = true;
            this.Sophomore2.BackColor = System.Drawing.SystemColors.Control;
            this.Sophomore2.Checked = true;
            this.Sophomore2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sophomore2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sophomore2.Location = new System.Drawing.Point(193, 73);
            this.Sophomore2.Name = "Sophomore2";
            this.Sophomore2.Size = new System.Drawing.Size(18, 17);
            this.Sophomore2.TabIndex = 5;
            this.Sophomore2.UseVisualStyleBackColor = false;
            // 
            // ES_FirstTerm
            // 
            this.ES_FirstTerm.AutoSize = true;
            this.ES_FirstTerm.Location = new System.Drawing.Point(3, 35);
            this.ES_FirstTerm.Name = "ES_FirstTerm";
            this.ES_FirstTerm.Size = new System.Drawing.Size(66, 19);
            this.ES_FirstTerm.TabIndex = 9;
            this.ES_FirstTerm.Text = "上学期";
            // 
            // Freshman2
            // 
            this.Freshman2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Freshman2.AutoSize = true;
            this.Freshman2.BackColor = System.Drawing.SystemColors.Control;
            this.Freshman2.Checked = true;
            this.Freshman2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Freshman2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Freshman2.Location = new System.Drawing.Point(118, 73);
            this.Freshman2.Name = "Freshman2";
            this.Freshman2.Size = new System.Drawing.Size(18, 17);
            this.Freshman2.TabIndex = 4;
            this.Freshman2.UseVisualStyleBackColor = false;
            // 
            // ES_SecondTerm
            // 
            this.ES_SecondTerm.AutoSize = true;
            this.ES_SecondTerm.Location = new System.Drawing.Point(3, 70);
            this.ES_SecondTerm.Name = "ES_SecondTerm";
            this.ES_SecondTerm.Size = new System.Drawing.Size(66, 19);
            this.ES_SecondTerm.TabIndex = 10;
            this.ES_SecondTerm.Text = "下学期";
            // 
            // ES_Freshman
            // 
            this.ES_Freshman.AutoSize = true;
            this.ES_Freshman.Location = new System.Drawing.Point(93, 0);
            this.ES_Freshman.Name = "ES_Freshman";
            this.ES_Freshman.Size = new System.Drawing.Size(66, 19);
            this.ES_Freshman.TabIndex = 8;
            this.ES_Freshman.Text = "一年级";
            // 
            // Senior1
            // 
            this.Senior1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Senior1.AutoSize = true;
            this.Senior1.BackColor = System.Drawing.SystemColors.Control;
            this.Senior1.Checked = true;
            this.Senior1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Senior1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Senior1.Location = new System.Drawing.Point(344, 38);
            this.Senior1.Name = "Senior1";
            this.Senior1.Size = new System.Drawing.Size(18, 17);
            this.Senior1.TabIndex = 3;
            this.Senior1.UseVisualStyleBackColor = false;
            // 
            // Freshman1
            // 
            this.Freshman1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Freshman1.AutoSize = true;
            this.Freshman1.BackColor = System.Drawing.SystemColors.Control;
            this.Freshman1.Checked = true;
            this.Freshman1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Freshman1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Freshman1.Location = new System.Drawing.Point(118, 38);
            this.Freshman1.Name = "Freshman1";
            this.Freshman1.Size = new System.Drawing.Size(18, 17);
            this.Freshman1.TabIndex = 0;
            this.Freshman1.UseVisualStyleBackColor = false;
            // 
            // Sophomore1
            // 
            this.Sophomore1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sophomore1.AutoSize = true;
            this.Sophomore1.BackColor = System.Drawing.SystemColors.Control;
            this.Sophomore1.Checked = true;
            this.Sophomore1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Sophomore1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sophomore1.Location = new System.Drawing.Point(193, 38);
            this.Sophomore1.Name = "Sophomore1";
            this.Sophomore1.Size = new System.Drawing.Size(18, 17);
            this.Sophomore1.TabIndex = 1;
            this.Sophomore1.UseVisualStyleBackColor = false;
            // 
            // Junior1
            // 
            this.Junior1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Junior1.AutoSize = true;
            this.Junior1.BackColor = System.Drawing.SystemColors.Control;
            this.Junior1.Checked = true;
            this.Junior1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Junior1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Junior1.Location = new System.Drawing.Point(268, 38);
            this.Junior1.Name = "Junior1";
            this.Junior1.Size = new System.Drawing.Size(18, 17);
            this.Junior1.TabIndex = 2;
            this.Junior1.UseVisualStyleBackColor = false;
            // 
            // ES_AttributeGroup
            // 
            this.ES_AttributeGroup.Controls.Add(this.ES_SubjectName);
            this.ES_AttributeGroup.Controls.Add(this.ES_SubjectNameLabel);
            this.ES_AttributeGroup.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ES_AttributeGroup.Location = new System.Drawing.Point(13, 13);
            this.ES_AttributeGroup.Name = "ES_AttributeGroup";
            this.ES_AttributeGroup.Size = new System.Drawing.Size(408, 65);
            this.ES_AttributeGroup.TabIndex = 3;
            this.ES_AttributeGroup.TabStop = false;
            this.ES_AttributeGroup.Text = "科目属性";
            // 
            // SubjectEditor_EditSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 439);
            this.Controls.Add(this.ES_CourseTimeGroup);
            this.Controls.Add(this.ES_AssessmentModeGroup);
            this.Controls.Add(this.ES_AttributeGroup);
            this.Controls.Add(this.ES_CancelButton);
            this.Controls.Add(this.ES_AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectEditor_EditSubject";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑科目";
            this.ES_AssessmentModeGroup.ResumeLayout(false);
            this.ES_AssessmentModeGroup.PerformLayout();
            this.ES_WhenAssessmodeByScoreGroup.ResumeLayout(false);
            this.ES_WhenAssessmodeByScoreGroup.PerformLayout();
            this.ES_CourseTimeGroup.ResumeLayout(false);
            this.ES_CourseTimePanel.ResumeLayout(false);
            this.ES_CourseTimePanel.PerformLayout();
            this.ES_AttributeGroup.ResumeLayout(false);
            this.ES_AttributeGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ES_AcceptButton;
        private System.Windows.Forms.Button ES_CancelButton;
        private System.Windows.Forms.TextBox ES_SubjectName;
        private System.Windows.Forms.Label ES_SubjectNameLabel;
        private System.Windows.Forms.GroupBox ES_AssessmentModeGroup;
        private System.Windows.Forms.GroupBox ES_WhenAssessmodeByScoreGroup;
        private System.Windows.Forms.TextBox ES_FullMark;
        private System.Windows.Forms.CheckBox ES_RoundCheck;
        private System.Windows.Forms.RadioButton ES_AssessmentModeByScoreButton;
        private System.Windows.Forms.RadioButton ES_AssessmentModeByGradeButton;
        private System.Windows.Forms.RadioButton ES_AssessmentModeByPassButton;
        private System.Windows.Forms.RadioButton ES_AssessmentModeNoneButton;
        private System.Windows.Forms.GroupBox ES_CourseTimeGroup;
        private System.Windows.Forms.CheckBox Freshman1;
        private System.Windows.Forms.Label ES_SecondTerm;
        private System.Windows.Forms.Label ES_FirstTerm;
        private System.Windows.Forms.Label ES_Freshman;
        private System.Windows.Forms.CheckBox Senior2;
        private System.Windows.Forms.CheckBox Junior2;
        private System.Windows.Forms.CheckBox Sophomore2;
        private System.Windows.Forms.CheckBox Freshman2;
        private System.Windows.Forms.CheckBox Senior1;
        private System.Windows.Forms.CheckBox Junior1;
        private System.Windows.Forms.CheckBox Sophomore1;
        private System.Windows.Forms.TableLayoutPanel ES_CourseTimePanel;
        private System.Windows.Forms.Label ES_Senior;
        private System.Windows.Forms.Label ES_Sophomore;
        private System.Windows.Forms.Label ES_Junior;
        private System.Windows.Forms.GroupBox ES_AttributeGroup;
        private System.Windows.Forms.TextBox ES_PassLine;
        private System.Windows.Forms.CheckBox ES_SetPassLineCheck;
        private System.Windows.Forms.Label ES_FullMarkLabel;
    }
}