using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            var username = txt_username.Text;
            string password = txt_password.Text;
            WelcomeForm wf = new WelcomeForm(username, password);

            if(username=="kgotlelelo"& password=="20222"&humanCheckBox.Checked)
            {
                wf.Show();
            }else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
