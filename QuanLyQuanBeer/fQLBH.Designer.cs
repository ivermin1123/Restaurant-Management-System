namespace QuanLyQuanBeer
{
    public partial class fQLBH
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLBH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btDSHoaDonBlue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGio = new System.Windows.Forms.Label();
            this.btRestore = new Bunifu.Framework.UI.BunifuImageButton();
            this.btMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btSoDowhite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btOrderPlus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btOrderwhite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSoDoblue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btOrderBlue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbNgay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btDSHoaDonWhite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.USCdSHoaDon = new QuanLyQuanBeer.DanhSachHoaDon();
            this.USCnewOrder = new QuanLyQuanBeer.NewOrder();
            this.USCsoDo = new QuanLyQuanBeer.SoDo();
            this.USCorder = new QuanLyQuanBeer.Order();
            this.USCchaoMung = new QuanLyQuanBeer.ManHinhChaoMung();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btDSHoaDonWhite);
            this.panel1.Controls.Add(this.btMinimize);
            this.panel1.Controls.Add(this.btDSHoaDonBlue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbGio);
            this.panel1.Controls.Add(this.btRestore);
            this.panel1.Controls.Add(this.btMaximize);
            this.panel1.Controls.Add(this.btSoDowhite);
            this.panel1.Controls.Add(this.btOrderPlus);
            this.panel1.Controls.Add(this.btUser);
            this.panel1.Controls.Add(this.btOrderwhite);
            this.panel1.Controls.Add(this.btSoDoblue);
            this.panel1.Controls.Add(this.btOrderBlue);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.lbNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 52);
            this.panel1.TabIndex = 1;
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btMinimize.Image")));
            this.btMinimize.ImageActive = null;
            this.btMinimize.Location = new System.Drawing.Point(1143, 5);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(49, 44);
            this.btMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMinimize.TabIndex = 20;
            this.btMinimize.TabStop = false;
            this.btMinimize.Zoom = 10;
            this.btMinimize.Click += new System.EventHandler(this.BtMinimize_Click);
            // 
            // btDSHoaDonBlue
            // 
            this.btDSHoaDonBlue.Active = false;
            this.btDSHoaDonBlue.Activecolor = System.Drawing.Color.White;
            this.btDSHoaDonBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btDSHoaDonBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDSHoaDonBlue.BorderRadius = 0;
            this.btDSHoaDonBlue.ButtonText = "   DS Hóa Đơn";
            this.btDSHoaDonBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDSHoaDonBlue.DisabledColor = System.Drawing.Color.Gray;
            this.btDSHoaDonBlue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSHoaDonBlue.Iconcolor = System.Drawing.Color.Transparent;
            this.btDSHoaDonBlue.Iconimage = ((System.Drawing.Image)(resources.GetObject("btDSHoaDonBlue.Iconimage")));
            this.btDSHoaDonBlue.Iconimage_right = null;
            this.btDSHoaDonBlue.Iconimage_right_Selected = null;
            this.btDSHoaDonBlue.Iconimage_Selected = null;
            this.btDSHoaDonBlue.IconMarginLeft = 0;
            this.btDSHoaDonBlue.IconMarginRight = 0;
            this.btDSHoaDonBlue.IconRightVisible = true;
            this.btDSHoaDonBlue.IconRightZoom = 0D;
            this.btDSHoaDonBlue.IconVisible = true;
            this.btDSHoaDonBlue.IconZoom = 55D;
            this.btDSHoaDonBlue.IsTab = false;
            this.btDSHoaDonBlue.Location = new System.Drawing.Point(345, 13);
            this.btDSHoaDonBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDSHoaDonBlue.Name = "btDSHoaDonBlue";
            this.btDSHoaDonBlue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btDSHoaDonBlue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btDSHoaDonBlue.OnHoverTextColor = System.Drawing.Color.White;
            this.btDSHoaDonBlue.selected = false;
            this.btDSHoaDonBlue.Size = new System.Drawing.Size(176, 42);
            this.btDSHoaDonBlue.TabIndex = 19;
            this.btDSHoaDonBlue.Text = "   DS Hóa Đơn";
            this.btDSHoaDonBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDSHoaDonBlue.Textcolor = System.Drawing.Color.White;
            this.btDSHoaDonBlue.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSHoaDonBlue.Click += new System.EventHandler(this.BtDSHoaDonBlue_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(742, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thời gian:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(936, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGio
            // 
            this.lbGio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGio.AutoSize = true;
            this.lbGio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGio.ForeColor = System.Drawing.Color.White;
            this.lbGio.Location = new System.Drawing.Point(951, 18);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(80, 25);
            this.lbGio.TabIndex = 15;
            this.lbGio.Text = "00:00:00";
            this.lbGio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btRestore
            // 
            this.btRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestore.Image = ((System.Drawing.Image)(resources.GetObject("btRestore.Image")));
            this.btRestore.ImageActive = null;
            this.btRestore.Location = new System.Drawing.Point(1195, 5);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(49, 44);
            this.btRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRestore.TabIndex = 13;
            this.btRestore.TabStop = false;
            this.btRestore.Visible = false;
            this.btRestore.Zoom = 10;
            this.btRestore.Click += new System.EventHandler(this.BtRestore_Click);
            // 
            // btMaximize
            // 
            this.btMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btMaximize.Image")));
            this.btMaximize.ImageActive = null;
            this.btMaximize.Location = new System.Drawing.Point(1195, 5);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(49, 44);
            this.btMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMaximize.TabIndex = 12;
            this.btMaximize.TabStop = false;
            this.btMaximize.Zoom = 10;
            this.btMaximize.Click += new System.EventHandler(this.BtMaximize_Click);
            // 
            // btSoDowhite
            // 
            this.btSoDowhite.Active = false;
            this.btSoDowhite.Activecolor = System.Drawing.Color.White;
            this.btSoDowhite.BackColor = System.Drawing.Color.White;
            this.btSoDowhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSoDowhite.BorderRadius = 0;
            this.btSoDowhite.ButtonText = "   Sơ đồ";
            this.btSoDowhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSoDowhite.DisabledColor = System.Drawing.Color.Gray;
            this.btSoDowhite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoDowhite.Iconcolor = System.Drawing.Color.Transparent;
            this.btSoDowhite.Iconimage = ((System.Drawing.Image)(resources.GetObject("btSoDowhite.Iconimage")));
            this.btSoDowhite.Iconimage_right = null;
            this.btSoDowhite.Iconimage_right_Selected = null;
            this.btSoDowhite.Iconimage_Selected = null;
            this.btSoDowhite.IconMarginLeft = 0;
            this.btSoDowhite.IconMarginRight = 0;
            this.btSoDowhite.IconRightVisible = true;
            this.btSoDowhite.IconRightZoom = 0D;
            this.btSoDowhite.IconVisible = true;
            this.btSoDowhite.IconZoom = 55D;
            this.btSoDowhite.IsTab = false;
            this.btSoDowhite.Location = new System.Drawing.Point(220, 13);
            this.btSoDowhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSoDowhite.Name = "btSoDowhite";
            this.btSoDowhite.Normalcolor = System.Drawing.Color.White;
            this.btSoDowhite.OnHovercolor = System.Drawing.Color.White;
            this.btSoDowhite.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btSoDowhite.selected = false;
            this.btSoDowhite.Size = new System.Drawing.Size(126, 42);
            this.btSoDowhite.TabIndex = 5;
            this.btSoDowhite.Text = "   Sơ đồ";
            this.btSoDowhite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSoDowhite.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btSoDowhite.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoDowhite.Visible = false;
            this.btSoDowhite.Click += new System.EventHandler(this.BtSoDowhite_Click);
            // 
            // btOrderPlus
            // 
            this.btOrderPlus.Active = false;
            this.btOrderPlus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btOrderPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOrderPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btOrderPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOrderPlus.BorderRadius = 0;
            this.btOrderPlus.ButtonText = "   ORDER";
            this.btOrderPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderPlus.DisabledColor = System.Drawing.Color.Gray;
            this.btOrderPlus.Iconcolor = System.Drawing.Color.Transparent;
            this.btOrderPlus.Iconimage = ((System.Drawing.Image)(resources.GetObject("btOrderPlus.Iconimage")));
            this.btOrderPlus.Iconimage_right = null;
            this.btOrderPlus.Iconimage_right_Selected = null;
            this.btOrderPlus.Iconimage_Selected = null;
            this.btOrderPlus.IconMarginLeft = 0;
            this.btOrderPlus.IconMarginRight = 0;
            this.btOrderPlus.IconRightVisible = true;
            this.btOrderPlus.IconRightZoom = 0D;
            this.btOrderPlus.IconVisible = true;
            this.btOrderPlus.IconZoom = 55D;
            this.btOrderPlus.IsTab = false;
            this.btOrderPlus.Location = new System.Drawing.Point(1023, 5);
            this.btOrderPlus.Name = "btOrderPlus";
            this.btOrderPlus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btOrderPlus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btOrderPlus.OnHoverTextColor = System.Drawing.Color.White;
            this.btOrderPlus.selected = false;
            this.btOrderPlus.Size = new System.Drawing.Size(114, 48);
            this.btOrderPlus.TabIndex = 8;
            this.btOrderPlus.Text = "   ORDER";
            this.btOrderPlus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOrderPlus.Textcolor = System.Drawing.Color.White;
            this.btOrderPlus.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderPlus.Click += new System.EventHandler(this.BtOrderPlus_Click);
            // 
            // btUser
            // 
            this.btUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUser.Image = ((System.Drawing.Image)(resources.GetObject("btUser.Image")));
            this.btUser.ImageActive = null;
            this.btUser.Location = new System.Drawing.Point(1250, 5);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(49, 44);
            this.btUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btUser.TabIndex = 6;
            this.btUser.TabStop = false;
            this.btUser.Zoom = 10;
            this.btUser.Click += new System.EventHandler(this.BtUser_Click);
            // 
            // btOrderwhite
            // 
            this.btOrderwhite.Active = false;
            this.btOrderwhite.Activecolor = System.Drawing.Color.White;
            this.btOrderwhite.BackColor = System.Drawing.Color.White;
            this.btOrderwhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOrderwhite.BorderRadius = 0;
            this.btOrderwhite.ButtonText = "  Order";
            this.btOrderwhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderwhite.DisabledColor = System.Drawing.Color.Gray;
            this.btOrderwhite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderwhite.Iconcolor = System.Drawing.Color.Transparent;
            this.btOrderwhite.Iconimage = ((System.Drawing.Image)(resources.GetObject("btOrderwhite.Iconimage")));
            this.btOrderwhite.Iconimage_right = null;
            this.btOrderwhite.Iconimage_right_Selected = null;
            this.btOrderwhite.Iconimage_Selected = null;
            this.btOrderwhite.IconMarginLeft = 0;
            this.btOrderwhite.IconMarginRight = 0;
            this.btOrderwhite.IconRightVisible = true;
            this.btOrderwhite.IconRightZoom = 0D;
            this.btOrderwhite.IconVisible = true;
            this.btOrderwhite.IconZoom = 55D;
            this.btOrderwhite.IsTab = false;
            this.btOrderwhite.Location = new System.Drawing.Point(95, 13);
            this.btOrderwhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOrderwhite.Name = "btOrderwhite";
            this.btOrderwhite.Normalcolor = System.Drawing.Color.White;
            this.btOrderwhite.OnHovercolor = System.Drawing.Color.White;
            this.btOrderwhite.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btOrderwhite.selected = false;
            this.btOrderwhite.Size = new System.Drawing.Size(126, 42);
            this.btOrderwhite.TabIndex = 4;
            this.btOrderwhite.Text = "  Order";
            this.btOrderwhite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOrderwhite.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btOrderwhite.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderwhite.Visible = false;
            this.btOrderwhite.Click += new System.EventHandler(this.BtOrderwhite_Click);
            // 
            // btSoDoblue
            // 
            this.btSoDoblue.Active = false;
            this.btSoDoblue.Activecolor = System.Drawing.Color.White;
            this.btSoDoblue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btSoDoblue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSoDoblue.BorderRadius = 0;
            this.btSoDoblue.ButtonText = "   Sơ đồ";
            this.btSoDoblue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSoDoblue.DisabledColor = System.Drawing.Color.Gray;
            this.btSoDoblue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoDoblue.Iconcolor = System.Drawing.Color.Transparent;
            this.btSoDoblue.Iconimage = ((System.Drawing.Image)(resources.GetObject("btSoDoblue.Iconimage")));
            this.btSoDoblue.Iconimage_right = null;
            this.btSoDoblue.Iconimage_right_Selected = null;
            this.btSoDoblue.Iconimage_Selected = null;
            this.btSoDoblue.IconMarginLeft = 0;
            this.btSoDoblue.IconMarginRight = 0;
            this.btSoDoblue.IconRightVisible = true;
            this.btSoDoblue.IconRightZoom = 0D;
            this.btSoDoblue.IconVisible = true;
            this.btSoDoblue.IconZoom = 55D;
            this.btSoDoblue.IsTab = false;
            this.btSoDoblue.Location = new System.Drawing.Point(220, 13);
            this.btSoDoblue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSoDoblue.Name = "btSoDoblue";
            this.btSoDoblue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btSoDoblue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btSoDoblue.OnHoverTextColor = System.Drawing.Color.White;
            this.btSoDoblue.selected = false;
            this.btSoDoblue.Size = new System.Drawing.Size(126, 42);
            this.btSoDoblue.TabIndex = 3;
            this.btSoDoblue.Text = "   Sơ đồ";
            this.btSoDoblue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSoDoblue.Textcolor = System.Drawing.Color.White;
            this.btSoDoblue.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoDoblue.Click += new System.EventHandler(this.BtSoDoblue_Click_1);
            // 
            // btOrderBlue
            // 
            this.btOrderBlue.Active = false;
            this.btOrderBlue.Activecolor = System.Drawing.Color.White;
            this.btOrderBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btOrderBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOrderBlue.BorderRadius = 0;
            this.btOrderBlue.ButtonText = "  Order";
            this.btOrderBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderBlue.DisabledColor = System.Drawing.Color.Gray;
            this.btOrderBlue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderBlue.Iconcolor = System.Drawing.Color.Transparent;
            this.btOrderBlue.Iconimage = ((System.Drawing.Image)(resources.GetObject("btOrderBlue.Iconimage")));
            this.btOrderBlue.Iconimage_right = null;
            this.btOrderBlue.Iconimage_right_Selected = null;
            this.btOrderBlue.Iconimage_Selected = null;
            this.btOrderBlue.IconMarginLeft = 0;
            this.btOrderBlue.IconMarginRight = 0;
            this.btOrderBlue.IconRightVisible = true;
            this.btOrderBlue.IconRightZoom = 0D;
            this.btOrderBlue.IconVisible = true;
            this.btOrderBlue.IconZoom = 55D;
            this.btOrderBlue.IsTab = false;
            this.btOrderBlue.Location = new System.Drawing.Point(91, 12);
            this.btOrderBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOrderBlue.Name = "btOrderBlue";
            this.btOrderBlue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btOrderBlue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btOrderBlue.OnHoverTextColor = System.Drawing.Color.White;
            this.btOrderBlue.selected = false;
            this.btOrderBlue.Size = new System.Drawing.Size(126, 42);
            this.btOrderBlue.TabIndex = 2;
            this.btOrderBlue.Text = "  Order";
            this.btOrderBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOrderBlue.Textcolor = System.Drawing.Color.White;
            this.btOrderBlue.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderBlue.Click += new System.EventHandler(this.BtOrderBlue_Click);
            // 
            // btHome
            // 
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImageActive = null;
            this.btHome.Location = new System.Drawing.Point(1, 8);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(88, 44);
            this.btHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btHome.TabIndex = 0;
            this.btHome.TabStop = false;
            this.btHome.Zoom = 10;
            this.btHome.Click += new System.EventHandler(this.BtHome_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.White;
            this.lbNgay.Location = new System.Drawing.Point(834, 18);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(106, 25);
            this.lbNgay.TabIndex = 14;
            this.lbNgay.Text = "00/00/0000";
            this.lbNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.USCdSHoaDon);
            this.panel2.Controls.Add(this.USCnewOrder);
            this.panel2.Controls.Add(this.USCsoDo);
            this.panel2.Controls.Add(this.USCorder);
            this.panel2.Controls.Add(this.USCchaoMung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1302, 726);
            this.panel2.TabIndex = 2;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btDSHoaDonWhite
            // 
            this.btDSHoaDonWhite.Active = false;
            this.btDSHoaDonWhite.Activecolor = System.Drawing.Color.White;
            this.btDSHoaDonWhite.BackColor = System.Drawing.Color.White;
            this.btDSHoaDonWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDSHoaDonWhite.BorderRadius = 0;
            this.btDSHoaDonWhite.ButtonText = "   DS Hóa Đơn";
            this.btDSHoaDonWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDSHoaDonWhite.DisabledColor = System.Drawing.Color.Gray;
            this.btDSHoaDonWhite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSHoaDonWhite.Iconcolor = System.Drawing.Color.Transparent;
            this.btDSHoaDonWhite.Iconimage = ((System.Drawing.Image)(resources.GetObject("btDSHoaDonWhite.Iconimage")));
            this.btDSHoaDonWhite.Iconimage_right = null;
            this.btDSHoaDonWhite.Iconimage_right_Selected = null;
            this.btDSHoaDonWhite.Iconimage_Selected = null;
            this.btDSHoaDonWhite.IconMarginLeft = 0;
            this.btDSHoaDonWhite.IconMarginRight = 0;
            this.btDSHoaDonWhite.IconRightVisible = true;
            this.btDSHoaDonWhite.IconRightZoom = 0D;
            this.btDSHoaDonWhite.IconVisible = true;
            this.btDSHoaDonWhite.IconZoom = 55D;
            this.btDSHoaDonWhite.IsTab = false;
            this.btDSHoaDonWhite.Location = new System.Drawing.Point(345, 13);
            this.btDSHoaDonWhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDSHoaDonWhite.Name = "btDSHoaDonWhite";
            this.btDSHoaDonWhite.Normalcolor = System.Drawing.Color.White;
            this.btDSHoaDonWhite.OnHovercolor = System.Drawing.Color.White;
            this.btDSHoaDonWhite.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btDSHoaDonWhite.selected = false;
            this.btDSHoaDonWhite.Size = new System.Drawing.Size(176, 42);
            this.btDSHoaDonWhite.TabIndex = 21;
            this.btDSHoaDonWhite.Text = "   DS Hóa Đơn";
            this.btDSHoaDonWhite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDSHoaDonWhite.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btDSHoaDonWhite.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSHoaDonWhite.Visible = false;
            this.btDSHoaDonWhite.Click += new System.EventHandler(this.BtDSHoaDonWhite_Click);
            // 
            // USCdSHoaDon
            // 
            this.USCdSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USCdSHoaDon.Location = new System.Drawing.Point(0, 0);
            this.USCdSHoaDon.Name = "USCdSHoaDon";
            this.USCdSHoaDon.Size = new System.Drawing.Size(1302, 726);
            this.USCdSHoaDon.TabIndex = 8;
            this.USCdSHoaDon.Visible = false;
            // 
            // USCnewOrder
            // 
            this.USCnewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USCnewOrder.Location = new System.Drawing.Point(0, 0);
            this.USCnewOrder.Name = "USCnewOrder";
            this.USCnewOrder.Size = new System.Drawing.Size(1302, 726);
            this.USCnewOrder.TabIndex = 0;
            this.USCnewOrder.Visible = false;
            // 
            // USCsoDo
            // 
            this.USCsoDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USCsoDo.Location = new System.Drawing.Point(0, 0);
            this.USCsoDo.Name = "USCsoDo";
            this.USCsoDo.Size = new System.Drawing.Size(1302, 726);
            this.USCsoDo.TabIndex = 2;
            this.USCsoDo.Visible = false;
            this.USCsoDo.Load += new System.EventHandler(this.USCsoDo_Load);
            // 
            // USCorder
            // 
            this.USCorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.USCorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USCorder.Location = new System.Drawing.Point(0, 0);
            this.USCorder.Name = "USCorder";
            this.USCorder.Size = new System.Drawing.Size(1302, 726);
            this.USCorder.TabIndex = 1;
            this.USCorder.Visible = false;
            // 
            // USCchaoMung
            // 
            this.USCchaoMung.BackColor = System.Drawing.Color.White;
            this.USCchaoMung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USCchaoMung.Location = new System.Drawing.Point(0, 0);
            this.USCchaoMung.Name = "USCchaoMung";
            this.USCchaoMung.Size = new System.Drawing.Size(1302, 726);
            this.USCchaoMung.TabIndex = 7;
            this.USCchaoMung.Visible = false;
            // 
            // fQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 778);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQLBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQLBH";
            this.Load += new System.EventHandler(this.FQLBH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btHome;
        private Bunifu.Framework.UI.BunifuFlatButton btSoDoblue;
        private Bunifu.Framework.UI.BunifuFlatButton btOrderBlue;
        private Bunifu.Framework.UI.BunifuFlatButton btOrderwhite;
        private Bunifu.Framework.UI.BunifuFlatButton btSoDowhite;
        private Bunifu.Framework.UI.BunifuImageButton btUser;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btOrderPlus;
        private Bunifu.Framework.UI.BunifuImageButton btMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btRestore;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Order USCorder;
        public SoDo USCsoDo;
        public ManHinhChaoMung USCchaoMung;
        public NewOrder USCnewOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btDSHoaDonBlue;
        private Bunifu.Framework.UI.BunifuImageButton btMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btDSHoaDonWhite;
        private DanhSachHoaDon USCdSHoaDon;
    }
}