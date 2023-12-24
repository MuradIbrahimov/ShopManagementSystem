using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management_System
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }


        private void CategoriesPanel_Click(object sender, EventArgs e)
        {
            // Show the Billing form
            Categories currentForm = new Categories();
            currentForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void CustomerPanel_Click(object sender, EventArgs e)
        {
            // Show the Billing form
            Customers current = new Customers();
            current.Show();

            // Hide the current form
            this.Hide();
        }


        private void BillingPanel_Click(object sender, EventArgs e)
        {
            // Show the Billing form
            Billing current = new Billing();
            current.Show();

            // Hide the current form
            this.Hide();
        }

        private void ItemsPanel_Click(object sender, EventArgs e)
        {
            Items currentForm = new Items();
            currentForm.Show();

            // Hide the current form
            this.Hide();
        }


    }
}
