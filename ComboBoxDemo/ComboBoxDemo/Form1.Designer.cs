namespace ComboBoxDemo
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
            this.ComboBox_1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radBut_simple = new System.Windows.Forms.RadioButton();
            this.radBut_dropdownlist = new System.Windows.Forms.RadioButton();
            this.radBut_dropdown = new System.Windows.Forms.RadioButton();
            this.But_01 = new System.Windows.Forms.Button();
            this.But_02 = new System.Windows.Forms.Button();
            this.But_04 = new System.Windows.Forms.Button();
            this.But_03 = new System.Windows.Forms.Button();
            this.But_05 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Button_Get = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(12, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 26);
            this.textBox1.TabIndex = 0;
            // 
            // ComboBox_1
            // 
            this.ComboBox_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBox_1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_1.FormattingEnabled = true;
            this.ComboBox_1.Items.AddRange(new object[] {
            "北京",
            "上海",
            "江西",
            "广东",
            "重庆"});
            this.ComboBox_1.Location = new System.Drawing.Point(12, 12);
            this.ComboBox_1.Name = "ComboBox_1";
            this.ComboBox_1.Size = new System.Drawing.Size(202, 27);
            this.ComboBox_1.TabIndex = 3;
            this.ComboBox_1.Text = "北京";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBut_dropdown);
            this.groupBox2.Controls.Add(this.radBut_dropdownlist);
            this.groupBox2.Controls.Add(this.radBut_simple);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ComboBox外观选择：";
            // 
            // radBut_simple
            // 
            this.radBut_simple.AutoSize = true;
            this.radBut_simple.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radBut_simple.Location = new System.Drawing.Point(24, 56);
            this.radBut_simple.Name = "radBut_simple";
            this.radBut_simple.Size = new System.Drawing.Size(73, 18);
            this.radBut_simple.TabIndex = 9;
            this.radBut_simple.Text = "simple";
            this.radBut_simple.UseVisualStyleBackColor = true;
            this.radBut_simple.CheckedChanged += new System.EventHandler(this.radBut_simple_CheckedChanged);
            // 
            // radBut_dropdownlist
            // 
            this.radBut_dropdownlist.AutoSize = true;
            this.radBut_dropdownlist.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radBut_dropdownlist.Location = new System.Drawing.Point(299, 56);
            this.radBut_dropdownlist.Name = "radBut_dropdownlist";
            this.radBut_dropdownlist.Size = new System.Drawing.Size(121, 18);
            this.radBut_dropdownlist.TabIndex = 10;
            this.radBut_dropdownlist.Text = "dropdwonlist";
            this.radBut_dropdownlist.UseVisualStyleBackColor = true;
            this.radBut_dropdownlist.CheckedChanged += new System.EventHandler(this.radBut_dropdownlist_CheckedChanged);
            // 
            // radBut_dropdown
            // 
            this.radBut_dropdown.AutoSize = true;
            this.radBut_dropdown.Checked = true;
            this.radBut_dropdown.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radBut_dropdown.Location = new System.Drawing.Point(156, 56);
            this.radBut_dropdown.Name = "radBut_dropdown";
            this.radBut_dropdown.Size = new System.Drawing.Size(89, 18);
            this.radBut_dropdown.TabIndex = 11;
            this.radBut_dropdown.TabStop = true;
            this.radBut_dropdown.Text = "dropdwon";
            this.radBut_dropdown.UseVisualStyleBackColor = true;
            this.radBut_dropdown.CheckedChanged += new System.EventHandler(this.radBut_dropdown_CheckedChanged);
            // 
            // But_01
            // 
            this.But_01.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_01.Location = new System.Drawing.Point(12, 99);
            this.But_01.Name = "But_01";
            this.But_01.Size = new System.Drawing.Size(92, 28);
            this.But_01.TabIndex = 9;
            this.But_01.Text = "新增内容";
            this.But_01.UseVisualStyleBackColor = true;
            this.But_01.Click += new System.EventHandler(this.But_01_Click);
            // 
            // But_02
            // 
            this.But_02.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_02.Location = new System.Drawing.Point(122, 99);
            this.But_02.Name = "But_02";
            this.But_02.Size = new System.Drawing.Size(92, 28);
            this.But_02.TabIndex = 10;
            this.But_02.Text = "插入内容";
            this.But_02.UseVisualStyleBackColor = true;
            this.But_02.Click += new System.EventHandler(this.But_02_Click);
            // 
            // But_04
            // 
            this.But_04.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_04.Location = new System.Drawing.Point(122, 140);
            this.But_04.Name = "But_04";
            this.But_04.Size = new System.Drawing.Size(92, 28);
            this.But_04.TabIndex = 11;
            this.But_04.Text = "删除当前行";
            this.But_04.UseVisualStyleBackColor = true;
            this.But_04.Click += new System.EventHandler(this.But_04_Click);
            // 
            // But_03
            // 
            this.But_03.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_03.Location = new System.Drawing.Point(12, 140);
            this.But_03.Name = "But_03";
            this.But_03.Size = new System.Drawing.Size(92, 28);
            this.But_03.TabIndex = 12;
            this.But_03.Text = "删除文本内容";
            this.But_03.UseVisualStyleBackColor = true;
            this.But_03.Click += new System.EventHandler(this.But_03_Click);
            // 
            // But_05
            // 
            this.But_05.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.But_05.Location = new System.Drawing.Point(12, 181);
            this.But_05.Name = "But_05";
            this.But_05.Size = new System.Drawing.Size(92, 28);
            this.But_05.TabIndex = 13;
            this.But_05.Text = "清空列表项";
            this.But_05.UseVisualStyleBackColor = true;
            this.But_05.Click += new System.EventHandler(this.But_05_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.But_01);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.Button_Get);
            this.splitContainer1.Size = new System.Drawing.Size(482, 230);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 14;
            // 
            // Button_Get
            // 
            this.Button_Get.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Get.Location = new System.Drawing.Point(16, 12);
            this.Button_Get.Name = "Button_Get";
            this.Button_Get.Size = new System.Drawing.Size(223, 27);
            this.Button_Get.TabIndex = 0;
            this.Button_Get.Text = "获取左侧combobox选中信息";
            this.Button_Get.UseVisualStyleBackColor = true;
            this.Button_Get.Click += new System.EventHandler(this.Button_Get_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(16, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 179);
            this.textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 330);
            this.Controls.Add(this.But_05);
            this.Controls.Add(this.But_03);
            this.Controls.Add(this.But_04);
            this.Controls.Add(this.But_02);
            this.Controls.Add(this.ComboBox_1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "ComboBoxDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ComboBox_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBut_dropdown;
        private System.Windows.Forms.RadioButton radBut_dropdownlist;
        private System.Windows.Forms.RadioButton radBut_simple;
        private System.Windows.Forms.Button But_01;
        private System.Windows.Forms.Button But_02;
        private System.Windows.Forms.Button But_04;
        private System.Windows.Forms.Button But_03;
        private System.Windows.Forms.Button But_05;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Button_Get;
        private System.Windows.Forms.TextBox textBox2;
    }
}

