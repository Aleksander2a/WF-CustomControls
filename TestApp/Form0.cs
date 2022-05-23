using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form form3 = new Form3();
            form3.ShowDialog();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
