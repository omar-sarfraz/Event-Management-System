using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System.EventUC
{
    public partial class UpdateEvent : UserControl
    {
        SqlConnection conn;
        string ID;
        public UpdateEvent()
        {
            conn = Program.Conn();
            InitializeComponent();
            populateDataGrid();

            dateTimePicker1.CustomFormat = "HH-mm-ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.CustomFormat = "HH-mm-ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.ShowUpDown = true;
        }

        private void populateDataGrid()
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT * FROM EVENTT", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetDateTime(7).ToString("yyyy-MM-dd"), reader.GetTimeSpan(8), reader.GetTimeSpan(9), reader.GetString(10), reader.GetString(11), reader.GetString(1));
            }
            conn.Close();
        }

        private void DataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataGridView.Rows[e.RowIndex];
            ID = row.Cells[0].Value.ToString();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT event_id,customer_id,event_name,event_type,event_expense,event_price_decided,event_advance,event_date,event_start_time,event_end_time,event_venue,venue_city FROM EVENTT WHERE event_id = @ID", conn);
            selectCommand.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = selectCommand.ExecuteReader();

            reader.Read();

            textBox1.Text = reader.GetString(0);
            textBox6.Text = reader.GetString(1);
            textBox2.Text = reader.GetString(2);
            textBox3.Text = reader.GetString(3);
            textBox4.Text = reader.GetInt32(4).ToString();
            textBox5.Text = reader.GetInt32(5).ToString();
            textBox7.Text = reader.GetInt32(6).ToString();
            dateTimePicker3.Value = reader.GetDateTime(7);
            dateTimePicker1.Value.ToString(reader.GetTimeSpan(8).ToString());
            dateTimePicker2.Value.ToString(reader.GetTimeSpan(9).ToString());
            textBox11.Text = reader.GetString(10);
            textBox10.Text = reader.GetString(11);
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                || textBox5.Text == "" || textBox6.Text == ""
                || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; UPDATE EVENTT SET event_id = @eid,customer_id = @cid,event_name = @name,event_type = @type,event_expense = @expense,event_price_decided = @price,event_advance = @price_paid,event_date = @date,event_start_time = @start_time,event_end_time = @end_time,event_venue = @venue,venue_city = @city " +
                                                             " WHERE event_id = @ID", conn);

                    insertCommand.Parameters.AddWithValue("@ID", ID);
                    insertCommand.Parameters.AddWithValue("@eid", textBox1.Text);
                    insertCommand.Parameters.AddWithValue("@cid", textBox6.Text);
                    insertCommand.Parameters.AddWithValue("@name", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@type", textBox3.Text);
                    insertCommand.Parameters.AddWithValue("@expense", Int32.Parse(textBox4.Text));
                    insertCommand.Parameters.AddWithValue("@price", Int32.Parse(textBox5.Text));
                    insertCommand.Parameters.AddWithValue("@price_paid", Int32.Parse(textBox7.Text));
                    insertCommand.Parameters.AddWithValue("@date", dateTimePicker3.Value.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("@start_time", dateTimePicker1.Value.ToString("HH:mm:ss"));
                    insertCommand.Parameters.AddWithValue("@end_time", dateTimePicker2.Value.ToString("HH:mm:ss"));
                    insertCommand.Parameters.AddWithValue("@venue", textBox11.Text);
                    insertCommand.Parameters.AddWithValue("@city", textBox10.Text);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                    textBox3.Text = String.Empty;
                    textBox4.Text = String.Empty;
                    textBox5.Text = String.Empty;
                    textBox6.Text = String.Empty;
                    textBox10.Text = String.Empty;
                    textBox11.Text = String.Empty;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            conn.Close();

            populateDataGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
