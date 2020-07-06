using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPhuongTrinh
{
    public partial class Form1 : Form
    {
        double a, b, c, delta, x1, x2, kq;

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có thật sự muốn thoát", "Cảnh bảo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radb1_CheckedChanged(object sender, EventArgs e)
        {
            txbc.Enabled = false;
            txba.Text = "";
            txbb.Text = "";
            txbc.Text = "";
        }

        private void radb2_CheckedChanged(object sender, EventArgs e)
        {
            txbc.Enabled = true;
            txba.Text = "";
            txbb.Text = "";
            txbc.Text = "";
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            if (radb1.Checked)
            {
                if (string.IsNullOrWhiteSpace(txba.Text) || string.IsNullOrWhiteSpace(txbb.Text) )
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                       
                        a = Convert.ToDouble(txba.Text);
                        b = Convert.ToDouble(txbb.Text);
                        if (a != 0)
                        {
                            kq = (-b) /(a);
                            txbkq.Text ="Phương trình có nghiệm là: "+ kq+"";
                        } else //a=0
                        {
                            if (b != 0)
                            {
                                txbkq.Text="Phương trình vô nghiệm";
                            }
                            else // b=0
                            {
                                txbkq.Text = "Phương trình có vô số nghiệm";
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vui lòng nhập số");
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txba.Text) || string.IsNullOrWhiteSpace(txbb.Text) || string.IsNullOrWhiteSpace(txbc.Text))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        a = Convert.ToDouble(txba.Text);
                        b = Convert.ToDouble(txbb.Text);
                        c = Convert.ToDouble(txbc.Text);

                        delta = (b * b) - (4 * a * c);

                        if (delta < 0)
                        {

                            txbkq.Text = "Phương trình vô nghiệm";


                        }
                        else if (delta == 0)
                        {
                            x1 = (-b) / 2 * a;
                            txbkq.Text = "Phương trình có nghiệm kép x1=x2=" + x1;
                        }
                        else
                        {
                            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                            txbkq.Text = "Phương trình có 2 nghiệm: x1=" + x1 + " và x2=" + x2;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vui lòng nhập số");
                    }

                }
            }
        }
    }
}
