namespace WindowsFormsControlLibrary1
{
    partial class PasswordValidator_UserControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Password_label = new System.Windows.Forms.Label();
            this.ConfirmPassword_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassword_textBox = new System.Windows.Forms.TextBox();
            this.Requirements_label = new System.Windows.Forms.Label();
            this.Digits_label = new System.Windows.Forms.Label();
            this.CapitalLetters_label = new System.Windows.Forms.Label();
            this.SpecialChars_label = new System.Windows.Forms.Label();
            this.Length_label = new System.Windows.Forms.Label();
            this.CharsCount_label = new System.Windows.Forms.Label();
            this.SpecialCharsCount_label = new System.Windows.Forms.Label();
            this.CapitalLettersCount_label = new System.Windows.Forms.Label();
            this.DigitsCount_label = new System.Windows.Forms.Label();
            this.PassConfPasslabel = new System.Windows.Forms.Label();
            this.NoWhiteSpaces_label = new System.Windows.Forms.Label();
            this.NoWsValue_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password_label.Location = new System.Drawing.Point(14, 13);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(106, 25);
            this.Password_label.TabIndex = 0;
            this.Password_label.Text = "Password";
            // 
            // ConfirmPassword_label
            // 
            this.ConfirmPassword_label.AutoSize = true;
            this.ConfirmPassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPassword_label.Location = new System.Drawing.Point(14, 88);
            this.ConfirmPassword_label.Name = "ConfirmPassword_label";
            this.ConfirmPassword_label.Size = new System.Drawing.Size(187, 25);
            this.ConfirmPassword_label.TabIndex = 1;
            this.ConfirmPassword_label.Text = "Confirm Password";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(19, 41);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(236, 26);
            this.Password_textBox.TabIndex = 2;
            this.Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // ConfirmPassword_textBox
            // 
            this.ConfirmPassword_textBox.Location = new System.Drawing.Point(19, 116);
            this.ConfirmPassword_textBox.Name = "ConfirmPassword_textBox";
            this.ConfirmPassword_textBox.Size = new System.Drawing.Size(236, 26);
            this.ConfirmPassword_textBox.TabIndex = 3;
            this.ConfirmPassword_textBox.TextChanged += new System.EventHandler(this.ConfirmPassword_textBox_TextChanged);
            // 
            // Requirements_label
            // 
            this.Requirements_label.AutoSize = true;
            this.Requirements_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Requirements_label.Location = new System.Drawing.Point(15, 157);
            this.Requirements_label.Name = "Requirements_label";
            this.Requirements_label.Size = new System.Drawing.Size(179, 20);
            this.Requirements_label.TabIndex = 4;
            this.Requirements_label.Text = "Password requirements:";
            // 
            // Digits_label
            // 
            this.Digits_label.AutoSize = true;
            this.Digits_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Digits_label.Location = new System.Drawing.Point(15, 283);
            this.Digits_label.Name = "Digits_label";
            this.Digits_label.Size = new System.Drawing.Size(79, 20);
            this.Digits_label.TabIndex = 8;
            this.Digits_label.Text = "Min digits:";
            // 
            // CapitalLetters_label
            // 
            this.CapitalLetters_label.AutoSize = true;
            this.CapitalLetters_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CapitalLetters_label.Location = new System.Drawing.Point(15, 253);
            this.CapitalLetters_label.Name = "CapitalLetters_label";
            this.CapitalLetters_label.Size = new System.Drawing.Size(136, 20);
            this.CapitalLetters_label.TabIndex = 7;
            this.CapitalLetters_label.Text = "Min capital letters:";
            // 
            // SpecialChars_label
            // 
            this.SpecialChars_label.AutoSize = true;
            this.SpecialChars_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpecialChars_label.Location = new System.Drawing.Point(15, 222);
            this.SpecialChars_label.Name = "SpecialChars_label";
            this.SpecialChars_label.Size = new System.Drawing.Size(170, 20);
            this.SpecialChars_label.TabIndex = 6;
            this.SpecialChars_label.Text = "Min special characters:";
            // 
            // Length_label
            // 
            this.Length_label.AutoSize = true;
            this.Length_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Length_label.Location = new System.Drawing.Point(15, 190);
            this.Length_label.Name = "Length_label";
            this.Length_label.Size = new System.Drawing.Size(117, 20);
            this.Length_label.TabIndex = 5;
            this.Length_label.Text = "Min characters:";
            // 
            // CharsCount_label
            // 
            this.CharsCount_label.AutoSize = true;
            this.CharsCount_label.Location = new System.Drawing.Point(139, 189);
            this.CharsCount_label.Name = "CharsCount_label";
            this.CharsCount_label.Size = new System.Drawing.Size(0, 20);
            this.CharsCount_label.TabIndex = 9;
            // 
            // SpecialCharsCount_label
            // 
            this.SpecialCharsCount_label.AutoSize = true;
            this.SpecialCharsCount_label.Location = new System.Drawing.Point(191, 222);
            this.SpecialCharsCount_label.Name = "SpecialCharsCount_label";
            this.SpecialCharsCount_label.Size = new System.Drawing.Size(0, 20);
            this.SpecialCharsCount_label.TabIndex = 10;
            // 
            // CapitalLettersCount_label
            // 
            this.CapitalLettersCount_label.AutoSize = true;
            this.CapitalLettersCount_label.Location = new System.Drawing.Point(157, 253);
            this.CapitalLettersCount_label.Name = "CapitalLettersCount_label";
            this.CapitalLettersCount_label.Size = new System.Drawing.Size(0, 20);
            this.CapitalLettersCount_label.TabIndex = 11;
            // 
            // DigitsCount_label
            // 
            this.DigitsCount_label.AutoSize = true;
            this.DigitsCount_label.Location = new System.Drawing.Point(94, 283);
            this.DigitsCount_label.Name = "DigitsCount_label";
            this.DigitsCount_label.Size = new System.Drawing.Size(0, 20);
            this.DigitsCount_label.TabIndex = 12;
            // 
            // PassConfPasslabel
            // 
            this.PassConfPasslabel.AutoSize = true;
            this.PassConfPasslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PassConfPasslabel.Location = new System.Drawing.Point(15, 312);
            this.PassConfPasslabel.Name = "PassConfPasslabel";
            this.PassConfPasslabel.Size = new System.Drawing.Size(237, 20);
            this.PassConfPasslabel.TabIndex = 13;
            this.PassConfPasslabel.Text = "Password matches Confirmation";
            // 
            // NoWhiteSpaces_label
            // 
            this.NoWhiteSpaces_label.AutoSize = true;
            this.NoWhiteSpaces_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoWhiteSpaces_label.Location = new System.Drawing.Point(15, 341);
            this.NoWhiteSpaces_label.Name = "NoWhiteSpaces_label";
            this.NoWhiteSpaces_label.Size = new System.Drawing.Size(121, 20);
            this.NoWhiteSpaces_label.TabIndex = 14;
            this.NoWhiteSpaces_label.Text = "No whitespaces";
            // 
            // NoWsValue_label
            // 
            this.NoWsValue_label.AutoSize = true;
            this.NoWsValue_label.Location = new System.Drawing.Point(142, 341);
            this.NoWsValue_label.Name = "NoWsValue_label";
            this.NoWsValue_label.Size = new System.Drawing.Size(0, 20);
            this.NoWsValue_label.TabIndex = 15;
            // 
            // PasswordValidator_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NoWsValue_label);
            this.Controls.Add(this.NoWhiteSpaces_label);
            this.Controls.Add(this.PassConfPasslabel);
            this.Controls.Add(this.DigitsCount_label);
            this.Controls.Add(this.CapitalLettersCount_label);
            this.Controls.Add(this.SpecialCharsCount_label);
            this.Controls.Add(this.CharsCount_label);
            this.Controls.Add(this.Digits_label);
            this.Controls.Add(this.CapitalLetters_label);
            this.Controls.Add(this.SpecialChars_label);
            this.Controls.Add(this.Length_label);
            this.Controls.Add(this.Requirements_label);
            this.Controls.Add(this.ConfirmPassword_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.ConfirmPassword_label);
            this.Controls.Add(this.Password_label);
            this.Name = "PasswordValidator_UserControl";
            this.Size = new System.Drawing.Size(276, 368);
            this.Load += new System.EventHandler(this.PasswordValidator_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label ConfirmPassword_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox ConfirmPassword_textBox;
        private System.Windows.Forms.Label Requirements_label;
        private System.Windows.Forms.Label Digits_label;
        private System.Windows.Forms.Label CapitalLetters_label;
        private System.Windows.Forms.Label SpecialChars_label;
        private System.Windows.Forms.Label Length_label;
        private System.Windows.Forms.Label CharsCount_label;
        private System.Windows.Forms.Label SpecialCharsCount_label;
        private System.Windows.Forms.Label CapitalLettersCount_label;
        private System.Windows.Forms.Label DigitsCount_label;
        private System.Windows.Forms.Label PassConfPasslabel;
        private System.Windows.Forms.Label NoWhiteSpaces_label;
        private System.Windows.Forms.Label NoWsValue_label;
    }
}
