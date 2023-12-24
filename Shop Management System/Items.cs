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
    public partial class Items : Form
    {
        private readonly Functions Con;
        private DataTable originalDataTable;
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public Items()
        {
            InitializeComponent();
            Con = new Functions();
            ShowItems();

            // Store the original data
            originalDataTable = (DataTable)ItemList.DataSource;
        }

        private void ClearContactFields()
        {
            ItemTb.Text = "";
            CategoryTb.Text = "";
            PriceTb.Text = "";
            StockTb.Text = "";
            ManufacturerTb.Text = "";
        
        }

        private void ShowItems()
        {
            string Query = "select *  from Items";
            ItemList.DataSource = Con.GetData(Query);
        }



        private void EditBtn_Click(object sender, EventArgs e)
        {
            AddorUpdate(ItemTb.Text, CategoryTb.Text, PriceTb.Text, StockTb.Text, ManufacturerTb.Text, "Update");

        }

        private void AddorUpdate(string Name, string Category, string Price, string Stock , string Manufacturer,  string action)
        {
            try
            {
                // Clear any previous error indicators
                errorProvider.Clear();

                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Category) || string.IsNullOrEmpty(Price) || string.IsNullOrEmpty(Stock) || string.IsNullOrEmpty(Manufacturer))
                {
                    // Display an error icon and tooltip message for the required fields
                    if (string.IsNullOrEmpty(Name))
                        errorProvider.SetError(ItemTb, "Name is required");
                    if (string.IsNullOrEmpty(Category))
                        errorProvider.SetError(CategoryTb, "Category is required");
                    if (string.IsNullOrEmpty(Price))
                        errorProvider.SetError(PriceTb, "Price is required");
                    if (string.IsNullOrEmpty(Stock))
                        errorProvider.SetError(StockTb, "Stock is required");
                    if (string.IsNullOrEmpty(Manufacturer))
                        errorProvider.SetError(ManufacturerTb, "Manufacturer is required");
                }
                else
                {
                    string query = $"INSERT INTO Items (Name, Category, Price, Stock, Manufacturer) VALUES (@Name, @Category, @Price, @Stock, @Manufacturer)";

                    if (action == "Update")
                    {
                        // Modify the query for an update
                        query = $"UPDATE Items SET Category = @Category, Price = @Price, Stock = @Stock, Manufacturer = @Manufacturer WHERE Name = @Name";
                    }

                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = Name },
                new SqlParameter("@Category", SqlDbType.NVarChar, 50) { Value = Category },
                new SqlParameter("@Price", SqlDbType.NVarChar, 50) { Value = Price },
                new SqlParameter("@Stock", SqlDbType.NVarChar, 50) { Value = Stock },
                new SqlParameter("@Manufacturer", SqlDbType.NVarChar, 50) { Value = Manufacturer },
            };

                    Con.SetData(query, parameters);
                    ShowItems();

                    MessageBox.Show($"{action} Item Successfully!");
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
            AddorUpdate(ItemTb.Text, CategoryTb.Text, PriceTb.Text, StockTb.Text, ManufacturerTb.Text, "Insert");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear any previous error indicators
                errorProvider.Clear();

                string nameToDelete = ItemTb.Text; // You can change this based on your requirement

                if (string.IsNullOrEmpty(nameToDelete))
                {
                    errorProvider.SetError(ItemTb, "Name is required to delete a customer.");
                    return;
                }

                string query = "DELETE FROM Items WHERE Name = @Name";

                List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = nameToDelete },
        };

                int rowsAffected = Con.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully!");
                    ShowItems();
                    ClearContactFields();
                }
                else
                {
                    MessageBox.Show("Customer not found or an error occurred during deletion.");
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
