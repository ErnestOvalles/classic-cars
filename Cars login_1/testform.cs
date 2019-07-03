using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Classic_Cars
{
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aruns\\Downloads\\CarsDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection.Open();

            Image img = Image.FromFile(@"C:\Users\aruns\Source\Repos\Ernest157\classic-cars\Cars login_1\Resources\CarIMGs\SEDAN_2.jpg"); ;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.ToArray();

            String sqlQuery = "UPDATE CarsDB SET Image=@IMAGE WHERE Id=@ID";

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@ID", 18);
            command.Parameters.AddWithValue("@IMAGE", bytes);
            command.ExecuteNonQuery();


        }
    }
}
