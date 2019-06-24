namespace MyNotePad_Spring
{
    partial class Replace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replace));
            this.Label_Find = new System.Windows.Forms.Label();
            this.Label_Replace = new System.Windows.Forms.Label();
            this.TextBox_Find = new System.Windows.Forms.TextBox();
            this.Button_Find = new System.Windows.Forms.Button();
            this.Button_Replace = new System.Windows.Forms.Button();
            this.Button_ReplaceAll = new System.Windows.Forms.Button();
            this.Butten_No = new System.Windows.Forms.Button();
            this.CheckBox_Case = new System.Windows.Forms.CheckBox();
            this.TextBox_Replace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_Find
            // 
            this.Label_Find.AutoSize = true;
            this.Label_Find.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Find.Location = new System.Drawing.Point(12, 27);
            this.Label_Find.Name = "Label_Find";
            this.Label_Find.Size = new System.Drawing.Size(95, 20);
            this.Label_Find.TabIndex = 0;
            this.Label_Find.Text = "查找内容(&N):";
            // 
            // Label_Replace
            // 
            this.Label_Replace.AutoSize = true;
            this.Label_Replace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Replace.Location = new System.Drawing.Point(12, 83);
            this.Label_Replace.Name = "Label_Replace";
            this.Label_Replace.Size = new System.Drawing.Size(77, 20);
            this.Label_Replace.TabIndex = 1;
            this.Label_Replace.Text = "替换为(&P):";
            // 
            // TextBox_Find
            // 
            this.TextBox_Find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Find.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Find.Location = new System.Drawing.Point(122, 22);
            this.TextBox_Find.Name = "TextBox_Find";
            this.TextBox_Find.Size = new System.Drawing.Size(237, 31);
            this.TextBox_Find.TabIndex = 2;
            // 
            // Button_Find
            // 
            this.Button_Find.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Find.Location = new System.Drawing.Point(378, 12);
            this.Button_Find.Name = "Button_Find";
            this.Button_Find.Size = new System.Drawing.Size(114, 35);
            this.Button_Find.TabIndex = 3;
            this.Button_Find.Text = "查找下一个(&E)";
            this.Button_Find.UseVisualStyleBackColor = true;
            this.Button_Find.Click += new System.EventHandler(this.Button_Find_Click);
            // 
            // Button_Replace
            // 
            this.Button_Replace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Replace.Location = new System.Drawing.Point(378, 57);
            this.Button_Replace.Name = "Button_Replace";
            this.Button_Replace.Size = new System.Drawing.Size(114, 35);
            this.Button_Replace.TabIndex = 4;
            this.Button_Replace.Text = "替换(&R)";
            this.Button_Replace.UseVisualStyleBackColor = true;
            // 
            // Button_ReplaceAll
            // 
            this.Button_ReplaceAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_ReplaceAll.Location = new System.Drawing.Point(378, 103);
            this.Button_ReplaceAll.Name = "Button_ReplaceAll";
            this.Button_ReplaceAll.Size = new System.Drawing.Size(114, 35);
            this.Button_ReplaceAll.TabIndex = 5;
            this.Button_ReplaceAll.Text = "全部替换(&A)";
            this.Button_ReplaceAll.UseVisualStyleBackColor = true;
            this.Button_ReplaceAll.Click += new System.EventHandler(this.Button_ReplaceAll_Click);
            // 
            // Butten_No
            // 
            this.Butten_No.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Butten_No.Location = new System.Drawing.Point(378, 149);
            this.Butten_No.Name = "Butten_No";
            this.Butten_No.Size = new System.Drawing.Size(114, 35);
            this.Butten_No.TabIndex = 6;
            this.Butten_No.Text = "取消";
            this.Butten_No.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Case
            // 
            this.CheckBox_Case.AutoSize = true;
            this.CheckBox_Case.Enabled = false;
            this.CheckBox_Case.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox_Case.Location = new System.Drawing.Point(16, 181);
            this.CheckBox_Case.Name = "CheckBox_Case";
            this.CheckBox_Case.Size = new System.Drawing.Size(126, 24);
            this.CheckBox_Case.TabIndex = 7;
            this.CheckBox_Case.Text = "区分大小写(&C)";
            this.CheckBox_Case.UseVisualStyleBackColor = true;
            // 
            // TextBox_Replace
            // 
            this.TextBox_Replace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Replace.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Replace.Location = new System.Drawing.Point(122, 78);
            this.TextBox_Replace.Name = "TextBox_Replace";
            this.TextBox_Replace.Size = new System.Drawing.Size(237, 31);
            this.TextBox_Replace.TabIndex = 8;
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 233);
            this.Controls.Add(this.TextBox_Replace);
            this.Controls.Add(this.CheckBox_Case);
            this.Controls.Add(this.Butten_No);
            this.Controls.Add(this.Button_ReplaceAll);
            this.Controls.Add(this.Button_Replace);
            this.Controls.Add(this.Button_Find);
            this.Controls.Add(this.TextBox_Find);
            this.Controls.Add(this.Label_Replace);
            this.Controls.Add(this.Label_Find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Replace";
            this.Text = "替换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Find;
        private System.Windows.Forms.Label Label_Replace;
        private System.Windows.Forms.TextBox TextBox_Find;
        private System.Windows.Forms.Button Button_Find;
        private System.Windows.Forms.Button Button_Replace;
        private System.Windows.Forms.Button Button_ReplaceAll;
        private System.Windows.Forms.Button Butten_No;
        private System.Windows.Forms.CheckBox CheckBox_Case;
        private System.Windows.Forms.TextBox TextBox_Replace;
    }
}