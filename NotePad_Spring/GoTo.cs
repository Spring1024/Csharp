using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad_Spring
{
    public partial class GoTo : Form
    {
        private int Num;
        public static int SetNum;
        public GoTo()
        {
            InitializeComponent();
            GoTo_Text.Text = MainForm.NowRowNum.ToString();
        }

        private void Button_No_Click(object sender, EventArgs e)
        {
            Close();
            SetNum = MainForm.NowRowNum;
        }

        private void Button_Yes_Click(object sender, EventArgs e)
        {
            Close();
            int.TryParse(GoTo_Text.Text, out Num);
            if (Num > (MainForm.MaxRowNum-1))
            {
                MessageBox.Show("输入的行数不能大于总行数", "错误");
                SetNum = MainForm.NowRowNum;
            }
            else
            {
                int.TryParse(GoTo_Text.Text, out SetNum);
            }

        }
        private void GoTo_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= 47 && e.KeyChar <= 58) | (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("只能输入数字", "错误");
            }
            
        }

        private void GoTo_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetNum = MainForm.NowRowNum;
        }
    }
}
