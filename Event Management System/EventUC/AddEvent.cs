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
    public partial class AddEvent : UserControl
    {
        SqlConnection conn;
        public AddEvent()
        {
            InitializeComponent();
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
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO EVENTT (event_id,customer_id,event_name,event_type,event_expense,event_price_decided,event_advance,event_date,event_start_time,event_end_time,event_venue,venue_city) VALUES " +
                                                             "(@eid,@cid,@name,@type,@expense,@price,@price_paid,@date,@start_time,@end_time,@venue,@city)", conn);
                    
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

        private void Event_Load(object sender, EventArgs e)
        {
            conn = Program.Conn();

            dateTimePicker1.CustomFormat = "HH-mm-ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.CustomFormat = "HH-mm-ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.ShowUpDown = true;

            populateDataGrid();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
