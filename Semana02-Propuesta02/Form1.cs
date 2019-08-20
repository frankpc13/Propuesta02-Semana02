using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Semana02_Propuesta02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["kotoha"].ConnectionString);

        public void LoadOrders()
        {
            using (SqlCommand command = new SqlCommand("usp_orders_list", connection))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = command;
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "orders");
                        dataGridOrders.DataSource = dataSet.Tables["orders"];
                        labelTotalOrders.Text = dataSet.Tables["orders"].Rows.Count.ToString();
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void dataGridOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int codigo = Convert.ToInt32(dataGridOrders.CurrentRow.Cells[0].Value);
            using (SqlCommand command = new SqlCommand("usp_product_by_order_detail_id", connection))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    dataAdapter.SelectCommand = command;
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@orderId", codigo);
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "products");
                        dataGridOrderDetail.DataSource = dataSet.Tables["products"];
                        labelTotalProducts.Text = dataSet.Tables["products"].Rows.Count.ToString();
                    }
                }
            }
        }
    }
}
