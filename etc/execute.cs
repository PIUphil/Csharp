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
            System.Diagnostics.Process.Start("notepad");
            //System.Diagnostics.Process.Start("mspaint");
        }
    }
}
