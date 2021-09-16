namespace iSEO
{
    using CookComputing.MetaWeblog;
    using iSEO.Properties;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Forms;

    public class frmAccount : Form
    {
        private GClass4 gclass4_0 = new GClass4();
        private IContainer icontainer_0;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;
        private GroupBox groupBox24;
        private ComboBox cbAccountType;
        private Label label2;
        private PictureBox btnAccountDelete;
        private Label label1;
        private TextBox txtAccountConnect;
        private PictureBox btnAccountEdit;
        private PictureBox btnAccountAdd;
        private Label label67;
        private TextBox txtAccountName;
        private DataGridView dtvAccount;
        private GroupBox groupBox30;
        private DataGridView dtvAccountLabel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private Label label3;
        private PictureBox btnGetCategory;
        private DataGridViewTextBoxColumn AnchorID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn Connect;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Column1;
        private PictureBox picLoader;
        private Label label4;
        private PictureBox btnCateDel;

        public frmAccount()
        {
            this.InitializeComponent();
            this.method_0();
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtAccountName.Text.Trim()) || string.IsNullOrEmpty(this.txtAccountConnect.Text.Trim()))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Accounts ([AccountID], [Name], [Connect], [Label], [Type]) VALUES('", Guid.NewGuid(), "','", this.txtAccountName.Text.Trim(), "','", this.txtAccountConnect.Text.Trim(), "','', '", this.cbAccountType.Text, "')" };
                    string str = string.Concat(objArray);
                    this.gclass4_0.method_42(str);
                    this.method_0();
                    this.txtAccountName.Text = string.Empty;
                    this.txtAccountConnect.Text = string.Empty;
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Accounts WHERE [AccountID]='" + this.dtvAccount.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_0();
                this.txtAccountName.Text = string.Empty;
                this.txtAccountConnect.Text = string.Empty;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAccountEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strArray = new string[] { "UPDATE Accounts SET [Name]='", this.txtAccountName.Text.Trim(), "' , [Connect]='", this.txtAccountConnect.Text.Trim(), "', [Type]='", this.cbAccountType.Text, "' WHERE [AccountID]='", this.dtvAccount.CurrentRow.Cells[0].Value.ToString(), "'" };
                string str = string.Concat(strArray);
                this.gclass4_0.method_42(str);
                this.method_0();
                this.txtAccountName.Text = string.Empty;
                this.txtAccountConnect.Text = string.Empty;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCateDel_Click(object sender, EventArgs e)
        {
            if (this.dtvAccountLabel.SelectedRows.Count > 0)
            {
                this.dtvAccountLabel.Rows.RemoveAt(this.dtvAccountLabel.SelectedRows[0].Index);
            }
            string str = "";
            foreach (DataGridViewRow row in (IEnumerable) this.dtvAccountLabel.Rows)
            {
                str = str + row.Cells[0].Value.ToString() + ",";
            }
            string[] strArray = new string[] { "UPDATE Accounts SET [Label]='", str, "' WHERE [AccountID]='", this.dtvAccount.CurrentRow.Cells[0].Value.ToString(), "'" };
            string str2 = string.Concat(strArray);
            this.gclass4_0.method_42(str2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtvAccount.CurrentRow != null)
                {
                    this.picLoader.Show();
                    new Thread(new ThreadStart(this.method_2)) { IsBackground = true }.Start();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dtvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtAccountName.Text = this.dtvAccount.CurrentRow.Cells[1].Value.ToString();
                this.txtAccountConnect.Text = this.dtvAccount.CurrentRow.Cells[2].Value.ToString();
                this.cbAccountType.Text = this.dtvAccount.CurrentRow.Cells[3].Value.ToString();
                string[] strArray = this.dtvAccount.CurrentRow.Cells[4].Value.ToString().Split(new char[] { ',' });
                this.dtvAccountLabel.Rows.Clear();
                foreach (string str2 in strArray)
                {
                    if (!string.IsNullOrEmpty(str2))
                    {
                        this.dtvAccountLabel.Rows.Add(new object[] { str2 });
                    }
                }
            }
            catch
            {
            }
        }

        private void dtvAccount_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAccount.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void dtvAccountLabel_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAccountLabel.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            this.cbAccountType.Text = "Wordpress";
            this.method_0();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmAccount));
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.groupBox24 = new GroupBox();
            this.cbAccountType = new ComboBox();
            this.label2 = new Label();
            this.btnAccountDelete = new PictureBox();
            this.label1 = new Label();
            this.txtAccountConnect = new TextBox();
            this.btnAccountEdit = new PictureBox();
            this.btnAccountAdd = new PictureBox();
            this.label67 = new Label();
            this.txtAccountName = new TextBox();
            this.dtvAccount = new DataGridView();
            this.AnchorID = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new DataGridViewTextBoxColumn();
            this.Connect = new DataGridViewTextBoxColumn();
            this.Type = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.groupBox30 = new GroupBox();
            this.dtvAccountLabel = new DataGridView();
            this.dataGridViewTextBoxColumn46 = new DataGridViewTextBoxColumn();
            this.label4 = new Label();
            this.label3 = new Label();
            this.btnCateDel = new PictureBox();
            this.btnGetCategory = new PictureBox();
            this.picLoader = new PictureBox();
            this.toolBar.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((ISupportInitialize) this.btnAccountDelete).BeginInit();
            ((ISupportInitialize) this.btnAccountEdit).BeginInit();
            ((ISupportInitialize) this.btnAccountAdd).BeginInit();
            ((ISupportInitialize) this.dtvAccount).BeginInit();
            this.groupBox30.SuspendLayout();
            ((ISupportInitialize) this.dtvAccountLabel).BeginInit();
            ((ISupportInitialize) this.btnCateDel).BeginInit();
            ((ISupportInitialize) this.btnGetCategory).BeginInit();
            ((ISupportInitialize) this.picLoader).BeginInit();
            base.SuspendLayout();
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x3e6, 0x19);
            this.toolBar.TabIndex = 0x15;
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
            this.toolStripLabel3.Size = new Size(0x83, 0x16);
            this.toolStripLabel3.Text = "Quản l\x00fd t\x00e0i khoản";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            this.groupBox24.Controls.Add(this.cbAccountType);
            this.groupBox24.Controls.Add(this.label2);
            this.groupBox24.Controls.Add(this.btnAccountDelete);
            this.groupBox24.Controls.Add(this.label1);
            this.groupBox24.Controls.Add(this.txtAccountConnect);
            this.groupBox24.Controls.Add(this.btnAccountEdit);
            this.groupBox24.Controls.Add(this.btnAccountAdd);
            this.groupBox24.Controls.Add(this.label67);
            this.groupBox24.Controls.Add(this.txtAccountName);
            this.groupBox24.Controls.Add(this.dtvAccount);
            this.groupBox24.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox24.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox24.Location = new Point(12, 0x1f);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new Size(0x2e5, 0x1d0);
            this.groupBox24.TabIndex = 0x20;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Quản l\x00fd t\x00e0i khoản";
            this.cbAccountType.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbAccountType.FlatStyle = FlatStyle.Popup;
            this.cbAccountType.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbAccountType.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbAccountType.FormattingEnabled = true;
            object[] items = new object[] { "Wordpress", "Blogger" };
            this.cbAccountType.Items.AddRange(items);
            this.cbAccountType.Location = new Point(0x22c, 0x12);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new Size(0x5c, 0x18);
            this.cbAccountType.TabIndex = 3;
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label2.Location = new Point(0x207, 0x17);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x1f, 0x10);
            this.label2.TabIndex = 0x2c;
            this.label2.Text = "Loại";
            this.btnAccountDelete.BackColor = SystemColors.Control;
            this.btnAccountDelete.Cursor = Cursors.Hand;
            this.btnAccountDelete.Image = Resources.smethod_12();
            this.btnAccountDelete.Location = new Point(710, 0x12);
            this.btnAccountDelete.Name = "btnAccountDelete";
            this.btnAccountDelete.Size = new Size(0x16, 0x16);
            this.btnAccountDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnAccountDelete.TabIndex = 0x2a;
            this.btnAccountDelete.TabStop = false;
            this.btnAccountDelete.Click += new EventHandler(this.btnAccountDelete_Click);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label1.Location = new Point(0xaf, 0x16);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2f, 0x10);
            this.label1.TabIndex = 0x27;
            this.label1.Text = "Kết nối";
            this.txtAccountConnect.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAccountConnect.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAccountConnect.Location = new Point(0xe4, 0x13);
            this.txtAccountConnect.Name = "txtAccountConnect";
            this.txtAccountConnect.Size = new Size(0x11d, 0x17);
            this.txtAccountConnect.TabIndex = 2;
            this.btnAccountEdit.BackColor = SystemColors.Control;
            this.btnAccountEdit.Cursor = Cursors.Hand;
            this.btnAccountEdit.Image = Resources.smethod_15();
            this.btnAccountEdit.Location = new Point(0x2aa, 0x12);
            this.btnAccountEdit.Name = "btnAccountEdit";
            this.btnAccountEdit.Size = new Size(0x16, 0x16);
            this.btnAccountEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAccountEdit.TabIndex = 0x29;
            this.btnAccountEdit.TabStop = false;
            this.btnAccountEdit.Click += new EventHandler(this.btnAccountEdit_Click);
            this.btnAccountAdd.BackColor = SystemColors.Control;
            this.btnAccountAdd.Cursor = Cursors.Hand;
            this.btnAccountAdd.Image = Resources.smethod_14();
            this.btnAccountAdd.Location = new Point(0x28e, 0x12);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new Size(0x16, 0x16);
            this.btnAccountAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAccountAdd.TabIndex = 40;
            this.btnAccountAdd.TabStop = false;
            this.btnAccountAdd.Click += new EventHandler(this.btnAccountAdd_Click);
            this.label67.AutoSize = true;
            this.label67.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label67.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label67.Location = new Point(6, 0x17);
            this.label67.Name = "label67";
            this.label67.Size = new Size(30, 0x10);
            this.label67.TabIndex = 0x25;
            this.label67.Text = "T\x00ean";
            this.txtAccountName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAccountName.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAccountName.Location = new Point(0x2a, 0x13);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new Size(0x7f, 0x17);
            this.txtAccountName.TabIndex = 1;
            this.dtvAccount.AllowUserToAddRows = false;
            this.dtvAccount.AllowUserToDeleteRows = false;
            this.dtvAccount.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAccount.AlternatingRowsDefaultCellStyle = style;
            this.dtvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAccount.BackgroundColor = Color.White;
            this.dtvAccount.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dtvAccount.ColumnHeadersDefaultCellStyle = style2;
            this.dtvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.AnchorID, this.dataGridViewTextBoxColumn39, this.Connect, this.Type, this.Column1 };
            this.dtvAccount.Columns.AddRange(dataGridViewColumns);
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.FromArgb(0, 0, 0x40);
            style3.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style3.SelectionForeColor = Color.White;
            style3.WrapMode = DataGridViewTriState.False;
            this.dtvAccount.DefaultCellStyle = style3;
            this.dtvAccount.Location = new Point(9, 0x30);
            this.dtvAccount.MultiSelect = false;
            this.dtvAccount.Name = "dtvAccount";
            this.dtvAccount.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.HighlightText;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dtvAccount.RowHeadersDefaultCellStyle = style4;
            this.dtvAccount.RowHeadersWidth = 30;
            this.dtvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAccount.Size = new Size(0x2d3, 410);
            this.dtvAccount.TabIndex = 7;
            this.dtvAccount.CellClick += new DataGridViewCellEventHandler(this.dtvAccount_CellClick);
            this.dtvAccount.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAccount_RowPostPaint);
            this.AnchorID.HeaderText = "AccountID";
            this.AnchorID.Name = "AnchorID";
            this.AnchorID.ReadOnly = true;
            this.AnchorID.Visible = false;
            this.dataGridViewTextBoxColumn39.FillWeight = 56.85279f;
            this.dataGridViewTextBoxColumn39.HeaderText = "T\x00ean";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.Connect.FillWeight = 175.9386f;
            this.Connect.HeaderText = "Kết nối";
            this.Connect.Name = "Connect";
            this.Connect.ReadOnly = true;
            this.Type.FillWeight = 47.20858f;
            this.Type.HeaderText = "Loại";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Column1.HeaderText = "Category";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.groupBox30.Controls.Add(this.dtvAccountLabel);
            this.groupBox30.Controls.Add(this.label4);
            this.groupBox30.Controls.Add(this.label3);
            this.groupBox30.Controls.Add(this.btnCateDel);
            this.groupBox30.Controls.Add(this.btnGetCategory);
            this.groupBox30.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox30.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox30.Location = new Point(0x2f7, 0x1f);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new Size(230, 0x1d0);
            this.groupBox30.TabIndex = 0x21;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Nh\x00f3m nh\x00e3n";
            this.dtvAccountLabel.AllowUserToAddRows = false;
            this.dtvAccountLabel.AllowUserToDeleteRows = false;
            this.dtvAccountLabel.AllowUserToOrderColumns = true;
            style5.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAccountLabel.AlternatingRowsDefaultCellStyle = style5;
            this.dtvAccountLabel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAccountLabel.BackgroundColor = Color.White;
            this.dtvAccountLabel.BorderStyle = BorderStyle.None;
            style6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style6.BackColor = SystemColors.Control;
            style6.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style6.ForeColor = SystemColors.WindowText;
            style6.SelectionBackColor = SystemColors.Highlight;
            style6.SelectionForeColor = SystemColors.HighlightText;
            style6.WrapMode = DataGridViewTriState.True;
            this.dtvAccountLabel.ColumnHeadersDefaultCellStyle = style6;
            this.dtvAccountLabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn46 };
            this.dtvAccountLabel.Columns.AddRange(columnArray2);
            style7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style7.BackColor = SystemColors.Window;
            style7.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style7.ForeColor = Color.FromArgb(0, 0, 0x40);
            style7.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style7.SelectionForeColor = Color.White;
            style7.WrapMode = DataGridViewTriState.False;
            this.dtvAccountLabel.DefaultCellStyle = style7;
            this.dtvAccountLabel.Location = new Point(6, 0x30);
            this.dtvAccountLabel.MultiSelect = false;
            this.dtvAccountLabel.Name = "dtvAccountLabel";
            this.dtvAccountLabel.ReadOnly = true;
            style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style8.BackColor = SystemColors.Control;
            style8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style8.ForeColor = SystemColors.WindowText;
            style8.SelectionBackColor = SystemColors.HighlightText;
            style8.SelectionForeColor = SystemColors.HighlightText;
            style8.WrapMode = DataGridViewTriState.True;
            this.dtvAccountLabel.RowHeadersDefaultCellStyle = style8;
            this.dtvAccountLabel.RowHeadersWidth = 30;
            this.dtvAccountLabel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAccountLabel.Size = new Size(0xd8, 410);
            this.dtvAccountLabel.TabIndex = 8;
            this.dtvAccountLabel.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAccountLabel_RowPostPaint);
            this.dataGridViewTextBoxColumn46.HeaderText = "Danh mục";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label4.Location = new Point(0xa1, 0x18);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x21, 0x10);
            this.label4.TabIndex = 0x2c;
            this.label4.Text = "Xo\x00e1";
            this.label4.TextAlign = ContentAlignment.MiddleCenter;
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label3.Location = new Point(0x20, 0x16);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x61, 0x10);
            this.label3.TabIndex = 0x2c;
            this.label3.Text = "Lấy danh mục";
            this.btnCateDel.BackColor = SystemColors.Control;
            this.btnCateDel.Cursor = Cursors.Hand;
            this.btnCateDel.Image = Resources.smethod_12();
            this.btnCateDel.Location = new Point(200, 20);
            this.btnCateDel.Name = "btnCateDel";
            this.btnCateDel.Size = new Size(0x16, 0x16);
            this.btnCateDel.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnCateDel.TabIndex = 0x2a;
            this.btnCateDel.TabStop = false;
            this.btnCateDel.Click += new EventHandler(this.btnCateDel_Click);
            this.btnGetCategory.BackColor = SystemColors.Control;
            this.btnGetCategory.Cursor = Cursors.Hand;
            this.btnGetCategory.Image = Resources.smethod_14();
            this.btnGetCategory.Location = new Point(7, 20);
            this.btnGetCategory.Name = "btnGetCategory";
            this.btnGetCategory.Size = new Size(0x16, 0x16);
            this.btnGetCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnGetCategory.TabIndex = 40;
            this.btnGetCategory.TabStop = false;
            this.btnGetCategory.Click += new EventHandler(this.btnGetCategory_Click);
            this.picLoader.BackColor = SystemColors.AppWorkspace;
            this.picLoader.Image = Resources.smethod_19();
            this.picLoader.Location = new Point(760, 2);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new Size(0xd3, 0x12);
            this.picLoader.SizeMode = PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 0x22;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3e6, 0x1fa);
            base.Controls.Add(this.picLoader);
            base.Controls.Add(this.groupBox30);
            base.Controls.Add(this.groupBox24);
            base.Controls.Add(this.toolBar);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmAccount";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản l\x00fd t\x00e0i khoản";
            base.Load += new EventHandler(this.frmAccount_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((ISupportInitialize) this.btnAccountDelete).EndInit();
            ((ISupportInitialize) this.btnAccountEdit).EndInit();
            ((ISupportInitialize) this.btnAccountAdd).EndInit();
            ((ISupportInitialize) this.dtvAccount).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((ISupportInitialize) this.dtvAccountLabel).EndInit();
            ((ISupportInitialize) this.btnCateDel).EndInit();
            ((ISupportInitialize) this.btnGetCategory).EndInit();
            ((ISupportInitialize) this.picLoader).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0()
        {
            string str = "SELECT [AccountID], [Name], [Connect],[Label], [Type] FROM Accounts ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvAccount.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["AccountID"].ToString(), row["Name"].ToString(), row["Connect"].ToString(), row["Type"].ToString(), row["Label"].ToString() };
                int num = this.dtvAccount.Rows.Add(values);
                this.dtvAccount.Rows[num].Tag = row;
            }
        }

        private void method_1(object sender, EventArgs e)
        {
            MessageBox.Show("sdf");
        }

        private void method_2()
        {
            try
            {
                Class4 class3 = new Class4 {
                    frmAccount_0 = this
                };
                GClass6 class2 = new GClass6();
                class3.list_0 = new List<string>();
                class3.string_0 = string.Empty;
                class3.string_1 = string.Empty;
                MethodInvoker method = new MethodInvoker(class3.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                Thread.Sleep(100);
                string[] strArray = class3.string_1.Split(new char[] { ';' });
                if ("Blogger".Equals(class3.string_0))
                {
                    class3.list_0 = class2.method_3(strArray[0]);
                }
                else if ("Wordpress".Equals(class3.string_0))
                {
                    Category[] categoryArray = class2.method_2(strArray[0], strArray[1], strArray[2]);
                    if (categoryArray != null)
                    {
                        foreach (Category category in categoryArray)
                        {
                            class3.list_0.Add(category.categoryName);
                        }
                    }
                }
                method = new MethodInvoker(class3.method_1);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch
            {
                MessageBox.Show("Nhập lại chuỗi kết nối!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        [CompilerGenerated]
        private sealed class Class4
        {
            public List<string> list_0;
            public string string_0;
            public string string_1;
            public frmAccount frmAccount_0;

            public void method_0()
            {
                this.frmAccount_0.dtvAccountLabel.Rows.Clear();
                this.string_0 = this.frmAccount_0.dtvAccount.CurrentRow.Cells[3].Value.ToString();
                this.string_1 = this.frmAccount_0.dtvAccount.CurrentRow.Cells[2].Value.ToString();
            }

            public void method_1()
            {
                string str = "";
                foreach (string str2 in this.list_0)
                {
                    object[] values = new object[] { str2 };
                    this.frmAccount_0.dtvAccountLabel.Rows.Add(values);
                    str = str + str2 + ",";
                }
                if (!string.IsNullOrEmpty(str))
                {
                    string[] strArray = new string[] { "UPDATE Accounts SET [Label]='", str, "' WHERE [AccountID]='", this.frmAccount_0.dtvAccount.CurrentRow.Cells[0].Value.ToString(), "'" };
                    string str3 = string.Concat(strArray);
                    this.frmAccount_0.gclass4_0.method_42(str3);
                    MessageBox.Show("Cập nhật danh mục th\x00e0nh c\x00f4ng!", "Alert!");
                    this.frmAccount_0.method_0();
                }
                this.frmAccount_0.picLoader.Hide();
            }
        }
    }
}

