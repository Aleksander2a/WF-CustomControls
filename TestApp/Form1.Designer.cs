namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Register_button = new System.Windows.Forms.Button();
            this.passwordValidator_UserControl1 = new WindowsFormsControlLibrary1.PasswordValidator_UserControl();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Menu_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Register_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Register_button.Location = new System.Drawing.Point(261, 436);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(276, 61);
            this.Register_button.TabIndex = 1;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // passwordValidator_UserControl1
            // 
            this.passwordValidator_UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordValidator_UserControl1.Location = new System.Drawing.Point(261, 64);
            this.passwordValidator_UserControl1.MIN_CAPITTAL_LETTERS = 0;
            this.passwordValidator_UserControl1.MIN_CHARACTERS = 0;
            this.passwordValidator_UserControl1.MIN_DIGITS = 0;
            this.passwordValidator_UserControl1.MIN_SPECIAL_CHARACTERS = 0;
            this.passwordValidator_UserControl1.Name = "passwordValidator_UserControl1";
            this.passwordValidator_UserControl1.NO_WHITESPACES = false;
            this.passwordValidator_UserControl1.Size = new System.Drawing.Size(276, 366);
            this.passwordValidator_UserControl1.SPECIAL_CHARACTERS_LIST = null;
            this.passwordValidator_UserControl1.TabIndex = 2;
            this.passwordValidator_UserControl1.StateToValid += new System.EventHandler(this.passwordValidator_UserControl1_StateToValid);
            this.passwordValidator_UserControl1.StateToInValid += new System.EventHandler(this.passwordValidator_UserControl1_StateToInValid);
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Location = new System.Drawing.Point(278, 32);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(243, 26);
            this.UserName_textBox.TabIndex = 3;
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserName_label.Location = new System.Drawing.Point(321, -3);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(156, 32);
            this.UserName_label.TabIndex = 4;
            this.UserName_label.Text = "UserName";
            // 
            // Menu_button
            // 
            this.Menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Menu_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu_button.Location = new System.Drawing.Point(12, 436);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(135, 61);
            this.Menu_button.TabIndex = 5;
            this.Menu_button.Text = "Menu";
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_button.Location = new System.Drawing.Point(653, 436);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(135, 61);
            this.Login_button.TabIndex = 6;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(819, 509);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Menu_button);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.UserName_textBox);
            this.Controls.Add(this.passwordValidator_UserControl1);
            this.Controls.Add(this.Register_button);
            this.Name = "Form1";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Register_button;
        private WindowsFormsControlLibrary1.PasswordValidator_UserControl passwordValidator_UserControl1;
        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Button Menu_button;
        private System.Windows.Forms.Button Login_button;
    }
}

