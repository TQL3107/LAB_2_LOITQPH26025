using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LAB_2_LOITQPH26025
{
    public partial class HBVK_2 : Form
    {
        public void funData(TextBox txtForm1)
        {
            label1.Text = txtForm1.Text;
        }
        
        public HBVK_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
