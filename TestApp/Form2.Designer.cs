namespace TestApp
{
    partial class Form2
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
            this.userControl11 = new WindowsFormsControlLibrary2.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.DATE = null;
            this.userControl11.DESCRIPTION = null;
            this.userControl11.EVENT_NAME = null;
            this.userControl11.Location = new System.Drawing.Point(1, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.PRIORITY = null;
            this.userControl11.Size = new System.Drawing.Size(787, 444);
            this.userControl11.TabIndex = 0;
            this.userControl11.TIME = null;
            this.userControl11.UserName = null;
            this.userControl11.TriedAddInvalid += new System.EventHandler(this.userControl11_TriedAddInvalid);
            this.userControl11.TriedAddValid += new System.EventHandler(this.userControl11_TriedAddValid);
            this.userControl11.DeleteEvent += new System.EventHandler(this.userControl11_DeleteEvent);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Name = "Form2";
            this.Text = "Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary2.UserControl1 userControl11;
    }
}