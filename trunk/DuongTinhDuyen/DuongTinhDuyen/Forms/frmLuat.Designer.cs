namespace DuongTinhDuyen
{
    partial class frmLuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvLuat = new System.Windows.Forms.DataGridView();
            this.colMaLuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaThiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorLuat = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvGiaThiet = new System.Windows.Forms.DataGridView();
            this.colTienTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNoiDungGiaThiet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigatorGiaThiet = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItemNut = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItemGiaThiet = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButtonGiaThiet = new System.Windows.Forms.ToolStripButton();
            this.dgvKetLuan = new System.Windows.Forms.DataGridView();
            this.colNoiDungKL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHauTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigatorKetLuan = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItemKetLuan = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItemKetLuan = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButtonKetLuan = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLuat)).BeginInit();
            this.bindingNavigatorLuat.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaThiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGiaThiet)).BeginInit();
            this.bindingNavigatorGiaThiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetLuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetLuan)).BeginInit();
            this.bindingNavigatorKetLuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvLuat);
            this.splitContainer2.Panel1.Controls.Add(this.bindingNavigatorLuat);
            this.splitContainer2.Panel1MinSize = 250;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2MinSize = 100;
            this.splitContainer2.Size = new System.Drawing.Size(933, 738);
            this.splitContainer2.SplitterDistance = 550;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvLuat
            // 
            this.dgvLuat.AllowUserToAddRows = false;
            this.dgvLuat.AllowUserToResizeColumns = false;
            this.dgvLuat.AllowUserToResizeRows = false;
            this.dgvLuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuat.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLuat,
            this.colGiaThiet,
            this.colKetLuan});
            this.dgvLuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuat.Location = new System.Drawing.Point(0, 30);
            this.dgvLuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLuat.Name = "dgvLuat";
            this.dgvLuat.ReadOnly = true;
            this.dgvLuat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuat.Size = new System.Drawing.Size(931, 518);
            this.dgvLuat.TabIndex = 70;
            this.dgvLuat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvLuat_DataError);
            this.dgvLuat.SelectionChanged += new System.EventHandler(this.dgvLuat_SelectionChanged);
            // 
            // colMaLuat
            // 
            this.colMaLuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaLuat.DataPropertyName = "MaLuat";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaLuat.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMaLuat.FillWeight = 70F;
            this.colMaLuat.HeaderText = "Mã luật";
            this.colMaLuat.MaxInputLength = 6;
            this.colMaLuat.Name = "colMaLuat";
            this.colMaLuat.ReadOnly = true;
            this.colMaLuat.Width = 70;
            // 
            // colGiaThiet
            // 
            this.colGiaThiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGiaThiet.DataPropertyName = "GiaThiet";
            this.colGiaThiet.FillWeight = 200F;
            this.colGiaThiet.HeaderText = "Giả thiết";
            this.colGiaThiet.MaxInputLength = 100;
            this.colGiaThiet.Name = "colGiaThiet";
            this.colGiaThiet.ReadOnly = true;
            this.colGiaThiet.Width = 200;
            // 
            // colKetLuan
            // 
            this.colKetLuan.DataPropertyName = "KetLuan";
            this.colKetLuan.HeaderText = "Kết luận";
            this.colKetLuan.MaxInputLength = 100;
            this.colKetLuan.Name = "colKetLuan";
            this.colKetLuan.ReadOnly = true;
            // 
            // bindingNavigatorLuat
            // 
            this.bindingNavigatorLuat.AddNewItem = null;
            this.bindingNavigatorLuat.AutoSize = false;
            this.bindingNavigatorLuat.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorLuat.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorLuat.CountItemFormat = "của {0}";
            this.bindingNavigatorLuat.DeleteItem = null;
            this.bindingNavigatorLuat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.bindingNavigatorRefreshItem,
            this.saveToolStripButton});
            this.bindingNavigatorLuat.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorLuat.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorLuat.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorLuat.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorLuat.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorLuat.Name = "bindingNavigatorLuat";
            this.bindingNavigatorLuat.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorLuat.Size = new System.Drawing.Size(931, 30);
            this.bindingNavigatorLuat.TabIndex = 71;
            this.bindingNavigatorLuat.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(51, 27);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorAddNewItem.Text = "&Thêm";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItemLuat_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItemLuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = global::DuongTinhDuyen.Properties.Resources.re;
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorRefreshItem.Text = "Làm tươi";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItemLuat_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 27);
            this.saveToolStripButton.Text = "&Lưu";
            this.saveToolStripButton.Click += new System.EventHandler(this.bindingNavigatorSaveItemLuat_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvGiaThiet);
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigatorGiaThiet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvKetLuan);
            this.splitContainer1.Panel2.Controls.Add(this.bindingNavigatorKetLuan);
            this.splitContainer1.Size = new System.Drawing.Size(931, 185);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 71;
            // 
            // dgvGiaThiet
            // 
            this.dgvGiaThiet.AllowUserToAddRows = false;
            this.dgvGiaThiet.AllowUserToResizeColumns = false;
            this.dgvGiaThiet.AllowUserToResizeRows = false;
            this.dgvGiaThiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaThiet.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaThiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiaThiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaThiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTienTo,
            this.colNoiDungGiaThiet});
            this.dgvGiaThiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaThiet.Location = new System.Drawing.Point(0, 30);
            this.dgvGiaThiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGiaThiet.Name = "dgvGiaThiet";
            this.dgvGiaThiet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGiaThiet.Size = new System.Drawing.Size(462, 155);
            this.dgvGiaThiet.TabIndex = 74;
            this.dgvGiaThiet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvGiaThiet_DataError);
            // 
            // colTienTo
            // 
            this.colTienTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTienTo.DataPropertyName = "KetLuan";
            this.colTienTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colTienTo.HeaderText = "Tiền tố";
            this.colTienTo.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.colTienTo.Name = "colTienTo";
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
            // 
            // bindingNavigatorGiaThiet
            // 
            this.bindingNavigatorGiaThiet.AddNewItem = null;
            this.bindingNavigatorGiaThiet.AutoSize = false;
            this.bindingNavigatorGiaThiet.BackColor = System.Drawing.Color.Lavender;
            this.bindingNavigatorGiaThiet.CountItem = null;
            this.bindingNavigatorGiaThiet.CountItemFormat = "của {0}";
            this.bindingNavigatorGiaThiet.DeleteItem = null;
            this.bindingNavigatorGiaThiet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItemNut,
            this.bindingNavigatorDeleteItemGiaThiet,
            this.saveToolStripButtonGiaThiet});
            this.bindingNavigatorGiaThiet.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorGiaThiet.MoveFirstItem = null;
            this.bindingNavigatorGiaThiet.MoveLastItem = null;
            this.bindingNavigatorGiaThiet.MoveNextItem = null;
            this.bindingNavigatorGiaThiet.MovePreviousItem = null;
            this.bindingNavigatorGiaThiet.Name = "bindingNavigatorGiaThiet";
            this.bindingNavigatorGiaThiet.PositionItem = null;
            this.bindingNavigatorGiaThiet.Size = new System.Drawing.Size(462, 30);
            this.bindingNavigatorGiaThiet.TabIndex = 73;
            this.bindingNavigatorGiaThiet.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItemNut
            // 
            this.bindingNavigatorAddNewItemNut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItemNut.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItemNut.Image")));
            this.bindingNavigatorAddNewItemNut.Name = "bindingNavigatorAddNewItemNut";
            this.bindingNavigatorAddNewItemNut.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItemNut.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorAddNewItemNut.Text = "Thêm";
            this.bindingNavigatorAddNewItemNut.Click += new System.EventHandler(this.bindingNavigatorAddNewItemGiaThiet_Click);
            // 
            // bindingNavigatorDeleteItemGiaThiet
            // 
            this.bindingNavigatorDeleteItemGiaThiet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItemGiaThiet.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItemGiaThiet.Image")));
            this.bindingNavigatorDeleteItemGiaThiet.Name = "bindingNavigatorDeleteItemGiaThiet";
            this.bindingNavigatorDeleteItemGiaThiet.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItemGiaThiet.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorDeleteItemGiaThiet.Text = "Xóa";
            this.bindingNavigatorDeleteItemGiaThiet.Click += new System.EventHandler(this.bindingNavigatorDeleteItemGiaThiet_Click);
            // 
            // saveToolStripButtonGiaThiet
            // 
            this.saveToolStripButtonGiaThiet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButtonGiaThiet.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButtonGiaThiet.Image")));
            this.saveToolStripButtonGiaThiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButtonGiaThiet.Name = "saveToolStripButtonGiaThiet";
            this.saveToolStripButtonGiaThiet.Size = new System.Drawing.Size(23, 27);
            this.saveToolStripButtonGiaThiet.Text = "&Lưu";
            this.saveToolStripButtonGiaThiet.Click += new System.EventHandler(this.saveToolStripButtonGiaThiet_Click);
            // 
            // dgvKetLuan
            // 
            this.dgvKetLuan.AllowUserToAddRows = false;
            this.dgvKetLuan.AllowUserToResizeColumns = false;
            this.dgvKetLuan.AllowUserToResizeRows = false;
            this.dgvKetLuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetLuan.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetLuan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKetLuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetLuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNoiDungKL,
            this.colHauTo});
            this.dgvKetLuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetLuan.Location = new System.Drawing.Point(0, 30);
            this.dgvKetLuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKetLuan.Name = "dgvKetLuan";
            this.dgvKetLuan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKetLuan.Size = new System.Drawing.Size(468, 155);
            this.dgvKetLuan.TabIndex = 74;
            this.dgvKetLuan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvKetLuan_DataError);
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
            this.colHauTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHauTo.Width = 80;
            // 
            // bindingNavigatorKetLuan
            // 
            this.bindingNavigatorKetLuan.AddNewItem = null;
            this.bindingNavigatorKetLuan.AutoSize = false;
            this.bindingNavigatorKetLuan.BackColor = System.Drawing.Color.Lavender;
            this.bindingNavigatorKetLuan.CountItem = null;
            this.bindingNavigatorKetLuan.CountItemFormat = "của {0}";
            this.bindingNavigatorKetLuan.DeleteItem = null;
            this.bindingNavigatorKetLuan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItemKetLuan,
            this.bindingNavigatorDeleteItemKetLuan,
            this.saveToolStripButtonKetLuan});
            this.bindingNavigatorKetLuan.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorKetLuan.MoveFirstItem = null;
            this.bindingNavigatorKetLuan.MoveLastItem = null;
            this.bindingNavigatorKetLuan.MoveNextItem = null;
            this.bindingNavigatorKetLuan.MovePreviousItem = null;
            this.bindingNavigatorKetLuan.Name = "bindingNavigatorKetLuan";
            this.bindingNavigatorKetLuan.PositionItem = null;
            this.bindingNavigatorKetLuan.Size = new System.Drawing.Size(468, 30);
            this.bindingNavigatorKetLuan.TabIndex = 75;
            this.bindingNavigatorKetLuan.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItemKetLuan
            // 
            this.bindingNavigatorAddNewItemKetLuan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItemKetLuan.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItemKetLuan.Image")));
            this.bindingNavigatorAddNewItemKetLuan.Name = "bindingNavigatorAddNewItemKetLuan";
            this.bindingNavigatorAddNewItemKetLuan.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItemKetLuan.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorAddNewItemKetLuan.Text = "&Thêm";
            this.bindingNavigatorAddNewItemKetLuan.Click += new System.EventHandler(this.bindingNavigatorAddNewItemKetLuan_Click);
            // 
            // bindingNavigatorDeleteItemKetLuan
            // 
            this.bindingNavigatorDeleteItemKetLuan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItemKetLuan.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItemKetLuan.Image")));
            this.bindingNavigatorDeleteItemKetLuan.Name = "bindingNavigatorDeleteItemKetLuan";
            this.bindingNavigatorDeleteItemKetLuan.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItemKetLuan.Size = new System.Drawing.Size(23, 27);
            this.bindingNavigatorDeleteItemKetLuan.Text = "Xóa";
            this.bindingNavigatorDeleteItemKetLuan.Click += new System.EventHandler(this.bindingNavigatorDeleteItemKetLuan_Click);
            // 
            // saveToolStripButtonKetLuan
            // 
            this.saveToolStripButtonKetLuan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButtonKetLuan.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButtonKetLuan.Image")));
            this.saveToolStripButtonKetLuan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButtonKetLuan.Name = "saveToolStripButtonKetLuan";
            this.saveToolStripButtonKetLuan.Size = new System.Drawing.Size(23, 27);
            this.saveToolStripButtonKetLuan.Text = "&Lưu";
            this.saveToolStripButtonKetLuan.Click += new System.EventHandler(this.saveToolStripButtonKetLuan_Click);
            // 
            // frmLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(933, 738);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BIÊN TẬP LUẬT";
            this.Load += new System.EventHandler(this.frmLuat_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLuat)).EndInit();
            this.bindingNavigatorLuat.ResumeLayout(false);
            this.bindingNavigatorLuat.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaThiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGiaThiet)).EndInit();
            this.bindingNavigatorGiaThiet.ResumeLayout(false);
            this.bindingNavigatorGiaThiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetLuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetLuan)).EndInit();
            this.bindingNavigatorKetLuan.ResumeLayout(false);
            this.bindingNavigatorKetLuan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorGiaThiet;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItemNut;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItemGiaThiet;
        private System.Windows.Forms.ToolStripButton saveToolStripButtonGiaThiet;
        private System.Windows.Forms.DataGridView dgvKetLuan;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNoiDungKL;
        private System.Windows.Forms.DataGridViewComboBoxColumn colHauTo;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKetLuan;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItemKetLuan;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItemKetLuan;
        private System.Windows.Forms.ToolStripButton saveToolStripButtonKetLuan;
        private System.Windows.Forms.DataGridView dgvLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaThiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetLuan;
        private System.Windows.Forms.BindingNavigator bindingNavigatorLuat;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.DataGridView dgvGiaThiet;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTienTo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNoiDungGiaThiet;

    }
}