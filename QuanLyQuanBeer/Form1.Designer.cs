namespace QuanLyQuanBeer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbND = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btXoa = new Bunifu.Framework.UI.BunifuImageButton();
            this.txbGiamGia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.txbGiamTien = new System.Windows.Forms.TextBox();
            this.txbDieuKien = new System.Windows.Forms.TextBox();
            this.txbToiDa = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txbND);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 29);
            this.panel2.TabIndex = 3;
            // 
            // txbND
            // 
            this.txbND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbND.Location = new System.Drawing.Point(0, 0);
            this.txbND.MaxLength = 9999;
            this.txbND.Name = "txbND";
            this.txbND.Size = new System.Drawing.Size(837, 29);
            this.txbND.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txbGiamGia);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.txbGiamTien);
            this.panel3.Controls.Add(this.txbDieuKien);
            this.panel3.Controls.Add(this.txbToiDa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(356, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 29);
            this.panel3.TabIndex = 112;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btXoa);
            this.panel4.Location = new System.Drawing.Point(448, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 29);
            this.panel4.TabIndex = 108;
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageActive = null;
            this.btXoa.Location = new System.Drawing.Point(-3, -1);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(35, 29);
            this.btXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btXoa.TabIndex = 112;
            this.btXoa.TabStop = false;
            this.btXoa.Zoom = 10;
            // 
            // txbGiamGia
            // 
            this.txbGiamGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGiamGia.Location = new System.Drawing.Point(1, 0);
            this.txbGiamGia.MaxLength = 2;
            this.txbGiamGia.Name = "txbGiamGia";
            this.txbGiamGia.Size = new System.Drawing.Size(53, 29);
            this.txbGiamGia.TabIndex = 1;
            this.txbGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuSwitch1);
            this.panel1.Location = new System.Drawing.Point(389, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 29);
            this.panel1.TabIndex = 107;
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(3, 5);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch1.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch1.TabIndex = 5;
            this.bunifuSwitch1.TabStop = false;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = false;
            // 
            // txbGiamTien
            // 
            this.txbGiamTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGiamTien.Location = new System.Drawing.Point(53, 0);
            this.txbGiamTien.MaxLength = 8;
            this.txbGiamTien.Name = "txbGiamTien";
            this.txbGiamTien.Size = new System.Drawing.Size(113, 29);
            this.txbGiamTien.TabIndex = 2;
            this.txbGiamTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbDieuKien
            // 
            this.txbDieuKien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDieuKien.Location = new System.Drawing.Point(277, 0);
            this.txbDieuKien.MaxLength = 8;
            this.txbDieuKien.Name = "txbDieuKien";
            this.txbDieuKien.Size = new System.Drawing.Size(113, 29);
            this.txbDieuKien.TabIndex = 4;
            this.txbDieuKien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbToiDa
            // 
            this.txbToiDa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbToiDa.Location = new System.Drawing.Point(165, 0);
            this.txbToiDa.MaxLength = 8;
            this.txbToiDa.Name = "txbToiDa";
            this.txbToiDa.Size = new System.Drawing.Size(113, 29);
            this.txbToiDa.TabIndex = 3;
            this.txbToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 219);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbND;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton btXoa;
        private System.Windows.Forms.TextBox txbGiamGia;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private System.Windows.Forms.TextBox txbGiamTien;
        private System.Windows.Forms.TextBox txbDieuKien;
        private System.Windows.Forms.TextBox txbToiDa;
    }
}