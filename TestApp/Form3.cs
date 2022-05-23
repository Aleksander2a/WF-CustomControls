using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestApp.BusinessLogic;

namespace TestApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form form0 = new Form0();
            form0.ShowDialog();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form form1 = new Form1();
            form1.ShowDialog();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            // Login...
            string username = UserName_textBox.Text;
            string password = Password_textBox.Text;
            if (UserManagement.UserExist(username))
            {
                if(UserManagement.IsUserPasswordCorrect(username, password))
                {
                    MessageBox.Show("Logged in successfully!");
                    LoggedUser.UserName = username;
                    this.FindForm().Hide();
                    Form form2 = new Form2();
                    form2.ShowDialog();
                    return;
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                    return;
                }
            }
            else
            {
                MessageBox.Show("This user does not exist");
                return;
            }
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
