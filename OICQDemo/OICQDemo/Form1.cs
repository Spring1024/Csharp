using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OICQDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //单击图片实现切换已记住密码的帐号
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (textBox2.Text == "")
            {
                textBox2.Text = "密码";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (textBox1.Text == "")
            {
                textBox1.Text = "QQ号码/邮箱";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _qqNum = @"([1-9][0-9]{4,})";
            string _email = @"/w+([-+.]/w+)*@/w+([-.]/w+)*/./w+([-.]/w+)*";
            //Match m=Regex.Match(textBox1.Text,_telnum);
            Match m1 = Regex.Match(textBox1.Text, _qqNum);
            Match m2 = Regex.Match(textBox1.Text, _email);
            if (m1.Groups.Count < 1 | m2.Groups.Count < 1 | textBox1.Text != " QQ号码/邮箱" | textBox1.Text != "")
            {
                MessageBox.Show(this, "输入有误");
            }
        }
    }
}
