using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2,num1_convert,num2_convert;
            long sum;
            if (int.TryParse(so1.Text, out num1_convert) && (int.TryParse(so2.Text, out num2_convert)))
            {
                num1 = Int32.Parse(so1.Text.Trim());
                num2 = Int32.Parse(so2.Text.Trim());
                sum = num1 + num2;
                ketqua.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Du lieu vao khong phu hop.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
