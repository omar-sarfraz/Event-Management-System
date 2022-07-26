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

namespace Event_Management_System
{
    public partial class SuppliedItemsReceipt : UserControl
    {
        SqlConnection conn;
        public SuppliedItemsReceipt()
        {
            InitializeComponent();
            conn = Program.Conn();

            populateDataGrid();
        }

        private void populateDataGrid()
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT * FROM SUPPLIED_ITEM_VIEW", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetDateTime(9).ToString("yyyy-MM-dd"));
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                try
                {

                    SqlCommand selectItem = new SqlCommand("USE event_managment; SELECT unit_price from AVAILABLE_ITEM_LIST WHERE item_id = " + "\'" + textBox2.Text + "\'", conn);
                    SqlDataReader reader = selectItem.ExecuteReader();
                    reader.Read();
                    int unit_price = reader.GetInt32(0);
                    int total_amount = unit_price * Int32.Parse(textBox4.Text);
                    conn.Close();
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO SUPPLIED_ITEM_RECEIPT (item_id,supplier_id,supplied_item_quantity,given_amount,supplied_date,TOTAL_AMOUNT) VALUES (@i_id,@sid,@quantity,@price,@date,@total);" , conn);
                    insertCommand.Parameters.AddWithValue("@i_id", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@sid", textBox1.Text);
                    insertCommand.Parameters.AddWithValue("@quantity", Int32.Parse(textBox4.Text));
                    insertCommand.Parameters.AddWithValue("@price", Int32.Parse(textBox5.Text));
                    insertCommand.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("@total", total_amount);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                    textBox4.Text = String.Empty;
                    textBox5.Text = String.Empty;
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
