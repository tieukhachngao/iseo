namespace iSEO
{
    using iSEO.iSEOService;
    using iSEO.Properties;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class frmLink : Form
    {
        private IContainer icontainer_0;
        private RichTextBox txtLink;
        private Button btnOK;
        private GroupBox groupBox22;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;

        public frmLink()
        {
            this.InitializeComponent();
            frmMain.list_0 = new List<string>();
        }

        public frmLink(InfoSEO info)
        {
            frmMain.list_0 = new List<string>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmMain.list_0 = this.txtLink.Text.Trim().Split(new char[] { '\n' }).Distinct<string>().ToList<string>();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmLink));
            this.txtLink = new RichTextBox();
            this.btnOK = new Button();
            this.groupBox22 = new GroupBox();
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            this.groupBox22.SuspendLayout();
            this.toolBar.SuspendLayout();
            base.SuspendLayout();
            this.txtLink.Location = new Point(6, 0x15);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new Size(0x2d2, 0x171);
            this.txtLink.TabIndex = 0;
            this.txtLink.Text = "";
            this.txtLink.LinkClicked += new LinkClickedEventHandler(this.txtLink_LinkClicked);
            this.btnOK.DialogResult = DialogResult.Cancel;
            this.btnOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnOK.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.btnOK.Location = new Point(0x13b, 0x18c);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new Size(90, 0x1f);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Ho\x00e0n Th\x00e0nh";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new EventHandler(this.btnOK_Click);
            this.groupBox22.Controls.Add(this.txtLink);
            this.groupBox22.Controls.Add(this.btnOK);
            this.groupBox22.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox22.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.groupBox22.Location = new Point(6, 0x1c);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new Size(0x2de, 0x1b1);
            this.groupBox22.TabIndex = 0x1a;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Nhập danh s\x00e1ch dữ liệu (Ph\x00e2n c\x00e1ch bằng xuống d\x00f2ng)";
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(740, 0x19);
            this.toolBar.TabIndex = 0x1b;
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
            this.toolStripLabel3.Size = new Size(0x66, 0x16);
            this.toolStripLabel3.Text = "Th\x00eam dữ liệu";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(740, 0x1d4);
            base.Controls.Add(this.toolBar);
            base.Controls.Add(this.groupBox22);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmLink";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Danh s\x00e1ch Link";
            this.groupBox22.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void txtLink_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}

