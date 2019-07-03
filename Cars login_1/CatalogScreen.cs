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

        public CatalogScreen()
        {
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aruns\\Downloads\\CarsDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection.Open();

            InitializeComponent();
            this.DoubleBuffered = true;

        }

        public String LoggedInValue {
            set
            {
                loggedInInput.Text = value;
            }
            get
            {
                return loggedInInput.Text;
            }
        }


        private void CatalogScreen_Load(object sender, EventArgs e)
        {
        }

        private void SignOutBTN_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void ViewPurchasesBTN_Click(object sender, EventArgs e)
        {
            ShowPurchases showPurchases = new ShowPurchases();
            showPurchases.UsernameValue = loggedInInput.Text;
            showPurchases.Show();
        }
  
        private void CategorySelectBTN_Click(object sender, EventArgs e)
        {
            ShowCatalog showCatalog = new ShowCatalog();

            Button buttonSender = new Button();
            buttonSender = (Button)sender;

            showCatalog.LoggedInValue = loggedInInput.Text;
            showCatalog.QueryTypeSet = buttonSender.Name;

            showCatalog.Show();
        }


        private void GoToCartBTN_Click(object sender, EventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.UsernameValue = loggedInInput.Text;
            showCart.Show();
        }
    }
}
