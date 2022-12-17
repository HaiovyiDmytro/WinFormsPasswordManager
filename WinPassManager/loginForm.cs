using System.IO;

using WPManager.Services;

namespace WPManager
{
    public partial class loginForm : Form
    {
        private ReaLTaiizor.Controls.AirTabPage loginTabContainer;
        private TabPage loginTabPage;
        private ImageList loginFormImageList;
        private System.ComponentModel.IContainer components;
        private TabPage registerTabPage;

        private string _currentProcessName { get; set; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
        private string _userLocalDataPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private string _appDataPath { get; set; }
        private string _appLoginCredentialsFilePath { get; set; }

        public readonly IDirectoryService _directoryService;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginTabContainer = new ReaLTaiizor.Controls.AirTabPage();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.loginFormImageList = new System.Windows.Forms.ImageList(this.components);
            this.loginTabContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTabContainer
            // 
            this.loginTabContainer.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.loginTabContainer.Controls.Add(this.loginTabPage);
            this.loginTabContainer.Controls.Add(this.registerTabPage);
            this.loginTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTabContainer.ImageList = this.loginFormImageList;
            this.loginTabContainer.ItemSize = new System.Drawing.Size(30, 115);
            this.loginTabContainer.Location = new System.Drawing.Point(0, 0);
            this.loginTabContainer.Multiline = true;
            this.loginTabContainer.Name = "loginTabContainer";
            this.loginTabContainer.SelectedIndex = 0;
            this.loginTabContainer.ShowOuterBorders = true;
            this.loginTabContainer.Size = new System.Drawing.Size(498, 200);
            this.loginTabContainer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.loginTabContainer.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.loginTabContainer.TabIndex = 1;
            // 
            // loginTabPage
            // 
            this.loginTabPage.BackColor = System.Drawing.Color.White;
            this.loginTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTabPage.Location = new System.Drawing.Point(119, 4);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(375, 192);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Login";
            // 
            // registerTabPage
            // 
            this.registerTabPage.BackColor = System.Drawing.Color.White;
            this.registerTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerTabPage.Location = new System.Drawing.Point(119, 4);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerTabPage.Size = new System.Drawing.Size(375, 192);
            this.registerTabPage.TabIndex = 1;
            this.registerTabPage.Text = "Register";
            // 
            // loginFormImageList
            // 
            this.loginFormImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.loginFormImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("loginFormImageList.ImageStream")));
            this.loginFormImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.loginFormImageList.Images.SetKeyName(0, "login.ico");
            this.loginFormImageList.Images.SetKeyName(1, "register.ico");
            // 
            // loginForm
            // 
            this.ClientSize = new System.Drawing.Size(498, 200);
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
            this.ResumeLayout(false);

        }
    }
}