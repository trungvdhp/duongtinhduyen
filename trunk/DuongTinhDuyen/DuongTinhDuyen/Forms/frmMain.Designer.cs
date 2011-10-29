namespace DuongTinhDuyen
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ketNoiCSDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huyKetNoiCSDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiNguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ketLuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hienThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhCongCuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhTinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dongTatCaTrangKhacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dongTatCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giupDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanSuDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinPhanMemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblTinhTrangKetNoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNguoiDangNhap = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDongHo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDongTab = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.chuyenGiaToolStripMenuItem,
            this.hienThiToolStripMenuItem,
            this.giupDoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ketNoiCSDLToolStripMenuItem,
            this.huyKetNoiCSDLToolStripMenuItem,
            this.toolStripSeparator11,
            this.dangNhapToolStripMenuItem,
            this.dangXuatToolStripMenuItem,
            this.doiMatKhauToolStripMenuItem,
            this.toolStripSeparator1,
            this.nguoiDungToolStripMenuItem,
            this.loaiNguoiDungToolStripMenuItem,
            this.toolStripSeparator9,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // ketNoiCSDLToolStripMenuItem
            // 
            this.ketNoiCSDLToolStripMenuItem.Name = "ketNoiCSDLToolStripMenuItem";
            this.ketNoiCSDLToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ketNoiCSDLToolStripMenuItem.Text = "Kết nối cơ sở dữ liệu";
            this.ketNoiCSDLToolStripMenuItem.Click += new System.EventHandler(this.ketNoiCSDLToolStripMenuItem_Click);
            // 
            // huyKetNoiCSDLToolStripMenuItem
            // 
            this.huyKetNoiCSDLToolStripMenuItem.Enabled = false;
            this.huyKetNoiCSDLToolStripMenuItem.Name = "huyKetNoiCSDLToolStripMenuItem";
            this.huyKetNoiCSDLToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.huyKetNoiCSDLToolStripMenuItem.Text = "Hủy kết nối cơ sở dữ liệu";
            this.huyKetNoiCSDLToolStripMenuItem.Click += new System.EventHandler(this.huyKetNoiCSDLToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(218, 6);
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.dangNhapToolStripMenuItem.Text = "Đăng nhập";
            this.dangNhapToolStripMenuItem.Click += new System.EventHandler(this.dangNhapToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Enabled = false;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Enabled = false;
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // nguoiDungToolStripMenuItem
            // 
            this.nguoiDungToolStripMenuItem.Name = "nguoiDungToolStripMenuItem";
            this.nguoiDungToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.nguoiDungToolStripMenuItem.Text = "Quản lý người dùng";
            this.nguoiDungToolStripMenuItem.Visible = false;
            this.nguoiDungToolStripMenuItem.Click += new System.EventHandler(this.nguoiDungToolStripMenuItem_Click);
            // 
            // loaiNguoiDungToolStripMenuItem
            // 
            this.loaiNguoiDungToolStripMenuItem.Name = "loaiNguoiDungToolStripMenuItem";
            this.loaiNguoiDungToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.loaiNguoiDungToolStripMenuItem.Text = "Loại người dùng";
            this.loaiNguoiDungToolStripMenuItem.Visible = false;
            this.loaiNguoiDungToolStripMenuItem.Click += new System.EventHandler(this.loaiNguoiDungToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(218, 6);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nutToolStripMenuItem,
            this.ketLuanToolStripMenuItem,
            this.luatToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            this.quanLyToolStripMenuItem.Visible = false;
            // 
            // nutToolStripMenuItem
            // 
            this.nutToolStripMenuItem.Name = "nutToolStripMenuItem";
            this.nutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.nutToolStripMenuItem.Text = "Nút";
            this.nutToolStripMenuItem.Click += new System.EventHandler(this.nutToolStripMenuItem_Click);
            // 
            // ketLuanToolStripMenuItem
            // 
            this.ketLuanToolStripMenuItem.Name = "ketLuanToolStripMenuItem";
            this.ketLuanToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ketLuanToolStripMenuItem.Text = "Kết luận";
            this.ketLuanToolStripMenuItem.Click += new System.EventHandler(this.ketLuanToolStripMenuItem_Click);
            // 
            // luatToolStripMenuItem
            // 
            this.luatToolStripMenuItem.Name = "luatToolStripMenuItem";
            this.luatToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.luatToolStripMenuItem.Text = "Luật";
            this.luatToolStripMenuItem.Click += new System.EventHandler(this.luatToolStripMenuItem_Click);
            // 
            // chuyenGiaToolStripMenuItem
            // 
            this.chuyenGiaToolStripMenuItem.Name = "chuyenGiaToolStripMenuItem";
            this.chuyenGiaToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.chuyenGiaToolStripMenuItem.Text = "Chuyên gia";
            this.chuyenGiaToolStripMenuItem.Visible = false;
            this.chuyenGiaToolStripMenuItem.Click += new System.EventHandler(this.chuyenGiaToolStripMenuItem_Click);
            // 
            // hienThiToolStripMenuItem
            // 
            this.hienThiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhCongCuToolStripMenuItem,
            this.thanhTinhTrangToolStripMenuItem,
            this.dongTatCaTrangKhacToolStripMenuItem,
            this.dongTatCaToolStripMenuItem});
            this.hienThiToolStripMenuItem.Name = "hienThiToolStripMenuItem";
            this.hienThiToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.hienThiToolStripMenuItem.Text = "Hiển thị";
            // 
            // thanhCongCuToolStripMenuItem
            // 
            this.thanhCongCuToolStripMenuItem.Checked = true;
            this.thanhCongCuToolStripMenuItem.CheckOnClick = true;
            this.thanhCongCuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thanhCongCuToolStripMenuItem.Name = "thanhCongCuToolStripMenuItem";
            this.thanhCongCuToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.thanhCongCuToolStripMenuItem.Text = "Thanh công cụ";
            this.thanhCongCuToolStripMenuItem.Click += new System.EventHandler(this.thanhCongCuToolStripMenuItem_Click);
            // 
            // thanhTinhTrangToolStripMenuItem
            // 
            this.thanhTinhTrangToolStripMenuItem.Checked = true;
            this.thanhTinhTrangToolStripMenuItem.CheckOnClick = true;
            this.thanhTinhTrangToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thanhTinhTrangToolStripMenuItem.Name = "thanhTinhTrangToolStripMenuItem";
            this.thanhTinhTrangToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.thanhTinhTrangToolStripMenuItem.Text = "Thanh tình trạng";
            this.thanhTinhTrangToolStripMenuItem.Click += new System.EventHandler(this.thanhTinhTrangToolStripMenuItem_Click);
            // 
            // dongTatCaTrangKhacToolStripMenuItem
            // 
            this.dongTatCaTrangKhacToolStripMenuItem.Name = "dongTatCaTrangKhacToolStripMenuItem";
            this.dongTatCaTrangKhacToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.dongTatCaTrangKhacToolStripMenuItem.Text = "Đóng tất cả trang khác";
            this.dongTatCaTrangKhacToolStripMenuItem.Visible = false;
            this.dongTatCaTrangKhacToolStripMenuItem.Click += new System.EventHandler(this.dongTatCaTrangKhacToolStripMenuItem_Click);
            // 
            // dongTatCaToolStripMenuItem
            // 
            this.dongTatCaToolStripMenuItem.Name = "dongTatCaToolStripMenuItem";
            this.dongTatCaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.dongTatCaToolStripMenuItem.Text = "Đóng tất cả";
            this.dongTatCaToolStripMenuItem.Visible = false;
            this.dongTatCaToolStripMenuItem.Click += new System.EventHandler(this.dongTatCaToolStripMenuItem_Click);
            // 
            // giupDoToolStripMenuItem
            // 
            this.giupDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huongDanSuDungToolStripMenuItem,
            this.thongTinPhanMemToolStripMenuItem});
            this.giupDoToolStripMenuItem.Name = "giupDoToolStripMenuItem";
            this.giupDoToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.giupDoToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // huongDanSuDungToolStripMenuItem
            // 
            this.huongDanSuDungToolStripMenuItem.Name = "huongDanSuDungToolStripMenuItem";
            this.huongDanSuDungToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.huongDanSuDungToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.huongDanSuDungToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.huongDanSuDungToolStripMenuItem.Click += new System.EventHandler(this.huongDanSuDungToolStripMenuItem_Click);
            // 
            // thongTinPhanMemToolStripMenuItem
            // 
            this.thongTinPhanMemToolStripMenuItem.Name = "thongTinPhanMemToolStripMenuItem";
            this.thongTinPhanMemToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.thongTinPhanMemToolStripMenuItem.Text = "Thông tin phần mềm";
            this.thongTinPhanMemToolStripMenuItem.Click += new System.EventHandler(this.thongTinPhanMemToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 438);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            // 
            // lblTinhTrangKetNoi
            // 
            this.lblTinhTrangKetNoi.BackColor = System.Drawing.Color.Transparent;
            this.lblTinhTrangKetNoi.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblTinhTrangKetNoi.Name = "lblTinhTrangKetNoi";
            this.lblTinhTrangKetNoi.Size = new System.Drawing.Size(243, 17);
            this.lblTinhTrangKetNoi.Spring = true;
            this.lblTinhTrangKetNoi.Text = "Chưa kết nối CSDL!";
            this.lblTinhTrangKetNoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTinhTrangKetNoi.ToolTipText = "Tình trạng kết nối";
            // 
            // lblNguoiDangNhap
            // 
            this.lblNguoiDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiDangNhap.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.lblNguoiDangNhap.Name = "lblNguoiDangNhap";
            this.lblNguoiDangNhap.Size = new System.Drawing.Size(233, 17);
            this.lblNguoiDangNhap.Spring = true;
            this.lblNguoiDangNhap.Text = "Chưa đăng nhập";
            this.lblNguoiDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNguoiDangNhap.ToolTipText = "Tên người đăng nhập";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTinhTrangKetNoi,
            this.lblNguoiDangNhap,
            this.lblDongHo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(744, 23);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDongHo
            // 
            this.lblDongHo.BackColor = System.Drawing.Color.Transparent;
            this.lblDongHo.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(233, 17);
            this.lblDongHo.Spring = true;
            this.lblDongHo.Text = "Đồng hồ";
            this.lblDongHo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDongHo.ToolTipText = "Thời gian hiện tại";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDongTab
            // 
            this.btnDongTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongTab.BackColor = System.Drawing.Color.Transparent;
            this.btnDongTab.FlatAppearance.BorderSize = 0;
            this.btnDongTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDongTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDongTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongTab.Image = global::DuongTinhDuyen.Properties.Resources.close;
            this.btnDongTab.Location = new System.Drawing.Point(720, 52);
            this.btnDongTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnDongTab.Name = "btnDongTab";
            this.btnDongTab.Padding = new System.Windows.Forms.Padding(3, 0, 5, 1);
            this.btnDongTab.Size = new System.Drawing.Size(20, 20);
            this.btnDongTab.TabIndex = 4;
            this.btnDongTab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDongTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDongTab.UseVisualStyleBackColor = false;
            this.btnDongTab.Visible = false;
            this.btnDongTab.Click += new System.EventHandler(this.btnDongTab_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.Controls.Add(this.btnDongTab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BÓI TÌNH DUYÊN QUA CHỈ TAY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giupDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hienThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhCongCuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinPhanMemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanSuDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhTinhTrangToolStripMenuItem;
        private System.Windows.Forms.Button btnDongTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripStatusLabel lblTinhTrangKetNoi;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoiDangNhap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDongHo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem dongTatCaTrangKhacToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem ketNoiCSDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem huyKetNoiCSDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dongTatCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loaiNguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ketLuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenGiaToolStripMenuItem;
    }
}

