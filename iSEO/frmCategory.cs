namespace iSEO
{
    using iSEO.Properties;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmCategory : Form
    {
        private IContainer icontainer_0;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;
        private DataGridView dtvCate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private PictureBox btCateDelete;
        private PictureBox btCateEdit;
        private PictureBox btCateAdd;
        private TextBox txtCate;
        private Label label51;
        private Label label1;
        private Label label2;
        private ComboBox cbCate;
        private GClass4 gclass4_0 = new GClass4();
        public string string_0 = "KEY";
        public string string_1 = string.Empty;

        public frmCategory()
        {
            this.InitializeComponent();
        }

        private void btCateAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCate.Text.Trim()))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Categories (CategoryID, Name, Code) VALUES('", Guid.NewGuid(), "','", this.txtCate.Text.Trim(), "','", this.cbCate.SelectedValue, "')" };
                    string str = string.Concat(objArray);
                    this.gclass4_0.method_42(str);
                    this.method_0();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btCateDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Categories WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.gclass4_0.method_42("DELETE FROM Backlinks WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.gclass4_0.method_42("DELETE FROM Adwords WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.gclass4_0.method_42("DELETE FROM Articles WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.gclass4_0.method_42("DELETE FROM Keywords WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.gclass4_0.method_42("DELETE FROM Submits WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.gclass4_0.method_42("DELETE FROM NewsLogs WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.gclass4_0.method_42("DELETE FROM Contents WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_0();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btCateEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("UPDATE Categories SET Name='" + this.txtCate.Text.Trim() + "' WHERE CategoryID='" + this.dtvCate.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_0();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void cbCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.method_0();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dtvCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtCate.Text = this.dtvCate.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Value", typeof(string));
            table.Columns.Add("Name", typeof(string));
            object[] values = new object[] { "KEY", "Danh mục Quản l\x00fd Từ kho\x00e1" };
            table.Rows.Add(values);
            values[0] = "BACKLINK";
            values[1] = "Danh mục Quản l\x00fd Backlink";
            table.Rows.Add(values);
            values[0] = "ARTICLE";
            values[1] = "Danh mục Quản l\x00fd Marketing";
            table.Rows.Add(values);
            values[0] = "SUBMIT";
            values[1] = "Danh mục Marketing Tools";
            table.Rows.Add(values);
            values[0] = "ADWORD";
            values[1] = "Danh mục Quản l\x00fd Adword";
            table.Rows.Add(values);
            values[0] = "NEWS";
            values[1] = "Nh\x00f3m từ kho\x00e1 Tin tức";
            table.Rows.Add(values);
            values[0] = "ANCHOR";
            values[1] = "Nh\x00f3m từ kho\x00e1 (ConpyRigher)";
            table.Rows.Add(values);
            values[0] = "CONTENT";
            values[1] = "Nh\x00f3m nội dung (ConpyRigher)";
            table.Rows.Add(values);
            this.cbCate.DataSource = table;
            this.cbCate.ValueMember = "Value";
            this.cbCate.DisplayMember = "Name";
            this.cbCate.SelectedValue = this.string_0;
            this.method_0();
            this.txtCate.Text = this.string_1;
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmCategory));
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.dtvCate = new DataGridView();
            this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            this.btCateDelete = new PictureBox();
            this.btCateEdit = new PictureBox();
            this.btCateAdd = new PictureBox();
            this.txtCate = new TextBox();
            this.label51 = new Label();
            this.cbCate = new ComboBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.toolBar.SuspendLayout();
            ((ISupportInitialize) this.dtvCate).BeginInit();
            ((ISupportInitialize) this.btCateDelete).BeginInit();
            ((ISupportInitialize) this.btCateEdit).BeginInit();
            ((ISupportInitialize) this.btCateAdd).BeginInit();
            base.SuspendLayout();
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x16e, 0x19);
            this.toolBar.TabIndex = 0x11;
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
            this.toolStripLabel3.Size = new Size(0x85, 0x16);
            this.toolStripLabel3.Text = "Quản l\x00fd danh mục";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            this.dtvCate.AllowUserToAddRows = false;
            this.dtvCate.AllowUserToDeleteRows = false;
            this.dtvCate.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvCate.AlternatingRowsDefaultCellStyle = style;
            this.dtvCate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvCate.BackgroundColor = Color.White;
            this.dtvCate.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dtvCate.ColumnHeadersDefaultCellStyle = style2;
            this.dtvCate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn13, this.dataGridViewTextBoxColumn14 };
            this.dtvCate.Columns.AddRange(dataGridViewColumns);
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.FromArgb(0, 0, 0x40);
            style3.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style3.SelectionForeColor = Color.White;
            style3.WrapMode = DataGridViewTriState.False;
            this.dtvCate.DefaultCellStyle = style3;
            this.dtvCate.Location = new Point(12, 0x7a);
            this.dtvCate.MultiSelect = false;
            this.dtvCate.Name = "dtvCate";
            this.dtvCate.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.HighlightText;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dtvCate.RowHeadersDefaultCellStyle = style4;
            this.dtvCate.RowHeadersWidth = 30;
            this.dtvCate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvCate.Size = new Size(0x152, 0x1b0);
            this.dtvCate.TabIndex = 6;
            this.dtvCate.CellClick += new DataGridViewCellEventHandler(this.dtvCate_CellClick);
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn14.HeaderText = "Danh mục";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.btCateDelete.BackColor = SystemColors.Control;
            this.btCateDelete.Cursor = Cursors.Hand;
            this.btCateDelete.Image = Resources.smethod_12();
            this.btCateDelete.Location = new Point(0x148, 0x5d);
            this.btCateDelete.Name = "btCateDelete";
            this.btCateDelete.Size = new Size(0x16, 0x16);
            this.btCateDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btCateDelete.TabIndex = 40;
            this.btCateDelete.TabStop = false;
            this.btCateDelete.Click += new EventHandler(this.btCateDelete_Click);
            this.btCateEdit.BackColor = SystemColors.Control;
            this.btCateEdit.Cursor = Cursors.Hand;
            this.btCateEdit.Image = Resources.smethod_15();
            this.btCateEdit.Location = new Point(300, 0x5e);
            this.btCateEdit.Name = "btCateEdit";
            this.btCateEdit.Size = new Size(0x16, 0x16);
            this.btCateEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btCateEdit.TabIndex = 0x27;
            this.btCateEdit.TabStop = false;
            this.btCateEdit.Click += new EventHandler(this.btCateEdit_Click);
            this.btCateAdd.BackColor = SystemColors.Control;
            this.btCateAdd.Cursor = Cursors.Hand;
            this.btCateAdd.Image = Resources.smethod_14();
            this.btCateAdd.Location = new Point(0x110, 0x5e);
            this.btCateAdd.Name = "btCateAdd";
            this.btCateAdd.Size = new Size(0x16, 0x16);
            this.btCateAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btCateAdd.TabIndex = 0x26;
            this.btCateAdd.TabStop = false;
            this.btCateAdd.Click += new EventHandler(this.btCateAdd_Click);
            this.txtCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtCate.Location = new Point(0x3f, 0x40);
            this.txtCate.Name = "txtCate";
            this.txtCate.Size = new Size(0x11f, 0x17);
            this.txtCate.TabIndex = 2;
            this.label51.AutoSize = true;
            this.label51.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label51.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label51.Location = new Point(0x9c, 0x61);
            this.label51.Name = "label51";
            this.label51.Size = new Size(110, 0x10);
            this.label51.TabIndex = 0x25;
            this.label51.Text = "Th\x00eam | Sửa |Xo\x00e1";
            this.cbCate.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbCate.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbCate.FlatStyle = FlatStyle.Popup;
            this.cbCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new Point(0x3f, 0x22);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new Size(0x11f, 0x18);
            this.cbCate.TabIndex = 1;
            this.cbCate.SelectionChangeCommitted += new EventHandler(this.cbCate_SelectionChangeCommitted);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label1.Location = new Point(12, 0x25);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x29, 0x10);
            this.label1.TabIndex = 0x25;
            this.label1.Text = "Nh\x00f3m";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label2.Location = new Point(12, 0x47);
            this.label2.Name = "label2";
            this.label2.Size = new Size(30, 0x10);
            this.label2.TabIndex = 0x25;
            this.label2.Text = "T\x00ean";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x16e, 0x238);
            base.Controls.Add(this.cbCate);
            base.Controls.Add(this.btCateDelete);
            base.Controls.Add(this.btCateEdit);
            base.Controls.Add(this.btCateAdd);
            base.Controls.Add(this.txtCate);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.label51);
            base.Controls.Add(this.dtvCate);
            base.Controls.Add(this.toolBar);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmCategory";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản l\x00fd danh mục";
            base.Load += new EventHandler(this.frmCategory_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((ISupportInitialize) this.dtvCate).EndInit();
            ((ISupportInitialize) this.btCateDelete).EndInit();
            ((ISupportInitialize) this.btCateEdit).EndInit();
            ((ISupportInitialize) this.btCateAdd).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = '" + this.cbCate.SelectedValue + "' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvCate.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["CategoryID"].ToString(), row["Name"].ToString() };
                int num = this.dtvCate.Rows.Add(values);
                this.dtvCate.Rows[num].Tag = row;
            }
        }
    }
}

