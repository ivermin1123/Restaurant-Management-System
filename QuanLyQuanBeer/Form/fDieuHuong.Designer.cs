namespace QuanLyQuanBeer
{
    partial class fDieuHuong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChaoMung = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.lbNguoiDN = new System.Windows.Forms.Label();
            this.btDX = new System.Windows.Forms.Button();
            this.btQLHT = new System.Windows.Forms.Button();
            this.btQLBH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(181)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.lbChaoMung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 44);
            this.panel1.TabIndex = 0;
            // 
            // lbChaoMung
            // 
            this.lbChaoMung.AutoSize = true;
            this.lbChaoMung.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChaoMung.ForeColor = System.Drawing.Color.Black;
            this.lbChaoMung.Location = new System.Drawing.Point(57, 9);
            this.lbChaoMung.Name = "lbChaoMung";
            this.lbChaoMung.Size = new System.Drawing.Size(442, 26);
            this.lbChaoMung.TabIndex = 0;
            this.lbChaoMung.Text = "CHÀO MỪNG BẠN ĐẾN VỚI PHẦN MỀM QUẢN LÝ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbThoiGian);
            this.panel2.Controls.Add(this.lbNguoiDN);
            this.panel2.Controls.Add(this.btDX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 73);
            this.panel2.TabIndex = 1;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(4, 40);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(94, 24);
            this.lbThoiGian.TabIndex = 35;
            this.lbThoiGian.Text = "Thời gian:";
            // 
            // lbNguoiDN
            // 
            this.lbNguoiDN.AutoSize = true;
            this.lbNguoiDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiDN.Location = new System.Drawing.Point(4, 9);
            this.lbNguoiDN.Name = "lbNguoiDN";
            this.lbNguoiDN.Size = new System.Drawing.Size(244, 24);
            this.lbNguoiDN.TabIndex = 34;
            this.lbNguoiDN.Text = "Tài khoản đang đăng nhập:";
            // 
            // btDX
            // 
            this.btDX.BackColor = System.Drawing.Color.Crimson;
            this.btDX.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDX.FlatAppearance.BorderSize = 0;
            this.btDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDX.ForeColor = System.Drawing.Color.White;
            this.btDX.Location = new System.Drawing.Point(389, 9);
            this.btDX.Name = "btDX";
            this.btDX.Size = new System.Drawing.Size(139, 43);
            this.btDX.TabIndex = 33;
            this.btDX.Text = "Đăng xuất";
            this.btDX.UseVisualStyleBackColor = false;
            // 
            // btQLHT
            // 
            this.btQLHT.BackColor = System.Drawing.Color.White;
            this.btQLHT.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btQLHT.FlatAppearance.BorderSize = 3;
            this.btQLHT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btQLHT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btQLHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLHT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btQLHT.Location = new System.Drawing.Point(33, 68);
            this.btQLHT.Name = "btQLHT";
            this.btQLHT.Size = new System.Drawing.Size(215, 133);
            this.btQLHT.TabIndex = 2;
            this.btQLHT.Text = "QUẢN LÝ HỆ THỐNG";
            this.btQLHT.UseVisualStyleBackColor = false;
            this.btQLHT.Click += new System.EventHandler(this.BtQLHT_Click);
            // 
            // btQLBH
            // 
            this.btQLBH.BackColor = System.Drawing.Color.White;
            this.btQLBH.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btQLBH.FlatAppearance.BorderSize = 3;
            this.btQLBH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btQLBH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btQLBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLBH.ForeColor = System.Drawing.Color.Crimson;
            this.btQLBH.Location = new System.Drawing.Point(295, 68);
            this.btQLBH.Name = "btQLBH";
            this.btQLBH.Size = new System.Drawing.Size(215, 133);
            this.btQLBH.TabIndex = 3;
            this.btQLBH.Text = "QUẢN LÝ BÁN \r\nHÀNG";
            this.btQLBH.UseVisualStyleBackColor = false;
            this.btQLBH.Click += new System.EventHandler(this.BtQLBH_Click);
            // 
            // fDieuHuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 287);
            this.Controls.Add(this.btQLBH);
            this.Controls.Add(this.btQLHT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDieuHuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDieuHuong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChaoMung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btQLHT;
        private System.Windows.Forms.Button btQLBH;
        private System.Windows.Forms.Button btDX;
        private System.Windows.Forms.Label lbNguoiDN;
        private System.Windows.Forms.Label lbThoiGian;
    }
}