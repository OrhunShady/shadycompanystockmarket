using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace _20200305026
{
    public partial class currentstockcs : Form
    {
        private DataTable dataTable;
        private List<Product> productList;

        public currentstockcs()
        {
            InitializeComponent();
            ConnectToDatabase();
            LoadDataIntoDataGridView();
        }

        private void ConnectToDatabase()
        {
            string connectionString = "Server=localhost;Database=stockmarketc;Uid=root;Pwd=;";
            productList = new List<Product>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT  UnitNumber, Name, Price, Date, Quantıty FROM products";

                using (var cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string unitNumber = reader["UnitNumber"].ToString();
                            string name = reader["Name"].ToString();
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            string date = reader["Date"].ToString(); 
                            int quantity = Convert.ToInt32(reader["Quantıty"]);

                            Product product = new Product(name, unitNumber, price, date, quantity); 
                            productList.Add(product);
                        }
                    }
                }
            }
        }

        private void LoadDataIntoDataGridView()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("UnitNumber");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Quantıty");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            foreach (var product in productList)
            {
                dataTable.Rows.Add(product.Name, product.UnitNumber, product.Price, product.Date, product.Quantity); 
            }

            dataGridView1.DataSource = dataTable;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Product
    {
        public string UnitNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Date { get; set; } 
        public int Quantity { get; set; }

        public Product(string unitNumber, string name, decimal price, string date, int quantity) 
        {
            UnitNumber = unitNumber;
            Name = name;
            Price = price;
            Date = date;
            Quantity = quantity;
        }
    }
}
