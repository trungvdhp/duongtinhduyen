namespace DuongTinhDuyen
{
    partial class frmChuyenGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvGiaThiet = new System.Windows.Forms.DataGridView();
            this.dgvKetLuan = new System.Windows.Forms.DataGridView();
            this.colNoiDungKL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHauTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNut = new System.Windows.Forms.DataGridView();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colTienTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNoiDungGiaThiet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTienTo1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGiaThiet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaThiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetLuan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNut)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 419);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvGiaThiet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvKetLuan);
            this.splitContainer1.Size = new System.Drawing.Size(800, 181);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 70;
            // 
            // dgvGiaThiet
            // 
            this.dgvGiaThiet.AllowUserToAddRows = false;
            this.dgvGiaThiet.AllowUserToResizeColumns = false;
            this.dgvGiaThiet.AllowUserToResizeRows = false;
            this.dgvGiaThiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaThiet.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaThiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaThiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaThiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTienTo,
            this.colNoiDungGiaThiet});
            this.dgvGiaThiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaThiet.Location = new System.Drawing.Point(0, 0);
            this.dgvGiaThiet.Name = "dgvGiaThiet";
            this.dgvGiaThiet.ReadOnly = true;
            this.dgvGiaThiet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGiaThiet.Size = new System.Drawing.Size(400, 181);
            this.dgvGiaThiet.TabIndex = 72;
            this.dgvGiaThiet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaThiet_CellValueChanged);
            this.dgvGiaThiet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvGiaThiet_DataError);
            // 
            // dgvKetLuan
            // 
            this.dgvKetLuan.AllowUserToAddRows = false;
            this.dgvKetLuan.AllowUserToResizeColumns = false;
            this.dgvKetLuan.AllowUserToResizeRows = false;
            this.dgvKetLuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetLuan.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetLuan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKetLuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetLuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNoiDungKL,
            this.colHauTo});
            this.dgvKetLuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetLuan.Location = new System.Drawing.Point(0, 0);
            this.dgvKetLuan.Name = "dgvKetLuan";
            this.dgvKetLuan.ReadOnly = true;
            this.dgvKetLuan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKetLuan.Size = new System.Drawing.Size(399, 181);
            this.dgvKetLuan.TabIndex = 74;
            this.dgvKetLuan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetLuan_CellValueChanged);
            this.dgvKetLuan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // colNoiDungKL
            // 
            this.colNoiDungKL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNoiDungKL.DataPropertyName = "NoiDung";
            this.colNoiDungKL.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colNoiDungKL.FillWeight = 298.4772F;
            this.colNoiDungKL.HeaderText = "Kết luận";
            this.colNoiDungKL.MaxDropDownItems = 50;
            this.colNoiDungKL.Name = "colNoiDungKL";
            this.colNoiDungKL.ReadOnly = true;
            // 
            // colHauTo
            // 
            this.colHauTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHauTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colHauTo.HeaderText = "Hậu tố";
            this.colHauTo.Items.AddRange(new object[] {
            "và",
            "hoặc"});
            this.colHauTo.Name = "colHauTo";
            this.colHauTo.ReadOnly = true;
            this.colHauTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHauTo.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNut);
            this.panel1.Controls.Add(this.btnLamLai);
            this.panel1.Controls.Add(this.btnKetThuc);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnTiepTuc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 419);
            this.panel1.TabIndex = 71;
            // 
            // dgvNut
            // 
            this.dgvNut.AllowUserToAddRows = false;
            this.dgvNut.AllowUserToResizeColumns = false;
            this.dgvNut.AllowUserToResizeRows = false;
            this.dgvNut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNut.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTienTo1,
            this.colGiaThiet});
            this.dgvNut.Location = new System.Drawing.Point(0, 57);
            this.dgvNut.Name = "dgvNut";
            this.dgvNut.ReadOnly = true;
            this.dgvNut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNut.Size = new System.Drawing.Size(800, 315);
            this.dgvNut.TabIndex = 73;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLamLai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLamLai.Location = new System.Drawing.Point(244, 378);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 9;
            this.btnLamLai.Text = "|<< &Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKetThuc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKetThuc.Location = new System.Drawing.Point(487, 378);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetThuc.TabIndex = 9;
            this.btnKetThuc.Text = "&Kết thúc >>|";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuayLai.Location = new System.Drawing.Point(325, 378);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "|< &Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTiepTuc.Location = new System.Drawing.Point(406, 378);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(75, 23);
            this.btnTiepTuc.TabIndex = 9;
            this.btnTiepTuc.Text = "&Tiếp tục >|";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "BÓI TÌNH DUYÊN QUA CHỈ TAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colTienTo
            // 
            this.colTienTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTienTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colTienTo.HeaderText = "Tiền tố";
            this.colTienTo.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.colTienTo.Name = "colTienTo";
            this.colTienTo.ReadOnly = true;
            this.colTienTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTienTo.Width = 80;
            // 
            // colNoiDungGiaThiet
            // 
            this.colNoiDungGiaThiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNoiDungGiaThiet.DataPropertyName = "NoiDung";
            this.colNoiDungGiaThiet.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colNoiDungGiaThiet.FillWeight = 298.4772F;
            this.colNoiDungGiaThiet.HeaderText = "Giả thiết";
            this.colNoiDungGiaThiet.MaxDropDownItems = 50;
            this.colNoiDungGiaThiet.Name = "colNoiDungGiaThiet";
            this.colNoiDungGiaThiet.ReadOnly = true;
            // 
            // colTienTo1
            // 
            this.colTienTo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTienTo1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colTienTo1.HeaderText = "Tiền tố";
            this.colTienTo1.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.colTienTo1.Name = "colTienTo1";
            this.colTienTo1.ReadOnly = true;
            this.colTienTo1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTienTo1.Width = 80;
            // 
            // colGiaThiet
            // 
            this.colGiaThiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiaThiet.DataPropertyName = "NoiDung";
            this.colGiaThiet.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colGiaThiet.FillWeight = 298.4772F;
            this.colGiaThiet.HeaderText = "Giả thiết";
            this.colGiaThiet.MaxDropDownItems = 50;
            this.colGiaThiet.Name = "colGiaThiet";
            this.colGiaThiet.ReadOnly = true;
            // 
            // frmChuyenGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChuyenGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHUYÊN GIA";
            this.Load += new System.EventHandler(this.frmChuyenGia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaThiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetLuan)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvGiaThiet;
        private System.Windows.Forms.DataGridView dgvKetLuan;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNoiDungKL;
        private System.Windows.Forms.DataGridViewComboBoxColumn colHauTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.DataGridView dgvNut;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTienTo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNoiDungGiaThiet;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTienTo1;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGiaThiet;
    }
}