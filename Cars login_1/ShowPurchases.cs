using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Classic_Cars
{
    public partial class ShowPurchases : Form
    {
        SqlConnection connection = new SqlConnection();

        public ShowPurchases()
        {
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aruns\\Downloads\\CarsDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection.Open();

            InitializeComponent();
        }
        public String UsernameValue
        {
            set
            {
                loggedInInput.Text = value;
            }
            get
            {
                return loggedInInput.Text;
            }
        }

        private void ShowPurchases_Load(object sender, EventArgs e)
        {
            
            Console.WriteLine("ShowPurchases: Username is " + UsernameValue);

            String sqlQuery = "SELECT * FROM Purchases WHERE Username=@USERNAME";
            if (UsernameValue == "admin")
            {
                sqlQuery = "SELECT * FROM Purchases";
            }
            else
            {
                sqlQuery = "SELECT * FROM Purchases WHERE Username=@USERNAME";
            }

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@USERNAME", UsernameValue);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
