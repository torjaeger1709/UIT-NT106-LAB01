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
    public partial class B6 : Form
    {
        public B6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text.Trim();
                string[] parts = input.Split('/');
                if (parts.Length != 2)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng: dd/MM (ví dụ: 15/06)");
                    return;
                }
                int day = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                if (!IsValidDate(day, month))
                {
                    MessageBox.Show("Ngày không hợp lệ! Vui lòng nhập lại.");
                    return;
                }
                string cung = XacDinhCungHoangDao(day, month);
                textBox2.Text = cung.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi định dạng! Vui lòng nhập ngày/tháng hợp lệ (vd: 23/11).");
            }
        }

        private string XacDinhCungHoangDao(int ngay, int thang)
        {
            if ((ngay >= 21 && thang == 3) || (ngay <= 20 && thang == 4))
                return "Bạch Dương";
            else if ((ngay >= 21 && thang == 4) || (ngay <= 21 && thang == 5))
                return "Kim Ngưu";
            else if ((ngay >= 22 && thang == 5) || (ngay <= 21 && thang == 6))
                return "Song Tử";
            else if ((ngay >= 22 && thang == 6) || (ngay <= 22 && thang == 7))
                return "Cự Giải";
            else if ((ngay >= 23 && thang == 7) || (ngay <= 22 && thang == 8))
                return "Sư Tử";
            else if ((ngay >= 23 && thang == 8) || (ngay <= 23 && thang == 9))
                return "Xử Nữ";
            else if ((ngay >= 24 && thang == 9) || (ngay <= 23 && thang == 10))
                return "Thiên Bình";
            else if ((ngay >= 24 && thang == 10) || (ngay <= 22 && thang == 11))
                return "Thần Nông";
            else if ((ngay >= 23 && thang == 11) || (ngay <= 21 && thang == 12))
                return "Nhân Mã";
            else if ((ngay >= 22 && thang == 12) || (ngay <= 20 && thang == 1))
                return "Ma Kết";
            else if ((ngay >= 21 && thang == 1) || (ngay <= 19 && thang == 2))
                return "Bảo Bình";
            else if ((ngay >= 20 && thang == 2) || (ngay <= 20 && thang == 3))
                return "Song Ngư";
            else
                return "Không xác định";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidDate(int day, int month)
        {
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month < 1 || month > 12)
                return false;
            if (day < 1 || day > daysInMonth[month])
                return false;
            return true;
        }
    }
}
