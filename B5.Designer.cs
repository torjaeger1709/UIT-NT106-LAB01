namespace WindowsFormsApp1
{
    partial class B5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B5));
            this.NhapA = new System.Windows.Forms.Label();
            this.NhapB = new System.Windows.Forms.Label();
            this.textboxNhapA = new System.Windows.Forms.TextBox();
            this.textBoxNhapB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.calculate = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NhapA
            // 
            this.NhapA.AutoSize = true;
            this.NhapA.Location = new System.Drawing.Point(50, 162);
            this.NhapA.Name = "NhapA";
            this.NhapA.Size = new System.Drawing.Size(60, 16);
            this.NhapA.TabIndex = 0;
            this.NhapA.Text = "NHẬP A:";
            // 
            // NhapB
            // 
            this.NhapB.AutoSize = true;
            this.NhapB.Location = new System.Drawing.Point(50, 204);
            this.NhapB.Name = "NhapB";
            this.NhapB.Size = new System.Drawing.Size(60, 16);
            this.NhapB.TabIndex = 1;
            this.NhapB.Text = "NHẬP B:";
            // 
            // textboxNhapA
            // 
            this.textboxNhapA.CausesValidation = false;
            this.textboxNhapA.Location = new System.Drawing.Point(133, 155);
            this.textboxNhapA.Name = "textboxNhapA";
            this.textboxNhapA.Size = new System.Drawing.Size(121, 22);
            this.textboxNhapA.TabIndex = 2;
            // 
            // textBoxNhapB
            // 
            this.textBoxNhapB.CausesValidation = false;
            this.textBoxNhapB.Location = new System.Drawing.Point(133, 204);
            this.textBoxNhapB.Name = "textBoxNhapB";
            this.textBoxNhapB.Size = new System.Drawing.Size(121, 22);
            this.textBoxNhapB.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(43, 299);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(210, 30);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "TÍNH CÁC GIÁ TRỊ";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(43, 335);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(210, 30);
            this.xoa.TabIndex = 6;
            this.xoa.Text = "XÓA";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(44, 371);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(210, 30);
            this.thoat.TabIndex = 7;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(319, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 247);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 101);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(153, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 100);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(43, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 100);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // B5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNhapB);
            this.Controls.Add(this.textboxNhapA);
            this.Controls.Add(this.NhapB);
            this.Controls.Add(this.NhapA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "B5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B5";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NhapA;
        private System.Windows.Forms.Label NhapB;
        private System.Windows.Forms.TextBox textboxNhapA;
        private System.Windows.Forms.TextBox textBoxNhapB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}