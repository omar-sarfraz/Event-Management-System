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
    public partial class ItemUsed : UserControl
    {
        SqlConnection conn;
        public ItemUsed()
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
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT * FROM item_used", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("All fields other are required");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO item_used (event_id,stock_item_id,used_quantity) " +
                                                             "VALUES (@id,@stock_item_id,@used_quantity)", conn);

                    insertCommand.Parameters.AddWithValue("@id", textBox1.Text);
                    insertCommand.Parameters.AddWithValue("@stock_item_id", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@used_quantity", Int32.Parse(textBox3.Text));

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
