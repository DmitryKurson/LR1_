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

namespace LR1_
{
    public partial class Vendors : Form
    {
        public Vendors()
        {
            InitializeComponent();
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView2.Columns["VendorID"].HeaderText = "Номер постачальника";
            dataGridView2.Columns["VendorName"].HeaderText = "Назва деталі";
            dataGridView2.Columns["ContactName"].HeaderText = "Назва постачальника";
            dataGridView2.Columns["ContactPhone"].HeaderText = "Телефон постачальника";
            
        }

        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=supply__;Trusted_Connection=True;";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM dbo.Vendors";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No data found in Orders table.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                    DataRow[] foundRows = dataTable.Select($"VendorID = '{searchTerm}'");
                    if (foundRows.Length > 0)
                    {
                        DataTable searchResult = foundRows.CopyToDataTable();
                        dataGridView2.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No matching data found.");
                    }
                }
                catch
                {
                    LoadData();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                int rowIndex = Convert.ToInt32(txtSearch.Text) - 1;
                if (rowIndex >= 0 && rowIndex < dataGridView2.Rows.Count)
                {
                    string current = dataGridView2.Rows[rowIndex].Cells["VendorID"].Value.ToString();
                    string newValue = current + "1";
                    dataGridView2.Rows[rowIndex].Cells["VendorID"].Value = newValue;
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
