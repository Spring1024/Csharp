using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxDemo
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
        public void setRank()
        {
            int totalline = textBox1.GetLineFromCharIndex(textBox1.Text.Length) + 1;
            int index = textBox1.GetFirstCharIndexOfCurrentLine();
            int line = textBox1.GetLineFromCharIndex(index) + 1;
            int col = textBox1.SelectionStart - index + 1;
            statusBar_Row.Text = line.ToString() + " 行";
            statusBar_Col.Text = col.ToString() + " 列";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            setRank();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            setRank();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 粘帖ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
