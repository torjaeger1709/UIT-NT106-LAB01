namespace WindowsFormsApp1
{
    partial class B7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B7));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NhapDuLieu = new System.Windows.Forms.TextBox();
            this.XuLy = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 447);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHUỖI ĐIỂM";
            // 
            // NhapDuLieu
            // 
            this.NhapDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapDuLieu.Location = new System.Drawing.Point(320, 63);
            this.NhapDuLieu.Name = "NhapDuLieu";
            this.NhapDuLieu.Size = new System.Drawing.Size(531, 28);
            this.NhapDuLieu.TabIndex = 2;
            // 
            // XuLy
            // 
            this.XuLy.BackColor = System.Drawing.Color.LightGreen;
            this.XuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuLy.Location = new System.Drawing.Point(320, 100);
            this.XuLy.Name = "XuLy";
            this.XuLy.Size = new System.Drawing.Size(127, 36);
            this.XuLy.TabIndex = 3;
            this.XuLy.Text = "XỬ LÝ";
            this.XuLy.UseVisualStyleBackColor = false;
            this.XuLy.Click += new System.EventHandler(this.XuLy_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.LightCoral;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(724, 97);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(127, 36);
            this.thoat.TabIndex = 4;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(524, 100);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(127, 36);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "XÓA";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "KẾT QUẢ";
            // 
            // KetQua
            // 
            this.KetQua.AutoScroll = true;
            this.KetQua.Location = new System.Drawing.Point(320, 171);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(531, 266);
            this.KetQua.TabIndex = 8;
            // 
            // B7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(941, 449);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.XuLy);
            this.Controls.Add(this.NhapDuLieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "B7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B7";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NhapDuLieu;
        private System.Windows.Forms.Button XuLy;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel KetQua;
    }
}