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
    public partial class LAB01 : Form
    {
        public LAB01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            B1 bai1 = new B1(); 
            bai1.Show();
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BT2 bai2 = new BT2();
            bai2.Show();
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BT3 bai3 = new BT3();
            bai3.Show();
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            B4 bai4 = new B4();
            bai4.Show();
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            B5 Bai5 = new B5();
            Bai5.Show();
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
        }
    }
}
