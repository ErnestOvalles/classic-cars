using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Classic_Cars
{
    public partial class SignUp : Form
    {
        SqlConnection connection = new SqlConnection();

        public SignUp()
        {
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aruns\\Downloads\\CarsDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection.Open();

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

                String sqlQuerry = "INSERT INTO UserDB(UserName, Password, EmailAddress) VALUES(@USERNAME, @PASSWORD, @EMAIL)";

                SqlCommand command = new SqlCommand(sqlQuerry, connection);
                command.Parameters.AddWithValue("@USERNAME", usernameTB.Text);
                command.Parameters.AddWithValue("@PASSWORD", passwordTB.Text);
                command.Parameters.AddWithValue("@EMAIL", emailTB.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Account Created! Please login");
                Login login = new Login();
                login.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Please make sure you enter a valid Username, Password and Email");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
