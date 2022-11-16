using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2_LOITQPH26025
{
    public partial class DanhSachTheThao : Form
    {
        public DanhSachTheThao()
        {
            InitializeComponent();
        }
        
        private void label8_Click(object sender, EventArgs e)
        {
            HBVK_1 bai3 = new HBVK_1();
            bai3.ShowDialog();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rtb_Show.ResetText();
            lb_DaChon.Items.Clear();
            lb_CacMon.Items.Clear();
            tb_time1.ResetText();
            tb_time2.ResetText();
            lb_CacMon.Items.Add("Bóng đá");
            lb_CacMon.Items.Add("Bóng bàn");
            lb_CacMon.Items.Add("Cầu lông");
            lb_CacMon.Items.Add("Nhày dù");
            lb_CacMon.Items.Add("Bắn bi");
            lb_CacMon.Items.Add("Bập bênh");
        }

        private void DanhSachTheThao_Load(object sender, EventArgs e)
        {
            tb_time1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_time2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            cbb_ten.Items.Add("Nguyễn Văn Đan");
            cbb_ten.Items.Add("Nguyễn Văn Thắng");
            cbb_ten.Items.Add("Nguyễn Duy Tuấn");
            cbb_ten.Items.Add("Nguyễn Hưng Kiên");
            cbb_ten.Items.Add("Trần Duy Thái");
            lb_CacMon.Items.Add("Bóng đá");
            lb_CacMon.Items.Add("Bóng bàn");
            lb_CacMon.Items.Add("Cầu lông");
            lb_CacMon.Items.Add("Nhày dù");
            lb_CacMon.Items.Add("Bắn bi");
            lb_CacMon.Items.Add("Bập bênh");
        }

        private void btn_chonAll_Click(object sender, EventArgs e)
        {
            int i;
            int n = lb_CacMon.Items.Count;
            for (i = 0; i < n; i++)
            {
                lb_CacMon.SelectedIndex = i;
                lb_DaChon.Items.Add(lb_CacMon.SelectedItem.ToString());
            }
            while (n > 0)
            {
                lb_CacMon.SelectedIndex = n - 1;
                lb_CacMon.Items.Remove(lb_CacMon.SelectedItem.ToString());
                n = lb_CacMon.Items.Count;
            }
        }

        private void btn_chon1_Click(object sender, EventArgs e)
        {
            //int i = lb_CacMon.SelectedIndex;
            string item = lb_CacMon.Items[1].ToString();
            lb_DaChon.Items.Add(item);
            lb_CacMon.Items.Remove(item);
        }

        private void btn_bo1_Click(object sender, EventArgs e)
        {
            //int i = lb_DaChon.SelectedIndex;
            string item = lb_DaChon.Items[1].ToString();
            lb_CacMon.Items.Add(item);
            lb_DaChon.Items.Remove(item);
        }

        private void btn_BoAll_Click(object sender, EventArgs e)
        {
            int i;
            int n = lb_DaChon.Items.Count;
            for (i = 0; i < n; i++)
            {
                lb_DaChon.SelectedIndex = i;
                lb_CacMon.Items.Add(lb_DaChon.SelectedItem.ToString());
            }
            while (n > 0)
            {
                lb_DaChon.SelectedIndex = n - 1;
                lb_DaChon.Items.Remove(lb_DaChon.SelectedItem.ToString());
                n = lb_DaChon.Items.Count;
            }
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            int i;
            int n = lb_DaChon.Items.Count;
            rtb_Show.Text = cbb_ten.Text +
                            "\r\n" + tb_time1.Text +
                            "\r\n" + tb_time2.Text +
                            "\r\n** Môn đã chọn: \r\n";
            for (i = 0; i < n; i++) 
            {
                lb_DaChon.SelectedIndex = i;
                rtb_Show.Text += lb_DaChon.Text + ", ";
            }
        }
    }
}
