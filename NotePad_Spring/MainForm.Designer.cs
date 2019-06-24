namespace MyNotePad_Spring
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.FIle_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.FIle_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.FIle_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.File_PageSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_Shear = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_FInd = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_FindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_GoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_All = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Time = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Format_Wrap = new System.Windows.Forms.ToolStripMenuItem();
            this.Format_Fonts = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.View_StatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_LookHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar_Row = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar_Col = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar_Type = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dialog_SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.Dialog_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Dialog_PageSetUp = new System.Windows.Forms.PageSetupDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.Dialog_PrintPage = new System.Windows.Forms.PrintDialog();
            this.Dialog_WordSet = new System.Windows.Forms.FontDialog();
            this.Pucker_Time = new System.Windows.Forms.DateTimePicker();
            this.Main_Text = new System.Windows.Forms.RichTextBox();
            this.Menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Edit,
            this.Menu_Format,
            this.Menu_View,
            this.Menu_Help});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(1080, 28);
            this.Menu.TabIndex = 1;
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_New,
            this.FIle_Open,
            this.FIle_Save,
            this.FIle_SaveAs,
            this.toolStripSeparator1,
            this.File_PageSelect,
            this.File_Print,
            this.toolStripSeparator2,
            this.File_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Menu_File.Size = new System.Drawing.Size(81, 24);
            this.Menu_File.Text = "文件(&F）";
            // 
            // File_New
            // 
            this.File_New.Name = "File_New";
            this.File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.File_New.Size = new System.Drawing.Size(214, 26);
            this.File_New.Text = "新建(&N)";
            this.File_New.Click += new System.EventHandler(this.File_New_Click);
            // 
            // FIle_Open
            // 
            this.FIle_Open.Name = "FIle_Open";
            this.FIle_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FIle_Open.Size = new System.Drawing.Size(214, 26);
            this.FIle_Open.Text = "打开(&O)...";
            this.FIle_Open.Click += new System.EventHandler(this.FIle_Open_Click);
            // 
            // FIle_Save
            // 
            this.FIle_Save.Name = "FIle_Save";
            this.FIle_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FIle_Save.Size = new System.Drawing.Size(214, 26);
            this.FIle_Save.Text = "保存(&S)";
            this.FIle_Save.Click += new System.EventHandler(this.FIle_Save_Click);
            // 
            // FIle_SaveAs
            // 
            this.FIle_SaveAs.Name = "FIle_SaveAs";
            this.FIle_SaveAs.Size = new System.Drawing.Size(214, 26);
            this.FIle_SaveAs.Text = "另存为(&A)...";
            this.FIle_SaveAs.Click += new System.EventHandler(this.FIle_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // File_PageSelect
            // 
            this.File_PageSelect.Name = "File_PageSelect";
            this.File_PageSelect.Size = new System.Drawing.Size(214, 26);
            this.File_PageSelect.Text = "页面设置";
            this.File_PageSelect.Click += new System.EventHandler(this.File_PageSelect_Click);
            // 
            // File_Print
            // 
            this.File_Print.Name = "File_Print";
            this.File_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.File_Print.Size = new System.Drawing.Size(214, 26);
            this.File_Print.Text = "打印(&P)...";
            this.File_Print.Click += new System.EventHandler(this.File_Print_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // File_Exit
            // 
            this.File_Exit.Name = "File_Exit";
            this.File_Exit.Size = new System.Drawing.Size(214, 26);
            this.File_Exit.Text = "退出(&X)";
            this.File_Exit.Click += new System.EventHandler(this.File_Exit_Click);
            // 
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_Undo,
            this.toolStripSeparator3,
            this.Edit_Shear,
            this.Edit_Paste,
            this.Edit_Copy,
            this.Edit_Del,
            this.toolStripSeparator4,
            this.Edit_FInd,
            this.Edit_FindNext,
            this.Edit_Replace,
            this.Edit_GoTo,
            this.toolStripSeparator5,
            this.Edit_All,
            this.Edit_Time});
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(71, 24);
            this.Menu_Edit.Text = "编辑(&E)";
            this.Menu_Edit.MouseEnter += new System.EventHandler(this.Menu_Edit_MouseEnter);
            // 
            // Edit_Undo
            // 
            this.Edit_Undo.Name = "Edit_Undo";
            this.Edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Edit_Undo.Size = new System.Drawing.Size(220, 26);
            this.Edit_Undo.Text = "撤消(&Z)";
            this.Edit_Undo.Click += new System.EventHandler(this.Edit_Undo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(217, 6);
            // 
            // Edit_Shear
            // 
            this.Edit_Shear.Enabled = false;
            this.Edit_Shear.Name = "Edit_Shear";
            this.Edit_Shear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Edit_Shear.Size = new System.Drawing.Size(220, 26);
            this.Edit_Shear.Text = "剪切(&X)";
            this.Edit_Shear.Click += new System.EventHandler(this.Edit_Shear_Click);
            // 
            // Edit_Paste
            // 
            this.Edit_Paste.Name = "Edit_Paste";
            this.Edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Edit_Paste.Size = new System.Drawing.Size(220, 26);
            this.Edit_Paste.Text = "粘贴(&V)";
            this.Edit_Paste.Click += new System.EventHandler(this.Edit_Paste_Click);
            // 
            // Edit_Copy
            // 
            this.Edit_Copy.Enabled = false;
            this.Edit_Copy.Name = "Edit_Copy";
            this.Edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Edit_Copy.Size = new System.Drawing.Size(220, 26);
            this.Edit_Copy.Text = "复制(&C)";
            this.Edit_Copy.Click += new System.EventHandler(this.Edit_Copy_Click);
            // 
            // Edit_Del
            // 
            this.Edit_Del.Enabled = false;
            this.Edit_Del.Name = "Edit_Del";
            this.Edit_Del.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Edit_Del.Size = new System.Drawing.Size(220, 26);
            this.Edit_Del.Text = "删除(&L)";
            this.Edit_Del.Click += new System.EventHandler(this.Edit_Del_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // Edit_FInd
            // 
            this.Edit_FInd.Name = "Edit_FInd";
            this.Edit_FInd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Edit_FInd.Size = new System.Drawing.Size(220, 26);
            this.Edit_FInd.Text = "查找(&F)";
            this.Edit_FInd.Click += new System.EventHandler(this.Edit_FInd_Click);
            // 
            // Edit_FindNext
            // 
            this.Edit_FindNext.Name = "Edit_FindNext";
            this.Edit_FindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.Edit_FindNext.Size = new System.Drawing.Size(220, 26);
            this.Edit_FindNext.Text = "查找下一个(&f)...";
            this.Edit_FindNext.Click += new System.EventHandler(this.Edit_FindNext_Click);
            // 
            // Edit_Replace
            // 
            this.Edit_Replace.Enabled = false;
            this.Edit_Replace.Name = "Edit_Replace";
            this.Edit_Replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.Edit_Replace.Size = new System.Drawing.Size(220, 26);
            this.Edit_Replace.Text = "替换(&R)";
            this.Edit_Replace.Click += new System.EventHandler(this.Edit_Replace_Click);
            // 
            // Edit_GoTo
            // 
            this.Edit_GoTo.Name = "Edit_GoTo";
            this.Edit_GoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Edit_GoTo.Size = new System.Drawing.Size(220, 26);
            this.Edit_GoTo.Text = "转到(&G)";
            this.Edit_GoTo.Click += new System.EventHandler(this.Edit_GoTo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(217, 6);
            // 
            // Edit_All
            // 
            this.Edit_All.Name = "Edit_All";
            this.Edit_All.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Edit_All.Size = new System.Drawing.Size(220, 26);
            this.Edit_All.Text = "全选(&A)";
            this.Edit_All.Click += new System.EventHandler(this.Edit_All_Click);
            // 
            // Edit_Time
            // 
            this.Edit_Time.Name = "Edit_Time";
            this.Edit_Time.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Edit_Time.Size = new System.Drawing.Size(220, 26);
            this.Edit_Time.Text = "时间/日期(&T)";
            this.Edit_Time.Click += new System.EventHandler(this.Edit_Time_Click);
            // 
            // Menu_Format
            // 
            this.Menu_Format.Checked = true;
            this.Menu_Format.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Format_Wrap,
            this.Format_Fonts});
            this.Menu_Format.Name = "Menu_Format";
            this.Menu_Format.Size = new System.Drawing.Size(75, 24);
            this.Menu_Format.Text = "格式(&O)";
            // 
            // Format_Wrap
            // 
            this.Format_Wrap.Checked = true;
            this.Format_Wrap.CheckOnClick = true;
            this.Format_Wrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Format_Wrap.Name = "Format_Wrap";
            this.Format_Wrap.Size = new System.Drawing.Size(177, 26);
            this.Format_Wrap.Text = "自动换行(&W)";
            this.Format_Wrap.CheckedChanged += new System.EventHandler(this.Format_Wrap_CheckedChanged);
            // 
            // Format_Fonts
            // 
            this.Format_Fonts.Name = "Format_Fonts";
            this.Format_Fonts.Size = new System.Drawing.Size(177, 26);
            this.Format_Fonts.Text = "字体(&F)";
            this.Format_Fonts.Click += new System.EventHandler(this.Format_Fonts_Click);
            // 
            // Menu_View
            // 
            this.Menu_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_StatusBar});
            this.Menu_View.Name = "Menu_View";
            this.Menu_View.Size = new System.Drawing.Size(73, 24);
            this.Menu_View.Text = "查看(&V)";
            // 
            // View_StatusBar
            // 
            this.View_StatusBar.CheckOnClick = true;
            this.View_StatusBar.Enabled = false;
            this.View_StatusBar.Name = "View_StatusBar";
            this.View_StatusBar.Size = new System.Drawing.Size(156, 26);
            this.View_StatusBar.Text = "状态栏(&S)";
            this.View_StatusBar.CheckedChanged += new System.EventHandler(this.View_StatusBar_CheckedChanged);
            // 
            // Menu_Help
            // 
            this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_LookHelp,
            this.Help_About});
            this.Menu_Help.Name = "Menu_Help";
            this.Menu_Help.Size = new System.Drawing.Size(75, 24);
            this.Menu_Help.Text = "帮助(&H)";
            // 
            // Help_LookHelp
            // 
            this.Help_LookHelp.Name = "Help_LookHelp";
            this.Help_LookHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.Help_LookHelp.Size = new System.Drawing.Size(224, 26);
            this.Help_LookHelp.Text = "查看帮助(&H)";
            this.Help_LookHelp.Click += new System.EventHandler(this.Help_LookHelp_Click);
            // 
            // Help_About
            // 
            this.Help_About.Name = "Help_About";
            this.Help_About.Size = new System.Drawing.Size(224, 26);
            this.Help_About.Text = "关于...";
            this.Help_About.Click += new System.EventHandler(this.Help_About_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.StatusBar_Row,
            this.StatusBar_Col,
            this.StatusBar_Type,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1080, 28);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(825, 22);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = " ";
            // 
            // StatusBar_Row
            // 
            this.StatusBar_Row.Name = "StatusBar_Row";
            this.StatusBar_Row.Size = new System.Drawing.Size(60, 22);
            this.StatusBar_Row.Text = "  第1行 ";
            // 
            // StatusBar_Col
            // 
            this.StatusBar_Col.Name = "StatusBar_Col";
            this.StatusBar_Col.Size = new System.Drawing.Size(56, 22);
            this.StatusBar_Col.Text = " 第1列 ";
            // 
            // StatusBar_Type
            // 
            this.StatusBar_Type.Name = "StatusBar_Type";
            this.StatusBar_Type.Size = new System.Drawing.Size(48, 22);
            this.StatusBar_Type.Text = " utf-8";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(77, 22);
            this.toolStripStatusLabel4.Text = "                 ";
            // 
            // Dialog_OpenFile
            // 
            this.Dialog_OpenFile.FileName = "openFileDialog1";
            // 
            // Dialog_PrintPage
            // 
            this.Dialog_PrintPage.UseEXDialog = true;
            // 
            // Dialog_WordSet
            // 
            this.Dialog_WordSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // Pucker_Time
            // 
            this.Pucker_Time.Location = new System.Drawing.Point(0, 565);
            this.Pucker_Time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pucker_Time.Name = "Pucker_Time";
            this.Pucker_Time.Size = new System.Drawing.Size(200, 25);
            this.Pucker_Time.TabIndex = 4;
            this.Pucker_Time.Visible = false;
            // 
            // Main_Text
            // 
            this.Main_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Text.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Main_Text.HideSelection = false;
            this.Main_Text.Location = new System.Drawing.Point(0, 28);
            this.Main_Text.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Main_Text.Name = "Main_Text";
            this.Main_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.Main_Text.Size = new System.Drawing.Size(1080, 562);
            this.Main_Text.TabIndex = 5;
            this.Main_Text.Text = "";
            this.Main_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Text_KeyDown);
            this.Main_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Text_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 590);
            this.Controls.Add(this.Main_Text);
            this.Controls.Add(this.Pucker_Time);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "新建文本文档.txt";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format;
        private System.Windows.Forms.ToolStripMenuItem Menu_View;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help;
        private System.Windows.Forms.ToolStripMenuItem File_New;
        private System.Windows.Forms.ToolStripMenuItem FIle_Open;
        private System.Windows.Forms.ToolStripMenuItem FIle_Save;
        private System.Windows.Forms.ToolStripMenuItem FIle_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem File_PageSelect;
        private System.Windows.Forms.ToolStripMenuItem File_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Edit_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Edit_Shear;
        private System.Windows.Forms.ToolStripMenuItem Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem Edit_Paste;
        private System.Windows.Forms.ToolStripMenuItem Edit_Del;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Edit_FInd;
        private System.Windows.Forms.ToolStripMenuItem Edit_FindNext;
        private System.Windows.Forms.ToolStripMenuItem Edit_Replace;
        private System.Windows.Forms.ToolStripMenuItem Edit_GoTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Edit_All;
        private System.Windows.Forms.ToolStripMenuItem Edit_Time;
        private System.Windows.Forms.ToolStripMenuItem Format_Wrap;
        private System.Windows.Forms.ToolStripMenuItem Format_Fonts;
        private System.Windows.Forms.ToolStripMenuItem View_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem Help_LookHelp;
        private System.Windows.Forms.ToolStripMenuItem Help_About;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar_Row;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar_Col;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar_Type;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.SaveFileDialog Dialog_SaveFile;
        private System.Windows.Forms.OpenFileDialog Dialog_OpenFile;
        private System.Windows.Forms.PageSetupDialog Dialog_PageSetUp;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog Dialog_PrintPage;
        private System.Windows.Forms.FontDialog Dialog_WordSet;
        private System.Windows.Forms.DateTimePicker Pucker_Time;
        public System.Windows.Forms.RichTextBox Main_Text;
    }
}

