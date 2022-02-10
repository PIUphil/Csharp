namespace ChatServerWF
{
    partial class Form1
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
            this.cmd_Start = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.bt_toggle = new System.Windows.Forms.Button();
            this.txt_Clients = new System.Windows.Forms.TextBox();
            this.lbl_Clients = new System.Windows.Forms.Label();
            this.rtxt_Chat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmd_Start
            // 
            this.cmd_Start.Location = new System.Drawing.Point(386, 16);
            this.cmd_Start.Name = "cmd_Start";
            this.cmd_Start.Size = new System.Drawing.Size(188, 45);
            this.cmd_Start.TabIndex = 0;
            this.cmd_Start.Text = "Server Start";
            this.cmd_Start.UseVisualStyleBackColor = true;
            this.cmd_Start.Click += new System.EventHandler(this.cmd_Start_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Message.Location = new System.Drawing.Point(120, 28);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(186, 16);
            this.lbl_Message.TabIndex = 1;
            this.lbl_Message.Tag = "Stop";
            this.lbl_Message.Text = "Server 중지 상태 입니다.";
            // 
            // bt_toggle
            // 
            this.bt_toggle.FlatAppearance.BorderSize = 0;
            this.bt_toggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_toggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_toggle.Image = global::ChatServerWF.Properties.Resources.off;
            this.bt_toggle.Location = new System.Drawing.Point(38, 17);
            this.bt_toggle.Name = "bt_toggle";
            this.bt_toggle.Size = new System.Drawing.Size(76, 38);
            this.bt_toggle.TabIndex = 3;
            this.bt_toggle.Click += new System.EventHandler(this.bt_toggle_Click);
            // 
            // txt_Clients
            // 
            this.txt_Clients.Location = new System.Drawing.Point(34, 440);
            this.txt_Clients.Multiline = true;
            this.txt_Clients.Name = "txt_Clients";
            this.txt_Clients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Clients.Size = new System.Drawing.Size(539, 168);
            this.txt_Clients.TabIndex = 4;
            // 
            // lbl_Clients
            // 
            this.lbl_Clients.AutoSize = true;
            this.lbl_Clients.BackColor = System.Drawing.Color.White;
            this.lbl_Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Clients.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Clients.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Clients.Location = new System.Drawing.Point(503, 443);
            this.lbl_Clients.Name = "lbl_Clients";
            this.lbl_Clients.Size = new System.Drawing.Size(51, 12);
            this.lbl_Clients.TabIndex = 5;
            this.lbl_Clients.Text = "Clients";
            // 
            // rtxt_Chat
            // 
            this.rtxt_Chat.Location = new System.Drawing.Point(34, 76);
            this.rtxt_Chat.Multiline = true;
            this.rtxt_Chat.Name = "rtxt_Chat";
            this.rtxt_Chat.Size = new System.Drawing.Size(539, 350);
            //this.rtxt_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtxt_Chat.TabIndex = 6;
            this.rtxt_Chat.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 627);
            this.Controls.Add(this.rtxt_Chat);
            this.Controls.Add(this.lbl_Clients);
            this.Controls.Add(this.txt_Clients);
            this.Controls.Add(this.bt_toggle);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.cmd_Start);
            this.Name = "Form1";
            this.Text = "ChatServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_Start;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button bt_toggle;
        private System.Windows.Forms.TextBox txt_Clients;
        private System.Windows.Forms.Label lbl_Clients;
        private System.Windows.Forms.RichTextBox rtxt_Chat;
    }
}
