namespace test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.RB = new System.Windows.Forms.GroupBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbJ = new System.Windows.Forms.CheckBox();
            this.cbCs = new System.Windows.Forms.CheckBox();
            this.cbCpp = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbPython = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "학과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "학년";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "학번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "선호\r\n하는\r\n언어";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 17);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(94, 16);
            this.rb1.TabIndex = 5;
            this.rb1.TabStop = true;
            this.rb1.Text = "의료IT공학과";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 39);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(71, 16);
            this.rb2.TabIndex = 6;
            this.rb2.TabStop = true;
            this.rb2.Text = "의공학과";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(6, 61);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(107, 16);
            this.rb3.TabIndex = 7;
            this.rb3.TabStop = true;
            this.rb3.Text = "의료신소재학과";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(6, 83);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(107, 16);
            this.rb4.TabIndex = 8;
            this.rb4.TabStop = true;
            this.rb4.Text = "제약생명공학과";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(6, 105);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(131, 16);
            this.rb5.TabIndex = 9;
            this.rb5.TabStop = true;
            this.rb5.Text = "의료공간디자인학과";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // RB
            // 
            this.RB.Controls.Add(this.rb1);
            this.RB.Controls.Add(this.rb5);
            this.RB.Controls.Add(this.rb2);
            this.RB.Controls.Add(this.rb4);
            this.RB.Controls.Add(this.rb3);
            this.RB.Location = new System.Drawing.Point(81, 12);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(207, 131);
            this.RB.TabIndex = 10;
            this.RB.TabStop = false;
            // 
            // cb
            // 
            this.cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb.Location = new System.Drawing.Point(81, 155);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 20);
            this.cb.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbJ);
            this.groupBox2.Controls.Add(this.cbCs);
            this.groupBox2.Controls.Add(this.cbCpp);
            this.groupBox2.Controls.Add(this.cbC);
            this.groupBox2.Controls.Add(this.cbPython);
            this.groupBox2.Location = new System.Drawing.Point(81, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // cbJ
            // 
            this.cbJ.AutoSize = true;
            this.cbJ.Location = new System.Drawing.Point(7, 99);
            this.cbJ.Name = "cbJ";
            this.cbJ.Size = new System.Drawing.Size(54, 16);
            this.cbJ.TabIndex = 4;
            this.cbJ.Text = "JAVA";
            this.cbJ.UseVisualStyleBackColor = true;
            // 
            // cbCs
            // 
            this.cbCs.AutoSize = true;
            this.cbCs.Location = new System.Drawing.Point(7, 79);
            this.cbCs.Name = "cbCs";
            this.cbCs.Size = new System.Drawing.Size(39, 16);
            this.cbCs.TabIndex = 3;
            this.cbCs.Text = "C#";
            this.cbCs.UseVisualStyleBackColor = true;
            // 
            // cbCpp
            // 
            this.cbCpp.AutoSize = true;
            this.cbCpp.Location = new System.Drawing.Point(7, 59);
            this.cbCpp.Name = "cbCpp";
            this.cbCpp.Size = new System.Drawing.Size(45, 16);
            this.cbCpp.TabIndex = 2;
            this.cbCpp.Text = "C++";
            this.cbCpp.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(7, 39);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(33, 16);
            this.cbC.TabIndex = 1;
            this.cbC.Text = "C";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbPython
            // 
            this.cbPython.AutoSize = true;
            this.cbPython.Location = new System.Drawing.Point(7, 19);
            this.cbPython.Name = "cbPython";
            this.cbPython.Size = new System.Drawing.Size(60, 16);
            this.cbPython.TabIndex = 0;
            this.cbPython.Text = "파이썬";
            this.cbPython.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.RB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "학생정보";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RB.ResumeLayout(false);
            this.RB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.GroupBox RB;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbJ;
        private System.Windows.Forms.CheckBox cbCs;
        private System.Windows.Forms.CheckBox cbCpp;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbPython;
        private System.Windows.Forms.Button button1;
    }
}

