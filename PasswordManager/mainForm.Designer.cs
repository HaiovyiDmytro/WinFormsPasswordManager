namespace WPManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainLayoutTabPage = new ReaLTaiizor.Controls.TabPage();
            this.mainLayout = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.btnMovePrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFindRecord = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMoveLast = new System.Windows.Forms.ToolStripButton();
            this.btnMoveNext = new System.Windows.Forms.ToolStripButton();
            this.workSpaceDataGridView = new System.Windows.Forms.DataGridView();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditOrSave = new System.Windows.Forms.Button();
            this.btnShowOrHidePassword = new System.Windows.Forms.Button();
            this.btnCopyValue = new System.Windows.Forms.Button();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtResourceDescription = new System.Windows.Forms.TextBox();
            this.lblResourceDescription = new System.Windows.Forms.Label();
            this.txtResourceName = new System.Windows.Forms.TextBox();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.settingsLayout = new System.Windows.Forms.TabPage();
            this.aboutSpace = new System.Windows.Forms.TabPage();
            this.exit = new System.Windows.Forms.TabPage();
            this.mainLayoutTabPage.SuspendLayout();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workSpaceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutTabPage
            // 
            this.mainLayoutTabPage.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainLayoutTabPage.ActiveLineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.mainLayoutTabPage.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.mainLayoutTabPage.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainLayoutTabPage.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.mainLayoutTabPage.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.mainLayoutTabPage.ControlBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.mainLayoutTabPage.Controls.Add(this.mainLayout);
            this.mainLayoutTabPage.Controls.Add(this.settingsLayout);
            this.mainLayoutTabPage.Controls.Add(this.aboutSpace);
            this.mainLayoutTabPage.Controls.Add(this.exit);
            this.mainLayoutTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutTabPage.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainLayoutTabPage.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.mainLayoutTabPage.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.mainLayoutTabPage.ItemSize = new System.Drawing.Size(44, 135);
            this.mainLayoutTabPage.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.mainLayoutTabPage.LineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.mainLayoutTabPage.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutTabPage.Multiline = true;
            this.mainLayoutTabPage.Name = "mainLayoutTabPage";
            this.mainLayoutTabPage.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.mainLayoutTabPage.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.mainLayoutTabPage.SelectedIndex = 0;
            this.mainLayoutTabPage.Size = new System.Drawing.Size(884, 461);
            this.mainLayoutTabPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainLayoutTabPage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.mainLayoutTabPage.StringType = System.Drawing.StringAlignment.Near;
            this.mainLayoutTabPage.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.mainLayoutTabPage.TabIndex = 3;
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.mainLayout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLayout.Controls.Add(this.splitContainer);
            this.mainLayout.Location = new System.Drawing.Point(139, 4);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(3);
            this.mainLayout.Size = new System.Drawing.Size(741, 453);
            this.mainLayout.TabIndex = 0;
            this.mainLayout.Text = "Work space";
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.toolStrip);
            this.splitContainer.Panel1.Controls.Add(this.workSpaceDataGridView);
            this.splitContainer.Panel1MinSize = 300;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer.Panel2.Controls.Add(this.btnEditOrSave);
            this.splitContainer.Panel2.Controls.Add(this.btnShowOrHidePassword);
            this.splitContainer.Panel2.Controls.Add(this.btnCopyValue);
            this.splitContainer.Panel2.Controls.Add(this.btnGeneratePassword);
            this.splitContainer.Panel2.Controls.Add(this.txtPassword);
            this.splitContainer.Panel2.Controls.Add(this.lblPassword);
            this.splitContainer.Panel2.Controls.Add(this.txtLogin);
            this.splitContainer.Panel2.Controls.Add(this.lblLogin);
            this.splitContainer.Panel2.Controls.Add(this.txtResourceDescription);
            this.splitContainer.Panel2.Controls.Add(this.lblResourceDescription);
            this.splitContainer.Panel2.Controls.Add(this.txtResourceName);
            this.splitContainer.Panel2.Controls.Add(this.lblResourceName);
            this.splitContainer.Panel2.Controls.Add(this.statusStrip);
            this.splitContainer.Panel2MinSize = 400;
            this.splitContainer.Size = new System.Drawing.Size(731, 443);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoveFirst,
            this.btnMovePrevious,
            this.toolStripSeparator1,
            this.txtFindRecord,
            this.toolStripSeparator2,
            this.btnMoveLast,
            this.btnMoveNext});
            this.toolStrip.Location = new System.Drawing.Point(0, 416);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(298, 25);
            this.toolStrip.TabIndex = 1;
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveFirst.Image")));
            this.btnMoveFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(23, 22);
            this.btnMoveFirst.ToolTipText = "Move first record";
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnMovePrevious.Image")));
            this.btnMovePrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(23, 22);
            this.btnMovePrevious.ToolTipText = "Move prev record";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtFindRecord
            // 
            this.txtFindRecord.AutoSize = false;
            this.txtFindRecord.Name = "txtFindRecord";
            this.txtFindRecord.Size = new System.Drawing.Size(150, 25);
            this.txtFindRecord.ToolTipText = "find record";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveLast.Image")));
            this.btnMoveLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(23, 22);
            this.btnMoveLast.ToolTipText = "Move last record";
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveNext.Image")));
            this.btnMoveNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(23, 22);
            this.btnMoveNext.ToolTipText = "Move next record";
            // 
            // workSpaceDataGridView
            // 
            this.workSpaceDataGridView.AllowUserToOrderColumns = true;
            this.workSpaceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workSpaceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workSpaceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResourceName});
            this.workSpaceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.workSpaceDataGridView.MultiSelect = false;
            this.workSpaceDataGridView.Name = "workSpaceDataGridView";
            this.workSpaceDataGridView.ReadOnly = true;
            this.workSpaceDataGridView.RowTemplate.Height = 25;
            this.workSpaceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workSpaceDataGridView.Size = new System.Drawing.Size(298, 416);
            this.workSpaceDataGridView.TabIndex = 0;
            // 
            // ResourceName
            // 
            this.ResourceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResourceName.HeaderText = "Resource name";
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(240, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Discard changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditOrSave
            // 
            this.btnEditOrSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditOrSave.Location = new System.Drawing.Point(8, 376);
            this.btnEditOrSave.Name = "btnEditOrSave";
            this.btnEditOrSave.Size = new System.Drawing.Size(176, 32);
            this.btnEditOrSave.TabIndex = 15;
            this.btnEditOrSave.Text = "Edit";
            this.btnEditOrSave.UseVisualStyleBackColor = true;
            // 
            // btnShowOrHidePassword
            // 
            this.btnShowOrHidePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOrHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowOrHidePassword.Image")));
            this.btnShowOrHidePassword.Location = new System.Drawing.Point(384, 176);
            this.btnShowOrHidePassword.Name = "btnShowOrHidePassword";
            this.btnShowOrHidePassword.Size = new System.Drawing.Size(35, 32);
            this.btnShowOrHidePassword.TabIndex = 14;
            this.btnShowOrHidePassword.UseVisualStyleBackColor = true;
            // 
            // btnCopyValue
            // 
            this.btnCopyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyValue.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyValue.Image")));
            this.btnCopyValue.Location = new System.Drawing.Point(336, 176);
            this.btnCopyValue.Name = "btnCopyValue";
            this.btnCopyValue.Size = new System.Drawing.Size(35, 32);
            this.btnCopyValue.TabIndex = 13;
            this.btnCopyValue.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(8, 176);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(176, 32);
            this.btnGeneratePassword.TabIndex = 12;
            this.btnGeneratePassword.Text = "Generate password!";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(8, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(408, 23);
            this.txtPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(8, 88);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(408, 23);
            this.txtLogin.TabIndex = 7;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(8, 64);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 15);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login:";
            // 
            // txtResourceDescription
            // 
            this.txtResourceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResourceDescription.Location = new System.Drawing.Point(8, 240);
            this.txtResourceDescription.Multiline = true;
            this.txtResourceDescription.Name = "txtResourceDescription";
            this.txtResourceDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResourceDescription.Size = new System.Drawing.Size(408, 56);
            this.txtResourceDescription.TabIndex = 5;
            // 
            // lblResourceDescription
            // 
            this.lblResourceDescription.AutoSize = true;
            this.lblResourceDescription.Location = new System.Drawing.Point(8, 216);
            this.lblResourceDescription.Name = "lblResourceDescription";
            this.lblResourceDescription.Size = new System.Drawing.Size(120, 15);
            this.lblResourceDescription.TabIndex = 4;
            this.lblResourceDescription.Text = "Resource description:";
            // 
            // txtResourceName
            // 
            this.txtResourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResourceName.Location = new System.Drawing.Point(8, 32);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Size = new System.Drawing.Size(408, 23);
            this.txtResourceName.TabIndex = 3;
            // 
            // lblResourceName
            // 
            this.lblResourceName.AutoSize = true;
            this.lblResourceName.Location = new System.Drawing.Point(8, 8);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(91, 15);
            this.lblResourceName.TabIndex = 2;
            this.lblResourceName.Text = "Resource name:";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(425, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // settingsLayout
            // 
            this.settingsLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.settingsLayout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsLayout.Location = new System.Drawing.Point(139, 4);
            this.settingsLayout.Name = "settingsLayout";
            this.settingsLayout.Padding = new System.Windows.Forms.Padding(3);
            this.settingsLayout.Size = new System.Drawing.Size(741, 453);
            this.settingsLayout.TabIndex = 1;
            this.settingsLayout.Text = "Settings";
            // 
            // aboutSpace
            // 
            this.aboutSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.aboutSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aboutSpace.Location = new System.Drawing.Point(139, 4);
            this.aboutSpace.Name = "aboutSpace";
            this.aboutSpace.Size = new System.Drawing.Size(741, 453);
            this.aboutSpace.TabIndex = 2;
            this.aboutSpace.Text = "About";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exit.Location = new System.Drawing.Point(139, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(741, 453);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.mainLayoutTabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "mainForm";
            this.Text = "Password manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.mainLayoutTabPage.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workSpaceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.TabPage mainLayoutTabPage;
        private TabPage mainLayout;
        private TabPage settingsLayout;
        private TabPage aboutSpace;
        private SplitContainer splitContainer;
        private DataGridView workSpaceDataGridView;
        private DataGridViewTextBoxColumn ResourceName;
        private TabPage exit;
        private ToolStrip toolStrip;
        private StatusStrip statusStrip;
        private ToolStripButton btnMoveFirst;
        private ToolStripButton btnMovePrevious;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox txtFindRecord;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnMoveNext;
        private ToolStripButton btnMoveLast;
        private Button btnGeneratePassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtLogin;
        private Label lblLogin;
        private TextBox txtResourceDescription;
        private Label lblResourceDescription;
        private TextBox txtResourceName;
        private Label lblResourceName;
        private Button btnShowOrHidePassword;
        private Button btnCopyValue;
        private Button btnCancel;
        private Button btnEditOrSave;
    }
}