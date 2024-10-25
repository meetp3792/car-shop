
using System;

namespace login
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.Label();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_login = new Guna.UI2.WinForms.Guna2Button();
            this.button_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(47, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "CAR ZONE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txt_login);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Location = new System.Drawing.Point(279, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 453);
            this.panel1.TabIndex = 9;
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(94, 191);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(83, 20);
            this.txt_password.TabIndex = 12;
            this.txt_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.AutoSize = true;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(94, 126);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(86, 20);
            this.txt_username.TabIndex = 15;
            this.txt_username.Text = "Username";
            // 
            // txt_login
            // 
            this.txt_login.AutoSize = true;
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(226, 43);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(86, 32);
            this.txt_login.TabIndex = 10;
            this.txt_login.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.BorderRadius = 15;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(209, 126);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PlaceholderText = "";
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(229, 34);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BorderRadius = 15;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.DefaultText = "";
            this.textBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(209, 191);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.PlaceholderText = "";
            this.textBox2.SelectedText = "";
            this.textBox2.Size = new System.Drawing.Size(229, 34);
            this.textBox2.TabIndex = 17;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_login.BorderRadius = 15;
            this.button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_login.FillColor = System.Drawing.Color.White;
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_login.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_login.Location = new System.Drawing.Point(347, 266);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(91, 35);
            this.button_login.TabIndex = 10;
            this.button_login.Text = "Login";
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Exit.BorderRadius = 15;
            this.button_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Exit.FillColor = System.Drawing.Color.White;
            this.button_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Exit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_Exit.Location = new System.Drawing.Point(209, 266);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(91, 35);
            this.button_Exit.TabIndex = 18;
            this.button_Exit.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "clear";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_login;
        private System.Windows.Forms.Label txt_username;
        private System.Windows.Forms.Label txt_password;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBox2;
        private Guna.UI2.WinForms.Guna2Button button_login;
        private Guna.UI2.WinForms.Guna2Button button_Exit;
    }
}

