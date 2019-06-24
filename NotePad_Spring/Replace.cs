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
    public partial class Replace : Form
    {
        int count = -1;
        int index = 0;
        public Replace()
        {
            InitializeComponent();
        }
        //private void Find()
        //{
        //    if (!(String.IsNullOrEmpty(this.TextBox_Find.Text)))
        //    {
        //        if (MainForm.txt.Contains(this.TextBox_Find.Text) == false)
        //        {

        //            index = MainForm.mainfrm.Main_Text.Text.IndexOf(TextBox_Find.Text, count + 1);
        //            if (index == -1)
        //            {
        //                MessageBox.Show("查找结束");
        //                count = -1;
        //            }
        //            else
        //            {
        //                count = index;
        //                MainForm.mainfrm.Main_Text.Find(TextBox_Find.Text, count + 1, RichTextBoxFinds.MatchCase);
        //                MainForm.mainfrm.Main_Text.Select(index, TextBox_Find.Text.Length);
        //                MainForm.mainfrm.Activate();
        //            }
        //        }
        //    }
        //}

        private void Button_Find_Click(object sender, EventArgs e)
        {
            //Find();
        }

        private void Button_ReplaceAll_Click(object sender, EventArgs e)
        {
            //if (TextBox_Replace.Text!=""&&TextBox_Find.Text!="")
            //{
            //    Find();
            //    string searchString = TextBox_Find.Text;
            //    int positionToSearch = MainForm.mainfrm.Main_Text.GetCharIndexFromPosition(new Point(index, TextBox_Find.Text.Length));
            //    int textLocation = MainForm.mainfrm.Main_Text.Find(searchString, positionToSearch, RichTextBoxFinds.None);
            //    if (textLocation >= 0)
            //    {
            //        MessageBox.Show("查找到了"+textLocation.ToString());
            //    }
            //    else
            //    {
            //        MessageBox.Show("没查找到");
            //    }
            //    MainForm.mainfrm.Main_Text.Text.Replace(MainForm.mainfrm.Main_Text.SelectedRtf, TextBox_Replace.Text);
            //}
        }
    }
}
