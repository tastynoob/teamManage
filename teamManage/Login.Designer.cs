namespace teamManage
{
    partial class Form_Login
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
            label_account = new Label();
            lable_password = new Label();
            textBox_account = new TextBox();
            textBox_password = new TextBox();
            btn_showpassword = new Button();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label_account
            // 
            label_account.AutoSize = true;
            label_account.Location = new Point(98, 89);
            label_account.Name = "label_account";
            label_account.Size = new Size(39, 20);
            label_account.TabIndex = 0;
            label_account.Text = "账号";
            // 
            // lable_password
            // 
            lable_password.AutoSize = true;
            lable_password.Location = new Point(98, 140);
            lable_password.Name = "lable_password";
            lable_password.Size = new Size(39, 20);
            lable_password.TabIndex = 1;
            lable_password.Text = "密码";
            // 
            // textBox_account
            // 
            textBox_account.BorderStyle = BorderStyle.FixedSingle;
            textBox_account.Location = new Point(157, 86);
            textBox_account.Name = "textBox_account";
            textBox_account.Size = new Size(125, 27);
            textBox_account.TabIndex = 2;
            textBox_account.WordWrap = false;
            // 
            // textBox_password
            // 
            textBox_password.BorderStyle = BorderStyle.FixedSingle;
            textBox_password.Location = new Point(157, 137);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(125, 27);
            textBox_password.TabIndex = 3;
            textBox_password.UseSystemPasswordChar = true;
            textBox_password.WordWrap = false;
            // 
            // btn_showpassword
            // 
            btn_showpassword.Location = new Point(303, 137);
            btn_showpassword.Name = "btn_showpassword";
            btn_showpassword.Size = new Size(83, 29);
            btn_showpassword.TabIndex = 4;
            btn_showpassword.Text = "显示密码";
            btn_showpassword.UseVisualStyleBackColor = true;
            btn_showpassword.Click += btn_showpassword_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(157, 191);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 5;
            btn_login.Text = "登录";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 313);
            Controls.Add(btn_login);
            Controls.Add(btn_showpassword);
            Controls.Add(textBox_password);
            Controls.Add(textBox_account);
            Controls.Add(lable_password);
            Controls.Add(label_account);
            Name = "Form_Login";
            Text = "登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_account;
        private Label lable_password;
        private TextBox textBox_account;
        private TextBox textBox_password;
        private Button btn_showpassword;
        private Button btn_login;
    }
}