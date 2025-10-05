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
            this.NhapA = new System.Windows.Forms.Label();
            this.NhapB = new System.Windows.Forms.Label();
            this.textboxNhapA = new System.Windows.Forms.TextBox();
            this.textBoxNhapB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.calculate = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NhapA
            // 
            this.NhapA.AutoSize = true;
            this.NhapA.Location = new System.Drawing.Point(69, 112);
            this.NhapA.Name = "NhapA";
            this.NhapA.Size = new System.Drawing.Size(60, 16);
            this.NhapA.TabIndex = 0;
            this.NhapA.Text = "NHẬP A:";
            // 
            // NhapB
            // 
            this.NhapB.AutoSize = true;
            this.NhapB.Location = new System.Drawing.Point(69, 154);
            this.NhapB.Name = "NhapB";
            this.NhapB.Size = new System.Drawing.Size(60, 16);
            this.NhapB.TabIndex = 1;
            this.NhapB.Text = "NHẬP B:";
            // 
            // textboxNhapA
            // 
            this.textboxNhapA.Location = new System.Drawing.Point(152, 105);
            this.textboxNhapA.Name = "textboxNhapA";
            this.textboxNhapA.Size = new System.Drawing.Size(121, 22);
            this.textboxNhapA.TabIndex = 2;
            // 
            // textBoxNhapB
            // 
            this.textBoxNhapB.Location = new System.Drawing.Point(152, 154);
            this.textBoxNhapB.Name = "textBoxNhapB";
            this.textBoxNhapB.Size = new System.Drawing.Size(121, 22);
            this.textBoxNhapB.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(62, 249);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(210, 30);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "TÍNH CÁC GIÁ TRỊ";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(62, 285);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(210, 30);
            this.xoa.TabIndex = 6;
            this.xoa.Text = "XÓA";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(63, 321);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(210, 30);
            this.thoat.TabIndex = 7;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(338, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 247);
            this.panel1.TabIndex = 8;
            // 
            // B5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNhapB);
            this.Controls.Add(this.textboxNhapA);
            this.Controls.Add(this.NhapB);
            this.Controls.Add(this.NhapA);
            this.Name = "B5";
            this.Text = "B5";
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
    }
}