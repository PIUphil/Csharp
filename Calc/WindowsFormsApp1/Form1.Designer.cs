
namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btSquare = new System.Windows.Forms.Button();
            this.btRoot = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.btEqual = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Gulim", 12F);
            this.textBox1.Location = new System.Drawing.Point(14, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 223);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(114, 73);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(132, 223);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(114, 73);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(252, 223);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(114, 73);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(12, 144);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(114, 73);
            this.bt4.TabIndex = 16;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(132, 144);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(114, 73);
            this.bt5.TabIndex = 15;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(252, 144);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(114, 73);
            this.bt6.TabIndex = 14;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(12, 65);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(114, 73);
            this.bt7.TabIndex = 17;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(132, 65);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(114, 73);
            this.bt8.TabIndex = 18;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(252, 65);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(114, 73);
            this.bt9.TabIndex = 19;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(12, 302);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(114, 73);
            this.bt0.TabIndex = 8;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(372, 144);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(80, 73);
            this.btPlus.TabIndex = 13;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(372, 223);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(80, 73);
            this.btMinus.TabIndex = 12;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMulti
            // 
            this.btMulti.Location = new System.Drawing.Point(372, 302);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(80, 73);
            this.btMulti.TabIndex = 5;
            this.btMulti.Text = "*";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.btMulti_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(372, 381);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(80, 73);
            this.btDiv.TabIndex = 3;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btSquare
            // 
            this.btSquare.Location = new System.Drawing.Point(132, 302);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(114, 73);
            this.btSquare.TabIndex = 7;
            this.btSquare.Text = "^";
            this.btSquare.UseVisualStyleBackColor = true;
            this.btSquare.Click += new System.EventHandler(this.btSquare_Click);
            // 
            // btRoot
            // 
            this.btRoot.Location = new System.Drawing.Point(252, 302);
            this.btRoot.Name = "btRoot";
            this.btRoot.Size = new System.Drawing.Size(114, 73);
            this.btRoot.TabIndex = 6;
            this.btRoot.Text = "√";
            this.btRoot.UseVisualStyleBackColor = true;
            this.btRoot.Click += new System.EventHandler(this.btRoot_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(132, 381);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(114, 73);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "←";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(373, 65);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(80, 73);
            this.btClear.TabIndex = 20;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDot
            // 
            this.btDot.Location = new System.Drawing.Point(12, 381);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(114, 73);
            this.btDot.TabIndex = 4;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.btDot_Click);
            // 
            // btEqual
            // 
            this.btEqual.Location = new System.Drawing.Point(252, 381);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(114, 73);
            this.btEqual.TabIndex = 2;
            this.btEqual.Text = "=";
            this.btEqual.UseVisualStyleBackColor = true;
            this.btEqual.Click += new System.EventHandler(this.btEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 466);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.btRoot);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btSquare);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt7);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btSquare;
        private System.Windows.Forms.Button btRoot;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.Button btDot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

