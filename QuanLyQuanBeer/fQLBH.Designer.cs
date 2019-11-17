namespace QuanLyQuanBeer
{
    partial class fQLBH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLBH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRestore = new Bunifu.Framework.UI.BunifuImageButton();
            this.btMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btSoDowhite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btOrderPlus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btOption = new Bunifu.Framework.UI.BunifuImageButton();
            this.btUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.btOrderwhite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSoDoblue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btOrderBlue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btQuayLai = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btTinhTien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbGio = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.USCtinhTien = new QuanLyQuanBeer.TinhTien();
            this.USCmenu = new QuanLyQuanBeer.Menu();
            this.USCnewOrder = new QuanLyQuanBeer.NewOrder();
            this.USCsoDo = new QuanLyQuanBeer.SoDo();
            this.USCorder = new QuanLyQuanBeer.Order();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbGio);
            this.panel1.Controls.Add(this.btRestore);
            this.panel1.Controls.Add(this.btMaximize);
            this.panel1.Controls.Add(this.btSoDowhite);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.btOrderPlus);
            this.panel1.Controls.Add(this.btOption);
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
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // btRestore
            // 
            this.btRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestore.Image = ((System.Drawing.Image)(resources.GetObject("btRestore.Image")));
            this.btRestore.ImageActive = null;
            this.btRestore.Location = new System.Drawing.Point(985, 5);
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
            this.btMaximize.Location = new System.Drawing.Point(985, 5);
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
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1161, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
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
            this.btOrderPlus.Location = new System.Drawing.Point(1040, 5);
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
            // btOption
            // 
            this.btOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOption.Image = ((System.Drawing.Image)(resources.GetObject("btOption.Image")));
            this.btOption.ImageActive = null;
            this.btOption.Location = new System.Drawing.Point(1210, 11);
            this.btOption.Name = "btOption";
            this.btOption.Size = new System.Drawing.Size(33, 35);
            this.btOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btOption.TabIndex = 7;
            this.btOption.TabStop = false;
            this.btOption.Zoom = 10;
            this.btOption.Click += new System.EventHandler(this.BtOption_Click);
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btQuayLai);
            this.panel2.Controls.Add(this.USCtinhTien);
            this.panel2.Controls.Add(this.btTinhTien);
            this.panel2.Controls.Add(this.USCmenu);
            this.panel2.Controls.Add(this.USCnewOrder);
            this.panel2.Controls.Add(this.USCsoDo);
            this.panel2.Controls.Add(this.USCorder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1302, 726);
            this.panel2.TabIndex = 2;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseClick);
            // 
            // btQuayLai
            // 
            this.btQuayLai.Active = false;
            this.btQuayLai.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btQuayLai.BackColor = System.Drawing.Color.White;
            this.btQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuayLai.BorderRadius = 0;
            this.btQuayLai.ButtonText = "  QUAY LẠI";
            this.btQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuayLai.DisabledColor = System.Drawing.Color.Gray;
            this.btQuayLai.Iconcolor = System.Drawing.Color.Transparent;
            this.btQuayLai.Iconimage = ((System.Drawing.Image)(resources.GetObject("btQuayLai.Iconimage")));
            this.btQuayLai.Iconimage_right = null;
            this.btQuayLai.Iconimage_right_Selected = null;
            this.btQuayLai.Iconimage_Selected = null;
            this.btQuayLai.IconMarginLeft = 0;
            this.btQuayLai.IconMarginRight = 0;
            this.btQuayLai.IconRightVisible = true;
            this.btQuayLai.IconRightZoom = 0D;
            this.btQuayLai.IconVisible = true;
            this.btQuayLai.IconZoom = 50D;
            this.btQuayLai.IsTab = false;
            this.btQuayLai.Location = new System.Drawing.Point(12, 664);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Normalcolor = System.Drawing.Color.White;
            this.btQuayLai.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btQuayLai.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btQuayLai.selected = false;
            this.btQuayLai.Size = new System.Drawing.Size(138, 48);
            this.btQuayLai.TabIndex = 6;
            this.btQuayLai.Text = "  QUAY LẠI";
            this.btQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuayLai.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btQuayLai.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Visible = false;
            this.btQuayLai.Click += new System.EventHandler(this.BtQuayLai_Click);
            // 
            // btTinhTien
            // 
            this.btTinhTien.Active = false;
            this.btTinhTien.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(85)))));
            this.btTinhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btTinhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(40)))));
            this.btTinhTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTinhTien.BorderRadius = 0;
            this.btTinhTien.ButtonText = "  Tính tiền";
            this.btTinhTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTinhTien.DisabledColor = System.Drawing.Color.Gray;
            this.btTinhTien.Iconcolor = System.Drawing.Color.Transparent;
            this.btTinhTien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btTinhTien.Iconimage")));
            this.btTinhTien.Iconimage_right = null;
            this.btTinhTien.Iconimage_right_Selected = null;
            this.btTinhTien.Iconimage_Selected = null;
            this.btTinhTien.IconMarginLeft = 0;
            this.btTinhTien.IconMarginRight = 0;
            this.btTinhTien.IconRightVisible = true;
            this.btTinhTien.IconRightZoom = 0D;
            this.btTinhTien.IconVisible = true;
            this.btTinhTien.IconZoom = 70D;
            this.btTinhTien.IsTab = false;
            this.btTinhTien.Location = new System.Drawing.Point(1155, 664);
            this.btTinhTien.Name = "btTinhTien";
            this.btTinhTien.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(119)))), ((int)(((byte)(40)))));
            this.btTinhTien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(85)))));
            this.btTinhTien.OnHoverTextColor = System.Drawing.Color.White;
            this.btTinhTien.selected = false;
            this.btTinhTien.Size = new System.Drawing.Size(124, 47);
            this.btTinhTien.TabIndex = 5;
            this.btTinhTien.Text = "  Tính tiền";
            this.btTinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTinhTien.Textcolor = System.Drawing.Color.White;
            this.btTinhTien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTinhTien.Visible = false;
            this.btTinhTien.Click += new System.EventHandler(this.BtTinhTien_Click);
            // 
            // lbGio
            // 
            this.lbGio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGio.AutoSize = true;
            this.lbGio.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGio.ForeColor = System.Drawing.Color.White;
            this.lbGio.Location = new System.Drawing.Point(714, 13);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(66, 30);
            this.lbGio.TabIndex = 15;
            this.lbGio.Text = "00:00";
            this.lbGio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNgay
            // 
            this.lbNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.White;
            this.lbNgay.Location = new System.Drawing.Point(597, 13);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(127, 30);
            this.lbNgay.TabIndex = 14;
            this.lbNgay.Text = "00/00/0000";
            this.lbNgay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // USCtinhTien
            // 
            this.USCtinhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USCtinhTien.Location = new System.Drawing.Point(0, 0);
            this.USCtinhTien.Name = "USCtinhTien";
            this.USCtinhTien.Size = new System.Drawing.Size(1302, 726);
            this.USCtinhTien.TabIndex = 4;
            this.USCtinhTien.Visible = false;
            // 
            // USCmenu
            // 
            this.USCmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.USCmenu.Location = new System.Drawing.Point(1043, 0);
            this.USCmenu.Name = "USCmenu";
            this.USCmenu.Size = new System.Drawing.Size(203, 194);
            this.USCmenu.TabIndex = 3;
            this.USCmenu.Visible = false;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(699, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(494, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thời gian:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)(this.btRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btOption)).EndInit();
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
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btOrderPlus;
        private Bunifu.Framework.UI.BunifuImageButton btOption;
        private NewOrder USCnewOrder;
        private Bunifu.Framework.UI.BunifuImageButton btMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btRestore;
        private Order USCorder;
        private SoDo USCsoDo;
        private Menu USCmenu;
        private TinhTien USCtinhTien;
        private Bunifu.Framework.UI.BunifuFlatButton btTinhTien;
        private Bunifu.Framework.UI.BunifuFlatButton btQuayLai;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}