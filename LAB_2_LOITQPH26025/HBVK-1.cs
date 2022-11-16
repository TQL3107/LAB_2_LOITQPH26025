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
    public partial class HBVK_1 : Form
    {
        public HBVK_1()
        {
            InitializeComponent();
        }
        public delegate void dePassData(TextBox text);
        private void button1_Click(object sender, System.EventArgs e)
        {
            HBVK_2 form2 = new HBVK_2();
            
            dePassData del = new dePassData(form2.funData);
            del(this.textBox1);
            form2.ShowDialog();
        }
    }
}
