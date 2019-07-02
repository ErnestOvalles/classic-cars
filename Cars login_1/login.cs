using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classic_Cars
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(usernameTB.Text)) || (String.IsNullOrEmpty(passwordTB.Text))))
            {
                if (usernameTB.Text == passwordTB.Text)
                {
                    // Have to insert database connection for validation check
                    CatalogScreen catalogScreen = new CatalogScreen();
                    catalogScreen.Show();
                    catalogScreen.LoggedInValue = usernameTB.Text;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password is wrong, try again!");
                }
            } else
            {
                MessageBox.Show("Please enter a valid Username & Password");
            }
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        { 
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
