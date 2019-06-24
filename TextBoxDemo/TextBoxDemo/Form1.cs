using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        private string _FileName = "";//文件名
        private Encoding _FileEncode = Encoding.UTF8;//系统默认编码为ANSI：Encoding.Default
        private bool _IsSaved = true;//是否已保存
        private void SaveTextFile(string fileName)
        {
            StreamWriter sWrite = new StreamWriter(fileName, false, _FileEncode);
            sWrite.WriteLine(textBox1.Text);
            sWrite.Flush();//文件流
            sWrite.Close();//最后要关闭写入状态
            _IsSaved = true;
            this.Text = _FileName;
        }
        public Form1()
        {
            InitializeComponent();
            this.Text_Type.Text = _FileEncode.EncodingName;
        }

        //检索文本行列数
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
        
        //新建文本文件
        private void NewFile()
        {
            if (!_IsSaved)
            {
                DialogResult dResult = MessageBox.Show(this, "当前文本已修改，需要保存吗？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dResult == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (dResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            textBox1.Clear();
            _FileName = "";
            _IsSaved = true;
            this.Text = "新建文本文档";

            setRank();
        }

        //打开文本文件
        private void OpenFile()
        {
            if (!_IsSaved)
            {
                DialogResult dResult = MessageBox.Show(this, "当前文本已修改，需要保存吗？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dResult == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (dResult == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _FileName = openFileDialog1.FileName;
                this.Text = _FileName;//对话框显示所打开的文件名
                _FileEncode = TextEncodingType.GetType(_FileName);//调用自定义静态类，自动获取文件的编码类型
                this.Text_Type.Text = _FileEncode.EncodingName;
                System.IO.StreamReader sr = new System.IO.StreamReader(_FileName, _FileEncode);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                _IsSaved = true;
                setRank();
            }
        }
        private void menu_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        //保存文本文件
        private void SaveFile()
        {

            //_FileName = "c:\\mm.txt";
            if (_FileName=="")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _FileName = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }
            SaveTextFile(_FileName);
        }
        private void menu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_NewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _IsSaved = false;
        }

        private void menu_SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = _FileName;
            _FileName = "";
            SaveFile();
        }

        private void menu_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void menu_undo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void menu_cut_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            textBox1.Cut();
        }

        private void menu_Editor_DropDownOpened(object sender, EventArgs e)
        {
            menu_Undo.Enabled = textBox1.CanUndo;

            menu_Copy.Enabled = textBox1.SelectedText != "";// textBox1.SelectionLength > 0; //判断是否选中了文本信息
            menu_Cut.Enabled = menu_Copy.Enabled;
            menu_Paste.Enabled = Clipboard.ContainsText();//判断剪切板中最后一次复制或剪切的内容是否是文本信息
        }

        private void menu_Copy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Copy();
            }
            
        }

        private void menu_Paste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        //弹出关于窗口
        private void menu_About_Click(object sender, EventArgs e)
        {
            About aForm = new About();
            aForm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void 删除LToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
