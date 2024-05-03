namespace AdoNET
{
    partial class Login
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
            button1 = new Button();
            username = new MaskedTextBox();
            password = new MaskedTextBox();
            registerHref = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 112);
            button1.Name = "button1";
            button1.Size = new Size(158, 37);
            button1.TabIndex = 0;
            button1.Text = "Daxil ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // username
            // 
            username.Location = new Point(102, 33);
            username.Name = "username";
            username.Size = new Size(158, 23);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(102, 72);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(158, 23);
            password.TabIndex = 3;
            // 
            // registerHref
            // 
            registerHref.AutoSize = true;
            registerHref.Location = new Point(132, 152);
            registerHref.Name = "registerHref";
            registerHref.Size = new Size(101, 15);
            registerHref.TabIndex = 4;
            registerHref.TabStop = true;
            registerHref.Text = "Qeydiyyatdan keç";
            registerHref.LinkClicked += registerHref_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 246);
            Controls.Add(registerHref);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox username;
        private MaskedTextBox password;
        private LinkLabel registerHref;
    }
}