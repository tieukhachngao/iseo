namespace iSEO
{
    using iSEO.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmInfo : Form
    {
        private IContainer icontainer_0;
        private PictureBox pictureBox1;
        private Label label19;
        private ToolStrip toolBar;
        private ToolStripButton btnExit;
        private ToolStripLabel toolStripLabel3;

        public frmInfo()
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmInfo));
            this.label19 = new Label();
            this.pictureBox1 = new PictureBox();
            this.toolBar = new ToolStrip();
            this.btnExit = new ToolStripButton();
            this.toolStripLabel3 = new ToolStripLabel();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            this.toolBar.SuspendLayout();
            base.SuspendLayout();
            this.label19.AutoSize = true;
            this.label19.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label19.Location = new Point(12, 0x21);
            this.label19.Name = "label19";
            this.label19.RightToLeft = RightToLeft.Yes;
            this.label19.Size = new Size(420, 0xa8);
            this.label19.TabIndex = 3;
            this.label19.Text = manager.GetString("label19.Text");
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Image = Resources.smethod_22();
            this.pictureBox1.Location = new Point(12, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x1a1, 0x142);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.toolBar.BackColor = SystemColors.ActiveCaptionText;
            this.toolBar.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.btnExit, this.toolStripLabel3 };
            this.toolBar.Items.AddRange(toolStripItems);
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = ToolStripRenderMode.System;
            this.toolBar.Size = new Size(0x1ba, 0x19);
            this.toolBar.TabIndex = 0x1c;
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
            this.toolStripLabel3.Size = new Size(0x43, 0x16);
            this.toolStripLabel3.Text = "About!";
            this.toolStripLabel3.TextAlign = ContentAlignment.MiddleRight;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x1ba, 0x21a);
            base.Controls.Add(this.toolBar);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.label19);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmInfo";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "About!";
            ((ISupportInitialize) this.pictureBox1).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

