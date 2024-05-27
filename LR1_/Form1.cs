using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace LR1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void show_items_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.ShowDialog();
        }

        private void show_orders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void show_parts_Click(object sender, EventArgs e)
        {
            Parts parts = new Parts();
            parts.ShowDialog();
        }

        private void show_vendors_Click(object sender, EventArgs e)
        {
            Vendors vendors = new Vendors();
            vendors.ShowDialog();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("÷€ програма створена студентом ... з групи ... “ут можна подивитис€ дан≥ в таблиц€х, модиф≥кувати њх, виконати пошук");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void more_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}
