using System;
using System.Windows.Forms;
using MySqlConnector;

namespace _20200305026
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();

            loginbutton.Click += loginbutton_Click;
            buttonexit.Click += buttonexit_Click;
            txtpassword.PasswordChar = '*';
        }

        private void InitializeDatabase()
        {
            string conUrl = "Server=localhost;User ID=root;Password=;Database=stockmarketc";
            connection = new MySqlConnection(conUrl);
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM login WHERE Username=@username AND Password=@password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    long? result = (long?)command.ExecuteScalar();
                    if (result > 0)
                    {
                        this.Hide();
                        menü menuForm = new menü();
                        menuForm.ShowDialog(this);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("The Username or Password is Incorrect!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        



        private void buttonexit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
