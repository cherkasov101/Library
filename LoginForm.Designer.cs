namespace Library
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
            this.loginFormPanel = new System.Windows.Forms.Panel();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.collapseLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.adminEnterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFormPanel
            // 
            this.loginFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(95)))), ((int)(((byte)(84)))));
            this.loginFormPanel.Controls.Add(this.registrationLabel);
            this.loginFormPanel.Controls.Add(this.enterButton);
            this.loginFormPanel.Controls.Add(this.passwordTextBox);
            this.loginFormPanel.Controls.Add(this.idTextBox);
            this.loginFormPanel.Controls.Add(this.collapseLabel);
            this.loginFormPanel.Controls.Add(this.exitLabel);
            this.loginFormPanel.Controls.Add(this.adminEnterLabel);
            this.loginFormPanel.Controls.Add(this.label1);
            this.loginFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginFormPanel.Location = new System.Drawing.Point(0, 0);
            this.loginFormPanel.Name = "loginFormPanel";
            this.loginFormPanel.Size = new System.Drawing.Size(285, 415);
            this.loginFormPanel.TabIndex = 0;
            this.loginFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginFormPanel_MouseDown);
            this.loginFormPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginFormPanel_MouseMove);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.ForeColor = System.Drawing.Color.White;
            this.registrationLabel.Location = new System.Drawing.Point(101, 307);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(86, 17);
            this.registrationLabel.TabIndex = 7;
            this.registrationLabel.Text = "Регистрация";
            this.registrationLabel.MouseEnter += new System.EventHandler(this.registrationLabel_MouseEnter);
            this.registrationLabel.MouseLeave += new System.EventHandler(this.registrationLabel_MouseLeave);
            // 
            // enterButton
            // 
            this.enterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterButton.BackColor = System.Drawing.Color.White;
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(95)))), ((int)(((byte)(84)))));
            this.enterButton.Location = new System.Drawing.Point(86, 263);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(117, 29);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "ВОЙТИ";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(95)))), ((int)(((byte)(84)))));
            this.passwordTextBox.Location = new System.Drawing.Point(62, 204);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(164, 27);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordTextBox_MouseClick);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(95)))), ((int)(((byte)(84)))));
            this.idTextBox.Location = new System.Drawing.Point(62, 161);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(164, 27);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.idTextBox_MouseClick);
            // 
            // collapseLabel
            // 
            this.collapseLabel.AutoSize = true;
            this.collapseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collapseLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collapseLabel.ForeColor = System.Drawing.Color.White;
            this.collapseLabel.Location = new System.Drawing.Point(224, 9);
            this.collapseLabel.Name = "collapseLabel";
            this.collapseLabel.Size = new System.Drawing.Size(24, 26);
            this.collapseLabel.TabIndex = 3;
            this.collapseLabel.Text = "_";
            this.collapseLabel.Click += new System.EventHandler(this.collapseLabel_Click);
            this.collapseLabel.MouseEnter += new System.EventHandler(this.collapseLabel_MouseEnter);
            this.collapseLabel.MouseLeave += new System.EventHandler(this.collapseLabel_MouseLeave);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(249, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(24, 26);
            this.exitLabel.TabIndex = 2;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            this.exitLabel.MouseEnter += new System.EventHandler(this.exitLabel_MouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
            // 
            // adminEnterLabel
            // 
            this.adminEnterLabel.AutoSize = true;
            this.adminEnterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminEnterLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEnterLabel.ForeColor = System.Drawing.Color.White;
            this.adminEnterLabel.Location = new System.Drawing.Point(12, 20);
            this.adminEnterLabel.Name = "adminEnterLabel";
            this.adminEnterLabel.Size = new System.Drawing.Size(120, 15);
            this.adminEnterLabel.TabIndex = 1;
            this.adminEnterLabel.Text = "Вход для сотрудника";
            this.adminEnterLabel.MouseEnter += new System.EventHandler(this.adminEnterLabel_MouseEnter);
            this.adminEnterLabel.MouseLeave += new System.EventHandler(this.adminEnterLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 415);
            this.Controls.Add(this.loginFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.loginFormPanel.ResumeLayout(false);
            this.loginFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginFormPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label collapseLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label adminEnterLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button enterButton;
    }
}

