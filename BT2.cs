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
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] mang = new double[3];
            double num1, num2, num3;
            if (double.TryParse(so1.Text, out num1) && (double.TryParse(so2.Text, out num2)) && (double.TryParse(so3.Text, out num3)))
            {
                num1 = double.Parse(so1.Text.Trim());
                num2 = double.Parse(so2.Text.Trim());
                num3 = double.Parse(so3.Text.Trim());
                mang[0] = num1;
                mang[1] = num2;
                mang[2] = num3;
                somax.Text = mang.Max().ToString(); 
                somin.Text = mang.Min().ToString();
            }
            else
            {
                MessageBox.Show("Du lieu vao khong phu hop.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            so1.Text = "";
            so2.Text = "";
            so3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
