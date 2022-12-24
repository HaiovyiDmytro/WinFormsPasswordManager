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
            this.settingsLayout = new System.Windows.Forms.TabPage();
            this.aboutSpace = new System.Windows.Forms.TabPage();
            this.mainLayoutTabPage.SuspendLayout();
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
            this.mainLayout.Location = new System.Drawing.Point(139, 4);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(3);
            this.mainLayout.Size = new System.Drawing.Size(741, 453);
            this.mainLayout.TabIndex = 0;
            this.mainLayout.Text = "Work space";
            // 
            // settingsLayout
            // 
            this.settingsLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
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
            this.aboutSpace.Location = new System.Drawing.Point(139, 4);
            this.aboutSpace.Name = "aboutSpace";
            this.aboutSpace.Size = new System.Drawing.Size(741, 453);
            this.aboutSpace.TabIndex = 2;
            this.aboutSpace.Text = "About";
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
            this.Text = "Windows password manager";
            this.mainLayoutTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.TabPage mainLayoutTabPage;
        private TabPage mainLayout;
        private TabPage settingsLayout;
        private TabPage aboutSpace;
    }
}