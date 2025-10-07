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
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
        }

        private void doc_Click(object sender, EventArgs e)
        {
            string[] donVi = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string DocSo3ChuSo(int number)
            {
                int tram = number / 100;
                int chuc = (number % 100) / 10;
                int dv = number % 10;
                string result = "";

                if (tram > 0)
                {
                    result += donVi[tram] + " trăm";
                    if (chuc == 0 && dv > 0) result += " lẻ";
                }

                if (chuc > 1)
                {
                    result += " " + donVi[chuc] + " mươi";
                    if (dv == 1) result += " mốt";
                    else if (dv == 5) result += " lăm";
                    else if (dv > 0) result += " " + donVi[dv];
                }
                else if (chuc == 1)
                {
                    result += " mười";
                    if (dv == 5) result += " lăm";
                    else if (dv > 0) result += " " + donVi[dv];
                }
                else if (chuc == 0 && dv > 0)
                {
                    result += " " + donVi[dv];
                }

                return result.Trim();
            }

            // Hàm đọc số nhiều chữ số
            string DocSo(long number)
            {
                if (number == 0) return "không";

                string[] hang = { "", " nghìn", " triệu", " tỷ" };
                string result = "";
                int i = 0;

                while (number > 0)
                {
                    int block = (int)(number % 1000);
                    if (block > 0)
                    {
                        string blockStr = DocSo3ChuSo(block) + hang[i];
                        result = blockStr + " " + result;
                    }
                    number /= 1000;
                    i++;
                }

                return result.Trim();
            }

            // Lấy dữ liệu từ TextBox và xử lý
            if (long.TryParse(so.Text, out long n))
            {
                ketqua.Text = DocSo(n);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            so.Text = "";
            ketqua.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
