﻿namespace TestApp
{
    partial class Form3
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
            this.UserName_label = new System.Windows.Forms.Label();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Register_button = new System.Windows.Forms.Button();
            this.Menu_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserName_label.Location = new System.Drawing.Point(335, 127);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(156, 32);
            this.UserName_label.TabIndex = 6;
            this.UserName_label.Text = "UserName";
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Location = new System.Drawing.Point(287, 162);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(243, 26);
            this.UserName_textBox.TabIndex = 5;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password_label.Location = new System.Drawing.Point(335, 203);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(146, 32);
            this.Password_label.TabIndex = 8;
            this.Password_label.Text = "Password";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(287, 238);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(243, 26);
            this.Password_textBox.TabIndex = 7;
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Register_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Register_button.Location = new System.Drawing.Point(662, 377);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(135, 61);
            this.Register_button.TabIndex = 11;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Menu_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu_button.Location = new System.Drawing.Point(21, 377);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(135, 61);
            this.Menu_button.TabIndex = 10;
            this.Menu_button.Text = "Menu";
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_button.Location = new System.Drawing.Point(270, 377);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(276, 61);
            this.Login_button.TabIndex = 9;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Menu_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.UserName_textBox);
            this.Name = "Form3";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Menu_button;
        private System.Windows.Forms.Button Login_button;
    }
}