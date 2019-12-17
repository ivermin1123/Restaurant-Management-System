namespace QuanLyQuanBeer
{
    partial class USCBaoCaoTK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USCBaoCaoTK));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lsvBC = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btLayDuLieu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpkToDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkFromDay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1018, 631);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lsvBC);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1018, 579);
            this.panel6.TabIndex = 4;
            // 
            // lsvBC
            // 
            this.lsvBC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBC.FullRowSelect = true;
            this.lsvBC.GridLines = true;
            this.lsvBC.HideSelection = false;
            this.lsvBC.Location = new System.Drawing.Point(0, 0);
            this.lsvBC.Name = "lsvBC";
            this.lsvBC.Size = new System.Drawing.Size(1018, 579);
            this.lsvBC.TabIndex = 12;
            this.lsvBC.UseCompatibleStateImageBehavior = false;
            this.lsvBC.View = System.Windows.Forms.View.Details;
            this.lsvBC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvBC_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã HD";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bàn";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng cộng";
            this.columnHeader3.Width = 269;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nhân viên thanh toán";
            this.columnHeader4.Width = 408;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpkToDay);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dtpkFromDay);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btLayDuLieu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1018, 52);
            this.panel5.TabIndex = 3;
            // 
            // btLayDuLieu
            // 
            this.btLayDuLieu.Active = false;
            this.btLayDuLieu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btLayDuLieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLayDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btLayDuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLayDuLieu.BorderRadius = 0;
            this.btLayDuLieu.ButtonText = "   Lấy dữ liệu";
            this.btLayDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLayDuLieu.DisabledColor = System.Drawing.Color.Gray;
            this.btLayDuLieu.Iconcolor = System.Drawing.Color.Transparent;
            this.btLayDuLieu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btLayDuLieu.Iconimage")));
            this.btLayDuLieu.Iconimage_right = null;
            this.btLayDuLieu.Iconimage_right_Selected = null;
            this.btLayDuLieu.Iconimage_Selected = null;
            this.btLayDuLieu.IconMarginLeft = 0;
            this.btLayDuLieu.IconMarginRight = 0;
            this.btLayDuLieu.IconRightVisible = true;
            this.btLayDuLieu.IconRightZoom = 0D;
            this.btLayDuLieu.IconVisible = true;
            this.btLayDuLieu.IconZoom = 55D;
            this.btLayDuLieu.IsTab = false;
            this.btLayDuLieu.Location = new System.Drawing.Point(480, 6);
            this.btLayDuLieu.Name = "btLayDuLieu";
            this.btLayDuLieu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btLayDuLieu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.btLayDuLieu.OnHoverTextColor = System.Drawing.Color.White;
            this.btLayDuLieu.selected = false;
            this.btLayDuLieu.Size = new System.Drawing.Size(136, 35);
            this.btLayDuLieu.TabIndex = 25;
            this.btLayDuLieu.Text = "   Lấy dữ liệu";
            this.btLayDuLieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLayDuLieu.Textcolor = System.Drawing.Color.White;
            this.btLayDuLieu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLayDuLieu.Click += new System.EventHandler(this.btLayDuLieu_Click);
            // 
            // dtpkToDay
            // 
            this.dtpkToDay.CustomFormat = "dd/MM/yyyy";
            this.dtpkToDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkToDay.Location = new System.Drawing.Point(315, 12);
            this.dtpkToDay.Name = "dtpkToDay";
            this.dtpkToDay.Size = new System.Drawing.Size(123, 29);
            this.dtpkToDay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến ngày:";
            // 
            // dtpkFromDay
            // 
            this.dtpkFromDay.CustomFormat = "dd/MM/yyyy";
            this.dtpkFromDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFromDay.Location = new System.Drawing.Point(81, 12);
            this.dtpkFromDay.Name = "dtpkFromDay";
            this.dtpkFromDay.Size = new System.Drawing.Size(123, 29);
            this.dtpkFromDay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 631);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(367, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO - THỐNG KÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 50);
            this.panel1.TabIndex = 11;
            // 
            // USCBaoCaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "USCBaoCaoTK";
            this.Size = new System.Drawing.Size(1018, 681);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkToDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkFromDay;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btLayDuLieu;
        private System.Windows.Forms.ListView lsvBC;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
