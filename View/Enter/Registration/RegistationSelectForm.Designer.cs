namespace Registration
{
    partial class RegistationSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistationSelectForm));
            this.loadAthorForm = new System.Windows.Forms.Button();
            this.loadUserForm = new System.Windows.Forms.Button();
            this.meBox = new System.Windows.Forms.RichTextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadAthorForm
            // 
            this.loadAthorForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadAthorForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.loadAthorForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadAthorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadAthorForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadAthorForm.Location = new System.Drawing.Point(172, 277);
            this.loadAthorForm.Name = "loadAthorForm";
            this.loadAthorForm.Size = new System.Drawing.Size(340, 45);
            this.loadAthorForm.TabIndex = 4;
            this.loadAthorForm.Text = "Автор";
            this.loadAthorForm.UseVisualStyleBackColor = false;
            this.loadAthorForm.Click += new System.EventHandler(this.ClickLoadAuthorRegistrationForm);
            // 
            // loadUserForm
            // 
            this.loadUserForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadUserForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.loadUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadUserForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadUserForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadUserForm.Location = new System.Drawing.Point(172, 226);
            this.loadUserForm.Name = "loadUserForm";
            this.loadUserForm.Size = new System.Drawing.Size(340, 45);
            this.loadUserForm.TabIndex = 5;
            this.loadUserForm.Text = "Користувач";
            this.loadUserForm.UseVisualStyleBackColor = false;
            this.loadUserForm.Click += new System.EventHandler(this.ClickLoadUserRegistrationForm);
            // 
            // meBox
            // 
            this.meBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meBox.BackColor = System.Drawing.Color.SteelBlue;
            this.meBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.meBox.Location = new System.Drawing.Point(192, 135);
            this.meBox.Name = "meBox";
            this.meBox.ReadOnly = true;
            this.meBox.Size = new System.Drawing.Size(320, 68);
            this.meBox.TabIndex = 6;
            this.meBox.Text = "Я майбутній";
            this.meBox.TextChanged += new System.EventHandler(this.meBox_TextChanged);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.Location = new System.Drawing.Point(257, 357);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 45);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.ClickBackButton);
            // 
            // RegistationSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.meBox);
            this.Controls.Add(this.loadUserForm);
            this.Controls.Add(this.loadAthorForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 580);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "RegistationSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма вибору реєстрації";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadAthorForm;
        private System.Windows.Forms.Button loadUserForm;
        private System.Windows.Forms.RichTextBox meBox;
        private System.Windows.Forms.Button backButton;
    }
}