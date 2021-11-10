using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //DB연동

namespace account_form
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=175.123.253.199; Database=test_schema; Uid=root; password=eldkdlTlxl0101@@"); //DB Connection
        MySqlCommand cmd = new MySqlCommand(); //SQL문 사용하여 DB 조작
        MySqlDataAdapter da = new MySqlDataAdapter(); //Adapter

        public Form2()
        {
            InitializeComponent();
        }

        private void join_btn_Click(object sender, EventArgs e) //회원가입
        {
            if (name_box.Text == "" || pw_box.Text == "" && pw2_box.Text == "") //name, id, password 값이 null 이라면
            {
                MessageBox.Show("이름, 아이디 또는 비밀번호 필드가 비어있습니다.");
            }
            else if (pw_box.Text ==pw2_box.Text) //비밀번호와 비밀번호 재확인이 같으면
            {
                conn.Open(); //실행
                string join = "INSERT INTO test_schema.tbl_users (user_name,password) value ('" + this.name_box.Text + "','" + 
                    this.pw_box.Text + "')";
                cmd = new MySqlCommand(join, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                name_box.Text = "";
                pw_box.Text = "";
                pw2_box.Text = "";

                MessageBox.Show("회원가입 되셨습니다.");
            }
            else
            {
                MessageBox.Show("비밀번호가 맞지 않습니다.");
                pw_box.Text = "";
                pw2_box.Text = "";
                pw_box.Focus();
            }
        }

        private void pw_chk_CheckedChanged(object sender, EventArgs e) //회원가입 중 비밀번호 표시
        {
            if(pw_chk.Checked) //체크박스에 체크가 되어 있다면,
            {
                pw_box.PasswordChar = '\0';
                pw2_box.PasswordChar = '\0';
            }
            else
            {
                pw_box.PasswordChar = '●'; //디자인 속성 passwordChar에서 ●로 change
                pw2_box.PasswordChar = '●';
            }
        }

        private void go_login_label_Click(object sender, EventArgs e) //로그인하러 가기
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
