namespace CMPT291_Group3_Project
{
    partial class Registration_Screen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login_redirect_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.password_box_confirm = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.confirm_password_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Login_redirect_button);
            this.panel1.Controls.Add(this.Register_button);
            this.panel1.Controls.Add(this.password_box_confirm);
            this.panel1.Controls.Add(this.password_box);
            this.panel1.Controls.Add(this.username_box);
            this.panel1.Controls.Add(this.confirm_password_label);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.Controls.Add(this.username_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(407, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 409);
            this.panel1.TabIndex = 0;
            // 
            // Login_redirect_button
            // 
            this.Login_redirect_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_redirect_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_redirect_button.Location = new System.Drawing.Point(83, 275);
            this.Login_redirect_button.Name = "Login_redirect_button";
            this.Login_redirect_button.Size = new System.Drawing.Size(293, 39);
            this.Login_redirect_button.TabIndex = 8;
            this.Login_redirect_button.Text = "Already have an account? Login";
            this.Login_redirect_button.UseVisualStyleBackColor = false;
            this.Login_redirect_button.Click += new System.EventHandler(this.Login_redirect_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Register_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Register_button.Location = new System.Drawing.Point(83, 230);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(293, 39);
            this.Register_button.TabIndex = 7;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // password_box_confirm
            // 
            this.password_box_confirm.Location = new System.Drawing.Point(157, 167);
            this.password_box_confirm.Name = "password_box_confirm";
            this.password_box_confirm.Size = new System.Drawing.Size(209, 23);
            this.password_box_confirm.TabIndex = 6;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(157, 127);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(208, 23);
            this.password_box.TabIndex = 5;
            // 
            // username_box
            // 
            this.username_box.AccessibleName = "usernamebox";
            this.username_box.Location = new System.Drawing.Point(157, 79);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(205, 23);
            this.username_box.TabIndex = 4;
            this.username_box.TextChanged += new System.EventHandler(this.username_box_TextChanged);
            // 
            // confirm_password_label
            // 
            this.confirm_password_label.AutoSize = true;
            this.confirm_password_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_password_label.Location = new System.Drawing.Point(14, 165);
            this.confirm_password_label.Name = "confirm_password_label";
            this.confirm_password_label.Size = new System.Drawing.Size(140, 21);
            this.confirm_password_label.TabIndex = 3;
            this.confirm_password_label.Text = "Confirm Password:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(32, 125);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(119, 21);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Enter Password:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_label.Location = new System.Drawing.Point(30, 77);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(124, 21);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Enter Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Registration_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPT291_Group3_Project.Properties.Resources.stranger_things_wallpaper_project;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.panel1);
            this.Name = "Registration_Screen";
            this.Text = "Account Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button Login_redirect_button;
        private Button Register_button;
        private TextBox password_box_confirm;
        private TextBox password_box;
        private TextBox username_box;
        private Label confirm_password_label;
        private Label password_label;
        private Label username_label;
    }
}