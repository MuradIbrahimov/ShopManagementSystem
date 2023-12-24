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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Shop_Management_System
{
    public partial class Customers : Form
    {
        private readonly Functions Con;
        private DataTable originalDataTable;
        private ErrorProvider errorProvider1 = new ErrorProvider();
      
        public Customers()  
        {
            InitializeComponent();
            Con = new Functions();
            ShowCustomer();

            // Store the original data
            originalDataTable = (DataTable)CustomersList.DataSource;

         
        }

        private void ClearContactFields()
        {
            NameTb.Text = "";
            GenderTb.Text = "";
            PhoneTb.Text = "";
            }

        private void ShowCustomer()
        {
            string Query = "select *  from CustomerTbl";
            CustomersList.DataSource = Con.GetData(Query);
        }

       

        private void EditBtn_Click(object sender, EventArgs e)
        {
            AddorUpdate(NameTb.Text, GenderTb.Text, PhoneTb.Text,  "Update");

        }

        private void AddorUpdate(string Name,string Gender, string Phone, string action)
        {
            try
            {
                // Clear any previous error indicators
                errorProvider.Clear();

                if (string.IsNullOrEmpty(NameTb.Text) || string.IsNullOrEmpty(GenderTb.Text))
                {
                    // Display an error icon and tooltip message for the required fields
                    if (string.IsNullOrEmpty(Name))
                        errorProvider.SetError(NameTb, "Name is required");

                    if (string.IsNullOrEmpty(Phone))
                        errorProvider.SetError(PhoneTb, "Phone Number is required");
                }
                else
                {
                    string query = $"INSERT INTO CustomerTbl (Name, Gender, Phone) VALUES (@Name, @Gender, @Phone)";

                    if (action == "Update")
                    {
                        // Modify the query for an update
                        query = $"UPDATE CustomerTbl SET Phone = @Phone, Gender = @Gender, Name = @Name WHERE Name= @Name";
                    }

                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = Name },
                new SqlParameter("@Gender", SqlDbType.NVarChar, 50) { Value = Gender },
                new SqlParameter("@Phone", SqlDbType.NVarChar, 50) { Value = Phone },
            };

                    Con.SetData(query, parameters);
                    ShowCustomer();

                    MessageBox.Show($"{action} Contact Successfully!");
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
            AddorUpdate(NameTb.Text, GenderTb.Text, PhoneTb.Text, "Insert");
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
                    errorProvider.SetError(NameTb, "Name is required to delete a customer.");
                    return;
                }

                string query = "DELETE FROM CustomerTbl WHERE Name = @Name";

                List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = nameToDelete },
        };

                int rowsAffected = Con.SetData(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully!");
                    ShowCustomer();
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
