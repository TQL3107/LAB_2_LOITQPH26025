using LAB_2_LOITQPH26025;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2_LOITQPH2605
{
    public partial class BangTinhTienDien : Form
    {
        public BangTinhTienDien()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BangTinhTienDien_Load(object sender, EventArgs e)
        {
            cbb_tenkhach.Items.Add("Trần Duy Thái");
            cbb_tenkhach.Items.Add("Nguyễn Văn Thắng");
            cbb_tenkhach.Items.Add("Nguyễn Văn Đan");
            cbb_tenkhach.Items.Add("Nguyễn Văn Tuấn");
            cbb_tenkhach.Items.Add("Nguyễn Hưng kiên");
        }
        int n1,n2,n3,n4 =50 , n5,n6;

        private void label12_Click(object sender, EventArgs e)
        {
            DanhSachTheThao bai2 = new DanhSachTheThao();
            bai2.ShowDialog();
            bai2.Hide();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            rtb_show.Text = cbb_tenkhach.SelectedItem + "\r\n"
                           + "Số KW tiêu thụ : " + tb_tieuThu.Text + "\r\n"
                           + "Số KW trong định mức : " + tb_trong.Text + "\r\n"
                           + "Số KW vượt định mức : " + tb_ngoai.Text + "\r\n"
                           + "Tổng tiền : " + tb_tong.Text;
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(tb_moi.Text);
            n2  = Convert.ToInt32(tb_cu.Text);
            n3 = n2 - n1;
            if (n3 < 0 )
            {
                MessageBox.Show("Nhập số cũ, số mới sai qui định !!!!", "Thông Báo ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tb_cu.Clear();
                tb_moi.Clear();
                tb_cu.Focus();
                return;
            }
            tb_tieuThu.Text = Convert.ToString(n3);
            if (n3 <= 50)
            {
                tb_trong.Text = Convert.ToString(n3);
                tb_ngoai.Text = Convert.ToString(0);
                n6 = n3 * 500;
                tb_tong.Text = Convert.ToString(n6);
            }
            else
            {
                n5 = n3 - n4;
                tb_trong.Text = Convert.ToString(n4);
                tb_ngoai.Text = Convert.ToString(n5);
                n6 = n4 * 500 + n5 * 1000;
                tb_tong.Text = Convert.ToString(n6);
            } 
                

        }
    }
}
