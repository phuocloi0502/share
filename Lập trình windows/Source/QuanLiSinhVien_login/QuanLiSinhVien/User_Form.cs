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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
        }


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

        private void User_Form_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn là User");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn đăng xuất ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Dangnhap dangnhap = new Dangnhap();
                dangnhap.Show();
                this.Hide();
            }

        }

        private void datagridvewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRecord();
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
     
    }
}
