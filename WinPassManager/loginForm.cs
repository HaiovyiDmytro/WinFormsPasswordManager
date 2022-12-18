using System.IO;

using WPManager.Services;

namespace WPManager
{
    public partial class loginForm : Form
    {
        private ReaLTaiizor.Controls.AirTabPage loginTabContainer;
        private TabPage loginTabPage;
        private System.ComponentModel.IContainer components;
        private TabPage registerTabPage;

        private string _currentProcessName { get; set; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        private string _userLocalDataPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private string _appDataPath { get; set; }
        private string _appLoginCredentialsFilePath { get; set; }

        public readonly IDirectoryService _directoryService;
        private ReaLTaiizor.Controls.ForeverTextBox txtEmailRegister;
        private ReaLTaiizor.Controls.ForeverTextBox txtPasswordRegister;
        private ReaLTaiizor.Controls.ForeverTextBox txtConfirmPasswordRegister;
        private Label lblEmailLogin;
        private Label lblPasswordLogin;
        private Label lblConfirmPasswordRegister;
        private Label lblPasswordRegister;
        private Label lblEmailRegister;
        private ReaLTaiizor.Controls.ForeverTextBox txtEmailLogin;
        private ReaLTaiizor.Controls.ForeverTextBox txtPasswordLogin;
        private ReaLTaiizor.Controls.Button btnLogin;
        private ReaLTaiizor.Controls.Button btnCancelLogin;
        private ReaLTaiizor.Controls.Button btnCancelRegister;
        private ReaLTaiizor.Controls.Button btnRegister;
        public readonly IFileService _fileService;

        public loginForm(IDirectoryService directoryService, IFileService fileService)
        {
            InitializeComponent();

            _appDataPath = Path.Combine(_userLocalDataPath, _currentProcessName);
            _appLoginCredentialsFilePath = Path.Combine(_appDataPath, string.Concat(_currentProcessName, ".credentials"));

            _directoryService = directoryService;
            _fileService = fileService;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (!_directoryService.DirectoryExists(_appDataPath))
            {
                _ = _directoryService.CreateDirectory(_appDataPath);
            }

            if (!_fileService.FileExists(_appLoginCredentialsFilePath))
            {
                loginTabContainer.TabPages.Remove(loginTabPage);
            }
            else
            {
                loginTabContainer.TabPages.Remove(registerTabPage);
            }
        }

        private void InitializeComponent()
        {
            this.loginTabContainer = new ReaLTaiizor.Controls.AirTabPage();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.btnLogin = new ReaLTaiizor.Controls.Button();
            this.btnCancelLogin = new ReaLTaiizor.Controls.Button();
            this.txtEmailLogin = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txtPasswordLogin = new ReaLTaiizor.Controls.ForeverTextBox();
            this.lblEmailLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.btnCancelRegister = new ReaLTaiizor.Controls.Button();
            this.btnRegister = new ReaLTaiizor.Controls.Button();
            this.lblConfirmPasswordRegister = new System.Windows.Forms.Label();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.lblEmailRegister = new System.Windows.Forms.Label();
            this.txtEmailRegister = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txtPasswordRegister = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txtConfirmPasswordRegister = new ReaLTaiizor.Controls.ForeverTextBox();
            this.loginTabContainer.SuspendLayout();
            this.loginTabPage.SuspendLayout();
            this.registerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTabContainer
            // 
            this.loginTabContainer.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.loginTabContainer.Controls.Add(this.loginTabPage);
            this.loginTabContainer.Controls.Add(this.registerTabPage);
            this.loginTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTabContainer.ItemSize = new System.Drawing.Size(30, 115);
            this.loginTabContainer.Location = new System.Drawing.Point(0, 0);
            this.loginTabContainer.Multiline = true;
            this.loginTabContainer.Name = "loginTabContainer";
            this.loginTabContainer.SelectedIndex = 0;
            this.loginTabContainer.ShowOuterBorders = true;
            this.loginTabContainer.Size = new System.Drawing.Size(564, 208);
            this.loginTabContainer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.loginTabContainer.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.loginTabContainer.TabIndex = 1;
            // 
            // loginTabPage
            // 
            this.loginTabPage.BackColor = System.Drawing.Color.White;
            this.loginTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTabPage.Controls.Add(this.btnLogin);
            this.loginTabPage.Controls.Add(this.btnCancelLogin);
            this.loginTabPage.Controls.Add(this.txtEmailLogin);
            this.loginTabPage.Controls.Add(this.txtPasswordLogin);
            this.loginTabPage.Controls.Add(this.lblEmailLogin);
            this.loginTabPage.Controls.Add(this.lblPasswordLogin);
            this.loginTabPage.Location = new System.Drawing.Point(119, 4);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(441, 200);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Image = null;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Location = new System.Drawing.Point(8, 160);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.Green;
            this.btnLogin.Size = new System.Drawing.Size(112, 32);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelLogin.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnCancelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelLogin.Image = null;
            this.btnCancelLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelLogin.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnCancelLogin.Location = new System.Drawing.Point(320, 160);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancelLogin.Size = new System.Drawing.Size(112, 32);
            this.btnCancelLogin.TabIndex = 17;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtEmailLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtEmailLogin.FocusOnHover = false;
            this.txtEmailLogin.ForeColor = System.Drawing.Color.Yellow;
            this.txtEmailLogin.Location = new System.Drawing.Point(120, 8);
            this.txtEmailLogin.MaxLength = 32767;
            this.txtEmailLogin.Multiline = false;
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.ReadOnly = false;
            this.txtEmailLogin.Size = new System.Drawing.Size(312, 29);
            this.txtEmailLogin.TabIndex = 16;
            this.txtEmailLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmailLogin.UseSystemPasswordChar = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtPasswordLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtPasswordLogin.FocusOnHover = false;
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.Yellow;
            this.txtPasswordLogin.Location = new System.Drawing.Point(120, 48);
            this.txtPasswordLogin.MaxLength = 32767;
            this.txtPasswordLogin.Multiline = false;
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.ReadOnly = false;
            this.txtPasswordLogin.Size = new System.Drawing.Size(312, 29);
            this.txtPasswordLogin.TabIndex = 15;
            this.txtPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordLogin.UseSystemPasswordChar = false;
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.AutoSize = true;
            this.lblEmailLogin.Location = new System.Drawing.Point(72, 16);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(39, 15);
            this.lblEmailLogin.TabIndex = 14;
            this.lblEmailLogin.Text = "Email:";
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(56, 56);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(60, 15);
            this.lblPasswordLogin.TabIndex = 13;
            this.lblPasswordLogin.Text = "Password:";
            // 
            // registerTabPage
            // 
            this.registerTabPage.BackColor = System.Drawing.Color.White;
            this.registerTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerTabPage.Controls.Add(this.btnCancelRegister);
            this.registerTabPage.Controls.Add(this.btnRegister);
            this.registerTabPage.Controls.Add(this.lblConfirmPasswordRegister);
            this.registerTabPage.Controls.Add(this.lblPasswordRegister);
            this.registerTabPage.Controls.Add(this.lblEmailRegister);
            this.registerTabPage.Controls.Add(this.txtEmailRegister);
            this.registerTabPage.Controls.Add(this.txtPasswordRegister);
            this.registerTabPage.Controls.Add(this.txtConfirmPasswordRegister);
            this.registerTabPage.Location = new System.Drawing.Point(119, 4);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerTabPage.Size = new System.Drawing.Size(441, 200);
            this.registerTabPage.TabIndex = 1;
            this.registerTabPage.Text = "Register";
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelRegister.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnCancelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelRegister.Image = null;
            this.btnCancelRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelRegister.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnCancelRegister.Location = new System.Drawing.Point(320, 160);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnCancelRegister.Size = new System.Drawing.Size(112, 32);
            this.btnCancelRegister.TabIndex = 16;
            this.btnCancelRegister.Text = "Cancel";
            this.btnCancelRegister.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Image = null;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnRegister.Location = new System.Drawing.Point(8, 160);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.PressedColor = System.Drawing.Color.Green;
            this.btnRegister.Size = new System.Drawing.Size(112, 32);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblConfirmPasswordRegister
            // 
            this.lblConfirmPasswordRegister.AutoSize = true;
            this.lblConfirmPasswordRegister.Location = new System.Drawing.Point(8, 96);
            this.lblConfirmPasswordRegister.Name = "lblConfirmPasswordRegister";
            this.lblConfirmPasswordRegister.Size = new System.Drawing.Size(107, 15);
            this.lblConfirmPasswordRegister.TabIndex = 14;
            this.lblConfirmPasswordRegister.Text = "Confirm password:";
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Location = new System.Drawing.Point(56, 56);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(60, 15);
            this.lblPasswordRegister.TabIndex = 13;
            this.lblPasswordRegister.Text = "Password:";
            // 
            // lblEmailRegister
            // 
            this.lblEmailRegister.AutoSize = true;
            this.lblEmailRegister.Location = new System.Drawing.Point(72, 16);
            this.lblEmailRegister.Name = "lblEmailRegister";
            this.lblEmailRegister.Size = new System.Drawing.Size(39, 15);
            this.lblEmailRegister.TabIndex = 12;
            this.lblEmailRegister.Text = "Email:";
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtEmailRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtEmailRegister.FocusOnHover = false;
            this.txtEmailRegister.ForeColor = System.Drawing.Color.Yellow;
            this.txtEmailRegister.Location = new System.Drawing.Point(120, 8);
            this.txtEmailRegister.MaxLength = 32767;
            this.txtEmailRegister.Multiline = false;
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.ReadOnly = false;
            this.txtEmailRegister.Size = new System.Drawing.Size(312, 29);
            this.txtEmailRegister.TabIndex = 11;
            this.txtEmailRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmailRegister.UseSystemPasswordChar = false;
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtPasswordRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtPasswordRegister.FocusOnHover = false;
            this.txtPasswordRegister.ForeColor = System.Drawing.Color.Yellow;
            this.txtPasswordRegister.Location = new System.Drawing.Point(120, 48);
            this.txtPasswordRegister.MaxLength = 32767;
            this.txtPasswordRegister.Multiline = false;
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.ReadOnly = false;
            this.txtPasswordRegister.Size = new System.Drawing.Size(312, 29);
            this.txtPasswordRegister.TabIndex = 10;
            this.txtPasswordRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordRegister.UseSystemPasswordChar = false;
            // 
            // txtConfirmPasswordRegister
            // 
            this.txtConfirmPasswordRegister.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPasswordRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtConfirmPasswordRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtConfirmPasswordRegister.FocusOnHover = false;
            this.txtConfirmPasswordRegister.ForeColor = System.Drawing.Color.Yellow;
            this.txtConfirmPasswordRegister.Location = new System.Drawing.Point(120, 88);
            this.txtConfirmPasswordRegister.MaxLength = 32767;
            this.txtConfirmPasswordRegister.Multiline = false;
            this.txtConfirmPasswordRegister.Name = "txtConfirmPasswordRegister";
            this.txtConfirmPasswordRegister.ReadOnly = false;
            this.txtConfirmPasswordRegister.Size = new System.Drawing.Size(312, 29);
            this.txtConfirmPasswordRegister.TabIndex = 8;
            this.txtConfirmPasswordRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPasswordRegister.UseSystemPasswordChar = false;
            // 
            // loginForm
            // 
            this.ClientSize = new System.Drawing.Size(564, 208);
            this.Controls.Add(this.loginTabContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter your credentials";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.loginTabContainer.ResumeLayout(false);
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            this.registerTabPage.ResumeLayout(false);
            this.registerTabPage.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}