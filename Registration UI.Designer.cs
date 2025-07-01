namespace A8__Registration_UI
{
    partial class Registration_UI
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
            this.UN_Label = new System.Windows.Forms.Label();
            this.Pass_Label = new System.Windows.Forms.Label();
            this.UN_TextBox = new System.Windows.Forms.TextBox();
            this.Show_Pass_CheckBox = new System.Windows.Forms.CheckBox();
            this.Reg_User_Label = new System.Windows.Forms.Label();
            this.Reg_Users_ListBox = new System.Windows.Forms.ListBox();
            this.Reg_Button = new System.Windows.Forms.Button();
            this.Delete_User = new System.Windows.Forms.Button();
            this.Pass_TextBox = new System.Windows.Forms.TextBox();
            this.UserNamrd_Errors_Label = new System.Windows.Forms.Label();
            this.Pass_Errors_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UN_Label
            // 
            this.UN_Label.AutoSize = true;
            this.UN_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UN_Label.Location = new System.Drawing.Point(26, 78);
            this.UN_Label.Name = "UN_Label";
            this.UN_Label.Size = new System.Drawing.Size(78, 16);
            this.UN_Label.TabIndex = 1;
            this.UN_Label.Text = "Username";
            // 
            // Pass_Label
            // 
            this.Pass_Label.AutoSize = true;
            this.Pass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Label.Location = new System.Drawing.Point(26, 118);
            this.Pass_Label.Name = "Pass_Label";
            this.Pass_Label.Size = new System.Drawing.Size(75, 16);
            this.Pass_Label.TabIndex = 2;
            this.Pass_Label.Text = "Password";
            // 
            // UN_TextBox
            // 
            this.UN_TextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Users;"});
            this.UN_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.UN_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UN_TextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UN_TextBox.Location = new System.Drawing.Point(123, 78);
            this.UN_TextBox.Name = "UN_TextBox";
            this.UN_TextBox.Size = new System.Drawing.Size(182, 22);
            this.UN_TextBox.TabIndex = 2;
            this.UN_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UN_TextBox.TextChanged += new System.EventHandler(this.UN_TextBox_TextChanged);
            // 
            // Show_Pass_CheckBox
            // 
            this.Show_Pass_CheckBox.AutoSize = true;
            this.Show_Pass_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Pass_CheckBox.Location = new System.Drawing.Point(123, 155);
            this.Show_Pass_CheckBox.Name = "Show_Pass_CheckBox";
            this.Show_Pass_CheckBox.Size = new System.Drawing.Size(125, 20);
            this.Show_Pass_CheckBox.TabIndex = 4;
            this.Show_Pass_CheckBox.Text = "Show Password";
            this.Show_Pass_CheckBox.UseVisualStyleBackColor = true;
            this.Show_Pass_CheckBox.CheckedChanged += new System.EventHandler(this.Show_Pass_CheckBox_CheckedChanged);
            // 
            // Reg_User_Label
            // 
            this.Reg_User_Label.AutoSize = true;
            this.Reg_User_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_User_Label.Location = new System.Drawing.Point(441, 38);
            this.Reg_User_Label.Name = "Reg_User_Label";
            this.Reg_User_Label.Size = new System.Drawing.Size(133, 16);
            this.Reg_User_Label.TabIndex = 5;
            this.Reg_User_Label.Text = "Registered Users:";
            // 
            // Reg_Users_ListBox
            // 
            this.Reg_Users_ListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Reg_Users_ListBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Reg_Users_ListBox.FormattingEnabled = true;
            this.Reg_Users_ListBox.ItemHeight = 16;
            this.Reg_Users_ListBox.Location = new System.Drawing.Point(444, 78);
            this.Reg_Users_ListBox.Name = "Reg_Users_ListBox";
            this.Reg_Users_ListBox.Size = new System.Drawing.Size(263, 420);
            this.Reg_Users_ListBox.TabIndex = 6;
            // 
            // Reg_Button
            // 
            this.Reg_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Reg_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reg_Button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Reg_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_Button.Location = new System.Drawing.Point(29, 466);
            this.Reg_Button.Name = "Reg_Button";
            this.Reg_Button.Size = new System.Drawing.Size(126, 32);
            this.Reg_Button.TabIndex = 3;
            this.Reg_Button.Text = "Register";
            this.Reg_Button.UseVisualStyleBackColor = false;
            this.Reg_Button.Click += new System.EventHandler(this.Reg_Button_Click);
            // 
            // Delete_User
            // 
            this.Delete_User.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Delete_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete_User.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_User.Location = new System.Drawing.Point(216, 466);
            this.Delete_User.Name = "Delete_User";
            this.Delete_User.Size = new System.Drawing.Size(126, 32);
            this.Delete_User.TabIndex = 4;
            this.Delete_User.Text = "Delete User";
            this.Delete_User.UseVisualStyleBackColor = false;
            this.Delete_User.Click += new System.EventHandler(this.Delete_User_Click);
            // 
            // Pass_TextBox
            // 
            this.Pass_TextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Pass_TextBox.Location = new System.Drawing.Point(123, 115);
            this.Pass_TextBox.Name = "Pass_TextBox";
            this.Pass_TextBox.Size = new System.Drawing.Size(182, 22);
            this.Pass_TextBox.TabIndex = 3;
            this.Pass_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass_TextBox.Click += new System.EventHandler(this.Pass_TextBox_Click);
            this.Pass_TextBox.TextChanged += new System.EventHandler(this.Pass_TextBox_TextChanged);
            // 
            // UserNamrd_Errors_Label
            // 
            this.UserNamrd_Errors_Label.AutoSize = true;
            this.UserNamrd_Errors_Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserNamrd_Errors_Label.ForeColor = System.Drawing.Color.Red;
            this.UserNamrd_Errors_Label.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.UserNamrd_Errors_Label.Location = new System.Drawing.Point(26, 194);
            this.UserNamrd_Errors_Label.Name = "UserNamrd_Errors_Label";
            this.UserNamrd_Errors_Label.Size = new System.Drawing.Size(112, 48);
            this.UserNamrd_Errors_Label.TabIndex = 7;
            this.UserNamrd_Errors_Label.Text = "UserName Errors\r\n\r\n\r\n";
            this.UserNamrd_Errors_Label.Visible = false;
            // 
            // Pass_Errors_Label
            // 
            this.Pass_Errors_Label.AutoSize = true;
            this.Pass_Errors_Label.ForeColor = System.Drawing.Color.Red;
            this.Pass_Errors_Label.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.Pass_Errors_Label.Location = new System.Drawing.Point(26, 226);
            this.Pass_Errors_Label.Name = "Pass_Errors_Label";
            this.Pass_Errors_Label.Size = new System.Drawing.Size(106, 16);
            this.Pass_Errors_Label.TabIndex = 8;
            this.Pass_Errors_Label.Text = "Password Errors";
            this.Pass_Errors_Label.Visible = false;
            // 
            // Registration_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 524);
            this.Controls.Add(this.Pass_Errors_Label);
            this.Controls.Add(this.UserNamrd_Errors_Label);
            this.Controls.Add(this.Pass_TextBox);
            this.Controls.Add(this.Delete_User);
            this.Controls.Add(this.Reg_Button);
            this.Controls.Add(this.Reg_Users_ListBox);
            this.Controls.Add(this.Reg_User_Label);
            this.Controls.Add(this.Show_Pass_CheckBox);
            this.Controls.Add(this.UN_TextBox);
            this.Controls.Add(this.Pass_Label);
            this.Controls.Add(this.UN_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration_UI";
            this.Text = "Registration UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UN_Label;
        private System.Windows.Forms.Label Pass_Label;
        private System.Windows.Forms.TextBox UN_TextBox;
        private System.Windows.Forms.CheckBox Show_Pass_CheckBox;
        private System.Windows.Forms.Label Reg_User_Label;
        private System.Windows.Forms.ListBox Reg_Users_ListBox;
        private System.Windows.Forms.Button Reg_Button;
        private System.Windows.Forms.Button Delete_User;
        private System.Windows.Forms.TextBox Pass_TextBox;
        private System.Windows.Forms.Label UserNamrd_Errors_Label;
        private System.Windows.Forms.Label Pass_Errors_Label;
    }
}

