using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad_Spring
{
    public partial class Search : Form
    {
        public static Search search = null;
        int count = -1;
        public Search()
        {
            InitializeComponent();
        }

        public void Find()
        {
            if (!(String.IsNullOrEmpty(this.TextBox_Search.Text)))
            {
                if (MainForm.txt.Contains(this.TextBox_Search.Text) == false)
                {

                    int index = MainForm.mainfrm.Main_Text.Text.IndexOf(TextBox_Search.Text, count + 1);
                    if (index == -1)
                    {
                        MessageBox.Show("查找结束");
                        count = -1;
                    }
                    else
                    {
                        count = index;
                        MainForm.mainfrm.Main_Text.Find(TextBox_Search.Text, count + 1, RichTextBoxFinds.MatchCase);
                        MainForm.mainfrm.Main_Text.Select(index, TextBox_Search.Text.Length);
                        MainForm.mainfrm.Activate();
                    }
                }
            }
        }
        //查找下一个的实现
        private void Button_Next_Click(object sender, EventArgs e)
        {
            Find();
            
        }

        private void Button_No_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
