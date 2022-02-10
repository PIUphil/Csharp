// https://m.blog.naver.com/leejongcheol2018/221449119478


using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;


namespace ChatClientWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Encoding encoding = Encoding.GetEncoding("euc-kr");

        TcpClient tcpClient;
        StreamReader reader;
        StreamWriter writer;
        //StreamWriter writer2;


        // Chat_Class cht_Class = new Chat_Class();
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cmd_Connect.Text != "Login")
            {
                send(DateTime.Now.ToString("HH:mm:ss") + " [" + txt_Name.Text + "] 님께서 접속해제 하셨습니다.", true); // false
                logout();
                Thread.Sleep(500);
            }
        }

        //public static string Client_IP
        //{
        //    get
        //    {
        //        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
        //        string ClientIP = string.Empty;
        //        for (int i = 0; i < host.AddressList.Length; i++)
        //        {
        //            if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
        //            {
        //                ClientIP = host.AddressList[i].ToString();
        //            }
        //        }
        //        return ClientIP;
        //    }
        //}

        private void cmd_Connect_Click(object sender, EventArgs e)
        {
            if (cmd_Connect.Text == "Login")
            {
                try
                {
                    //IPAddress ipAddress = IPAddress.Parse(txt_Server_IP.Text);
                    IPAddress ipAddress = IPAddress.Parse("192.168.0.225");
                    tcpClient = new TcpClient();
                    tcpClient.Connect(ipAddress, 5001);

                    NetworkStream stream = tcpClient.GetStream();
                    reader = new StreamReader(stream, encoding);
                    writer = new StreamWriter(stream, encoding) { AutoFlush = true };
                    //writer2 = new StreamWriter(stream, encoding) { AutoFlush = true };

                    new Thread(post).Start();
                    //send(DateTime.Now.ToString("HH:mm:ss") + " [" + txt_Name.Text + "] 님께서 접속 하셨습니다.  (" + Client_IP + ")", true);
                    send(DateTime.Now.ToString("HH:mm:ss") + " [" + txt_Name.Text + "] 님께서 접속 하셨습니다.", true);
                    cmd_Connect.Text = "Logout";

                    txt_Name.Enabled = false;
                    ActiveControl = txt_Msg;
                }
                catch (System.Exception Err)
                {
                    MessageBox.Show("Chatting Server 오류발생 또는 Start 되지 않았거나\n" + Err.Message, "Client");
                }
            }
            else
            {
                string message = DateTime.Now.ToString("HH:mm:ss") + " [" + txt_Name.Text + "] 님께서 접속해제 하셨습니다.";
                
                send(message, true);   // false
                SetText(message + "\r\n");
                cmd_Connect.Text = "Login";
                logout();
                Thread.Sleep(1000);

                txt_Name.Enabled = true;
                ActiveControl = txt_Name;

                //writer2.WriteLine(txt_Name.Text);
            }
        }

        private void txt_Msg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)        // keydown -> enter
            {
                if (cmd_Connect.Text == "Logout")
                    if (txt_Msg.Text.Length > 200)
                        MessageBox.Show("글자수가 초과되었습니다.(200자 제한)", "Too Long Message !!");
                    else
                    {
                        send(DateTime.Now.ToString("HH:mm:ss")+ " [" + txt_Name.Text + "] " + txt_Msg.Text, true);
                        txt_Msg.Text = "";
                    }
                e.Handled = true;
            }
        }

        public void SetText(string text)
        {
            if (this.txt_Chat.InvokeRequired) 
                this.Invoke((Action<string>)SetText, text);
            else 
                this.txt_Chat.AppendText(text);
        }

        private void send(string message, Boolean Msg)
        {
            try
            {
                writer.WriteLine(message);
            }
            catch (System.Exception Err)
            {
                if (Msg == true)
                {
                    MessageBox.Show("Chatting Server가 오류발생 또는 Start 되지 않았거나\n" + Err.Message, "Client");
                    cmd_Connect.Text = "Login";
                    logout();
                }
            }
        }

        private void sendLogInOut(string message, Boolean Msg)
        {

        }

        public void post()
        {
            try
            {
                string line;

                while (reader != null && (line = reader.ReadLine()) != null)
                {
                    if (line != "") 
                        SetText(line + "\r\n");
                }
            }
            catch { }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader = null;
                }
                tcpClient.Close();
            }
        }

        public void logout()
        {
            reader.Close();
            reader = null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2)
                txt_Chat.Text = ""; 
        }

        private void txt_Msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                txt_Chat.Text = ""; 
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && cmd_Connect.Text == "Login")
                cmd_Connect_Click(sender, e);
        }
    }
}
