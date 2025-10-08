using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class B7 : Form
    {
        public B7()
        {
            InitializeComponent();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            NhapDuLieu.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuLy_Click(object sender, EventArgs e)
        {
            KetQua.Controls.Clear();
            string input = NhapDuLieu.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return;
            }

            // Tách các phần tử bằng dấu ","
            string[] parts = input.Split(',');
            if (parts.Length < 2)
            {
                MessageBox.Show("Sai định dạng! Phải có tên và ít nhất 1 điểm.");
                return;
            }

            string hoTen = parts[0].Trim();
            // Kiểm tra họ tên không phải là số
            double temp;
            if (double.TryParse(hoTen, out temp))
            {
                MessageBox.Show("Phần tử đầu tiên phải là họ tên, không phải là số!");
                return;
            }

            double[] diem = new double[parts.Length - 1];
            for (int i = 1; i < parts.Length; i++)
            {
                string diemStr = parts[i].Trim();
                if (!double.TryParse(diemStr, out diem[i - 1]))
                {
                    MessageBox.Show($"Điểm thứ {i} không hợp lệ! Phải là số.");
                    return;
                }
            }

            // In ra kết quả
            double dtb = diem.Average();
            double max = diem.Max();
            double min = diem.Min();
            int soMonDau = diem.Count(d => d >= 5);
            int soMonRot = diem.Count(d => d < 5);
            string xepLoai = XepLoai(diem, dtb);

            int y = 10; // vị trí dòng đầu tiên

            AddLabel($"Họ và tên: {hoTen}", ref y, FontStyle.Bold);
            AddLabel("", ref y);

            // Liệt kê điểm
            for (int i = 0; i < diem.Length; i++)
                AddLabel($"Môn {i + 1}: {diem[i]}", ref y);
            AddLabel("", ref y);
            AddLabel($"Điểm trung bình: {dtb:F2}", ref y);
            AddLabel($"Điểm cao nhất: {max}", ref y);
            AddLabel($"Điểm thấp nhất: {min}", ref y);
            AddLabel($"Số môn đậu: {soMonDau}", ref y);
            AddLabel($"Số môn không đậu: {soMonRot}", ref y);
            AddLabel($"Xếp loại: {xepLoai}", ref y, FontStyle.Bold);
        }
        private void AddLabel(string text, ref int y, FontStyle style = FontStyle.Regular)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10, style);
            lbl.Location = new Point(10, y);
            KetQua.Controls.Add(lbl);
            y += 20; // khoảng cách giữa các dòng
        }

        private string XepLoai(double[] diem, double dtb)
        {
            if (dtb >= 8 && diem.All(d => d >= 6.5))
                return "Giỏi";
            else if (dtb >= 6.5 && diem.All(d => d >= 5))
                return "Khá";
            else if (dtb >= 5 && diem.All(d => d >= 3.5))
                return "Trung bình";
            else if (dtb >= 3.5 && diem.All(d => d >= 2))
                return "Yếu";
            else
                return "Kém";
        }
    }
}
