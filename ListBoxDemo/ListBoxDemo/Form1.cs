using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("蛮牛冲撞");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i=listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.AppendText("这些招式，蔡徐坤全都会！\r\n");
            if (!checkBox1.Checked && listBox1.SelectedItems.Count > 0)
            {
                textBox2.AppendText("而你会的招式只有：" + listBox1.SelectedItem.ToString()+"\r\n"+"\r\n你太菜了！"+"\r\n");
            }
            else if (!checkBox1.Checked && listBox1.SelectedItems.Count ==0)
            {
                textBox2.AppendText("\r\n而你怎么什么都不会？\r\nhe       tui！");
            }
            else
            {
                foreach (string str in listBox1.SelectedItems)
                {
                    textBox2.AppendText("而你会的招式有：" + str + "\r\n");
                }
                if (listBox1.SelectedItems.Count >= 5)
                {
                    textBox2.AppendText("\r\n真是太棒了！\r\n你比蔡徐坤还蔡徐坤！");
                }
                else
                {
                    textBox2.AppendText("\r\n你太菜了！\r\n");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode;
            if (k == Keys.F5)
            {
                this.Hide();//先隐藏主窗体
                Form1 form = new Form1();//重新实例化此窗体
                form.ShowDialog();//以模式窗体的方法重新打开
                this.Close();//原窗体关闭
            }
        }



    }
}
