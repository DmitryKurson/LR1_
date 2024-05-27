using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LR1_
{
    public partial class Items : Form
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=supply__;Trusted_Connection=True;";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Items()
        {    
            InitializeComponent();
        }

        private void LoadData()
        {
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM dbo.Items";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No data found in Items table.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Items_Load(object sender, EventArgs e)
        {      
            LoadData();
            dataGridView1.Columns["ItemID"].HeaderText = "Номер";
            dataGridView1.Columns["OrderID"].HeaderText = "Номер замовлення";
            dataGridView1.Columns["PartID"].HeaderText = "Номер частини";
            dataGridView1.Columns["Quantity"].HeaderText = "Кількість";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            SearchData(searchTerm);
        }

        private void SearchData(string searchTerm)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                try
                {
                    DataRow[] foundRows = dataTable.Select($"ItemID = '{searchTerm}'");
                    if (foundRows.Length > 0)
                    {
                        DataTable searchResult = foundRows.CopyToDataTable();
                        dataGridView1.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No matching data found.");
                    }
                }
                catch
                {

                }
                
            }
            else
            {
                MessageBox.Show("No data loaded.");
            }
        }

        private void UpdateData()
        {
            try
            {
                if (dataTable != null)
                {
                    dataAdapter.Update(dataTable);
                    MessageBox.Show("Data updated successfully.");
                }
                else
                {
                    MessageBox.Show("No data loaded to update.");
                }
            }
            catch (Exception ex)
            {
                LoadData();
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                int rowIndex = Convert.ToInt32(txtSearch.Text) - 1;
                if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                {
                    int currentQuantity = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Quantity"].Value);
                    int newQuantity = currentQuantity + 1;
                    dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = newQuantity;
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Invalid row index.");
                }
            }
            else
            {
                MessageBox.Show("Please enter row index.");
            }
        }
    }
}
