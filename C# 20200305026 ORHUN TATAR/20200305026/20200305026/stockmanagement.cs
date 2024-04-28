using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace _20200305026
{
    public partial class stockmanagement : Form

    {
        private string connectionString = "Server=localhost;Database=stockmarketc;Uid=root;Pwd=;";


        public stockmanagement()
        {
            InitializeComponent();
            UpdateData();
        }
        private void UpdateData()
        {
            string selectQuery = "SELECT UnitNumber, Name, Price, Quantıty,Date FROM Products";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            dataGridView1.Columns["UnitNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView1.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            dataGridView1.Columns["Quantıty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textunit_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitlabel_Click(object sender, EventArgs e)
        {

        }

        private void textprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            string unitNumberToUpdate = dataGridView1.SelectedRows[0].Cells["UnitNumber"].Value.ToString();
            string name = textname.Text;
            string unit = textunit.Text;
            string price = textprice.Text;
            string date = textdate.Text;
            string quantity = textquantity.Text;

            string updateQuery = "UPDATE Products SET Name = @Name, Price = @Price, Date = @Date, Quantıty = @Quantıty WHERE UnitNumber = @UnitNumber";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Quantıty", quantity);
                        cmd.Parameters.AddWithValue("@UnitNumber", unitNumberToUpdate);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully.");

                            UpdateData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string unitNumber = dataGridView1.SelectedRows[0].Cells["UnitNumber"].Value.ToString();


            string deleteQuery = "DELETE FROM Products WHERE UnitNumber = @UnitNumber";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UnitNumber", unitNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully.");

                            UpdateData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void sortbutton_Click(object sender, EventArgs e)
        {

        }

        private void searchlabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textname.Text) ||
                string.IsNullOrWhiteSpace(textunit.Text) ||
                string.IsNullOrWhiteSpace(textprice.Text) ||
                string.IsNullOrWhiteSpace(textdate.Text) ||
                string.IsNullOrWhiteSpace(textquantity.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string name = textname.Text;
            string unit = textunit.Text;
            string price = textprice.Text;
            string date = textdate.Text;
            string quantity = textquantity.Text;

            string checkExistenceQuery = "SELECT COUNT(*) FROM Products WHERE UnitNumber = @UnitNumber";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(checkExistenceQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UnitNumber", unit);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("An entry with the same UnitNumber already exists. Please enter a different UnitNumber.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Products (Name, UnitNumber, Price, Date, Quantıty) VALUES (@Name, @UnitNumber, @Price, @Date, @Quantıty)";
                    using (var cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@UnitNumber", unit);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Quantıty", quantity);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully.");

                            UpdateData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void clearbutton_Click(object sender, EventArgs e)
        {
            textname.Text = "";
            textunit.Text = "";
            textprice.Text = "";
            textdate.Text = "";
            textquantity.Text = "";
            textsearch.Text = "";
        }

        private void textquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantitylabel_Click(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
        }

        private void searchbutton_Click_1(object sender, EventArgs e)
        {
            string unitNumberToSearch = textsearch.Text;

            if (string.IsNullOrWhiteSpace(unitNumberToSearch))
            {
                MessageBox.Show("Please enter a Unit Number to search.");
                return;
            }

            string selectQuery = "SELECT Name, UnitNumber, Price, Date, Quantıty FROM Products WHERE UnitNumber = @UnitNumber";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UnitNumber", unitNumberToSearch);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textname.Text = reader["Name"].ToString();
                                textunit.Text = reader["UnitNumber"].ToString();
                                textprice.Text = reader["Price"].ToString();
                                textdate.Text = reader["Date"].ToString();
                                textquantity.Text = reader["Quantıty"].ToString();


                                SelectRowByUnitNumber(unitNumberToSearch);
                            }
                            else
                            {
                                MessageBox.Show("Product with the specified Unit Number not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void SelectRowByUnitNumber(string unitNumber)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["UnitNumber"].Value.ToString() == unitNumber)
                {
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void sortbutton_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["UnitNumber"], ListSortDirection.Ascending);
        }
    }
}
