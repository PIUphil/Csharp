// https://m.blog.naver.com/leejongcheol2018/221449119478        # chat
//https://metalzang.tistory.com/334                              # client IP

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace ChatServerWF
{
    public partial class Form1 : Form
    {
        static Encoding encoding = Encoding.GetEncoding("euc-kr");
        static IPAddress ip = IPAddress.Parse("192.168.0.225");
        TcpListener listener = new TcpListener(ip, 5001);

        List<Socket> sockets = new List<Socket>();

        public Form1()
        {
            InitializeComponent();
        }


        private List<string> clientsName = new List<string>();
        private List<string> pallette = new List<string>(new string[] {"red", "orange", "green", "blue", "violet"});

        private string GetIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string ipAddr = string.Empty;

            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddr = host.AddressList[i].ToString();
                }
            }
            return ipAddr;
        }


        public void SetText(string text)
        {
            if (this.rtxt_Chat.InvokeRequired)
                this.Invoke((Action<string>)SetText, text);
            else
            { 
                this.rtxt_Chat.AppendText(text);

                //if (text.Split()[1] in clientsName)
                //{
                    
                //}
               
            }

            // System.Drawing.Color a = Color.Red;
        }

        // 버튼
        private void cmd_Start_Click(object sender, EventArgs e)
        {
            if (lbl_Message.Tag.ToString() == "Stop")
            {
                listener.Start();
                new Thread(listen).Start();

                lbl_Message.Text = "Server Start 상태 입니다.";
                lbl_Message.Tag = "Start";
                cmd_Start.Text = "Server Stop";

                bt_toggle.Image = Properties.Resources.on;

            }
            else
            {
                listener.Stop();
                foreach (Socket socket in sockets)
                    socket.Close();
                sockets.Clear();

                lbl_Message.Text = "Server Stop 상태 입니다.";
                lbl_Message.Tag = "Stop";
                cmd_Start.Text = "Server Start";

                bt_toggle.Image = Properties.Resources.off;
            }
        }

        // 창 닫기
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            listener.Stop();
        }


        private void listen()
        {
            Socket socket = null;

            try
            {
                while (true)
                {
                    socket = listener.AcceptSocket();
                    new Thread(() => chat(socket)).Start();
                }
            }
            catch (System.Exception)
            {
                if (socket != null)
                    sockets.Remove(socket);
            }
        }

        private void chat(Socket socket)
        {
            sockets.Add(socket);
            StreamReader reader = new StreamReader(new NetworkStream(socket), encoding);

            try
            {
                string line;
                
                while (reader != null && (line = reader.ReadLine()) != null)
                {
                    SetText(line + "\r\n");
                    lock (sockets)
                    {
                        foreach (Socket s in sockets)
                        {
                            NetworkStream stream = new NetworkStream(s);
                            StreamWriter writer = new StreamWriter(stream, encoding) { AutoFlush = true };

                            writer.WriteLine(line);
                            writer.Close();
                        }
                    }

                    txt_Clients.Text = "";
                    string name = line.Split()[1];
                    clientsName.Append(name);

                    if (int.Parse(sockets.Count.ToString()) != 0)                    
                    //foreach (Socket sock in sockets)
                    {
                        txt_Clients.AppendText(name + GetIP() + "\n");
                    }
                }
            }
            catch { }
            finally 
            {
                txt_Clients.Text = "";
                sockets.Remove(socket); 
            }
        }

        private void bt_toggle_Click(object sender, EventArgs e)
        {
            cmd_Start_Click(sender, e);
        }
    }
}
