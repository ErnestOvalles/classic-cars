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
    public partial class CatalogScreen : Form
    {
        public CatalogScreen()
        {
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
            /*for (int i = 0; i < 15; i++)
            {
                Button buttonNew = new Button();
                buttonNew.Name = "Button" + i;
                buttonNew.Text = "Button" + i;
                buttonNew.Top = (i * 100) + 25;
                buttonNew.Left = 25;
                buttonNew.Width = 75;
                buttonNew.Height = 75;
                this.Controls.Add(buttonNew);

                this.AutoScrollMinSize = new Size(1000, (i * 100) + 100);

            }*/
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
