using System.IO;

using WinPassManager.Models;
using WinPassManager.Services;

using PasswordManager.Services;

namespace PasswordManager
{
    internal partial class loginForm : Form
    {
        private ReaLTaiizor.Controls.AirTabPage? loginTabContainer;
        private TabPage? loginTabPage;
        private TabPage? registerTabPage;

        private string _workflowFileExtension { get; set; } = "workflow";
        private string _credentialsFileExtension { get; set; } = "credentials";
        private string _currentProcessName { get; set; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        private string _userLocalDataPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private string _appDataPath { get; set; }
        private string _appLoginCredentialsFilePath { get; set; }
        private string? _hashedLogin { get; set; }
        private string? _hashedPassword { get; set; }

        private readonly IDirectoryService _directoryService;
        private readonly IFileService _fileService;
        private readonly ISecretHasherService _secretHasherService;
        private readonly IINIFileService _INIFileService;
        private readonly mainForm _mainForm;

        private ReaLTaiizor.Controls.ForeverTextBox? txtUserNameRegister;
        private ReaLTaiizor.Controls.ForeverTextBox? txtPasswordRegister;
        private ReaLTaiizor.Controls.ForeverTextBox? txtConfirmPasswordRegister;
        private Label? lblUserNameLogin;
        private Label? lblPasswordLogin;
        private Label? lblConfirmPasswordRegister;
        private Label? lblPasswordRegister;
        private Label? lblUserNameRegister;
        private ReaLTaiizor.Controls.ForeverTextBox? txtUserNameLogin;
        private ReaLTaiizor.Controls.ForeverTextBox? txtPasswordLogin;
        private ReaLTaiizor.Controls.Button? btnLogin;
        private ReaLTaiizor.Controls.Button? btnCancelLogin;
        private ReaLTaiizor.Controls.Button? btnCancelRegister;
        private ReaLTaiizor.Controls.Button? btnRegister;
        private Label? lblErrorMessageLogin;
        private ReaLTaiizor.Controls.Button? btnResetPassword;
        private Label? lblForgetMessage;
        private Label? lblErrorMessageRegister;

        public loginForm(
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
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

        private void loginForm_Load(object? sender, EventArgs e)
        {
            if (!_directoryService.DirectoryExists(_appDataPath))
            {
                _ = _directoryService.CreateDirectory(_appDataPath);
            }

            if (!_fileService.FileExists(_appLoginCredentialsFilePath))
            {
                loginTabContainer?.TabPages.Remove(loginTabPage);
                this.AcceptButton = btnRegister as IButtonControl;
                this.CancelButton = btnCancelRegister as IButtonControl;
            }
            else
            {
                loginTabContainer?.TabPages.Remove(registerTabPage);
                this.AcceptButton = btnLogin as IButtonControl;
                this.CancelButton = btnCancelLogin as IButtonControl;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            loginTabContainer = new ReaLTaiizor.Controls.AirTabPage();
            loginTabPage = new TabPage();
            btnResetPassword = new ReaLTaiizor.Controls.Button();
            lblForgetMessage = new Label();
            lblErrorMessageLogin = new Label();
            btnLogin = new ReaLTaiizor.Controls.Button();
            btnCancelLogin = new ReaLTaiizor.Controls.Button();
            txtUserNameLogin = new ReaLTaiizor.Controls.ForeverTextBox();
            txtPasswordLogin = new ReaLTaiizor.Controls.ForeverTextBox();
            lblUserNameLogin = new Label();
            lblPasswordLogin = new Label();
            registerTabPage = new TabPage();
            lblErrorMessageRegister = new Label();
            btnCancelRegister = new ReaLTaiizor.Controls.Button();
            btnRegister = new ReaLTaiizor.Controls.Button();
            lblConfirmPasswordRegister = new Label();
            lblPasswordRegister = new Label();
            lblUserNameRegister = new Label();
            txtUserNameRegister = new ReaLTaiizor.Controls.ForeverTextBox();
            txtPasswordRegister = new ReaLTaiizor.Controls.ForeverTextBox();
            txtConfirmPasswordRegister = new ReaLTaiizor.Controls.ForeverTextBox();
            loginTabContainer.SuspendLayout();
            loginTabPage.SuspendLayout();
            registerTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // loginTabContainer
            // 
            loginTabContainer.Alignment = TabAlignment.Left;
            loginTabContainer.Controls.Add(loginTabPage);
            loginTabContainer.Controls.Add(registerTabPage);
            loginTabContainer.Dock = DockStyle.Fill;
            loginTabContainer.ItemSize = new Size(30, 115);
            loginTabContainer.Location = new Point(0, 0);
            loginTabContainer.Multiline = true;
            loginTabContainer.Name = "loginTabContainer";
            loginTabContainer.SelectedIndex = 0;
            loginTabContainer.ShowOuterBorders = true;
            loginTabContainer.Size = new Size(564, 208);
            loginTabContainer.SizeMode = TabSizeMode.Fixed;
            loginTabContainer.SquareColor = Color.FromArgb(78, 87, 100);
            loginTabContainer.TabIndex = 0;
            // 
            // loginTabPage
            // 
            loginTabPage.BackColor = Color.White;
            loginTabPage.BorderStyle = BorderStyle.FixedSingle;
            loginTabPage.Controls.Add(btnResetPassword);
            loginTabPage.Controls.Add(lblForgetMessage);
            loginTabPage.Controls.Add(lblErrorMessageLogin);
            loginTabPage.Controls.Add(btnLogin);
            loginTabPage.Controls.Add(btnCancelLogin);
            loginTabPage.Controls.Add(txtUserNameLogin);
            loginTabPage.Controls.Add(txtPasswordLogin);
            loginTabPage.Controls.Add(lblUserNameLogin);
            loginTabPage.Controls.Add(lblPasswordLogin);
            loginTabPage.Location = new Point(119, 4);
            loginTabPage.Name = "loginTabPage";
            loginTabPage.Padding = new Padding(3);
            loginTabPage.Size = new Size(441, 200);
            loginTabPage.TabIndex = 0;
            loginTabPage.Text = "Login";
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.Transparent;
            btnResetPassword.EnteredColor = Color.FromArgb(32, 34, 37);
            btnResetPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetPassword.Image = null;
            btnResetPassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetPassword.InactiveColor = Color.FromArgb(32, 34, 37);
            btnResetPassword.Location = new Point(272, 112);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.PressedColor = Color.FromArgb(165, 37, 37);
            btnResetPassword.Size = new Size(160, 32);
            btnResetPassword.TabIndex = 13;
            btnResetPassword.Text = "Reset password!";
            btnResetPassword.TextAlignment = StringAlignment.Center;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // lblForgetMessage
            // 
            lblForgetMessage.AutoSize = true;
            lblForgetMessage.ForeColor = Color.Blue;
            lblForgetMessage.Location = new Point(8, 120);
            lblForgetMessage.Name = "lblForgetMessage";
            lblForgetMessage.Size = new Size(255, 15);
            lblForgetMessage.TabIndex = 17;
            lblForgetMessage.Text = "Forgot your password? Click the 'Reset' button.";
            // 
            // lblErrorMessageLogin
            // 
            lblErrorMessageLogin.AutoSize = true;
            lblErrorMessageLogin.ForeColor = Color.Red;
            lblErrorMessageLogin.Location = new Point(8, 88);
            lblErrorMessageLogin.Name = "lblErrorMessageLogin";
            lblErrorMessageLogin.Size = new Size(84, 15);
            lblErrorMessageLogin.TabIndex = 16;
            lblErrorMessageLogin.Text = "ErrorMessage: ";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.EnteredColor = Color.FromArgb(32, 34, 37);
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Image = null;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.InactiveColor = Color.FromArgb(32, 34, 37);
            btnLogin.Location = new Point(8, 160);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedColor = Color.Green;
            btnLogin.Size = new Size(112, 32);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancelLogin
            // 
            btnCancelLogin.BackColor = Color.Transparent;
            btnCancelLogin.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCancelLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelLogin.Image = null;
            btnCancelLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelLogin.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCancelLogin.Location = new Point(320, 160);
            btnCancelLogin.Name = "btnCancelLogin";
            btnCancelLogin.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancelLogin.Size = new Size(112, 32);
            btnCancelLogin.TabIndex = 12;
            btnCancelLogin.Text = "Cancel";
            btnCancelLogin.TextAlignment = StringAlignment.Center;
            btnCancelLogin.Click += btnCancel_Click;
            // 
            // txtUserNameLogin
            // 
            txtUserNameLogin.BackColor = Color.Transparent;
            txtUserNameLogin.BaseColor = Color.FromArgb(45, 47, 49);
            txtUserNameLogin.BorderColor = Color.FromArgb(35, 168, 109);
            txtUserNameLogin.FocusOnHover = false;
            txtUserNameLogin.ForeColor = Color.Yellow;
            txtUserNameLogin.Location = new Point(120, 8);
            txtUserNameLogin.MaxLength = 32767;
            txtUserNameLogin.Multiline = false;
            txtUserNameLogin.Name = "txtUserNameLogin";
            txtUserNameLogin.ReadOnly = false;
            txtUserNameLogin.Size = new Size(312, 29);
            txtUserNameLogin.TabIndex = 9;
            txtUserNameLogin.TextAlign = HorizontalAlignment.Left;
            txtUserNameLogin.UseSystemPasswordChar = false;
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.BackColor = Color.Transparent;
            txtPasswordLogin.BaseColor = Color.FromArgb(45, 47, 49);
            txtPasswordLogin.BorderColor = Color.FromArgb(35, 168, 109);
            txtPasswordLogin.FocusOnHover = false;
            txtPasswordLogin.ForeColor = Color.Yellow;
            txtPasswordLogin.Location = new Point(120, 48);
            txtPasswordLogin.MaxLength = 32767;
            txtPasswordLogin.Multiline = false;
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.ReadOnly = false;
            txtPasswordLogin.Size = new Size(312, 29);
            txtPasswordLogin.TabIndex = 10;
            txtPasswordLogin.TextAlign = HorizontalAlignment.Left;
            txtPasswordLogin.UseSystemPasswordChar = false;
            // 
            // lblUserNameLogin
            // 
            lblUserNameLogin.AutoSize = true;
            lblUserNameLogin.Location = new Point(8, 16);
            lblUserNameLogin.Name = "lblUserNameLogin";
            lblUserNameLogin.Size = new Size(105, 15);
            lblUserNameLogin.TabIndex = 14;
            lblUserNameLogin.Text = "UserName (Email):";
            // 
            // lblPasswordLogin
            // 
            lblPasswordLogin.AutoSize = true;
            lblPasswordLogin.Location = new Point(56, 56);
            lblPasswordLogin.Name = "lblPasswordLogin";
            lblPasswordLogin.Size = new Size(60, 15);
            lblPasswordLogin.TabIndex = 15;
            lblPasswordLogin.Text = "Password:";
            // 
            // registerTabPage
            // 
            registerTabPage.BackColor = Color.White;
            registerTabPage.BorderStyle = BorderStyle.FixedSingle;
            registerTabPage.Controls.Add(lblErrorMessageRegister);
            registerTabPage.Controls.Add(btnCancelRegister);
            registerTabPage.Controls.Add(btnRegister);
            registerTabPage.Controls.Add(lblConfirmPasswordRegister);
            registerTabPage.Controls.Add(lblPasswordRegister);
            registerTabPage.Controls.Add(lblUserNameRegister);
            registerTabPage.Controls.Add(txtUserNameRegister);
            registerTabPage.Controls.Add(txtPasswordRegister);
            registerTabPage.Controls.Add(txtConfirmPasswordRegister);
            registerTabPage.Location = new Point(119, 4);
            registerTabPage.Name = "registerTabPage";
            registerTabPage.Padding = new Padding(3);
            registerTabPage.Size = new Size(441, 200);
            registerTabPage.TabIndex = 1;
            registerTabPage.Text = "Register";
            // 
            // lblErrorMessageRegister
            // 
            lblErrorMessageRegister.AutoSize = true;
            lblErrorMessageRegister.ForeColor = Color.Red;
            lblErrorMessageRegister.Location = new Point(8, 128);
            lblErrorMessageRegister.Name = "lblErrorMessageRegister";
            lblErrorMessageRegister.Size = new Size(84, 15);
            lblErrorMessageRegister.TabIndex = 8;
            lblErrorMessageRegister.Text = "ErrorMessage: ";
            // 
            // btnCancelRegister
            // 
            btnCancelRegister.BackColor = Color.Transparent;
            btnCancelRegister.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCancelRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelRegister.Image = null;
            btnCancelRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelRegister.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCancelRegister.Location = new Point(320, 160);
            btnCancelRegister.Name = "btnCancelRegister";
            btnCancelRegister.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancelRegister.Size = new Size(112, 32);
            btnCancelRegister.TabIndex = 4;
            btnCancelRegister.Text = "Cancel";
            btnCancelRegister.TextAlignment = StringAlignment.Center;
            btnCancelRegister.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.EnteredColor = Color.FromArgb(32, 34, 37);
            btnRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Image = null;
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.InactiveColor = Color.FromArgb(32, 34, 37);
            btnRegister.Location = new Point(8, 160);
            btnRegister.Name = "btnRegister";
            btnRegister.PressedColor = Color.Green;
            btnRegister.Size = new Size(112, 32);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.TextAlignment = StringAlignment.Center;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblConfirmPasswordRegister
            // 
            lblConfirmPasswordRegister.AutoSize = true;
            lblConfirmPasswordRegister.Location = new Point(8, 96);
            lblConfirmPasswordRegister.Name = "lblConfirmPasswordRegister";
            lblConfirmPasswordRegister.Size = new Size(107, 15);
            lblConfirmPasswordRegister.TabIndex = 7;
            lblConfirmPasswordRegister.Text = "Confirm password:";
            // 
            // lblPasswordRegister
            // 
            lblPasswordRegister.AutoSize = true;
            lblPasswordRegister.Location = new Point(56, 56);
            lblPasswordRegister.Name = "lblPasswordRegister";
            lblPasswordRegister.Size = new Size(60, 15);
            lblPasswordRegister.TabIndex = 6;
            lblPasswordRegister.Text = "Password:";
            // 
            // lblUserNameRegister
            // 
            lblUserNameRegister.AutoSize = true;
            lblUserNameRegister.Location = new Point(8, 16);
            lblUserNameRegister.Name = "lblUserNameRegister";
            lblUserNameRegister.Size = new Size(105, 15);
            lblUserNameRegister.TabIndex = 5;
            lblUserNameRegister.Text = "UserName (Email):";
            // 
            // txtUserNameRegister
            // 
            txtUserNameRegister.BackColor = Color.Transparent;
            txtUserNameRegister.BaseColor = Color.FromArgb(45, 47, 49);
            txtUserNameRegister.BorderColor = Color.FromArgb(35, 168, 109);
            txtUserNameRegister.FocusOnHover = false;
            txtUserNameRegister.ForeColor = Color.Yellow;
            txtUserNameRegister.Location = new Point(120, 8);
            txtUserNameRegister.MaxLength = 32767;
            txtUserNameRegister.Multiline = false;
            txtUserNameRegister.Name = "txtUserNameRegister";
            txtUserNameRegister.ReadOnly = false;
            txtUserNameRegister.Size = new Size(312, 29);
            txtUserNameRegister.TabIndex = 0;
            txtUserNameRegister.TextAlign = HorizontalAlignment.Left;
            txtUserNameRegister.UseSystemPasswordChar = false;
            // 
            // txtPasswordRegister
            // 
            txtPasswordRegister.BackColor = Color.Transparent;
            txtPasswordRegister.BaseColor = Color.FromArgb(45, 47, 49);
            txtPasswordRegister.BorderColor = Color.FromArgb(35, 168, 109);
            txtPasswordRegister.FocusOnHover = false;
            txtPasswordRegister.ForeColor = Color.Yellow;
            txtPasswordRegister.Location = new Point(120, 48);
            txtPasswordRegister.MaxLength = 32767;
            txtPasswordRegister.Multiline = false;
            txtPasswordRegister.Name = "txtPasswordRegister";
            txtPasswordRegister.ReadOnly = false;
            txtPasswordRegister.Size = new Size(312, 29);
            txtPasswordRegister.TabIndex = 1;
            txtPasswordRegister.TextAlign = HorizontalAlignment.Left;
            txtPasswordRegister.UseSystemPasswordChar = false;
            // 
            // txtConfirmPasswordRegister
            // 
            txtConfirmPasswordRegister.BackColor = Color.Transparent;
            txtConfirmPasswordRegister.BaseColor = Color.FromArgb(45, 47, 49);
            txtConfirmPasswordRegister.BorderColor = Color.FromArgb(35, 168, 109);
            txtConfirmPasswordRegister.FocusOnHover = false;
            txtConfirmPasswordRegister.ForeColor = Color.Yellow;
            txtConfirmPasswordRegister.Location = new Point(120, 88);
            txtConfirmPasswordRegister.MaxLength = 32767;
            txtConfirmPasswordRegister.Multiline = false;
            txtConfirmPasswordRegister.Name = "txtConfirmPasswordRegister";
            txtConfirmPasswordRegister.ReadOnly = false;
            txtConfirmPasswordRegister.Size = new Size(312, 29);
            txtConfirmPasswordRegister.TabIndex = 2;
            txtConfirmPasswordRegister.TextAlign = HorizontalAlignment.Left;
            txtConfirmPasswordRegister.UseSystemPasswordChar = false;
            // 
            // loginForm
            // 
            ClientSize = new Size(564, 208);
            Controls.Add(loginTabContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = resources.GetObject("$this.Icon") as Icon;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter your credentials";
            Load += loginForm_Load;
            loginTabContainer.ResumeLayout(false);
            loginTabPage.ResumeLayout(false);
            loginTabPage.PerformLayout();
            registerTabPage.ResumeLayout(false);
            registerTabPage.PerformLayout();
            ResumeLayout(false);
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            var loginModel = GetLoginModel();
            if (!ModelState.IsValid(loginModel))
            {
                SetLblErrorMessageValue(lblErrorMessageLogin ?? throw new ArgumentNullException(nameof(lblErrorMessageLogin)), true,
                    string.Concat("ErrorMessage: ", ModelState.ErrorMessages.FirstOrDefault()));
                return;
            }

            _hashedLogin = _INIFileService.IniReadValue(
                _credentialsFileExtension, nameof(_hashedLogin), _appLoginCredentialsFilePath);
            _hashedPassword = _INIFileService.IniReadValue(
                _credentialsFileExtension, nameof(_hashedPassword), _appLoginCredentialsFilePath);
            if (!_secretHasherService.Verify(txtUserNameLogin?.Text ?? throw new ArgumentNullException(nameof(txtUserNameLogin)), _hashedLogin) ||
                !_secretHasherService.Verify(txtPasswordLogin?.Text ?? throw new ArgumentNullException(nameof(txtPasswordLogin)), _hashedPassword))
            {
                SetLblErrorMessageValue(lblErrorMessageLogin ?? throw new ArgumentNullException(nameof(lblErrorMessageLogin)), true, 
                    string.Concat("ErrorMessage: ", "UserName (Email) or password is incorrect!"));
                return;
            }

            SetLblErrorMessageValue(lblErrorMessageLogin ?? throw new ArgumentNullException(nameof(lblErrorMessageLogin)), false, null);

            this.Hide();
            _mainForm.AppDataPath = _appDataPath;
            _mainForm.AppWorkflowFilePath = Path.Combine(_appDataPath, string.Concat(_currentProcessName, ".", _workflowFileExtension));
            _ = _mainForm.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            var registerModel = GetRegisterModel();
            if (!ModelState.IsValid(registerModel))
            {
                SetLblErrorMessageValue(lblErrorMessageRegister ?? throw new ArgumentNullException(nameof(lblErrorMessageRegister)), true, 
                    string.Concat("ErrorMessage: ", ModelState.ErrorMessages.FirstOrDefault()));
                return;
            }
            if (!string.Equals(
                txtPasswordRegister?.Text ?? throw new ArgumentNullException(nameof(txtPasswordRegister)), 
                txtConfirmPasswordRegister?.Text ?? throw new ArgumentNullException(nameof(txtConfirmPasswordRegister))))
            {
                SetLblErrorMessageValue(lblErrorMessageRegister ?? throw new ArgumentNullException(nameof(lblErrorMessageRegister)), 
                    true, string.Concat("ErrorMessage: ", "ConfirmPassword text is incorrect!"));
                return;
            }
            SetLblErrorMessageValue(lblErrorMessageRegister ?? throw new ArgumentNullException(nameof(lblErrorMessageRegister)), false, null);

            _hashedLogin = _secretHasherService.Hash(txtUserNameRegister?.Text ?? throw new ArgumentNullException(nameof(txtUserNameRegister)));
            _hashedPassword = _secretHasherService.Hash(txtPasswordRegister?.Text ?? throw new ArgumentNullException(nameof(txtPasswordRegister)));
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
                UserName = txtUserNameRegister?.Text ?? throw new ArgumentNullException(nameof(txtUserNameRegister)),
                Password = txtPasswordRegister?.Text ?? throw new ArgumentNullException(nameof(txtPasswordRegister)),
                ConfirmPassword = txtConfirmPasswordRegister?.Text ?? throw new ArgumentNullException(nameof(txtConfirmPasswordRegister))
            };
        }

        private Login GetLoginModel()
        {
            return new Login()
            {
                UserName = txtUserNameLogin?.Text ?? throw new ArgumentNullException(nameof(txtUserNameLogin)),
                Password = txtPasswordLogin?.Text ?? throw new ArgumentNullException(nameof(txtPasswordLogin))
            };
        }

        private void btnResetPassword_Click(object? sender, EventArgs e)
        {

        }
    }
}