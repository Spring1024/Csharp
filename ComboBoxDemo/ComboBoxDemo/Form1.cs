using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radBut_simple_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_1.DropDownStyle = ComboBoxStyle.Simple;
        }


        private void radBut_dropdown_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_1.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void radBut_dropdownlist_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void But_01_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ComboBox_1.Items.Add(textBox1.Text);
            }
        }

        private void But_02_Click(object sender, EventArgs e)
        {
            int i=ComboBox_1.SelectedIndex;
            if (textBox1.Text != "") {
                if (i > -1)
                {
                    ComboBox_1.Items.Insert(i, textBox1.Text);
                }
                else
                {
                    ComboBox_1.Items.Insert(0, textBox1.Text);
                }
            }
           
            
        }

        private void But_03_Click(object sender, EventArgs e)
        {
            ComboBox_1.Items.Remove(textBox1.Text);
        }

        private void But_04_Click(object sender, EventArgs e)
        {
            int i = ComboBox_1.SelectedIndex;
            if (i > -1)
            {
                ComboBox_1.Items.RemoveAt(i);
            }
        }

        private void But_05_Click(object sender, EventArgs e)
        {
            ComboBox_1.Items.Clear();
        }

        private void Button_Get_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.AppendText ("选中的信息所在行数为：" + (ComboBox_1.SelectedIndex+1).ToString()+"\t\n");
            if (ComboBox_1.SelectedIndex > -1)
            {
                textBox2.AppendText("选中的内容是：" + ComboBox_1.SelectedItem.ToString()+"\t\n");
            }
           
        }
    }
}
