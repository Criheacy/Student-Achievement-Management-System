namespace Students_Achievement_Management_System
{
    partial class StudentEditor
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
            this.StudentNameText = new System.Windows.Forms.Label();
            this.MaleSex = new System.Windows.Forms.RadioButton();
            this.FemaleSex = new System.Windows.Forms.RadioButton();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.StudentMajor = new System.Windows.Forms.TextBox();
            this.StudentClass = new System.Windows.Forms.TextBox();
            this.StudentMajorText = new System.Windows.Forms.Label();
            this.StudentYearText = new System.Windows.Forms.Label();
            this.StudentClassText = new System.Windows.Forms.Label();
            this.YearPicker = new System.Windows.Forms.DateTimePicker();
            this.ClassText = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.StudentIDText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentNameText
            // 
            this.StudentNameText.AutoSize = true;
            this.StudentNameText.Location = new System.Drawing.Point(15, 56);
            this.StudentNameText.Name = "StudentNameText";
            this.StudentNameText.Size = new System.Drawing.Size(85, 19);
            this.StudentNameText.TabIndex = 0;
            this.StudentNameText.Text = "学生姓名";
            // 
            // MaleSex
            // 
            this.MaleSex.AutoSize = true;
            this.MaleSex.BackColor = System.Drawing.SystemColors.Control;
            this.MaleSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MaleSex.Location = new System.Drawing.Point(20, 92);
            this.MaleSex.Name = "MaleSex";
            this.MaleSex.Size = new System.Drawing.Size(68, 23);
            this.MaleSex.TabIndex = 1;
            this.MaleSex.TabStop = true;
            this.MaleSex.Text = "男生";
            this.MaleSex.UseVisualStyleBackColor = false;
            this.MaleSex.CheckedChanged += new System.EventHandler(this.StudentSex_TextChanged);
            // 
            // FemaleSex
            // 
            this.FemaleSex.AutoSize = true;
            this.FemaleSex.Location = new System.Drawing.Point(148, 92);
            this.FemaleSex.Name = "FemaleSex";
            this.FemaleSex.Size = new System.Drawing.Size(68, 23);
            this.FemaleSex.TabIndex = 2;
            this.FemaleSex.TabStop = true;
            this.FemaleSex.Text = "女生";
            this.FemaleSex.UseVisualStyleBackColor = true;
            this.FemaleSex.CheckedChanged += new System.EventHandler(this.StudentSex_TextChanged);
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(106, 53);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(145, 28);
            this.StudentName.TabIndex = 3;
            this.StudentName.TextChanged += new System.EventHandler(this.StudentName_TextChanged);
            // 
            // StudentMajor
            // 
            this.StudentMajor.Location = new System.Drawing.Point(105, 125);
            this.StudentMajor.Name = "StudentMajor";
            this.StudentMajor.Size = new System.Drawing.Size(146, 28);
            this.StudentMajor.TabIndex = 4;
            this.StudentMajor.TextChanged += new System.EventHandler(this.StudentMajor_TextChanged);
            // 
            // StudentClass
            // 
            this.StudentClass.Location = new System.Drawing.Point(105, 197);
            this.StudentClass.Name = "StudentClass";
            this.StudentClass.Size = new System.Drawing.Size(112, 28);
            this.StudentClass.TabIndex = 6;
            this.StudentClass.TextChanged += new System.EventHandler(this.StudentClass_TextChanged);
            // 
            // StudentMajorText
            // 
            this.StudentMajorText.AutoSize = true;
            this.StudentMajorText.Location = new System.Drawing.Point(15, 129);
            this.StudentMajorText.Name = "StudentMajorText";
            this.StudentMajorText.Size = new System.Drawing.Size(85, 19);
            this.StudentMajorText.TabIndex = 7;
            this.StudentMajorText.Text = "所属学院";
            // 
            // StudentYearText
            // 
            this.StudentYearText.AutoSize = true;
            this.StudentYearText.Location = new System.Drawing.Point(15, 167);
            this.StudentYearText.Name = "StudentYearText";
            this.StudentYearText.Size = new System.Drawing.Size(85, 19);
            this.StudentYearText.TabIndex = 8;
            this.StudentYearText.Text = "入学年份";
            // 
            // StudentClassText
            // 
            this.StudentClassText.AutoSize = true;
            this.StudentClassText.Location = new System.Drawing.Point(14, 202);
            this.StudentClassText.Name = "StudentClassText";
            this.StudentClassText.Size = new System.Drawing.Size(85, 19);
            this.StudentClassText.TabIndex = 9;
            this.StudentClassText.Text = "所在班级";
            // 
            // YearPicker
            // 
            this.YearPicker.Location = new System.Drawing.Point(105, 161);
            this.YearPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.YearPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(146, 28);
            this.YearPicker.TabIndex = 10;
            this.YearPicker.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.YearPicker.ValueChanged += new System.EventHandler(this.StudentYear_TextChanged);
            // 
            // ClassText
            // 
            this.ClassText.AutoSize = true;
            this.ClassText.Location = new System.Drawing.Point(223, 200);
            this.ClassText.Name = "ClassText";
            this.ClassText.Size = new System.Drawing.Size(28, 19);
            this.ClassText.TabIndex = 11;
            this.ClassText.Text = "班";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKButton.Location = new System.Drawing.Point(153, 231);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(97, 30);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "确定(&A)";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.SystemColors.Window;
            this.StudentID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentID.Location = new System.Drawing.Point(72, 12);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(178, 28);
            this.StudentID.TabIndex = 14;
            this.StudentID.TextChanged += new System.EventHandler(this.StudentID_TextChanged);
            // 
            // StudentIDText
            // 
            this.StudentIDText.AutoSize = true;
            this.StudentIDText.Location = new System.Drawing.Point(18, 17);
            this.StudentIDText.Name = "StudentIDText";
            this.StudentIDText.Size = new System.Drawing.Size(47, 19);
            this.StudentIDText.TabIndex = 13;
            this.StudentIDText.Text = "学号";
            // 
            // StudentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 273);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.StudentIDText);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ClassText);
            this.Controls.Add(this.YearPicker);
            this.Controls.Add(this.StudentClassText);
            this.Controls.Add(this.StudentYearText);
            this.Controls.Add(this.StudentMajorText);
            this.Controls.Add(this.StudentClass);
            this.Controls.Add(this.StudentMajor);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.FemaleSex);
            this.Controls.Add(this.MaleSex);
            this.Controls.Add(this.StudentNameText);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentNameText;
        private System.Windows.Forms.RadioButton MaleSex;
        private System.Windows.Forms.RadioButton FemaleSex;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox StudentMajor;
        private System.Windows.Forms.TextBox StudentClass;
        private System.Windows.Forms.Label StudentMajorText;
        private System.Windows.Forms.Label StudentYearText;
        private System.Windows.Forms.Label StudentClassText;
        private System.Windows.Forms.DateTimePicker YearPicker;
        private System.Windows.Forms.Label ClassText;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label StudentIDText;
    }
}