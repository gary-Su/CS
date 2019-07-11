using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> list = new List<Student>();
        Hashtable ht = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            // Student stu = new Student(name, score, gra);
            Student stu = new Student();
            stu.StudentName = studentName.Text;
            stu.Scores = scores.Text;
            stu.Grade = grade.Text;
            list.Add(stu);
            if (ht.ContainsKey(stu.StudentName)) {
                MessageBox.Show("该信息已存在");
                return;
            }
            ht.Add(stu.StudentName,stu);
            studentInfo.Items.Add(studentName.Text);
        }


        private void Grade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Scores_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectScore_Click(object sender, EventArgs e)
        {
            Object o = studentInfo.SelectedItem;
            if (o == null) {
                MessageBox.Show("请选择需要查询的同学!");
                return;
            }

            Object obj = ht[o.ToString()];
            //typeof(Student).IsInstanceOfType(obj);
            if (obj is Student ){
                Student stud = (Student)obj;
                scoreInfo.Items.Clear();
                scoreInfo.Items.Add("姓名:"+stud.StudentName);
                scoreInfo.Items.Add("班级:"+stud.Grade);
                scoreInfo.Items.Add("分数:"+stud.Scores);
                
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Object o = studentInfo.SelectedItem;
            if (o == null)
            {
                MessageBox.Show("请选择需要删除的同学!");
                return;
            }
          
            String studentName = o.ToString();
            studentInfo.Items.Remove(studentName);
           Object obj = ht[studentName];
            //typeof(Student).IsInstanceOfType(obj);
            Student stud = (Student)obj;
            list.Remove(stud);
            ht.Remove(o);

        }

        private void NameAsc_Click(object sender, EventArgs e)
        {
            list.Sort((x, y) => x.StudentName.CompareTo(y.StudentName));
            studentInfo.Items.Clear();
            for (int i = 0; i < list.Count(); i++) {
                studentInfo.Items.Add(list[i].StudentName);
            }
        }

        private void NameDesc_Click(object sender, EventArgs e)
        {
            list.Sort((x, y) => y.StudentName.CompareTo(x.StudentName));
            studentInfo.Items.Clear();
            for (int i = 0; i < list.Count(); i++)
            {
                studentInfo.Items.Add(list[i].StudentName);
            }
        }
    }
}
