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
            // System.Diagnostics.Process.Start("cmd");      // 명령프롬프트
            // System.Diagnostics.Process.Start("calc");     // 계산기
            // System.Diagnostics.Process.Start("notepad");  // 메모장
            // System.Diagnostics.Process.Start("mspaint");  // 그림판
            
            System.Diagnostics.Process.Start("note");   // 실행순서가 이상해짐.. 먼저 프로그램 실행 후 파일열기
            System.Diagnostics.Process.Start("note", @"C:\Users\J\Desktop\s.txt"); // C:\windows에 Notepad++프로그램을 바로가기(연결)파일로 note라는 이름으로 저장
            System.Diagnostics.Process.Start("note", @"C:\Users\J\Desktop\p.txt"); // >> Notepad++로 메모장(txt)파일이 열림
            
            // string notePath = @"C:\Program Files (x86)\Notepad++\notepad++.exe";
            // System.Diagnostics.Process.Start(notePath, @"C:\Users\J-innotech\Desktop\s.txt");
            
            
        }
    }
}
