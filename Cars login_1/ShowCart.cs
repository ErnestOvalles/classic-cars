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
    public partial class ShowCart : Form
    {
        public ShowCart()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPurchasesBTN_Click(object sender, EventArgs e)
        {
            ShowPurchases showPurchases = new ShowPurchases();
            showPurchases.Show();
            this.Close();
        }
    }
}
