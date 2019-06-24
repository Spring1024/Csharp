using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad_Spring
{
    public partial class MainForm : Form
    {
        public static MainForm mainfrm = null;
        public static string txt = "";
        public static int MaxRowNum=0;
        public static int NowRowNum = 1;
        private string _FileName = "";//文件名
        private Encoding _FileEncode = Encoding.UTF8;//系统默认编码为ANSI：Encoding.Default
        private bool _IsSaved = true;//是否已保存

        //将PrintDialog时间的docToPrint连接到已定义的事件处理方法。
        private System.Drawing.Printing.PrintDocument docToPrint =new System.Drawing.Printing.PrintDocument();

        public MainForm()
        {
            InitializeComponent();
            mainfrm = this;
        }

        //打开文件的实现
        private void OpenFile()
        {
            if (!_IsSaved)
            {
                DialogResult dr = MessageBox.Show(this, "当前文本已修改，需要保存吗？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SaveFile();
                }
                if (dr == DialogResult.No || dr == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (Dialog_OpenFile.ShowDialog() == DialogResult.OK)
            {
                _FileName = Dialog_OpenFile.FileName;
                this.Text = _FileName;//对话框显示所打开的文件名
                _FileEncode = TextEncodingType.GetType(_FileName);
                this.StatusBar_Type.Text = _FileEncode.EncodingName;
                StreamReader sr = new StreamReader(_FileName, _FileEncode);
                Main_Text.Text = sr.ReadToEnd();
                sr.Close();
                _IsSaved = true;
                SetRank(false);
            }
        }

        //新建文件的实现
        private void NewFile()
        {
            if (Main_Text != null)
            {
                if (!_IsSaved)//判断已打开的文件是否保存，如果没有保存，则提示用户是否需要保存
                {
                    //弹出对话框，提示用户。
                    DialogResult dr = MessageBox.Show(this, "当前文本已修改，需要保存吗？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)//如果用户选择同意保存，则执行保存函数
                    {
                        SaveFile();
                    }
                    else if (dr == DialogResult.Cancel)//如果用户选择不保存，则返回。
                    {
                        return;
                    }
                }
            }
            //如果未打开文件，则清除文本框的内容
            Main_Text.Clear();
            _FileName = "";
            _IsSaved = true;
            this.Text = "新建文本文档";

            SetRank(false);
        }

        //保存文件的实现
        private void SaveFile()
        {
            if (_FileName == "")
            {
               if (Dialog_SaveFile.ShowDialog() == DialogResult.OK)
                {
                    _FileName = Dialog_SaveFile.FileName;
                }
                else
                {
                    return;
                }
            }
            IOStream(_FileName);
        }

        //打印文件的页面设置的实现
        private void SetPage()
        {
            if (Main_Text.Text != null)
            {
                //Dialog_PageSetUp.Document =printDocument;
                //Dialog_PageSetUp.ShowDialog();

                //上两行代码使用PageSetUpDialog框架，把Document赋给DocumentDialog框架，同样可实现页面设置。
                //暂时不知其差别。


                //使用PageSetUpDialog框架来进行页面设置
                Dialog_PageSetUp.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                Dialog_PageSetUp.PageSettings = new System.Drawing.Printing.PageSettings();
                
                Dialog_PageSetUp.ShowNetwork = false;
                DialogResult result = Dialog_PageSetUp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    object[] results = new object[]{
                    Dialog_PageSetUp.PageSettings.Margins,
                    Dialog_PageSetUp.PageSettings.PaperSize,
                    Dialog_PageSetUp.PageSettings.Landscape,
                    Dialog_PageSetUp.PrinterSettings.PrinterName,
                    Dialog_PageSetUp.PrinterSettings.PrintRange};
                    
                }
            }
        }

        //打印文件的实现
        private void printPage()
        {
            Dialog_PrintPage.AllowSomePages = true;
            Dialog_PrintPage.ShowHelp = true;
            Dialog_PrintPage.Document = docToPrint;
            DialogResult result = Dialog_PrintPage.ShowDialog();
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }
        private void document_PrintPage(object sender,System.Drawing.Printing.PrintPageEventArgs e)
            {

                // Insert code to render the page here.
                // This code will be called when the control is drawn.

                // The following code will render a simple
                // message on the printed document.
                string text = "In document_PrintPage method.";
                System.Drawing.Font printFont = new System.Drawing.Font
                    ("Arial", 35, System.Drawing.FontStyle.Regular);

                // Draw the content.
                e.Graphics.DrawString(text, printFont,
                    System.Drawing.Brushes.Black, 10, 10);
            }

        //字体格式设置的实现
        private void SetWord()
        {
            Dialog_WordSet.ShowColor = true;
            Dialog_WordSet.Font = Main_Text.Font;
            Dialog_WordSet.Color = Main_Text.ForeColor;
            if (Dialog_WordSet.ShowDialog() != DialogResult)
            {
                Main_Text.Font = Dialog_WordSet.Font;
                Main_Text.ForeColor = Dialog_WordSet.Color;
            }
        }

        //输入时间的实现
        private void Time()
        {
            
            Main_Text.Text = this.Main_Text.Text.Insert(this.Main_Text.SelectionStart,Pucker_Time.Value.ToString());
        }

        //文件输入输出的实现
        private void IOStream(String fileName)
        {
            StreamWriter sW = new StreamWriter(fileName, false, _FileEncode);
            sW.WriteLine(Main_Text);
            sW.Flush();
            sW.Close();
            _IsSaved = true;
            this.Text = _FileName;
        }

        //复制、撤销、剪切、粘贴、查找、查找下一个等控件的启用与否
        private void IsEnable()
        {
            if (Main_Text.Text != "")
            {
                Edit_FInd.Enabled = true;
                Edit_FindNext.Enabled = true;
                if (Main_Text.SelectedText != "")
                {
                    Edit_Copy.Enabled = true;
                    Edit_Del.Enabled = true;
                    Edit_Shear.Enabled = true;                   
                }
                else
                {
                    Edit_Copy.Enabled = false;
                    Edit_Del.Enabled = false;
                    Edit_Shear.Enabled = false;
                }
            }
            else
            {
                Edit_FInd.Enabled = false;
                Edit_FindNext.Enabled = false;
            }
            
        }

        //“关于”页面的实现
        private void Help_About_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.ShowDialog();
        }

        //检测文本行、列数
        private void SetRank(Boolean temp)//加入参数，判断是否按下了Enter键
        {
            int totalline = Main_Text.GetLineFromCharIndex(Main_Text.TextLength) + 1;
            int index = Main_Text.GetFirstCharIndexOfCurrentLine();

            //以下两行代码当用户按下Enter键时，无法正确判断行、列数。
            //因此，需要加入判断条件。
            int row = Main_Text.GetLineFromCharIndex(index) + 1;
            int col = Main_Text.SelectionStart-index + 1;
            if (temp == true)//如果按下Enter键，则行数+1,列数重新设置为1
            {
                row = row + 1;
                col = 1;
            }
            StatusBar_Row.Text = " 第" + row + "行 ";
            StatusBar_Col.Text = " 第" + col + "列 ";
            NowRowNum = row;
        }

        //跳转至某一行数的实现
        private void ToLine()
        {
            //RichTextBox中的GetFirstCharIndexFromLine可以获取指定行数的首个字符
            Main_Text.SelectionStart = Main_Text.GetFirstCharIndexFromLine(GoTo.SetNum- 1);
            //使光标选定的字符字数为0；
            Main_Text.SelectionLength = 0;
            //在该处设置焦点
            Main_Text.Focus();
            //将光标移至焦点
            Main_Text.ScrollToCaret();
        }

        //检测用户是否键入按键
        private void Main_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetRank(true);
            }
            else
            {
                SetRank(false);
            }
 
        }

        //检测用户是否使用鼠标点击主文本框
        private void Main_Text_MouseDown(object sender, MouseEventArgs e)
        {
            SetRank(false);
        }

        //"格式"一栏中"自动换行"的实现
        private void Format_Wrap_CheckedChanged(object sender, EventArgs e)
        {
            if (Format_Wrap.Checked == true)
            {
                Main_Text.WordWrap = true;//主文本框自动换行控件开启
                View_StatusBar.Enabled = false;//"查看"一栏中"状态栏"控件关闭
                View_StatusBar.Checked = false;//"查看"一栏中"状态栏"控件的选中状态更改为关闭
                statusStrip1.Visible = false;//隐藏最下方的状态栏
                
            }
            if (Format_Wrap.Checked == false)
            {
                Main_Text.WordWrap = false;//主文本框自动换行控件关闭
                View_StatusBar.Enabled = true;//"查看"一栏中"状态栏"控件开启
            }
        }

        //"查看"一栏中"状态栏"控件的选中状态更改
        private void View_StatusBar_CheckedChanged(object sender, EventArgs e)
        {
            if (View_StatusBar.Checked == true)
            {
                statusStrip1.Visible = true;//当"状态栏"控件为选中状态时，显示下方状态栏
            }
            if (View_StatusBar.Checked == false)
            {
                statusStrip1.Visible = false;//当"状态栏"控件为未选中状态时，隐藏下方状态栏
            }
        }

        //撤消功能的实现
        private void Edit_Undo_Click(object sender, EventArgs e)
        {
            Main_Text.Undo();
            SetRank(false);
        }

        //剪切功能的实现
        private void Edit_Shear_Click(object sender, EventArgs e)
        {
                
                if (Main_Text.SelectedText!="")
                {
                    Edit_Shear.Enabled = true;
                    Main_Text.Cut();
                    SetRank(false);
                }
        }

        //复制功能的实现
        private void Edit_Copy_Click(object sender, EventArgs e)
        {
            if (Main_Text.SelectedText != "")
            {
                Edit_Copy.Enabled = true;
                Main_Text.Copy();
                SetRank(false);
            }
        }

        //粘贴功能的实现
        private void Edit_Paste_Click(object sender, EventArgs e)
        {
            Main_Text.Paste();
            SetRank(false);
        }

        //删除功能的实现
        private void Edit_Del_Click(object sender, EventArgs e)
        {
            if (Main_Text.SelectedText != "")
            {
                Main_Text.SelectedText = "";
                SetRank(false);
            }
        }

        //退出功能的实现
        private void File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新建功能的实现
        private void File_New_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        //打开功能的实现
        private void FIle_Open_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        //保存功能的实现
        private void FIle_Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        //另存为功能的实现
        private void FIle_SaveAs_Click(object sender, EventArgs e)
        {
            Dialog_OpenFile.FileName = _FileName;
            _FileName = "";
            SaveFile();
        }

        //打印功能的实现
        private void File_Print_Click(object sender, EventArgs e)
        {
            printPage();
        }

        //页面设置的实现
        private void File_PageSelect_Click(object sender, EventArgs e)
        {
            SetPage();
        }

        //字体设置的实现
        private void Format_Fonts_Click(object sender, EventArgs e)
        {
            SetWord();
        }

        //插入时间和日期的实现
        private void Edit_Time_Click(object sender, EventArgs e)
        { 
            Time();
            SetRank(false);
        }

        //查看帮助的实现
        private void Help_LookHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.baidu.com");
        }

        //全选功能的实现
        private void Edit_All_Click(object sender, EventArgs e)
        {
            Main_Text.SelectAll();
        }

        //查找功能的实现
        private void Edit_FInd_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        //"编辑"一栏中某些控件的启用与否的实现
        private void Menu_Edit_MouseEnter(object sender, EventArgs e)
        {
            IsEnable();
        }

        //转到功能的实现
        private void Edit_GoTo_Click(object sender, EventArgs e)
        {
            SetRank(false);
            MaxRowNum = Main_Text.Lines.Length;
            GoTo GoTo= new GoTo();
            GoTo.ShowDialog();
            ToLine();
            SetRank(false);
        }

        //查找下一个功能的实现
        private void Edit_FindNext_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            if (search.TextBox_Search.Text == "")
            {
                search.ShowDialog();
            }
            else
            {
                Search.search.Find();
            }
        }

        //替换功能的实现
        private void Edit_Replace_Click(object sender, EventArgs e)
        {
            Replace replace = new Replace();
            replace.ShowDialog();
        }
    }
}