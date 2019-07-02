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
using System.IO;

namespace Classic_Cars
{
    public partial class CatalogScreen : Form
    {
        SqlConnection connection = new SqlConnection();

        List<int> listId = new List<int>();
        List<String> listMake = new List<String>();
        List<String> listModel = new List<String>();
        List<int> listYear = new List<int>();
        List<int> listMSRP = new List<int>();
        List<byte[]> listBytes = new List<byte[]>();

        public CatalogScreen()
        {
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aruns\\Downloads\\CarsDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection.Open();

            InitializeComponent();
            this.goToCartBTN.Visible = false;
            this.DoubleBuffered = true;

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
            String sqlQueryList = "SELECT * FROM CarsDB";
            SqlCommand commandList = new SqlCommand(sqlQueryList, connection);
            SqlDataReader reader = commandList.ExecuteReader();

            while (reader.Read())
            {
                listId.Add(int.Parse(reader[0].ToString()));
                listMake.Add(reader[1].ToString());
                listModel.Add(reader[2].ToString());
                listYear.Add(int.Parse(reader[3].ToString()));
                listMSRP.Add(int.Parse(reader[4].ToString()));
                listBytes.Add((byte[]) reader[5]);
            }
            reader.Close();

            String rowCountQuery = "SELECT COUNT(Id) FROM CarsDB";
            SqlCommand rowCountCmd = new SqlCommand(rowCountQuery, connection);
            int rowCount = ((int)rowCountCmd.ExecuteScalar());

            for (int i = 0; i < rowCount; i++)
            {
                Panel panel = new Panel();
                panel.Location = new System.Drawing.Point(12, ((240 * i) + 228));
                panel.Name = "panelCart" + i;
                panel.Size = new System.Drawing.Size(1000, 200);
                panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
                panel.TabIndex = 0;

                Button button = new Button();
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.Location = new System.Drawing.Point(854, 3);
                button.Name = i.ToString();
                button.Size = new System.Drawing.Size(143, 100);
                button.TabIndex = 3;
                button.Text = "Add to Cart";
                button.UseVisualStyleBackColor = true;

                RichTextBox richTextBox = new RichTextBox();
                richTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
                richTextBox.Location = new System.Drawing.Point(193, 3);
                richTextBox.Name = "richTextBoxCart" + i;
                richTextBox.Size = new System.Drawing.Size(655, 194);
                richTextBox.TabIndex = 2;
                richTextBox.Text = "";
                richTextBox.ReadOnly = true;

                richTextBox.Font = new Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                richTextBox.SelectionIndent = 20;
                richTextBox.AppendText(Environment.NewLine + "Make: " + listMake[i]);
                richTextBox.AppendText(Environment.NewLine + "Model: " + listModel[i]);
                richTextBox.AppendText(Environment.NewLine + "Year: " + listYear[i]);
                richTextBox.AppendText(Environment.NewLine + "Price: " + listMSRP[i]);

                PictureBox picture = new PictureBox();
                picture.Location = new System.Drawing.Point(3, 3);
                picture.Name = "pictureBoxCart" + i;
                picture.Size = new System.Drawing.Size(184, 194);
                picture.TabIndex = 0;
                picture.TabStop = false;
                picture.BackgroundImage = global::Classic_Cars.Properties.Resources.IMG_1;

                Image newImage = byteArrayToImage(listBytes[i]);
                picture.BackgroundImage = newImage;
                picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

                panel.Controls.Add(button);
                panel.Controls.Add(richTextBox);
                panel.Controls.Add(picture);

                this.Controls.Add(panel);
            }

        }

        private Image byteArrayToImage(byte[] v)
        {
            using (var ms = new MemoryStream(v))
            {
                return Image.FromStream(ms);
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
            String sqlQuery = null;
            if (loggedInInput.Text == "Admin")
            {
                sqlQuery = "SELECT * FROM CarsDB";
            } else
            {
                sqlQuery = "SELECT * FROM CarsDB WHERE Id=2";
            }
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@USERNAME", loggedInInput.Text);
        }

        private void CategorySelectBTN_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button = (Button)sender;
        }

        private void AddToCartBTN_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button = (Button) sender;
            int index = int.Parse(button.Text);

            String sqlQuery = "SELECT * FROM CarsDB where Id=@ID";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@ID", listId[index]);
            command.ExecuteNonQuery();

            String sqlQueryUpdateUsername = "";
            command = new SqlCommand(sqlQueryUpdateUsername, connection);
            command.Parameters.AddWithValue("@ID", listId[index]);
            command.Parameters.AddWithValue("@USERNAME", loggedInInput.Text);



            this.goToCartBTN.Visible = true;
            MessageBox.Show("Item added to cart");
        }
    }
}
