namespace iSEO
{
    using iSEO.Properties;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Forms;

    public class frmSitemap : Form
    {
        private GClass4 gclass4_0 = new GClass4();
        private string string_0 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><rss version=\"2.0\"\r\nxmlns:content=\"http://purl.org/rss/1.0/modules/content/\"\r\nxmlns:wfw=\"http://wellformedweb.org/CommentAPI/\"\r\nxmlns:dc=\"http://purl.org/dc/elements/1.1/\"\r\nxmlns:atom=\"http://www.w3.org/2005/Atom\"\r\nxmlns:sy=\"http://purl.org/rss/1.0/modules/syndication/\"\r\nxmlns:slash=\"http://purl.org/rss/1.0/modules/slash/\"\r\nxmlns:georss=\"http://www.georss.org/georss\" xmlns:geo=\"http://www.w3.org/2003/01/geo/wgs84_pos#\" xmlns:media=\"http://search.yahoo.com/mrss/\"\r\n><channel>\r\n<title><![CDATA[ RSS ]]></title>\r\n$content$\r\n</channel></rss>";
        private string string_1 = ("<?xml version=\"1.0\" encoding=\"UTF-8\"?><!-- Created (" + DateTime.Now.ToString() + ") with Free iSEO - iGoo.vn --><urlset xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">$content$</urlset>");
        private bool bool_0;
        private List<string> list_0;
        private IContainer icontainer_0;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;
        private PictureBox picLoader;
        private DataGridView dtvName;
        private RichTextBox txtListUrl;
        private Label label1;
        private GroupBox groupBox8;
        private PictureBox btnSitemapSearch;
        private TextBox txtName;
        private PictureBox btnSitemapDelete;
        private PictureBox btnSitemapEdit;
        private PictureBox btnSitemapAdd;
        private Label label34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn Column1;
        private Button btnGenSitemap;
        private GroupBox groupBox27;
        private Button btnGenSitemapAuto;
        private Label label2;
        private Label label3;
        private Button btnGenRSS;
        private Button btnGenRSSAuto;
        [CompilerGenerated]
        private static Func<GClass9, bool> func_0;
        [CompilerGenerated]
        private static Func<GClass9, bool> func_1;

        public frmSitemap()
        {
            this.InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnGenRSS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtListUrl.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.list_0 = this.txtListUrl.Text.Trim().Split(new char[] { '\n' }).ToList<string>();
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_2)) { IsBackground = true }.Start();
            }
        }

        private void btnGenRSSAuto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtListUrl.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.list_0 = this.txtListUrl.Text.Trim().Split(new char[] { '\n' }).ToList<string>();
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_4)) { IsBackground = true }.Start();
            }
        }

        private void btnGenSitemap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtListUrl.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.list_0 = this.txtListUrl.Text.Trim().Split(new char[] { '\n' }).ToList<string>();
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_1)) { IsBackground = true }.Start();
            }
        }

        private void btnGenSitemapAuto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtListUrl.Text.Trim()))
            {
                MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.list_0 = this.txtListUrl.Text.Trim().Split(new char[] { '\n' }).ToList<string>();
                this.picLoader.Show();
                new Thread(new ThreadStart(this.method_3)) { IsBackground = true }.Start();
            }
        }

        private void btnSitemapAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtName.Text.Trim()) || string.IsNullOrEmpty(this.txtListUrl.Text.Trim()))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Sitemaps (SitemapID, Name, ListUrl) VALUES('", Guid.NewGuid(), "','", this.txtName.Text.Trim(), "','", this.txtListUrl.Text.Trim(), "')" };
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

        private void btnSitemapDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Sitemaps WHERE SitemapID='" + this.dtvName.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_0();
                this.txtName.Text = string.Empty;
                this.txtListUrl.Text = string.Empty;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSitemapEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("UPDATE Sitemaps SET Name='" + this.txtName.Text.Trim() + "', ListUrl='" + this.txtListUrl.Text.Trim() + "' WHERE SitemapID='" + this.dtvName.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_0();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSitemapSearch_Click(object sender, EventArgs e)
        {
            this.bool_0 = true;
            this.method_0();
            this.bool_0 = false;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dtvName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtName.Text = this.dtvName.CurrentRow.Cells[1].Value.ToString();
                this.txtListUrl.Text = this.dtvName.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
            }
        }

        private void dtvName_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvName.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void frmSitemap_Load(object sender, EventArgs e)
        {
            try
            {
                this.method_0();
                this.txtName.Text = this.dtvName.CurrentRow.Cells[1].Value.ToString();
                this.txtListUrl.Text = this.dtvName.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
            }
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmSitemap));
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.picLoader = new PictureBox();
            this.dtvName = new DataGridView();
            this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.txtListUrl = new RichTextBox();
            this.label1 = new Label();
            this.groupBox8 = new GroupBox();
            this.groupBox27 = new GroupBox();
            this.label34 = new Label();
            this.btnSitemapDelete = new PictureBox();
            this.btnSitemapEdit = new PictureBox();
            this.btnSitemapAdd = new PictureBox();
            this.btnSitemapSearch = new PictureBox();
            this.txtName = new TextBox();
            this.btnGenSitemap = new Button();
            this.btnGenSitemapAuto = new Button();
            this.label2 = new Label();
            this.label3 = new Label();
            this.btnGenRSS = new Button();
            this.btnGenRSSAuto = new Button();
            this.toolBar.SuspendLayout();
            ((ISupportInitialize) this.picLoader).BeginInit();
            ((ISupportInitialize) this.dtvName).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox27.SuspendLayout();
            ((ISupportInitialize) this.btnSitemapDelete).BeginInit();
            ((ISupportInitialize) this.btnSitemapEdit).BeginInit();
            ((ISupportInitialize) this.btnSitemapAdd).BeginInit();
            ((ISupportInitialize) this.btnSitemapSearch).BeginInit();
            base.SuspendLayout();
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x335, 0x19);
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
            this.toolStripLabel3.Size = new Size(0xa5, 0x16);
            this.toolStripLabel3.Text = "Quản l\x00fd Sitemap && RSS";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            this.picLoader.BackColor = SystemColors.AppWorkspace;
            this.picLoader.Image = Resources.smethod_19();
            this.picLoader.Location = new Point(0x23b, 3);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new Size(0xd3, 0x12);
            this.picLoader.SizeMode = PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 0x12;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            this.dtvName.AllowUserToAddRows = false;
            this.dtvName.AllowUserToDeleteRows = false;
            this.dtvName.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvName.AlternatingRowsDefaultCellStyle = style;
            this.dtvName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvName.BackgroundColor = Color.White;
            this.dtvName.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dtvName.ColumnHeadersDefaultCellStyle = style2;
            this.dtvName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn13, this.dataGridViewTextBoxColumn14, this.Column1 };
            this.dtvName.Columns.AddRange(dataGridViewColumns);
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.FromArgb(0, 0, 0x40);
            style3.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style3.SelectionForeColor = Color.White;
            style3.WrapMode = DataGridViewTriState.False;
            this.dtvName.DefaultCellStyle = style3;
            this.dtvName.Location = new Point(6, 0x17);
            this.dtvName.MultiSelect = false;
            this.dtvName.Name = "dtvName";
            this.dtvName.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.HighlightText;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dtvName.RowHeadersDefaultCellStyle = style4;
            this.dtvName.RowHeadersWidth = 30;
            this.dtvName.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvName.Size = new Size(240, 0x161);
            this.dtvName.TabIndex = 1;
            this.dtvName.CellClick += new DataGridViewCellEventHandler(this.dtvName_CellClick);
            this.dtvName.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvName_RowPostPaint);
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn14.HeaderText = "Nh\x00f3m";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.Column1.HeaderText = "List Url";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.txtListUrl.BorderStyle = BorderStyle.None;
            this.txtListUrl.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtListUrl.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtListUrl.Location = new Point(6, 0x15);
            this.txtListUrl.Name = "txtListUrl";
            this.txtListUrl.Size = new Size(0x20f, 300);
            this.txtListUrl.TabIndex = 8;
            this.txtListUrl.Text = "";
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label1.Location = new Point(0x10f, 0x42);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x5b, 0x10);
            this.label1.TabIndex = 0x20;
            this.label1.Text = "Nh\x00f3m Website";
            this.groupBox8.Controls.Add(this.groupBox27);
            this.groupBox8.Controls.Add(this.label34);
            this.groupBox8.Controls.Add(this.btnSitemapDelete);
            this.groupBox8.Controls.Add(this.btnSitemapEdit);
            this.groupBox8.Controls.Add(this.btnSitemapAdd);
            this.groupBox8.Controls.Add(this.btnSitemapSearch);
            this.groupBox8.Controls.Add(this.txtName);
            this.groupBox8.Controls.Add(this.dtvName);
            this.groupBox8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox8.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox8.Location = new Point(12, 0x2b);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new Size(0x31d, 0x181);
            this.groupBox8.TabIndex = 0x24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Quản l\x00fd Sitemap && RSS";
            this.groupBox27.Controls.Add(this.txtListUrl);
            this.groupBox27.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox27.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox27.Location = new Point(0xfc, 0x31);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new Size(0x21b, 0x147);
            this.groupBox27.TabIndex = 0x26;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Danh s\x00e1ch Url Link";
            this.label34.AutoSize = true;
            this.label34.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label34.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label34.Location = new Point(0xf9, 0x17);
            this.label34.Name = "label34";
            this.label34.Size = new Size(0x42, 0x10);
            this.label34.TabIndex = 40;
            this.label34.Text = "T\x00ean nh\x00f3m";
            this.btnSitemapDelete.BackColor = SystemColors.Control;
            this.btnSitemapDelete.Cursor = Cursors.Hand;
            this.btnSitemapDelete.Image = Resources.smethod_12();
            this.btnSitemapDelete.Location = new Point(0x301, 20);
            this.btnSitemapDelete.Name = "btnSitemapDelete";
            this.btnSitemapDelete.Size = new Size(0x16, 0x16);
            this.btnSitemapDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnSitemapDelete.TabIndex = 0x27;
            this.btnSitemapDelete.TabStop = false;
            this.btnSitemapDelete.Click += new EventHandler(this.btnSitemapDelete_Click);
            this.btnSitemapEdit.BackColor = SystemColors.Control;
            this.btnSitemapEdit.Cursor = Cursors.Hand;
            this.btnSitemapEdit.Image = Resources.smethod_15();
            this.btnSitemapEdit.Location = new Point(0x2e5, 20);
            this.btnSitemapEdit.Name = "btnSitemapEdit";
            this.btnSitemapEdit.Size = new Size(0x16, 0x16);
            this.btnSitemapEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnSitemapEdit.TabIndex = 0x26;
            this.btnSitemapEdit.TabStop = false;
            this.btnSitemapEdit.Click += new EventHandler(this.btnSitemapEdit_Click);
            this.btnSitemapAdd.BackColor = SystemColors.Control;
            this.btnSitemapAdd.Cursor = Cursors.Hand;
            this.btnSitemapAdd.Image = Resources.smethod_14();
            this.btnSitemapAdd.Location = new Point(0x2c9, 20);
            this.btnSitemapAdd.Name = "btnSitemapAdd";
            this.btnSitemapAdd.Size = new Size(0x16, 0x16);
            this.btnSitemapAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnSitemapAdd.TabIndex = 0x25;
            this.btnSitemapAdd.TabStop = false;
            this.btnSitemapAdd.Click += new EventHandler(this.btnSitemapAdd_Click);
            this.btnSitemapSearch.BackColor = SystemColors.Control;
            this.btnSitemapSearch.Cursor = Cursors.Hand;
            this.btnSitemapSearch.Image = Resources.smethod_18();
            this.btnSitemapSearch.Location = new Point(0x2ad, 20);
            this.btnSitemapSearch.Name = "btnSitemapSearch";
            this.btnSitemapSearch.Size = new Size(0x16, 0x16);
            this.btnSitemapSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnSitemapSearch.TabIndex = 0x24;
            this.btnSitemapSearch.TabStop = false;
            this.btnSitemapSearch.Click += new EventHandler(this.btnSitemapSearch_Click);
            this.txtName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtName.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtName.Location = new Point(0x141, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(0x166, 0x17);
            this.txtName.TabIndex = 2;
            this.btnGenSitemap.DialogResult = DialogResult.Cancel;
            this.btnGenSitemap.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnGenSitemap.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnGenSitemap.Location = new Point(0xb7, 0x1b2);
            this.btnGenSitemap.Name = "btnGenSitemap";
            this.btnGenSitemap.Size = new Size(0x9b, 0x1f);
            this.btnGenSitemap.TabIndex = 9;
            this.btnGenSitemap.Text = "Tạo Sitemap Theo Link";
            this.btnGenSitemap.UseVisualStyleBackColor = true;
            this.btnGenSitemap.Click += new EventHandler(this.btnGenSitemap_Click);
            this.btnGenSitemapAuto.DialogResult = DialogResult.Cancel;
            this.btnGenSitemapAuto.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnGenSitemapAuto.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnGenSitemapAuto.Location = new Point(0x158, 0x1b2);
            this.btnGenSitemapAuto.Name = "btnGenSitemapAuto";
            this.btnGenSitemapAuto.Size = new Size(0x8a, 0x1f);
            this.btnGenSitemapAuto.TabIndex = 10;
            this.btnGenSitemapAuto.Text = "Tạo Sitemap tự động";
            this.btnGenSitemapAuto.UseVisualStyleBackColor = true;
            this.btnGenSitemapAuto.Click += new EventHandler(this.btnGenSitemapAuto_Click);
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label2.Location = new Point(0x48, 0x1b9);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x69, 0x10);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tạo Sitemap.xml";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label3.Location = new Point(0x1e8, 0x1b9);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x3a, 0x10);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tạo RSS";
            this.btnGenRSS.DialogResult = DialogResult.Cancel;
            this.btnGenRSS.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnGenRSS.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnGenRSS.Location = new Point(0x228, 0x1b2);
            this.btnGenRSS.Name = "btnGenRSS";
            this.btnGenRSS.Size = new Size(0x7d, 0x1f);
            this.btnGenRSS.TabIndex = 11;
            this.btnGenRSS.Text = "Tạo RSS Theo Link";
            this.btnGenRSS.UseVisualStyleBackColor = true;
            this.btnGenRSS.Click += new EventHandler(this.btnGenRSS_Click);
            this.btnGenRSSAuto.DialogResult = DialogResult.Cancel;
            this.btnGenRSSAuto.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnGenRSSAuto.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnGenRSSAuto.Location = new Point(0x2ab, 0x1b2);
            this.btnGenRSSAuto.Name = "btnGenRSSAuto";
            this.btnGenRSSAuto.Size = new Size(0x7e, 0x1f);
            this.btnGenRSSAuto.TabIndex = 12;
            this.btnGenRSSAuto.Text = "Tạo RSS tự động";
            this.btnGenRSSAuto.UseVisualStyleBackColor = true;
            this.btnGenRSSAuto.Click += new EventHandler(this.btnGenRSSAuto_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x335, 0x1dd);
            base.Controls.Add(this.btnGenRSSAuto);
            base.Controls.Add(this.btnGenSitemapAuto);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.btnGenRSS);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.btnGenSitemap);
            base.Controls.Add(this.groupBox8);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.picLoader);
            base.Controls.Add(this.toolBar);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmSitemap";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản l\x00fd Sitemap && RSS";
            base.Load += new EventHandler(this.frmSitemap_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((ISupportInitialize) this.picLoader).EndInit();
            ((ISupportInitialize) this.dtvName).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            ((ISupportInitialize) this.btnSitemapDelete).EndInit();
            ((ISupportInitialize) this.btnSitemapEdit).EndInit();
            ((ISupportInitialize) this.btnSitemapAdd).EndInit();
            ((ISupportInitialize) this.btnSitemapSearch).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0()
        {
            try
            {
                string str = "SELECT * FROM Sitemaps ORDER BY Name";
                if (this.bool_0)
                {
                    str = "SELECT * FROM Sitemaps WHERE Name LIKE '%" + this.txtName.Text.Trim() + "%' ORDER BY Name";
                }
                DataTable table = this.gclass4_0.method_40(str);
                this.dtvName.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    object[] values = new object[] { row["SitemapID"].ToString(), row["Name"].ToString(), row["ListUrl"].ToString() };
                    int num = this.dtvName.Rows.Add(values);
                    this.dtvName.Rows[num].Tag = row;
                }
            }
            catch
            {
            }
        }

        private void method_1()
        {
            try
            {
                Class51 class2 = new Class51 {
                    frmSitemap_0 = this,
                    string_0 = string.Empty
                };
                MethodInvoker method = new MethodInvoker(class2.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_2()
        {
            try
            {
                Class52 class3 = new Class52 {
                    frmSitemap_0 = this,
                    string_0 = string.Empty
                };
                foreach (string str in this.list_0)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        GClass7 class2 = this.gclass4_0.method_0(this.gclass4_0.method_38(str));
                        string[] strArray = new string[] { class3.string_0, "<item>\r\n<title><![CDATA[ ", class2.method_0(), " ]]></title>\r\n<link><![CDATA[ ", str, " ]]></link>\r\n<description><![CDATA[ ", class2.method_2(), " ]]></description>\r\n</item>" };
                        class3.string_0 = string.Concat(strArray);
                    }
                }
                MethodInvoker method = new MethodInvoker(class3.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_3()
        {
            try
            {
                Class53 class3 = new Class53 {
                    frmSitemap_0 = this,
                    string_0 = string.Empty
                };
                List<string> list = new List<string>();
                foreach (string str in this.list_0)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        list.Add(str);
                        if (func_0 == null)
                        {
                            func_0 = new Func<GClass9, bool>(frmSitemap.smethod_0);
                        }
                        using (List<GClass9>.Enumerator enumerator2 = this.gclass4_0.method_10(this.gclass4_0.method_38(str), str, string.Empty).Where<GClass9>(func_0).ToList<GClass9>().GetEnumerator())
                        {
                            Class54 class2 = new Class54 {
                                class53_0 = class3
                            };
                            while (enumerator2.MoveNext())
                            {
                                class2.gclass9_0 = enumerator2.Current;
                                if (list.FindIndex(new Predicate<string>(class2.method_0)) < 0)
                                {
                                    list.Add(class2.gclass9_0.method_4());
                                }
                            }
                        }
                    }
                }
                foreach (string str2 in list)
                {
                    class3.string_0 = class3.string_0 + "<url><loc>" + str2 + "</loc></url>";
                }
                MethodInvoker method = new MethodInvoker(class3.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void method_4()
        {
            try
            {
                Class55 class4 = new Class55 {
                    frmSitemap_0 = this,
                    string_0 = string.Empty
                };
                List<string> list = new List<string>();
                foreach (string str in this.list_0)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        list.Add(str);
                        if (func_1 == null)
                        {
                            func_1 = new Func<GClass9, bool>(frmSitemap.smethod_1);
                        }
                        using (List<GClass9>.Enumerator enumerator2 = this.gclass4_0.method_10(this.gclass4_0.method_38(str), str, string.Empty).Where<GClass9>(func_1).ToList<GClass9>().GetEnumerator())
                        {
                            Class56 class2 = new Class56 {
                                class55_0 = class4
                            };
                            while (enumerator2.MoveNext())
                            {
                                class2.gclass9_0 = enumerator2.Current;
                                if (list.FindIndex(new Predicate<string>(class2.method_0)) < 0)
                                {
                                    list.Add(class2.gclass9_0.method_4());
                                }
                            }
                        }
                    }
                }
                foreach (string str2 in list)
                {
                    GClass7 class3 = this.gclass4_0.method_0(this.gclass4_0.method_38(str2));
                    string str3 = class4.string_0;
                    string[] strArray = new string[] { str3, "<item>\r\n<title><![CDATA[ ", class3.method_0().Replace("<![CDATA[", "").Replace("]]>", "").Trim(), " ]]></title>\r\n<link><![CDATA[ ", str2, " ]]></link>\r\n<description><![CDATA[ ", class3.method_2(), " ]]></description>\r\n</item>" };
                    class4.string_0 = string.Concat(strArray);
                }
                MethodInvoker method = new MethodInvoker(class4.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        [CompilerGenerated]
        private static bool smethod_0(GClass9 gclass9_0) => 
            (gclass9_0.method_12() == "Internal") && (gclass9_0.method_8().IndexOf("nofollow") < 0);

        [CompilerGenerated]
        private static bool smethod_1(GClass9 gclass9_0) => 
            (gclass9_0.method_12() == "Internal") && (gclass9_0.method_8().IndexOf("nofollow") < 0);

        [CompilerGenerated]
        private sealed class Class51
        {
            public string string_0;
            public frmSitemap frmSitemap_0;

            public void method_0()
            {
                Stream stream;
                foreach (string str in this.frmSitemap_0.list_0)
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        this.string_0 = this.string_0 + "<url><loc>" + str + "</loc></url>";
                    }
                }
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "Sitemap.xml (*.xml)|*.xml",
                    FileName = "sitemap.xml",
                    Title = "Type File"
                };
                if ((dialog.ShowDialog() == DialogResult.OK) && ((stream = dialog.OpenFile()) != null))
                {
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(this.frmSitemap_0.string_1.Replace("$content$", this.string_0));
                    writer.Flush();
                    stream.Close();
                    MessageBox.Show("Ghi File th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.frmSitemap_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class52
        {
            public string string_0;
            public frmSitemap frmSitemap_0;

            public void method_0()
            {
                Stream stream;
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "feed.xml (*.xml)|*.xml",
                    FileName = "feed.xml",
                    Title = "Type File"
                };
                if ((dialog.ShowDialog() == DialogResult.OK) && ((stream = dialog.OpenFile()) != null))
                {
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(this.frmSitemap_0.string_0.Replace("$content$", this.string_0));
                    writer.Flush();
                    stream.Close();
                    MessageBox.Show("Ghi File th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.frmSitemap_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class53
        {
            public string string_0;
            public frmSitemap frmSitemap_0;

            public void method_0()
            {
                Stream stream;
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "Sitemap.xml (*.xml)|*.xml",
                    FileName = "sitemap.xml",
                    Title = "Type File"
                };
                if ((dialog.ShowDialog() == DialogResult.OK) && ((stream = dialog.OpenFile()) != null))
                {
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(this.frmSitemap_0.string_1.Replace("$content$", this.string_0));
                    writer.Flush();
                    stream.Close();
                    MessageBox.Show("Ghi File th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.frmSitemap_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class54
        {
            public frmSitemap.Class53 class53_0;
            public GClass9 gclass9_0;

            public bool method_0(string string_0) => 
                string_0 == this.gclass9_0.method_4();
        }

        [CompilerGenerated]
        private sealed class Class55
        {
            public string string_0;
            public frmSitemap frmSitemap_0;

            public void method_0()
            {
                Stream stream;
                SaveFileDialog dialog = new SaveFileDialog {
                    Filter = "Feed.xml (*.xml)|*.xml",
                    FileName = "feed.xml",
                    Title = "Type File"
                };
                if ((dialog.ShowDialog() == DialogResult.OK) && ((stream = dialog.OpenFile()) != null))
                {
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(this.frmSitemap_0.string_0.Replace("$content$", this.string_0));
                    writer.Flush();
                    stream.Close();
                    MessageBox.Show("Ghi File th\x00e0nh c\x00f4ng!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.frmSitemap_0.picLoader.Hide();
            }
        }

        [CompilerGenerated]
        private sealed class Class56
        {
            public frmSitemap.Class55 class55_0;
            public GClass9 gclass9_0;

            public bool method_0(string string_0) => 
                string_0 == this.gclass9_0.method_4();
        }
    }
}

