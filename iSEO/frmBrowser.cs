namespace iSEO
{
    using iSEO.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmBrowser : Form
    {
        private IContainer icontainer_0;
        public WebBrowser webBrowser;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;

        public frmBrowser()
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

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmBrowser));
            this.webBrowser = new WebBrowser();
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.toolBar.SuspendLayout();
            base.SuspendLayout();
            this.webBrowser.Dock = DockStyle.Fill;
            this.webBrowser.Location = new Point(0, 0);
            this.webBrowser.MinimumSize = new Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new Size(0x3fa, 670);
            this.webBrowser.TabIndex = 0;
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x3fa, 0x19);
            this.toolBar.TabIndex = 3;
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
            this.toolStripLabel3.Size = new Size(0x12e, 0x16);
            this.toolStripLabel3.Text = "Tr\x00ecnh duyệt Website (Hỗ trợ tốt nhất >=IE9)";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3fa, 670);
            base.Controls.Add(this.toolBar);
            base.Controls.Add(this.webBrowser);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmBrowser";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Tr\x00ecnh duyệt Website (Hỗ trợ tốt nhất >=IE8)";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

