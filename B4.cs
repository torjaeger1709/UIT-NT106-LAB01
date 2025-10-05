using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class B4 : Form
    {
        // Dictionary chứa giá vé theo phim
        private Dictionary<string, (int price, List<int> rooms)> movies = new Dictionary<string, (int, List<int>)>
        {
            {"Đào, phở và piano", (45000, new List<int>{1,2,3})},
            {"Mai", (100000, new List<int>{2,3})},
            {"Gặp lại chị bầu", (70000, new List<int>{1})},
            {"Tarot", (90000, new List<int>{3})}
        };

        // Ghế đã đặt: theo từng phim + phòng
        private Dictionary<(string movie, int room), List<string>> bookedSeats
            = new Dictionary<(string movie, int room), List<string>>();

        // Ghế đang chọn tạm thời: theo từng phim + phòng
        private Dictionary<(string movie, int room), List<string>> selectedSeats
            = new Dictionary<(string movie, int room), List<string>>();

        public B4()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void LoadMovies()
        {
            cbMovie.Items.Clear();
            foreach (var m in movies.Keys)
                cbMovie.Items.Add(m);
        }

        private void LoadSeatsGrid()
        {
            panelSeats.Controls.Clear();

            int rows = 3;
            int cols = 5;
            int btnSize = 50;
            int padding = 10;

            string[] rowNames = { "A", "B", "C" };
            string[] veVot = { "A1", "A5", "C1", "C5" };
            string[] veThuong = { "A2", "A3", "A4", "C2", "C3", "C4", "B1", "B5" };
            string[] veVIP = { "B2", "B3", "B4" };

            if (cbMovie.SelectedItem == null || cbRoom.SelectedItem == null)
                return;

            string movie = cbMovie.SelectedItem.ToString();
            int room = int.Parse(cbRoom.SelectedItem.ToString().Replace("Phòng ", ""));
            var key = (movie, room);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    string seatName = rowNames[r] + (c + 1);

                    Button btn = new Button();
                    btn.Name = seatName;
                    btn.Text = seatName;
                    btn.Width = btnSize;
                    btn.Height = btnSize;
                    btn.Left = c * (btnSize + padding);
                    btn.Top = r * (btnSize + padding);

                    // màu mặc định theo loại ghế
                    if (veVot.Contains(seatName))
                        btn.BackColor = Color.Gray;
                    else if (veVIP.Contains(seatName))
                        btn.BackColor = Color.Pink;
                    else if (veThuong.Contains(seatName))
                        btn.BackColor = Color.White;

                    btn.Tag = btn.BackColor;
                    btn.Click += Seat_Click;

                    // Nếu ghế đã đặt thì cam
                    if (bookedSeats.ContainsKey(key) && bookedSeats[key].Contains(seatName))
                    {
                        btn.BackColor = Color.Orange;
                        btn.Enabled = false;
                    }
                    // Nếu ghế đang chọn thì xanh lá
                    else if (selectedSeats.ContainsKey(key) && selectedSeats[key].Contains(seatName))
                    {
                        btn.BackColor = Color.LightGreen;
                    }

                    panelSeats.Controls.Add(btn);
                }
            }

            panelSeats.Width = cols * (btnSize + padding);
            panelSeats.Height = rows * (btnSize + padding);
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string seat = btn.Text;

            if (cbMovie.SelectedItem == null || cbRoom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng trước khi chọn ghế.");
                return;
            }

            string movie = cbMovie.SelectedItem.ToString();
            int room = int.Parse(cbRoom.SelectedItem.ToString().Replace("Phòng ", ""));
            var key = (movie, room);

            // Initialize collections if they don't exist
            if (!bookedSeats.ContainsKey(key))
                bookedSeats[key] = new List<string>();
            if (!selectedSeats.ContainsKey(key))
                selectedSeats[key] = new List<string>();

            if (bookedSeats[key].Contains(seat))
                return;

            string[] veVIP = { "B2", "B3", "B4" };
            
            if (selectedSeats[key].Contains(seat))
            {
                // Removing a selected seat
                selectedSeats[key].Remove(seat);
                btn.BackColor = (Color)btn.Tag;
            }
            else
            {
                // Check VIP ticket limit when trying to select a VIP seat
                if (veVIP.Contains(seat))
                {
                    // Count total VIP seats selected across all rooms
                    int totalVIPSelected = selectedSeats
                        .SelectMany(kv => kv.Value)
                        .Count(s => veVIP.Contains(s));

                    if (totalVIPSelected >= 2)
                    {
                        MessageBox.Show("Không thể chọn quá 2 vé VIP ở các phòng chiếu.", 
                            "Giới hạn vé VIP", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                        return;
                    }
                }

                // If validation passes, add the seat
                selectedSeats[key].Add(seat);
                btn.BackColor = Color.LightGreen;
            }
        }



        private void cbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoom.Items.Clear();

            if (cbMovie.SelectedItem != null)
            {
                var selected = cbMovie.SelectedItem.ToString();

                foreach (var room in movies[selected].rooms)
                {
                    cbRoom.Items.Add("Phòng " + room);
                }

                if (cbRoom.Items.Count > 0)
                    cbRoom.SelectedIndex = 0;
            }
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSeatsGrid();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (var kv in selectedSeats)
            {
                string movie = kv.Key.movie;
                int room = kv.Key.room;
                int basePrice = movies[movie].price;

                foreach (var seat in kv.Value)
                {
                    if (seat.Equals("B2") || seat.Equals("B3") || seat.Equals("B4"))
                        total += (int)(basePrice * 2);
                    else if (seat.Equals("A1") || seat.Equals("A5") || seat.Equals("C1") || seat.Equals("C5"))
                        total += (int)(basePrice * 0.25);
                    else
                        total += basePrice;
                }

                if (!bookedSeats.ContainsKey(kv.Key))
                    bookedSeats[kv.Key] = new List<string>();

                bookedSeats[kv.Key].AddRange(kv.Value);
            }

            selectedSeats.Clear();
            LoadSeatsGrid();

            lblResult.Text = "Tổng tiền: " + total.ToString("N0") + " đ";
        }

      
    }
}
