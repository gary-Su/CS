using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        HashSet<int> set = new HashSet<int>();
        int seqNum = 1;
        private void Start_Click(object sender, EventArgs e)
        {
            if ("开始".Equals(start.Text)) {
                if (Utils.grp <= 0 || Utils.arrGroups.Length == 0 || Utils.arrGroups == null)
                {
                    MessageBox.Show("未生成卡片!!!");
                    return;
                }

                panel1.Controls.Clear();
                groupBox1.Controls.Clear();
                set = new HashSet<int>();
                seqNum = 1;
                timer1.Start();
                start.Text = "停止";
                return;
            }

            if ("停止".Equals(start.Text))
            {
                timer1.Stop();
                start.Text = "开始";
                return;
            }

        }

        public void addOneNum(int i,int num) //9个卡片（包括中间点选卡片）卡片布局
        {
            panel1.Controls.Clear();
            Label addLabel = new Label();
            addLabel.Width = 100;
            addLabel.Height = 100;
            addLabel.BorderStyle = BorderStyle.FixedSingle;
            addLabel.BackColor = Color.Red; //从颜色数组里面设置背景颜色
            addLabel.Font = new Font("黑体", 30, FontStyle.Bold);
            addLabel.TextAlign = ContentAlignment.MiddleCenter;//设置Label的文本属性
            addLabel.Text =num+"";
            addLabel.Location = new Point(0,0); //卡片位置

            panel1.Controls.Add(addLabel);
            panel1.Show();

            Label addLabel1 = new Label();
            addLabel1.Width = 60;
            addLabel1.Height = 40;
            addLabel1.BorderStyle = BorderStyle.FixedSingle;
            addLabel1.BackColor = Color.White; //从颜色数组里面设置背景颜色
            addLabel1.Font = new Font("黑体", 20, FontStyle.Bold);
            addLabel1.TextAlign = ContentAlignment.MiddleCenter;//设置Label的文本属性
            addLabel1.Text = num.ToString();
            addLabel1.Location = new Point(80+((i-1) % 5) * 60 , 20 + ((i-1)/5) * 60); //卡片位置
           //if (i == 4)
           //   addLabel.Click += new System.EventHandler(label1_Click);//给中间卡片加点击事件

            groupBox1.Controls.Add(addLabel1);//label数组里面加入label
            groupBox1.Show();
        }

        private void isWin(HashSet<int> set) {
           
            for(int i =0; i < Utils.grp; i++)
            {
                int[] card = Utils.arrGroups[i];
                int[] card1_1 = { card[0], card[1], card[2] };
                int[] card1_2 = { card[0], card[3], card[5] };
                int[] card1_3 = { card[5], card[6], card[7] };
                int[] card1_4 = { card[2], card[4], card[7] };

                if (set.Contains<int>(card1_1[0]) && set.Contains<int>(card1_1[1])&& set.Contains<int>(card1_1[2]))
                {
                    flush();
                    MessageBox.Show(String.Format("卡片{0}中奖啦！！！上行匹配({1})",i+1,card1_1[0]+"_"+ card1_1[1]+"_"+ card1_1[2]));
                    Console.WriteLine("上行匹配");
                    break;
                }
                if (set.Contains<int>(card1_2[0]) && set.Contains<int>(card1_2[1]) && set.Contains<int>(card1_2[2]))
                {
                    flush();
                    MessageBox.Show(String.Format("卡片{0}中奖啦！！！左列匹配({1})", i + 1, card1_2[0] + "_" + card1_2[1] + "_" + card1_2[2]));
                    Console.WriteLine("左列匹配");
                    break;
                }
                if (set.Contains<int>(card1_3[0]) && set.Contains<int>(card1_3[1]) && set.Contains<int>(card1_3[2]))
                {
                    flush();
                    MessageBox.Show(String.Format("卡片{0}中奖啦！！！下行匹配({1})", i + 1, card1_3[0] + "_" + card1_3[1] + "_" + card1_3[2]));
                    Console.WriteLine("下行匹配");
                    break;
                }
                if (set.Contains<int>(card1_4[0]) && set.Contains<int>(card1_4[1]) && set.Contains<int>(card1_4[2]))
                {
                    flush();
                    MessageBox.Show(String.Format("卡片{0}中奖啦！！！右列匹配({1})", i + 1, card1_4[0] + "_" + card1_4[1] + "_" + card1_4[2]));
                    Console.WriteLine("右列匹配");
                    break;
                }
            }
           
           
        }

      
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = r.Next(0, 20);
            set.Add(num);
            addOneNum(seqNum, num);
            if (set.Count >= 3) {
                isWin(set);
            }
            seqNum++;
            if (seqNum == 11)
            {
                timer1.Stop();
                start.Text = "开始";
                seqNum = 1;
            }
        }

        public void flush()
        {
            set = new HashSet<int>();
            timer1.Stop();
            start.Text = "开始";
        }
    }
}
