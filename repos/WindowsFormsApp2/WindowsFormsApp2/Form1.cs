using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int grp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void MakeCard_Click(object sender, EventArgs e)
        {
            if (this.groups.Text.Equals("")|| this.groups.Text==null) {
                MessageBox.Show("请输入卡片数!!!");
                return;
            }
            grp = int.Parse(this.groups.Text);
            Utils.grp = grp;
            Utils.arrGroups  = randomNumbers(grp, 8, 0, 20);
            Card.Text = "卡片"+ Utils.grp;
            num0.Text = Utils.arrGroups[grp - 1][0].ToString();
            num1.Text = Utils.arrGroups[grp - 1][1].ToString();
            num2.Text = Utils.arrGroups[grp - 1][2].ToString();
            num3.Text = Utils.arrGroups[grp - 1][3].ToString();
            num4.Text = Utils.arrGroups[grp - 1][4].ToString();
            num5.Text = Utils.arrGroups[grp - 1][5].ToString();
            num6.Text = Utils.arrGroups[grp - 1][6].ToString();
            num7.Text = Utils.arrGroups[grp - 1][7].ToString();
        }

        private int[][] randomNumbers(int groups,int nums, int min, int max) {
            Random r = new Random();
            int[][] arr = new int[groups][];
            int[] son;
           
            for(int i = 0; i < groups; i++)
            {
                son = new int[nums];
                int j = 0;
                while (true)
                {
                    int num = r.Next(0, 20);
                    if (!son.Contains<int>(num))
                    {
                        son[j] = num;
                        if (j == 7)
                        {
                            break;
                        }
                        j++;
                    }
                }
                Array.Sort<int>(son);
                arr[i] = son;
            }
            return arr;
        }
        
        private void Card_Click(object sender, EventArgs e)
        {
            grp--;
            if (grp <= 0)
            {
                MessageBox.Show("没卡片啦!");
                return;
            }
             Card.Text = "卡片" + grp;
            num0.Text = Utils.arrGroups[grp - 1][0].ToString();
            num1.Text = Utils.arrGroups[grp - 1][1].ToString();
            num2.Text = Utils.arrGroups[grp - 1][2].ToString();
            num3.Text = Utils.arrGroups[grp - 1][3].ToString();
            num4.Text = Utils.arrGroups[grp - 1][4].ToString();
            num5.Text = Utils.arrGroups[grp - 1][5].ToString();
            num6.Text = Utils.arrGroups[grp - 1][6].ToString();
            num7.Text = Utils.arrGroups[grp - 1][7].ToString();

        }

        private void DrawLottery_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }
    }
}
