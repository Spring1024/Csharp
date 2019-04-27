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
            this.statusBar_Row = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_Col = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Editor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘帖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.查找FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找下一个NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间日期DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(576, 324);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.statusBar_Row,
            this.statusBar_Col});
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar_Row
            // 
            this.statusBar_Row.AutoSize = false;
            this.statusBar_Row.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBar_Row.Name = "statusBar_Row";
            this.statusBar_Row.Size = new System.Drawing.Size(65, 17);
            this.statusBar_Row.Text = "1行";
            // 
            // statusBar_Col
            // 
            this.statusBar_Col.AutoSize = false;
            this.statusBar_Col.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBar_Col.Name = "statusBar_Col";
            this.statusBar_Col.Size = new System.Drawing.Size(65, 17);
            this.statusBar_Col.Text = "1列";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(431, 17);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Editor,
            this.menu_Format,
            this.menu_View,
            this.menu_Help});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(576, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.页面设置ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出XToolStripMenuItem});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(58, 21);
            this.menu_File.Text = "文件(&F)";
            this.menu_File.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // menu_Editor
            // 
            this.menu_Editor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.剪切ToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘帖ToolStripMenuItem,
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
            this.menu_Editor.Size = new System.Drawing.Size(59, 21);
            this.menu_Editor.Text = "编辑(&E)";
            // 
            // menu_Format
            // 
            this.menu_Format.Name = "menu_Format";
            this.menu_Format.Size = new System.Drawing.Size(62, 21);
            this.menu_Format.Text = "格式(&O)";
            // 
            // menu_View
            // 
            this.menu_View.Name = "menu_View";
            this.menu_View.Size = new System.Drawing.Size(60, 21);
            this.menu_View.Text = "查看(&V)";
            // 
            // menu_Help
            // 
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(69, 21);
            this.menu_Help.Text = "帮助(&H）";
            this.menu_Help.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.新建ToolStripMenuItem.Text = "新建(&N)";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.打开ToolStripMenuItem.Text = "打开(&O)...";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.另存为ToolStripMenuItem.Text = "另存为(&A)...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.页面设置ToolStripMenuItem.Text = "页面设置(&U)...";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.打印ToolStripMenuItem.Text = "打印(&P)...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.撤销ToolStripMenuItem.Text = "撤销(U)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.剪切ToolStripMenuItem.Text = "剪切(T)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.复制CToolStripMenuItem.Text = "复制(C)";
            // 
            // 粘帖ToolStripMenuItem
            // 
            this.粘帖ToolStripMenuItem.Name = "粘帖ToolStripMenuItem";
            this.粘帖ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘帖ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.粘帖ToolStripMenuItem.Text = "粘帖(P)";
            this.粘帖ToolStripMenuItem.Click += new System.EventHandler(this.粘帖ToolStripMenuItem_Click);
            // 
            // 删除LToolStripMenuItem
            // 
            this.删除LToolStripMenuItem.Name = "删除LToolStripMenuItem";
            this.删除LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.删除LToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.删除LToolStripMenuItem.Text = "删除(L)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 6);
            // 
            // 查找FToolStripMenuItem
            // 
            this.查找FToolStripMenuItem.Name = "查找FToolStripMenuItem";
            this.查找FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.查找FToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.查找FToolStripMenuItem.Text = "查找(F)...";
            // 
            // 查找下一个NToolStripMenuItem
            // 
            this.查找下一个NToolStripMenuItem.Name = "查找下一个NToolStripMenuItem";
            this.查找下一个NToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.查找下一个NToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.查找下一个NToolStripMenuItem.Text = "查找下一个(N)";
            // 
            // 替换RToolStripMenuItem
            // 
            this.替换RToolStripMenuItem.Name = "替换RToolStripMenuItem";
            this.替换RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.替换RToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.替换RToolStripMenuItem.Text = "替换(R)...";
            // 
            // 转到GToolStripMenuItem
            // 
            this.转到GToolStripMenuItem.Name = "转到GToolStripMenuItem";
            this.转到GToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.转到GToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.转到GToolStripMenuItem.Text = "转到(G)...";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(172, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.全选AToolStripMenuItem.Text = "全选(A)";
            // 
            // 时间日期DToolStripMenuItem
            // 
            this.时间日期DToolStripMenuItem.Name = "时间日期DToolStripMenuItem";
            this.时间日期DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.时间日期DToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.时间日期DToolStripMenuItem.Text = "时间/日期(D)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 349);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Editor;
        private System.Windows.Forms.ToolStripMenuItem menu_Format;
        private System.Windows.Forms.ToolStripMenuItem menu_View;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘帖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除LToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 查找FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找下一个NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到GToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间日期DToolStripMenuItem;
    }
}

