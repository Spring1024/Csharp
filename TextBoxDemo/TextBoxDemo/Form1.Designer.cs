namespace TextBoxDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_Row = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_Col = new System.Windows.Forms.ToolStripStatusLabel();
            this.Text_Type = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Editor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.删除LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.查找FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找下一个NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间日期DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Aid = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1079, 576);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.statusBar_Row,
            this.statusBar_Col,
            this.Text_Type});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(929, 16);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // statusBar_Row
            // 
            this.statusBar_Row.AutoSize = false;
            this.statusBar_Row.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBar_Row.Name = "statusBar_Row";
            this.statusBar_Row.Size = new System.Drawing.Size(65, 16);
            this.statusBar_Row.Text = "1行";
            // 
            // statusBar_Col
            // 
            this.statusBar_Col.AutoSize = false;
            this.statusBar_Col.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBar_Col.Name = "statusBar_Col";
            this.statusBar_Col.Size = new System.Drawing.Size(65, 16);
            this.statusBar_Col.Text = "1列";
            // 
            // Text_Type
            // 
            this.Text_Type.Name = "Text_Type";
            this.Text_Type.Size = new System.Drawing.Size(0, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Editor,
            this.menu_Format,
            this.menu_View,
            this.menu_Help});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1079, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_NewFile,
            this.menu_OpenFile,
            this.menu_SaveFile,
            this.menu_SaveAs,
            this.toolStripMenuItem1,
            this.页面设置ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.menu_Exit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(71, 24);
            this.menu_File.Text = "文件(&F)";
            // 
            // menu_NewFile
            // 
            this.menu_NewFile.Name = "menu_NewFile";
            this.menu_NewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_NewFile.Size = new System.Drawing.Size(214, 26);
            this.menu_NewFile.Text = "新建(&N)";
            this.menu_NewFile.Click += new System.EventHandler(this.menu_NewFile_Click);
            // 
            // menu_OpenFile
            // 
            this.menu_OpenFile.Name = "menu_OpenFile";
            this.menu_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_OpenFile.Size = new System.Drawing.Size(214, 26);
            this.menu_OpenFile.Text = "打开(&O)...";
            this.menu_OpenFile.Click += new System.EventHandler(this.menu_OpenFile_Click);
            // 
            // menu_SaveFile
            // 
            this.menu_SaveFile.Name = "menu_SaveFile";
            this.menu_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_SaveFile.Size = new System.Drawing.Size(214, 26);
            this.menu_SaveFile.Text = "保存(&S)";
            this.menu_SaveFile.Click += new System.EventHandler(this.menu_SaveFile_Click);
            // 
            // menu_SaveAs
            // 
            this.menu_SaveAs.Name = "menu_SaveAs";
            this.menu_SaveAs.Size = new System.Drawing.Size(214, 26);
            this.menu_SaveAs.Text = "另存为(&A)...";
            this.menu_SaveAs.Click += new System.EventHandler(this.menu_SaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.页面设置ToolStripMenuItem.Text = "页面设置(&U)...";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.打印ToolStripMenuItem.Text = "打印(&P)...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
            // 
            // menu_Exit
            // 
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.Size = new System.Drawing.Size(214, 26);
            this.menu_Exit.Text = "退出(&X)";
            // 
            // menu_Editor
            // 
            this.menu_Editor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Undo,
            this.toolStripMenuItem3,
            this.menu_Cut,
            this.menu_Copy,
            this.menu_Paste,
            this.删除LToolStripMenuItem,
            this.toolStripMenuItem4,
            this.查找FToolStripMenuItem,
            this.查找下一个NToolStripMenuItem,
            this.替换RToolStripMenuItem,
            this.转到GToolStripMenuItem,
            this.toolStripMenuItem5,
            this.全选AToolStripMenuItem,
            this.时间日期DToolStripMenuItem});
            this.menu_Editor.Name = "menu_Editor";
            this.menu_Editor.Size = new System.Drawing.Size(71, 24);
            this.menu_Editor.Text = "编辑(&E)";
            this.menu_Editor.DropDownOpened += new System.EventHandler(this.menu_Editor_DropDownOpened);
            // 
            // menu_Undo
            // 
            this.menu_Undo.Name = "menu_Undo";
            this.menu_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menu_Undo.Size = new System.Drawing.Size(224, 26);
            this.menu_Undo.Text = "撤销(U)";
            this.menu_Undo.Click += new System.EventHandler(this.menu_undo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // menu_Cut
            // 
            this.menu_Cut.Name = "menu_Cut";
            this.menu_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menu_Cut.Size = new System.Drawing.Size(224, 26);
            this.menu_Cut.Text = "剪切(T)";
            this.menu_Cut.Click += new System.EventHandler(this.menu_cut_Click);
            // 
            // menu_Copy
            // 
            this.menu_Copy.Name = "menu_Copy";
            this.menu_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menu_Copy.Size = new System.Drawing.Size(224, 26);
            this.menu_Copy.Text = "复制(C)";
            this.menu_Copy.Click += new System.EventHandler(this.menu_Copy_Click);
            // 
            // menu_Paste
            // 
            this.menu_Paste.Name = "menu_Paste";
            this.menu_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menu_Paste.Size = new System.Drawing.Size(224, 26);
            this.menu_Paste.Text = "粘帖(P)";
            this.menu_Paste.Click += new System.EventHandler(this.menu_Paste_Click);
            // 
            // 删除LToolStripMenuItem
            // 
            this.删除LToolStripMenuItem.Name = "删除LToolStripMenuItem";
            this.删除LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.删除LToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.删除LToolStripMenuItem.Text = "删除(L)";
            this.删除LToolStripMenuItem.Click += new System.EventHandler(this.删除LToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // 查找FToolStripMenuItem
            // 
            this.查找FToolStripMenuItem.Name = "查找FToolStripMenuItem";
            this.查找FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.查找FToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查找FToolStripMenuItem.Text = "查找(F)...";
            // 
            // 查找下一个NToolStripMenuItem
            // 
            this.查找下一个NToolStripMenuItem.Name = "查找下一个NToolStripMenuItem";
            this.查找下一个NToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.查找下一个NToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查找下一个NToolStripMenuItem.Text = "查找下一个(N)";
            // 
            // 替换RToolStripMenuItem
            // 
            this.替换RToolStripMenuItem.Name = "替换RToolStripMenuItem";
            this.替换RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.替换RToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.替换RToolStripMenuItem.Text = "替换(R)...";
            // 
            // 转到GToolStripMenuItem
            // 
            this.转到GToolStripMenuItem.Name = "转到GToolStripMenuItem";
            this.转到GToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.转到GToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.转到GToolStripMenuItem.Text = "转到(G)...";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(221, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.全选AToolStripMenuItem.Text = "全选(A)";
            // 
            // 时间日期DToolStripMenuItem
            // 
            this.时间日期DToolStripMenuItem.Name = "时间日期DToolStripMenuItem";
            this.时间日期DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.时间日期DToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.时间日期DToolStripMenuItem.Text = "时间/日期(D)";
            // 
            // menu_Format
            // 
            this.menu_Format.Name = "menu_Format";
            this.menu_Format.Size = new System.Drawing.Size(75, 24);
            this.menu_Format.Text = "格式(&O)";
            // 
            // menu_View
            // 
            this.menu_View.Name = "menu_View";
            this.menu_View.Size = new System.Drawing.Size(73, 24);
            this.menu_View.Text = "查看(&V)";
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Aid,
            this.menu_About});
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(85, 24);
            this.menu_Help.Text = "帮助(&H）";
            // 
            // menu_Aid
            // 
            this.menu_Aid.Name = "menu_Aid";
            this.menu_Aid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.menu_Aid.Size = new System.Drawing.Size(205, 26);
            this.menu_Aid.Text = "查看帮助";
            // 
            // menu_About
            // 
            this.menu_About.Name = "menu_About";
            this.menu_About.Size = new System.Drawing.Size(205, 26);
            this.menu_About.Text = "关于...";
            this.menu_About.Click += new System.EventHandler(this.menu_About_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "saveFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 604);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "NotePad_spring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_Row;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_Col;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_NewFile;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem menu_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem menu_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem menu_Editor;
        private System.Windows.Forms.ToolStripMenuItem menu_Format;
        private System.Windows.Forms.ToolStripMenuItem menu_View;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem menu_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menu_Cut;
        private System.Windows.Forms.ToolStripMenuItem menu_Copy;
        private System.Windows.Forms.ToolStripMenuItem menu_Paste;
        private System.Windows.Forms.ToolStripMenuItem 删除LToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 查找FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找下一个NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到GToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间日期DToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripStatusLabel Text_Type;
        private System.Windows.Forms.ToolStripMenuItem menu_About;
        private System.Windows.Forms.ToolStripMenuItem menu_Aid;
    }
}

