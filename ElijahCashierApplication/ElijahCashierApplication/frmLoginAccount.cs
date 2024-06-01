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
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            string username = username_textBox.Text;
            string password = password_textBox.Text; 
            Cashier c = new Cashier("Clarisa Castro", "Finance", username, password);
            if(c.validateLogin(username, password))
            {
                MessageBox.Show($"Welcome {c.getFullName()} of {c.getDepartment()}");
                frmPurchaseDiscountedItem frm = new frmPurchaseDiscountedItem();
                frm.Show();
                this.Hide();
            }
        }
    }
}
