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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrEmpty(usernameTB.Text)) || (String.IsNullOrEmpty(passwordTB.Text)) || (String.IsNullOrEmpty(emailTB.Text))))
            {
                // Have to insert database connection for adding accounts to DB
                MessageBox.Show("Account Created! Please login");
                Login login = new Login();
                login.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Please make sure you enter a valid Username, Password and Email");
            }
        }
    }
}
