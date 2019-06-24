using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyNotePad_Spring
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //查看帮助的实现
        private void Help_About_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }catch(Exception ex)
            {
                MessageBox.Show("找不到该网站，请通过QQ联系:1819669614");
            }
        }


        //LinkLabel连接至网页
        //通过使用Diagnostics下的process的start方法。
        //为防止报错，需要对其进行异常捕捉
        private void VisitLink()
        {
            Help_About_Link.LinkVisited = true;
            System.Diagnostics.Process.Start("www.spring_xzc.com");
        }

        //点击确定按钮，关闭页面
        private void Help_About_Button_Click(object sender, EventArgs e) 
        { 
            Close(); 
        }
    }
}
