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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbhoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên");
            }
            else
            {
                Form2 form2 = new Form2(txbhoten.Text);
                form2.Show();
            }
        }
    }
}
