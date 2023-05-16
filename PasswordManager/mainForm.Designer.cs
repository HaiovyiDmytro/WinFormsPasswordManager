namespace PasswordManager
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            mainLayoutTabPage = new ReaLTaiizor.Controls.TabPage();
            mainLayout = new TabPage();
            mainPanel = new Panel();
            toolStrip = new ToolStrip();
            btnMoveFirst = new ToolStripButton();
            btnMovePrevious = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            txtFindRecord = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            btnMoveLast = new ToolStripButton();
            btnMoveNext = new ToolStripButton();
            btnFind = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            workSpaceDataGridView = new DataGridView();
            ResourceName = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Link = new DataGridViewLinkColumn();
            dgvContextMenuStrip = new ContextMenuStrip(components);
            mnuCopyLogin = new ToolStripMenuItem();
            mnuCopyPassword = new ToolStripMenuItem();
            mnuCopyLink = new ToolStripMenuItem();
            toolStripSeparator_1 = new ToolStripSeparator();
            mnuInsert = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            toolStripSeparator_0 = new ToolStripSeparator();
            mnuDelete = new ToolStripMenuItem();
            settingsLayout = new TabPage();
            aboutSpace = new TabPage();
            exit = new TabPage();
            mainLayoutTabPage.SuspendLayout();
            mainLayout.SuspendLayout();
            mainPanel.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workSpaceDataGridView).BeginInit();
            dgvContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutTabPage
            // 
            mainLayoutTabPage.ActiveForeColor = Color.FromArgb(254, 255, 255);
            mainLayoutTabPage.ActiveLineTabColor = Color.FromArgb(89, 169, 222);
            mainLayoutTabPage.ActiveTabColor = Color.FromArgb(35, 36, 38);
            mainLayoutTabPage.Alignment = TabAlignment.Left;
            mainLayoutTabPage.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            mainLayoutTabPage.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            mainLayoutTabPage.ControlBackColor = Color.FromArgb(54, 57, 64);
            mainLayoutTabPage.Controls.Add(mainLayout);
            mainLayoutTabPage.Controls.Add(settingsLayout);
            mainLayoutTabPage.Controls.Add(aboutSpace);
            mainLayoutTabPage.Controls.Add(exit);
            mainLayoutTabPage.Dock = DockStyle.Fill;
            mainLayoutTabPage.DrawMode = TabDrawMode.OwnerDrawFixed;
            mainLayoutTabPage.FrameColor = Color.FromArgb(41, 50, 63);
            mainLayoutTabPage.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            mainLayoutTabPage.ItemSize = new Size(44, 135);
            mainLayoutTabPage.LineColor = Color.FromArgb(25, 26, 28);
            mainLayoutTabPage.LineTabColor = Color.FromArgb(54, 57, 64);
            mainLayoutTabPage.Location = new Point(0, 0);
            mainLayoutTabPage.Multiline = true;
            mainLayoutTabPage.Name = "mainLayoutTabPage";
            mainLayoutTabPage.NormalForeColor = Color.FromArgb(159, 162, 167);
            mainLayoutTabPage.PageColor = Color.FromArgb(50, 63, 74);
            mainLayoutTabPage.SelectedIndex = 0;
            mainLayoutTabPage.Size = new Size(884, 461);
            mainLayoutTabPage.SizeMode = TabSizeMode.Fixed;
            mainLayoutTabPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            mainLayoutTabPage.StringType = StringAlignment.Near;
            mainLayoutTabPage.TabColor = Color.FromArgb(54, 57, 64);
            mainLayoutTabPage.TabIndex = 0;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(50, 63, 74);
            mainLayout.BorderStyle = BorderStyle.Fixed3D;
            mainLayout.Controls.Add(mainPanel);
            mainLayout.Location = new Point(139, 4);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(3);
            mainLayout.Size = new Size(741, 453);
            mainLayout.TabIndex = 0;
            mainLayout.Text = "Work space";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(toolStrip);
            mainPanel.Controls.Add(workSpaceDataGridView);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(3, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(731, 443);
            mainPanel.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Bottom;
            toolStrip.Items.AddRange(new ToolStripItem[] { btnMoveFirst, btnMovePrevious, toolStripSeparator1, txtFindRecord, toolStripSeparator2, btnMoveLast, btnMoveNext, btnFind, toolStripSeparator3 });
            toolStrip.Location = new Point(0, 418);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(731, 25);
            toolStrip.TabIndex = 1;
            // 
            // btnMoveFirst
            // 
            btnMoveFirst.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMoveFirst.Image = Properties.Resources.icons8_double_left_16;
            btnMoveFirst.ImageTransparentColor = Color.Magenta;
            btnMoveFirst.Name = "btnMoveFirst";
            btnMoveFirst.Size = new Size(23, 22);
            btnMoveFirst.ToolTipText = "Move first record";
            // 
            // btnMovePrevious
            // 
            btnMovePrevious.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMovePrevious.Image = Properties.Resources.icons8_prev_16;
            btnMovePrevious.ImageTransparentColor = Color.Magenta;
            btnMovePrevious.Name = "btnMovePrevious";
            btnMovePrevious.Size = new Size(23, 22);
            btnMovePrevious.ToolTipText = "Move prev record";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // txtFindRecord
            // 
            txtFindRecord.AutoSize = false;
            txtFindRecord.Name = "txtFindRecord";
            txtFindRecord.Size = new Size(150, 25);
            txtFindRecord.ToolTipText = "find record by resource name";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnMoveLast
            // 
            btnMoveLast.Alignment = ToolStripItemAlignment.Right;
            btnMoveLast.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMoveLast.Image = Properties.Resources.icons8_double_right_16;
            btnMoveLast.ImageTransparentColor = Color.Magenta;
            btnMoveLast.Name = "btnMoveLast";
            btnMoveLast.Size = new Size(23, 22);
            btnMoveLast.ToolTipText = "Move last record";
            // 
            // btnMoveNext
            // 
            btnMoveNext.Alignment = ToolStripItemAlignment.Right;
            btnMoveNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMoveNext.Image = Properties.Resources.icons8_forward_16;
            btnMoveNext.ImageTransparentColor = Color.Magenta;
            btnMoveNext.Name = "btnMoveNext";
            btnMoveNext.Size = new Size(23, 22);
            btnMoveNext.ToolTipText = "Move next record";
            // 
            // btnFind
            // 
            btnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFind.Image = Properties.Resources.icons8_search_16;
            btnFind.ImageTransparentColor = Color.Magenta;
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(23, 22);
            btnFind.ToolTipText = "Click to find record";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // workSpaceDataGridView
            // 
            workSpaceDataGridView.AllowUserToAddRows = false;
            workSpaceDataGridView.AllowUserToDeleteRows = false;
            workSpaceDataGridView.AllowUserToOrderColumns = true;
            workSpaceDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            workSpaceDataGridView.Columns.AddRange(new DataGridViewColumn[] { ResourceName, Login, Password, Link });
            workSpaceDataGridView.ContextMenuStrip = dgvContextMenuStrip;
            workSpaceDataGridView.Location = new Point(-2, 0);
            workSpaceDataGridView.MultiSelect = false;
            workSpaceDataGridView.Name = "workSpaceDataGridView";
            workSpaceDataGridView.ReadOnly = true;
            workSpaceDataGridView.RowTemplate.Height = 25;
            workSpaceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            workSpaceDataGridView.Size = new Size(735, 417);
            workSpaceDataGridView.TabIndex = 0;
            // 
            // ResourceName
            // 
            ResourceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ResourceName.HeaderText = "Resource name";
            ResourceName.Name = "ResourceName";
            ResourceName.ReadOnly = true;
            // 
            // Login
            // 
            Login.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Login.HeaderText = "Login";
            Login.Name = "Login";
            Login.ReadOnly = true;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Link
            // 
            Link.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Link.HeaderText = "Link";
            Link.Name = "Link";
            Link.ReadOnly = true;
            Link.Resizable = DataGridViewTriState.True;
            Link.SortMode = DataGridViewColumnSortMode.Automatic;
            Link.Text = "";
            // 
            // dgvContextMenuStrip
            // 
            dgvContextMenuStrip.Items.AddRange(new ToolStripItem[] { mnuCopyLogin, mnuCopyPassword, mnuCopyLink, toolStripSeparator_1, mnuInsert, mnuAdd, mnuEdit, toolStripSeparator_0, mnuDelete });
            dgvContextMenuStrip.Name = "dgvContextMenuStrip";
            dgvContextMenuStrip.Size = new Size(187, 170);
            // 
            // mnuCopyLogin
            // 
            mnuCopyLogin.Name = "mnuCopyLogin";
            mnuCopyLogin.Size = new Size(186, 22);
            mnuCopyLogin.Text = "Copy Login value";
            mnuCopyLogin.ToolTipText = "Copy selected Login value";
            // 
            // mnuCopyPassword
            // 
            mnuCopyPassword.Name = "mnuCopyPassword";
            mnuCopyPassword.Size = new Size(186, 22);
            mnuCopyPassword.Text = "Copy Password value";
            mnuCopyPassword.ToolTipText = "Copy selected Password value";
            // 
            // mnuCopyLink
            // 
            mnuCopyLink.Name = "mnuCopyLink";
            mnuCopyLink.Size = new Size(186, 22);
            mnuCopyLink.Text = "Copy Link value";
            mnuCopyLink.ToolTipText = "Copy selected Link value";
            // 
            // toolStripSeparator_1
            // 
            toolStripSeparator_1.Name = "toolStripSeparator_1";
            toolStripSeparator_1.Size = new Size(183, 6);
            // 
            // mnuInsert
            // 
            mnuInsert.Name = "mnuInsert";
            mnuInsert.Size = new Size(186, 22);
            mnuInsert.Text = "Insert item";
            mnuInsert.ToolTipText = "Insert item into collection";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(186, 22);
            mnuAdd.Text = "Add item";
            mnuAdd.ToolTipText = "Add item to end of collection";
            // 
            // mnuEdit
            // 
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(186, 22);
            mnuEdit.Text = "Edit item";
            mnuEdit.ToolTipText = "Edit current selected item";
            // 
            // toolStripSeparator_0
            // 
            toolStripSeparator_0.Name = "toolStripSeparator_0";
            toolStripSeparator_0.Size = new Size(183, 6);
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(186, 22);
            mnuDelete.Text = "Delete item";
            mnuDelete.ToolTipText = "Delete selected item from collection";
            // 
            // settingsLayout
            // 
            settingsLayout.BackColor = Color.FromArgb(50, 63, 74);
            settingsLayout.BorderStyle = BorderStyle.Fixed3D;
            settingsLayout.Location = new Point(139, 4);
            settingsLayout.Name = "settingsLayout";
            settingsLayout.Padding = new Padding(3);
            settingsLayout.Size = new Size(741, 453);
            settingsLayout.TabIndex = 1;
            settingsLayout.Text = "Settings";
            // 
            // aboutSpace
            // 
            aboutSpace.BackColor = Color.FromArgb(50, 63, 74);
            aboutSpace.BorderStyle = BorderStyle.Fixed3D;
            aboutSpace.Location = new Point(139, 4);
            aboutSpace.Name = "aboutSpace";
            aboutSpace.Size = new Size(741, 453);
            aboutSpace.TabIndex = 2;
            aboutSpace.Text = "About";
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(50, 63, 74);
            exit.BorderStyle = BorderStyle.Fixed3D;
            exit.Location = new Point(139, 4);
            exit.Name = "exit";
            exit.Size = new Size(741, 453);
            exit.TabIndex = 3;
            exit.Text = "Exit";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(mainLayoutTabPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 500);
            Name = "mainForm";
            Text = "Password manager";
            Load += mainForm_Load;
            Resize += mainForm_Resize;
            mainLayoutTabPage.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workSpaceDataGridView).EndInit();
            dgvContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.TabPage mainLayoutTabPage;
        private TabPage mainLayout;
        private TabPage settingsLayout;
        private TabPage aboutSpace;
        private TabPage exit;
        private Panel mainPanel;
        private ToolStrip toolStrip;
        private ToolStripButton btnMoveFirst;
        private ToolStripButton btnMovePrevious;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox txtFindRecord;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnMoveLast;
        private ToolStripButton btnMoveNext;
        private DataGridView workSpaceDataGridView;
        private ToolStripButton btnFind;
        private ToolStripSeparator toolStripSeparator3;
        private ContextMenuStrip dgvContextMenuStrip;
        private ToolStripMenuItem mnuCopyLogin;
        private ToolStripMenuItem mnuCopyPassword;
        private ToolStripMenuItem mnuCopyLink;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripMenuItem mnuInsert;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuEdit;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripMenuItem mnuDelete;
        private DataGridViewTextBoxColumn ResourceName;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewLinkColumn Link;
    }
}