namespace PasswordManager
{
    partial class detailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.txtResourceName = new System.Windows.Forms.TextBox();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(552, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 32);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Discard changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditOrSave
            // 
            this.btnEditOrSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditOrSave.Location = new System.Drawing.Point(320, 384);
            this.btnEditOrSave.Name = "btnEditOrSave";
            this.btnEditOrSave.Size = new System.Drawing.Size(176, 32);
            this.btnEditOrSave.TabIndex = 27;
            this.btnEditOrSave.Text = "Edit";
            this.btnEditOrSave.UseVisualStyleBackColor = true;
            // 
            // btnShowOrHidePassword
            // 
            this.btnShowOrHidePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOrHidePassword.Image = global::PasswordManager.Properties.Resources.eye;
            this.btnShowOrHidePassword.Location = new System.Drawing.Point(696, 184);
            this.btnShowOrHidePassword.Name = "btnShowOrHidePassword";
            this.btnShowOrHidePassword.Size = new System.Drawing.Size(35, 32);
            this.btnShowOrHidePassword.TabIndex = 26;
            this.btnShowOrHidePassword.UseVisualStyleBackColor = true;
            // 
            // btnCopyValue
            // 
            this.btnCopyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyValue.Image = global::PasswordManager.Properties.Resources.copy;
            this.btnCopyValue.Location = new System.Drawing.Point(648, 184);
            this.btnCopyValue.Name = "btnCopyValue";
            this.btnCopyValue.Size = new System.Drawing.Size(35, 32);
            this.btnCopyValue.TabIndex = 25;
            this.btnCopyValue.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(320, 184);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(176, 32);
            this.btnGeneratePassword.TabIndex = 24;
            this.btnGeneratePassword.Text = "Generate password!";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(320, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(408, 23);
            this.txtPassword.TabIndex = 23;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(320, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password:";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(320, 96);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(408, 23);
            this.txtLogin.TabIndex = 21;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(320, 72);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 15);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Login:";
            // 
            // txtResourceDescription
            // 
            this.txtResourceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResourceDescription.Location = new System.Drawing.Point(320, 296);
            this.txtResourceDescription.Multiline = true;
            this.txtResourceDescription.Name = "txtResourceDescription";
            this.txtResourceDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResourceDescription.Size = new System.Drawing.Size(408, 56);
            this.txtResourceDescription.TabIndex = 19;
            // 
            // txtResourceName
            // 
            this.txtResourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResourceName.Location = new System.Drawing.Point(320, 40);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Size = new System.Drawing.Size(408, 23);
            this.txtResourceName.TabIndex = 18;
            // 
            // lblResourceName
            // 
            this.lblResourceName.AutoSize = true;
            this.lblResourceName.Location = new System.Drawing.Point(320, 16);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(91, 15);
            this.lblResourceName.TabIndex = 17;
            this.lblResourceName.Text = "Resource name:";
            // 
            // detailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditOrSave);
            this.Controls.Add(this.btnShowOrHidePassword);
            this.Controls.Add(this.btnCopyValue);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtResourceDescription);
            this.Controls.Add(this.txtResourceName);
            this.Controls.Add(this.lblResourceName);
            this.Name = "detailsForm";
            this.Text = "editForm";
            this.Load += new System.EventHandler(this.detailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnEditOrSave;
        private Button btnShowOrHidePassword;
        private Button btnCopyValue;
        private Button btnGeneratePassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtLogin;
        private Label lblLogin;
        private TextBox txtResourceDescription;
        private TextBox txtResourceName;
        private Label lblResourceName;
    }
}