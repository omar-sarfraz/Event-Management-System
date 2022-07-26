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

namespace Event_Management_System.UserControls
{
    public partial class Dashboard : UserControl
    {
        SqlConnection conn;
        public Dashboard()
        {
            InitializeComponent();
            conn = Program.Conn();

            populateEventsDataGrid();
            populatePaymentDataGrid();
        }

        private void populateEventsDataGrid()
        {
            EventsDataGridView.Rows.Clear();
            EventsDataGridView.Refresh();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT event_name, customer_fname + ' ' + customer_lname AS customer_name, event_venue, event_start_time, event_end_time FROM EVENTT INNER JOIN customer ON eventt.customer_id = customer.customer_id WHERE event_start_time < CONVERT(TIME, GETDATE()) AND event_end_time > CONVERT(TIME, GETDATE()) AND event_date = CONVERT(DATE, GETDATE())", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                EventsDataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetTimeSpan(3), reader.GetTimeSpan(4));
            }
            conn.Close();
        }

        private void populateDataGridView1()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("use event_managment; execute EventsPresent @from= @START , @till = @END;", conn);
            selectCommand.Parameters.AddWithValue("@START", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            selectCommand.Parameters.AddWithValue("@END", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
          
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(0), reader.GetDateTime(1));
            }

            conn.Close();

        }
        private void populateDataGridView2()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("use event_managment; execute CustomersPresent @from= @START , @till = @END;", conn);
            selectCommand.Parameters.AddWithValue("@START", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            selectCommand.Parameters.AddWithValue("@END", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(0), reader.GetDateTime(1));
            }

            conn.Close();

        }

        private void populatePaymentDataGrid()
        {
            PaymentDataGridView.Rows.Clear();
            PaymentDataGridView.Refresh();

            conn.Open();
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT event_name, customer_fname + ' ' + customer_lname AS customer_name, event_date, (event_price_decided - event_advance) AS PendingAmount FROM EVENTT INNER JOIN customer ON eventt.customer_id = customer.customer_id WHERE event_advance < event_price_decided", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                PaymentDataGridView.Rows.Add(reader.GetString(1), reader.GetString(0), reader.GetDateTime(2).ToString("yyyy-MM-dd"), reader.GetInt32(3));
            }
            conn.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            profit();
        }

        private void profit()
        {
            conn.Open();
            SqlCommand selectCommand = new SqlCommand("use event_managment; SELECT (SUM(EVENTT.event_price_decided) - SUM(EVENTT.event_expense)) FROM EVENTT WHERE EVENTT.event_date BETWEEN '2022-11-01' AND '2022-11-30';", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();
            reader.Read();

            Profit.Text = reader.GetInt32(0).ToString();
            conn.Close();
        }

        private void Profit_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (customers.Checked)
            {
                populateDataGridView2();
            } else
            {
                populateDataGridView1();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            populateDataGridView2();

        }

        private void Events_CheckedChanged(object sender, EventArgs e)
        {
            populateDataGridView1();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
