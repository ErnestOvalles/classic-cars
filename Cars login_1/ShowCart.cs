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
    public partial class ShowCart : Form
    {
        SqlConnection connection = new SqlConnection();
        
        public ShowCart()
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPurchasesBTN_Click(object sender, EventArgs e)
        {
            ShowPurchases showPurchases = new ShowPurchases();
            showPurchases.UsernameValue = loggedInInput.Text;
            showPurchases.Show();
        }

        private void CheckOutBTN_Click(object sender, EventArgs e)
        {
            String sqlQuery = "INSERT INTO Purchases(Make, Model, Year, MSRP, Username) SELECT Make, Model, Year, MSRP, Username FROM Cart WHERE USERNAME=@USERNAME";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@USERNAME", UsernameValue);
            command.ExecuteNonQuery();

            String sqlDeleteQuery = "DELETE FROM CART WHERE USERNAME=@USERNAME";
            SqlCommand commandDelete = new SqlCommand(sqlDeleteQuery, connection);
            commandDelete.Parameters.AddWithValue("@USERNAME", UsernameValue);
            commandDelete.ExecuteNonQuery();

            MessageBox.Show("Car(s) purchased! \n Click on \"View Purchases\" to view all purchases made");
        }

        private void ShowCart_Load(object sender, EventArgs e)
        {
            String sqlQuery = "SELECT Make, Model, Year, MSRP FROM Cart WHERE Username=@USERNAME";

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@USERNAME", UsernameValue);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            String rowCountQuery = "SELECT SUM(MSRP) FROM Cart WHERE Username=@USERNAME";
            SqlCommand rowCountCmd = new SqlCommand(rowCountQuery, connection);
            rowCountCmd.Parameters.AddWithValue("@USERNAME", UsernameValue);
            TotalLabelIn.Text = (rowCountCmd.ExecuteScalar().ToString());
        }

    }
}
