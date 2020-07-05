using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class Dangnhap : Form
    {
        string string_con = "Data Source=" +SystemInformation.UserDomainName.ToString()+"\\SQLEXPRESS;Database=QUANLISINHVIEN;User Id=sa;Password=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader red;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btndn_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(string_con);
            con.Open();
            //MessageBox.Show("Kết nối thành công");

            string sql = "Select * from THANHVIEN where taikhoan='" + txbdn.Text.Trim() + "'and matkhau='" + txbmk.Text.Trim() + "'";
            cmd = new SqlCommand(sql, con);
            red = cmd.ExecuteReader();
            if (red.Read() == true)
            {
                if (red.GetValue(2).ToString().Equals("1"))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Admin_Form admin_Form = new Admin_Form();
                    admin_Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    User_Form user_Form = new User_Form();
                    user_Form.Show();
                    this.Hide();
                }
               

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khảu không đúng");
            }

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
           

        }
    }
}
