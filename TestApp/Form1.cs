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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Register_button.Enabled = false;

            passwordValidator_UserControl1.MIN_CHARACTERS = 8;
            passwordValidator_UserControl1.MIN_SPECIAL_CHARACTERS = 1;
            passwordValidator_UserControl1.MIN_CAPITTAL_LETTERS = 1;
            passwordValidator_UserControl1.MIN_DIGITS = 1;
            passwordValidator_UserControl1.NO_WHITESPACES = true;
            passwordValidator_UserControl1.SPECIAL_CHARACTERS_LIST = new List<char>() { '!', '@', '#',};
        }

        private void passwordValidator_UserControl1_StateToInValid(object sender, EventArgs e)
        {
            Register_button.Enabled = false;
        }

        private void passwordValidator_UserControl1_StateToValid(object sender, EventArgs e)
        {
            Register_button.Enabled = true;
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            // Register
            string username = UserName_textBox.Text;
            string password = passwordValidator_UserControl1.PASSWORD;
            if (!UserManagement.UserExist(username))
            {
                UserManagement.AddUser(username, password);
                MessageBox.Show("Registered successfully!");
                LoggedUser.UserName = username;
                this.FindForm().Hide();
                Form form2 = new Form2();
                form2.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("User with this name already exists");
                return;
            }
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form form0 = new Form0();
            form0.ShowDialog();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
