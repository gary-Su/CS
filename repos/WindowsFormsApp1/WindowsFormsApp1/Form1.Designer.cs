namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameDesc = new System.Windows.Forms.Button();
            this.nameAsc = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.selectScore = new System.Windows.Forms.Button();
            this.studentInfo = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scoreInfo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.scores);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.studentName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // scores
            // 
            this.scores.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scores.Location = new System.Drawing.Point(120, 78);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(181, 23);
            this.scores.TabIndex = 5;
            this.scores.TextChanged += new System.EventHandler(this.Scores_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "成绩";
            // 
            // grade
            // 
            this.grade.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grade.Location = new System.Drawing.Point(120, 123);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(181, 23);
            this.grade.TabIndex = 3;
            this.grade.TextChanged += new System.EventHandler(this.Grade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "班级";
            // 
            // studentName
            // 
            this.studentName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentName.Location = new System.Drawing.Point(120, 31);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(181, 23);
            this.studentName.TabIndex = 1;
            this.studentName.TextChanged += new System.EventHandler(this.StudentName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameDesc);
            this.groupBox2.Controls.Add(this.nameAsc);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.selectScore);
            this.groupBox2.Controls.Add(this.studentInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生";
            // 
            // nameDesc
            // 
            this.nameDesc.Location = new System.Drawing.Point(213, 166);
            this.nameDesc.Name = "nameDesc";
            this.nameDesc.Size = new System.Drawing.Size(112, 23);
            this.nameDesc.TabIndex = 10;
            this.nameDesc.Text = "按名字降序";
            this.nameDesc.UseVisualStyleBackColor = true;
            this.nameDesc.Click += new System.EventHandler(this.NameDesc_Click);
            // 
            // nameAsc
            // 
            this.nameAsc.Location = new System.Drawing.Point(213, 118);
            this.nameAsc.Name = "nameAsc";
            this.nameAsc.Size = new System.Drawing.Size(112, 23);
            this.nameAsc.TabIndex = 9;
            this.nameAsc.Text = "按名字升序";
            this.nameAsc.UseVisualStyleBackColor = true;
            this.nameAsc.Click += new System.EventHandler(this.NameAsc_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(213, 75);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 23);
            this.delete.TabIndex = 8;
            this.delete.Text = "信息删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // selectScore
            // 
            this.selectScore.Location = new System.Drawing.Point(213, 35);
            this.selectScore.Name = "selectScore";
            this.selectScore.Size = new System.Drawing.Size(112, 23);
            this.selectScore.TabIndex = 7;
            this.selectScore.Text = "成绩查询";
            this.selectScore.UseVisualStyleBackColor = true;
            this.selectScore.Click += new System.EventHandler(this.SelectScore_Click);
            // 
            // studentInfo
            // 
            this.studentInfo.FormattingEnabled = true;
            this.studentInfo.ItemHeight = 12;
            this.studentInfo.Location = new System.Drawing.Point(6, 35);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(145, 172);
            this.studentInfo.TabIndex = 0;
            this.studentInfo.SelectedIndexChanged += new System.EventHandler(this.StudentInfo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scoreInfo);
            this.groupBox3.Location = new System.Drawing.Point(426, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "成绩信息";
            // 
            // scoreInfo
            // 
            this.scoreInfo.FormattingEnabled = true;
            this.scoreInfo.ItemHeight = 12;
            this.scoreInfo.Location = new System.Drawing.Point(45, 41);
            this.scoreInfo.Name = "scoreInfo";
            this.scoreInfo.Size = new System.Drawing.Size(144, 160);
            this.scoreInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "学生成绩查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox scores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button nameDesc;
        private System.Windows.Forms.Button nameAsc;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button selectScore;
        private System.Windows.Forms.ListBox studentInfo;
        private System.Windows.Forms.ListBox scoreInfo;
    }
}

