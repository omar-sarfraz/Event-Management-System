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
    public partial class Customers : UserControl
    {
        SqlConnection conn;
        public Customers()
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
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT customer_id, customer_fname+' '+customer_lname AS Name, customer_contact, customer_housenumber + ' ' + customer_area + ' ' + customer_city AS Address FROM Customer", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }
            conn.Close();
        }

        private void CustomerNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("All fields other than address are required");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO customer (customer_id,customer_fname,customer_lname,customer_contact,customer_housenumber, customer_area, customer_city) VALUES (@id,@fname,@lname,@contact,@housenumber, @area, @city)", conn);
                    insertCommand.Parameters.AddWithValue("@id", textBox1.Text);                    
                    insertCommand.Parameters.AddWithValue("@fname", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@lname", textBox3.Text);
                    insertCommand.Parameters.AddWithValue("@contact", textBox4.Text);
                    insertCommand.Parameters.AddWithValue("@housenumber", textBox5.Text);
                    insertCommand.Parameters.AddWithValue("@area", textBox6.Text);
                    insertCommand.Parameters.AddWithValue("@city", textBox7.Text);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                    textBox3.Text = String.Empty;
                    textBox4.Text = String.Empty;
                    textBox5.Text = String.Empty;
                    textBox6.Text = String.Empty;
                    textBox7.Text = String.Empty;

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
