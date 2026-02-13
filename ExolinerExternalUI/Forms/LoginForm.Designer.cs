namespace ExolinerExternalUI {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.randomPhraseLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.processLogin = new System.ComponentModel.BackgroundWorker();
            this.rememberCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Inter SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(5, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(274, 57);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "EXOLINER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randomPhraseLabel
            // 
            this.randomPhraseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.randomPhraseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.randomPhraseLabel.Location = new System.Drawing.Point(5, 62);
            this.randomPhraseLabel.Name = "randomPhraseLabel";
            this.randomPhraseLabel.Size = new System.Drawing.Size(274, 24);
            this.randomPhraseLabel.TabIndex = 1;
            this.randomPhraseLabel.Text = "external";
            this.randomPhraseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailBox
            // 
            this.emailBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailBox.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(5, 148);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(274, 21);
            this.emailBox.TabIndex = 2;
            this.emailBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 48);
            this.panel1.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailLabel.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(5, 134);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(40, 14);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "e-mail";
            this.emailLabel.Visible = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordBox.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(5, 183);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(274, 21);
            this.passwordBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordLabel.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(5, 169);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(167, 14);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "JSON Web Token (JWT cookie)";
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginButton.Location = new System.Drawing.Point(5, 265);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(274, 21);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorLabel.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(5, 247);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(274, 18);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "error message";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processLogin
            // 
            this.processLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processLogin_DoWork);
            this.processLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.processLogin_RunWorkerCompleted);
            // 
            // rememberCheck
            // 
            this.rememberCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.rememberCheck.Location = new System.Drawing.Point(5, 204);
            this.rememberCheck.Name = "rememberCheck";
            this.rememberCheck.Size = new System.Drawing.Size(274, 31);
            this.rememberCheck.TabIndex = 9;
            this.rememberCheck.Text = "Remember me";
            this.rememberCheck.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.rememberCheck);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.randomPhraseLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exoliner - log in";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label randomPhraseLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label errorLabel;
        private System.ComponentModel.BackgroundWorker processLogin;
        private System.Windows.Forms.CheckBox rememberCheck;
    }
}