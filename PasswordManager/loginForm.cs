using System.IO;

using WinPassManager.Models;
using WinPassManager.Services;

using PasswordManager.Services;

namespace PasswordManager
{
    internal partial class loginForm : Form
    {
        private ReaLTaiizor.Controls.AirTabPage loginTabContainer;
        private TabPage loginTabPage;
        private TabPage registerTabPage;

        private string _workflowFileExtension { get; set; } = "workflow";
        private string _credentialsFileExtension { get; set; } = "credentials";
        private string _currentProcessName { get; set; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        private string _userLocalDataPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private string _appDataPath { get; set; }
        private string _appLoginCredentialsFilePath { get; set; }
        private string _hashedLogin { get; set; }
        private string _hashedPassword { get; set; }

        private readonly IDirectoryService _directoryService;
        private readonly IFileService _fileService;
        private readonly ISecretHasherService _secretHasherService;
        private readonly IINIFileService _INIFileService;
        private readonly mainForm _mainForm;

        private ReaLTaiizor.Controls.ForeverTextBox txtUserNameRegister;
        private ReaLTaiizor.Controls.ForeverTextBox txtPasswordRegister;
        private ReaLTaiizor.Controls.ForeverTextBox txtConfirmPasswordRegister;
        private Label lblUserNameLogin;
        private Label lblPasswordLogin;
        private Label lblConfirmPasswordRegister;
        private Label lblPasswordRegister;
        private Label lblUserNameRegister;
        private ReaLTaiizor.Controls.ForeverTextBox txtUserNameLogin;
        private ReaLTaiizor.Controls.ForeverTextBox txtPasswordLogin;
        private ReaLTaiizor.Controls.Button btnLogin;
        private ReaLTaiizor.Controls.Button btnCancelLogin;
        private ReaLTaiizor.Controls.Button btnCancelRegister;
        private ReaLTaiizor.Controls.Button btnRegister;
        private Label lblErrorMessageLogin;
        private ReaLTaiizor.Controls.Button btnResetPassword;
        private Label lblForgetMessage;
        private Label lblErrorMessageRegister;

        public loginForm(
            IDirectoryService directoryService,
            IFileService fileService,
            ISecretHasherService secretHasherService,
            IINIFileService INIFileService,
            mainForm mainForm)
        {
            InitializeComponent();

            _appDataPath = Path.Combine(_userLocalDataPath, _currentProcessName);
            _appLoginCredentialsFilePath = Path.Combine(
                _appDataPath, 
                string.Concat(_currentProcessName, ".", _credentialsFileExtension));

            _directoryService = directoryService;
            _fileService = fileService;
            _secretHasherService = secretHasherService;
            _INIFileService = INIFileService;
            _mainForm = mainForm;

            txtPasswordRegister!.UseSystemPasswordChar = true;
            txtConfirmPasswordRegister!.UseSystemPasswordChar = true;

            txtPasswordLogin!.UseSystemPasswordChar = true;

            lblErrorMessageLogin!.Visible = false;
            lblErrorMessageRegister!.Visible = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginTabContainer = new ReaLTaiizor.Controls.AirTabPage();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.btnResetPassword = new ReaLTaiizor.Controls.Button();
            this.lblForgetMessage = new System.Windows.Forms.Label();
            this.lblErrorMessageLogin = new System.Windows.Forms.Label();
            this.btnLogin = new ReaLTaiizor.Controls.Button();
            this.btnCancelLogin = new ReaLTaiizor.Controls.Button();
            this.txtUserNameLogin = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txtPasswordLogin = new ReaLTaiizor.Controls.ForeverTextBox();
            this.lblUserNameLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.lblErrorMessageRegister = new System.Windows.Forms.Label();
            this.btnCancelRegister = new ReaLTaiizor.Controls.Button();
            this.btnRegister = new ReaLTaiizor.Controls.Button();
            this.lblConfirmPasswordRegister = new System.Windows.Forms.Label();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.lblUserNameRegister = new System.Windows.Forms.Label();
            this.txtUserNameRegister = new ReaLTaiizor.Controls.ForeverTextBox();
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
            this.loginTabContainer.TabIndex = 0;
            // 
            // loginTabPage
            // 
            this.loginTabPage.BackColor = System.Drawing.Color.White;
            this.loginTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTabPage.Controls.Add(this.btnResetPassword);
            this.loginTabPage.Controls.Add(this.lblForgetMessage);
            this.loginTabPage.Controls.Add(this.lblErrorMessageLogin);
            this.loginTabPage.Controls.Add(this.btnLogin);
            this.loginTabPage.Controls.Add(this.btnCancelLogin);
            this.loginTabPage.Controls.Add(this.txtUserNameLogin);
            this.loginTabPage.Controls.Add(this.txtPasswordLogin);
            this.loginTabPage.Controls.Add(this.lblUserNameLogin);
            this.loginTabPage.Controls.Add(this.lblPasswordLogin);
            this.loginTabPage.Location = new System.Drawing.Point(119, 4);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(441, 200);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Login";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetPassword.Image = null;
            this.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnResetPassword.Location = new System.Drawing.Point(272, 112);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnResetPassword.Size = new System.Drawing.Size(160, 32);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Reset password!";
            this.btnResetPassword.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // lblForgetMessage
            // 
            this.lblForgetMessage.AutoSize = true;
            this.lblForgetMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblForgetMessage.Location = new System.Drawing.Point(8, 120);
            this.lblForgetMessage.Name = "lblForgetMessage";
            this.lblForgetMessage.Size = new System.Drawing.Size(255, 15);
            this.lblForgetMessage.TabIndex = 8;
            this.lblForgetMessage.Text = "Forgot your password? Click the \'Reset\' button.";
            // 
            // lblErrorMessageLogin
            // 
            this.lblErrorMessageLogin.AutoSize = true;
            this.lblErrorMessageLogin.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessageLogin.Location = new System.Drawing.Point(8, 88);
            this.lblErrorMessageLogin.Name = "lblErrorMessageLogin";
            this.lblErrorMessageLogin.Size = new System.Drawing.Size(84, 15);
            this.lblErrorMessageLogin.TabIndex = 7;
            this.lblErrorMessageLogin.Text = "ErrorMessage: ";
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
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.btnCancelLogin.TabIndex = 3;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtUserNameLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtUserNameLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtUserNameLogin.FocusOnHover = false;
            this.txtUserNameLogin.ForeColor = System.Drawing.Color.Yellow;
            this.txtUserNameLogin.Location = new System.Drawing.Point(120, 8);
            this.txtUserNameLogin.MaxLength = 32767;
            this.txtUserNameLogin.Multiline = false;
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.ReadOnly = false;
            this.txtUserNameLogin.Size = new System.Drawing.Size(312, 29);
            this.txtUserNameLogin.TabIndex = 0;
            this.txtUserNameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserNameLogin.UseSystemPasswordChar = false;
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
            this.txtPasswordLogin.TabIndex = 1;
            this.txtPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPasswordLogin.UseSystemPasswordChar = false;
            // 
            // lblUserNameLogin
            // 
            this.lblUserNameLogin.AutoSize = true;
            this.lblUserNameLogin.Location = new System.Drawing.Point(8, 16);
            this.lblUserNameLogin.Name = "lblUserNameLogin";
            this.lblUserNameLogin.Size = new System.Drawing.Size(105, 15);
            this.lblUserNameLogin.TabIndex = 5;
            this.lblUserNameLogin.Text = "UserName (Email):";
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(56, 56);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(60, 15);
            this.lblPasswordLogin.TabIndex = 6;
            this.lblPasswordLogin.Text = "Password:";
            // 
            // registerTabPage
            // 
            this.registerTabPage.BackColor = System.Drawing.Color.White;
            this.registerTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerTabPage.Controls.Add(this.lblErrorMessageRegister);
            this.registerTabPage.Controls.Add(this.btnCancelRegister);
            this.registerTabPage.Controls.Add(this.btnRegister);
            this.registerTabPage.Controls.Add(this.lblConfirmPasswordRegister);
            this.registerTabPage.Controls.Add(this.lblPasswordRegister);
            this.registerTabPage.Controls.Add(this.lblUserNameRegister);
            this.registerTabPage.Controls.Add(this.txtUserNameRegister);
            this.registerTabPage.Controls.Add(this.txtPasswordRegister);
            this.registerTabPage.Controls.Add(this.txtConfirmPasswordRegister);
            this.registerTabPage.Location = new System.Drawing.Point(119, 4);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerTabPage.Size = new System.Drawing.Size(441, 200);
            this.registerTabPage.TabIndex = 1;
            this.registerTabPage.Text = "Register";
            // 
            // lblErrorMessageRegister
            // 
            this.lblErrorMessageRegister.AutoSize = true;
            this.lblErrorMessageRegister.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessageRegister.Location = new System.Drawing.Point(8, 128);
            this.lblErrorMessageRegister.Name = "lblErrorMessageRegister";
            this.lblErrorMessageRegister.Size = new System.Drawing.Size(84, 15);
            this.lblErrorMessageRegister.TabIndex = 8;
            this.lblErrorMessageRegister.Text = "ErrorMessage: ";
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
            this.btnCancelRegister.TabIndex = 4;
            this.btnCancelRegister.Text = "Cancel";
            this.btnCancelRegister.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblConfirmPasswordRegister
            // 
            this.lblConfirmPasswordRegister.AutoSize = true;
            this.lblConfirmPasswordRegister.Location = new System.Drawing.Point(8, 96);
            this.lblConfirmPasswordRegister.Name = "lblConfirmPasswordRegister";
            this.lblConfirmPasswordRegister.Size = new System.Drawing.Size(107, 15);
            this.lblConfirmPasswordRegister.TabIndex = 7;
            this.lblConfirmPasswordRegister.Text = "Confirm password:";
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Location = new System.Drawing.Point(56, 56);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(60, 15);
            this.lblPasswordRegister.TabIndex = 6;
            this.lblPasswordRegister.Text = "Password:";
            // 
            // lblUserNameRegister
            // 
            this.lblUserNameRegister.AutoSize = true;
            this.lblUserNameRegister.Location = new System.Drawing.Point(8, 16);
            this.lblUserNameRegister.Name = "lblUserNameRegister";
            this.lblUserNameRegister.Size = new System.Drawing.Size(105, 15);
            this.lblUserNameRegister.TabIndex = 5;
            this.lblUserNameRegister.Text = "UserName (Email):";
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.BackColor = System.Drawing.Color.Transparent;
            this.txtUserNameRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtUserNameRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtUserNameRegister.FocusOnHover = false;
            this.txtUserNameRegister.ForeColor = System.Drawing.Color.Yellow;
            this.txtUserNameRegister.Location = new System.Drawing.Point(120, 8);
            this.txtUserNameRegister.MaxLength = 32767;
            this.txtUserNameRegister.Multiline = false;
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.ReadOnly = false;
            this.txtUserNameRegister.Size = new System.Drawing.Size(312, 29);
            this.txtUserNameRegister.TabIndex = 0;
            this.txtUserNameRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserNameRegister.UseSystemPasswordChar = false;
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
            this.txtPasswordRegister.TabIndex = 1;
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
            this.txtConfirmPasswordRegister.TabIndex = 2;
            this.txtConfirmPasswordRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPasswordRegister.UseSystemPasswordChar = false;
            // 
            // loginForm
            // 
            this.ClientSize = new System.Drawing.Size(564, 208);
            this.Controls.Add(this.loginTabContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginModel = GetLoginModel();
            if (!ModelState.IsValid(loginModel))
            {
                SetLblErrorMessageValue(lblErrorMessageLogin, true, 
                    string.Concat("ErrorMessage: ", ModelState.ErrorMessages.FirstOrDefault()));
                return;
            }

            _hashedLogin = _INIFileService.IniReadValue(
                _credentialsFileExtension, nameof(_hashedLogin), _appLoginCredentialsFilePath);
            _hashedPassword = _INIFileService.IniReadValue(
                _credentialsFileExtension, nameof(_hashedPassword), _appLoginCredentialsFilePath);
            if (!_secretHasherService.Verify(txtUserNameLogin.Text, _hashedLogin) ||
                !_secretHasherService.Verify(txtPasswordLogin.Text, _hashedPassword))
            {
                SetLblErrorMessageValue(lblErrorMessageLogin, true, 
                    string.Concat("ErrorMessage: ", "UserName (Email) or password is incorrect!"));
                return;
            }

            SetLblErrorMessageValue(lblErrorMessageLogin, false, null);

            this.Hide();
            _mainForm.AppDataPath = _appDataPath;
            _mainForm.AppWorkflowFilePath = Path.Combine(_appDataPath, string.Concat(_currentProcessName, ".", _workflowFileExtension));
            _ = _mainForm.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerModel = GetRegisterModel();
            if (!ModelState.IsValid(registerModel))
            {
                SetLblErrorMessageValue(lblErrorMessageRegister, true, 
                    string.Concat("ErrorMessage: ", ModelState.ErrorMessages.FirstOrDefault()));
                return;
            }
            if (!string.Equals(txtPasswordRegister.Text, txtConfirmPasswordRegister.Text))
            {
                SetLblErrorMessageValue(lblErrorMessageRegister, 
                    true, string.Concat("ErrorMessage: ", "ConfirmPassword text is incorrect!"));
                return;
            }
            SetLblErrorMessageValue(lblErrorMessageRegister, false, null);

            _hashedLogin = _secretHasherService.Hash(txtUserNameRegister.Text);
            _hashedPassword = _secretHasherService.Hash(txtPasswordRegister.Text);
            _INIFileService.IniWriteValue(
                _credentialsFileExtension, nameof(_hashedLogin), _hashedLogin, _appLoginCredentialsFilePath);
            _INIFileService.IniWriteValue(
                _credentialsFileExtension, nameof(_hashedPassword), _hashedPassword, _appLoginCredentialsFilePath);

            this.Hide();
            _mainForm.AppDataPath = _appDataPath;
            _mainForm.AppWorkflowFilePath = Path.Combine(_appDataPath, string.Concat(_currentProcessName, ".", _workflowFileExtension));
            _ = _mainForm.ShowDialog();
            this.Close();
        }

        private void SetLblErrorMessageValue(Label errorLabel, bool visible, string? text)
        {
            errorLabel.Visible = visible;
            errorLabel.Text = text;
        }

        private Register GetRegisterModel()
        {
            return new Register()
            {
                UserName = txtUserNameRegister.Text,
                Password = txtPasswordRegister.Text,
                ConfirmPassword = txtConfirmPasswordRegister.Text
            };
        }

        private Login GetLoginModel()
        {
            return new Login()
            {
                UserName = txtUserNameLogin.Text,
                Password = txtPasswordLogin.Text
            };
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

        }
    }
}