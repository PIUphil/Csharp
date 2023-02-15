using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("cmd");
            //System.Diagnostics.Process.Start("calc");
            // System.Diagnostics.Process.Start("notepad");
            System.Diagnostics.Process.Start("note", @"C:\Users\J\Desktop\s.txt"); // C:\windows에 Notepad++프로그램을 바로가기(연결)파일로 note라는 이름으로 저장
            System.Diagnostics.Process.Start("note", @"C:\Users\J\Desktop\p.txt"); // >> Notepad++로 메모장(txt)파일이 열림
            //System.Diagnostics.Process.Start("mspaint");
        }
    }
}
