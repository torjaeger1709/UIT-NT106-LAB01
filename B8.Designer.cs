namespace WindowsFormsApp1
{
    partial class B8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B8));
            this.label1 = new System.Windows.Forms.Label();
            this.addFoodtxt = new System.Windows.Forms.TextBox();
            this.addFoodBtn = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.ListBox();
            this.Find = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.exitForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm món ăn:";
            // 
            // addFoodtxt
            // 
            this.addFoodtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodtxt.Location = new System.Drawing.Point(160, 94);
            this.addFoodtxt.Name = "addFoodtxt";
            this.addFoodtxt.Size = new System.Drawing.Size(304, 26);
            this.addFoodtxt.TabIndex = 1;
            // 
            // addFoodBtn
            // 
            this.addFoodBtn.BackColor = System.Drawing.Color.Khaki;
            this.addFoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodBtn.Location = new System.Drawing.Point(484, 94);
            this.addFoodBtn.Name = "addFoodBtn";
            this.addFoodBtn.Size = new System.Drawing.Size(74, 30);
            this.addFoodBtn.TabIndex = 2;
            this.addFoodBtn.Text = "THÊM";
            this.addFoodBtn.UseVisualStyleBackColor = false;
            this.addFoodBtn.Click += new System.EventHandler(this.addFoodBtn_Click);
            // 
            // Food
            // 
            this.Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.FormattingEnabled = true;
            this.Food.ItemHeight = 22;
            this.Food.Location = new System.Drawing.Point(42, 133);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(422, 202);
            this.Food.TabIndex = 3;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.LightGreen;
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(484, 136);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(73, 54);
            this.Find.TabIndex = 4;
            this.Find.Text = "TÌM";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Aqua;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(484, 215);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(73, 54);
            this.delete.TabIndex = 5;
            this.delete.Text = "XÓA";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // exitForm
            // 
            this.exitForm.BackColor = System.Drawing.Color.LightCoral;
            this.exitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitForm.Location = new System.Drawing.Point(484, 291);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(73, 54);
            this.exitForm.TabIndex = 6;
            this.exitForm.Text = "THOÁT";
            this.exitForm.UseVisualStyleBackColor = false;
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Món ăn hôm nay: ";
            // 
            // ketqua
            // 
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.Location = new System.Drawing.Point(194, 355);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(270, 28);
            this.ketqua.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, -6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 79);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(667, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "NGƯỜI YÊU BẠN KHÔNG BIẾT ĂN GÌ? HÃY ĐỂ CHÚNG TÔI LO!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // B8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.addFoodBtn);
            this.Controls.Add(this.addFoodtxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "B8";
            this.Text = "B8";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addFoodtxt;
        private System.Windows.Forms.Button addFoodBtn;
        private System.Windows.Forms.ListBox Food;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exitForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}