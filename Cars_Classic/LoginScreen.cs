using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_login_1
{
    public partial class Form1 : Form
    {
        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlConnection = new SqlConnection();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
                "C:\\Users\\Ernest O\\source\\repos\\Ernest157\\classic - cars\\Classic_Cars\\CarsDB.mdf;" +
                "Integrated Security=True;Connect Timeout=30";

            
        }
    }
}
