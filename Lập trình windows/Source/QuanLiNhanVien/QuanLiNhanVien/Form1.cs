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


namespace QuanLiNhanVien
{
    public partial class Form1 : Form
    {
        string string_ketnoi = "Data Source="+SystemInformation.UserDomainName+"\\SQLEXPRESS;Database=QUANLINHANVIEN;User Id=sa;Password=123456";
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader red;
        SqlConnection con;
        SqlCommand cmd;
        BindingSource bs=new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }
        // Hàm kết nối
        private void ketnoi()
        {
            try
            {
                con = new SqlConnection(string_ketnoi);
                con.Open();
              //  MessageBox.Show("Kết nối thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }
        // Hàm đưa dữ liệu lên dataGridview

        private void loaddata()
        {
            
            string sql_load = "select Manv,Tennv,Ngaysinh,Gioitinh,Quequan,Tenpb from  NhanVien,PhongBan where NhanVien.Mapb=PhongBan.Mapb";
            da = new SqlDataAdapter(sql_load, con);
            dt = new DataTable();
            da.Fill(dt);
            bs.DataSource = dt;
            dataGridViewNV.DataSource = bs;

            //Đưa dữ liệu lên combobox
            string sql_phongban = "select Tenpb from PhongBan";
            da = new SqlDataAdapter(sql_phongban, con);
            dt = new DataTable();
            da.Fill(dt);
            cbpb.DataSource = dt;
            cbpb.DisplayMember = "Tenpb";

        }
        // Hàm chọn từng dòng dữ liệu
        private void showrecord()
        {
            int index = dataGridViewNV.CurrentRow.Index;
            if(index >= 0)
            {
                txbmnv.Text = dataGridViewNV.Rows[index].Cells["Manv"].Value.ToString().Trim();
                txbhoten.Text = dataGridViewNV.Rows[index].Cells["Tennv"].Value.ToString().Trim();
                txbqq.Text = dataGridViewNV.Rows[index].Cells["Quequan"].Value.ToString().Trim();
                string gt;
                gt = dataGridViewNV.Rows[index].Cells["Gioitinh"].Value.ToString().Trim();
                if (gt.Equals("Nam"))
                {
                    radnam.Checked = true;
                }
                else radnu.Checked = true;
               
                datens.Text = dataGridViewNV.Rows[index].Cells["Ngaysinh"].Value.ToString().Trim();
                cbpb.Text = dataGridViewNV.Rows[index].Cells["Tenpb"].Value.ToString().Trim();
            }
        }

        //hàm kiểm tra thông tin
        private bool kttt()
        {
            if (string.IsNullOrWhiteSpace(txbmnv.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống");
                txbhoten.Focus();
                return false;

            }

            if (string.IsNullOrWhiteSpace(txbhoten.Text.ToString()))
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

        // Hàm thêm dữ liệu
        private void them()
        {
            if (kttt())
            {
                try
                {
                    string sql_Mapb = "select PhongBan.Mapb from PhongBan where Phongban.Tenpb=N'" + cbpb.Text.Trim() + "'";
                    cmd = new SqlCommand(sql_Mapb, con);
                    red = cmd.ExecuteReader();
                    string Mapb = "";
                    red.Read();
                    Mapb = red.GetValue(0).ToString().Trim();
                    red.Close();

                    string gt;
                    gt = (radnam.Checked) ? "Nam" : "Nữ";
                    string sql_them = "Insert into NhanVien values('" + txbmnv.Text + "',N'" + txbhoten.Text + "','" + datens.Value.ToString() + "',N'" + gt + "',N'" + txbqq.Text + "','" + Mapb + "')";
                    cmd = new SqlCommand(sql_them, con);
                    cmd.ExecuteNonQuery();
                    loaddata();
                    bs.MoveLast();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        private void sua()
        {
            if (kttt())
            {
                try
                {
                    string sql_Mapb = "select PhongBan.Mapb from PhongBan where Phongban.Tenpb=N'" + cbpb.Text.Trim() + "'";
                    cmd = new SqlCommand(sql_Mapb, con);
                    red = cmd.ExecuteReader();
                    string Mapb = "";
                    red.Read();
                    Mapb = red.GetValue(0).ToString().Trim();
                    red.Close();

                    string gt;
                    gt = (radnam.Checked) ? "Nam" : "Nữ";
                    string sql_sua = "Update NhanVien set Tennv=N'"+txbhoten.Text+"',Ngaysinh='"+datens.Value.ToString()+"',Gioitinh=N'"+gt+"',Quequan=N'"+txbqq.Text+"',Mapb='"+Mapb+"' where Manv='"+txbmnv.Text+"'";
                    cmd = new SqlCommand(sql_sua, con);
                    cmd.ExecuteNonQuery();
                    loaddata();
              
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }
        private void xoa()
        {
            string sql_xoa = "delete NhanVien where Manv='" + txbmnv.Text + "'";
            cmd = new SqlCommand(sql_xoa, con);
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi();
            loaddata();
            showrecord();

        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showrecord();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            sua();
        }
    }
}
