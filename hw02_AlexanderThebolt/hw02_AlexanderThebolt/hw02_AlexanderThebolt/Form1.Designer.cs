namespace hw02_AlexanderThebolt
{
    partial class Form1
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
            this.lb_users = new System.Windows.Forms.ListBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_fName = new System.Windows.Forms.Label();
            this.lbl_lName = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_fName = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_lName = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tb_passConf = new System.Windows.Forms.TextBox();
            this.lbl_passConf = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_users
            // 
            this.lb_users.BackColor = System.Drawing.Color.Black;
            this.lb_users.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_users.ForeColor = System.Drawing.Color.Lime;
            this.lb_users.FormattingEnabled = true;
            this.lb_users.ItemHeight = 39;
            this.lb_users.Location = new System.Drawing.Point(12, 12);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(776, 238);
            this.lb_users.TabIndex = 0;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.DimGray;
            this.btn_register.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_register.Location = new System.Drawing.Point(12, 256);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(776, 68);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Register A New User";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_fName
            // 
            this.lbl_fName.AutoSize = true;
            this.lbl_fName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fName.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fName.ForeColor = System.Drawing.Color.Lime;
            this.lbl_fName.Location = new System.Drawing.Point(3, 125);
            this.lbl_fName.Name = "lbl_fName";
            this.lbl_fName.Size = new System.Drawing.Size(168, 32);
            this.lbl_fName.TabIndex = 2;
            this.lbl_fName.Text = "First Name:";
            // 
            // lbl_lName
            // 
            this.lbl_lName.AutoSize = true;
            this.lbl_lName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lName.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lName.ForeColor = System.Drawing.Color.Lime;
            this.lbl_lName.Location = new System.Drawing.Point(395, 125);
            this.lbl_lName.Name = "lbl_lName";
            this.lbl_lName.Size = new System.Drawing.Size(154, 32);
            this.lbl_lName.TabIndex = 3;
            this.lbl_lName.Text = "Last Name:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Lime;
            this.lbl_password.Location = new System.Drawing.Point(3, 191);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(140, 32);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Lime;
            this.lbl_email.Location = new System.Drawing.Point(395, 63);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(98, 32);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Lime;
            this.lbl_username.Location = new System.Drawing.Point(3, 63);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(140, 32);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username:";
            // 
            // tb_fName
            // 
            this.tb_fName.BackColor = System.Drawing.Color.Black;
            this.tb_fName.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fName.ForeColor = System.Drawing.Color.Lime;
            this.tb_fName.Location = new System.Drawing.Point(172, 125);
            this.tb_fName.Name = "tb_fName";
            this.tb_fName.Size = new System.Drawing.Size(217, 35);
            this.tb_fName.TabIndex = 7;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Black;
            this.tb_email.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.Lime;
            this.tb_email.Location = new System.Drawing.Point(493, 60);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(295, 35);
            this.tb_email.TabIndex = 8;
            // 
            // tb_lName
            // 
            this.tb_lName.BackColor = System.Drawing.Color.Black;
            this.tb_lName.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lName.ForeColor = System.Drawing.Color.Lime;
            this.tb_lName.Location = new System.Drawing.Point(555, 125);
            this.tb_lName.Name = "tb_lName";
            this.tb_lName.Size = new System.Drawing.Size(233, 35);
            this.tb_lName.TabIndex = 9;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Black;
            this.tb_password.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.Lime;
            this.tb_password.Location = new System.Drawing.Point(149, 188);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(240, 35);
            this.tb_password.TabIndex = 10;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Black;
            this.tb_username.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.Lime;
            this.tb_username.Location = new System.Drawing.Point(149, 63);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(240, 35);
            this.tb_username.TabIndex = 11;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DimGray;
            this.btn_back.Font = new System.Drawing.Font("Cascadia Code", 27.25F);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(44, 256);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(213, 68);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.DimGray;
            this.btn_confirm.Font = new System.Drawing.Font("Cascadia Code", 27.25F);
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_confirm.Location = new System.Drawing.Point(511, 256);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(240, 68);
            this.btn_confirm.TabIndex = 13;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tb_passConf
            // 
            this.tb_passConf.BackColor = System.Drawing.Color.Black;
            this.tb_passConf.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passConf.ForeColor = System.Drawing.Color.Lime;
            this.tb_passConf.Location = new System.Drawing.Point(555, 188);
            this.tb_passConf.Name = "tb_passConf";
            this.tb_passConf.PasswordChar = '*';
            this.tb_passConf.Size = new System.Drawing.Size(233, 35);
            this.tb_passConf.TabIndex = 15;
            // 
            // lbl_passConf
            // 
            this.lbl_passConf.AutoSize = true;
            this.lbl_passConf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_passConf.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passConf.ForeColor = System.Drawing.Color.Lime;
            this.lbl_passConf.Location = new System.Drawing.Point(395, 191);
            this.lbl_passConf.Name = "lbl_passConf";
            this.lbl_passConf.Size = new System.Drawing.Size(154, 32);
            this.lbl_passConf.TabIndex = 14;
            this.lbl_passConf.Text = "Pass Conf:";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(5, 232);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(64, 21);
            this.lbl_error.TabIndex = 16;
            this.lbl_error.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.tb_passConf);
            this.Controls.Add(this.lbl_passConf);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_lName);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_fName);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_lName);
            this.Controls.Add(this.lbl_fName);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lb_users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_users;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_fName;
        private System.Windows.Forms.Label lbl_lName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_fName;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_lName;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox tb_passConf;
        private System.Windows.Forms.Label lbl_passConf;
        private System.Windows.Forms.Label lbl_error;
    }
}

