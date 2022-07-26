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
    public partial class AvailibleItemsList : UserControl
    {
        SqlConnection conn;
        public AvailibleItemsList()
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
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT * FROM available_item_list", conn);
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
            if (textBox7.Text == "" || textBox12.Text == "" || textBox13.Text == "")
            {
                MessageBox.Show("All fields except are required");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO available_item_list (item_id,item_name, unit_price) VALUES (@id, @itemN,@price)", conn);
                    insertCommand.Parameters.AddWithValue("@itemN", textBox7.Text);
                    insertCommand.Parameters.AddWithValue("@id", textBox12.Text);
                    insertCommand.Parameters.AddWithValue("@price", Int32.Parse(textBox13.Text));                   

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");                    
                    textBox7.Text = String.Empty;
                    textBox12.Text = String.Empty;
                    textBox13.Text = String.Empty;
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
