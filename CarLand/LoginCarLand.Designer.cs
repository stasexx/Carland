namespace CarLand
{
    partial class LoginCarLand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCarLand));
            this.LoginToProgram = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.textBoxForLogin = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBoxForPassword = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginToProgram
            // 
            this.LoginToProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginToProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginToProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginToProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginToProgram.ForeColor = System.Drawing.Color.Black;
            this.LoginToProgram.Location = new System.Drawing.Point(117, 276);
            this.LoginToProgram.Name = "LoginToProgram";
            this.LoginToProgram.Size = new System.Drawing.Size(151, 66);
            this.LoginToProgram.TabIndex = 0;
            this.LoginToProgram.Text = "Вхід";
            this.LoginToProgram.UseVisualStyleBackColor = false;
            this.LoginToProgram.Click += new System.EventHandler(this.Login_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(133, 80);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(109, 42);
            this.Login.TabIndex = 1;
            this.Login.Text = "Логін";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBoxForLogin
            // 
            this.textBoxForLogin.Location = new System.Drawing.Point(49, 134);
            this.textBoxForLogin.Name = "textBoxForLogin";
            this.textBoxForLogin.Size = new System.Drawing.Size(267, 20);
            this.textBoxForLogin.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(124, 166);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(144, 42);
            this.Password.TabIndex = 3;
            this.Password.Text = "Пароль";
            // 
            // textBoxForPassword
            // 
            this.textBoxForPassword.Location = new System.Drawing.Point(49, 222);
            this.textBoxForPassword.Name = "textBoxForPassword";
            this.textBoxForPassword.Size = new System.Drawing.Size(266, 20);
            this.textBoxForPassword.TabIndex = 4;
            this.textBoxForPassword.TextChanged += new System.EventHandler(this.textBoxForPassword_TextChanged);
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.RosyBrown;
            this.Registration.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(91, 348);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(208, 33);
            this.Registration.TabIndex = 5;
            this.Registration.Text = "Зареєструватися";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(114, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Не вірний логін або пароль";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Registration);
            this.panel1.Controls.Add(this.textBoxForPassword);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.textBoxForLogin);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.LoginToProgram);
            this.panel1.Location = new System.Drawing.Point(473, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 440);
            this.panel1.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::CarLand.Properties.Resources.black_circle_close_button_png_5;
            this.Exit.Location = new System.Drawing.Point(1244, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 35);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 8;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LoginCarLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.Registration;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginCarLand";
            this.Text = "CarLand";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginToProgram;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox textBoxForLogin;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBoxForPassword;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Exit;
    }
}

