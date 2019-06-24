namespace MyNotePad_Spring
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.TextBox_Search = new System.Windows.Forms.TextBox();
            this.Label_Search = new System.Windows.Forms.Label();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Button_No = new System.Windows.Forms.Button();
            this.Group_Dir = new System.Windows.Forms.GroupBox();
            this.CheckBox_Down = new System.Windows.Forms.CheckBox();
            this.CheckBox_Up = new System.Windows.Forms.CheckBox();
            this.CheckBox_Case = new System.Windows.Forms.CheckBox();
            this.Group_Dir.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Search.Location = new System.Drawing.Point(105, 18);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(295, 30);
            this.TextBox_Search.TabIndex = 0;
            // 
            // Label_Search
            // 
            this.Label_Search.AutoSize = true;
            this.Label_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Search.Location = new System.Drawing.Point(3, 22);
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(95, 20);
            this.Label_Search.TabIndex = 1;
            this.Label_Search.Text = "查找内容(&N):";
            // 
            // Button_Next
            // 
            this.Button_Next.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Next.Location = new System.Drawing.Point(421, 13);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(118, 36);
            this.Button_Next.TabIndex = 2;
            this.Button_Next.Text = "查找下一个(&F)";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Button_No
            // 
            this.Button_No.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_No.Location = new System.Drawing.Point(421, 61);
            this.Button_No.Name = "Button_No";
            this.Button_No.Size = new System.Drawing.Size(118, 36);
            this.Button_No.TabIndex = 3;
            this.Button_No.Text = "取消";
            this.Button_No.UseVisualStyleBackColor = true;
            this.Button_No.Click += new System.EventHandler(this.Button_No_Click);
            // 
            // Group_Dir
            // 
            this.Group_Dir.Controls.Add(this.CheckBox_Down);
            this.Group_Dir.Controls.Add(this.CheckBox_Up);
            this.Group_Dir.Enabled = false;
            this.Group_Dir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Group_Dir.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Group_Dir.Location = new System.Drawing.Point(200, 69);
            this.Group_Dir.Name = "Group_Dir";
            this.Group_Dir.Size = new System.Drawing.Size(200, 69);
            this.Group_Dir.TabIndex = 5;
            this.Group_Dir.TabStop = false;
            this.Group_Dir.Text = "方向";
            // 
            // CheckBox_Down
            // 
            this.CheckBox_Down.AutoSize = true;
            this.CheckBox_Down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBox_Down.Location = new System.Drawing.Point(112, 34);
            this.CheckBox_Down.Name = "CheckBox_Down";
            this.CheckBox_Down.Size = new System.Drawing.Size(79, 24);
            this.CheckBox_Down.TabIndex = 1;
            this.CheckBox_Down.Text = "向下(&D)";
            this.CheckBox_Down.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Up
            // 
            this.CheckBox_Up.AutoSize = true;
            this.CheckBox_Up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBox_Up.Location = new System.Drawing.Point(7, 34);
            this.CheckBox_Up.Name = "CheckBox_Up";
            this.CheckBox_Up.Size = new System.Drawing.Size(79, 24);
            this.CheckBox_Up.TabIndex = 0;
            this.CheckBox_Up.Text = "向上(&U)";
            this.CheckBox_Up.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Case
            // 
            this.CheckBox_Case.AutoSize = true;
            this.CheckBox_Case.Enabled = false;
            this.CheckBox_Case.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBox_Case.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox_Case.Location = new System.Drawing.Point(7, 114);
            this.CheckBox_Case.Name = "CheckBox_Case";
            this.CheckBox_Case.Size = new System.Drawing.Size(123, 24);
            this.CheckBox_Case.TabIndex = 6;
            this.CheckBox_Case.Text = "区分大小写(&C)";
            this.CheckBox_Case.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 150);
            this.Controls.Add(this.CheckBox_Case);
            this.Controls.Add(this.Group_Dir);
            this.Controls.Add(this.Button_No);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.Label_Search);
            this.Controls.Add(this.TextBox_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.Text = "查找";
            this.Group_Dir.ResumeLayout(false);
            this.Group_Dir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextBox_Search;
        private System.Windows.Forms.Label Label_Search;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Button Button_No;
        private System.Windows.Forms.GroupBox Group_Dir;
        private System.Windows.Forms.CheckBox CheckBox_Down;
        private System.Windows.Forms.CheckBox CheckBox_Up;
        private System.Windows.Forms.CheckBox CheckBox_Case;
    }
}