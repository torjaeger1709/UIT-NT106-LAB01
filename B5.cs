using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class B5 : Form
    {
        public B5()
        {
            InitializeComponent();
            comboBox1.Items.Add("Bảng cửu chương");
            comboBox1.Items.Add("Tính toán giá trị");
            comboBox1.SelectedIndex = 0;
            calculate.Click += calculate_Click;
            xoa.Click += xoa_Click;
            thoat.Click += thoat_Click;
            panel1.AutoScroll = true;
        }

        private void ShowResultInPanel(string text)
        {
            panel1.Controls.Clear();
            var label = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopLeft,
                Font = new Font("Consolas", 10),
                Text = text
            };
            panel1.Controls.Add(label);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(textboxNhapA.Text.Trim(), out a) || !int.TryParse(textBoxNhapB.Text.Trim(), out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B.");
                return;
            }

            string selected = comboBox1.SelectedItem.ToString();
            StringBuilder result = new StringBuilder();

            if (selected == "Bảng cửu chương")
            {
                int start = Math.Min(a, b);
                int end = Math.Max(a, b);
                for (int i = start; i <= end; i++)
                {
                    result.AppendLine($"Bảng cửu chương {i}:");
                    for (int j = 1; j <= 10; j++)
                    {
                        result.AppendLine($"{i} x {j} = {i * j}");
                    }
                    result.AppendLine();
                }
            }
            else if (selected == "Tính toán giá trị")
            {
                int diff = a - b;
                long factorial = 1;
                if (diff < 0)
                {
                    result.AppendLine($"(A - B)! không xác định với A < B");
                }
                else
                {
                    for (int i = 1; i <= diff; i++)
                        factorial *= i;
                    result.AppendLine($"(A - B)! = {factorial}");
                }

                long sum = 0;
                for (int i = 1; i <= b; i++)
                {
                    sum += (long)Math.Pow(a, i);
                }
                result.AppendLine($"Tổng S = A¹ + A² + ... + Aᴮ = {sum}");
            }

            // Show result in the panel
            ShowResultInPanel(result.ToString());
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            textboxNhapA.Text = "";
            textBoxNhapB.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
