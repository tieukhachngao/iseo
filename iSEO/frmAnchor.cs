namespace iSEO
{
    using iSEO.Properties;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmAnchor : Form
    {
        private IContainer icontainer_0;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;
        private GroupBox groupBox30;
        private PictureBox btnAnchorGroupSearch;
        private PictureBox btnAnchorGroupAdd;
        private DataGridView dtvAnchorGroup;
        private TextBox txtAnchorGroup;
        private GroupBox groupBox24;
        private DataGridView dtvAnchorKey;
        private TextBox txtAnchorKey;
        private Label label67;
        private Label label1;
        private TextBox txtAnchorLink;
        private PictureBox btnAnchorDelete;
        private PictureBox btnAnchorEdit;
        private PictureBox btnAnchorAdd;
        private DataGridViewTextBoxColumn AnchorID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewLinkColumn Column18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private GClass4 gclass4_0 = new GClass4();
        private bool bool_0;
        private bool bool_1;

        public frmAnchor()
        {
            this.InitializeComponent();
            this.method_0();
        }

        private void btnAnchorAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtAnchorKey.Text.Trim()) || (string.IsNullOrEmpty(this.txtAnchorLink.Text.Trim()) || (this.dtvAnchorGroup.CurrentRow == null)))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Anchor ([AnchorID], [CategoryID], [Key], [ListUrl], [LengthKey]) VALUES('", Guid.NewGuid(), "','", this.dtvAnchorGroup.CurrentRow.Cells[0].Value.ToString(), "','", this.txtAnchorKey.Text.Trim(), "','", this.txtAnchorLink.Text.Trim(), "', " };
                    objArray[9] = this.txtAnchorKey.Text.Trim().Length;
                    objArray[10] = ")";
                    string str = string.Concat(objArray);
                    this.gclass4_0.method_42(str);
                    this.method_2();
                    this.txtAnchorKey.Text = string.Empty;
                    this.txtAnchorLink.Text = string.Empty;
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAnchorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Anchor WHERE AnchorID='" + this.dtvAnchorKey.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_2();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAnchorEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.bool_1)
                {
                    if (string.IsNullOrEmpty(this.txtAnchorKey.Text.Trim()) || (string.IsNullOrEmpty(this.txtAnchorLink.Text.Trim()) || (this.dtvAnchorGroup.CurrentRow == null)))
                    {
                        MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        object[] objArray = new object[] { "UPDATE Anchor SET [Key]='", this.txtAnchorKey.Text.Trim(), "' , [ListUrl]='", this.txtAnchorLink.Text.Trim(), "', [LengthKey]=", this.txtAnchorKey.Text.Trim().Length, " WHERE [AnchorID]='", this.dtvAnchorKey.CurrentRow.Cells[0].Value.ToString(), "'" };
                        string str = string.Concat(objArray);
                        this.gclass4_0.method_42(str);
                        this.method_2();
                        this.txtAnchorKey.Text = string.Empty;
                        this.txtAnchorLink.Text = string.Empty;
                        this.bool_1 = false;
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAnchorGroupAdd_Click(object sender, EventArgs e)
        {
            new frmCategory { string_0 = "ANCHOR" }.ShowDialog();
            this.method_1();
        }

        private void btnAnchorGroupSearch_Click(object sender, EventArgs e)
        {
            this.bool_0 = true;
            this.method_1();
            this.bool_0 = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dtvAnchorGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.method_2();
        }

        private void dtvAnchorGroup_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnchorGroup.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAnchorKey_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtAnchorKey.Text = this.dtvAnchorKey.CurrentRow.Cells[1].Value.ToString();
            this.txtAnchorLink.Text = this.dtvAnchorKey.CurrentRow.Cells[2].Value.ToString();
            this.bool_1 = true;
        }

        private void dtvAnchorKey_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAnchorKey.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            DataGridViewCellStyle style8 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmAnchor));
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.groupBox30 = new GroupBox();
            this.btnAnchorGroupSearch = new PictureBox();
            this.btnAnchorGroupAdd = new PictureBox();
            this.dtvAnchorGroup = new DataGridView();
            this.dataGridViewTextBoxColumn45 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new DataGridViewTextBoxColumn();
            this.txtAnchorGroup = new TextBox();
            this.groupBox24 = new GroupBox();
            this.btnAnchorDelete = new PictureBox();
            this.label1 = new Label();
            this.txtAnchorLink = new TextBox();
            this.btnAnchorEdit = new PictureBox();
            this.btnAnchorAdd = new PictureBox();
            this.label67 = new Label();
            this.txtAnchorKey = new TextBox();
            this.dtvAnchorKey = new DataGridView();
            this.AnchorID = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new DataGridViewTextBoxColumn();
            this.Column18 = new DataGridViewLinkColumn();
            this.toolBar.SuspendLayout();
            this.groupBox30.SuspendLayout();
            ((ISupportInitialize) this.btnAnchorGroupSearch).BeginInit();
            ((ISupportInitialize) this.btnAnchorGroupAdd).BeginInit();
            ((ISupportInitialize) this.dtvAnchorGroup).BeginInit();
            this.groupBox24.SuspendLayout();
            ((ISupportInitialize) this.btnAnchorDelete).BeginInit();
            ((ISupportInitialize) this.btnAnchorEdit).BeginInit();
            ((ISupportInitialize) this.btnAnchorAdd).BeginInit();
            ((ISupportInitialize) this.dtvAnchorKey).BeginInit();
            base.SuspendLayout();
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(990, 0x19);
            this.toolBar.TabIndex = 0x12;
            this.toolBar.Text = "toolBar";
            this.btnExit.Alignment = ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = Resources.smethod_4();
            this.btnExit.ImageTransparentColor = Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x17, 0x16);
            this.btnExit.Text = "toolStripButton1";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.toolStripLabel3.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.toolStripLabel3.ForeColor = Color.White;
            this.toolStripLabel3.Image = Resources.smethod_21();
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new Size(0x7a, 0x16);
            this.toolStripLabel3.Text = "Quản l\x00fd từ kho\x00e1";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            this.groupBox30.Controls.Add(this.btnAnchorGroupSearch);
            this.groupBox30.Controls.Add(this.btnAnchorGroupAdd);
            this.groupBox30.Controls.Add(this.dtvAnchorGroup);
            this.groupBox30.Controls.Add(this.txtAnchorGroup);
            this.groupBox30.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox30.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox30.Location = new Point(8, 0x1f);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new Size(0xfc, 0x1dc);
            this.groupBox30.TabIndex = 0x1d;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Nh\x00f3m từ kho\x00e1";
            this.btnAnchorGroupSearch.BackColor = SystemColors.Control;
            this.btnAnchorGroupSearch.Cursor = Cursors.Hand;
            this.btnAnchorGroupSearch.Image = Resources.smethod_18();
            this.btnAnchorGroupSearch.Location = new Point(0xc4, 20);
            this.btnAnchorGroupSearch.Name = "btnAnchorGroupSearch";
            this.btnAnchorGroupSearch.Size = new Size(0x16, 0x16);
            this.btnAnchorGroupSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAnchorGroupSearch.TabIndex = 0x23;
            this.btnAnchorGroupSearch.TabStop = false;
            this.btnAnchorGroupSearch.Click += new EventHandler(this.btnAnchorGroupSearch_Click);
            this.btnAnchorGroupAdd.BackColor = SystemColors.Control;
            this.btnAnchorGroupAdd.Cursor = Cursors.Hand;
            this.btnAnchorGroupAdd.Image = Resources.smethod_14();
            this.btnAnchorGroupAdd.Location = new Point(0xe0, 20);
            this.btnAnchorGroupAdd.Name = "btnAnchorGroupAdd";
            this.btnAnchorGroupAdd.Size = new Size(0x16, 0x16);
            this.btnAnchorGroupAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAnchorGroupAdd.TabIndex = 20;
            this.btnAnchorGroupAdd.TabStop = false;
            this.btnAnchorGroupAdd.Click += new EventHandler(this.btnAnchorGroupAdd_Click);
            this.dtvAnchorGroup.AllowUserToAddRows = false;
            this.dtvAnchorGroup.AllowUserToDeleteRows = false;
            this.dtvAnchorGroup.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnchorGroup.AlternatingRowsDefaultCellStyle = style;
            this.dtvAnchorGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnchorGroup.BackgroundColor = Color.White;
            this.dtvAnchorGroup.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dtvAnchorGroup.ColumnHeadersDefaultCellStyle = style2;
            this.dtvAnchorGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn45, this.dataGridViewTextBoxColumn46 };
            this.dtvAnchorGroup.Columns.AddRange(dataGridViewColumns);
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.FromArgb(0, 0, 0x40);
            style3.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style3.SelectionForeColor = Color.White;
            style3.WrapMode = DataGridViewTriState.False;
            this.dtvAnchorGroup.DefaultCellStyle = style3;
            this.dtvAnchorGroup.Location = new Point(6, 0x30);
            this.dtvAnchorGroup.MultiSelect = false;
            this.dtvAnchorGroup.Name = "dtvAnchorGroup";
            this.dtvAnchorGroup.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.HighlightText;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dtvAnchorGroup.RowHeadersDefaultCellStyle = style4;
            this.dtvAnchorGroup.RowHeadersWidth = 30;
            this.dtvAnchorGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnchorGroup.Size = new Size(240, 0x1a1);
            this.dtvAnchorGroup.TabIndex = 2;
            this.dtvAnchorGroup.CellClick += new DataGridViewCellEventHandler(this.dtvAnchorGroup_CellClick);
            this.dtvAnchorGroup.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAnchorGroup_RowPostPaint);
            this.dataGridViewTextBoxColumn45.HeaderText = "ID";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Visible = false;
            this.dataGridViewTextBoxColumn46.HeaderText = "Nh\x00f3m từ kho\x00e1";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.txtAnchorGroup.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAnchorGroup.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAnchorGroup.Location = new Point(6, 20);
            this.txtAnchorGroup.Name = "txtAnchorGroup";
            this.txtAnchorGroup.Size = new Size(0xb8, 0x17);
            this.txtAnchorGroup.TabIndex = 1;
            this.groupBox24.Controls.Add(this.btnAnchorDelete);
            this.groupBox24.Controls.Add(this.label1);
            this.groupBox24.Controls.Add(this.txtAnchorLink);
            this.groupBox24.Controls.Add(this.btnAnchorEdit);
            this.groupBox24.Controls.Add(this.btnAnchorAdd);
            this.groupBox24.Controls.Add(this.label67);
            this.groupBox24.Controls.Add(this.txtAnchorKey);
            this.groupBox24.Controls.Add(this.dtvAnchorKey);
            this.groupBox24.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox24.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox24.Location = new Point(0x10a, 0x1f);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new Size(0x2ca, 0x1dc);
            this.groupBox24.TabIndex = 30;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Quản l\x00fd từ kh\x00f3a";
            this.btnAnchorDelete.BackColor = SystemColors.Control;
            this.btnAnchorDelete.Cursor = Cursors.Hand;
            this.btnAnchorDelete.Image = Resources.smethod_12();
            this.btnAnchorDelete.Location = new Point(0x2a7, 0x11);
            this.btnAnchorDelete.Name = "btnAnchorDelete";
            this.btnAnchorDelete.Size = new Size(0x16, 0x16);
            this.btnAnchorDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnAnchorDelete.TabIndex = 0x2a;
            this.btnAnchorDelete.TabStop = false;
            this.btnAnchorDelete.Click += new EventHandler(this.btnAnchorDelete_Click);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label1.Location = new Point(0xfd, 0x16);
            this.label1.Name = "label1";
            this.label1.Size = new Size(30, 0x10);
            this.label1.TabIndex = 0x27;
            this.label1.Text = "Link";
            this.txtAnchorLink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAnchorLink.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAnchorLink.Location = new Point(0x121, 0x13);
            this.txtAnchorLink.Name = "txtAnchorLink";
            this.txtAnchorLink.Size = new Size(0x148, 0x17);
            this.txtAnchorLink.TabIndex = 4;
            this.btnAnchorEdit.BackColor = SystemColors.Control;
            this.btnAnchorEdit.Cursor = Cursors.Hand;
            this.btnAnchorEdit.Image = Resources.smethod_15();
            this.btnAnchorEdit.Location = new Point(0x28b, 0x11);
            this.btnAnchorEdit.Name = "btnAnchorEdit";
            this.btnAnchorEdit.Size = new Size(0x16, 0x16);
            this.btnAnchorEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAnchorEdit.TabIndex = 0x29;
            this.btnAnchorEdit.TabStop = false;
            this.btnAnchorEdit.Click += new EventHandler(this.btnAnchorEdit_Click);
            this.btnAnchorAdd.BackColor = SystemColors.Control;
            this.btnAnchorAdd.Cursor = Cursors.Hand;
            this.btnAnchorAdd.Image = Resources.smethod_14();
            this.btnAnchorAdd.Location = new Point(0x26f, 0x11);
            this.btnAnchorAdd.Name = "btnAnchorAdd";
            this.btnAnchorAdd.Size = new Size(0x16, 0x16);
            this.btnAnchorAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAnchorAdd.TabIndex = 40;
            this.btnAnchorAdd.TabStop = false;
            this.btnAnchorAdd.Click += new EventHandler(this.btnAnchorAdd_Click);
            this.label67.AutoSize = true;
            this.label67.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label67.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label67.Location = new Point(6, 0x17);
            this.label67.Name = "label67";
            this.label67.Size = new Size(0x37, 0x10);
            this.label67.TabIndex = 0x25;
            this.label67.Text = "Từ kh\x00f3a";
            this.txtAnchorKey.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAnchorKey.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAnchorKey.Location = new Point(0x43, 0x13);
            this.txtAnchorKey.Name = "txtAnchorKey";
            this.txtAnchorKey.Size = new Size(180, 0x17);
            this.txtAnchorKey.TabIndex = 3;
            this.dtvAnchorKey.AllowUserToAddRows = false;
            this.dtvAnchorKey.AllowUserToDeleteRows = false;
            this.dtvAnchorKey.AllowUserToOrderColumns = true;
            style5.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAnchorKey.AlternatingRowsDefaultCellStyle = style5;
            this.dtvAnchorKey.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAnchorKey.BackgroundColor = Color.White;
            this.dtvAnchorKey.BorderStyle = BorderStyle.None;
            style6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style6.BackColor = SystemColors.Control;
            style6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style6.ForeColor = SystemColors.WindowText;
            style6.SelectionBackColor = SystemColors.Highlight;
            style6.SelectionForeColor = SystemColors.HighlightText;
            style6.WrapMode = DataGridViewTriState.True;
            this.dtvAnchorKey.ColumnHeadersDefaultCellStyle = style6;
            this.dtvAnchorKey.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.AnchorID, this.dataGridViewTextBoxColumn39, this.Column18 };
            this.dtvAnchorKey.Columns.AddRange(columnArray2);
            style7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style7.BackColor = SystemColors.Window;
            style7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style7.ForeColor = Color.FromArgb(0, 0, 0x40);
            style7.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style7.SelectionForeColor = Color.White;
            style7.WrapMode = DataGridViewTriState.False;
            this.dtvAnchorKey.DefaultCellStyle = style7;
            this.dtvAnchorKey.Location = new Point(9, 0x30);
            this.dtvAnchorKey.MultiSelect = false;
            this.dtvAnchorKey.Name = "dtvAnchorKey";
            this.dtvAnchorKey.ReadOnly = true;
            style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style8.BackColor = SystemColors.Control;
            style8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style8.ForeColor = SystemColors.WindowText;
            style8.SelectionBackColor = SystemColors.HighlightText;
            style8.SelectionForeColor = SystemColors.HighlightText;
            style8.WrapMode = DataGridViewTriState.True;
            this.dtvAnchorKey.RowHeadersDefaultCellStyle = style8;
            this.dtvAnchorKey.RowHeadersWidth = 30;
            this.dtvAnchorKey.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAnchorKey.Size = new Size(0x2b6, 0x1a1);
            this.dtvAnchorKey.TabIndex = 9;
            this.dtvAnchorKey.CellDoubleClick += new DataGridViewCellEventHandler(this.dtvAnchorKey_CellDoubleClick);
            this.dtvAnchorKey.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAnchorKey_RowPostPaint);
            this.AnchorID.HeaderText = "AnchorID";
            this.AnchorID.Name = "AnchorID";
            this.AnchorID.ReadOnly = true;
            this.AnchorID.Visible = false;
            this.dataGridViewTextBoxColumn39.FillWeight = 80f;
            this.dataGridViewTextBoxColumn39.HeaderText = "Từ kh\x00f3a";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.Column18.FillWeight = 136.0502f;
            this.Column18.HeaderText = "Link";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(990, 0x202);
            base.Controls.Add(this.groupBox24);
            base.Controls.Add(this.groupBox30);
            base.Controls.Add(this.toolBar);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmAnchor";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản l\x00fd Li\x00ean kết";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((ISupportInitialize) this.btnAnchorGroupSearch).EndInit();
            ((ISupportInitialize) this.btnAnchorGroupAdd).EndInit();
            ((ISupportInitialize) this.dtvAnchorGroup).EndInit();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((ISupportInitialize) this.btnAnchorDelete).EndInit();
            ((ISupportInitialize) this.btnAnchorEdit).EndInit();
            ((ISupportInitialize) this.btnAnchorAdd).EndInit();
            ((ISupportInitialize) this.dtvAnchorKey).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0()
        {
            this.bool_0 = false;
            this.bool_1 = false;
            this.method_1();
            if (this.dtvAnchorGroup.CurrentRow != null)
            {
                this.method_2();
            }
        }

        private void method_1()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'ANCHOR' ORDER BY Name";
            if (this.bool_0)
            {
                str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'ANCHOR' AND Name LIKE '%" + this.txtAnchorGroup.Text.Trim() + "%' ORDER BY Name";
            }
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvAnchorGroup.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["CategoryID"].ToString(), row["Name"].ToString() };
                int num = this.dtvAnchorGroup.Rows.Add(values);
                this.dtvAnchorGroup.Rows[num].Tag = row;
            }
        }

        private void method_2()
        {
            string str = "SELECT [AnchorID], [Key], [ListUrl] FROM Anchor WHERE CategoryID='" + this.dtvAnchorGroup.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY [LengthKey]";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvAnchorKey.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["AnchorID"].ToString(), row["Key"].ToString(), row["ListUrl"].ToString() };
                int num = this.dtvAnchorKey.Rows.Add(values);
                this.dtvAnchorKey.Rows[num].Tag = row;
            }
        }
    }
}

