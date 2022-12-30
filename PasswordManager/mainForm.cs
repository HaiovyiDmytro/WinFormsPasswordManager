namespace WPManager
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            txtFindRecord.Width = splitContainer.Panel1.ClientRectangle.Width - btnMoveFirst.Width * 6;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            txtFindRecord.Width = splitContainer.Panel1.ClientRectangle.Width - btnMoveFirst.Width * 6;

            ToolTip ButtonsToolTip = new();
            ButtonsToolTip.SetToolTip(btnCopyValue, "Copy password value");
            ButtonsToolTip.SetToolTip(btnShowOrHidePassword, "Show or hide password value");
        }
    }
}