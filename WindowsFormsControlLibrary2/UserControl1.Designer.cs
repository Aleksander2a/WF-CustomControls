namespace WindowsFormsControlLibrary2
{
    partial class UserControl1
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
            this.Week_dataGridView = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.EventName_textBox = new System.Windows.Forms.TextBox();
            this.EventName_label = new System.Windows.Forms.Label();
            this.Priority_label = new System.Windows.Forms.Label();
            this.Priority_comboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Description_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.Time_label = new System.Windows.Forms.Label();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.Previous_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Week_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Week_dataGridView
            // 
            this.Week_dataGridView.AllowUserToAddRows = false;
            this.Week_dataGridView.AllowUserToDeleteRows = false;
            this.Week_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Week_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.Week_dataGridView.Name = "Week_dataGridView";
            this.Week_dataGridView.ReadOnly = true;
            this.Week_dataGridView.RowHeadersWidth = 62;
            this.Week_dataGridView.RowTemplate.Height = 28;
            this.Week_dataGridView.Size = new System.Drawing.Size(781, 287);
            this.Week_dataGridView.TabIndex = 0;
            this.Week_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Week_dataGridView_CellClick);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Add_button.Location = new System.Drawing.Point(3, 332);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(107, 51);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Save";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // EventName_textBox
            // 
            this.EventName_textBox.Location = new System.Drawing.Point(116, 357);
            this.EventName_textBox.Name = "EventName_textBox";
            this.EventName_textBox.Size = new System.Drawing.Size(161, 26);
            this.EventName_textBox.TabIndex = 2;
            // 
            // EventName_label
            // 
            this.EventName_label.AutoSize = true;
            this.EventName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EventName_label.Location = new System.Drawing.Point(138, 332);
            this.EventName_label.Name = "EventName_label";
            this.EventName_label.Size = new System.Drawing.Size(129, 25);
            this.EventName_label.TabIndex = 3;
            this.EventName_label.Text = "Event Name";
            // 
            // Priority_label
            // 
            this.Priority_label.AutoSize = true;
            this.Priority_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Priority_label.Location = new System.Drawing.Point(322, 329);
            this.Priority_label.Name = "Priority_label";
            this.Priority_label.Size = new System.Drawing.Size(79, 25);
            this.Priority_label.TabIndex = 5;
            this.Priority_label.Text = "Priority";
            // 
            // Priority_comboBox
            // 
            this.Priority_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Priority_comboBox.FormattingEnabled = true;
            this.Priority_comboBox.Location = new System.Drawing.Point(283, 355);
            this.Priority_comboBox.Name = "Priority_comboBox";
            this.Priority_comboBox.Size = new System.Drawing.Size(155, 28);
            this.Priority_comboBox.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(444, 357);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(340, 84);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Description_label.Location = new System.Drawing.Point(543, 329);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(120, 25);
            this.Description_label.TabIndex = 8;
            this.Description_label.Text = "Description";
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Date_label.Location = new System.Drawing.Point(169, 390);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(57, 25);
            this.Date_label.TabIndex = 10;
            this.Date_label.Text = "Date";
            // 
            // Date_textBox
            // 
            this.Date_textBox.Location = new System.Drawing.Point(116, 415);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.ReadOnly = true;
            this.Date_textBox.Size = new System.Drawing.Size(161, 26);
            this.Date_textBox.TabIndex = 9;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Time_label.Location = new System.Drawing.Point(332, 390);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(60, 25);
            this.Time_label.TabIndex = 12;
            this.Time_label.Text = "Time";
            // 
            // Time_textBox
            // 
            this.Time_textBox.Location = new System.Drawing.Point(283, 415);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.ReadOnly = true;
            this.Time_textBox.Size = new System.Drawing.Size(155, 26);
            this.Time_textBox.TabIndex = 11;
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(709, 296);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 31);
            this.Next_button.TabIndex = 13;
            this.Next_button.Text = ">>";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Previous_button
            // 
            this.Previous_button.Location = new System.Drawing.Point(3, 296);
            this.Previous_button.Name = "Previous_button";
            this.Previous_button.Size = new System.Drawing.Size(75, 31);
            this.Previous_button.TabIndex = 14;
            this.Previous_button.Text = "<<";
            this.Previous_button.UseVisualStyleBackColor = true;
            this.Previous_button.Click += new System.EventHandler(this.Previous_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.Red;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Delete_button.Location = new System.Drawing.Point(3, 389);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(107, 51);
            this.Delete_button.TabIndex = 15;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Previous_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Time_textBox);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Date_textBox);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Priority_comboBox);
            this.Controls.Add(this.Priority_label);
            this.Controls.Add(this.EventName_label);
            this.Controls.Add(this.EventName_textBox);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Week_dataGridView);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(787, 444);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Week_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Week_dataGridView;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox EventName_textBox;
        private System.Windows.Forms.Label EventName_label;
        private System.Windows.Forms.Label Priority_label;
        private System.Windows.Forms.ComboBox Priority_comboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.TextBox Time_textBox;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Previous_button;
        private System.Windows.Forms.Button Delete_button;
    }
}
