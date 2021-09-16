namespace iSEO
{
    using iSEO.iSEOService;
    using iSEO.Properties;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Forms;

    public class frmLogin : Form
    {
        private const string string_0 = "<RSAKeyValue><Modulus>keuFw++iHf6aXfHGpvEJ9ReFx1HTmbppEK2YehoUFU8W3zAjl8BjpM2e+t6FG9fDv+skvr/j2q+SjjKUvK1rXAEYLVt56SHE1PD8UxP8QP0N/vQd2eddEqp1BBqynLp1c8EWze7nI9NSfMQSHghZZVI6WjhZmbzw/JWMULBtbKs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private bool bool_0;
        private GClass4 gclass4_0 = new GClass4();
        private IContainer icontainer_0;
        private TextBox txtEmail;
        private MaskedTextBox txtPass;
        private PictureBox btnExit;
        private PictureBox btnpRegister;
        private PictureBox btnpLogin;
        private Label lbLoad;

        public frmLogin()
        {
            this.InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpLogin_Click(object sender, EventArgs e)
        {
            this.method_1();
        }

        private void btnpRegister_Click(object sender, EventArgs e)
        {
            Process.Start("http://igoo.vn/info/login");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in this.gclass4_0.method_40("SELECT * FROM Users WHERE Code = 'ISEO'").Rows)
            {
                this.txtEmail.Text = row["UserName"].ToString();
                this.txtPass.Text = row["Password"].ToString();
                this.bool_0 = true;
                this.method_1();
            }
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmLogin));
            this.txtEmail = new TextBox();
            this.txtPass = new MaskedTextBox();
            this.lbLoad = new Label();
            this.btnpRegister = new PictureBox();
            this.btnpLogin = new PictureBox();
            this.btnExit = new PictureBox();
            ((ISupportInitialize) this.btnpRegister).BeginInit();
            ((ISupportInitialize) this.btnpLogin).BeginInit();
            ((ISupportInitialize) this.btnExit).BeginInit();
            base.SuspendLayout();
            this.txtEmail.BackColor = Color.MintCream;
            this.txtEmail.BorderStyle = BorderStyle.None;
            this.txtEmail.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtEmail.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtEmail.Location = new Point(0x48, 0x63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(0xac, 15);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyUp += new KeyEventHandler(this.txtEmail_KeyUp);
            this.txtPass.BackColor = Color.MintCream;
            this.txtPass.BorderStyle = BorderStyle.None;
            this.txtPass.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPass.ForeColor = Color.FromArgb(0, 0, 0x40);
            this.txtPass.Location = new Point(0x48, 140);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new Size(0xac, 15);
            this.txtPass.TabIndex = 4;
            this.txtPass.KeyUp += new KeyEventHandler(this.txtPass_KeyUp);
            this.lbLoad.AutoSize = true;
            this.lbLoad.BackColor = Color.Transparent;
            this.lbLoad.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbLoad.ForeColor = Color.White;
            this.lbLoad.Location = new Point(0x40, 0x17);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new Size(0, 14);
            this.lbLoad.TabIndex = 0x19;
            this.btnpRegister.BackColor = Color.Transparent;
            this.btnpRegister.Cursor = Cursors.Hand;
            this.btnpRegister.Location = new Point(250, 0x81);
            this.btnpRegister.Name = "btnpRegister";
            this.btnpRegister.Size = new Size(0x61, 0x24);
            this.btnpRegister.TabIndex = 0x18;
            this.btnpRegister.TabStop = false;
            this.btnpRegister.Click += new EventHandler(this.btnpRegister_Click);
            this.btnpLogin.BackColor = Color.Transparent;
            this.btnpLogin.Cursor = Cursors.Hand;
            this.btnpLogin.Location = new Point(250, 0x58);
            this.btnpLogin.Name = "btnpLogin";
            this.btnpLogin.Size = new Size(0x61, 0x24);
            this.btnpLogin.TabIndex = 0x18;
            this.btnpLogin.TabStop = false;
            this.btnpLogin.Click += new EventHandler(this.btnpLogin_Click);
            this.btnExit.BackColor = Color.Transparent;
            this.btnExit.Cursor = Cursors.Hand;
            this.btnExit.Image = Resources.smethod_4();
            this.btnExit.Location = new Point(0x145, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x16, 0x11);
            this.btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0x17;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Resources.smethod_23();
            base.ClientSize = new Size(350, 0xae);
            base.Controls.Add(this.lbLoad);
            base.Controls.Add(this.btnpRegister);
            base.Controls.Add(this.btnpLogin);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.txtPass);
            base.Controls.Add(this.txtEmail);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmLogin";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            base.Load += new EventHandler(this.frmLogin_Load);
            ((ISupportInitialize) this.btnpRegister).EndInit();
            ((ISupportInitialize) this.btnpLogin).EndInit();
            ((ISupportInitialize) this.btnExit).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void method_1()
        {
            try
            {
                string str = this.txtEmail.Text.Trim();
                string str2 = this.gclass4_0.method_37(this.txtPass.Text.Trim());
                if (!this.bool_0)
                {
                    if (this.gclass4_0.method_40("SELECT * FROM Users WHERE Code='ISEO'").Rows.Count > 0)
                    {
                        this.gclass4_0.method_42("UPDATE Users SET UserName = '" + this.txtEmail.Text.Trim() + "', [Password] = '" + this.gclass4_0.method_37(this.txtPass.Text.Trim()) + "' WHERE Code='ISEO'");
                    }
                    else
                    {
                        this.gclass4_0.method_42(string.Concat(new object[] { "INSERT INTO Users(UserID, [UserName], [Password], [Code]) VALUES('", Guid.NewGuid(), "','", str, "', '", str2, "', 'ISEO')" }));
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.lbLoad.Text = "Loaddding...";
            if (!string.IsNullOrEmpty(this.txtEmail.Text.Trim()) && !string.IsNullOrEmpty(this.txtPass.Text.Trim()))
            {
                new Thread(new ThreadStart(this.method_2)) { IsBackground = true }.Start();
            }
        }

        private void method_2()
        {
            MethodInvoker invoker3 = null;
            try
            {
                MethodInvoker invoker;
                MethodInvoker invoker2 = null;
                Class57 class3 = new Class57 {
                    frmLogin_0 = this
                };
                GClass18 class2 = new GClass18();
                string str = this.txtEmail.Text.Trim();
                string str2 = this.bool_0 ? this.txtPass.Text.Trim() : this.gclass4_0.method_37(this.txtPass.Text.Trim());
                class3.infoSEO_0 = new InfoSEO();
                iSEOSoapClient client = new iSEOSoapClient();
                if (!client.Endpoint.Address.Uri.ToString().StartsWith("http://igoo.vn"))
                {
                    Application.Exit();
                }
                class3.infoSEO_0.Email = str;
                class3.infoSEO_0.Password = class2.method_0(str2, 0x400, "<RSAKeyValue><Modulus>keuFw++iHf6aXfHGpvEJ9ReFx1GTmbppEk2YehoUFU8W3zAjk8BjpM2e+t6FG9fDv+skvr/j2q+SjjKUvK1rXAEYLVt56SHE1PD8UxP8QP0N/vQd2eddEqp1BBqynLp1c8EWze7nI9NSfMQSHghZZVI6WjhZmbzw/JWMULBtbKs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
                class3.infoSEO_0.CPUID = this.gclass4_0.method_29();
                class3.infoSEO_0 = client.CheckLoginISEO(class3.infoSEO_0);
                if (string.IsNullOrEmpty(class3.infoSEO_0.Permission))
                {
                    MessageBox.Show("Email hoặc mật khẩu kh\x00f4ng đ\x00fang!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    invoker2 ??= new MethodInvoker(class3.method_0);
                    invoker = invoker2;
                    if (base.InvokeRequired)
                    {
                        base.BeginInvoke(invoker);
                    }
                    else
                    {
                        invoker();
                    }
                }
                invoker3 ??= new MethodInvoker(this.method_3);
                invoker = invoker3;
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(invoker);
                }
                else
                {
                    invoker();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        [CompilerGenerated]
        private void method_3()
        {
            this.bool_0 = false;
            this.lbLoad.Text = string.Empty;
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.method_1();
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.method_1();
            }
        }

        [CompilerGenerated]
        private sealed class Class57
        {
            public InfoSEO infoSEO_0;
            public frmLogin frmLogin_0;

            public void method_0()
            {
                this.frmLogin_0.Hide();
                new frmMain(this.infoSEO_0).Show();
            }
        }
    }
}

