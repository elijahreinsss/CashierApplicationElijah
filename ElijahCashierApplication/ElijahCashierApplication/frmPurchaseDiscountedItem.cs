using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElijahCashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        double totalAmount = 0;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount frmLoginAccount = new frmLoginAccount();
            frmLoginAccount.Show();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void compute_btn_Click(object sender, EventArgs e)
        {
            string itemName = item_txtbox.Text;
            double price = Convert.ToDouble(price_txtbox.Text);
            double discount = Convert.ToDouble(discount_txtbox.Text) * 0.01; 
            int quantity = Convert.ToInt32(quantity_txtbox.Text);

            double discountedPrice = price * (1 - discount);
            totalAmount = discountedPrice * quantity;

            totalAmount_lbl.Text = totalAmount.ToString();

            
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

            double payment = Convert.ToDouble(payment_txtbox.Text);

            double change = payment - totalAmount;

            change_lbl.Text = change.ToString();
        }
    }
}
