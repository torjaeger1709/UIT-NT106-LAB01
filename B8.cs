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
    public partial class B8 : Form
    {
        public B8()
        {
            InitializeComponent();
        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            string monAn = addFoodtxt.Text.Trim();

            if (string.IsNullOrEmpty(monAn))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
                return;
            }

            // Kiểm tra trùng
            if (!Food.Items.Contains(monAn))
            {
                Food.Items.Add(monAn);
                addFoodtxt.Clear();
            }
            else
            {
                MessageBox.Show("Món ăn này đã có trong danh sách!");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Food.SelectedItem != null)
            {
                Food.Items.Remove(Food.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!");
            }
        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            if (Food.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống!");
                return;
            }

            Random rnd = new Random();
            int index = rnd.Next(Food.Items.Count);
            string monHomNay = Food.Items[index].ToString();
            ketqua.Text = monHomNay;
        }
    }
}
