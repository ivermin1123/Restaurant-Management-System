namespace QuanLyQuanBeer
{
    partial class fChuyenBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChuyenBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvTableFrom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMaHDPhai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBanPhai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMaHDTrai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLoaiSP = new System.Windows.Forms.Label();
            this.btSangTraiAll = new Bunifu.Framework.UI.BunifuImageButton();
            this.btSangPhaiAll = new Bunifu.Framework.UI.BunifuImageButton();
            this.btSangPhai1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btSangTrai1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvTableTo = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbBanTrai = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSangTraiAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSangPhaiAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSangPhai1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSangTrai1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lsvTableTo);
            this.panel1.Controls.Add(this.lsvTableFrom);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btSangTraiAll);
            this.panel1.Controls.Add(this.btSangPhaiAll);
            this.panel1.Controls.Add(this.btSangPhai1);
            this.panel1.Controls.Add(this.btSangTrai1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 590);
            this.panel1.TabIndex = 0;
            // 
            // lsvTableFrom
            // 
            this.lsvTableFrom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader4});
            this.lsvTableFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvTableFrom.FullRowSelect = true;
            this.lsvTableFrom.GridLines = true;
            this.lsvTableFrom.HideSelection = false;
            this.lsvTableFrom.Location = new System.Drawing.Point(13, 174);
            this.lsvTableFrom.Name = "lsvTableFrom";
            this.lsvTableFrom.Size = new System.Drawing.Size(475, 401);
            this.lsvTableFrom.TabIndex = 16;
            this.lsvTableFrom.UseCompatibleStateImageBehavior = false;
            this.lsvTableFrom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.Width = 41;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Đơn vị";
            this.columnHeader9.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 113;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txbMaHDPhai);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbxBanPhai);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(575, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 87);
            this.panel4.TabIndex = 15;
            // 
            // txbMaHDPhai
            // 
            this.txbMaHDPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaHDPhai.Location = new System.Drawing.Point(134, 10);
            this.txbMaHDPhai.MaxLength = 2;
            this.txbMaHDPhai.Name = "txbMaHDPhai";
            this.txbMaHDPhai.Size = new System.Drawing.Size(298, 29);
            this.txbMaHDPhai.TabIndex = 70;
            this.txbMaHDPhai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(89, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Bàn:";
            // 
            // cbxBanPhai
            // 
            this.cbxBanPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBanPhai.FormattingEnabled = true;
            this.cbxBanPhai.Location = new System.Drawing.Point(134, 48);
            this.cbxBanPhai.Name = "cbxBanPhai";
            this.cbxBanPhai.Size = new System.Drawing.Size(298, 32);
            this.cbxBanPhai.TabIndex = 68;
            this.cbxBanPhai.SelectedIndexChanged += new System.EventHandler(this.cbxBanPhai_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(31, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txbBanTrai);
            this.panel3.Controls.Add(this.txbMaHDTrai);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelLoaiSP);
            this.panel3.Location = new System.Drawing.Point(13, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 87);
            this.panel3.TabIndex = 15;
            // 
            // txbMaHDTrai
            // 
            this.txbMaHDTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaHDTrai.Location = new System.Drawing.Point(134, 10);
            this.txbMaHDTrai.MaxLength = 2;
            this.txbMaHDTrai.Name = "txbMaHDTrai";
            this.txbMaHDTrai.Size = new System.Drawing.Size(298, 29);
            this.txbMaHDTrai.TabIndex = 70;
            this.txbMaHDTrai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(89, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Bàn:";
            // 
            // labelLoaiSP
            // 
            this.labelLoaiSP.AutoSize = true;
            this.labelLoaiSP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelLoaiSP.Location = new System.Drawing.Point(31, 15);
            this.labelLoaiSP.Name = "labelLoaiSP";
            this.labelLoaiSP.Size = new System.Drawing.Size(97, 21);
            this.labelLoaiSP.TabIndex = 67;
            this.labelLoaiSP.Text = "Mã hóa đơn:";
            // 
            // btSangTraiAll
            // 
            this.btSangTraiAll.BackColor = System.Drawing.Color.White;
            this.btSangTraiAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btSangTraiAll.Image = ((System.Drawing.Image)(resources.GetObject("btSangTraiAll.Image")));
            this.btSangTraiAll.ImageActive = null;
            this.btSangTraiAll.Location = new System.Drawing.Point(494, 479);
            this.btSangTraiAll.Name = "btSangTraiAll";
            this.btSangTraiAll.Size = new System.Drawing.Size(60, 50);
            this.btSangTraiAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSangTraiAll.TabIndex = 11;
            this.btSangTraiAll.TabStop = false;
            this.btSangTraiAll.Zoom = 10;
            this.btSangTraiAll.Click += new System.EventHandler(this.btSangTraiAll_Click);
            // 
            // btSangPhaiAll
            // 
            this.btSangPhaiAll.BackColor = System.Drawing.Color.White;
            this.btSangPhaiAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btSangPhaiAll.Image = ((System.Drawing.Image)(resources.GetObject("btSangPhaiAll.Image")));
            this.btSangPhaiAll.ImageActive = null;
            this.btSangPhaiAll.Location = new System.Drawing.Point(494, 301);
            this.btSangPhaiAll.Name = "btSangPhaiAll";
            this.btSangPhaiAll.Size = new System.Drawing.Size(60, 50);
            this.btSangPhaiAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSangPhaiAll.TabIndex = 12;
            this.btSangPhaiAll.TabStop = false;
            this.btSangPhaiAll.Zoom = 10;
            this.btSangPhaiAll.Click += new System.EventHandler(this.btSangPhaiAll_Click);
            // 
            // btSangPhai1
            // 
            this.btSangPhai1.BackColor = System.Drawing.Color.White;
            this.btSangPhai1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btSangPhai1.Image = ((System.Drawing.Image)(resources.GetObject("btSangPhai1.Image")));
            this.btSangPhai1.ImageActive = null;
            this.btSangPhai1.Location = new System.Drawing.Point(494, 231);
            this.btSangPhai1.Name = "btSangPhai1";
            this.btSangPhai1.Size = new System.Drawing.Size(60, 50);
            this.btSangPhai1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSangPhai1.TabIndex = 13;
            this.btSangPhai1.TabStop = false;
            this.btSangPhai1.Zoom = 10;
            this.btSangPhai1.Click += new System.EventHandler(this.btSangPhai1_Click);
            // 
            // btSangTrai1
            // 
            this.btSangTrai1.BackColor = System.Drawing.Color.White;
            this.btSangTrai1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btSangTrai1.Image = ((System.Drawing.Image)(resources.GetObject("btSangTrai1.Image")));
            this.btSangTrai1.ImageActive = null;
            this.btSangTrai1.Location = new System.Drawing.Point(494, 413);
            this.btSangTrai1.Name = "btSangTrai1";
            this.btSangTrai1.Size = new System.Drawing.Size(60, 50);
            this.btSangTrai1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSangTrai1.TabIndex = 14;
            this.btSangTrai1.TabStop = false;
            this.btSangTrai1.Zoom = 10;
            this.btSangTrai1.Click += new System.EventHandler(this.btSangTrai1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 48);
            this.panel2.TabIndex = 8;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageActive = null;
            this.btExit.Location = new System.Drawing.Point(1012, 6);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(28, 34);
            this.btExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btExit.TabIndex = 8;
            this.btExit.TabStop = false;
            this.btExit.Zoom = 10;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHUYỂN BÀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvTableTo
            // 
            this.lsvTableTo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.lsvTableTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvTableTo.FullRowSelect = true;
            this.lsvTableTo.GridLines = true;
            this.lsvTableTo.HideSelection = false;
            this.lsvTableTo.Location = new System.Drawing.Point(560, 174);
            this.lsvTableTo.Name = "lsvTableTo";
            this.lsvTableTo.Size = new System.Drawing.Size(475, 401);
            this.lsvTableTo.TabIndex = 16;
            this.lsvTableTo.UseCompatibleStateImageBehavior = false;
            this.lsvTableTo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên món";
            this.columnHeader5.Width = 159;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SL";
            this.columnHeader6.Width = 41;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đơn giá";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đơn vị";
            this.columnHeader8.Width = 68;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Thành tiền";
            this.columnHeader10.Width = 113;
            // 
            // txbBanTrai
            // 
            this.txbBanTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBanTrai.Location = new System.Drawing.Point(134, 48);
            this.txbBanTrai.MaxLength = 2;
            this.txbBanTrai.Name = "txbBanTrai";
            this.txbBanTrai.Size = new System.Drawing.Size(298, 29);
            this.txbBanTrai.TabIndex = 71;
            this.txbBanTrai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 590);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fChuyenBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fChuyenBan";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSangTraiAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSangPhaiAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSangPhai1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSangTrai1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btSangTraiAll;
        private Bunifu.Framework.UI.BunifuImageButton btSangPhaiAll;
        private Bunifu.Framework.UI.BunifuImageButton btSangPhai1;
        private Bunifu.Framework.UI.BunifuImageButton btSangTrai1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbMaHDTrai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLoaiSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbMaHDPhai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxBanPhai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvTableFrom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lsvTableTo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txbBanTrai;
    }
}