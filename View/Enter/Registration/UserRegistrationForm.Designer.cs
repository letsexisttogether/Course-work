namespace Registration
{
    partial class UserRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            this.regButton = new System.Windows.Forms.Button();
            this.passwordTitle = new System.Windows.Forms.RichTextBox();
            this.loginTitle = new System.Windows.Forms.RichTextBox();
            this.login = new System.Windows.Forms.RichTextBox();
            this.password = new System.Windows.Forms.RichTextBox();
            this.secondPassword = new System.Windows.Forms.RichTextBox();
            this.secondPasswordTitle = new System.Windows.Forms.RichTextBox();
            this.userNameTitle = new System.Windows.Forms.RichTextBox();
            this.userName = new System.Windows.Forms.RichTextBox();
            this.surnameTitle = new System.Windows.Forms.RichTextBox();
            this.surname = new System.Windows.Forms.RichTextBox();
            this.birthDateTitle = new System.Windows.Forms.RichTextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.backButton = new System.Windows.Forms.Button();
            this.emailTitle = new System.Windows.Forms.RichTextBox();
            this.email = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regButton.BackColor = System.Drawing.Color.White;
            this.regButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regButton.Location = new System.Drawing.Point(340, 485);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(170, 45);
            this.regButton.TabIndex = 6;
            this.regButton.TabStop = false;
            this.regButton.Text = "Далі";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.RegButtonClick);
            // 
            // passwordTitle
            // 
            this.passwordTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.passwordTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordTitle.Location = new System.Drawing.Point(22, 90);
            this.passwordTitle.Name = "passwordTitle";
            this.passwordTitle.ReadOnly = true;
            this.passwordTitle.Size = new System.Drawing.Size(142, 55);
            this.passwordTitle.TabIndex = 6;
            this.passwordTitle.TabStop = false;
            this.passwordTitle.Text = "Пароль:";
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginTitle.Location = new System.Drawing.Point(22, 29);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.ReadOnly = true;
            this.loginTitle.Size = new System.Drawing.Size(142, 55);
            this.loginTitle.TabIndex = 7;
            this.loginTitle.TabStop = false;
            this.loginTitle.Text = "Логін:";
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(170, 28);
            this.login.MaxLength = 30;
            this.login.Multiline = false;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(340, 55);
            this.login.TabIndex = 0;
            this.login.Text = "";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(170, 90);
            this.password.MaxLength = 30;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(340, 55);
            this.password.TabIndex = 1;
            this.password.Text = "";
            this.password.TextChanged += new System.EventHandler(this.FirstPasswordChanged);
            // 
            // secondPassword
            // 
            this.secondPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondPassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPassword.Location = new System.Drawing.Point(170, 151);
            this.secondPassword.MaxLength = 30;
            this.secondPassword.Multiline = false;
            this.secondPassword.Name = "secondPassword";
            this.secondPassword.Size = new System.Drawing.Size(340, 55);
            this.secondPassword.TabIndex = 2;
            this.secondPassword.Text = "";
            this.secondPassword.TextChanged += new System.EventHandler(this.SecondPasswordChanged);
            // 
            // secondPasswordTitle
            // 
            this.secondPasswordTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondPasswordTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.secondPasswordTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondPasswordTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.secondPasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPasswordTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.secondPasswordTitle.Location = new System.Drawing.Point(22, 152);
            this.secondPasswordTitle.Name = "secondPasswordTitle";
            this.secondPasswordTitle.ReadOnly = true;
            this.secondPasswordTitle.Size = new System.Drawing.Size(142, 55);
            this.secondPasswordTitle.TabIndex = 11;
            this.secondPasswordTitle.TabStop = false;
            this.secondPasswordTitle.Text = "Підтвердити пароль:";
            // 
            // userNameTitle
            // 
            this.userNameTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.userNameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userNameTitle.Location = new System.Drawing.Point(22, 276);
            this.userNameTitle.Name = "userNameTitle";
            this.userNameTitle.ReadOnly = true;
            this.userNameTitle.Size = new System.Drawing.Size(142, 55);
            this.userNameTitle.TabIndex = 13;
            this.userNameTitle.TabStop = false;
            this.userNameTitle.Text = "Ім\'я:";
            // 
            // userName
            // 
            this.userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(170, 276);
            this.userName.MaxLength = 40;
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(340, 55);
            this.userName.TabIndex = 4;
            this.userName.Text = "";
            // 
            // surnameTitle
            // 
            this.surnameTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.surnameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.surnameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.surnameTitle.Location = new System.Drawing.Point(22, 337);
            this.surnameTitle.Name = "surnameTitle";
            this.surnameTitle.ReadOnly = true;
            this.surnameTitle.Size = new System.Drawing.Size(142, 55);
            this.surnameTitle.TabIndex = 15;
            this.surnameTitle.TabStop = false;
            this.surnameTitle.Text = "Прізвище:";
            // 
            // surname
            // 
            this.surname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(170, 337);
            this.surname.MaxLength = 50;
            this.surname.Multiline = false;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(340, 55);
            this.surname.TabIndex = 5;
            this.surname.Text = "";
            // 
            // birthDateTitle
            // 
            this.birthDateTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDateTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.birthDateTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthDateTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.birthDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthDateTitle.Location = new System.Drawing.Point(22, 411);
            this.birthDateTitle.Name = "birthDateTitle";
            this.birthDateTitle.ReadOnly = true;
            this.birthDateTitle.Size = new System.Drawing.Size(142, 55);
            this.birthDateTitle.TabIndex = 16;
            this.birthDateTitle.TabStop = false;
            this.birthDateTitle.Text = "Дата народження:";
            // 
            // birthDate
            // 
            this.birthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthDate.Location = new System.Drawing.Point(170, 413);
            this.birthDate.MinDate = new System.DateTime(2023, 1, 9, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(339, 22);
            this.birthDate.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(170, 485);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 45);
            this.backButton.TabIndex = 19;
            this.backButton.TabStop = false;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.ClickBackButton);
            // 
            // emailTitle
            // 
            this.emailTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.emailTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailTitle.Location = new System.Drawing.Point(22, 222);
            this.emailTitle.Name = "emailTitle";
            this.emailTitle.ReadOnly = true;
            this.emailTitle.Size = new System.Drawing.Size(142, 40);
            this.emailTitle.TabIndex = 21;
            this.emailTitle.TabStop = false;
            this.emailTitle.Text = "Email:";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(170, 212);
            this.email.MaxLength = 40;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(340, 55);
            this.email.TabIndex = 3;
            this.email.Text = "";
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.emailTitle);
            this.Controls.Add(this.email);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.birthDateTitle);
            this.Controls.Add(this.surnameTitle);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.userNameTitle);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.secondPasswordTitle);
            this.Controls.Add(this.secondPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordTitle);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.regButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 900);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "UserRegistrationForm";
            this.Text = "Форма реєстаріції користувача";
            this.Load += new System.EventHandler(this.LoadRegistrationForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.RichTextBox passwordTitle;
        private System.Windows.Forms.RichTextBox loginTitle;
        private System.Windows.Forms.RichTextBox login;
        private System.Windows.Forms.RichTextBox password;
        private System.Windows.Forms.RichTextBox secondPassword;
        private System.Windows.Forms.RichTextBox secondPasswordTitle;
        private System.Windows.Forms.RichTextBox userNameTitle;
        private System.Windows.Forms.RichTextBox userName;
        private System.Windows.Forms.RichTextBox surnameTitle;
        private System.Windows.Forms.RichTextBox surname;
        private System.Windows.Forms.RichTextBox birthDateTitle;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.RichTextBox emailTitle;
        private System.Windows.Forms.RichTextBox email;
    }
}