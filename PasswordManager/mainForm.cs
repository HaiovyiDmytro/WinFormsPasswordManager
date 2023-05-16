using Newtonsoft.Json.Linq;

using PasswordManager.Models;
using PasswordManager.Services;

namespace PasswordManager
{
    internal partial class mainForm : Form
    {
        public string AppDataPath { get; set; }
        public string AppWorkflowFilePath { get; set; }

        private readonly IDirectoryService _directoryService;
        private readonly IFileService _fileService;

        private WorkflowCollection _workflowCollection { get; set; } = new();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public mainForm(IDirectoryService directoryService, IFileService fileService)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();

            _directoryService = directoryService;
            _fileService = fileService;

            workSpaceDataGridView.AutoGenerateColumns = false;
            workSpaceDataGridView.Columns[nameof(Entity.ResourceName)].DataPropertyName = nameof(Entity.ResourceName);
            workSpaceDataGridView.Columns[nameof(Entity.Login)].DataPropertyName = nameof(Entity.Login);
            workSpaceDataGridView.Columns[nameof(Entity.Password)].DataPropertyName = nameof(Entity.Password);
            workSpaceDataGridView.Columns[nameof(Entity.Link)].DataPropertyName = nameof(Entity.Link);
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            InitComponents();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (!_directoryService.DirectoryExists(AppDataPath))
            {
                _ = _directoryService.CreateDirectory(AppDataPath);
            }

            if (!_fileService.FileExists(AppWorkflowFilePath))
            {
                _fileService.CreateFile(AppWorkflowFilePath);
            }

            string? fileContent = _fileService.ReadAllText(AppWorkflowFilePath);
            if (!string.IsNullOrEmpty(fileContent) && !string.IsNullOrWhiteSpace(fileContent))
            {
                JObject exValues = JObject.Parse(fileContent);
                _workflowCollection = exValues.ToObject<WorkflowCollection>() ?? new();
            }
            else
            {
                _workflowCollection.BaseEntities = new SortableBindingList<Entity>()
                {
                    new Entity()
                    {
                        Id = Guid.NewGuid(),
                        Login = "Login",
                        Password = "Password",
                        ResourceName = "ResourceName",
                        Link = "Github.com",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    },
                    new Entity()
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

            InitComponents();
        }

        private void InitComponents()
        {
            txtFindRecord.Width = mainPanel.ClientRectangle.Width - btnMoveFirst.Width * 8;
        }
    }
}