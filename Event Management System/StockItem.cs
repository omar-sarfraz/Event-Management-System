using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class StockItem : UserControl
    {
        SqlConnection conn;
        public StockItem()
        {
            conn = Program.Conn();
            InitializeComponent();

            populateDataGrid();
        }

        private void populateDataGrid()
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT stock_item_id,ITEM_NAME,stock_item_quantity,stock_item_description FROM STOCK_ITEM JOIN AVAILABLE_ITEM_LIST ON STOCK_ITEM.stock_item_id = AVAILABLE_ITEM_LIST.ITEM_ID", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0),reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
            }
            conn.Close();
        }

        private void StockItem_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("All fields other than description are required");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO stock_item (stock_item_id, stock_item_quantity, stock_item_description) VALUES (@id, @quantity, @description)", conn);
                    insertCommand.Parameters.AddWithValue("@id", textBox1.Text);
                    insertCommand.Parameters.AddWithValue("@quantity", Int32.Parse(textBox3.Text));
                    insertCommand.Parameters.AddWithValue("@description", textBox4.Text);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");
                    textBox1.Text = String.Empty;
                    textBox3.Text = String.Empty;
                    textBox3.Text = String.Empty;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            conn.Close();

            populateDataGrid();
        }
    }
}
