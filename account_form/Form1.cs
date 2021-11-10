using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //DB 연동

namespace account_form
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=175.123.253.199; Database=test_schema; Uid=root; password=eldkdlTlxl0101@@"); //DB Connection
        MySqlCommand cmd = new MySqlCommand(); //SQL문 사용하여 DB 조작
        MySqlDataAdapter da = new MySqlDataAdapter(); //Adapter

        private void cancel_btn_Click(object sender, EventArgs e) //닫기 버튼
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e) //로그인 버튼
        {
            conn.Open();
            string login = "SELECT * FROM tbl_users WHERE user_name= '" + name_box.Text + "' and password= '" + pw_box.Text + "'";
            cmd = new MySqlCommand(login, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()==true)
            {
                new dashboard().Show(); //로그인 성공 시 나오는 dashboard
                this.Hide();
            }
            else
            {
                MessageBox.Show("유효하지 않은 아이디 또는 비밀번호 입니다.");
                name_box.Text = "";
                pw_box.Text = "";
                name_box.Focus();
            }

            if(remember_chk.Checked==true)
            {
                Properties.Settings.Default.UserName = name_box.Text; //프로젝트 속성의 세팅에서 추가
                Properties.Settings.Default.Password = pw_box.Text;
                Properties.Settings.Default.Save();
            }else
            {
                Properties.Settings.Default.UserName = name_box.Text; //프로젝트 속성의 세팅에서 추가
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void join_btn_Click(object sender, EventArgs e) //회원가입 Form으로 이동
        {
            new Form2().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Remember me
        {

        }
    }
}
