namespace MyNotePad_Spring
{
    partial class GoTo
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
            this.GoTo_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_No = new System.Windows.Forms.Button();
            this.Button_Yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoTo_Text
            // 
            this.GoTo_Text.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoTo_Text.Location = new System.Drawing.Point(12, 64);
            this.GoTo_Text.Name = "GoTo_Text";
            this.GoTo_Text.Size = new System.Drawing.Size(373, 31);
            this.GoTo_Text.TabIndex = 0;
            this.GoTo_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GoTo_Text_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "行号(&L):";
            // 
            // Button_No
            // 
            this.Button_No.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_No.Location = new System.Drawing.Point(278, 122);
            this.Button_No.Name = "Button_No";
            this.Button_No.Size = new System.Drawing.Size(107, 33);
            this.Button_No.TabIndex = 3;
            this.Button_No.Text = "取消";
            this.Button_No.UseVisualStyleBackColor = true;
            this.Button_No.Click += new System.EventHandler(this.Button_No_Click);
            // 
            // Button_Yes
            // 
            this.Button_Yes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Yes.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Yes.Location = new System.Drawing.Point(155, 122);
            this.Button_Yes.Name = "Button_Yes";
            this.Button_Yes.Size = new System.Drawing.Size(107, 33);
            this.Button_Yes.TabIndex = 4;
            this.Button_Yes.Text = "转到";
            this.Button_Yes.UseVisualStyleBackColor = true;
            this.Button_Yes.Click += new System.EventHandler(this.Button_Yes_Click);
            // 
            // GoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Yes;
            this.ClientSize = new System.Drawing.Size(397, 167);
            this.Controls.Add(this.Button_Yes);
            this.Controls.Add(this.Button_No);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoTo_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoTo";
            this.ShowInTaskbar = false;
            this.Text = "转到指定行";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoTo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GoTo_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_No;
        private System.Windows.Forms.Button Button_Yes;
    }
}