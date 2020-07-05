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
    public partial class Form1 : Form
    {
        // Khai báo
        public String string_connec = "Data Source=" + SystemInformation.UserDomainName.ToString() + "\\SQLEXPRESS;Database=QUANLISINHVIEN;User Id=sa;Password=123456";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da, da_khoa;
        DataTable dt, dt_khoa;

        // Hàm kết nối
        public void Ketnoi()
        {
            try
            {
                con = new SqlConnection(string_connec);
                con.Open();
                // MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ket noi khong thanh cong");
            }
        }

        // Hàm load dữ liệu lên dataGirdView
        public void Loaddata()
        {
            string sql = "Select mssv,hoten,gioitinh,ngaysinh,quequan,tenkhoa from SINHVIEN,KHOA where SINHVIEN.makhoa=KHOA.makhoa";
            Ketnoi();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            datagridvewSV.DataSource = dt;
            ShowRecord();

            string sql_khoa = "Select tenkhoa from KHOA";
            da_khoa = new SqlDataAdapter(sql_khoa, con);
            dt_khoa = new DataTable();
            da_khoa.Fill(dt_khoa);
            cbkhoa.DataSource = dt_khoa;
            cbkhoa.DisplayMember = "tenkhoa";
            

        }
        public void ShowRecord()
        {
            int index = datagridvewSV.CurrentRow.Index;
            if (index >= 0)
            {
                txbmssv.Text = datagridvewSV.Rows[index].Cells["mssv"].Value.ToString().Trim();
                txbhoten.Text = datagridvewSV.Rows[index].Cells["hoten"].Value.ToString().Trim();
                String gt = datagridvewSV.Rows[index].Cells["gioitinh"].Value.ToString();
                if (gt == "Nam") radnam.Checked = true;
                else radnu.Checked = true;
                txbqq.Text = datagridvewSV.Rows[index].Cells["quequan"].Value.ToString().Trim();
                datens.Text = datagridvewSV.Rows[index].Cells["ngaysinh"].Value.ToString().Trim();
                cbkhoa.Text = datagridvewSV.Rows[index].Cells["tenkhoa"].Value.ToString().Trim();
            }
        }

        // Thêm sinh viên
        private void Them()
        {
            try
            {
                string gt, makhoa;
                if (kttt())
                {
                    if (radnam.Checked)
                    {
                        gt = "Nam";
                    }
                    else gt = "Nữ";

                    string sql_khoa = "Select makhoa from KHOA where tenkhoa=N'" + cbkhoa.Text.Trim() + "'";
                    cmd = new SqlCommand(sql_khoa, con);
                    SqlDataReader red = cmd.ExecuteReader();
                    red.Read();
                    makhoa = red.GetValue(0).ToString().Trim();
                    red.Close();
                    string sql_them = "Insert into SINHVIEN values('" + txbmssv.Text + "',N'" + txbhoten.Text + "',N'" + gt + "','" + datens.Value.ToString() + "',N'" + txbqq.Text + "','" + makhoa + "')";
                    cmd = new SqlCommand(sql_them, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    Loaddata();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm thât bại");
            }
         

        }

        //Sửa sinh viên
        private void Sua()
        {
            try
            {
                string gt, makhoa;
                if (kttt())
                {
                    if (radnam.Checked)
                    {
                        gt = "Nam";
                    }
                    else gt = "Nữ";

                    string sql_khoa = "Select makhoa from KHOA where tenkhoa=N'" + cbkhoa.Text.Trim() + "'";
                    cmd = new SqlCommand(sql_khoa, con);
                    SqlDataReader red = cmd.ExecuteReader();
                    red.Read();
                    makhoa = red.GetValue(0).ToString().Trim();
                    red.Close();

                    string sql_sua = "Update SINHVIEN set mssv='" + txbmssv.Text.Trim() + "',hoten=N'" + txbhoten.Text + "',gioitinh=N'" + gt + "',ngaysinh='" + datens.Value.ToString() + "',quequan=N'" + txbqq.Text + "',makhoa='" + makhoa + "' where mssv='"+txbmssv.Text.Trim()+ "'";
                    cmd = new SqlCommand(sql_sua, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    Loaddata();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Sửa thât bại");
            }

        }

        //Xóa sinh viên
        private void Xoa()
        {
            string sql_xoa = "Delete from SINHVIEN where mssv='"+txbmssv.Text+"'";
            cmd = new SqlCommand(sql_xoa, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            Loaddata();
        }


        private bool kttt()
        {
            if (string.IsNullOrWhiteSpace(txbmssv.Text))
            {
                MessageBox.Show("MSSV không được để trống");
                txbhoten.Focus();
                return false;

            }

            if (string.IsNullOrWhiteSpace(txbmssv.Text.ToString()))
            {
                MessageBox.Show("Họ tên không được để trống");
                txbhoten.Focus();
                return false;

            }

            if (string.IsNullOrWhiteSpace(txbqq.Text.ToString()))
            {
                MessageBox.Show("Quê quán không được để trống");
                txbhoten.Focus();
                return false;

            }
            return true;
        }
    

       

        public Form1()
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them();
        }



        private void btnsua_Click(object sender, EventArgs e)
        {
            Sua();
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            Loaddata();


        }



        private void datagridvewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRecord();
        }
    }
}
