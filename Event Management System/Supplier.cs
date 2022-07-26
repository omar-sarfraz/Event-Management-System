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
    public partial class Supplier : UserControl
    {
        SqlConnection conn;
        public Supplier()
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
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT supplier_id, supplier_fname+' '+supplier_lname AS Name, supplier_number, shop_name, street_no + ' ' + supplier_area + ' ' + supplier_city AS Address FROM supplier", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetString(4));
            }
            conn.Close();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                 || textBox6.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("All fields other than shop name are required");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO supplier (supplier_id,supplier_fname,supplier_lname,shop_name,street_no,supplier_number,supplier_area,supplier_city) VALUES " +
                                                             "(@id,@fname,@lname,@sname,@street_no,@number,@area,@city)", conn);

                    insertCommand.Parameters.AddWithValue("id", textBox1.Text);
                    insertCommand.Parameters.AddWithValue("@fname", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@lname", textBox3.Text);
                    insertCommand.Parameters.AddWithValue("@sname", textBox5.Text);
                    insertCommand.Parameters.AddWithValue("@street_no", textBox6.Text);
                    insertCommand.Parameters.AddWithValue("@number", textBox4.Text);
                    insertCommand.Parameters.AddWithValue("@area", textBox9.Text);
                    insertCommand.Parameters.AddWithValue("@city", textBox10.Text);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                    textBox3.Text = String.Empty;
                    textBox4.Text = String.Empty;
                    textBox5.Text = String.Empty;
                    textBox6.Text = String.Empty;
                    textBox9.Text = String.Empty;
                    textBox10.Text = String.Empty;

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
