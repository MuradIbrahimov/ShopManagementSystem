using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop_Management_System
{
    public partial class Login : Form
    {
        // Connection string for your database
        private string connectionString = @"Data Source=(localDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Shop Management System\Shop Management System\HardwareDb.mdf;Integrated Security=True;Connect Timeout=30";

        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string password = PasswordTb.Text;

            // Validate if the username and password are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check the user credentials in the database
            if (ValidateUser(username, password))
            {
                // Successful login
                MessageBox.Show("Login successful!");
                // Add code here to open your main application form or perform any other actions.
              

                Customers currentForm = new Customers();
                currentForm.Show();

                // Hide the current form
                this.Hide();
            }
            else
            {
                // Failed login
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
