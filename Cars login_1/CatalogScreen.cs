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
    public partial class CatalogScreen : Form
    {
        SqlConnection connection = new SqlConnection();
        public CatalogScreen()
        {
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aruns\\Downloads\\CarsDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection.Open();

            InitializeComponent();
            this.AutoScroll = true;
            this.ResizeRedraw = false;
            this.goToCartBTN.Visible = false;

        }

        public String LoggedInValue {
            get
            {
                return loggedInInput.Text;
            }
            set
            {
                loggedInInput.Text = value;
            }
        }


        private void CatalogScreen_Load(object sender, EventArgs e)
        {
            String rowCountQuery = "SELECT COUNT(Id) FROM CarsDB";

            SqlCommand rowCountCmd = new SqlCommand(rowCountQuery, connection);
            int rowCount = ((int) rowCountCmd.ExecuteScalar());

            //int rowCount = int.Parse(dataTable.Rows[0][0].ToString());
            for (int i = 0; i <= rowCount; i++)
            {
                String sqlQuery = "SELECT * FROM CarsDB WHERE Id=@ID";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ID", i);

                Panel panel = new Panel();
                panel.Location = new System.Drawing.Point(12, ((240 * i) + 128));
                panel.Name = "panel" + i;
                panel.Size = new System.Drawing.Size(1000, 200);
                panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
                panel.TabIndex = 0;

                Button button = new Button();
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.Location = new System.Drawing.Point(854, 3);
                button.Name = "button" + i;
                button.Size = new System.Drawing.Size(143, 100);
                button.TabIndex = 3;
                button.Text = "Add to Cart";
                button.UseVisualStyleBackColor = true;

                RichTextBox richTextBox = new RichTextBox();
                richTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
                richTextBox.Location = new System.Drawing.Point(193, 3);
                richTextBox.Name = "richTextBox" + i;
                richTextBox.Size = new System.Drawing.Size(655, 194);
                richTextBox.TabIndex = 2;
                richTextBox.Text = "";

                PictureBox picture = new PictureBox();
                picture.Location = new System.Drawing.Point(3, 3);
                picture.Name = "pictureBox" + i;
                picture.Size = new System.Drawing.Size(184, 194);
                picture.TabIndex = 0;
                picture.TabStop = false;

                panel.Controls.Add(button);
                panel.Controls.Add(richTextBox);
                panel.Controls.Add(picture);

                this.Controls.Add(panel);
            }

        }

        private void SignOutBTN_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void ViewPurchasesBTN_Click(object sender, EventArgs e)
        {
            if (loggedInInput.Text == "Admin")
            {

            } else
            {

            }
        }

        private void AddToCartBTN_Click(object sender, EventArgs e)
        {
            this.goToCartBTN.Visible = true;
            MessageBox.Show("Item added to cart");
        }
    }
}
