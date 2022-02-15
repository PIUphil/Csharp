// https://luckygg.tistory.com/328

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Resources;


namespace CS_MySQL
{
    public partial class Form1 : Form
    {
        string _server = "127.0.0.1";       //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306;                   //DB 서버 포트
        string _database = "mydb_schema";   //DB 이름
        string _id = "root";                //계정 아이디
        string _pw = "abcd";                //계정 비밀번호
        string _connectionAddress = "";


        public Form1()
        {
            InitializeComponent();

            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}",
                _server, _port, _database, _id, _pw);
        }


        // 추가
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO table1 (name, phone) VALUES ('{0}', '{1}');",
                        textBoxName.Text, textBoxPhone.Text);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");

                    textBoxName.Text = "";
                    textBoxPhone.Text = "";

                    selectTable();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        // 수정
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();

                    int pos = listViewPhoneBook.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listViewPhoneBook.Items[pos].Text);

                    string updateQuery = string.Format("UPDATE table1 SET name = '{1}', phone = '{2}' WHERE id={0};", index, textBoxName.Text, textBoxPhone.Text);

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    textBoxName.Text = "";
                    textBoxPhone.Text = "";

                    selectTable();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        // 삭제
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    int pos = listViewPhoneBook.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listViewPhoneBook.Items[pos].Text);

                    string deleteQuery = string.Format("DELETE FROM table1 WHERE id={0};", index);

                    MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    textBoxName.Text = "";
                    textBoxPhone.Text = "";

                    selectTable();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        // 조회 - 버튼
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            selectTable();
        }


        // 조회 - 기능
        private void selectTable()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM table1");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listViewPhoneBook.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["name"].ToString());
                        item.SubItems.Add(table["phone"].ToString());

                        listViewPhoneBook.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void listViewPhoneBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            textBoxName.Text = listview.Items[index].SubItems[1].Text;
            textBoxPhone.Text = listview.Items[index].SubItems[2].Text;
        }


        // 리셋
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxPhone.Text = "";
        }


        // 연결확인
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(_connectionAddress);
            connection.Open();
            bool check = connection.Ping();

            if (check == true)
                MessageBox.Show("연결 성공");
            else
                MessageBox.Show("연결 실패");
        }

    }
}
