namespace Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.RichTextBox();
            this.password = new System.Windows.Forms.RichTextBox();
            this.loginTitle = new System.Windows.Forms.RichTextBox();
            this.passwordTitle = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(172, 298);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(340, 45);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Увійти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.ClickLoginButton);
            // 
            // regButton
            // 
            this.regButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.regButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.regButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.regButton.Location = new System.Drawing.Point(172, 358);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(340, 45);
            this.regButton.TabIndex = 4;
            this.regButton.Text = "Зареєструватись";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.ClickRegButton);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(172, 32);
            this.login.Multiline = false;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(340, 39);
            this.login.TabIndex = 1;
            this.login.Text = "";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(172, 108);
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(340, 41);
            this.password.TabIndex = 2;
            this.password.Text = "";
            this.password.TextChanged += new System.EventHandler(this.PasswordTextChanged);
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.loginTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginTitle.Location = new System.Drawing.Point(24, 32);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.ReadOnly = true;
            this.loginTitle.Size = new System.Drawing.Size(142, 39);
            this.loginTitle.TabIndex = 1;
            this.loginTitle.TabStop = false;
            this.loginTitle.Text = "Логін:";
            // 
            // passwordTitle
            // 
            this.passwordTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.passwordTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordTitle.Location = new System.Drawing.Point(24, 108);
            this.passwordTitle.Name = "passwordTitle";
            this.passwordTitle.ReadOnly = true;
            this.passwordTitle.Size = new System.Drawing.Size(142, 41);
            this.passwordTitle.TabIndex = 1;
            this.passwordTitle.TabStop = false;
            this.passwordTitle.Text = "Пароль:";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.passwordTitle);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.login);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.loginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 580);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід у додаток";
            this.Load += new System.EventHandler(this.LoadLoginForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.RichTextBox login;
        private System.Windows.Forms.RichTextBox password;
        private System.Windows.Forms.RichTextBox loginTitle;
        private System.Windows.Forms.RichTextBox passwordTitle;
    }
}