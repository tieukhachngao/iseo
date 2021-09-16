namespace iSEO
{
    using iSEO.Properties;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class frmContent : Form
    {
        private IContainer icontainer_0;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;
        private GroupBox groupBox30;
        private PictureBox btnContentGroupAdd;
        private DataGridView dtvContentTitle;
        private GroupBox groupBox1;
        private TextBox txtContentTitle;
        private WebBrowser txtContentwebEditor;
        private PictureBox btnContentDelete;
        private PictureBox btnContentEdit;
        private PictureBox btnContentAdd;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private ComboBox cbContentCate;
        private Label label4;
        private Button btnHTMLCode;
        private Button btnHTMLBBcode;
        private GClass4 gclass4_0 = new GClass4();
        private bool bool_0;

        public frmContent()
        {
            this.InitializeComponent();
            this.method_0();
        }

        private void btnContentAdd_Click(object sender, EventArgs e)
        {
            MethodInvoker invoker2 = null;
            try
            {
                if ((this.cbContentCate.SelectedValue == null) || (string.IsNullOrEmpty(this.cbContentCate.SelectedValue.ToString()) || string.IsNullOrEmpty(this.txtContentTitle.Text.Trim())))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Contents ([ContentID], [CategoryID], [Title], [Content]) VALUES('", Guid.NewGuid(), "','", this.cbContentCate.SelectedValue, "','", this.txtContentTitle.Text.Trim(), "','", this.method_3("GetContents", new object[0]).ToString(), "')" };
                    string str = string.Concat(objArray);
                    this.gclass4_0.method_42(str);
                    this.method_2();
                    this.txtContentTitle.Text = string.Empty;
                    invoker2 ??= new MethodInvoker(this.method_4);
                    MethodInvoker method = invoker2;
                    if (base.InvokeRequired)
                    {
                        base.BeginInvoke(method);
                    }
                    else
                    {
                        method();
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnContentDelete_Click(object sender, EventArgs e)
        {
            MethodInvoker invoker2 = null;
            try
            {
                this.gclass4_0.method_42("DELETE FROM Contents WHERE ContentID='" + this.dtvContentTitle.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_2();
                this.txtContentTitle.Text = string.Empty;
                invoker2 ??= new MethodInvoker(this.method_5);
                MethodInvoker method = invoker2;
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

        private void btnContentEdit_Click(object sender, EventArgs e)
        {
            MethodInvoker invoker2 = null;
            try
            {
                if (this.bool_0)
                {
                    if ((this.cbContentCate.SelectedValue == null) || (string.IsNullOrEmpty(this.cbContentCate.SelectedValue.ToString()) || string.IsNullOrEmpty(this.txtContentTitle.Text.Trim())))
                    {
                        MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        string[] strArray = new string[] { "UPDATE Contents SET [Title]='", this.txtContentTitle.Text.Trim(), "' , [Content]='", this.method_3("GetContents", new object[0]).ToString(), "' WHERE [ContentID]='", this.dtvContentTitle.CurrentRow.Cells[0].Value.ToString(), "'" };
                        string str = string.Concat(strArray);
                        this.gclass4_0.method_42(str);
                        this.method_2();
                        this.txtContentTitle.Text = string.Empty;
                        invoker2 ??= new MethodInvoker(this.method_6);
                        MethodInvoker method = invoker2;
                        if (base.InvokeRequired)
                        {
                            base.BeginInvoke(method);
                        }
                        else
                        {
                            method();
                        }
                        this.bool_0 = false;
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnContentGroupAdd_Click(object sender, EventArgs e)
        {
            new frmCategory { string_0 = "CONTENT" }.ShowDialog();
            this.method_1();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnHTMLBBcode_Click(object sender, EventArgs e)
        {
            this.method_3("BBcode", new object[0]);
        }

        private void btnHTMLCode_Click(object sender, EventArgs e)
        {
            this.method_3("HTMLCode", new object[0]);
        }

        private void cbContentCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.method_2();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dtvContentTitle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Class3 class2 = new Class3 {
                    frmContent_0 = this
                };
                string str = "SELECT [Title], [Content] FROM Contents WHERE [ContentID]='" + this.dtvContentTitle.CurrentRow.Cells[0].Value.ToString() + "'";
                DataTable table = this.gclass4_0.method_40(str);
                class2.string_0 = "";
                using (IEnumerator enumerator = table.Rows.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow) enumerator.Current;
                        this.txtContentTitle.Text = current["Title"].ToString();
                        class2.string_0 = current["Content"].ToString();
                    }
                }
                MethodInvoker method = new MethodInvoker(class2.method_0);
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(method);
                }
                else
                {
                    method();
                }
                this.bool_0 = true;
            }
            catch
            {
            }
        }

        private void dtvContentTitle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvContentTitle.RowHeadersDefaultCellStyle.ForeColor))
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmContent));
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.groupBox30 = new GroupBox();
            this.cbContentCate = new ComboBox();
            this.btnContentGroupAdd = new PictureBox();
            this.dtvContentTitle = new DataGridView();
            this.dataGridViewTextBoxColumn45 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new DataGridViewTextBoxColumn();
            this.groupBox1 = new GroupBox();
            this.btnHTMLCode = new Button();
            this.btnHTMLBBcode = new Button();
            this.label4 = new Label();
            this.btnContentDelete = new PictureBox();
            this.btnContentEdit = new PictureBox();
            this.btnContentAdd = new PictureBox();
            this.txtContentwebEditor = new WebBrowser();
            this.txtContentTitle = new TextBox();
            this.toolBar.SuspendLayout();
            this.groupBox30.SuspendLayout();
            ((ISupportInitialize) this.btnContentGroupAdd).BeginInit();
            ((ISupportInitialize) this.dtvContentTitle).BeginInit();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize) this.btnContentDelete).BeginInit();
            ((ISupportInitialize) this.btnContentEdit).BeginInit();
            ((ISupportInitialize) this.btnContentAdd).BeginInit();
            base.SuspendLayout();
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x42f, 0x19);
            this.toolBar.TabIndex = 0x13;
            this.toolBar.Text = "toolBar";
            this.btnExit.Alignment = ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = Resources.smethod_4();
            this.btnExit.ImageTransparentColor = Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x17, 0x16);
            this.btnExit.Text = "f";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.toolStripLabel3.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.toolStripLabel3.ForeColor = Color.White;
            this.toolStripLabel3.Image = Resources.smethod_21();
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new Size(0x80, 0x16);
            this.toolStripLabel3.Text = "Quản l\x00fd nội dung";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            this.groupBox30.Controls.Add(this.cbContentCate);
            this.groupBox30.Controls.Add(this.btnContentGroupAdd);
            this.groupBox30.Controls.Add(this.dtvContentTitle);
            this.groupBox30.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox30.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox30.Location = new Point(7, 0x1c);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new Size(0xd3, 0x23b);
            this.groupBox30.TabIndex = 30;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Nh\x00f3m nội dung";
            this.cbContentCate.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.cbContentCate.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbContentCate.FlatStyle = FlatStyle.Popup;
            this.cbContentCate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cbContentCate.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.cbContentCate.FormattingEnabled = true;
            this.cbContentCate.Location = new Point(6, 0x12);
            this.cbContentCate.Name = "cbContentCate";
            this.cbContentCate.Size = new Size(0xa9, 0x18);
            this.cbContentCate.TabIndex = 1;
            this.cbContentCate.SelectedIndexChanged += new EventHandler(this.cbContentCate_SelectedIndexChanged);
            this.btnContentGroupAdd.BackColor = SystemColors.Control;
            this.btnContentGroupAdd.Cursor = Cursors.Hand;
            this.btnContentGroupAdd.Image = Resources.smethod_14();
            this.btnContentGroupAdd.Location = new Point(0xb5, 0x13);
            this.btnContentGroupAdd.Name = "btnContentGroupAdd";
            this.btnContentGroupAdd.Size = new Size(0x16, 0x16);
            this.btnContentGroupAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnContentGroupAdd.TabIndex = 20;
            this.btnContentGroupAdd.TabStop = false;
            this.btnContentGroupAdd.Click += new EventHandler(this.btnContentGroupAdd_Click);
            this.dtvContentTitle.AllowUserToAddRows = false;
            this.dtvContentTitle.AllowUserToDeleteRows = false;
            this.dtvContentTitle.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvContentTitle.AlternatingRowsDefaultCellStyle = style;
            this.dtvContentTitle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvContentTitle.BackgroundColor = Color.White;
            this.dtvContentTitle.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dtvContentTitle.ColumnHeadersDefaultCellStyle = style2;
            this.dtvContentTitle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn45, this.dataGridViewTextBoxColumn46 };
            this.dtvContentTitle.Columns.AddRange(dataGridViewColumns);
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.FromArgb(0, 0, 0x40);
            style3.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style3.SelectionForeColor = Color.White;
            style3.WrapMode = DataGridViewTriState.False;
            this.dtvContentTitle.DefaultCellStyle = style3;
            this.dtvContentTitle.Location = new Point(6, 0x30);
            this.dtvContentTitle.MultiSelect = false;
            this.dtvContentTitle.Name = "dtvContentTitle";
            this.dtvContentTitle.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.HighlightText;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dtvContentTitle.RowHeadersDefaultCellStyle = style4;
            this.dtvContentTitle.RowHeadersWidth = 30;
            this.dtvContentTitle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvContentTitle.Size = new Size(0xc4, 0x205);
            this.dtvContentTitle.TabIndex = 3;
            this.dtvContentTitle.CellClick += new DataGridViewCellEventHandler(this.dtvContentTitle_CellClick);
            this.dtvContentTitle.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvContentTitle_RowPostPaint);
            this.dataGridViewTextBoxColumn45.HeaderText = "ID";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Visible = false;
            this.dataGridViewTextBoxColumn46.HeaderText = "Ti\x00eau đề";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.groupBox1.Controls.Add(this.btnHTMLCode);
            this.groupBox1.Controls.Add(this.btnHTMLBBcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnContentDelete);
            this.groupBox1.Controls.Add(this.btnContentEdit);
            this.groupBox1.Controls.Add(this.btnContentAdd);
            this.groupBox1.Controls.Add(this.txtContentwebEditor);
            this.groupBox1.Controls.Add(this.txtContentTitle);
            this.groupBox1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox1.Location = new Point(0xe0, 0x1c);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x346, 0x23b);
            this.groupBox1.TabIndex = 0x24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung";
            this.btnHTMLCode.DialogResult = DialogResult.Cancel;
            this.btnHTMLCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLCode.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLCode.Location = new Point(0x2d9, 0x56);
            this.btnHTMLCode.Name = "btnHTMLCode";
            this.btnHTMLCode.Size = new Size(0x4f, 0x1a);
            this.btnHTMLCode.TabIndex = 0x30;
            this.btnHTMLCode.Text = "HTML";
            this.btnHTMLCode.UseVisualStyleBackColor = true;
            this.btnHTMLCode.Click += new EventHandler(this.btnHTMLCode_Click);
            this.btnHTMLBBcode.DialogResult = DialogResult.Cancel;
            this.btnHTMLBBcode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnHTMLBBcode.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnHTMLBBcode.Location = new Point(0x2d9, 0x39);
            this.btnHTMLBBcode.Name = "btnHTMLBBcode";
            this.btnHTMLBBcode.Size = new Size(0x4f, 0x1a);
            this.btnHTMLBBcode.TabIndex = 0x2f;
            this.btnHTMLBBcode.Text = "BBCode";
            this.btnHTMLBBcode.UseVisualStyleBackColor = true;
            this.btnHTMLBBcode.Click += new EventHandler(this.btnHTMLBBcode_Click);
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label4.Location = new Point(6, 0x17);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x33, 0x10);
            this.label4.TabIndex = 0x2e;
            this.label4.Text = "Ti\x00eau đề";
            this.btnContentDelete.BackColor = SystemColors.Control;
            this.btnContentDelete.Cursor = Cursors.Hand;
            this.btnContentDelete.Image = Resources.smethod_12();
            this.btnContentDelete.Location = new Point(0x328, 0x15);
            this.btnContentDelete.Name = "btnContentDelete";
            this.btnContentDelete.Size = new Size(0x16, 0x16);
            this.btnContentDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btnContentDelete.TabIndex = 0x2d;
            this.btnContentDelete.TabStop = false;
            this.btnContentDelete.Click += new EventHandler(this.btnContentDelete_Click);
            this.btnContentEdit.BackColor = SystemColors.Control;
            this.btnContentEdit.Cursor = Cursors.Hand;
            this.btnContentEdit.Image = Resources.smethod_15();
            this.btnContentEdit.Location = new Point(780, 0x15);
            this.btnContentEdit.Name = "btnContentEdit";
            this.btnContentEdit.Size = new Size(0x16, 0x16);
            this.btnContentEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnContentEdit.TabIndex = 0x2c;
            this.btnContentEdit.TabStop = false;
            this.btnContentEdit.Click += new EventHandler(this.btnContentEdit_Click);
            this.btnContentAdd.BackColor = SystemColors.Control;
            this.btnContentAdd.Cursor = Cursors.Hand;
            this.btnContentAdd.Image = Resources.smethod_14();
            this.btnContentAdd.Location = new Point(0x2f0, 0x15);
            this.btnContentAdd.Name = "btnContentAdd";
            this.btnContentAdd.Size = new Size(0x16, 0x16);
            this.btnContentAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnContentAdd.TabIndex = 0x2b;
            this.btnContentAdd.TabStop = false;
            this.btnContentAdd.Click += new EventHandler(this.btnContentAdd_Click);
            this.txtContentwebEditor.Location = new Point(6, 0x31);
            this.txtContentwebEditor.MinimumSize = new Size(20, 20);
            this.txtContentwebEditor.Name = "txtContentwebEditor";
            this.txtContentwebEditor.ScriptErrorsSuppressed = true;
            this.txtContentwebEditor.Size = new Size(0x339, 0x204);
            this.txtContentwebEditor.TabIndex = 8;
            this.txtContentwebEditor.Url = new Uri("http://igoo.vn/editor.html", UriKind.Absolute);
            this.txtContentTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtContentTitle.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtContentTitle.Location = new Point(0x43, 20);
            this.txtContentTitle.Name = "txtContentTitle";
            this.txtContentTitle.Size = new Size(0x2a7, 0x17);
            this.txtContentTitle.TabIndex = 4;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x42f, 0x260);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox30);
            base.Controls.Add(this.toolBar);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmContent";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản l\x00fd Nội dung";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            ((ISupportInitialize) this.btnContentGroupAdd).EndInit();
            ((ISupportInitialize) this.dtvContentTitle).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((ISupportInitialize) this.btnContentDelete).EndInit();
            ((ISupportInitialize) this.btnContentEdit).EndInit();
            ((ISupportInitialize) this.btnContentAdd).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0()
        {
            this.bool_0 = false;
            this.method_1();
            this.method_2();
        }

        private void method_1()
        {
            string str = "SELECT CategoryID, Name FROM Categories WHERE Code = 'CONTENT' ORDER BY Name";
            DataTable table = this.gclass4_0.method_40(str);
            this.cbContentCate.DataSource = table;
            this.cbContentCate.ValueMember = "CategoryID";
            this.cbContentCate.DisplayMember = "Name";
        }

        private void method_2()
        {
            string str = "SELECT [ContentID], [Title] FROM Contents WHERE [CategoryID]='" + this.cbContentCate.SelectedValue + "'";
            DataTable table = this.gclass4_0.method_40(str);
            this.dtvContentTitle.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                object[] values = new object[] { row["ContentID"].ToString(), row["Title"].ToString() };
                int num = this.dtvContentTitle.Rows.Add(values);
                this.dtvContentTitle.Rows[num].Tag = row;
            }
        }

        private object method_3(string string_0, params object[] object_0) => 
            this.txtContentwebEditor.Document.InvokeScript(string_0, object_0);

        [CompilerGenerated]
        private void method_4()
        {
            object[] objArray = new object[] { "" };
            this.method_3("SetContents", objArray);
        }

        [CompilerGenerated]
        private void method_5()
        {
            object[] objArray = new object[] { "" };
            this.method_3("SetContents", objArray);
        }

        [CompilerGenerated]
        private void method_6()
        {
            object[] objArray = new object[] { "" };
            this.method_3("SetContents", objArray);
        }

        [CompilerGenerated]
        private sealed class Class3
        {
            public string string_0;
            public frmContent frmContent_0;

            public void method_0()
            {
                object[] objArray = new object[] { this.string_0 };
                this.frmContent_0.method_3("SetContents", objArray);
            }
        }
    }
}

