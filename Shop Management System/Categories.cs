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

namespace Shop_Management_System
{
    public partial class Categories : Form
    {
        private readonly Functions Con;
        private DataTable originalDataTable;
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public Categories()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCustomer();

            // Store the original data
            originalDataTable = (DataTable)CategoryList.DataSource;


        }

        private void ClearContactFields()
        {
            NameTb.Text = "";
        }

        private void ShowCustomer()
        {
            string Query = "select *  from CategoryTbl";
            CategoryList.DataSource = Con.GetData(Query);
        }



        private void EditBtn_Click(object sender, EventArgs e)
        {
            AddorUpdate(NameTb.Text, "Update");

        }

        private void AddorUpdate(string Name, string action)
        {
            try
            {
                // Clear any previous error indicators
                errorProvider.Clear();

                if (string.IsNullOrEmpty(NameTb.Text) )
                {
                    // Display an error icon and tooltip message for the required fields
                    if (string.IsNullOrEmpty(Name))
                        errorProvider.SetError(NameTb, "Name is required");

                  
                }
                else
                {
                    string query = $"INSERT INTO CategoryTbl (Name) VALUES (@Name)";

                    if (action == "Update")
                    {
                        // Modify the query for an update
                        query = $"UPDATE CategoryTbl SET Name = @Name WHERE Name= @Name";
                    }

                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = Name }
            };

                    Con.SetData(query, parameters);
                    ShowCustomer();

                    MessageBox.Show($"{action} Category changed Successfully!");
                    ClearContactFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddorUpdate(NameTb.Text, "Insert");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear any previous error indicators
                errorProvider.Clear();

                string nameToDelete = NameTb.Text; // You can change this based on your requirement

                if (string.IsNullOrEmpty(nameToDelete))
                {
                    errorProvider.SetError(NameTb, "Name is required to delete a category.");
                    return;
                }

                string query = "DELETE FROM CategoryTbl WHERE Name = @Name";

                List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = nameToDelete },
        };

                int rowsAffected = Con.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category deleted successfully!");
                    ShowCustomer();
                    ClearContactFields();
                }
                else
                {
                    MessageBox.Show("Category not found or an error occurred during deletion.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            Customers currentForm = new Customers();
            currentForm.Show();

            // Hide the current form
            this.Hide();
        }


        private void BillingPanel_Click(object sender, EventArgs e)
        {
            // Show the Billing form
            Billing currentForm = new Billing();
            currentForm.Show();

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
