namespace iSEO
{
    using iSEO.Properties;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmAttribute : Form
    {
        public string string_0 = string.Empty;
        private GClass4 gclass4_0 = new GClass4();
        private IContainer icontainer_0;
        private GroupBox groupBox8;
        private RichTextBox txtAttributeValue;
        private PictureBox btAttributeDelete;
        private PictureBox btnAttributeEdit;
        private PictureBox btnAttributeAdd;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;
        private DataGridView dtvAttribute;
        private Label label2;
        private TextBox txtAttributeName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;

        public frmAttribute(string attributeSelect)
        {
            this.InitializeComponent();
            this.string_0 = attributeSelect;
            this.method_0();
        }

        private void btAttributeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gclass4_0.method_42("DELETE FROM Attributes WHERE AttributeID='" + this.dtvAttribute.CurrentRow.Cells[0].Value.ToString() + "'");
                this.method_0();
                this.txtAttributeName.Text = string.Empty;
                this.txtAttributeValue.Text = string.Empty;
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAttributeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtAttributeName.Text.Trim()))
                {
                    MessageBox.Show("H\x00e3y nhập đủ th\x00f4ng tin!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    object[] objArray = new object[] { "INSERT INTO Attributes (AttributeID , Name, [Value]) VALUES('", Guid.NewGuid(), "','", this.txtAttributeName.Text.Trim(), "',@Value)" };
                    string str = string.Concat(objArray);
                    object[] objArray2 = new object[] { "@Value", this.txtAttributeValue.Text.Trim() };
                    this.gclass4_0.method_43(str, CommandType.Text, objArray2);
                    this.method_0();
                    this.txtAttributeName.Text = string.Empty;
                    this.txtAttributeValue.Text = string.Empty;
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAttributeEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strArray = new string[] { "UPDATE Attributes SET Name='", this.txtAttributeName.Text.Trim(), "', [Value]=@Value WHERE AttributeID='", this.dtvAttribute.CurrentRow.Cells[0].Value.ToString(), "'" };
                string str = string.Concat(strArray);
                object[] objArray = new object[] { "@Value", this.txtAttributeValue.Text.Trim() };
                this.gclass4_0.method_43(str, CommandType.Text, objArray);
                this.method_0();
                this.txtAttributeName.Text = string.Empty;
                this.txtAttributeValue.Text = string.Empty;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dtvAttribute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.method_3();
        }

        private void dtvAttribute_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAttribute.RowHeadersDefaultCellStyle.ForeColor))
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmAttribute));
            this.groupBox8 = new GroupBox();
            this.dtvAttribute = new DataGridView();
            this.ID = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new DataGridViewTextBoxColumn();
            this.btAttributeDelete = new PictureBox();
            this.btnAttributeEdit = new PictureBox();
            this.btnAttributeAdd = new PictureBox();
            this.txtAttributeValue = new RichTextBox();
            this.label2 = new Label();
            this.txtAttributeName = new TextBox();
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.groupBox8.SuspendLayout();
            ((ISupportInitialize) this.dtvAttribute).BeginInit();
            ((ISupportInitialize) this.btAttributeDelete).BeginInit();
            ((ISupportInitialize) this.btnAttributeEdit).BeginInit();
            ((ISupportInitialize) this.btnAttributeAdd).BeginInit();
            this.toolBar.SuspendLayout();
            base.SuspendLayout();
            this.groupBox8.Controls.Add(this.dtvAttribute);
            this.groupBox8.Controls.Add(this.btAttributeDelete);
            this.groupBox8.Controls.Add(this.btnAttributeEdit);
            this.groupBox8.Controls.Add(this.btnAttributeAdd);
            this.groupBox8.Controls.Add(this.txtAttributeValue);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.txtAttributeName);
            this.groupBox8.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox8.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox8.Location = new Point(12, 0x1c);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new Size(0x342, 0x25d);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Quản l\x00fd thuộc t\x00ednh";
            this.dtvAttribute.AllowUserToAddRows = false;
            this.dtvAttribute.AllowUserToDeleteRows = false;
            this.dtvAttribute.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvAttribute.AlternatingRowsDefaultCellStyle = style;
            this.dtvAttribute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAttribute.BackgroundColor = Color.White;
            this.dtvAttribute.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dtvAttribute.ColumnHeadersDefaultCellStyle = style2;
            this.dtvAttribute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.ID, this.dataGridViewTextBoxColumn46 };
            this.dtvAttribute.Columns.AddRange(dataGridViewColumns);
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.FromArgb(0, 0, 0x40);
            style3.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style3.SelectionForeColor = Color.White;
            style3.WrapMode = DataGridViewTriState.False;
            this.dtvAttribute.DefaultCellStyle = style3;
            this.dtvAttribute.Location = new Point(6, 0x18);
            this.dtvAttribute.MultiSelect = false;
            this.dtvAttribute.Name = "dtvAttribute";
            this.dtvAttribute.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.HighlightText;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dtvAttribute.RowHeadersDefaultCellStyle = style4;
            this.dtvAttribute.RowHeadersWidth = 30;
            this.dtvAttribute.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvAttribute.Size = new Size(0xd7, 0x235);
            this.dtvAttribute.TabIndex = 1;
            this.dtvAttribute.CellClick += new DataGridViewCellEventHandler(this.dtvAttribute_CellClick);
            this.dtvAttribute.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvAttribute_RowPostPaint);
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.dataGridViewTextBoxColumn46.HeaderText = "Danh mục";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.btAttributeDelete.BackColor = SystemColors.Control;
            this.btAttributeDelete.Cursor = Cursors.Hand;
            this.btAttributeDelete.Image = Resources.smethod_12();
            this.btAttributeDelete.Location = new Point(0x325, 0x18);
            this.btAttributeDelete.Name = "btAttributeDelete";
            this.btAttributeDelete.Size = new Size(0x16, 0x16);
            this.btAttributeDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            this.btAttributeDelete.TabIndex = 0x22;
            this.btAttributeDelete.TabStop = false;
            this.btAttributeDelete.Click += new EventHandler(this.btAttributeDelete_Click);
            this.btnAttributeEdit.BackColor = SystemColors.Control;
            this.btnAttributeEdit.Cursor = Cursors.Hand;
            this.btnAttributeEdit.Image = Resources.smethod_15();
            this.btnAttributeEdit.Location = new Point(0x309, 0x18);
            this.btnAttributeEdit.Name = "btnAttributeEdit";
            this.btnAttributeEdit.Size = new Size(0x16, 0x16);
            this.btnAttributeEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAttributeEdit.TabIndex = 0x21;
            this.btnAttributeEdit.TabStop = false;
            this.btnAttributeEdit.Click += new EventHandler(this.btnAttributeEdit_Click);
            this.btnAttributeAdd.BackColor = SystemColors.Control;
            this.btnAttributeAdd.Cursor = Cursors.Hand;
            this.btnAttributeAdd.Image = Resources.smethod_14();
            this.btnAttributeAdd.Location = new Point(0x2ed, 0x18);
            this.btnAttributeAdd.Name = "btnAttributeAdd";
            this.btnAttributeAdd.Size = new Size(0x16, 0x16);
            this.btnAttributeAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            this.btnAttributeAdd.TabIndex = 0x20;
            this.btnAttributeAdd.TabStop = false;
            this.btnAttributeAdd.Click += new EventHandler(this.btnAttributeAdd_Click);
            this.txtAttributeValue.BorderStyle = BorderStyle.None;
            this.txtAttributeValue.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAttributeValue.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAttributeValue.Location = new Point(0xe3, 0x35);
            this.txtAttributeValue.Name = "txtAttributeValue";
            this.txtAttributeValue.Size = new Size(600, 0x218);
            this.txtAttributeValue.TabIndex = 8;
            this.txtAttributeValue.Text = " ";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.label2.Location = new Point(0xe3, 0x1a);
            this.label2.Name = "label2";
            this.label2.Size = new Size(30, 0x10);
            this.label2.TabIndex = 0x1b;
            this.label2.Text = "T\x00ean";
            this.txtAttributeName.BorderStyle = BorderStyle.FixedSingle;
            this.txtAttributeName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAttributeName.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtAttributeName.Location = new Point(0x123, 0x18);
            this.txtAttributeName.Name = "txtAttributeName";
            this.txtAttributeName.Size = new Size(0x1c4, 0x17);
            this.txtAttributeName.TabIndex = 2;
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x35a, 0x19);
            this.toolBar.TabIndex = 0x10;
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
            this.toolStripLabel3.Size = new Size(0x8a, 0x16);
            this.toolStripLabel3.Text = "Quản l\x00fd thuộc t\x00ednh";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x35a, 0x285);
            base.Controls.Add(this.toolBar);
            base.Controls.Add(this.groupBox8);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmAttribute";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản l\x00fd thuộc t\x00ednh";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((ISupportInitialize) this.dtvAttribute).EndInit();
            ((ISupportInitialize) this.btAttributeDelete).EndInit();
            ((ISupportInitialize) this.btnAttributeEdit).EndInit();
            ((ISupportInitialize) this.btnAttributeAdd).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0()
        {
            try
            {
                string str = "SELECT * FROM Attributes ORDER BY Name";
                this.dtvAttribute.Rows.Clear();
                int num = -1;
                int num2 = 0;
                foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
                {
                    if (row["AttributeID"].ToString().Equals(this.string_0))
                    {
                        num = num2;
                    }
                    object[] values = new object[] { row["AttributeID"].ToString(), row["Name"].ToString() };
                    int num3 = this.dtvAttribute.Rows.Add(values);
                    this.dtvAttribute.Rows[num3].Tag = row;
                    num2++;
                }
                if (num > -1)
                {
                    this.dtvAttribute.Rows[num].Selected = true;
                    this.dtvAttribute.Rows[num].Cells[1].Selected = true;
                    this.dtvAttribute.FirstDisplayedScrollingRowIndex = num;
                    this.method_3();
                }
            }
            catch
            {
            }
        }

        private void method_1(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void method_2(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvAttribute.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, brush, (float) (e.RowBounds.Location.X + 10), (float) (e.RowBounds.Location.Y + 4));
            }
        }

        private void method_3()
        {
            try
            {
                string str = "SELECT AttributeID, Name, Value  FROM Attributes WHERE AttributeID = '" + this.dtvAttribute.CurrentRow.Cells[0].Value.ToString() + "'";
                foreach (DataRow row in this.gclass4_0.method_40(str).Rows)
                {
                    this.txtAttributeName.Text = row["Name"].ToString();
                    this.txtAttributeValue.Text = row["Value"].ToString();
                }
            }
            catch
            {
            }
        }
    }
}

