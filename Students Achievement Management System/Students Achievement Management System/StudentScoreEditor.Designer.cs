namespace Students_Achievement_Management_System
{
    partial class StudentScoreEditor
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
            this.StudentInformationText = new System.Windows.Forms.Label();
            this.SubjectInformationText = new System.Windows.Forms.Label();
            this.PassButton = new System.Windows.Forms.RadioButton();
            this.FailButton = new System.Windows.Forms.RadioButton();
            this.PassGroup = new System.Windows.Forms.GroupBox();
            this.GradeGroup = new System.Windows.Forms.GroupBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.ABCDEF = new System.Windows.Forms.Label();
            this.GradeText = new System.Windows.Forms.TextBox();
            this.GradeTraceBar = new System.Windows.Forms.TrackBar();
            this.ScoreGroup = new System.Windows.Forms.GroupBox();
            this.PassLineState = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.NumericUpDown();
            this.PassLineHint = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.PassGroup.SuspendLayout();
            this.GradeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeTraceBar)).BeginInit();
            this.ScoreGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreText)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentInformationText
            // 
            this.StudentInformationText.AutoSize = true;
            this.StudentInformationText.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentInformationText.Location = new System.Drawing.Point(12, 19);
            this.StudentInformationText.Name = "StudentInformationText";
            this.StudentInformationText.Size = new System.Drawing.Size(66, 19);
            this.StudentInformationText.TabIndex = 0;
            this.StudentInformationText.Text = "学生：";
            // 
            // SubjectInformationText
            // 
            this.SubjectInformationText.AutoSize = true;
            this.SubjectInformationText.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubjectInformationText.Location = new System.Drawing.Point(12, 54);
            this.SubjectInformationText.Name = "SubjectInformationText";
            this.SubjectInformationText.Size = new System.Drawing.Size(142, 19);
            this.SubjectInformationText.TabIndex = 1;
            this.SubjectInformationText.Text = "科目：高等数学";
            // 
            // PassButton
            // 
            this.PassButton.AutoSize = true;
            this.PassButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassButton.Location = new System.Drawing.Point(19, 27);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(68, 23);
            this.PassButton.TabIndex = 2;
            this.PassButton.TabStop = true;
            this.PassButton.Text = "合格";
            this.PassButton.UseVisualStyleBackColor = true;
            // 
            // FailButton
            // 
            this.FailButton.AutoSize = true;
            this.FailButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FailButton.Location = new System.Drawing.Point(186, 27);
            this.FailButton.Name = "FailButton";
            this.FailButton.Size = new System.Drawing.Size(87, 23);
            this.FailButton.TabIndex = 3;
            this.FailButton.TabStop = true;
            this.FailButton.Text = "不合格";
            this.FailButton.UseVisualStyleBackColor = true;
            // 
            // PassGroup
            // 
            this.PassGroup.Controls.Add(this.PassButton);
            this.PassGroup.Controls.Add(this.FailButton);
            this.PassGroup.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassGroup.Location = new System.Drawing.Point(90, 108);
            this.PassGroup.Name = "PassGroup";
            this.PassGroup.Size = new System.Drawing.Size(319, 67);
            this.PassGroup.TabIndex = 4;
            this.PassGroup.TabStop = false;
            this.PassGroup.Text = "合格制评分";
            // 
            // GradeGroup
            // 
            this.GradeGroup.Controls.Add(this.GradeLabel);
            this.GradeGroup.Controls.Add(this.ABCDEF);
            this.GradeGroup.Controls.Add(this.GradeText);
            this.GradeGroup.Controls.Add(this.GradeTraceBar);
            this.GradeGroup.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GradeGroup.Location = new System.Drawing.Point(181, 298);
            this.GradeGroup.Name = "GradeGroup";
            this.GradeGroup.Size = new System.Drawing.Size(319, 148);
            this.GradeGroup.TabIndex = 5;
            this.GradeGroup.TabStop = false;
            this.GradeGroup.Text = "等级制评分";
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GradeLabel.Location = new System.Drawing.Point(59, 41);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(109, 20);
            this.GradeLabel.TabIndex = 3;
            this.GradeLabel.Text = "等级评分：";
            // 
            // ABCDEF
            // 
            this.ABCDEF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ABCDEF.AutoSize = true;
            this.ABCDEF.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ABCDEF.Location = new System.Drawing.Point(49, 113);
            this.ABCDEF.Name = "ABCDEF";
            this.ABCDEF.Size = new System.Drawing.Size(219, 19);
            this.ABCDEF.TabIndex = 2;
            this.ABCDEF.Text = "A   B   C   D   E   F";
            this.ABCDEF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradeText
            // 
            this.GradeText.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GradeText.Location = new System.Drawing.Point(186, 27);
            this.GradeText.MaxLength = 2;
            this.GradeText.Name = "GradeText";
            this.GradeText.Size = new System.Drawing.Size(51, 43);
            this.GradeText.TabIndex = 1;
            this.GradeText.Text = "A+";
            this.GradeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GradeText.TextChanged += new System.EventHandler(this.GradeText_TextChanged);
            this.GradeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIllegal);
            // 
            // GradeTraceBar
            // 
            this.GradeTraceBar.LargeChange = 1;
            this.GradeTraceBar.Location = new System.Drawing.Point(25, 76);
            this.GradeTraceBar.Maximum = 17;
            this.GradeTraceBar.Name = "GradeTraceBar";
            this.GradeTraceBar.Size = new System.Drawing.Size(276, 56);
            this.GradeTraceBar.TabIndex = 0;
            this.GradeTraceBar.Scroll += new System.EventHandler(this.GradeTraceBar_Scroll);
            // 
            // ScoreGroup
            // 
            this.ScoreGroup.Controls.Add(this.PassLineState);
            this.ScoreGroup.Controls.Add(this.ScoreText);
            this.ScoreGroup.Controls.Add(this.PassLineHint);
            this.ScoreGroup.Controls.Add(this.ScoreLabel);
            this.ScoreGroup.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScoreGroup.Location = new System.Drawing.Point(464, 117);
            this.ScoreGroup.Name = "ScoreGroup";
            this.ScoreGroup.Size = new System.Drawing.Size(319, 109);
            this.ScoreGroup.TabIndex = 6;
            this.ScoreGroup.TabStop = false;
            this.ScoreGroup.Text = "分数制评分";
            // 
            // PassLineState
            // 
            this.PassLineState.AutoSize = true;
            this.PassLineState.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassLineState.Location = new System.Drawing.Point(176, 73);
            this.PassLineState.Name = "PassLineState";
            this.PassLineState.Size = new System.Drawing.Size(85, 19);
            this.PassLineState.TabIndex = 6;
            this.PassLineState.Text = "（及格）";
            this.PassLineState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreText
            // 
            this.ScoreText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScoreText.Location = new System.Drawing.Point(152, 27);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(109, 40);
            this.ScoreText.TabIndex = 5;
            this.ScoreText.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ScoreText.ValueChanged += new System.EventHandler(this.ScoreText_ValueChanged);
            // 
            // PassLineHint
            // 
            this.PassLineHint.AutoSize = true;
            this.PassLineHint.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassLineHint.Location = new System.Drawing.Point(15, 73);
            this.PassLineHint.Name = "PassLineHint";
            this.PassLineHint.Size = new System.Drawing.Size(85, 19);
            this.PassLineHint.TabIndex = 4;
            this.PassLineHint.Text = "及格线：";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScoreLabel.Location = new System.Drawing.Point(59, 38);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(69, 20);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "分数：";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(181, 215);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(103, 34);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "确认(&A)";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // StudentScoreEditor
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 466);
            this.Controls.Add(this.ScoreGroup);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.GradeGroup);
            this.Controls.Add(this.PassGroup);
            this.Controls.Add(this.SubjectInformationText);
            this.Controls.Add(this.StudentInformationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentScoreEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "录入成绩";
            this.PassGroup.ResumeLayout(false);
            this.PassGroup.PerformLayout();
            this.GradeGroup.ResumeLayout(false);
            this.GradeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradeTraceBar)).EndInit();
            this.ScoreGroup.ResumeLayout(false);
            this.ScoreGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentInformationText;
        private System.Windows.Forms.Label SubjectInformationText;
        private System.Windows.Forms.RadioButton PassButton;
        private System.Windows.Forms.RadioButton FailButton;
        private System.Windows.Forms.GroupBox PassGroup;
        private System.Windows.Forms.GroupBox GradeGroup;
        private System.Windows.Forms.GroupBox ScoreGroup;
        private System.Windows.Forms.Label PassLineState;
        private System.Windows.Forms.NumericUpDown ScoreText;
        private System.Windows.Forms.Label PassLineHint;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label ABCDEF;
        private System.Windows.Forms.TextBox GradeText;
        private System.Windows.Forms.TrackBar GradeTraceBar;
        private System.Windows.Forms.Button OKButton;
    }
}