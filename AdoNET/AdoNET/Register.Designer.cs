namespace AdoNET
{
    partial class Register
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
            name = new TextBox();
            surname = new TextBox();
            gender = new TextBox();
            username = new TextBox();
            password = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(86, 20);
            name.Name = "name";
            name.Size = new Size(191, 23);
            name.TabIndex = 0;
            // 
            // surname
            // 
            surname.Location = new Point(86, 49);
            surname.Name = "surname";
            surname.Size = new Size(191, 23);
            surname.TabIndex = 1;
            // 
            // gender
            // 
            gender.Location = new Point(86, 78);
            gender.Name = "gender";
            gender.Size = new Size(191, 23);
            gender.TabIndex = 2;
            // 
            // username
            // 
            username.Location = new Point(86, 107);
            username.Name = "username";
            username.Size = new Size(191, 23);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(86, 136);
            password.Name = "password";
            password.Size = new Size(191, 23);
            password.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(86, 176);
            button1.Name = "button1";
            button1.Size = new Size(191, 32);
            button1.TabIndex = 5;
            button1.Text = "Qeydiyyatdan kec";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 285);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(gender);
            Controls.Add(surname);
            Controls.Add(name);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox surname;
        private TextBox gender;
        private TextBox username;
        private TextBox password;
        private Button button1;
    }
}