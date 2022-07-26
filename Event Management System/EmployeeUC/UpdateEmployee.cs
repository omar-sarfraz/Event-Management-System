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

namespace Event_Management_System.EmployeeUC
{
    public partial class UpdateEmployee : UserControl
    {
        SqlConnection conn;
        string ID;
        public UpdateEmployee()
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
            SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT employee_id, employee_fname +' '+ employee_lname AS Name, employee_cnic, employee_type, employee_contact1, employee_date_of_birth, employee_joining_date , employee_wage, employee_housenumber + ' ' + employee_area + ' ' + employee_city AS Address FROM Employee", conn);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                DataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(4), reader.GetString(8), reader.GetInt32(7), reader.GetString(2), reader.GetString(3), reader.GetDateTime(5).ToString("yyyy-MM-dd"), reader.GetDateTime(6).ToString("yyyy-MM-dd"));
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "" || textBox5.Text == "" || textBox9.Text == "" ||
                textBox7.Text == "" || textBox12.Text == "" || textBox10.Text == "" ||
                textBox13.Text == "")
            {
                MessageBox.Show("All fields other than mobile number are required");
            }
            else
            {
                try
                {
                    SqlCommand insertCommand = new SqlCommand("USE event_managment; INSERT INTO EMPLOYEE (employee_id, employee_type, employee_fname, employee_lname, employee_cnic, employee_father_cnic, employee_contact1, employee_contact2, employee_date_of_birth, employee_joining_date, employee_hourlywage, employee_housenumber, employee_area, employee_city) " +
                                                            "VALUES (@id, @type, @fname, @lname, @cnic, @fatherCNIC @contact1, @contact2, @date_of_birth, @joining_date, @hourlywage, @housenumber, @area, @city)", conn);

                    insertCommand.Parameters.AddWithValue("@id", Int32.Parse(textBox1.Text));
                    insertCommand.Parameters.AddWithValue("@type", textBox13.Text);
                    insertCommand.Parameters.AddWithValue("@fname", textBox2.Text);
                    insertCommand.Parameters.AddWithValue("@lname", textBox3.Text);
                    insertCommand.Parameters.AddWithValue("@cnic", textBox12.Text);
                    insertCommand.Parameters.AddWithValue("@fatherCNIC", textBox6.Text);
                    insertCommand.Parameters.AddWithValue("@contact1", textBox4.Text);
                    insertCommand.Parameters.AddWithValue("@contact2", textBox8.Text);
                    insertCommand.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("@joining_date", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("@hourlywage", Int32.Parse(textBox7.Text));
                    insertCommand.Parameters.AddWithValue("@housenumber", textBox5.Text);
                    insertCommand.Parameters.AddWithValue("@area", textBox9.Text);
                    insertCommand.Parameters.AddWithValue("@city", textBox10.Text);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data Added Successfully!");
                    textBox1.Text = String.Empty;
                    textBox13.Text = String.Empty;
                    textBox2.Text = String.Empty;
                    textBox3.Text = String.Empty;
                    textBox12.Text = String.Empty;
                    textBox4.Text = String.Empty;
                    textBox8.Text = String.Empty;
                    textBox7.Text = String.Empty;
                    textBox5.Text = String.Empty;
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

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DataGridView.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();

                conn.Open();
                SqlCommand selectCommand = new SqlCommand("USE event_managment; SELECT employee_id, employee_type, employee_fname, employee_lname, employee_cnic, employee_father_cnic, employee_contact1, employee_contact2, employee_date_of_birth, employee_joining_date, employee_wage, employee_housenumber, employee_area, employee_city FROM EMPLOYEE WHERE employee_id = @ID", conn);
                selectCommand.Parameters.AddWithValue("@ID", ID);
                SqlDataReader reader = selectCommand.ExecuteReader();

                reader.Read();
                textBox1.Text = reader.GetString(0);
                textBox13.Text = reader.GetString(1);
                textBox2.Text = reader.GetString(2);
                textBox3.Text = reader.GetString(3);
                textBox12.Text = reader.GetString(4);
                textBox6.Text = reader.GetString(5);
                textBox4.Text = reader.GetString(6);
                textBox8.Text = reader.GetString(7);
                dateTimePicker1.Value = reader.GetDateTime(8);
                dateTimePicker2.Value = reader.GetDateTime(9);
                textBox7.Text = reader.GetInt32(10).ToString();
                textBox5.Text = reader.GetString(11);
                textBox9.Text = reader.GetString(12);
                textBox10.Text = reader.GetString(13);    

                conn.Close();
            }
            catch (Exception exe)
            {
                conn.Close();
            }

            populateDataGrid();
        }
    }
}
