using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LienKetForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string hoten) : this()
        {
            txbhotendanhap.Text = hoten;
        }

        private void txbtk_TextChanged(object sender, EventArgs e)
        {
            string s = txbtk.Text;
            if (s.Length == 1)
            {
                txbtk.Enabled = false;
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string tk = txbtk.Text;
            string str = txbhotendanhap.Text.Trim();

            int i = str.LastIndexOf(tk);
            int dem = 0;
            while( i != -1){
                str = str.Substring(0, i);
                dem++;
                i = str.LastIndexOf(tk);
              
            }
               
            
             MessageBox.Show("Tìm thấy " + dem +" kí tự "+tk+" trong họ tên của bạn");
          //  MessageBox.Show(dem + "");
            txbtk.Enabled = true;
            txbtk.Text = "";
        }
    }
}
