using Newtonsoft.Json.Linq;

using PasswordManager.Models;
using PasswordManager.Services;

namespace PasswordManager
{
    internal partial class mainForm : Form
    {
        internal string AppDataPath { get; set; }
        internal string AppWorkflowFilePath { get; set; }

        private readonly IDirectoryService _directoryService;
        private readonly IFileService _fileService;

        private WorkflowCollection _workflowCollection { get; set; } = new();

        public mainForm(IDirectoryService directoryService, IFileService fileService)
        {
            InitializeComponent();

            _directoryService = directoryService;
            _fileService = fileService;

            workSpaceDataGridView.AutoGenerateColumns = false;
            workSpaceDataGridView.Columns[nameof(BaseEntity.ResourceName)].DataPropertyName = nameof(BaseEntity.ResourceName);
            workSpaceDataGridView.Columns[nameof(BaseEntity.Login)].DataPropertyName = nameof(BaseEntity.Login);
            workSpaceDataGridView.Columns[nameof(BaseEntity.Password)].DataPropertyName = nameof(BaseEntity.Password);
            workSpaceDataGridView.Columns[nameof(BaseEntity.Link)].DataPropertyName = nameof(BaseEntity.Link);
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            txtFindRecord.Width = mainPanel.ClientRectangle.Width - btnMoveFirst.Width * 8;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (!_directoryService.DirectoryExists(AppDataPath))
            {
                _ = _directoryService.CreateDirectory(AppDataPath);
            }

            if (!_fileService.FileExists(AppWorkflowFilePath))
            {
                _ = _fileService.CreateFile(AppWorkflowFilePath);
            }

            string? fileContent = _fileService.ReadAllText(AppWorkflowFilePath);
            if (!string.IsNullOrEmpty(fileContent) && !string.IsNullOrWhiteSpace(fileContent))
            {
                JObject exValues = JObject.Parse(fileContent);
                _workflowCollection = exValues.ToObject<WorkflowCollection>() ?? new();
            }
            else
            {
                _workflowCollection.BaseEntities = new SortableBindingList<BaseEntity>()
                {
                    new BaseEntity()
                    {
                        Id = Guid.NewGuid(),
                        Login = "Login",
                        Password = "Password",
                        ResourceName = "ResourceName",
                        Link = "Github.com",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    },
                    new BaseEntity()
                    {
                        Id = Guid.NewGuid(),
                        Login = "Login1",
                        Password = "Password1",
                        ResourceName = "ResourceName1",
                        Link = "https://github.com/",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    }
                };
            }

            BindingSource? source = new()
            {
                DataSource = _workflowCollection.BaseEntities
            };
            workSpaceDataGridView.DataSource = source;

            txtFindRecord.Width = mainPanel.ClientRectangle.Width - btnMoveFirst.Width * 8;
        }
    }
}