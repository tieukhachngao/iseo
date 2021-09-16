namespace iSEO
{
    using iSEO.Properties;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmSERP : Form
    {
        private IContainer icontainer_0;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewLinkColumn Column11;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column7;
        public DataGridView dtvSERP;
        public ToolStripLabel lbResult;

        public frmSERP()
        {
            this.InitializeComponent();
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

        private void dtvSERP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dtvSERP.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    Process.Start(this.dtvSERP[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
            }
            catch
            {
            }
        }

        private void dtvSERP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.dtvSERP.RowHeadersDefaultCellStyle.ForeColor))
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmSERP));
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.lbResult = new ToolStripLabel();
            this.dtvSERP = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column11 = new DataGridViewLinkColumn();
            this.Column9 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.toolBar.SuspendLayout();
            ((ISupportInitialize) this.dtvSERP).BeginInit();
            base.SuspendLayout();
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.lbResult };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x3e8, 0x19);
            this.toolBar.TabIndex = 4;
            this.toolBar.Text = "toolBar";
            this.btnExit.Alignment = ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = Resources.smethod_4();
            this.btnExit.ImageTransparentColor = Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x17, 0x16);
            this.btnExit.Text = "toolStripButton1";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.lbResult.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbResult.ForeColor = Color.White;
            this.lbResult.Image = Resources.smethod_21();
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new Size(0xc2, 0x16);
            this.lbResult.Text = "Độ cạnh tranh của từ kho\x00e1!";
            this.lbResult.TextAlign = ContentAlignment.MiddleRight;
            this.dtvSERP.AllowUserToAddRows = false;
            this.dtvSERP.AllowUserToDeleteRows = false;
            this.dtvSERP.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dtvSERP.AlternatingRowsDefaultCellStyle = style;
            this.dtvSERP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvSERP.BackgroundColor = Color.White;
            this.dtvSERP.BorderStyle = BorderStyle.None;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Control;
            style2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.WindowText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.True;
            this.dtvSERP.ColumnHeadersDefaultCellStyle = style2;
            this.dtvSERP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.Column1, this.Column11, this.Column9, this.Column7 };
            this.dtvSERP.Columns.AddRange(dataGridViewColumns);
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.FromArgb(0, 0, 0x40);
            style3.SelectionBackColor = Color.FromArgb(0xff, 0x80, 0);
            style3.SelectionForeColor = Color.White;
            style3.WrapMode = DataGridViewTriState.False;
            this.dtvSERP.DefaultCellStyle = style3;
            this.dtvSERP.Dock = DockStyle.Fill;
            this.dtvSERP.Location = new Point(0, 0x19);
            this.dtvSERP.MultiSelect = false;
            this.dtvSERP.Name = "dtvSERP";
            this.dtvSERP.ReadOnly = true;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.HighlightText;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dtvSERP.RowHeadersDefaultCellStyle = style4;
            this.dtvSERP.RowHeadersWidth = 40;
            this.dtvSERP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtvSERP.Size = new Size(0x3e8, 470);
            this.dtvSERP.TabIndex = 9;
            this.dtvSERP.CellContentClick += new DataGridViewCellEventHandler(this.dtvSERP_CellContentClick);
            this.dtvSERP.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dtvSERP_RowPostPaint);
            style5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = style5;
            this.Column1.FillWeight = 31.79241f;
            this.Column1.HeaderText = "TOP";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column11.FillWeight = 181.3769f;
            this.Column11.HeaderText = "Url Link";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = DataGridViewTriState.True;
            this.Column11.SortMode = DataGridViewColumnSortMode.Automatic;
            style6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column9.DefaultCellStyle = style6;
            this.Column9.FillWeight = 24.69639f;
            this.Column9.HeaderText = "PR";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column7.FillWeight = 248.6532f;
            this.Column7.HeaderText = "Ti\x00eau đề";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3e8, 0x1ef);
            base.Controls.Add(this.dtvSERP);
            base.Controls.Add(this.toolBar);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmSERP";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Độ cạnh tranh của từ kho\x00e1!";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((ISupportInitialize) this.dtvSERP).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

