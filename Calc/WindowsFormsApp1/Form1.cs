using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1 = 0;
        double num2 = 0;
        bool hasOper = false;
        int oper = 0;           // 1:plus 2:minus 3:multiply 4:divide

        //double preOper;
        //double postOper;

        double result;

        //
        //label1.TextAlign = MiddleLeft;

        private void bt1_Click(object sender, EventArgs e)
        {
            if (!hasOper)       // 연산이 없을 때 - num1에 숫자 저장
            {
                if (num1 == 0) { num1 = 1; }    
                else { num1 = num1 * 10 + 1; }      // 숫자 연속으로 누를 때
            }
            else              // 연산이 있을 때 - num2에 숫자 저장
            {
                if (num2 == 0) { num2 = 1; }
                else { num2 = num2 * 10 + 1; }
            }

            label1.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 2; }
                else { num1 = num1 * 10 + 2; }
            }
            else
            {
                if (num2 == 0) { num2 = 2; }
                else { num2 = num2 * 10 + 2; }
            }

            label1.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 3; }
                else { num1 = num1 * 10 + 3; }
            }
            else
            {
                if (num2 == 0) { num2 = 3; }
                else { num2 = num2 * 10 + 3; }
            }

            label1.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 4; }
                else { num1 = num1 * 10 + 4; }
            }
            else
            {
                if (num2 == 0) { num2 = 4; }
                else { num2 = num2 * 10 + 4; }
            }

            label1.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 5; }
                else { num1 = num1 * 10 + 5; }
            }
            else
            {
                if (num2 == 0) { num2 = 5; }
                else { num2 = num2 * 10 + 5; }
            }

            label1.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 6; }
                else { num1 = num1 * 10 + 6; }
            }
            else
            {
                if (num2 == 0) { num2 = 6; }
                else { num2 = num2 * 10 + 6; }
            }

            label1.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 7; }
                else { num1 = num1 * 10 + 7; }
            }
            else
            {
                if (num2 == 0) { num2 = 7; }
                else { num2 = num2 * 10 + 7; }
            }

            label1.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 8; }
                else { num1 = num1 * 10 + 8; }
            }
            else
            {
                if (num2 == 0) { num2 = 8; }
                else { num2 = num2 * 10 + 8; }
            }

            label1.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 9; }
                else { num1 = num1 * 10 + 9; }
            }
            else
            {
                if (num2 == 0) { num2 = 9; }
                else { num2 = num2 * 10 + 9; }
            }

            label1.Text += "9";
        }

        bool once0 = true;  // 0은 중복입력되지 않도록 함
        private void bt0_Click(object sender, EventArgs e)
        {
            if (!hasOper)
            {
                if (num1 == 0) { num1 = 0; }
                else 
                { 
                    num1 = num1*10;
                    once0 = true;
                }
            }
            else
            {
                once0 = true;

                if (num2 == 0) { num2 = 0; }
                else
                { 
                    num2 = num2*10;                    
                }
            }

            if (once0)
            {
                label1.Text += "0";
                once0 = false;
            }            
        }

        bool canOper = false;

        private void operation()
        {
            List<string> list = new List<string>();
            list.Add("PLUS");
            list.Add("MINUS");
            list.Add("MULTI");
            list.Add("DIV");

            switch (list[oper - 1])
            {
                case "PLUS":
                    result = num1 + num2;
                    break;
                case "MINUS":
                    result = num1 - num2;
                    break;
                case "MULTI":
                    result = num1 * num2;
                    break;
                case "DIV":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        textBox1.Text = "DivZero Error";
                    }
                    break;
                default:
                    result = num1;
                    break;
            }

            string lastWord = label1.Text.Substring(label1.Text.Length-1);

            if (label1.Text != "" && lastWord != "+" && lastWord != "-" && lastWord != "*" && lastWord != "/")
            {
                canOper = true;
            }
        }       
                    
        private void btPlus_Click(object sender, EventArgs e)
        {
            //if (canOper)
            //{
            if (hasOper)
            {
                operation();
                num2 = 0;
                num1 = result;
                textBox1.Text = result.ToString();
            }
            oper = 1;
            label1.Text += "+";
            hasOper = true;
            //}
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (hasOper)
            {
                operation();
                num2 = 0;
                num1 = result;
                textBox1.Text = result.ToString();
            }
            oper = 2;
            label1.Text += "-";
            hasOper = true;
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            if (hasOper)
            {
                operation();
                num2 = 0;
                num1 = result;
                textBox1.Text = result.ToString();
            }
            oper = 3;
            label1.Text += "*";
            hasOper = true;
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            if (hasOper)
            {
                operation();
                num2 = 0;
                num1 = result;
                textBox1.Text = result.ToString();
            }
            oper = 4;
            label1.Text += "/";
            hasOper = true;
        }

        private void btSquare_Click(object sender, EventArgs e)
        {
            label1.Text += "^2(";
            if (!hasOper) 
            {
                num1 = num1 * num1;
                label1.Text += num1.ToString();
            }
            else
            {
                num2 = num2 * num2;
                label1.Text += num2.ToString();
            }
            label1.Text += ")";
        }

        private void btRoot_Click(object sender, EventArgs e)
        {
            string tmpNum = num1.ToString();
            label1.Text += "(√)=";
            double sqrtNum = Math.Sqrt(double.Parse(tmpNum));
            label1.Text += sqrtNum.ToString();
            num1 = sqrtNum;
        }
        


        private void btEqual_Click(object sender, EventArgs e)
        {
            operation();

            label1.Text += "=";
            label1.Text += result.ToString();

            // 초기화
            num1 = result;
            num2 = 0;
            hasOper = false;

            // 출력
            textBox1.Text = result.ToString();
            
            result = 0;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";

            num1 = 0;
            num2 = 0;
            hasOper = false;
            result = 0;
        }

        private void btDot_Click(object sender, EventArgs e)
        {

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length-1);   // 마지막 글자 삭제
        }

        // 키보드 입력
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: case Keys.NumPad1: { bt1_Click(sender, e); break; }
                case Keys.D2: case Keys.NumPad2: { bt2_Click(sender, e); break; }
                case Keys.D3: case Keys.NumPad3: { bt3_Click(sender, e); break; }
                case Keys.D4: case Keys.NumPad4: { bt4_Click(sender, e); break; }
                case Keys.D5: case Keys.NumPad5: { bt5_Click(sender, e); break; }
                case Keys.D6: case Keys.NumPad6: { bt6_Click(sender, e); break; }
                case Keys.D7: case Keys.NumPad7: { bt7_Click(sender, e); break; }
                case Keys.D8: case Keys.NumPad8: { bt8_Click(sender, e); break; }
                case Keys.D9: case Keys.NumPad9: { bt9_Click(sender, e); break; }
                case Keys.D0: case Keys.NumPad0: { bt0_Click(sender, e); break; }

                case Keys.C: { btClear_Click(sender, e); break; }
                case Keys.Enter: { btEqual_Click(sender, e); break; }
                case Keys.Escape: { textBox1.Clear(); break; }

                //case Keys.ShiftKey:
                //    {
                //         btSquare_Click(sender, e);
                //        //if (e.KeyCode==Keys.D6) { btSquare_Click(sender, e); }
                //        //else if (e.KeyCode == Keys.D8) { btMulti_Click(sender, e); }
                //        break;
                //    }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '+': { btPlus_Click(sender, e); break; }
                case '-': { btMinus_Click(sender, e); break; }
                case '*':
                    {
                        btMulti_Click(sender, e);
                        break;
                    }
                case '/': { btDiv_Click(sender, e); break; }
                case '=': { btEqual_Click(sender, e); break; }
                case '^':
                    {
                        num1 = (num1 - 6) / 10;
                        label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
                        btSquare_Click(sender, e);
                        break;
                    }
                case 'r': { btRoot_Click(sender, e); break; }

                //case '+': { btPlus_Click(sender, e); break; }
                //case '+': { btPlus_Click(sender, e); break; }
            }

        }

        
    }
}
