namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName_textbox = new System.Windows.Forms.TextBox();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sign_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName_textbox
            // 
            this.UserName_textbox.Location = new System.Drawing.Point(76, 39);
            this.UserName_textbox.Name = "UserName_textbox";
            this.UserName_textbox.Size = new System.Drawing.Size(192, 20);
            this.UserName_textbox.TabIndex = 0;
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(76, 81);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(192, 20);
            this.Email_textbox.TabIndex = 1;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(76, 123);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(192, 20);
            this.password_textbox.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(13, 39);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(53, 13);
            this.Username.TabIndex = 3;
            this.Username.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "password";
            // 
            // sign_button
            // 
            this.sign_button.Location = new System.Drawing.Point(76, 162);
            this.sign_button.Name = "sign_button";
            this.sign_button.Size = new System.Drawing.Size(75, 23);
            this.sign_button.TabIndex = 6;
            this.sign_button.Text = "sign in ";
            this.sign_button.UseVisualStyleBackColor = true;
            this.sign_button.Click += new System.EventHandler(this.sign_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(193, 162);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 7;
            this.close_button.Text = "close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.sign_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.UserName_textbox);
            this.Name = "Form1";
            this.Text = "email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName_textbox;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sign_button;
        private System.Windows.Forms.Button close_button;
    }
}
